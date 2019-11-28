using System;
namespace GradeR
{
    public interface IWeightedAverage : IAverage
    {
        Mark WeightedAverage { get; }
    }
}