using System;
namespace GradeR
{
    public class MissedItem : MarkableItem, IWeightedAverage
    {
        virtual public Mark Average => 0;
        virtual public Mark WeightedAverage => 0;
        public MissedItem(TrimmedText name, TrimmedText description, int weight, int possibleMarks) : base(name, description, weight, possibleMarks)
        {
        }
    }
}