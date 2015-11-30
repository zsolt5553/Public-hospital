using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    [ServiceContract]
    public interface IDoctorService
    {
        [OperationContract]
        [FaultContract(typeof(DoctorFault))]
        Doctor GetDoctor(int id);

        [OperationContract]
        [FaultContract(typeof(DoctorFault))]
        Doctor GetDoctorByName(string name);

        [OperationContract]
        [FaultContract(typeof(DoctorFault))]
        bool DeleteDoctor(ref Doctor doctor,
            ref string message);

        [OperationContract]
        [FaultContract(typeof(DoctorFault))]
        List<Doctor> GetAllDoctors();

        [OperationContract]
        [FaultContract(typeof(DoctorFault))]
        DataSet GetDoctorTable();

        [OperationContract]
        [FaultContract(typeof(DoctorFault))]
        bool SaveDoctor(ref Doctor doctor,
            ref string message);

        [OperationContract]
        [FaultContract(typeof(DoctorFault))]
        bool UpdateDoctor(ref Doctor doctor,
            ref string message);
    }

    [DataContract]
    public class Doctor
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
        public string specialty { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public byte[] RowVersion { get; set; }
    }
    [DataContract]
    public class DoctorFault
    {
        public DoctorFault(string msg)
        {
            FaultMessage = msg;
        }

        [DataMember]
        public string FaultMessage;
    }
}
