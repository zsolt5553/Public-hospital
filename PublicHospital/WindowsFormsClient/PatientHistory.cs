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
    public partial class PatientHistory : Form
    {
        Patient patient = null;
        public PatientHistory(Patient patient)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.patient = patient;
            FillTabe();
        }

        private void FillTabe()
        {
            string[] days = new string[] { "ID", "Date", "Hour", "Service type", "Doctor", "Doctor ID" };
            for (int i = 0; i < days.Length; i++)
            {
                dataGridView1.Columns.Add(i.ToString(), days[i]);
            }

            foreach (var appointment in patient.appointmentsHistory)
            {
                dataGridView1.Rows.Add(appointment.id, appointment.time.ToShortDateString(),
                    appointment.time.ToShortTimeString(), appointment.serviceType,
                    appointment.doctor.firstName+" "+ appointment.doctor.lastName, appointment.doctor.id);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 0;
            Int32.TryParse(dataGridView1.CurrentRow.Index.ToString(), out index);
            Visit visit = patient.appointmentsHistory.ElementAt(index).visit;
            if (visit != null)
                new Thread(() => new VisitDetails(visit).ShowDialog()).Start();
            else
                new Thread(() => new ErrorWindow("No details").ShowDialog()).Start();
        }
    }
}
