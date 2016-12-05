using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGradeBook
{
    /// <summary>
    /// A StudentEvaluation is a complete set of evaluation items used to generate the final mark for a given course for a single student.
    /// </summary>
    public class StudentEvaluation
    {
        public StudentEvaluation()
        {
            Groups = new EvaluationGroup[7]; // arbitrary physical size
            _LogicalSize = 0; // I'm explicitly stating that it's "empty"
        }

        public string CourseNumber { get; set; }
        public string CourseName { get; set; }
        public double MarkToDate
        {
            get
            {
                double result = 0;
                foreach (var mark in Groups)
                    result += mark.MarkToDate;
                return result;
            }
        }
        public bool AllItemsMarked
        {
            get
            {
                // Ah, the beauty of extension methods for collections, even arrays
                return Groups.All(x => x.AllItemsMarked);
            }
        }


        // Hiding the Groups by making them private helps protect the data
        private EvaluationGroup[] Groups { get; set; }
        private int _LogicalSize; // a field to control the logical size of the array

        // Methods to allow a controlled access of the Groups
        public void AddEvaluationGroup(EvaluationGroup item)
        {
            if (item == null)
                throw new System.Exception("Evaluation Group cannot be null");
            if (_LogicalSize == Groups.Length)
                throw new System.Exception("Not enough room to add a new item");
            // To add an item to the array, we simply append it to the end
            Groups[_LogicalSize] = item; // here _LogicalSize is the next available
                                         // slot in the array
            _LogicalSize++; // increment the logical size
        }

        public EvaluationGroup GetEvaluationGroup(string name)
        {
            EvaluationGroup found = null;
            // A simple sequential search through an array, from the start to the end
            // of the used portion of the array
            for (int index = 0; index < _LogicalSize; index++)
                if (Groups[index].Name == name)
                    found = Groups[index];
            return found;
        }

        public string[] ListEvaluationGroups()
        {
            string[] groupNames = new string[_LogicalSize];
            // In the loop below, I am treating the two arrays as "parallel arrays".
            // Parallel arrays are when two or more arrays have their items relating
            // to each other based on their index positions.
            // Therefore, the logical (and possibly physical) sizes of the two arrays
            // must be the same.
            for (int index = 0; index < _LogicalSize; index++)
                groupNames[index] = Groups[index].Name;
            return groupNames;
        }
    }
}
