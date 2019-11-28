using System;
namespace GradeR
{
    public struct TrimmedText
    {
        private readonly string Value;
        public TrimmedText(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"{nameof(value)} is null or empty.", nameof(value));
            Value = value.Trim();
        }
        public override string ToString()
        {
            return Value;
        }

        public static implicit operator string(TrimmedText t) => t.Value;
        public static implicit operator TrimmedText(string text) => new TrimmedText(text);
    }
}