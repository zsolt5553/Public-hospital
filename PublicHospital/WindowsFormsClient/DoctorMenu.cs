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
    public partial class DoctorMenu : Form
    {
        DoctorServiceRef.Doctor doctor = null;
        public DoctorMenu(DoctorServiceRef.Doctor doctor)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.doctor = doctor;
        }

        private void DoctorMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Thread(() => new ListOfPatients(doctor, 0).ShowDialog()).Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(() => new Schedule().ShowDialog()).Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            new Thread(() => new ListOfPatients(doctor, 1).ShowDialog()).Start();
        }
    }
}
