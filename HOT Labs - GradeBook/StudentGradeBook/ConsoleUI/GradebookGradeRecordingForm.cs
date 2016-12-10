using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGradeBook.ConsoleUI
{
    class GradebookGradeRecordingForm
    {
        public StudentEvaluation Gradebook { get; private set; }
        public bool GradesEntered { get; private set; }

        private List<EvaluationComponent> EditableItem { get; set; }

        public GradebookGradeRecordingForm(StudentEvaluation gradebook)
        {
            Gradebook = gradebook;
            EditableItem = new List<EvaluationComponent>();
            foreach (var groupName in Gradebook.ListEvaluationGroups())
            {
                var group = Gradebook.GetEvaluationGroup(groupName);
                foreach (var itemName in group.ListGroupComponents())
                {
                    var item = group.GetEvaluationItem(itemName);
                    EditableItem.Add(item);
                }
            }
        }

        public void ShowForm()
        {
            // Show the grades at present
            char option;
            do
            {
                option = GetMenuOption();

                switch (option)
                {
                    case 'A':
                        DisplayGrades();
                        break;
                    case 'B':
                        EditGrade();
                        break;
                }
            } while (option != 'X');


            // Menu to allow marks to be entered
            // Save/Exit form
        }

        private static char GetMenuOption()
        {
            Console.Clear();
            Console.WriteLine("--- Main Menu > Grade Recording Form ---\n");
            Console.WriteLine("A) Display Grades");
            Console.WriteLine("B) Edit a grade");
            Console.WriteLine("X) Exit to main menu\n");
            Console.Write("Select an option: ");
            char choice;
            while(!char.TryParse(Console.ReadLine().ToUpper(), out choice))
                Console.Write("\tInvalid choice.\nSelect an option: ");

            return choice;
        }

        private void DisplayGrades()
        {
            Console.Clear();
            Console.WriteLine("--- Main Menu > Grade Recording Form ---\n");
            Console.WriteLine($"{Gradebook.CourseNumber} - {Gradebook.CourseName}\n");
            foreach (var groupName in Gradebook.ListEvaluationGroups())
            {
                var group = Gradebook.GetEvaluationGroup(groupName);
                Console.Write($"\t{group}");
                if (group.HasPassedGroup.HasValue)
                {
                    if (group.HasPassedGroup.Value)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" - Passed this group!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        string yet = "not *yet* ";
                        if (group.AllItemsMarked) yet = "NOT ";
                        Console.WriteLine($" - Has {yet}passed this group!");
                        Console.ResetColor();
                    }
                }
                else
                    Console.WriteLine();
                foreach (var itemName in group.ListGroupComponents())
                {
                    var item = group.GetEvaluationItem(itemName);
                    Console.WriteLine($"\t  - {item}");
                }
            }
            Console.Write("\n\nPress [Enter] to continue...");
            Console.ReadLine();
        }

        private void EditGrade()
        {
            Console.Clear();
            Console.WriteLine("--- Main Menu > Grade Recording Form ---\n--- Edit Grade\n\n");
            int index = 1, input;
            foreach (var item in EditableItem)
            {
                Console.WriteLine($"{index}) {item.Name}");
                index++;
            }
            Console.Write("Select an item to record: ");
            while(!int.TryParse(Console.ReadLine(), out input) && (input < 1 || input > EditableItem.Count))
                Console.Write("\tInvalid entry\nSelect an item to record: ");

            index = input - 1;
            var editItem = EditableItem[index];
            Console.WriteLine($"\n{editItem}");

            Console.Write("Enter possible marks: ");
            while (!int.TryParse(Console.ReadLine(), out input) && (input < 1 || input > 100))
                Console.Write("\tInvalid value\nEnter possible marks: ");
            double earned;
            Console.Write("Enter earned marks: ");
            while (!double.TryParse(Console.ReadLine(), out earned) && (earned < 0 || earned > input))
                Console.Write("\tInvalid value\nEnter earned marks: ");

            editItem.PossibleMarks = input;
            editItem.EarnedMark = earned;

            GradesEntered = true;
        }
    }
}
