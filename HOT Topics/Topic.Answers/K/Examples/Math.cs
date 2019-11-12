using System;
using System.Collections.Generic;
using System.Linq;

namespace Topic.K.Examples
{
    public class Math
    {
        public static int FibonacciNumber(int i)
        {
            int current = 1, previous = 1, beforePrevious = 0;
            if (i >= 1)
            {
                for (int counter = 3; counter <= i; counter++)
                {
                    beforePrevious = previous;
                    previous = current;
                    current = beforePrevious + previous;
                }
            }
            else
                throw new Exception("Can only create a fibonacci number based on a positive non-zero position");
            return current;
        }

        /// <summary>
        /// This method generates the sequence of Fibonacci numbers to a specific length in the sequence.
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static List<int> FibonacciSequence(int length)
        {
            List<int> fib = new List<int>();
            if (length >= 1)
            {
                for (int index = 0; index < length; index++)
                    fib.Add(FibonacciNumber(index + 1));
            }
            return fib;
        }

        public static bool IsPerfect(int number)
        {
            bool perfect = true;
            if (number <= 1)
                perfect = false;
            else
            {
                // The following logic attempts to prove it is imperfect
                int halfWay = number / 2;
                int total = 0;
                int count = 1;
                while (total != number && total <= halfWay && total < number)
                {
                    if (number % count == 0) // Then count is a factor of number
                        total += count;
                    count++;
                }
                if (total != number)
                    perfect = false;
            }
            return perfect;
        }
    }
}
