using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tutorial.Tests
{
    public class Class1
    {
        [Fact]
        public void should()
        {
            byte max = (byte)255;
            const byte base16 = (byte)16;
            string result = HexDigit((byte)(max / base16)) + HexDigit((byte)(max % base16));
            Assert.True(result.Equals("FF"));
        }
        private static string HexDigit(byte number)
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

    }
}
