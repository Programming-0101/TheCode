using System;
using System.Linq;

namespace Topic.E.Examples
{
    internal class Fraction
    {
        public int Numerator { get; private set; }

        public int Denominator { get; private set; }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction Reciprocal
        {
            get { return new Fraction(Denominator, Numerator); }
        }

        public override string ToString()
        {
            string stringValue = "";
            stringValue += Numerator + "/" + Denominator;
            return stringValue;
        }

        public double ToDouble()
        {
            // The casting of numerator to a double helps
            // ensure that we don't lose any fractional
            // portion due to integer division.
            double value = (double)(Numerator) / Denominator;
            return value;
        }
    }
}
