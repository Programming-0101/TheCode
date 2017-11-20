using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.H.Examples
{
    public class LetterGrade
    {
        private char _Grade;

        public char Grade
        {
            get { return _Grade; }
            set { this._Grade = char.ToUpper(value); }
        }

        public LetterGrade(char grade)
        {
            Grade = grade;
        }


        public override string ToString()
        {
            string description;
            switch (_Grade)
            {
                case 'A':
                    description = "A - 80-100% - Greatly Above Standards";
                    break;
                case 'B':
                    description = "B - 70-79% - Above Standards";
                    break;
                case 'C':
                    description = "C - 60-69% - At Government Standards";
                    break;
                case 'D':
                    description = "D - 50-60% - Lower Standards";
                    break;
                case 'F':
                    description = "F - 0-49% - Failure";
                    break;
                default:
                    description = "Invalid Letter Grade";
                    break;
            }
            return description;
        }
    }
}
