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
    public partial class DoctorUpdate : Form
    {
        public DoctorUpdate(int id)
        {
            InitializeComponent();
            setDoctor(id);
        }

        private void setDoctor(int id)
        {
            DoctorServiceRef.IDoctorService doctorService = new DoctorServiceRef.DoctorServiceClient();
            DoctorServiceRef.Doctor doc = doctorService.GetDoctor(id);

            firstname.Text = doc.firstName;
            lastname.Text = doc.lastName;
            city.Text = doc.city;
            zip.Text = doc.zip.ToString();
            street.Text = doc.street;
            streetnr.Text = doc.streetNr.ToString();
            phonenr.Text = doc.phoneNr;
            username.Text = doc.login;
            description.Text = doc.description;
            speciality.Text = doc.specialty;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
