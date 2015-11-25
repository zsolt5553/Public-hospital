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

        public bool InsertAppointment(ref AppointmentBDO appointmentBDO,
            ref string massage)
        {
            return appointmentDAO.InsertAppointment(ref appointmentBDO, ref massage);
        }

        public bool UpdateAppointment(
            ref AppointmentBDO appointmentBDO,
            ref string message)
        {
            var appointmentInDb = Getappointment(appointmentBDO.id);
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
    }
}
