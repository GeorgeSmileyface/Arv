using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    public class Doctor
    {
        public string Specialty { get; set; }

        public Doctor(string specialty)
        {
            Specialty = specialty;
        }
    }
}
