using System;
using System.Linq;

namespace Topic.E.Examples
{
    public class QuadraticEquation
    {
        private int a;
        private int b;
        private int c;

        public QuadraticEquation(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double LowerRoot
        {
            get
            {
                double value;
                value = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                return value;
            }
        }

        public double HigherRoot
        {
            get
            {
                double value;
                value = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                return value;
            }
        }


        public override string ToString()
        {
            return a.ToString() + "x^2 + " + b + "x + " + c + " = 0";
        }
    }
}
