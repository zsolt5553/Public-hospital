using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceLayer
{
    class AdminDAO
    {
        public Admin GetAdmin (int id)
        {
            Admin admin = null;
            using (var PHEntities = new PublicHospitalEntities())
            {
                var adminObj = (from a in PHEntities.Admin
                             where a.id == id
                             select a).FirstOrDefault();
                if (adminObj != null)
                    admin = new Admin()
                    {
                        id = adminObj.id,
                        firstName = adminObj.firstName,
                        lastName = adminObj.lastName,
                        city = adminObj.city,
                        street = adminObj.street,
                        streetNr = adminObj.streetNr,
                        phoneNr = adminObj.phoneNr,
                        zip = adminObj.zip,
                    };
            }
                return admin;
        }

        public bool UpdateAdmin(ref Admin admin,
            ref string massage)
        {
            massage = "Admin updated successfully";
            var ret = true;
            using (var PHEntites = new PublicHospitalEntities())
            {
                var adminId = admin.id;
                var adminInDb = (from a
                                 in PHEntites.Admin
                                 where a.id == adminId
                                 select a).FirstOrDefault();
                if (adminInDb == null)
                {
                    throw new Exception("No admin with id " +
                                        admin.id);
                }
                adminInDb.firstName = admin.firstName;
                adminInDb.lastName = admin.lastName;
                adminInDb.city = admin.city;
                adminInDb.zip = admin.zip;
                adminInDb.street = admin.street;
                adminInDb.streetNr = admin.streetNr;
                adminInDb.phoneNr = admin.phoneNr;
                PHEntites.Admin.Attach(adminInDb);
                PHEntites.Entry(adminInDb).State = System.Data.Entity.EntityState.Modified;
                var num = PHEntites.SaveChanges();
                if (num != 1)
                {
                    ret = false;
                    massage = "Admin was not updated";
                }
            }
            return ret;
        }
    }
}
