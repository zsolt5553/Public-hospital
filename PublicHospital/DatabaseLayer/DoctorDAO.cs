using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using PersistenceLayer;

namespace DatabaseLayer
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
                        description = doctorObj.description,
                        specialty = doctorObj.specialty
                    };
            }
            return doctorBDO;
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
