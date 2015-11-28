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
    public partial class VisitDetails : Form
    {
        public VisitDetails(Visit visit)
        {
            InitializeComponent();
            this.CenterToScreen();
            FillTabe(visit);
        }

        private void FillTabe(Visit visit)
        {
            textBox1.Text = 
                "PROBLEMS:" + Environment.NewLine +
                visit.patientProblem + Environment.NewLine + Environment.NewLine +
                "SYMPTOM:" + Environment.NewLine +
                visit.symptom + Environment.NewLine + Environment.NewLine +
                "ADVICE:" + Environment.NewLine +
                visit.advice;
        }
    }
}
