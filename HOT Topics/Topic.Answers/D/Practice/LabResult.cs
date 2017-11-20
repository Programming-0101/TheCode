using System;
using System.Linq;

namespace Topic.D.Practice
{
    public class LabResult
    {
        public int LabNumber { get; private set; }
        public int TotalMarks { get; private set; }
        public double MarksEarned { get; set; }
        public int LabWeight { get; private set; }
        public int StudentID { get; private set; }
        public LabResult(int labNumber, int totalMarks, double marksEarned, int labWeight, int studentID)
        {
            LabNumber = labNumber;
            TotalMarks = totalMarks;
            MarksEarned = marksEarned;
            LabWeight = labWeight;
            StudentID = studentID;
        }
        public override string ToString()
        {
            return $"The student ({StudentID}) received {MarksEarned}/{TotalMarks} for this lab.";
        }
    }
}
