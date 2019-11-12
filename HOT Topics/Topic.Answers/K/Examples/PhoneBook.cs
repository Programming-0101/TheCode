using System;
using System.Collections.Generic;
using System.Linq;

namespace Topic.K.Examples
{
    public class PhoneBook
    {
        private List<PhoneNumber> Number { get; set; }

        public PhoneBook()
        {
            Number = new List<PhoneNumber>();
        }

        public void AddPhoneNumber(PhoneNumber entry)
        {
            if (entry == null)
                throw new System.Exception("The phone number entry cannot be null");
            Number.Add(entry);
        }

        public PhoneNumber GetPhoneNumber(int index)
        {
            return Number[index];
        }

        public int Count
        {
            get
            {
                return Number.Count;
            }
        }

        public PhoneNumber FindPhoneNumber(string telephoneNumber)
        {
            PhoneNumber found = null;
            foreach (PhoneNumber item in Number)
            {
                if (item.Number.Equals(telephoneNumber))
                {
                    found = item;
                    break;
                }
            }
            return found;
        }

        public List<PhoneNumber> FindPhoneNumbersByLastName(string lastName)
        {
            List<PhoneNumber> found = new List<PhoneNumber>();
            foreach (PhoneNumber item in Number)
            {
                if (item.LastName.Equals(lastName))
                {
                    found.Add(item);
                }
            }
            return found;
        }
    }
}
