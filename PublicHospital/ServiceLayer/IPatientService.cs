using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLayer
{
    [ServiceContract]
    public interface IPatientService
    {
        [OperationContract]
        [FaultContract(typeof(PatientFault))]
        Patient GetPatient(int id);

        [OperationContract]
        [FaultContract(typeof(PatientFault))]
        bool UpdatePatient(ref Patient Patient,
            ref string message);

        [OperationContract]
        [FaultContract(typeof(PatientFault))]
        List<Patient> GetAllpatients();

        [OperationContract]
        [FaultContract(typeof(AppointmentFault))]
        Patient GetAppointmentsHistoryPatient(int id, ref string message);
    }

    [DataContract]
    public class Patient
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
        public DateTime dateOfBirth { get; set; }
        [DataMember]
        public string login { get; set; }
        [DataMember]
        public string pass { get; set; }
        [DataMember]
        public byte[] RowVersion { get; set; }
        [DataMember]
        public List<Appointment> appointmentsHistory { get; set; }
        [DataMember]
        public string sessionID { get; set; }
    }
    [DataContract]
    public class PatientFault
    {
        public PatientFault(string msg)
        {
            FaultMessage = msg;
        }

        [DataMember]
        public string FaultMessage;
    }
}