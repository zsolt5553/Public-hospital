using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPasswordService" in both code and config file together.
    [ServiceContract]
    public interface IPasswordService
    {
        [OperationContract]
        [FaultContract(typeof(PasswordFault))]
        AdminBDO authenticatePerson(string login, string password);
    }

    [DataContract]
    public class Password
    {
        [DataMember]
        public int id { get; }
    }

    [DataContract]
    public class PasswordFault
    {
        public PasswordFault(string msg)
        {
            FaultMessage = msg;
        }

        [DataMember]
        public string FaultMessage;
    }
}
