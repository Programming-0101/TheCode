using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeBook.ConsoleUI
{
    class GradebookForm
    {
        private StudentEvaluation _Gradebook;

        public StudentEvaluation PromptForData()
        {
            Console.Clear();
            Console.WriteLine("--- Main Menu > Gradebook Form ---\n");

            Console.Write("Enter the course name (or 'x' to exit): ");
            string name = Console.ReadLine();
            if (name.Equals("x", StringComparison.InvariantCultureIgnoreCase))
                throw new AbortFormInputException();
            Console.Write("Enter the course number: ");
            string number = Console.ReadLine();
            _Gradebook = new StudentEvaluation
            {
                CourseName = name,
                CourseNumber = number
            };

            AddEvaluationGroups();
            return _Gradebook;
        }

        private void AddEvaluationGroups()
        {
            // Add Evaluation Groups
            int remainingWeight = 100;
            do
            {
                EvaluationGroup group = PromptForEvaluationGroup(remainingWeight);
                int groupWeight = group.Weight;

                do
                {
                    var item = PromptForEvaluationComponent(groupWeight);
                    group.AddEvaluationItem(item);
                    groupWeight -= item.Weight;
                } while (groupWeight > 0);

                _Gradebook.AddEvaluationGroup(group);
                remainingWeight -= group.Weight;
            } while (remainingWeight > 0);
        }

        private EvaluationGroup PromptForEvaluationGroup(int remainingWeight)
        {
            int groupWeight;
            string groupName = String.Empty;
            Console.Write("\tEnter a name for the evaluation group (or 'x' to exit form): ");
            groupName = Console.ReadLine();
            if (groupName.Equals("x", StringComparison.InvariantCultureIgnoreCase))
                throw new AbortFormInputException();
            Console.Write($"\tEnter a weight for the group (up to {remainingWeight}): ");
            while (!int.TryParse(Console.ReadLine(), out groupWeight) || groupWeight < 1 || groupWeight > remainingWeight)
            {
                Console.WriteLine("\t\tInvalid group weight");
                Console.Write($"\tEnter a weight for the group (up to {remainingWeight}): ");
            }
            Console.Write("\tEnter a pass mark for the group (or press [Enter] if the group has no pass mark): ");
            int temp;
            int? passMark = null;
            if (int.TryParse(Console.ReadLine(), out temp))
                passMark = temp;


            EvaluationGroup group = new EvaluationGroup()
            {
                Name = groupName,
                Weight = groupWeight,
                PassMark = passMark
            };
            return group;
        }

        private EvaluationComponent PromptForEvaluationComponent(int remainingWeight)
        {
            Console.Write("\t\tEnter item name (or 'x' to exit form): ");
            string itemName = Console.ReadLine();
            if (itemName.Equals("x", StringComparison.InvariantCultureIgnoreCase))
                throw new AbortFormInputException();
            Console.Write($"\t\tEnter weight (up to {remainingWeight}): ");
            int itemWeight;
            while (!int.TryParse(Console.ReadLine(), out itemWeight) || itemWeight < 1 || itemWeight > remainingWeight)
            {
                Console.WriteLine("\t\tInvalid weight");
                Console.Write($"\tEnter a weight (up to {remainingWeight}): ");
            }
            var item = new EvaluationComponent(itemName, itemWeight);
            return item;
        }
    }
}
