using System;
namespace GradeR
{
    public struct Mark
    {
        private readonly decimal Value;
        public Mark(decimal value)
        {
            if (value <= 0)
                throw new ArgumentException("Mark must be a positive (greater than zero) value", nameof(value));
            Value = value;
        }
        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator decimal(Mark w) => w.Value;
        public static implicit operator Mark(decimal d) => new Mark(d);
    }
}