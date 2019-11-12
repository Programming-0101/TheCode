using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.K.Examples
{
    public class ClassList
    {
        public const int CLASS_LIMIT = 25;
        public string CourseId { get; private set; }
        private List<Student> students;

        public ClassList(string courseId, List<Student> students)
        {
            if (String.IsNullOrEmpty(courseId) || string.IsNullOrEmpty(courseId.Trim()))
                throw new Exception("Course Id is required");
            if (students == null)
                throw new Exception("Students cannot be a null list");
            if (students.Count > CLASS_LIMIT)
                throw new Exception("Class Limit Exceeded");
            for (int index = 0; index < students.Count - 1; index++)
            {
                int id = students[index].StudentId;
                for (int innerLoop = index + 1; innerLoop < students.Count; innerLoop++)
                    if (students[innerLoop].StudentId == id)
                        throw new Exception(
                                "Duplicate student Ids not allowed in the class list");
            }
            this.CourseId = courseId.Trim();
            this.students = students;
        }

        public ClassList(string courseId) :
            this(courseId, new List<Student>())
        {
        }

        public int ClassSize
        {
            get
            {
                return students.Count;
            }
        }

        public void AddStudent(Student anotherStudent)
        {
            if (anotherStudent == null)
                throw new Exception("Cannot add null student");
            if (students.Count >= CLASS_LIMIT)
                throw new Exception("Class Limit Exceeded - Cannot add student");
            for (int index = 0; index < students.Count - 1; index++)
            {
                int id = students[index].StudentId;
                if (anotherStudent.StudentId == id)
                    throw new Exception(
                            "Duplicate student Ids not allowed in the class list");
            }
            students.Add(anotherStudent);
        }

        public Student FindStudent(int studentId)
        {
            Student found = null;
            for (int index = 0; index < students.Count && found == null; index++)
                if (students[index].StudentId == studentId)
                    found = students[index];
            return found;
        }

        public Student RemoveStudent(int studentId)
        {
            Student found = FindStudent(studentId);
            if (found != null)
                students.Remove(found);
            return found;
        }
    }
}
