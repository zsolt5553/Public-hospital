using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using PersistenceLayer;
namespace LogicLayer
{
    public class AppointmentLogic
    {
        AppointmentDAO appointmentDAO = new AppointmentDAO();
        public AppointmentBDO GetAppointment(int id)
        {
            return appointmentDAO.GetAppointment(id);
        }

        public List<string> getAppointmentsByDocAndDate(DateTime date, int docId)
        {
            return appointmentDAO.getAppointmentsByDocAndDate(date, docId);
        }

        public bool DeleteAppointment(ref AppointmentBDO app,
            ref string message)
        {
            return appointmentDAO.DeleteAppointment(ref app,ref message);
        }

        public List<AppointmentBDO> GetAppointmentsAfterCurrentDateByPatient(int id)
        {
            List<AppointmentBDO> origList = appointmentDAO.GetAllAppointmentsByPatient(id);
            if (origList != null)
            {
                List<AppointmentBDO> targetList = new List<AppointmentBDO>();
                foreach (AppointmentBDO app in origList)
                {
                    if (app.time > DateTime.Now)
                    {
                        targetList.Add(app);
                    }
                }
                if (targetList != null)
                {
                    return targetList;
                }
                else
                {
                    return null;
                }   
            }
            else
            {
                return null;
            }
        }

        public List<AppointmentBDO> GetAllAppointments()
        {
            return appointmentDAO.GetAllAppointments();
        }
        public bool InsertAppointment(ref AppointmentBDO appointmentBDO,
        ref string massage)
        {
            return appointmentDAO.InsertAppointment(ref appointmentBDO, ref massage);
        }
        public bool UpdateAppointment(
        ref AppointmentBDO appointmentBDO,
        ref string message)
        {
            var appointmentInDb = GetAppointment(appointmentBDO.id);
            if (appointmentInDb == null)
            {
                message = "cannot fetch appointment with this ID";
                return false;
            }
            else
            {
                return appointmentDAO.Updateappointment(ref appointmentBDO,
                ref message);
            }
        }

        public bool GetAppointmentsHistoryPatient(ref PatientBDO patient, ref string message)
        {
            return appointmentDAO.GetAppointmentsHistoryPatient(ref patient, ref message);
        }

        public bool GetAppointmentsHistoryDoctor(ref DoctorBDO doctor, ref string message)
        {
            return appointmentDAO.GetAppointmentsHistoryDoctor(ref doctor, ref message);
        }
    }
}