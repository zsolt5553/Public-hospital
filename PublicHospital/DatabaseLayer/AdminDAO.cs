using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using PersistenceLayer;

namespace DatabaseLayer
{
    public class AdminDAO
    {
        public AdminBDO GetAdmin (int id)
        {
            AdminBDO adminBDO = null;
            using (var PHEntities = new PublicHospitalEntities())
            {
                var adminObj = (from a in PHEntities.Admin
                             where a.id == id
                             select a).FirstOrDefault();
                if (adminObj != null)
                    adminBDO = new AdminBDO()
                    {
                        id = adminObj.id,
                        firstName = adminObj.firstName,
                        lastName = adminObj.lastName,
                        city = adminObj.city,
                        street = adminObj.street,
                        streetNr = adminObj.streetNr,
                        phoneNr = adminObj.phoneNr,
                        zip = adminObj.zip
                    };
            }
                return adminBDO;
        }

        public bool InsertAdmin(ref AdminBDO adminBDO,
            ref string massage)
        {
            massage = "Admin inserted successfully";
            var ret = true;
            using (var PHEntities = new PublicHospitalEntities())
            {
                PHEntities.Admin.Add(new Admin
                {
                    id = adminBDO.id,
                    firstName = adminBDO.firstName,
                    lastName = adminBDO.lastName,
                    city = adminBDO.city,
                    street = adminBDO.street,
                    streetNr = adminBDO.streetNr,
                    phoneNr = adminBDO.phoneNr,
                    zip = adminBDO.zip
                });
                var num = PHEntities.SaveChanges();
                if (num != 1)
                {
                    ret = false;
                    massage = "Admin was not inserted";
                }
            }
            return ret;
        }

        public bool UpdateAdmin(ref AdminBDO adminBDO,
            ref string massage)
        {
            massage = "Admin updated successfully";
            var ret = true;
            using (var PHEntites = new PublicHospitalEntities())
            {
                var adminId = adminBDO.id;
                var adminInDb = (from a
                                 in PHEntites.Admin
                                 where a.id == adminId
                                 select a).FirstOrDefault();
                if (adminInDb == null)
                {
                    throw new Exception("No admin with id " +
                                        adminBDO.id);
                }
                adminInDb.firstName = adminBDO.firstName;
                adminInDb.lastName = adminBDO.lastName;
                adminInDb.city = adminBDO.city;
                adminInDb.zip = adminBDO.zip;
                adminInDb.street = adminBDO.street;
                adminInDb.streetNr = adminBDO.streetNr;
                adminInDb.phoneNr = adminBDO.phoneNr;
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
