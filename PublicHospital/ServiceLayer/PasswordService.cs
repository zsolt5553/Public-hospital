using DataLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLayer
{
    public class PasswordService : IPasswordService
    {
        PasswordLogic pas = new PasswordLogic();
        public int[] authenticatePerson(string login, string password, ref string message)
        {
            int[] idAndType = null;
            try
            {
                idAndType = pas.authenticatePerson(login, password, ref message);
            }
            catch (Exception e)
            {
                var msg = e.Message;
                var reason = "authenticatePerson exception";
                throw new FaultException<PasswordFault>(new PasswordFault(msg), reason);
            }
            return idAndType;
        }
    }
}
