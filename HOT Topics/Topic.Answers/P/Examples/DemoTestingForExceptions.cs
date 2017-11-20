using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.P.Examples
{
    public class DemoTestingForExceptions
    {
        private static ConsoleColor _Normal = Console.ForegroundColor;

        public static void Start()
        {
            string[] actualAuthors = { "Dan Gilleland", "B. N. D'erdundat", "Dr. Ink" };
            string actualTitle = "Java: Bean There, Done That";
            string actualBarCode = "0-12345678-9";

            // Demo a normal creation of a Book object
            Console.WriteLine("Testing valid data");
            TestBook(actualTitle, actualAuthors, actualBarCode);

            // Demo testing the Book class for various combinations of data
            Console.WriteLine("Testing empty title");
            TestBook("", actualAuthors, actualBarCode);
            Console.WriteLine("Testing null title");
            TestBook(null, actualAuthors, actualBarCode);
            Console.WriteLine("Testing empty author list");
            TestBook(actualTitle, new String[0], actualBarCode);
            Console.WriteLine("Testing null author list");
            TestBook(actualTitle, null, actualBarCode);
            Console.WriteLine("Testing empty bar code");
            TestBook(actualTitle, actualAuthors, "");
            Console.WriteLine("Testing null bar code");
            TestBook(actualTitle, actualAuthors, null);
            Console.WriteLine("Testing all nulls");
            TestBook(null, null, null);
        }

        private static void TestBook(string title, string[] authors, string barCode)
        {
            try
            {
                Book theBook = new Book(title, authors, new ISBN(barCode));
                Console.WriteLine("I created the following book:");
                Console.WriteLine("    Title: " + theBook.Title);
                Console.Write("    Authors: ");
                foreach (string author in theBook.Authors)
                    Console.Write(author + ", ");
                Console.WriteLine("(" + theBook.Authors.Length + " authors)");
                Console.WriteLine("    ISBN: " + theBook.Isbn.BarCode);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!-- " + ex.Message + " --!");
                Console.ForegroundColor = _Normal;
            }
        }
    }
}
