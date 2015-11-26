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
    public partial class Appointment : Form
    {
        public Appointment(DateTime date, int id)
        {
            InitializeComponent();
            this.CenterToScreen();
            SetDeatils(date, id);
        }

        private void SetDeatils(DateTime date, int id)
        {
            DoctorServiceRef.IDoctorService doctorService = new DoctorServiceRef.DoctorServiceClient();
            DoctorServiceRef.Doctor doc = doctorService.GetDoctor(id);
            doctor.Text = doc.firstName + " " + doc.lastName;
            appointmentDate.Text = date.ToString();
        }
    }
}
