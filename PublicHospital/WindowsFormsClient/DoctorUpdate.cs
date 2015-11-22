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
    public partial class DoctorUpdate : Form
    {
        public DoctorUpdate(int id)
        {
            InitializeComponent();
            setDoctor(id);
        }

        private void setDoctor(int id)
        {
             DoctorService doctorService = new DoctorService();

             textBox4.Text = doctorService.GetDoctor(id).city;

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
    }
}
