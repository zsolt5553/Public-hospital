using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class DoctorBDO : AdminBDO
    {
        public string specialty { get; set; }
        public string description { get; set; }

        public DoctorBDO () { }
        public DoctorBDO (int id, string firstName, string lastName, string city, int zip, string street,
            int streetNr, string phoneNr, string specialty, string description, string login, string password) :
                base(id, firstName, lastName, city, zip, street, streetNr, phoneNr, login, password)
        {
            this.specialty = specialty;
            this.description = description;
        }
    }
}
