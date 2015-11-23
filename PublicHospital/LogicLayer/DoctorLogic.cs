using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using PersistenceLayer;

namespace LogicLayer
{
    public class DoctorLogic
    {
        DoctorDAO doctorDAO = new DoctorDAO();
        public DoctorBDO GetDoctor(int id)
        {
            return doctorDAO.GetDoctor(id);
        }

        public bool InsertDoctor(ref DoctorBDO doctorBDO,
            ref string massage)
        {
            return doctorDAO.InsertDoctor(ref doctorBDO, ref massage);
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
