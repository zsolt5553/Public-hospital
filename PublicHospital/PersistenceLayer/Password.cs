using DataLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceLayer
{
    public class Password
    {
        public string[] authenticatePerson(string login, string password)
        {
            string[] dbData = getPasswordSaltDB(login);
            if (dbData != null)
            {
                if (comparePasswords(password, dbData[0], dbData[1]) == true)
                {
                    string[] idAndType = null;
                    switch (dbData[3])
                    {
                        case "admin":
                            idAndType = new string[] { dbData[2], "0", setSessionIdDB(dbData[2], 0) };
                            break;
                        case "doctor":
                            idAndType = new string[] { dbData[2], "1", setSessionIdDB(dbData[2], 1) };
                            break;
                        case "patient":
                            idAndType = new string[] { dbData[2], "2", setSessionIdDB(dbData[2], 2) };
                            break;
                    }
                    return idAndType;
                }
                else
                    return null;
            }
            else
                return null;
        }

        private string[] getPasswordSaltDB(string login)
        {
            using (var PHEntities = new PublicHospitalEntities())
            {
                string[] person = null;
                var admin = PHEntities.Admin.Where(a => a.login == login);
                var doctor = PHEntities.Doctor.Where(d => d.login == login);
                var patient = PHEntities.Patient.Where(p => p.login == login);
                if (admin.FirstOrDefault() != null)
                    person = new string[] { admin.First().pass, admin.First().salt, admin.First().id.ToString(), "admin", };
                else if (doctor.FirstOrDefault() != null)
                {
                    person = new string[] { doctor.First().pass, doctor.First().salt, doctor.First().id.ToString(), "doctor" };
                }
                else if (patient.FirstOrDefault() != null)
                {
                    person = new string[] { patient.First().pass, patient.First().salt, patient.First().id.ToString(), "patient" };
                }
                return person;
            }
        }

        private string setSessionIdDB(string idd, int type)
        {
            string sessionID = getSessionID();
            int changes = 0;
            using (var PHEntities = new PublicHospitalEntities())
            {
                int id = 0;
                Int32.TryParse(idd, out id);
                switch (type)
                {
                    case 0:
                        var admin = (from a in PHEntities.Admin where a.id == id select a).FirstOrDefault();
                        admin.sessionID = sessionID;
                        changes = PHEntities.SaveChanges();
                        break;
                    case 1:
                        var doctor = (from a in PHEntities.Doctor where a.id == id select a).FirstOrDefault();
                        doctor.sessionID = sessionID;
                        changes = PHEntities.SaveChanges();
                        break;
                    case 2:
                        var patient = (from a in PHEntities.Patient where a.id == id select a).FirstOrDefault();
                        patient.sessionID = sessionID;
                        changes = PHEntities.SaveChanges();
                        break;
                }
                if (changes != 1)
                    sessionID = null;
            }
            return sessionID;
        }

        private string getSessionIdDB(int id)
        {
            string sessionID = null;
            using (var PHEntities = new PublicHospitalEntities())
            {
                var admin = from a in PHEntities.Admin where a.id == id select a;
                var doctor = from a in PHEntities.Doctor where a.id == id select a;
                var patient = from a in PHEntities.Patient where a.id == id select a;
                if (admin.FirstOrDefault() != null)
                    sessionID = admin.First().sessionID.ToString();
                else if (doctor.FirstOrDefault() != null)
                    sessionID = doctor.First().sessionID.ToString();
                else if (patient.FirstOrDefault() != null)
                    sessionID = patient.First().sessionID.ToString();
            }
            return sessionID;
        }

        public string[] getFullyHash(string password)
        {
            string salt = getRandomNumber(20);
            return new string[] { getPBKDF2(password, salt), salt };
        }

        public bool compareSessionID(AdminBDO person)
        {
            if (getSessionIdDB(person.id).Equals(person.sessionID))
                return true;
            else
                return false;
        }

        private string getRandomNumber(int byteSize)
        {
            RNGCryptoServiceProvider generate = new RNGCryptoServiceProvider();
            byte[] number = new byte[byteSize];
            generate.GetBytes(number);
           
            return Convert.ToBase64String(number);  
        }

        private string getSessionID()
        {
            return getRandomNumber(30);
        }

        private bool comparePasswords(string password, string hash, string salt)
        {
            if (getPBKDF2(password, salt).Equals(hash))
                return true;
            else
                return false;
        }

        private string getPBKDF2(string password, string salt)
        {
            Rfc2898DeriveBytes hash = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes(salt), 6000);
            return Convert.ToBase64String(hash.GetBytes(50));
        }
    }
}