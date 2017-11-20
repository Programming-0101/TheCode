using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.G.Examples
{
    public class Square
    {
        public Square(double side)
        {
            this.Side = side;
        }

        private double _Side;
        public double Side
        {
            get
            {
                return _Side;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("A square must have a positive non-zero length for its side");
                _Side = value;
            }
        }
        public double Area
        {
            get { return Side * Side; }
        }

        public double Perimeter
        {
            get { return Side * 4; }
        }

        public double Diagonal
        {
            get { return Math.Sqrt(2 * Side * Side); }
        }
    }
}
