using System;
using System.Linq;

namespace Topic.G.Examples
{
    public class Student
    {
        #region Fields
        private string _Name;
        private char _Gender;
        private int _StudentId;
        private string _Program;
        private double _GradePointAverage;
        private bool _IsFullTime;
        #endregion

        #region Properties
        public string Name
        {
            get { return _Name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(value.Trim()))
                    throw new System.Exception("Name cannot be empty");
                _Name = value.Trim();
            }
        }

        public char Gender
        {
            get { return _Gender; }
            set
            {
                value = char.ToUpper(value);
                if (value != 'M' && value != 'F')
                    throw new Exception("Gender must be M or F");
                _Gender = value;
            }
        }

        public int StudentId
        {
            get { return _StudentId; }
            set
            {
                if (value < 100000000 || value > 999999999)
                    throw new Exception("Student Ids must be 9 digits");
                _StudentId = value;
            }
        }

        public string Program
        {
            get { return _Program; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(value.Trim()))
                    throw new Exception("Program cannot be empty");
                _Program = value.Trim();
            }
        }

        public double GradePointAverage
        {
            get { return _GradePointAverage; }
            set
            {
                if (value < 0 || value > 9)
                    throw new System.Exception("GPA must be between 0 and 9 inclusive");
                _GradePointAverage = value;
            }
        }

        public bool IsFullTime
        {
            get { return _IsFullTime; }
            set { _IsFullTime = value; }
        }
        #endregion

        #region Constructors
        public Student(string name, char gender, int studentId, string program, double gradePointAverage, bool isFullTime)
        {
            if (studentId < 100000000 || studentId > 999999999)
                throw new System.Exception("Student Ids must be 9 digits");
            this.Name = name;
            this.Gender = gender;
            this.StudentId = studentId;
            this.Program = program;
            this.GradePointAverage = gradePointAverage;
            this.IsFullTime = isFullTime;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"({StudentId}) {Name}";
        }
        #endregion
    }
}
