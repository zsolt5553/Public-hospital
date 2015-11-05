using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class Doctor : Person
    {
        private string specialty { get; set; }
        private string description { get; set; }

        public Doctor (string firstName, string lastName, string city, int zip, string street,
            int streetNr, string phoneNr, string specialty, string description) :
                base(firstName, lastName, city, zip, street, streetNr, phoneNr)
        {
            this.specialty = specialty;
            this.description = description;
        }
    }
}
