using System;
namespace GradeR
{
    public class MarkableItem : EvaluationComponent
    {
        public Mark PossibleMarks{ get; protected set; }

        public MarkableItem(TrimmedText name, TrimmedText description, Weight weight, Mark possibleMarks)
            : base(name, description, weight)
        {
            PossibleMarks = possibleMarks;
        }
    }
}