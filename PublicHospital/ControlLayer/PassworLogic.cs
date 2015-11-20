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
        public CtrPassword()
        {

        }

        public Admin authenticatePerson(string login, string password)
        {
            if (db.authenticatePerson(login, password) != null)
            {
                return new Admin();
            }
            else
                return null;
        }
    }
}
