using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeBook.ConsoleUI
{
    public class FileDialog
    {
        public static string GetFilePathFromDirectory(string prompt, string searchPath = "*.txt")
        {
            List<string> files = Directory.EnumerateFiles(".", searchPath, SearchOption.TopDirectoryOnly).ToList();

            Console.WriteLine("Files: ");
            int index = 0;
            Console.WriteLine($"{index} - Exit input");
            index++;
            foreach (var file in files)
            {
                Console.WriteLine($"{index} - {file}");
                index++;
            }
            Console.WriteLine();
            Console.WriteLine(prompt);
            while (!int.TryParse(Console.ReadLine(), out index) && (index < 0 || index > files.Count))
                Console.Write($"\tInvalid selection\n{prompt}");
            if (index == 0)
                throw new AbortFormInputException();
            return files[index - 1].Replace(@".\", ""); // offsetting for zero-based
        }
    }
}
