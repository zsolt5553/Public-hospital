using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceLayer;

namespace WindowsFormsClient
{
    public partial class NewAdmin : Form
    {
        Admin admin;
        public NewAdmin()
        {
            InitializeComponent();
        }

        private void NewAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "";
            int zip;
            Int32.TryParse(zipTxt.Text, out zip);
            int streetNr;
            Int32.TryParse(streetNrTxt.Text,out streetNr);
            admin.firstName = firstNameTxt.Text;
            admin.lastName = lastNameTxt.Text;
            admin.city = cityTxt.Text;
            admin.zip = zip;
            admin.street = streetTxt.Text;
            admin.streetNr = streetNr;
            admin.id = 1; // not implemented !!

            AdminServiceRef.IAdminService  adminService =
                new AdminServiceRef.AdminServiceClient();
            adminService.InsertAdmin(ref admin, ref message);
        }
    }
}
