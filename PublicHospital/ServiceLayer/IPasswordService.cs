using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLayer
{
    [ServiceKnownType(typeof(Admin))]
    [ServiceKnownType(typeof(Doctor))]
    [ServiceContract]
    public interface IPasswordService
    {
        [OperationContract]
        [FaultContract(typeof(PasswordFault))]
        People authenticatePerson(string login, string password, ref string message);
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

    [DataContract]
    [KnownType(typeof(Admin))]
    [KnownType(typeof(Doctor))]
    public class People
    {
        //[DataMember]
        //public Admin aa { get; }
        //[DataMember]
        //public Doctor dd { get; }
      //  [DataMember]
    //    public Doctor pp { get; }
    }
}