using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace PersistenceLayer
{
    public class DoctorDAO
    {
        public DoctorBDO GetDoctor(int id)
        {
            DoctorBDO doctorBDO = null;
            using (var PHEntities = new PublicHospitalEntities())
            {
                var doctorObj = (from a in PHEntities.Doctor
                                where a.id == id
                                select a).FirstOrDefault();
                if (doctorObj != null)
                    doctorBDO = new DoctorBDO()
                    {
                        id = doctorObj.id,
                        firstName = doctorObj.firstName,
                        lastName = doctorObj.lastName,
                        city = doctorObj.city,
                        street = doctorObj.street,
                        streetNr = doctorObj.streetNr,
                        phoneNr = doctorObj.phoneNr,
                        zip = doctorObj.zip,
                        login = doctorObj.login,
                        pass = doctorObj.pass,
                        description = doctorObj.description,
                        specialty = doctorObj.specialty
                    };
            }
            return doctorBDO;
        }

        private int GetNextID()
        {
            int nextID = -1;

            using (var PHEntities = new PublicHospitalEntities())
            {
                var ids = (from a in PHEntities.Doctor select a.id).ToList();
                nextID = ids.Max();
            };

            if (nextID == -1)
            {
                throw new Exception("Doctor id couldn't be generated");
            }
            else
            {
                return nextID + 1;
            }
        }

        public bool InsertDoctor(ref DoctorBDO doctorBDO,
            ref string massage)
        {
            massage = "Doctor inserted successfully";
            var ret = true;
            Password passObj = new Password();
            string[] passAndSalt = passObj.getFullyHash(doctorBDO.pass);
            using (var PHEntities = new PublicHospitalEntities())
            {
                PHEntities.Doctor.Add(new Doctor
                {
                    id = GetNextID(),
                    firstName = doctorBDO.firstName,
                    lastName = doctorBDO.lastName,
                    city = doctorBDO.city,
                    street = doctorBDO.street,
                    streetNr = doctorBDO.streetNr,
                    phoneNr = doctorBDO.phoneNr,
                    zip = doctorBDO.zip,
                    login = doctorBDO.login,

                    pass = passAndSalt[0],
                    salt = passAndSalt[1]
                });
                var num = PHEntities.SaveChanges();
                if (num != 1)
                {
                    ret = false;
                    massage = "Doctor was not inserted";
                }
            }
            return ret;
        }

        public bool UpdateDoctor(ref DoctorBDO doctorBDO,
            ref string massage)
        {
            massage = "Doctor updated successfully";
            var ret = true;
            using (var PHEntites = new PublicHospitalEntities())
            {
                var doctorId = doctorBDO.id;
                var doctorInDb = (from a
                                 in PHEntites.Doctor
                                 where a.id == doctorId
                                 select a).FirstOrDefault();
                if (doctorInDb == null)
                {
                    throw new Exception("No doctor with id " +
                                        doctorBDO.id);
                }
                doctorInDb.firstName = doctorBDO.firstName;
                doctorInDb.lastName = doctorBDO.lastName;
                doctorInDb.city = doctorBDO.city;
                doctorInDb.zip = doctorBDO.zip;
                doctorInDb.street = doctorBDO.street;
                doctorInDb.streetNr = doctorBDO.streetNr;
                doctorInDb.phoneNr = doctorBDO.phoneNr;
                doctorInDb.description = doctorBDO.description;
                doctorInDb.specialty = doctorBDO.specialty;
                //without username and pass
                PHEntites.Doctor.Attach(doctorInDb);
                PHEntites.Entry(doctorInDb).State = System.Data.Entity.EntityState.Modified;
                var num = PHEntites.SaveChanges();
                if (num != 1)
                {
                    ret = false;
                    massage = "Doctor was not updated";
                }
            }
            return ret;
        }
    }
}
