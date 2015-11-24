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
         
            string message = null;
            if (textBox1.TextLength > 3 || textBox2.TextLength > 3)
            {
                
                var passwordClient = new PasswordServiceClient();
                int[] idAndType = passwordClient.authenticatePerson(textBox1.Text, textBox2.Text, ref message);
                label1.Text = message;
                if (idAndType != null)
                    new Thread(() => new AdminMenu().ShowDialog()).Start();
            }
            else
            {
                new Thread(() => new ErrorWindow("Incorrect length").ShowDialog()).Start();
                label1.Text = "Incorrect length";
            }
        }
    }
}