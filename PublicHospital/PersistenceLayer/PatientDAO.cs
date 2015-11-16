using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace PersistenceLayer
{
    public class PatientDAO
    {
        public PatientBDO GetPatient(int id)
        {
            PatientBDO patientBDO = null;
            using (var PHEntities = new PublicHospitalEntities())
            {
                var patientObj = (from a in PHEntities.Patient
                                where a.id == id
                                select a).FirstOrDefault();
                if (patientObj != null)
                    patientBDO = new PatientBDO()
                    {
                        id = patientObj.id,
                        firstName = patientObj.firstName,
                        lastName = patientObj.lastName,
                        city = patientObj.city,
                        street = patientObj.street,
                        streetNr = patientObj.streetNr,
                        phoneNr = patientObj.phoneNr,
                        zip = patientObj.zip,
                        dateOfBirth = patientObj.dateOfBirth
                    };
            }
            return patientBDO;
        }

        public bool UpdatePatient(ref PatientBDO patientBDO,
            ref string massage)
        {
            massage = "Patient updated successfully";
            var ret = true;
            using (var PHEntites = new PublicHospitalEntities())
            {
                var patientId = patientBDO.id;
                var patientInDb = (from a
                                 in PHEntites.Patient
                                 where a.id == patientId
                                 select a).FirstOrDefault();
                if (patientInDb == null)
                {
                    throw new Exception("No patient with id " +
                                        patientBDO.id);
                }
                patientInDb.firstName = patientBDO.firstName;
                patientInDb.lastName = patientBDO.lastName;
                patientInDb.city = patientBDO.city;
                patientInDb.zip = patientBDO.zip;
                patientInDb.street = patientBDO.street;
                patientInDb.streetNr = patientBDO.streetNr;
                patientInDb.phoneNr = patientBDO.phoneNr;
                patientInDb.dateOfBirth = patientBDO.dateOfBirth;
                PHEntites.Patient.Attach(patientInDb);
                PHEntites.Entry(patientInDb).State = System.Data.Entity.EntityState.Modified;
                var num = PHEntites.SaveChanges();
                if (num != 1)
                {
                    ret = false;
                    massage = "Patient was not updated";
                }
            }
            return ret;
        }
    }
}
