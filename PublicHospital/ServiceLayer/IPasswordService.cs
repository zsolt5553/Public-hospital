using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLayer
{
    [ServiceContract]
    public interface IPasswordService
    {
        [OperationContract]
        [FaultContract(typeof(PasswordFault))]
        int[] authenticatePerson(string login, string password, ref string message);
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