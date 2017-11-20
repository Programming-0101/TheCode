using System;
using System.Linq;

namespace Topic.G.Examples
{
    public class Die
    {
        private static Random Rnd = new Random();
        public int Sides { get; private set; }
        public int FaceValue { get; private set; }
        public Die(int sides)
        {
            if (sides < 4 || sides > 20)
                throw new Exception("A die can only have from 4 to 20 sides");
            Sides = sides;
            Roll();
        }

        public void Roll()
        {
            FaceValue = Rnd.Next(1, Sides + 1);
        }
    }
}
