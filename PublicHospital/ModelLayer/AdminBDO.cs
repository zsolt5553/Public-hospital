using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class AdminBDO
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string city { get; set; }
        public int zip { get; set; }
        public string street { get; set; }
        public int streetNr { get; set; }
        public string phoneNr { get; set; }

        public AdminBDO() { }

        public AdminBDO (int id, string firstName, string lastName, string city, int zip, string street,
            int streetNr, string phoneNr)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;
            this.zip = zip;
            this.street = street;
            this.streetNr = streetNr;
            this.phoneNr = phoneNr;
        }
    }
}
