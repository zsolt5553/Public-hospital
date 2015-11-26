using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class NewAdmin : Form
    {
        AdminServiceRef.Admin admin;
        public NewAdmin()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void NewAdmin_Load(object sender, EventArgs e)
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
            admin.phoneNr = phoneTxt.Text;
            admin.login = usernameTxt.Text;
            admin.pass = passwordTxt.Text;

            var client = new AdminServiceRef.AdminServiceClient();
            
            if (client.SaveAdmin(ref admin, ref message))
            {
                Dispose();
            }
            else
            {
                new Thread(() => new ErrorWindow(message).ShowDialog()).Start();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
