using DataLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLayer
{
    public class PasswordService : IPasswordService
    {
        PasswordLogic pas = new PasswordLogic();
        public People authenticatePerson(string login, string password, ref string message)
        {
            AdminBDO adminBDO = null;
            try
            {
                adminBDO = pas.authenticatePerson(login, password, ref message);
            }
            catch (Exception e)
            {
                var msg = e.Message;
                var reason = "authenticatePerson exception";
                throw new FaultException<PasswordFault>(new PasswordFault(msg), reason);
            }
            if(adminBDO.GetType() == typeof(AdminBDO))
            {
                var admin = new Admin();
                AdminService a = new AdminService();
                a.TranslateAdminBDOToAdminDTO(adminBDO, admin);
                return new People();
            }
            else if(adminBDO.GetType() == typeof(PatientBDO))
            {
                var patient = new Admin();
                AdminService a = new AdminService();
                a.TranslateAdminBDOToAdminDTO(adminBDO as PatientBDO, patient);
                return new People();
            }
            else if (adminBDO.GetType() == typeof(DoctorBDO))
            {
                var doctor = new Doctor();
                DoctorService a = new DoctorService();
                a.TranslateDoctorBDOToDoctorDTO(adminBDO as DoctorBDO, doctor);
                return new People();
            }
            else
                return null;
        }

        public DataLayer.AdminBDO authenticatePerson(string login, string password)
        {
            throw new NotImplementedException();
        }
    }
}
