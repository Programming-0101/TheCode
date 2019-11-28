using System;
namespace GradeR
{
    public class MarkedItemWithBonus : MarkedItem
    {
        public readonly Mark MaxBonus;
        public override Mark EarnedMarks
        { 
            get => base.EarnedMarks; 
            set
            {
                if (value > PossibleMarks + MaxBonus)
                    throw new System.ArgumentException("Earned marks cannot exceed the sum of possible marks and maximum bonus for a MarkedItemWithBonus");
                _EarnedMark = value;
            }
        }

        public MarkedItemWithBonus(TrimmedText name, TrimmedText description, Weight weight, Mark possibleMarks, Mark earnedMarks, Mark maxBonus) : base(name, description, weight, possibleMarks, earnedMarks)
        {
            if (MaxBonus > PossibleMarks / 10)
                throw new ArgumentException("Maximum bonus cannot be more than 10% of the possible marks of the markable item");
            MaxBonus = maxBonus;
        }
    }
}