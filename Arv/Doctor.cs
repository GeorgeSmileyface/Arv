using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    public class Doctor : Person
    {
        public string Specialty { get; set; }

        public Doctor(string name, int tlfNumber, string email, string specialty)
            : base(name, tlfNumber, email)
        {
            Name = name;
            PhoneNumber = tlfNumber;
            EmailAddress = email;
            Specialty = specialty;
        }
    }
}
