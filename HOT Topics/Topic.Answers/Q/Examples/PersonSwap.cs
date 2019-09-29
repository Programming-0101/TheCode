using System;
using System.Linq;

namespace Topic.Q.Examples
{
    public class PersonSwap
    {
        private static void DemoObjectSwapMethods()
        {
            // Variable setup
            Person varA = new Person("Matt");
            Person varB = new Person("Mallory");

            Console.WriteLine($"Attempting to swap {varA} and {varB}.");
            BadObjectSwap(varA, varB);
            Console.WriteLine($"Results of BadSwap method: {varA} and {varB}");
            GoodObjectSwap(ref varA, ref varB);
            Console.WriteLine($"Results of GoodSwap method: {varA} and {varB}");
        }

        private static void BadObjectSwap(Person a, Person b)
        {
            // Only the local variables are swapped
            Person temp;
            temp = a;
            a = b;
            b = temp;
        }

        private static void GoodObjectSwap(ref Person a, ref Person b)
        {
            Person temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
