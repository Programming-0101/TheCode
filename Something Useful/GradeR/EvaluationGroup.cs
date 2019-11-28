using System;
using System.Collections.Generic;

namespace GradeR
{
    public class EvaluationGroup : List<EvaluationComponent>, RequiredForPass
    {
        public readonly TrimmedText Name;
        public Mark? PassMark { get; private set; }
        public EvaluationGroup(TrimmedText name, Mark passMark)
        {
            Name = name;
            PassMark = passMark;
        }
        public EvaluationGroup(TrimmedText name)
        {
            Name = name;
        }
    }
}
