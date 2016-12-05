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
                    Console.Error.WriteLine($"at {ex.TargetSite}");
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
                    //Console.Write("Course Number: ");
                    //string courseNumber = Console.ReadLine();
                    //var data = LoadGrades($"{courseNumber}.txt");
                    string path = FileDialog.GetFilePathFromDirectory("Select a course file: ");
                    var data = LoadGrades(path);
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
            CSVFileIO reader = new CSVFileIO(fileName);
            Queue<string> lines = new Queue<string>(reader.ReadAllLines());

            // Get the course name/number
            string[] parts = lines.Dequeue().Split(',');
            gradebook = new StudentEvaluation()
            {
                CourseName = parts[0],
                CourseNumber = parts[1]
            };
            int groupCount = int.Parse(parts[2]);
            while (groupCount > 0)
            {
                // Get the evaluation group
                parts = lines.Dequeue().Split(',');
                int temp;
                var group = new EvaluationGroup()
                {
                    Name = parts[0],
                    Weight = int.Parse(parts[1]),
                    PassMark = int.TryParse(parts[2], out temp) // does it parse?
                             ? temp                             // yes, so use it
                             : (int?)null                       // no, so set to null
                };
                int itemCount = int.Parse(parts[3]);
                while (itemCount > 0)
                {
                    // Get the evaluation component
                    parts = lines.Dequeue().Split(',');
                    var item = new EvaluationComponent(parts[0], int.Parse(parts[1]));
                    if (int.TryParse(parts[2], out temp))
                        item.PossibleMarks = temp;
                    double dtemp;
                    if (double.TryParse(parts[3], out dtemp))
                        item.EarnedMark = dtemp;
                    group.AddEvaluationItem(item);
                    itemCount--;
                }
                gradebook.AddEvaluationGroup(group);
                groupCount--;
            }

            return gradebook;
        }
    }
}
