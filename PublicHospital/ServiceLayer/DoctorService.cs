using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using DataLayer;
using LogicLayer;
using System.Data;

namespace ServiceLayer
{
    public class DoctorService : IDoctorService
    {
        DoctorLogic doctorLogic = new DoctorLogic();

        public Doctor GetDoctor(int id)
        {
            DoctorBDO doctorBDO = null;
            try
            {
                doctorBDO = doctorLogic.GetDoctor(id);
            }
            catch (Exception e)
            {
                var msg = e.Message;
                var reason = "GetDoctor exception";
                throw new FaultException<DoctorFault>
                    (new DoctorFault(msg), reason);
            }
            if (doctorBDO == null)
            {
                var msg =
                    string.Format("No doctor found for id {0}",
                    id);
                var reason = "GetDoctor empty";
                throw new FaultException<DoctorFault>
                    (new DoctorFault(msg), reason);
            }
            var doctor = new Doctor();
            TranslateDoctorBDOToDoctorDTO(doctorBDO,
                doctor);
            return doctor;
        }

        public bool DeleteDoctor(ref Doctor doctor,
            ref string message)
        {
            var result = false;
            try
            {
                var doctorBDO = new DoctorBDO();
                TranslateDoctorDTOToDoctorBDO(doctor,
                    doctorBDO);
                result = doctorLogic.DeleteDoctor(
                    ref doctorBDO, ref message);
            }
            catch (Exception e)
            {
                var msg = e.Message;
                throw new FaultException<DoctorFault>
                    (new DoctorFault(msg), msg);
            }
            return result;
        }  

        public Doctor GetDoctorByName(string name)
        {
            DoctorBDO doctorBDO = null;
            try
            {
                doctorBDO = doctorLogic.GetDoctorByName(name);
            }
            catch (Exception e)
            {
                var msg = e.Message;
                var reason = "GetDoctor exception";
                throw new FaultException<DoctorFault>
                    (new DoctorFault(msg), reason);
            }
            if (doctorBDO == null)
            {
                var msg =
                    string.Format("No doctor found for id {0}",
                    name);
                var reason = "GetDoctor empty";
                throw new FaultException<DoctorFault>
                    (new DoctorFault(msg), reason);
            }
            var doctor = new Doctor();
            TranslateDoctorBDOToDoctorDTO(doctorBDO,
                doctor);
            return doctor;
        }

        public DataSet GetDoctorTable()
        {
            DataTable doctorTable;
            try
            {
                doctorTable = doctorLogic.GetDoctorTable();
            }
            catch (Exception e)
            {
                var msg = e.Message;
                var reason = "GetDoctorTable exception";
                throw new FaultException<DoctorFault>
                    (new DoctorFault(msg), reason);
            }
            if (doctorTable == null)
            {
                var msg = "GetDoctorTable is empty";
                var reason = "GetDoctorTable empty";
                throw new FaultException<DoctorFault>
                    (new DoctorFault(msg), reason);
            }
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(doctorTable);
            return dataSet;
        }

        public List<Doctor> GetAllDoctors()
        {
            List<DoctorBDO> doctorsList;
            try
            {
                doctorsList = doctorLogic.GetAllDoctors();
            }
            catch (Exception e)
            {
                var msg = e.Message;
                var reason = "GetAllDoctors exception";
                throw new FaultException<DoctorFault>
                    (new DoctorFault(msg), reason);
            }
            if (doctorsList == null)
            {
                var msg ="ListOfDoctors is empty";
                var reason = "ListOfDoctors empty";
                throw new FaultException<DoctorFault>
                    (new DoctorFault(msg), reason);
            }
            List<Doctor> doctors = new List<Doctor>();
            foreach (DoctorBDO doc in doctorsList)
            {
                var doctor = new Doctor();
                TranslateDoctorBDOToDoctorDTO(doc,
                    doctor);
                doctors.Add(doctor);
            }
            return doctors;
        }

        private bool DoctorCheck(ref Doctor doctor,
            ref string message)
        {
            var result = true;
            if (string.IsNullOrEmpty(doctor.firstName))
            {
                message = "Doctor's first name cannot be empty";
                result = false;
            }
            else if (string.IsNullOrEmpty(doctor.lastName))
            {
                message = "Doctor's last name cannot be empty";
                result = false;
            }
            else if (string.IsNullOrEmpty(doctor.city))
            {
                message = "Doctor's city cannot be empty";
                result = false;
            }
            else if (doctor.zip <= 0)
            {
                message = "Doctor's zip cannot be empty or smaller or equal to 0";
                result = false;
            }
            else if (string.IsNullOrEmpty(doctor.street))
            {
                message = "Doctor's street cannot be empty";
                result = false;
            }
            else if (doctor.streetNr <= 0)
            {
                message = "Doctor's street number cannot be empty or smaller or equal to 0";
                result = false;
            }
            else if (string.IsNullOrEmpty(doctor.phoneNr))
            {
                message = "Doctor's phone number cannot be empty";
                result = false;
            }
            else if (string.IsNullOrEmpty(doctor.login))
            {
                message = "Doctor's username cannot be empty";
                result = false;
            }
            else if (string.IsNullOrEmpty(doctor.pass))
            {
                message = "Doctor's password cannot be empty";
                result = false;
            }
            else if (string.IsNullOrEmpty(doctor.specialty))
            {
                message = "Doctor's specialty cannot be empty";
                result = false;
            }
            return result;
        }

        public bool SaveDoctor(ref Doctor doctor,
            ref string message)
        {
            var result = true;
            if (!DoctorCheck(ref doctor, ref message))
            {
                result = false;
            }
            else
            {
                try
                {
                    var doctorBDO = new DoctorBDO();
                    TranslateDoctorDTOToDoctorBDO(doctor,
                        doctorBDO);
                    result = doctorLogic.InsertDoctor(
                        ref doctorBDO, ref message);
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    throw new FaultException<DoctorFault>
                        (new DoctorFault(msg), msg);
                }
            }
            return result;
        }

        public bool UpdateDoctor(ref Doctor doctor,
            ref string message)
        {
            var result = true;
            if (!DoctorCheck(ref doctor, ref message))
            {
                result = false;
            }
            else
            {
                try
                {
                    var doctorBDO = new DoctorBDO();
                    TranslateDoctorDTOToDoctorBDO(doctor,
                        doctorBDO);
                    result = doctorLogic.UpdateDoctor(
                        ref doctorBDO, ref message);
                    doctor.RowVersion = doctorBDO.RowVersion;
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    throw new FaultException<DoctorFault>
                        (new DoctorFault(msg), msg);
                }
            }
            return result;
        }

        public void TranslateDoctorBDOToDoctorDTO(
            DoctorBDO doctorBDO,
            Doctor doctor)
        {
            doctor.id = doctorBDO.id;
            doctor.firstName = doctorBDO.firstName;
            doctor.lastName = doctorBDO.lastName;
            doctor.city = doctorBDO.city;
            doctor.zip = doctorBDO.zip;
            doctor.street = doctorBDO.street;
            doctor.streetNr = doctorBDO.streetNr;
            doctor.phoneNr = doctorBDO.phoneNr;
            doctor.specialty = doctorBDO.specialty;
            doctor.description = doctorBDO.description;
            doctor.login = doctorBDO.login;
            doctor.pass = doctorBDO.pass;
            doctor.RowVersion = doctorBDO.RowVersion;
        }

        public void TranslateDoctorDTOToDoctorBDO(
            Doctor doctor,
            DoctorBDO doctorBDO)
        {
            doctorBDO.id = doctor.id;
            doctorBDO.firstName = doctor.firstName;
            doctorBDO.lastName = doctor.lastName;
            doctorBDO.city = doctor.city;
            doctorBDO.zip = doctor.zip;
            doctorBDO.street = doctor.street;
            doctorBDO.streetNr = doctor.streetNr;
            doctorBDO.phoneNr = doctor.phoneNr;
            doctorBDO.specialty = doctor.specialty;
            doctorBDO.description = doctor.description;
            doctorBDO.login = doctor.login;
            doctorBDO.pass = doctor.pass;
            doctorBDO.RowVersion = doctor.RowVersion;
        }
    }
}
