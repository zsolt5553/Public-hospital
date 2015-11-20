using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceLayer
{
   public class Password
    {
        public Password() { }

        public string authenticatePerson(string login, string password)
        {
            string[] dbData = getPasswordSaltDB(login);
            if (dbData != null)
            {
                if (comparePasswords(password, dbData[0], dbData[1]) == true)
                    return login;
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
                var adminBDO = PHEntities.Admin.Where(p => p.login == login);
                var doctorBDO = PHEntities.Doctor.Where(p => p.login == login);
                var patientBDO = PHEntities.Patient.Where(p => p.login == login);
                bool found = false;
                while (!found)
                {

                }
                if (admin.FirstOrDefault() != null)
                    return new string[] { admin.First().pass, admin.First().salt };
                else
                    return null;
            }
        }

        private string[] getFullyHash(string password)
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
