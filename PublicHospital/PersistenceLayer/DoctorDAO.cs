using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;

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

        public DataTable GetDoctorTable()
        {
            DataTable doctors = null;
            using (var PHEntities = new PublicHospitalEntities())
            {
                var table = PHEntities.Doctor.Where(doctor => !doctor.isDeleted);
                if (table !=null)
                {
                    doctors = CopyGenericToDataTable<Doctor>(table);
                }
            }
            return doctors;
        }

        private DataTable CopyGenericToDataTable<T>(IQueryable<T> items) 
        {
            var properties = typeof(T).GetProperties();
            var result = new DataTable();

            foreach (var property in properties)
            {
                result.Columns.Add(property.Name,property.PropertyType);
            }

            foreach (var item in items)
            {
                var row = result.NewRow();

                foreach (var property in properties)
                {
                    var itemValue = property.GetValue(item, new Object[] { });
                    row[property.Name] = itemValue;
                }
                result.Rows.Add(row);
            }
            return result;
        }

        public List<DoctorBDO> GetAllDoctors()
        {
            List<DoctorBDO> doctors = null;
            DoctorBDO doctorBDO = null;
            using (var PHEntities = new PublicHospitalEntities())
            {
                var listInDb = (from d in PHEntities.Doctor
                                select d).ToList();
                if (listInDb != null)
                {
                    doctors = new List<DoctorBDO>();
                    doctorBDO = new DoctorBDO();
                    foreach (Doctor doctorObj in listInDb)
                    {
                        if (!doctorObj.isDeleted)
                        {
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
                            doctors.Add(doctorBDO);
                        }
                    }
                }
            }
            return doctors;
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
                    specialty = doctorBDO.specialty,
                    description = doctorBDO.description,
                    isDeleted = doctorBDO.isDeleted,
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
