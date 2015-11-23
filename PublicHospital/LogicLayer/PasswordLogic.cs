using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenceLayer;
using DataLayer;

namespace LogicLayer
{
    public class PasswordLogic
    {
        Password pass = new Password();
        public AdminBDO authenticatePerson(string login, string password, ref string message)
        {
            AdminBDO person = pass.authenticatePerson(login, password);
            if (person != null)
            {
                message = "Successful authentication";
                return person;
            }
            else
            {
                message = "Try once agin";
                return null;
            }
        }
    }
}
