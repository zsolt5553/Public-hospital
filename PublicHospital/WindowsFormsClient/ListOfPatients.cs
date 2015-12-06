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
using WindowsFormsClient.DoctorServiceRef;
using WindowsFormsClient.PatientService;

namespace WindowsFormsClient
{
    public partial class ListOfPatients : Form
    {
        public ListOfPatients(DoctorServiceRef.Doctor doctor, int choose)
        {
            InitializeComponent();
            this.CenterToScreen();
            FillTabe(doctor, choose);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string message = null;
            int id = 0;
            Int32.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out id);
            PatientService.Patient patient = new PatientServiceClient().GetAppointmentsHistoryPatient(id, ref message);
            if (patient != null)
            {
                new Thread(() => new PatientHistory(patient).ShowDialog()).Start();
            }
            else
                new Thread(() => new ErrorWindow(message).ShowDialog()).Start();
        }

        private void FillTabe(DoctorServiceRef.Doctor doc, int choose)
        {
            string[] columns = new string[] { "ID", "First name", "Last name", "City", "Street", "Phone", "ZIP", "Date of birth" };
            for (int i = 0; i < columns.Length; i++)
                dataGridView1.Columns.Add(i.ToString(), columns[i]);
            if (choose == 1)
            {
                string message = null;
                DoctorServiceRef.Doctor doctor = new DoctorServiceClient().GetAppointmentsHistoryDoctor(doc.id, ref message);
                if (doctor != null)
                {
                    List<DoctorServiceRef.Patient> patientList = new List<DoctorServiceRef.Patient>();
                    foreach (var appointment in doctor.appointmentsHistory)
                        patientList.Add(appointment.patient);
                    for (int i = 0; i < patientList.Count; i++)
                    {
                        dataGridView1.Rows.Add(patientList[i].id, patientList[i].firstName, patientList[i].lastName,
                            patientList[i].city, patientList[i].street + " " + patientList[i].streetNr, patientList[i].phoneNr,
                            patientList[i].zip, patientList[i].dateOfBirth.ToShortDateString());
                    }
                }
                else
                    new Thread(() => new ErrorWindow(message).ShowDialog()).Start();
            }
            else
            {
                List<PatientService.Patient> patientList = new PatientServiceClient().GetAllpatients().ToList();
                for (int i = 0; i < patientList.Count; i++)
                {
                    dataGridView1.Rows.Add(patientList[i].id, patientList[i].firstName, patientList[i].lastName,
                        patientList[i].city, patientList[i].street + " " + patientList[i].streetNr, patientList[i].phoneNr,
                        patientList[i].zip, patientList[i].dateOfBirth.ToShortDateString());
                }
            }
        }
    }
}
