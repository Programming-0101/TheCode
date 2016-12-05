using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGradeBook
{
    /// <summary>
    /// An EvaluationGroup is a set of one or more evaluation component that may or may not need to be passed as a whole in order to qualify for a passing grade.
    /// </summary>
    public class EvaluationGroup
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int? PassMark { get; set; }
        public double MarkToDate
        {
            get
            {
                double result = 0;
                foreach (var mark in Items)
                    result += mark.WeightedMark ?? 0;
                return result;
            }
        }
        public bool AllItemsMarked
        {
            get
            {
                // Ah, the beauty of extension methods for collections
                return Items.All(x => x.WeightedMark.HasValue);
            }
        }
        private List<EvaluationComponent> Items { get; set; }

        // Constructor
        public EvaluationGroup()
        {
            // Set up the Items property as an empty list
            Items = new List<EvaluationComponent>();
        }

        public void AddEvaluationItem(EvaluationComponent item)
        {
            if (item == null)
                throw new System.Exception("Evaluation Component cannot be null");
            Items.Add(item);
        }

        public EvaluationComponent GetEvaluationItem(string name)
        {
            EvaluationComponent found = null;
            foreach (var item in Items)
                if (item.Name == name)
                    found = item;
            return found;
        }

        public List<string> ListGroupComponents()
        {
            List<string> results = new List<string>();

            foreach (var item in Items)
                results.Add(item.Name);

            return results;
        }

        public override string ToString()
        {
            string text = $"{Name} ({Weight} %";
            if (PassMark.HasValue)
                text += $" - {PassMark} % to pass)";
            else
                text += ")";

            text += $" -- {MarkToDate} % ";
            if (AllItemsMarked)
                text += "FINAL MARK";
            else
                text += "Mark-to-date";

            return text;
        }
    }
}
