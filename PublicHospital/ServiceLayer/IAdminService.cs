using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLayer
{
    [ServiceContract]
    public interface IAdminService
    {
        [OperationContract]
        [FaultContract(typeof(AdminFault))]
        Admin GetAdmin(int id);

        [OperationContract]
        [FaultContract(typeof(AdminFault))]
        bool SaveAdmin(ref Admin admin,
            ref string message);

        [OperationContract]
        [FaultContract(typeof(AdminFault))]
        bool UpdateAdmin(ref Admin admin,
            ref string message);
    }

    [DataContract]
    public class Admin
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string firstName { get; set; }
        [DataMember]
        public string lastName { get; set; }
        [DataMember]
        public string city { get; set; }
        [DataMember]
        public int zip { get; set; }
        [DataMember]
        public string street { get; set; }
        [DataMember]
        public int streetNr { get; set; }
        [DataMember]
        public string phoneNr { get; set; }
        [DataMember]
        public string login { get; set; }
        [DataMember]
        public string pass { get; set; }
        [DataMember]
        public byte[] RowVersion { get; set; }

    }
    [DataContract]
    public class AdminFault
    {
        public AdminFault(string msg)
        {
            FaultMessage = msg;
        }

        [DataMember]
        public string FaultMessage;
    }
}

