using System;
using System.Linq;

namespace Topic.G.Examples
{
    public class Person
    {
        private string _FirstName;
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(value.Trim()))
                    throw new Exception("FirstName cannot be empty");
                _FirstName = value.Trim();
            }
        }

        private string _LastName;
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(value.Trim()))
                    throw new Exception("LastName cannot be empty");
                _LastName = value.Trim();
            }
        }

        public DateTime BirthDate { get; private set; }

        public int Age
        {
            get
            {
                int currentAge = 0;
                // straight years calculation
                currentAge = DateTime.Today.Year - BirthDate.Year;
                // Check to see if we're on the "early" side of their birthday
                if (BirthDate > DateTime.Today.AddYears(-currentAge))
                    currentAge--;
                return currentAge;
            }
        }
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            if (birthDate.CompareTo(DateTime.Today) > 0)
                throw new Exception("Birth dates in the future are not allowed");
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }


        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public string Initials
        {
            get
            {
                return FirstName[0] + "." + LastName[0] + ".";
            }
        }
        public string LifeStage
        {
            get
            {
                string stage;
                if (Age == 0)
                    stage = "infant";
                else if (Age < 3)
                    stage = "toddler";
                else if (Age < 5)
                    stage = "preschooler";
                else if (Age < 18)
                    stage = "school age";
                else
                    stage = "adult";
                return stage;
            }
        }
    }
}
