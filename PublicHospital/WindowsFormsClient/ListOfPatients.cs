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
using WindowsFormsClient.PatientService;

namespace WindowsFormsClient
{
    public partial class ListOfPatients : Form
    {
        public ListOfPatients()
        {
            InitializeComponent();
            this.CenterToScreen();
            FillTabe();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string message = null;
            int id = 0;
            Int32.TryParse(dataGridView1.SelectedRows[e.RowIndex].Cells[0].Value.ToString(), out id);
            Patient patient = new PatientServiceClient().GetAppointmentsHistoryPatient(id, ref message);
            if (patient != null)
            {
                new Thread(() => new PatientHistory(patient).ShowDialog()).Start();
            }
            else
                new Thread(() => new ErrorWindow(message).ShowDialog()).Start();
        }

        private void FillTabe()
        {
            List<Patient> patientList = new PatientServiceClient().GetAllpatients().ToList();
            string[] days = new string[] { "ID", "First name", "Last name", "City", "Street", "Phone", "ZIP", "Date of birth" };
            for (int i = 0; i < days.Length; i++)
            {
                dataGridView1.Columns.Add(i.ToString(), days[i]);
            }

            for (int i = 0; i < patientList.Count; i++)
            {
                dataGridView1.Rows.Add(patientList[i].id, patientList[i].firstName, patientList[i].lastName,
                    patientList[i].city, patientList[i].street+" "+patientList[i].streetNr, patientList[i].phoneNr,
                    patientList[i].zip, patientList[i].dateOfBirth.ToShortDateString());
            }
        }
    }
}
