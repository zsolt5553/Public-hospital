using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceLayer
{
    public class Password
    {
        private static aaaEntities db;

        public DBPasswordAccess()
        {
            db = new aaaEntities();
        }

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

        public bool insertPassword(Admin a)
        {
            string[] hashSalt = getFullyHash(a.password);
            string querry = "INSERT INTO Passwords (login, pass, salt) VALUES (@login, @pass, @salt)";
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@login", a.login);
            parameters[1] = new SqlParameter("@pass", hashSalt[0]);
            parameters[2] = new SqlParameter("@salt", hashSalt[1]);
            try
            {
                int result = db.Database.ExecuteSqlCommand(querry, parameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deletePassword(Admin a)
        {
            string querry = "DELETE Passwords WHERE login = @login";
            try
            {
                int result = db.Database.ExecuteSqlCommand(querry, new SqlParameter("@login", a.login));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool updatePassword(Admin aOld, Admin aUpdated)
        {
            //if(authenticatePerson() == aOld.login
            //string[] hashSalt = getFullyHash(a.password);
            string querry = "UPDATE Passwords SET pass = @pass WHERE login =@login";
            SqlParameter[] parameters = new SqlParameter[3];
            //parameters[0] = new SqlParameter("@login", a.login);
            //parameters[1] = new SqlParameter("@pass", hashSalt[0]);
            //parameters[2] = new SqlParameter("@salt", hashSalt[1]);
            try
            {
                int result = db.Database.ExecuteSqlCommand(querry, parameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private string[] getPasswordSaltDB(String login)
        {
            var admin = db.Passwords.Where(p => p.login == login);
            if (admin.FirstOrDefault() != null)
                return new string[] { admin.First().pass, admin.First().salt };
            else
                return null;
        }

        private string[] getFullyHash(string password)
        {
            RNGCryptoServiceProvider generate = new RNGCryptoServiceProvider();
            byte[] salt = new byte[20];
            generate.GetBytes(salt);
            return new string[] { getSHA512(password, Convert.ToBase64String(salt)), Convert.ToBase64String(salt) };
        }

        private bool comparePasswords(string password, string hash, string salt)
        {
            if (getSHA512(password, salt).Equals(hash))
                return true;
            else
                return false;
        }

        private string getSHA512(string password, string salt)
        {
            SHA512 sha = new SHA512Managed();
            return Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(string.Concat(salt, password))));
        }
    }
}