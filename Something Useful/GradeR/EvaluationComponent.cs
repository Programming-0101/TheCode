using System;

namespace GradeR
{
    public class EvaluationComponent : RequiredForPass
    {
        public readonly TrimmedText Name;
        public readonly TrimmedText Description;
        public readonly Weight Weight;
        public Mark? PassMark { get; private set; }

        public EvaluationComponent(TrimmedText name, TrimmedText description, Weight weight)
        {
            Name = name;
            Description = description;
            Weight = weight;
        }

        public EvaluationComponent(TrimmedText name, TrimmedText description, Weight weight, Mark passMark)
        {
            Name = name;
            Description = description;
            Weight = weight;
            PassMark = passMark;
        }
    }
}
