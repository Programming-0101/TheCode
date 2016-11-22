using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGradeBook
{
    /// <summary>
    /// An EvaluationComponent is some specific item for which marks can be earned.
    /// </summary>
    public class EvaluationComponent
    {
        public EvaluationComponent(string name, int weight)
        {
            if (weight > 100 || weight <= 0)
                throw new System.Exception("Invalid weight for component");
            Name = name;
            Weight = weight;
        }

        public string Name { get; set; }
        public int Weight { get; set; }
        public int? PossibleMarks { get; set; } // an int? variable means that this primitive could hold a null value (acts like a reference type instead of a value type)
        public double? EarnedMark { get; set; }

        public double? Mark
        {
            get
            {
                if (PossibleMarks.HasValue && EarnedMark.HasValue)
                    return (EarnedMark / PossibleMarks) * 100;
                else
                    return null; // not enough information to calculate a marks
            }
        }

        public double? WeightedMark
        {
            get
            {
                if (Mark.HasValue)
                    return Mark * (Weight / 100.0);
                else
                    return null; // not enough data to calculate
            }
        }
    }
}
