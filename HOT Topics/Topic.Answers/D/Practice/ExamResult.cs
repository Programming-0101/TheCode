using System;
using System.Linq;

namespace Topic.D.Practice
{
    public class ExamResult
    {
        public string ExamName { get; set; }
        public int TotalMarks { get; set; }
        public double MarksEarned { get; set; }
        public int ExamWeight { get; set; }
        public int StudentID { get; set; }
        public ExamResult(string examName, int totalMarks, double marksEarned, int examWeight, int studentID)
        {
            ExamName = examName;
            TotalMarks = totalMarks;
            MarksEarned = marksEarned;
            ExamWeight = examWeight;
            StudentID = studentID;
        }
        public ExamResult(string examName, int totalMarks, int examWeight, int studentID)
        {
            ExamName = examName;
            TotalMarks = totalMarks;
            ExamWeight = examWeight;
            StudentID = studentID;
        }
        public override string ToString()
        {
            return $"The student ({StudentID}) received {MarksEarned}/{TotalMarks} for this {ExamName} exam.";
        }
    }
}
