using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.I.Examples
{
    public class Coin
    {
        public enum CoinFace { HEADS, TAILS };

        private static Random Rnd = new Random();
        public CoinFace FaceShowing { get; private set; }

        public Coin()
        {
            Toss();
        }

        public void Toss()
        {
            if (Rnd.Next(2) == 0)
                FaceShowing = CoinFace.HEADS;
            else
                FaceShowing = CoinFace.TAILS;
        }
    }
}
