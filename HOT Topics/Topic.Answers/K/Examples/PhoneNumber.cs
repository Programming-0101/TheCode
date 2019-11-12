using System;
using System.Linq;

namespace Topic.K.Examples
{
    public class PhoneNumber
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }
        public PhoneNumber(string firstName, string lastName, string number)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
        }
    }
}
