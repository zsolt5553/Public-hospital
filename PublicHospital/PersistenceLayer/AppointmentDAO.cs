using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace PersistenceLayer
{
    public class AppointmentDAO
    {
        private PatientDAO patientDAO;
        private DoctorDAO doctorDAO;

        public AppointmentBDO GetAppointment(int id)
        {
            AppointmentBDO appointmentBDO = null;
            using (var PHEntities = new PublicHospitalEntities())
            {
                var appointmentObj = (from a in PHEntities.Appointment
                                      where a.id == id
                                      select a).FirstOrDefault();
                if (appointmentObj != null)
                    appointmentBDO = new AppointmentBDO()
                    {
                        id = appointmentObj.id,
                        time = Convert.ToDateTime(appointmentObj.time),
                        serviceType = appointmentObj.serviceType,
                        patient = patientDAO.GetPatient(appointmentObj.idPatient.Value),
                        doctor = doctorDAO.GetDoctor(appointmentObj.idDoctor.Value)
                    };
            }
            return appointmentBDO;
        }

        public bool InsertAppointment(ref AppointmentBDO appointmentBDO,
            ref string massage)
        {
            massage = "Appointment inserted successfully";
            var ret = true;
            using (var PHEntities = new PublicHospitalEntities())
            {
                PHEntities.Appointment.Add(new Appointment
                {
                    id = appointmentBDO.id,
                    time = appointmentBDO.time.Date.ToString("yyyy-MM-dd HH:mm:ss"),
                    serviceType = appointmentBDO.serviceType,
                    idPatient = appointmentBDO.patient.id,
                    idDoctor = appointmentBDO.patient.id
                });
                var num = PHEntities.SaveChanges();
                if (num != 1)
                {
                    ret = false;
                    massage = "Appointment was not inserted";
                }
            }
            return ret;
        }

        public bool Updateappointment(ref AppointmentBDO appointmentBDO,
            ref string massage)
        {
            massage = "appointment updated successfully";
            var ret = true;
            using (var PHEntites = new PublicHospitalEntities())
            {
                var appointmentId = appointmentBDO.id;
                var appointmentInDb = (from a
                                 in PHEntites.Appointment
                                 where a.id == appointmentId
                                 select a).FirstOrDefault();
                if (appointmentInDb == null)
                {
                    throw new Exception("No appointment with id " +
                                        appointmentBDO.id);
                }
                appointmentInDb.id = appointmentBDO.id;
                appointmentInDb.time = appointmentBDO.time.Date.ToString("yyyy-MM-dd HH:mm:ss");
                appointmentInDb.serviceType = appointmentBDO.serviceType;
                appointmentInDb.idPatient = appointmentBDO.patient.id;
                appointmentInDb.idDoctor = appointmentBDO.patient.id;
                //without username and pass
                PHEntites.Appointment.Attach(appointmentInDb);
                PHEntites.Entry(appointmentInDb).State = System.Data.Entity.EntityState.Modified;
                var num = PHEntites.SaveChanges();
                if (num != 1)
                {
                    ret = false;
                    massage = "appointment was not updated";
                }
            }
            return ret;
        }
    }
}
}
