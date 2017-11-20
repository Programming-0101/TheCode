using System;
using System.Linq;

namespace Topic.E.Examples
{
    public class Die
    {
        private static Random Rnd = new Random();

        public Die()
        {
            Roll();
        }

        public int FaceValue { get; private set; }

        public void Roll()
        {
            FaceValue = Rnd.Next(1, 7);
        }
    }
}
