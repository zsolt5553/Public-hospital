using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DoctorBDO : AdminBDO
    {
        public string specialty { get; set; }
        public string description { get; set; }
        public bool isDeleted { get; set; }

        public DoctorBDO ()
        {
            isDeleted = false;
        }
        public DoctorBDO (int id, string firstName, string lastName, string city, int zip, string street,
            int streetNr, string phoneNr, string login, string pass, string specialty, string description) :
                base(id, firstName, lastName, city, zip, street, streetNr, phoneNr, login,pass)
        {
            isDeleted = false;
            this.specialty = specialty;
            this.description = description;
        }

        public override string ToString()
        {
            return "doctor";
        }
    }
}
