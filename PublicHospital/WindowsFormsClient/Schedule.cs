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
        public Schedule()//(DateTime date)
        {
            InitializeComponent();
            hourColum();
            doctorColumns();
        }

        private void hourColum()
        {
            //dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //dataGridView1.Rows[0] = dataGridView1.Height / 6;
            //dataGridView1.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //this.dataGridView1.BorderStyle = BorderStyle.None;
            //dataGridView1.RowHeadersVisible = false;
            //DateTime date = new DateTime(2008, 5, 1, 8, 30, 0);//rok,dzień,miesiąc,h,m,s
            //list[0] = new string[] { "aaa", "1." + Environment.NewLine + "aaa", "aaa" };
            //int countRows = (((endH - startH) * 60) + (endM - startM)) / timeVisitM;
            //string[][] list = new string[countRows][];
            //dataGridView1.Rows[i2].Cells[i].Value = "aaa";
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

            for (int i = 0; i < weeks.Length; i++)//dataGridView1.ColumnCount dodawanie do komórek
            {
                //dataGridView1.Columns.Add("d" + i, list[i][0] + Environment.NewLine + "" + list[i][1]);//dodawanie kolumn
                dataGridView1.Columns.Add("d" + i, weeks[i]);//dodawanie kolumn
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
                    //    dataGridView1.Rows[i2].Cells[i].Style.BackColor = Color.White;
                    }
                }
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)// && e.ColumnIndex != 0)
            {//dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
                dataGridView1.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.LightBlue;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)// && e.ColumnIndex != 0)
            {//dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                dataGridView1.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.White;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         //   new Appointment().Show();
        }
    }
}