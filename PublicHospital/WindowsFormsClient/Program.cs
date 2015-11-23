using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string message = "";
            //AdminServiceRef.Admin admin = new AdminServiceRef.Admin();
            //admin.firstName = "Zsolt";
            //admin.lastName = "Bari";
            //admin.city = "Aalborg";
            //admin.zip = 9000;
            //admin.street = "Toldstrupsgade";
            //admin.streetNr = 14;
            //admin.phoneNr = "74154763";
            //admin.login = "zsoltbari";
            //admin.pass = "1111111";
            //var client = new AdminServiceRef.AdminServiceClient();
            //client.SaveAdmin(ref admin,ref message);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NewAdmin());

        }
    }
}
