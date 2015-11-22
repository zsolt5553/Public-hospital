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
    public partial class ListOfDoctors : Form
    {
        public ListOfDoctors()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dmaj0914_3Sem_4_1DataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.dmaj0914_3Sem_4_1DataSet.Doctor);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         

        }

      

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(() => new NewDoctor().ShowDialog()).Start();
        }
    }
}
