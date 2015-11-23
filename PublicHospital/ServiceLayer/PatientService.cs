using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using DataLayer;
using LogicLayer;

namespace ServiceLayer
{
    public class PatientService
    {
        PatientLogic patientLogic = new PatientLogic();

        public Patient GetPatient(int id)
        {
            PatientBDO patientBDO = null;
            try
            {
                patientBDO = patientLogic.GetPatient(id);
            }
            catch (Exception e)
            {
                var msg = e.Message;
                var reason = "GetPatient exception";
                throw new FaultException<PatientFault>
                    (new PatientFault(msg), reason);
            }
            if (patientBDO == null)
            {
                var msg =
                    string.Format("No patient found for id {0}",
                    id);
                var reason = "GetPatient empty";
                throw new FaultException<PatientFault>
                    (new PatientFault(msg), reason);
            }
            var patient = new Patient();
            TranslatePatientBDOToPatientDTO(patientBDO,
                patient);
            return patient;
        }

        private bool PatientCheck(ref Patient patient,
            ref string message)
        {
            var result = true;
            if (string.IsNullOrEmpty(patient.firstName))
            {
                message = "Patient's first name cannot be empty";
                result = false;
            }
            else if (string.IsNullOrEmpty(patient.lastName))
            {
                message = "Patient's last name cannot be empty";
                result = false;
            }
            else if (string.IsNullOrEmpty(patient.city))
            {
                message = "Patient's city cannot be empty";
                result = false;
            }
            else if (patient.zip <= 0)
            {
                message = "Patient's zip cannot be empty or smaller or equal to 0";
                result = false;
            }
            else if (string.IsNullOrEmpty(patient.street))
            {
                message = "Patient's street cannot be empty";
                result = false;
            }
            else if (patient.streetNr <= 0)
            {
                message = "Patient's street number cannot be empty or smaller or equal to 0";
                result = false;
            }
            else if (string.IsNullOrEmpty(patient.phoneNr))
            {
                message = "Patient's phone number cannot be empty";
                result = false;
            }
            else if (patient.dateOfBirth == null)
            {
                //checking to do

                message = "Patient's date of birth cannot be empty";
                result = false;
            }

            else if (string.IsNullOrEmpty(patient.login))
            {
                message = "Patient's username cannot be empty";
                result = false;
            }
            else if (string.IsNullOrEmpty(patient.pass))
            {
                message = "Patient's password cannot be empty";
                result = false;
            }
            return result;
        }

        public bool UpdatePatient(ref Patient patient,
            ref string message)
        {
            var result = true;
            if (!PatientCheck(ref patient, ref message))
            {
                result = false;
            }
            else
            {
                try
                {
                    var patientBDO = new PatientBDO();
                    TranslatePatientDTOToPatientBDO(patient,
                        patientBDO);
                    result = patientLogic.UpdatePatient(
                        ref patientBDO, ref message);
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    throw new FaultException<PatientFault>
                        (new PatientFault(msg), msg);
                }
            }
            return result;
        }

        public void TranslatePatientBDOToPatientDTO(
            PatientBDO patientBDO,
            Patient patient)
        {
            patient.id = patientBDO.id;
            patient.firstName = patientBDO.firstName;
            patient.lastName = patientBDO.lastName;
            patient.city = patientBDO.city;
            patient.zip = patientBDO.zip;
            patient.street = patientBDO.street;
            patient.streetNr = patientBDO.streetNr;
            patient.phoneNr = patientBDO.phoneNr;
            patient.dateOfBirth = patientBDO.dateOfBirth;
            patient.login = patientBDO.login;
            patient.pass = patientBDO.pass;
        }

        private void TranslatePatientDTOToPatientBDO(
            Patient patient,
            PatientBDO patientBDO)
        {
            patientBDO.id = patient.id;
            patientBDO.firstName = patient.firstName;
            patientBDO.lastName = patient.lastName;
            patientBDO.city = patient.city;
            patientBDO.zip = patient.zip;
            patientBDO.street = patient.street;
            patientBDO.streetNr = patient.streetNr;
            patientBDO.phoneNr = patient.phoneNr;
            patientBDO.dateOfBirth = patient.dateOfBirth;
            patientBDO.login = patient.login;
            patientBDO.pass = patient.pass;
        }
    }
}
