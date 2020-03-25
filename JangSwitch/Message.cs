using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JangSwitch
{
    enum Stage : byte
    {
        START = 0,
        LENGTH = 1,
        TRX_ID = 2,
        MESSAGETYPE = 3,
        DATA = 4,
        PARSING = 5,
        CHECKSUM = 6,
        SEND = 7,
        RESEND = 8,
        STOP = 9,
        WRITE = 10,
        END = 11,
        SRCID = 12,
        DESTID = 13
    };

    enum Packet : byte 
    { 
        STX = 0x7E, 
        ETX = 0x7F, 
        CHECKSUM = 0x00, 
        DATA = 0x00,
        MAX_LENGTH = 0xF0,
        ERROR = 0x00,
        SUCCESS = 0x01,
        DEST_ID = 0x04,
        FIRE_ID = 0x09,
        FUNC_ID = 0x08,
        HEADER_LENGTH = 5
    };

    enum LEDState : byte
    {
        기만기 = 1,
        수중허가 = 2,
        수평발사 = 3,
        발사명령 = 4,
        발사인가 = 5,
        MAS = 6,
        AOS = 7
    }

    public struct Message
    {
        public byte nextStage;
        public byte type;
        public byte length;
        public byte datasize;
        public byte dataCount;
        public byte checksum;
        public byte startFlag;
        public byte destID;
        public byte srcID;
        public byte[] data;

        public Message(byte[] data)
        {
            this.nextStage = 0;
            this.type = 0;
            this.length = 0;
            this.datasize = 0;
            this.checksum = 0;
            this.data = data;
            dataCount = 0;
            startFlag = 0;
            srcID = 0;
            destID = 0;
        }

        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Message left, Message right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Message left, Message right)
        {
            return !(left == right);
        }
    }
}
