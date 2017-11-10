using System;
using System.Linq;

namespace Topic.E.Examples
{
    internal class Angle
    {
        public Angle(double degrees)
        {
            this.Degrees = degrees;
        }

        public double Degrees { get; set; }

        public double Radians
        {
            get
            {
                double radians = Degrees * (Math.PI / 180);
                return radians;
            }
        }

        public double Grads
        {
            get
            {
                double grads = Radians * (200 / Math.PI);
                return grads;
            }
        }

        // http://unicode.org/notes/tn28/UTN28-PlainTextMath.pdf
        // Page 40 of the above reference for the degree symbol
        public override string ToString()
        {
            return Degrees.ToString() + '\u00B0';
        }
    }
}
