using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsClient
{
    public partial class DoctorUpdate : Form
    {
        DoctorServiceRef.Doctor doc;
        public DoctorUpdate(int id)
        {
            InitializeComponent();
            setDoctor(id);
        }

        private void setDoctor(int id)
        {
            var doctorService = new DoctorServiceRef.DoctorServiceClient();
            doc = doctorService.GetDoctor(id);

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

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "";
            int zipNr;
            Int32.TryParse(zip.Text, out zipNr);
            int streetNr;
            Int32.TryParse(streetnr.Text, out streetNr);
            doc.firstName = firstname.Text;
            doc.lastName = lastname.Text;
            doc.city = city.Text;
            doc.zip = zipNr;
            doc.street = street.Text;
            doc.streetNr = streetNr;
            doc.phoneNr = phonenr.Text;
            doc.specialty = speciality.Text;
            doc.description = description.Text;

            var doctorService = new DoctorServiceRef.DoctorServiceClient();
            try
            {
                doctorService.UpdateDoctor(ref doc, ref message);

                new Thread(() => new ErrorWindow("The update was successful !").ShowDialog()).Start();

            }
            catch (FaultException)
            {
                new Thread(() => new ErrorWindow("The update was unsuccessful due to inconsistent data !").ShowDialog()).Start();
            }

        }
    }
}
