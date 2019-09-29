using System;
using System.Linq;

namespace Topic.Q.Examples
{
    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "My name is " + Name;
        }
    }
}
