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
                {
                    patientDAO = new PatientDAO();
                    doctorDAO = new DoctorDAO();
                    appointmentBDO = new AppointmentBDO()
                    {
                        id = appointmentObj.id,
                        time = Convert.ToDateTime(appointmentObj.time),
                        serviceType = appointmentObj.serviceType,
                        patient = patientDAO.GetPatient(appointmentObj.idPatient.Value),
                        doctor = doctorDAO.GetDoctor(appointmentObj.idDoctor.Value),
                        rowVersion = appointmentObj.rowVersion
                    };
                } 
            }
            return appointmentBDO;
        }
        public List<AppointmentBDO> GetAllAppointments()
        {
            List<AppointmentBDO> appointments = null;
            AppointmentBDO appointmentBDO = null;
            PatientBDO patientBDO = null;
            DoctorBDO doctorBDO = null;
            using (var PHEntities = new PublicHospitalEntities())
            {
                var listInDb = (from Appointment in PHEntities.Appointment
                                from Doctor in PHEntities.Doctor
                                from Patient in PHEntities.Patient
                                where Appointment.idDoctor == Doctor.id &&
                                Appointment.idPatient == Patient.id
                                select new
                                {
                                    Appointment.id,
                                    Appointment.time,
                                    Appointment.serviceType,
                                    Doctor.firstName,
                                    Doctor.lastName,
                                    DoctorId = Doctor.id,
                                    Column1 = Patient.firstName,
                                    Column2 = Patient.lastName,
                                    Column3 = Patient.id
                                });
                if (listInDb != null)
                {
                    appointments = new List<AppointmentBDO>();
                    foreach (var mergedList in listInDb)
                    {
                        if (mergedList != null)
                        {
                            doctorBDO = new DoctorBDO();
                            patientBDO = new PatientBDO();
                            doctorBDO.firstName = mergedList.firstName;
                            doctorBDO.lastName = mergedList.lastName;
                            doctorBDO.id = mergedList.DoctorId;
                            patientBDO.firstName = mergedList.Column1;
                            patientBDO.lastName = mergedList.Column2;
                            patientBDO.id = mergedList.Column3;
                            appointmentBDO = new AppointmentBDO()
                            {
                                id = mergedList.id,
                                time = mergedList.time,
                                serviceType = mergedList.serviceType,
                                doctor = doctorBDO,
                                patient = patientBDO
                            };
                            appointments.Add(appointmentBDO);
                        }
                    }
                }
            }
            return appointments;
        }

        public List<string> getAppointmentsByDocAndDate (DateTime date, ref DoctorBDO doc)
        {
            List<string> appTimes;
            using (var PHEntities = new PublicHospitalEntities())
            {
                var listInDb = (from appointment in PHEntities.Appointment
                                from doctor in PHEntities.Doctor
                                where appointment.idDoctor == doctor.id &&
                                appointment.time.ToShortDateString() == date.ToShortDateString()
                                select new
                                {
                                    appointment.time
                                }).ToList();
                appTimes = new List<string>();
                if (listInDb != null)
                {
                    foreach (var d in listInDb)
                    {
                        appTimes.Add(d.time.ToShortTimeString());
                    }
                }
            }
            return appTimes;
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
                    time = appointmentBDO.time.Date,
                    serviceType = appointmentBDO.serviceType,
                    idPatient = appointmentBDO.patient.id,
                    idDoctor = appointmentBDO.patient.id,
                    rowVersion = appointmentBDO.rowVersion
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
                appointmentInDb.time = appointmentBDO.time.Date;
                appointmentInDb.serviceType = appointmentBDO.serviceType;
                appointmentInDb.idPatient = appointmentBDO.patient.id;
                appointmentInDb.idDoctor = appointmentBDO.patient.id;
                appointmentInDb.rowVersion = appointmentBDO.rowVersion;
                //without username and pass
                PHEntites.Appointment.Attach(appointmentInDb);
                PHEntites.Entry(appointmentInDb).State = System.Data.Entity.EntityState.Modified;
                var num = PHEntites.SaveChanges();

                appointmentBDO.rowVersion = appointmentInDb.rowVersion;
                if (num != 1)
                {
                    ret = false;
                    massage = "appointment was not updated";
                }
            }
            return ret;
        }

        public bool GetAppointmentsHistoryPatient(ref PatientBDO patient, ref string message)
        {
            bool succesful = false;
            using (var PHEntities = new PublicHospitalEntities())
            {
                int patientID = patient.id;
                var appointments = PHEntities.Appointment.Where(a => a.idPatient == patientID);
                if (appointments.FirstOrDefault() != null)
                {
                    VisitDAO visitDAO = new VisitDAO();
                    List<AppointmentBDO> appointmentList = new List<AppointmentBDO>();
                    foreach (var appointment in appointments)
                    {
                        appointmentList.Add(new AppointmentBDO()
                        {
                            id = appointment.id,
                            time = Convert.ToDateTime(appointment.time),
                            serviceType = appointment.serviceType,
                            doctor = new DoctorDAO().GetDoctor(appointment.idDoctor.Value),
                            visit = visitDAO.GetVisit(appointment.id)
                        });
                    }
                    if (appointmentList != null)
                    {
                        patient.appointmentsHistory = appointmentList;
                        succesful = true;
                    }
                    else
                        message = "Appointment list is empty";
                }
                else
                    message = "Can not get id from the database appointment";
            }
            return succesful;
        }

        public bool GetAppointmentsHistoryDoctor(ref DoctorBDO doctor, ref string message)
        {
            bool succesful = false;
            using (var PHEntities = new PublicHospitalEntities())
            {
                int doctorID = doctor.id;
                var appointments = PHEntities.Appointment.Where(a => a.idDoctor == doctorID);
                if (appointments.FirstOrDefault() != null)
                {
                    VisitDAO visitDAO = new VisitDAO();
                    List<AppointmentBDO> appointmentList = new List<AppointmentBDO>();
                    foreach (var appointment in appointments)
                    {
                        appointmentList.Add(new AppointmentBDO()
                        {
                            id = appointment.id,
                            time = Convert.ToDateTime(appointment.time),
                            serviceType = appointment.serviceType,
                            patient = new PatientDAO().GetPatient(appointment.idPatient.Value),
                            visit = visitDAO.GetVisit(appointment.id)
                        });
                    }
                    if (appointmentList != null)
                    {
                        doctor.appointmentsHistory = appointmentList;
                        succesful = true;
                    }
                    else
                        message = "Appointment list is empty";
                }
                else
                    message = "Can not get id from the database appointment";
            }
            return succesful;
        }
    }
}