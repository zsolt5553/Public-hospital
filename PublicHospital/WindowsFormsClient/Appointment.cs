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
        public Appointment(DateTime date, int doctorId, int patientId, string serviceType)
        {
            InitializeComponent();
            this.CenterToScreen();
            SetDeatils(date, doctorId,patientId,serviceType);
        }

        private void SetDeatils(DateTime date, int doctorId,int patientId, string serviceType)
        {
            DoctorServiceRef.IDoctorService doctorService = new DoctorServiceRef.DoctorServiceClient();
            DoctorServiceRef.Doctor doc = doctorService.GetDoctor(doctorId);

            PatientService.IPatientService patientservice = new PatientService.PatientServiceClient();
            PatientService.Patient patient = patientservice.GetPatient(patientId);

            doctor.Text = doc.firstName + " " + doc.lastName;
            patientName.Text = patient.firstName + " " + patient.lastName;
            appointmentDate.Text = date.ToString();
            serviceTypeTXT.Text = serviceType;

        }
    }
}
