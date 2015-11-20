﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace PersistenceLayer
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
                        zip = adminObj.zip,
                        login = adminObj.login,
                        pass = adminObj.pass
                    };
            }
                return adminBDO;
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
                //without username and pass
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