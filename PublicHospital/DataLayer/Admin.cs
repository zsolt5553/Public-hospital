using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Admin
    {
        private int id { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string city { get; set; }
        private int zip { get; set; }
        private string street { get; set; }
        private int streetNr { get; set; }
        private string phoneNr { get; set; }

        public Admin (int id, string firstName, string lastName, string city, int zip, string street,
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
