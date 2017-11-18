using System;
using System.Linq;

namespace Topic.E.Examples
{
    public class Circle
    {
        public Circle(double diameter)
        {
            this.Diameter = diameter;
        }

        public double Diameter { get; set; }

        public double Radius
        { get { return Diameter / 2; } }

        public double Circumference
        { get { return Math.PI * Diameter; } }

        public double Area
        { get { return Math.PI * Radius * Radius; } }
    }
}
