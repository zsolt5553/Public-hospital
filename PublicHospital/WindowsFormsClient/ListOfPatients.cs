using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FillTabe()
        {
            List<Patient> patientList = new PatientServiceClient().GetAllpatients().ToList();
            string[] days = new string[] { "ID", "First name", "Last name", "City", "Street", "Phone", "Date of birth" };
            for (int i = 0; i < days.Length; i++)
            {
                dataGridView1.Columns.Add(i.ToString(), days[i]);
            }

            for (int i = 0; i < patientList.Count; i++)
            {
                dataGridView1.Rows.Add(patientList[i].id, patientList[i].firstName, patientList[i].lastName,
                    patientList[i].city, patientList[i].street+" "+patientList[i].streetNr, patientList[i].phoneNr,
                    patientList[i].dateOfBirth.ToShortDateString());
            }
        }
    }
}
