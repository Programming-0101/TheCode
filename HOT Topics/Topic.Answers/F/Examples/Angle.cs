using System;
using System.Linq;

namespace Topic.F.Examples
{
    public class Angle
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

        public string AngleType
        {
            get
            {
                string angleType;
                if (Degrees <= 0)
                    angleType = "undefined";
                else if (Degrees < 90)
                    angleType = "acute";
                else if (Degrees == 90)
                    angleType = "right";
                else if (Degrees < 180)
                    angleType = "obtuse";
                else if (Degrees == 180)
                    angleType = "straight";
                else if (Degrees < 360)
                    angleType = "reflex";
                else if (Degrees == 360)
                    angleType = "full rotation";
                else
                    angleType = "undefined";
                return angleType;
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
