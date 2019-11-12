using System;
using System.Linq;

namespace Topic.J.Examples
{
    public class Fraction
    {
        public int Numerator { get; private set; }

        public int Denominator { get; private set; }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            FixSign();
        }

        public Fraction Reciprocal
        {
            get { return new Fraction(Denominator, Numerator); }
        }


        private void FixSign()
        {
            if (Denominator < 0)
            {
                Denominator *= -1;
                Numerator *= -1;
            }
        }

        public bool IsProper
        {
            get
            {
                bool proper;
                if (Numerator < Denominator)
                    proper = true;
                else
                    proper = false;
                return proper;
            }
        }

        public override string ToString()
        {
            string stringValue = "";
            if (IsProper)
                stringValue += (Numerator / Denominator) + " and "
                             + (Numerator % Denominator) + "/" + Denominator;
            else
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

        public void MultiplyBy(Fraction otherFraction)
        {
            Numerator = Numerator * otherFraction.Numerator;
            Denominator = Denominator * otherFraction.Denominator;
        }

        private int GreatestCommonDenominator()
        {
            int commonDenominator = 1;
            int count = 2, halfWay;
            int absoluteNumerator = System.Math.Abs(Numerator);
            if (absoluteNumerator > Denominator)
                halfWay = absoluteNumerator / 2;
            else
                halfWay = Denominator / 2;

            while (count <= halfWay)
            {
                if (absoluteNumerator % count == 0 &&
                    Denominator % count == 0)
                    commonDenominator = count;
                count++;
            }

            return commonDenominator;
        }
    }
}
