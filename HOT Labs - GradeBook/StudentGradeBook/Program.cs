using StudentGradeBook.ConsoleUI;
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
            string userInput;
            do
            {
                DisplayMenu();
                Console.Write("Select an option from the menu: ");
                userInput = Console.ReadLine().ToUpper();
                try
                {
                    HandleMenuOption(userInput);
                }
                catch (AbortFormInputException ex)
                {
                    // no need to do anything - they've just aborted the form they are in
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                    Console.Write("Press [Enter] to return to the main menu.");
                    Console.ReadLine();// tossing the input....
                }
            } while (userInput != "Q");
        }

        private void HandleMenuOption(string option)
        {
            switch (option)
            {
                case "1":
                    GradebookForm form = new GradebookForm();
                    var gradebook = form.PromptForData();
                    SaveGrades(gradebook);
                    break;
                case "2":
                    Console.Write("Course Number: ");
                    string courseNumber = Console.ReadLine();
                    var data = LoadGrades($"{courseNumber}.txt");
                    GradebookGradeRecordingForm form2 = new GradebookGradeRecordingForm(data);
                    form2.ShowForm();
                    if (form2.GradesEntered)
                        SaveGrades(form2.Gradebook);
                    break;
            }
        }

        private void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Main Menu ===\n");
            Console.WriteLine("1) Create Gradebook File");
            Console.WriteLine("2) Load Gradebook File");
            Console.WriteLine("Q) Quit Program");
            Console.WriteLine();
        }

        private void SaveGrades(StudentEvaluation gradebook)
        {
            /* File structure:
             * CourseName, CourseNumber, GroupCount
             * GroupName, GroupWeight, PassMark, ItemCount
             * ItemName, ItemWeight, PossibleMarks, EarnedMark
             */
            List<string> lines = new List<string>();
            string[] groupNames = gradebook.ListEvaluationGroups();
            lines.Add($"{gradebook.CourseName},{gradebook.CourseNumber},{groupNames.Length}");
            foreach (string name in groupNames)
            {
                var group = gradebook.GetEvaluationGroup(name);
                var itemNames = group.ListGroupComponents();
                lines.Add($"{group.Name},{group.Weight},{group.PassMark},{itemNames.Count}");
                foreach (string item in itemNames)
                {
                    var component = group.GetEvaluationItem(item);
                    lines.Add($"{component.Name},{component.Weight},{component.PossibleMarks},{component.EarnedMark}");
                }
            }
            CSVFileIO writer = new CSVFileIO($"{gradebook.CourseNumber}.txt");
            writer.WriteAllLines(lines, false);
        }

        private StudentEvaluation LoadGrades(string fileName)
        {
            /* File structure:
             * CourseName, CourseNumber, GroupCount
             * GroupName, GroupWeight, PassMark, ItemCount
             * ItemName, ItemWeight, PossibleMarks, EarnedMark
             */
            StudentEvaluation gradebook = null;

            return gradebook;
        }
    }
}
