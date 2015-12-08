using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ServiceLayer
{
    [ServiceContract]
    public interface IAppointmentService
    {
        [OperationContract]
        [FaultContract(typeof(AppointmentFault))]
        Appointment GetAppointment(int id);

        [OperationContract]
        [FaultContract(typeof(AppointmentFault))]
        bool SaveAppointment(ref Appointment appointment,
            ref string message);

        [OperationContract]
        [FaultContract(typeof(AppointmentFault))]
        List<Appointment> GetAllAppointments();

        [OperationContract]
        [FaultContract(typeof(AppointmentFault))]
        List<Appointment> GetAppointmentsAfterCurrentDateByPatient(int id);

        [OperationContract]
        [FaultContract(typeof(AppointmentFault))]
        List<string> getAppointmentsByDocAndDate(DateTime date,
           int docId);


        [OperationContract]
        [FaultContract(typeof(AppointmentFault))]
        bool UpdateAppointment(ref Appointment Appointment,
            ref string message);
    }

    [DataContract]
    public class Appointment
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public DateTime time { get; set; }
        [DataMember]
        public string serviceType { get; set; }
        [DataMember]
        public Patient patient { get; set; }
        [DataMember]
        public Doctor doctor { get; set; }
        [DataMember]
        public Visit visit { get; set; }
        [DataMember]
        public byte[] RowVersion { get; set; }


    }

    [DataContract]
    public class AppointmentFault
    {
        public AppointmentFault(string msg)
        {
            FaultMessage = msg;
        }

        [DataMember]
        public string FaultMessage;
    }

    [DataContract]
    public class Visit
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string patientProblem { get; set; }
        [DataMember]
        public string symptom { get; set; }
        [DataMember]
        public string advice { get; set; }
        [DataMember]
        public byte[] RowVersion { get; set; }

    }
}
