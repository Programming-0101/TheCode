using System;
using System.Linq;

namespace Topic.I.Examples
{
    public class Address
    {
        public string Street { get; set; }
        public string Unit { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public Address(string unit, string street, string city, string state,
                string zipCode)
        {
            this.Unit = unit;
            this.Street = street;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
        }
    }
}
