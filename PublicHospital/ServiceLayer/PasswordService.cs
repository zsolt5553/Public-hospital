using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PasswordService" in both code and config file together.
    public class PasswordService : IPasswordService
    {
        public void DoWork()
        {
        }

        public DataLayer.AdminBDO authenticatePerson(string login, string password)
        {
            throw new NotImplementedException();
        }
    }
}
