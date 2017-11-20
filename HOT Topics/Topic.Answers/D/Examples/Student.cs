using System;
using System.Linq;

namespace Topic.D.Examples
{
    public class Student
    {
        public string Name { get; set; }
        public char Gender { get; set; }
        public int StudentId { get; set; }
        public string Program { get; set; }
        public double GradePointAverage { get; set; }
        public bool IsFullTime { get; set; }
        public Student(string name, char gender, int studentId, string program, double gradePointAverage, bool isFullTime)
        {
            Name = name;
            Gender = gender;
            StudentId = studentId;
            Program = program;
            GradePointAverage = gradePointAverage;
            IsFullTime = isFullTime;
        }
        public override string ToString()
        {
            return $"({StudentId}) {Name}";
        }
    }
}
