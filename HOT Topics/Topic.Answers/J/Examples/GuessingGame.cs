using System;
using System.Linq;

namespace Topic.J.Examples
{
    public class GuessingGame
    {
        private static Random Rnd = new Random();
        private SecretNumber Number { get; set; }
        public const int GUESS_FAILED = -1;

        public GuessingGame(SecretNumber number)
        {
            if (number == null)
                throw new System.Exception("SecretNumber cannot be null");
            this.Number = number;
        }

        public int GuessNumber(int maxAttempts)
        {
            int numberOfAttempts = 0;
            bool correct = false;
            while (maxAttempts > 0 && !correct)
            {
                // Make a guess
                int myBestGuess = Rnd.Next(Number.LowerLimit, Number.UpperLimit);
                if (Number.Guess(myBestGuess))
                    correct = true;
                numberOfAttempts++;
                maxAttempts--;
            }
            if (!correct)
                numberOfAttempts = GUESS_FAILED; // a "flag" to say the guess was incorrect
            return numberOfAttempts;
        }

        public int GuessNumber()
        {
            bool correct = false;
            int numberOfAttempts = 0;
            while (numberOfAttempts < int.MaxValue && !correct)
            {
                // Make a guess
                int myBestGuess = Rnd.Next(Number.LowerLimit, Number.UpperLimit);
                if (Number.Guess(myBestGuess))
                    correct = true;
                numberOfAttempts++;
            }
            if (!correct)
                numberOfAttempts = GUESS_FAILED;
            return numberOfAttempts;
        }
    }
}
