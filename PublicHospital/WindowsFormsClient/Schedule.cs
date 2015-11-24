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
    public partial class Schedule : Form
    {
        DoctorServiceRef.IDoctorService doctorService = new DoctorServiceRef.DoctorServiceClient();
        DoctorServiceRef.Doctor doc;
        private int doctorId=1;
        public Schedule()
        {
            InitializeComponent();
            CreateRows();
            CreateColumns();
            CalculateWeekNumber();


        }


        private void CalculateWeekNumber()
        {
            label1.Text = "Week" + (1 + (dateTimePicker1.Value.DayOfYear / 7)).ToString("0");
        }


        private void CreateRows()
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

        private void CreateColumns()
        {

            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-CheckIfNotMonday());
            for (int i = 0; i < 7; i++)
            {

                dataGridView1.Columns.Add("d" + i, dateTimePicker1.Value.Date.ToShortDateString() + "\n" + dateTimePicker1.Value.DayOfWeek.ToString());
                dataGridView1.Columns[i + 1].HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);

            }
            CreateCells(doctorId);
        }
        private void CreateCells(int id)
        {
           doc = GetDoctor(id);
            
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < dataGridView1.RowCount; i2++)
                {

                    if ( doc.firstName.Equals("Adam"))
                    {

                        dataGridView1.Rows[i2].Cells[i + 1].Style.BackColor = Color.Green;
                    }
                    else
                    {
                               dataGridView1.Rows[i2].Cells[i+1].Style.BackColor = Color.Red;
                    }
                }
            }
        }

        private void UpdateColumns()
        {
            for (int i = 1; i < 8; i++)
            {
                dataGridView1.Columns[i].HeaderText = dateTimePicker1.Value.Date.ToShortDateString() + "\n" + dateTimePicker1.Value.DayOfWeek.ToString();
                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String a = (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor.ToString());
            if ((dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor.ToString().Equals("Color [Green]")))
            {
                new Thread(() => new ErrorWindow("You dont have any appointment on this date").ShowDialog()).Start();
              
            }
            else
            {
                string row = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string colum = dataGridView1.Columns[e.ColumnIndex].HeaderCell.Value.ToString();
                DateTime myDate = DateTime.Parse(colum + row);
                Console.WriteLine(a);
                new Thread(() => new Appointment(myDate, doctorId).ShowDialog()).Start();
            }
        }
        private void WeekForward(object sender, EventArgs e)
        {

            UpdateColumns();
            CalculateWeekNumber();
        }

        private void WeekPrevious(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-14);
            UpdateColumns();
            CalculateWeekNumber();
        }

        private void SearchDoctor(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            int value2 = -1;
            Int32.TryParse(value, out value2);
            if (value2 != -1)
            {
                doctorId = value2;
                CreateCells(value2);
            
            }
            else
            {
                // do something
            }
        }


        private int CheckIfNotMonday()
        {
            int daynumber = 0;
            Boolean found = false;
            string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int i = 0;
            while (!found && i < days.Length)
            {
                if (days[i].Equals(dateTimePicker1.Value.DayOfWeek.ToString()))
                {
                    daynumber = i;
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            return daynumber;
        }

        private DoctorServiceRef.Doctor GetDoctor(int id)
        {
           
            DoctorServiceRef.Doctor doc = doctorService.GetDoctor(id);
            label2.Text = doc.firstName;
            return doc;
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    dataGridView1.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.LightBlue;
            //}
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.White;
            }
        }

    }
}