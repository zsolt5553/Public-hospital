using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class UpdateDoctor : Form
    {
        AdminServiceRef.Admin admin;
        private int id;
        public UpdateDoctor()
        {
            InitializeComponent();
        }

        public UpdateDoctor(int id)
        {
            // TODO: Complete member initialization
            this.id = id;
        }

        private void UpdateDoctor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin = new AdminServiceRef.Admin();
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
            admin.id = 2; // not implemented !!

            var client = new AdminServiceRef.AdminServiceClient();
            client.SaveAdmin(ref admin,ref message);
        }
    }
}
