using System;
using System.Linq;

namespace Topic.D.Practice
{
    public class Course
    {
        public string CourseName { get; set; }
        public string CourseNumber { get; set; }
        public int ExamCount { get; set; }
        public int LabCount { get; set; }
        public int ClassHours { get; set; }
        public Course(string courseName, string courseNumber, int examCount, int labCount, int classHours)
        {
            CourseName = courseName;
            CourseNumber = courseNumber;
            ExamCount = examCount;
            LabCount = labCount;
            ClassHours = classHours;
        }
    }
}
