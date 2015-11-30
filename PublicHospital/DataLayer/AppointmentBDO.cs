using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataLayer
{
    public class AppointmentBDO
    {
        public int id { get; set; }
        public DateTime time { get; set; }
        public string serviceType { get; set; }
        public PatientBDO patient { get; set; }
        public DoctorBDO doctor { get; set; }
        public VisitBDO visit { get; set; }
        public byte[] rowVersion { get; set; }

        public AppointmentBDO() { }
        public AppointmentBDO(int id, DateTime time, string serviceType,
        PatientBDO patient, DoctorBDO doctor, VisitBDO visit)
        {
            this.id = id;
            this.time = time;
            this.serviceType = serviceType;
            this.patient = patient;
            this.doctor = doctor;
            this.visit = visit;
        }
    }
}