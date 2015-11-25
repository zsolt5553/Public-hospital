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
            AddColumns();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AddColumns()
        {
            var passwordClient = new PatientServiceClient();
            DataSet patientsTable = passwordClient.GetAllpatients();
            dataGridView1.Columns.Add("aaa", patientsTable.Tables[0].ToString());
            string a = patientsTable.Tables[0].ToString();

        }
    }
}
