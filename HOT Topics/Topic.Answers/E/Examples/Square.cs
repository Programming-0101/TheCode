using System;
using System.Linq;

namespace Topic.E.Examples
{
    public class Square
    {
        public Square(double side)
        {
            this.Side = side;
        }

        public double Side { get; set; }

        public double Area
        {
            get { return Side * Side; }
        }

        public double Perimeter
        {
            get { return Side * 4; }
        }
    }
}
