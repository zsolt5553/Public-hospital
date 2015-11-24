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
    public partial class NewDoctor : Form
    {
        DoctorServiceRef.Doctor doctor = new DoctorServiceRef.Doctor();

        public NewDoctor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewDoctor_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doctor = new DoctorServiceRef.Doctor();
            string message = "";
            int zip;
            Int32.TryParse(zipTxt.Text, out zip);
            int streetNr;
            Int32.TryParse(streetNrTxt.Text, out streetNr);
            doctor.firstName = firstNameTxt.Text;
            doctor.lastName = lastNameTxt.Text;
            doctor.city = cityTxt.Text;
            doctor.zip = zip;
            doctor.street = streetTxt.Text;
            doctor.streetNr = streetNr;
            doctor.phoneNr = phoneTxt.Text;
            doctor.specialty = specialtyTxt.Text;
            doctor.description = descriptionTxt.Text;
            doctor.login = usernameTxt.Text;
            doctor.pass = passwordTxt.Text;

            var client = new DoctorServiceRef.DoctorServiceClient();
            if (client.SaveDoctor(ref doctor, ref message))
            {
                Dispose();
            }
            else
            {
                new Thread(() => new ErrorWindow(message).ShowDialog()).Start();
            }
        }
    }
}
