using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LogicLayer;
using DataLayer;

namespace ServiceLayer
{
    public class AdminService : IAdminService
    {
        AdminLogic adminLogic = new AdminLogic();

        public Admin GetAdmin (int id)
        {
            AdminBDO adminBDO = null;
            try
            {
                adminBDO = adminLogic.GetAdmin(id);
            }
            catch (Exception e)
            {
                var msg = e.Message;
                var reason = "GetAdmin exception";
                throw new FaultException<AdminFault>
                    (new AdminFault(msg), reason);
            }
            if (adminBDO == null)
            {
                var msg =
                    string.Format("No admin found for id {0}",
                    id);
                var reason = "GetAdmin empty";
                throw new FaultException<AdminFault>
                    (new AdminFault(msg), reason);
            }
            var admin = new Admin();
            TranslateAdminBDOToAdminDTO(adminBDO,
                admin);
            return admin;
        }

        private bool AdminCheck(ref Admin admin,
            ref string message)
        {
            var result = true;
            if (string.IsNullOrEmpty(admin.firstName))
            {
                message = "Admin's first name cannot be empty";
                result = false;
            }
            else if (string.IsNullOrEmpty(admin.lastName))
            {
                message = "Admin's last name cannot be empty";
                result = false;
            }
            else if (string.IsNullOrEmpty(admin.city))
            {
                message = "Admin's city cannot be empty";
                result = false;
            }
            else if (admin.zip <= 0)
            {
                message = "Admin's zip cannot be empty or smaller or equal to 0";
                result = false;
            }
            else if (string.IsNullOrEmpty(admin.street))
            {
                message = "Admin's street cannot be empty";
                result = false;
            }
            else if (admin.streetNr <= 0)
            {
                message = "Admin's street number cannot be empty or smaller or equal to 0";
                result = false;
            }
            else if (string.IsNullOrEmpty(admin.phoneNr))
            {
                message = "Admin's phone number cannot be empty";
                result = false;
            }
            else if (string.IsNullOrEmpty(admin.login))
            {
                message = "Admin's username cannot be empty";
                result = false;
            }
            else if (string.IsNullOrEmpty(admin.pass))
            {
                message = "Admin's password cannot be empty";
                result = false;
            }
            return result;
        }

        public bool SaveAdmin(ref Admin admin,
            ref string message)
        {
            var result = true;
            if (!AdminCheck(ref admin, ref message))
            {
                result = false;
            }
            else
            {
                try
                {
                    var adminBDO = new AdminBDO();
                    TranslateAdminDTOToAdminBDO(admin,
                        adminBDO);
                    result = adminLogic.InsertAdmin(
                        ref adminBDO, ref message);
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    throw new FaultException<AdminFault>
                        (new AdminFault(msg), msg);
                }
            }
            return result;
        }

        public bool UpdateAdmin (ref Admin admin,
            ref string message)
        {
            var result = true;
            if (!AdminCheck(ref admin, ref message))
            {
                result = false;
            }
            else
            {
                try
                {
                    var adminBDO = new AdminBDO();
                    TranslateAdminDTOToAdminBDO(admin,
                        adminBDO);
                    result = adminLogic.UpdateAdmin(
                        ref adminBDO, ref message);
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    throw new FaultException<AdminFault>
                        (new AdminFault(msg), msg);
                }
            }
            return result;
        }

        public void TranslateAdminBDOToAdminDTO (
            AdminBDO adminBDO,
            Admin admin)
        {
            admin.id = adminBDO.id;
            admin.firstName = adminBDO.firstName;
            admin.lastName = adminBDO.lastName;
            admin.city = adminBDO.city;
            admin.zip = adminBDO.zip;
            admin.street = adminBDO.street;
            admin.streetNr = adminBDO.streetNr;
            admin.phoneNr = adminBDO.phoneNr;
            admin.login = adminBDO.login;
            admin.pass = adminBDO.pass;
        }

        private void TranslateAdminDTOToAdminBDO (
            Admin admin,
            AdminBDO adminBDO)
        {
            adminBDO.id = admin.id;
            adminBDO.firstName = admin.firstName;
            adminBDO.lastName = admin.lastName;
            adminBDO.city = admin.city;
            adminBDO.zip = admin.zip;
            adminBDO.street = admin.street;
            adminBDO.streetNr = admin.streetNr;
            adminBDO.phoneNr = admin.phoneNr;
            adminBDO.login = admin.login;
            adminBDO.pass = admin.pass;
        }
    }
}
