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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
            hourColum();
            doctorColumns();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
                 label1.Text = (1 + (dateTimePicker1.Value.Day / 7)).ToString("0");
        }


        private void hourColum()
        {
            int startH = 7;
            int startM = 0;
            int endH = 15;
            int endM = 0;
            int timeVisitM = 30;
            Boolean finish = false;
            while (!finish)
            {
                if (startM == 0)
                    dataGridView1.Rows.Add(new string[] { startH + ":00" });
                else
                    dataGridView1.Rows.Add(new string[] { startH + ":" + startM });
                startM += timeVisitM;
                if (startM == 60)
                {
                    startH += 1;
                    startM = 0;
                }
                if (startH == endH && startM == endM + timeVisitM)
                {
                    finish = true;
                }
            }
        }

        private void doctorColumns()
        {
            string[] weeks = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            for (int i = 0; i < weeks.Length; i++)
            {
                dataGridView1.Columns.Add("d" + i, weeks[i]);
                dataGridView1.Columns[i + 1].HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                for (int i2 = 0; i2 < dataGridView1.RowCount; i2++)
                {
                    if (true)
                    {
                        dataGridView1.Rows[i2].Cells[i + 1].Style.BackColor = Color.Green;
                    }
                    else
                    {
               //       dataGridView1.Rows[i2].Cells[i].Style.BackColor = Color.Red;
                    }
                }
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.LightBlue;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.White;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         //   new Appointment().Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            //label1.Text = (1 + (dateTimePicker1.Value. / 7)).ToString("0");
        }

     

       
    }
}