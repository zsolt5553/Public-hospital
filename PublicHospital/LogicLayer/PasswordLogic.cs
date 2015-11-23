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

        public int[] authenticatePerson(string login, string password, ref string message)
        {
            int[] idAndType = pass.authenticatePerson(login, password);
            if (idAndType != null)
            {
                message = "Successful authentication";
                return idAndType;
            }
            else
            {
                message = "Try once agin";
                return null;
            }
        }
    }
}