using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Samples
{
    public class Color
    {
        public byte Red { get; private set; }
        public byte Blue { get; private set; }
        public byte Green { get; private set; }

        public string Hex
        {
            get
            {
                string converted = "#";
                converted += ToHexDigit((byte)(Red / _Base16))
                           + ToHexDigit((byte)(Red % _Base16));
                converted += ToHexDigit((byte)(Blue / _Base16))
                           + ToHexDigit((byte)(Blue % _Base16));
                converted += ToHexDigit((byte)(Green / _Base16))
                           + ToHexDigit((byte)(Green % _Base16));
                return converted;
            }
        }

        private static byte _Base16 = (byte)16;
        private static string ToHexDigit(byte number)
        {
            string result;
            if (number < 10)
                result = number.ToString();
            else if (number == 10)
                result = "A";
            else if (number == 11)
                result = "B";
            else if (number == 12)
                result = "C";
            else if (number == 13)
                result = "D";
            else if (number == 14)
                result = "E";
            else if (number == 15)
                result = "F";
            else
                result = "";

            return result;   
        }

        public Color(byte red, byte blue, byte green)
        {
            Red = red;
            Blue = blue;
            Green = green;
        }
    }
}
