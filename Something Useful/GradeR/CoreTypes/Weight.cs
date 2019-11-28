using System;
namespace GradeR
{
    public struct Weight
    {
        private readonly decimal Value;
        public Weight(decimal value)
        {
            if (value <= 0)
                throw new ArgumentException("Weight must be a positive (greater than zero) value", nameof(value));
            if (value > 100)
                throw new ArgumentException("Weight must be less than 100%", nameof(value));
            if (value != Math.Round(value, 1))
                throw new ArgumentException("Weight precisions are only allowed to a tenth of a percent", nameof(value));
            Value = value;
        }
        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator decimal(Weight w) => w.Value;
        public static implicit operator Weight(decimal d) => new Weight(d);
    }
}