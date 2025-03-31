using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    public class Person
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public Person(string name, int phoneNumber, string emailAddress)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
        }
    }
}
