using System;
using System.Linq;

namespace Topic.G.Examples
{
    public class Circle
    {
        public Circle(double diameter)
        {
            Diameter = diameter;
        }

        private double _Diameter;
        public double Diameter
        {
            get
            {
                return _Diameter;
            }
            set
            {
                if (value <= 0)
                    throw new System.Exception("Diameter must be a positive non-zero value");
                _Diameter = value;
            }
        }
        public double Radius
        { get { return Diameter / 2; } }

        public double Circumference
        { get { return Math.PI * Diameter; } }

        public double Area
        { get { return Math.PI * Radius * Radius; } }
    }
}
