using System;
using System.Linq;

namespace Topic.K.Examples
{
    public class Mark
    {
        // ![](27EF3772193AA5AAEC69A3C8AD61AB88.png)
        public double Average => (double)EarnedMarks / PossibleMarks;
        public int EarnedMarks { get; private set; }
        public int PossibleMarks { get; private set; }
        public Mark(int possibleMarks, int earnedMarks)
        {
            EarnedMarks = earnedMarks;
            PossibleMarks = possibleMarks;
        }
    }
}
