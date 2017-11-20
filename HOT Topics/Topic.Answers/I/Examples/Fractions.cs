// Assorted classes for Fractions
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.I.Examples
{
    public class ProperFraction
    {
        public ProperFraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new System.Exception("zero denominator fractions are undefined");
            if (Math.Abs(numerator) >= Math.Abs(denominator))
                throw new System.Exception("Proper fractions must have a numerator that is less than the denominator");

            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public int Numerator { get; private set; }
        public int Denominator { get; private set; }
        public ImproperFraction Reciprocal
        {
            get
            { return new ImproperFraction(Denominator, Numerator); }
        }

        public double ToDouble()
        {
            return (double)(Numerator) / Denominator;
        }

        public override string ToString()
        {
            return Numerator + "/" + Denominator;
        }
    }

    public class ImproperFraction
    {
        public ImproperFraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new System.Exception("zero denominator fractions are undefined");
            if (Math.Abs(numerator) < Math.Abs(denominator))
                throw new System.Exception("Improper fractions must have a numerator that is greater than or equal to the denominator");

            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public int Numerator { get; private set; }
        public int Denominator { get; private set; }
        public ProperFraction Reciprocal
        {
            get { return new ProperFraction(Denominator, Numerator); }
        }

        public double ToDouble()
        {
            return (double)(Numerator) / Denominator;
        }

        public override string ToString()
        {
            return Numerator + "/" + Denominator;
        }
    }

    public class MixedNumber
    {
        public int WholeNumber { get; private set; }
        public ProperFraction Fraction { get; private set; }

        public MixedNumber(int wholeNumber, ProperFraction fraction)
        {
            if (wholeNumber == 0)
                throw new System.Exception("wholeNumber portion cannot be zero for a Mixed Number");
            if (fraction == null)
                throw new System.Exception("MixedNumbers must have a fractional portion");
            if (fraction.Numerator < 0)
            {
                fraction = new ProperFraction(-fraction.Numerator, fraction.Denominator);
                wholeNumber *= -1;
            }
            this.WholeNumber = wholeNumber;
            this.Fraction = fraction;
        }

        public MixedNumber(ImproperFraction improperFraction) :
            this(improperFraction.Numerator / improperFraction.Denominator,
                  new ProperFraction(improperFraction.Numerator %
                                    improperFraction.Denominator,
                                    improperFraction.Denominator))
        {
        }

        public ImproperFraction ToImproperFraction()
        {
            return new ImproperFraction(WholeNumber *
                                        Fraction.Denominator + Fraction.Numerator,
                                        Fraction.Denominator);
        }

        public double ToDouble()
        {
            double realValue = Math.Abs(WholeNumber) + Fraction.ToDouble();
            if (WholeNumber < 0)
                realValue *= -1;
            return realValue;
        }
    }
}
