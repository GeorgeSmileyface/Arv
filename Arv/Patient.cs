using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    public class Patient : Person
    {
        public string Allergies { get; set; }
        
        public Patient(string name, int phoneNumber, string emailAddress, string allergies)
            : base(name, phoneNumber, emailAddress)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            Allergies = allergies;
        }
    }
}
