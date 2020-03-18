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

        }

        private void timer_1s_handler(object sender, EventArgs e)
        {

        }

        private void OpenSerialPort()
        {
            try
            {
                // serialPort가 null 일때만 새로운 SerialPort Open
                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = "COM3";
                    serialPort.BaudRate = 9600;

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
                    { }
                }
            }
            catch (System.Exception)
            { }
        }

        static void ProcessMessage()
        {

        }

        bool button_state = true;
        private void Button1_Click(object sender, MouseEventArgs e)
        {

            if (button_state == true)
            {
                button1.Image = Properties.Resources.btn_red;
                button_state = false;
            }
            else
            {
                button1.Image = Properties.Resources.btn_green;
                button_state = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

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

    }
}
