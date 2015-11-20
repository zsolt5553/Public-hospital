using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using ModelLayer;

namespace ControlLayer
{
    public class CtrPassword
    {
        private DBPasswordAccess db;
        public CtrPassword()
        {
            db = new DBPasswordAccess();
        }

        public Admin authenticatePerson(string login, string password)
        {
            if (db.authenticatePerson(login, password) != null)
            {
                //add people db
                return new Admin();
            }
            else
                return null;
        }

        public bool insertPassword(Admin a)
        {
            return db.insertPassword(a);
        }

        public bool deletePassword(Admin a)
        {
            return db.deletePassword(a);
        }

        public bool updatePassword(Admin a)
        {
            return db.updatePassword(a, a);
        }
    }
}
