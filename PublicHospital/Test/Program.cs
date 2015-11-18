using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceLayer;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "";
            Admin ad = new Admin();
            ad.firstName = "Zsolt";
            ad.lastName = "Bari";
            ad.city = "Aalborg";
            ad.zip = 9000;
            ad.street = "Toldstrupsgade";
            ad.streetNr = 14;
            ad.phoneNr = "84124123";

            WCFAdminServiceRef.IAdminService serviceRef =
                new WCFAdminServiceRef.AdminServiceClient();
            serviceRef.InsertAdmin(ad,  message);
        }
    }
}
