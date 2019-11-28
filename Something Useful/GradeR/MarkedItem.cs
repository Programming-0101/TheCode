using System;
namespace GradeR
{
    public class MarkedItem : MarkableItem, IWeightedAverage
    {
        protected Mark _EarnedMark;
        public virtual Mark EarnedMarks
        {
            get { return _EarnedMark; }
            set
            {
                if (value > PossibleMarks)
                    throw new System.ArgumentException("Earned marks cannot exceed possible marks for a MarkedItem");
                _EarnedMark = value;
            }
        }

        public Mark Average => EarnedMarks / PossibleMarks;

        public Mark WeightedAverage => Average * Weight;

        public MarkedItem(TrimmedText name, TrimmedText description, Weight weight, Mark possibleMarks, Mark earnedMarks)
            : base(name, description, weight, possibleMarks)
        {
            EarnedMarks = earnedMarks;
        }
    }
}