using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DatabaseLayer;

namespace ContolLayer
{
    public class DoctorLogic
    {
        DoctorDAO doctorDAO = new DoctorDAO();
        public DoctorBDO GetDoctor(int id)
        {
            return doctorDAO.GetDoctor(id);
        }

        public bool UpdateDoctor(
            ref DoctorBDO doctorBDO,
            ref string message)
        {
            var doctorInDb = GetDoctor(doctorBDO.id);
            if (doctorInDb == null)
            {
                message = "cannot fetch doctor with this ID";
                return false;
            }
            else
            {
                return doctorDAO.UpdateDoctor(ref doctorBDO,
                    ref message);
            }
        }
    }
}
