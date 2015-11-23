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
            AdminServiceRef.IAdminService doctorService = new AdminServiceRef.AdminServiceClient();
            firstname.Text = doctorService.GetAdmin(id).city;
            lastname.Text = doctorService.GetAdmin(id).city;
            city.Text = doctorService.GetAdmin(id).city;
            zip.Text = doctorService.GetAdmin(id).city;
            street.Text = doctorService.GetAdmin(id).city;
            streetnr.Text = doctorService.GetAdmin(id).city;
            firstname.Text = doctorService.GetAdmin(id).city;
            phonenr.Text = doctorService.GetAdmin(id).city;
            password.Text = doctorService.GetAdmin(id).city;
            username.Text = doctorService.GetAdmin(id).city;
            description.Text = doctorService.GetAdmin(id).city;
            speciality.Text = doctorService.GetAdmin(id).city;
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
