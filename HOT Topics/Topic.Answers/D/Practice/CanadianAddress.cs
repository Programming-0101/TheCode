using System;
using System.Linq;

namespace Topic.D.Practice
{
    public class CanadianAddress
    {
        public string Street { get; set; }
        public string Unit { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string RuralRoute { get; set; }
        public string BoxNumber { get; set; }
        public CanadianAddress(string street, string unit, string city, string province, string postalCode, string ruralRoute, string boxNumber)
        {
            Street = street;
            Unit = unit;
            City = city;
            Province = province;
            PostalCode = postalCode;
            RuralRoute = ruralRoute;
            BoxNumber = boxNumber;
        }
        public override string ToString()
        {
            return $"{Street}, {City}, {Province}  {PostalCode}";
        }
    }
}
