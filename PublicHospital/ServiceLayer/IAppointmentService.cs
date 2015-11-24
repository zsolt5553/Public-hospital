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
            public PatientBDO patient { get; set; }
            [DataMember]
            public DoctorBDO doctor { get; set; }

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
    }
