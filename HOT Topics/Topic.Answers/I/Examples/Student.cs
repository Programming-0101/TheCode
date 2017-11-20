using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.I.Examples
{
    public class Student
    {
        private string _name; // The full name of the student
        private string _program; // The course program; e.g.: "COMP"
        private double _gradePointAverage; // GPA is from 1.0 to 9.0
        private Address _homeAddress;

        public Student(string name, Address homeAddress, GenderType gender,
            int studentId, string program, double gradePointAverage,
            bool isFullTime)
        {
            if (studentId < 100000000 || studentId > 999999999)
                throw new System.Exception("Student Ids must be 9 digits");
            Name = name;
            HomeAddress = homeAddress;
            Gender = gender;
            StudentId = studentId;
            Program = program;
            GradePointAverage = gradePointAverage;
            IsFullTime = isFullTime;
        }

        public GenderType Gender { get; set; }
        public bool IsFullTime { get; set; }
        public int StudentId { get; private set; }

        public string Name
        {
            get
            { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value) ||
                    string.IsNullOrEmpty(value.Trim()))
                    throw new System.Exception("name cannot be empty");
                this._name = value.Trim();
            }
        }

        public Address HomeAddress
        {
            get
            { return _homeAddress; }
            set
            {
                if (value == null)
                    throw new System.Exception("Address is required");
                this._homeAddress = value;
            }
        }

        public string Program
        {
            get
            { return _program; }
            set
            {
                if (string.IsNullOrEmpty(value) ||
                    string.IsNullOrEmpty(value.Trim()))
                    throw new System.Exception("Program cannot be empty");
                this._program = value.Trim();
            }
        }

        public double GradePointAverage
        {
            get
            { return _gradePointAverage; }
            set
            {
                if (value < 0 || value > 9)
                    throw new System.Exception("GPA must be between 0 and 9 inclusive");
                this._gradePointAverage = value;
            }
        }


        public override string ToString()
        {
            return "(" + StudentId + ") " + Name;
        }
    }
}
