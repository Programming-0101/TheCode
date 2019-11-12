using System;
using System.Linq;

namespace Topic.J.Examples
{
    public class SecretNumber
    {
        private static Random _rnd = new Random();
        public readonly int LowerLimit;
        public readonly int UpperLimit;
        private readonly int TheSecretNumber;
        public SecretNumber(int upperLimit) : this(1, upperLimit)
        { }
        public SecretNumber(int lowerLimit, int upperLimit) : this(lowerLimit, upperLimit, _rnd.Next(lowerLimit, upperLimit + 1))
        { }
        public SecretNumber(int lowerLimit, int upperLimit, int theSecretNumber)
        {
            LowerLimit = lowerLimit;
            UpperLimit = upperLimit;
            TheSecretNumber = theSecretNumber;
        }
        public bool Guess(int myBestGuess)
        {
            throw new NotImplementedException();
        }
    }
}
