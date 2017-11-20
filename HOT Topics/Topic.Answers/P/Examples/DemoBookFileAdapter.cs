using System;
using System.IO;
using System.Linq;

namespace Topic.P.Examples
{
    public class DemoBookFileAdapter
    {
        private static ConsoleColor _Normal = Console.ForegroundColor;

        public static void Start()
        {
            try
            {
                Book[] myBooks;
                myBooks = BookFileAdapter.LoadList("BookList.txt", FileFormat.CSV).ToArray();
                DisplayBooks(myBooks);

                myBooks = BookFileAdapter.LoadList(@"V:\ThisDriveNameDoesNotExist", FileFormat.CSV).ToArray();
                myBooks = BookFileAdapter.LoadList("ThisFileNameDoesNotExist", FileFormat.CSV).ToArray();

                DisplayBooks(myBooks);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!-- " + ex.Message + " --!");
                Console.ForegroundColor = _Normal;
            }
            catch (FileNotFoundException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!-- " + ex.Message + " --!");
                Console.ForegroundColor = _Normal;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!-- " + ex.Message + " --!");
                Console.ForegroundColor = _Normal;
            }
        }

        private static void DisplayBooks(Book[] myBooks)
        {
            for (int index = 0; index < myBooks.Length; index++)
            {
                Console.WriteLine("Title  : " + myBooks[index].Title);
                Console.WriteLine("ISBN   : " + myBooks[index].Isbn.BarCode);
                Console.WriteLine("Authors: ");
                foreach (string author in myBooks[index].Authors)
                    Console.WriteLine("\t" + author);
                Console.WriteLine();
            }
        }
    }
}
