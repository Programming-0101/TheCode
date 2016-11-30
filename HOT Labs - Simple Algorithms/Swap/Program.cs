using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleSwap();
            DemoSwapMethods();
            DemoArrayElementSwap();
            DemoObjectSwapMethods();
        }

        private static void SimpleSwap()
        {
            Console.Clear();

            // A simple swap
            string varA = "Matt";
            string varB = "Mallory";

            Console.WriteLine($"Attempting to swap {varA} and {varB}.");

            // The following will NOT work
            varA = varB;
            varB = varA;
            Console.WriteLine($"Results: {varA} and {varB}");

            // Reset & try again
            varA = "Matt";
            varB = "Mallory";

            Console.WriteLine($"Second attempt to swap {varA} and {varB}.");

            // A temporary variable is required.
            string temp;
            temp = varA;
            varA = varB;
            varB = temp;
            Console.WriteLine($"Results: {varA} and {varB}");
        }

        private static void DemoSwapMethods()
        {
            // Variable setup
            string varA = "Matt";
            string varB = "Mallory";

            Console.WriteLine($"Attempting to swap {varA} and {varB}.");
            BadSwap(varA, varB);
            Console.WriteLine($"Results of BadSwap method: {varA} and {varB}");
            GoodSwap(ref varA, ref varB);
            Console.WriteLine($"Results of GoodSwap method: {varA} and {varB}");
        }

        private static void BadSwap(string a, string b)
        {
            string temp;
            temp = a;
            a = b;
            b = temp;
        }

        private static void GoodSwap(ref string a, ref string b)
        {
            string temp;
            temp = a;
            a = b;
            b = temp;
        }

        private static void DemoArrayElementSwap()
        {
            string[] studioC_CastMembers = { "Whitney Call", "Mallory Everton", "Jason Gray", "Matt Meese", "Adam Berg", "Stacey Harkey", "Natalie Madsen", "Stephen Meek", "James Perry", "Jeremy Warner" };
            Console.WriteLine($"Going to swap {studioC_CastMembers[0]} and {studioC_CastMembers[1]}");
            SwapElements(studioC_CastMembers, 0, 1);
            Console.WriteLine($"Results of array swap: {studioC_CastMembers[0]} and {studioC_CastMembers[1]}");
        }

        private static void SwapElements(string[] theArray, int indexA, int indexB)
        {
            string temp;
            temp = theArray[indexA];
            theArray[indexA] = theArray[indexB];
            theArray[indexB] = temp;
        }

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

    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "My name is " + Name;
        }
    }
}
