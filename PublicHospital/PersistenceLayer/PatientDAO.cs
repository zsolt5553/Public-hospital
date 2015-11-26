using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;

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
                        login = patientObj.login,
                        pass = patientObj.pass,
                        dateOfBirth = patientObj.dateOfBirth
                    };
            }
            return patientBDO;
        }

        private int GetNextID()
        {
            int nextID = -1;

            using (var PHEntities = new PublicHospitalEntities())
            {
                var ids = (from a in PHEntities.Patient select a.id).ToList();
                nextID = ids.Max();
            };

            if (nextID == -1)
            {
                throw new Exception("Patient id couldn't be generated");
            }
            else
            {
                return nextID + 1;
            }
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
                //without username and pass
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

        public List<PatientBDO> GetAllpatients()
        {
            List<PatientBDO> patientList = null;
            using (var PHEntities = new PublicHospitalEntities())
            {
                var patientDatabase = from p in PHEntities.Patient select p;
                if ((patientDatabase.FirstOrDefault() != null))
                {
                    patientList = new List<PatientBDO>();
                    foreach (var patient in patientDatabase)
                    {
                        patientList.Add(new PatientBDO()
                        {
                            id = patient.id,
                            firstName = patient.firstName,
                            lastName = patient.lastName,
                            city = patient.city,
                            street = patient.street,
                            streetNr = patient.streetNr,
                            phoneNr = patient.phoneNr,
                            zip = patient.zip,
                            login = patient.login,
                            pass = patient.pass,
                            dateOfBirth = patient.dateOfBirth
                        });
                    }
                }
            }
            return patientList;
        }

        //public DataTable GetAllpatients()
        //{
        //    DataTable patients = null;
        //    using (var PHEntities = new PublicHospitalEntities())
        //    {
        //        var table = from p in PHEntities.Patient select p;
        //        if (table != null)
        //        {
        //            patients = CopyGenericToDataTable<Patient>(table);
        //        }
        //    }
        //    return patients;
        //}

        //private DataTable CopyGenericToDataTable<T>(IQueryable<T> items)
        //{
        //    var properties = typeof(T).GetProperties();
        //    var result = new DataTable();

        //    foreach (var property in properties)
        //    {
        //        result.Columns.Add(property.Name, property.PropertyType);
        //    }

        //    foreach (var item in items)
        //    {
        //        var row = result.NewRow();

        //        foreach (var property in properties)
        //        {
        //            var itemValue = property.GetValue(item, new Object[] { });
        //            row[property.Name] = itemValue;
        //        }
        //        result.Rows.Add(row);
        //    }
        //    return result;
        //}
    }
}
