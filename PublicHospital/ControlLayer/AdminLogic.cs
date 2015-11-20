using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DatabaseLayer;

namespace ControlLayer
{
    public class AdminLogic
    {
        AdminDAO adminDAO = new AdminDAO();
        public AdminBDO GetAdmin (int id)
        {
            return adminDAO.GetAdmin(id);
        }

        public bool InsertAdmin (ref AdminBDO adminBDO,
            ref string massage)
        {
            return adminDAO.InsertAdmin(ref adminBDO, ref massage);
        }

        public bool UpdateAdmin (
            ref AdminBDO adminBDO,
            ref string message)
        {
            var adminInDb = GetAdmin(adminBDO.id);
            if (adminInDb == null)
            {
                message = "cannot fetch admin with this ID";
                return false;
            }
            else
            {
                return adminDAO.UpdateAdmin(ref adminBDO,
                    ref message);
            }
        }
    }
}
