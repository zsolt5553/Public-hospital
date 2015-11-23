﻿using System;
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
            if (textBox1.TextLength > 3 || textBox2.TextLength > 3)
            {
                string message = null;
                var passwordClient = new PasswordServiceClient();
                int[] idAndType = passwordClient.authenticatePerson(textBox1.Text, textBox2.Text, ref message);
                label1.Text = message;
                if (idAndType != null)
                    new Thread(() => new AdminMenu().ShowDialog()).Start();
              
            }
            else
            {
                label1.Text = "Incorrect length";
            }
        }
    }
}