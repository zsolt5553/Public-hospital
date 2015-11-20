using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class PasswordLogic
    {
        public PasswordLogic() { }

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
