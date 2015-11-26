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
using WindowsFormsClient.PasswordService;
using WindowsFormsClient.AdminServiceRef;
using WindowsFormsClient.DoctorServiceRef;

namespace WindowsFormsClient
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signin();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signin();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signin();
            }
        }

        private void signin()
        {
         
            string message = "";
            if (textBox1.TextLength > 3 || textBox2.TextLength > 3)
            {
                var passwordClient = new PasswordServiceClient();
                int[] idAndType = passwordClient.authenticatePerson(textBox1.Text, textBox2.Text, ref message);
                if (idAndType != null)
                {
                    if(idAndType[1] == 0)
                    {
                        var adminClient = new AdminServiceClient().GetAdmin(idAndType[0]);
                        new Thread(() => new AdminMenu().ShowDialog()).Start();
                        Dispose();
                    }
                    else if(idAndType[1] == 1)
                    {
                        var doctorClient = new DoctorServiceClient().GetDoctor(idAndType[0]);
                        new Thread(() => new DoctorMenu().ShowDialog()).Start();
                        Dispose();
                    }
                    else
                        new Thread(() => new ErrorWindow("Wrong username or password").ShowDialog()).Start();
                }
                else
                {
                    new Thread(() => new ErrorWindow("Wrong username or password").ShowDialog()).Start();
                }    
            }
            else
            {
                new Thread(() => new ErrorWindow("Incorrect length").ShowDialog()).Start();
            }
        }
    }
}