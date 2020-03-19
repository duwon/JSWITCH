using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JangSwitch
{
    public partial class Fire : Form
    {
        public Fire(string[] args)
        {
            InitializeComponent();
        }

        private void Fire_Load(object sender, EventArgs e)
        {
            OpenSerialPort();

            Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1초
            timer.Tick += new EventHandler(timer_1s_handler);
            timer.Start();

            //byte[] testLEDData = { 0xf0, 0x00, 0x00, 0x00 };
            //SaveLEDStatus(testLEDData);

        }

        bool[] 발사LED점멸상태 = new bool[8];
        private void timer_1s_handler(object sender, EventArgs e)
        {
            Button[] btn_led = { button9, button_LED1, button_LED2, button_LED3, button_LED4, button_LED5, button_LED6, button_LED7 };
            for (int i = 0; i < 8; i++)
            {
                //발사LED상태[i] = 0x01;
                if ((발사LED상태[i] == 0x01) && (발사LED점멸상태[i] == true))
                {
                    btn_led[i].Image = JangSwitch.Properties.Resources.btn_yellow;
                    발사LED점멸상태[i] = false;
                }
                else if ((발사LED상태[i] == 0x01) && (발사LED점멸상태[i] == false))
                {
                    btn_led[i].Image = JangSwitch.Properties.Resources.btn_default;
                    발사LED점멸상태[i] = true;
                }
            }
        }

        private void OpenSerialPort()
        {
            try
            {
                // serialPort가 null 일때만 새로운 SerialPort Open
                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = "COM3";
                    serialPort.BaudRate = 115200;

                    serialPort.RtsEnable = true;
                    serialPort.Open();
                    RefreshViewControl(true);
                    PrintDebug("OPEN " + serialPort.PortName);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseSerialPort()
        {
            // serialPort가 null 아닐때만 Close 
            if (null != serialPort)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    RefreshViewControl(false);
                    PrintDebug("CLOSE " + serialPort.PortName);
                }
            }
        }

        private void RefreshViewControl(bool openPortState)
        {
            if (openPortState)
                button_comLED.Image = Properties.Resources.led_on;
            else
                button_comLED.Image = Properties.Resources.led_off;
        }

        private void PrintDebug(string message)
        {
            textBox_Debug.AppendText(message + "\r\n");
        }

        Message RxMessage = new Message();
        System.Collections.Concurrent.ConcurrentQueue<byte> rxBuffer = new System.Collections.Concurrent.ConcurrentQueue<byte>();
        
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                int iRecievedSize = serialPort.BytesToRead; //수신 데이터 갯수
                if (iRecievedSize != 0)
                {
                    byte[] rxPacketBuff = new byte[50];
                    try
                    {
                        serialPort.Read(rxPacketBuff, 0, iRecievedSize);
                        for (int i = 0; i < iRecievedSize; i++)
                        {
                            rxBuffer.Enqueue(rxPacketBuff[i]);
                        }
                        ProcessMessage();
                    }
                    catch
                    { /* 없음 */
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message); 
                PrintDebug("수신된 Data 없음");
            }
        }
        private void ProcessMessage()
        {
            while ((rxBuffer.Count != 0) || (RxMessage.nextStage == (byte)Stage.PARSING) || (RxMessage.nextStage == (byte)Stage.CHECKSUM))
            {
                switch (RxMessage.nextStage)
                {
                    case (byte)Stage.START:
                        {

                            byte _tch;
                            for (int i = 0; i < rxBuffer.Count; i++)
                            {
                                rxBuffer.TryDequeue(out _tch);
                                if (_tch == (byte)Packet.STX)
                                {
                                    RxMessage.startFlag++;
                                }
                                if (RxMessage.startFlag == 4)
                                {
                                    RxMessage.startFlag = 0;
                                    RxMessage.nextStage = (byte)Stage.MESSAGETYPE;
                                    RxMessage.data[0] = (byte)Packet.STX;
                                    RxMessage.data[1] = (byte)Packet.STX;
                                    RxMessage.data[2] = (byte)Packet.STX;
                                    RxMessage.data[3] = (byte)Packet.STX;
                                    break;
                                }
                            }
                            break;
                        }
                    case (byte)Stage.LENGTH:
                        {
                            rxBuffer.TryDequeue(out RxMessage.data[4]);
                            RxMessage.length = RxMessage.data[4];                   /* 패킷 길이 저장 */
                            
                            if (RxMessage.length > 40) RxMessage.length = 10;       /* 40바이트 이상이면 패킷 길이는 10으로 설정 */
                            if (RxMessage.length == 0)
                            {
                                RxMessage.nextStage = (byte)Stage.START;
                                break;
                            }
                            RxMessage.datasize = (byte)(RxMessage.length - (byte)Packet.HEADER_LENGTH);      /* 5Byte(STX 및 LENGTH)을 제외한 MSG DATA 크기 할당 */

                            RxMessage.nextStage = (byte)Stage.SRCID;
                            break;
                        }
                    case (byte)Stage.SRCID:
                        {
                            rxBuffer.TryDequeue(out RxMessage.data[5]);
                            RxMessage.srcID = RxMessage.data[5];                    /* 송신 ID 저장 */

                            RxMessage.nextStage = (byte)Stage.DESTID;
                            break;
                        }
                    case (byte)Stage.DESTID:
                        {
                            rxBuffer.TryDequeue(out RxMessage.data[6]);
                            RxMessage.destID = RxMessage.data[6];                   /* 수신 ID 저장 */

                            if (RxMessage.destID == (byte)Packet.FIRE_ID)           /* 발사스위치단 수신ID면 데이터 수신 */
                            {
                                RxMessage.nextStage = (byte)Stage.MESSAGETYPE;
                                break;
                            }
                            else
                            {
                                RxMessage.nextStage = (byte)Stage.START;
                            }

                            break;
                        }
                    case (byte)Stage.MESSAGETYPE:
                        {
                            rxBuffer.TryDequeue(out RxMessage.data[7]);
                            RxMessage.type = RxMessage.data[7];                   /* 명령어 저장 */

                            RxMessage.nextStage = (byte)Stage.DATA;
                            break;
                        }
                    case (byte)Stage.DATA:
                        {
                            rxBuffer.TryDequeue(out RxMessage.data[RxMessage.dataCount + 8]);
                            RxMessage.dataCount++;

                            if (RxMessage.dataCount == RxMessage.datasize)
                            {
                                RxMessage.dataCount = 0;
                                if (RxMessage.data[RxMessage.length - 1] == (byte)Packet.ETX)       /* 메시지 끝 바이트가 ETX로 끝나면 */
                                {
                                    RxMessage.checksum = RxMessage.data[RxMessage.length - 2];      /* 체크섬 값을 프레임의 체크섬 변수에 저장하고 */
                                    RxMessage.nextStage = (byte)Stage.CHECKSUM;                     /* CHECKSUM 단계로 넘어가기 */
                                }
                                else                                                                /* 메시지 끝 바이트가 ETX가 아니면 */
                                {
                                    RxMessage.nextStage = (byte)Stage.START;                        /* START 단계로 돌아가기 */
                                }
                            }
                            break;

                        }
                    case (byte)Stage.CHECKSUM:
                        {
                            if (RxMessage.checksum == Cal_CRC(RxMessage.data))                     /* 체크섬 값이 정상이면 */
                            {
                                RxMessage.nextStage = (byte)Stage.PARSING;          /* Parsing 단계로 넘어가기 */
                            }
                            else                                                    /* 체크섬 값이 정상이 아니면 */
                            {
                                RxMessage.nextStage = (byte)Stage.START;            /* START 단계로 돌아가기 */
                            }
                            break;
                        }
                    case (byte)Stage.PARSING:
                        {
                            //ParsingMessage();
                            RxMessage.nextStage = (byte)Stage.START;
                            break;
                        }
                    case (byte)Stage.END:
                        {
                            break;
                        }
                    default:
                        break;

                }
            }

        }
        
        private byte Cal_CRC(byte[] messageData)
        {
            byte calChecksum = 0;

            for (int i = 4; i < messageData.Length - 2; i++)           /* Length(4번째 바이트)에서 체크섬 앞 바이트까지 더하기 */
            {
                calChecksum += messageData[i];
            }
            calChecksum = (byte)(~calChecksum + 0x01);            /* 체크섬 계산식 : ~(Lenghth + Transmit ID + Receive ID + Command + Data) + 1 */

            return calChecksum;
        }

        byte[] 발사LED상태 = new byte[8];
        private void SaveLEDStatus(byte[] LEDData)
        {
            /* 점멸 1, 점등, 소등 8 을 각 스위치별로 통합하여 발사LED상태에 저장 */
            for(int i=0; i<4; i++)
            {
                for(int shiftCnt = 0; shiftCnt < 8; shiftCnt++)
                {
                    if(((LEDData[i] >> shiftCnt) & 0x01) == 0x01)
                    {
                        발사LED상태[shiftCnt] = (byte)(1 << i);
                    }
                }
            }
            ControlLED(); /* LED 갱신 제어 */
        }

        private void ControlLED()
        {
            Button[] btn_led = { button9, button_LED1, button_LED2, button_LED3, button_LED4, button_LED5, button_LED6, button_LED7 };
            for(int i=0; i<8; i++)
            {
                if(발사LED상태[i] == 0x8) /* 끔 */
                {
                    btn_led[i].Image = JangSwitch.Properties.Resources.btn_default;
                }
                else if(발사LED상태[i] == 0x4) /* 어두운황색 점등 */
                {
                    btn_led[i].Image = JangSwitch.Properties.Resources.btn_orange;
                }
                else if (발사LED상태[i] == 0x2) /* 밝은황색 점등 */
                {
                    btn_led[i].Image = JangSwitch.Properties.Resources.btn_yellow;
                }
                else if (발사LED상태[i] == 0x1) /* 밝은황색 점멸 */
                {
                    /* 1초 타이머(timer_1s_handler)에서 처리 */
                }
            }

        }

        bool [] button_keystate = { true, true, true };
        private void btn_key_click(object sender, MouseEventArgs e)
        {

            Button[] btn_key = { button_key1, button_key2, button_key3};
            for (int index = 0; index < 3; index++)
            {
                if (sender.Equals(btn_key[index]) == true)
                {
                    if(button_keystate[index] == true)
                    { 
                        btn_key[index].Image = JangSwitch.Properties.Resources.key_2;
                        button_keystate[index] = false;
                    }
                    else
                    {
                        btn_key[index].Image = JangSwitch.Properties.Resources.key_1;
                        button_keystate[index] = true;
                    }
                }
            }
        }

        private void button_comLED_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
                CloseSerialPort();
            else
                OpenSerialPort();
        }

        bool button_state = true;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (button_state == true)
            {
                button_LED4.Image = Properties.Resources.btn_orange;
                button_state = false;
            }
            else
            {
                button_LED4.Image = Properties.Resources.btn_yellow;
                button_state = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
