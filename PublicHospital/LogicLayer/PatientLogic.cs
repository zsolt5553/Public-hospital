using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using PersistenceLayer;
using System.Data;

namespace LogicLayer
{
    public class PatientLogic
    {
        PatientDAO patientDAO = new PatientDAO();
        public PatientBDO GetPatient(int id)
        {
            return patientDAO.GetPatient(id);
        }

        public bool InsertPatient(ref PatientBDO patientBDO,
                                    ref string massage)
        {
            return patientDAO.InsertPatient(ref patientBDO, ref massage);
        }

        public bool UpdatePatient(
            ref PatientBDO patientBDO,
            ref string message)
        {
            var patientInDb = GetPatient(patientBDO.id);
            if (patientInDb == null)
            {
                message = "cannot fetch patient with this ID";
                return false;
            }
            else
            {
                return patientDAO.UpdatePatient(ref patientBDO,
                    ref message);
            }
        }

        public List<PatientBDO> GetAllpatients()
        {
            return patientDAO.GetAllpatients();
        }
    }
}
