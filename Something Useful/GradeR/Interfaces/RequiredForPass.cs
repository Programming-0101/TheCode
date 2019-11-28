using System;
namespace GradeR
{
    public interface RequiredForPass
    {
        Mark? PassMark { get; }
        public bool IsRequiredForPass => PassMark.HasValue;
    }
}