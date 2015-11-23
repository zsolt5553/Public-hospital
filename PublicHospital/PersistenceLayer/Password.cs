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
        public int[] authenticatePerson(string login, string password)
        {
            string[] dbData = getPasswordSaltDB(login);
            if (dbData != null)
            {
                if (comparePasswords(password, dbData[0], dbData[1]) == true)
                {
                    int[] idAndType = null;
                    switch (dbData[3])
                    {
                        case "admin":
                            idAndType = new int[] { int.Parse(dbData[3]), 0 };
                            break;
                        case "doctor":
                            idAndType = new int[] { int.Parse(dbData[3]), 0 };
                            break;
                        case "patient":
                            //idAndType = new PatientDAO().GetPatient(int.Parse(dbData[3]));
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
                    person = new string[] { admin.First().pass, admin.First().salt, admin.First().id.ToString(), "admin" };
                if (doctor.FirstOrDefault() != null)
                    person = new string[] { doctor.First().pass, doctor.First().salt, doctor.First().id.ToString(), "doctor" };
                if (patient.FirstOrDefault() != null)
                    person = new string[] { patient.First().pass, patient.First().salt, patient.First().id.ToString(), "patient" };
                return person;
            }
        }

        public string[] getFullyHash(string password)
        {
            RNGCryptoServiceProvider generate = new RNGCryptoServiceProvider();
            byte[] salt = new byte[20];
            generate.GetBytes(salt);
            return new string[] { getPBKDF2(password, Convert.ToBase64String(salt)), Convert.ToBase64String(salt) };
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