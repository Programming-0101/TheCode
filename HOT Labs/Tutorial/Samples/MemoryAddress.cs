using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Samples
{
    public class MemoryAddress
    {
        public short Base10Value { get; private set; }
        public string HexValue
        {
            get
            {
                string hex = "0x";
                // A short number in hexadecimal 
                // will be at most 4 digits
                //    FFFF
                //    ||||
                //    |||- 16^0 =>    1
                //    ||-- 16^1 =>   16
                //    |--- 16^2 =>  256
                //    ---- 16^3 => 4096
                int value = Base10Value;
                int portion = value / 4096;
                hex += ToHexDigit(portion);
                value -= portion;
                portion = value / 256;
                hex += ToHexDigit(portion);
                value -= portion;
                portion = value / 16;
                hex += ToHexDigit(portion);
                portion = value % 16;
                hex += ToHexDigit(portion);
                return hex;
            }
        }

        public MemoryAddress(short address)
        {
            Base10Value = address;
        }

        private static string ToHexDigit(int number)
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
            else // Should never happen...
                result = "";

            return result;
        }
    }
}
