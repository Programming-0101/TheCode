using System;
using System.Linq;

namespace Topic.E.Examples
{
    internal class Die
    {
        private static Random rnd = new Random();

        public Die()
        {
            Roll();
        }

        public int FaceValue { get; private set; }

        public void Roll()
        {
            FaceValue = rnd.Next(6000) % 6 + 1;
        }
    }
}
