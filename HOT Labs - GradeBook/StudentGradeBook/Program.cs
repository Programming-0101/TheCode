using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Program app = new Program();
            app.Run();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        private void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Main Menu ===\n");
            Console.WriteLine("1) Create Gradebook File");
            Console.WriteLine("2) Load Gradebook File");
            Console.WriteLine("Q) Quit Program");
        }
    }
}
