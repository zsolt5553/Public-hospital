using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class PatientBDO : AdminBDO
    {
        public DateTime dateOfBirth { get; set; }

        public PatientBDO () { }
        public PatientBDO(int id, string firstName, string lastName, string city, int zip, string street,
            int streetNr, string phoneNr, DateTime dateOfBirth) :
                base(id, firstName, lastName, city, zip, street, streetNr, phoneNr)
        {
            this.dateOfBirth = dateOfBirth;
        }
    }
}
