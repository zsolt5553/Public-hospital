using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer;
using DataLayer;
using System.ServiceModel;

namespace ServiceLayer
{
    public class AppointmentService : IAppointmentService
    {
        private DoctorService doctorService;

        AppointmentLogic AppointmentLogic = new AppointmentLogic();

        public Appointment GetAppointment(int id)
        {
            AppointmentBDO AppointmentBDO = null;
            try
            {
                AppointmentBDO = AppointmentLogic.GetAppointment(id);
            }
            catch (Exception e)
            {
                var msg = e.Message;
                var reason = "GetAppointment exception";
                throw new FaultException<AppointmentFault>
                    (new AppointmentFault(msg), reason);
            }
            if (AppointmentBDO == null)
            {
                var msg =
                    string.Format("No Appointment found for id {0}",
                    id);
                var reason = "GetAppointment empty";
                throw new FaultException<AppointmentFault>
                    (new AppointmentFault(msg), reason);
            }
            var Appointment = new Appointment();
            TranslateAppointmentBDOToAppointmentDTO(AppointmentBDO,
                Appointment);
            return Appointment;
        }

        public List<Appointment> GetAllAppointments()
        {
            List<AppointmentBDO> appointmentList;
            try
            {
                appointmentList = AppointmentLogic.GetAllAppointments();
            }
            catch (Exception e)
            {
                var msg = e.Message;
                var reason = "GetAllDoctors exception";
                throw new FaultException<DoctorFault>
                    (new DoctorFault(msg), reason);
            }
            if (appointmentList == null)
            {
                var msg = "ListOfDoctors is empty";
                var reason = "ListOfDoctors empty";
                throw new FaultException<DoctorFault>
                    (new DoctorFault(msg), reason);
            }
            List<Appointment> appointments = new List<Appointment>();
            foreach (AppointmentBDO doc in appointmentList)
            {
                var appointment = new Appointment();
                TranslateAppointmentBDOToAppointmentDTO(doc,
                    appointment);
                appointments.Add(appointment);
            }
            return appointments;
        }

        public bool UpdateAppointment(ref Appointment Appointment,
            ref string message)
        {
            var result = true;
            if (Appointment.doctor.Equals(null))
            {
                message = "Appointment needs a doctor.";
                result = false;
            }
            if (Appointment.patient.Equals(null))
            {
                message = "Appointment needs a patient.";
                result = false;
            }
            if (Appointment.time.Equals(null))
            {
                message = "Appointment needs a setTime.";
                result = false;
            }
            if (String.IsNullOrEmpty(Appointment.serviceType))
            {
                message = "Appointment needs a serviceType.";
                result = false;
            }
            else
            {
                try
                {
                    var AppointmentBDO = new AppointmentBDO();
                    TranslateAppointmentDTOToAppointmentBDO(Appointment,
                        AppointmentBDO);
                    result = AppointmentLogic.UpdateAppointment(
                        ref AppointmentBDO, ref message);
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    throw new FaultException<AppointmentFault>
                        (new AppointmentFault(msg), msg);
                }
            }
            return result;
        }

        private void TranslateAppointmentBDOToAppointmentDTO(
            AppointmentBDO AppointmentBDO,
            Appointment Appointment)
        {
            Appointment.id = AppointmentBDO.id;
            Appointment.patient = AppointmentBDO.patient;
            Appointment.serviceType = AppointmentBDO.serviceType;
            Appointment.time = AppointmentBDO.time;
            Appointment.doctor = AppointmentBDO.doctor;
        }

        private void TranslateAppointmentDTOToAppointmentBDO(
            Appointment Appointment,
            AppointmentBDO AppointmentBDO)
        {
            AppointmentBDO.id = Appointment.id;
            AppointmentBDO.patient = Appointment.patient;
            AppointmentBDO.serviceType = Appointment.serviceType;
            AppointmentBDO.time = Appointment.time;
            AppointmentBDO.doctor = Appointment.doctor;
        }
    }

}
