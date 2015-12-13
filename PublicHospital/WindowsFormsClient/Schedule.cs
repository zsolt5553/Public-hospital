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
        AppointmentServiceRef.IAppointmentService appointmentService = new AppointmentServiceRef.AppointmentServiceClient();
        DoctorServiceRef.Doctor doc;
        List<AppointmentServiceRef.Appointment> appointmentList = new List<AppointmentServiceRef.Appointment>();

        List<DoctorServiceRef.Doctor> doctorList = new List<DoctorServiceRef.Doctor>();
        List<String> doctorsName = new List<String>();
        private int doctorId=1;
        private string serviceType;
        private int patientId;
        public Schedule()
        {
            getAllDoctorName();
            InitializeComponent();
            this.comboBox1.Items.AddRange(doctorsName.ToArray());
            CreateRows();
            CreateColumns();
            CalculateWeekNumber();
            appointmentList.AddRange(appointmentService.GetAllAppointments());
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
                dataGridView1.Columns[i].HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                dataGridView1.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(208, 221, 238);
                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);

            }
            CreateCells(doctorId);
        }
        private void CreateCells(int id)
        {
           doc = doctorService.GetDoctor(id);


            for (int i = 1; i < 8; i++)
            {
             
                    for (int i2 = 0; i2 < dataGridView1.RowCount; i2++)
                    {
                        dataGridView1.Rows[i2].Cells[0].Style.BackColor = Color.FromArgb(208, 221, 238);
                        int i3 = 0;
                        Boolean found = false;
                        while (i3 < appointmentList.Count && found==false)
                            {
                            if (appointmentList.ElementAt(i3).doctor.id == doc.id)
                            {
                                string row = dataGridView1.Rows[i2].Cells[0].Value.ToString();
                                string colum = dataGridView1.Columns[i].HeaderCell.Value.ToString();
                                DateTime myDate = DateTime.Parse(colum + row);
                                if (myDate.Equals(appointmentList.ElementAt(i3).time))
                                {
                                    dataGridView1.Rows[i2].Cells[i].Style.BackColor = Color.Red;
                                    found = true;
                                }
                                else
                                {
                                    dataGridView1.Rows[i2].Cells[i].Style.BackColor = Color.Green;
                                    i3++;
                                }

                            }
                            else
                            {
                                dataGridView1.Rows[i2].Cells[i].Style.BackColor = Color.Green;
                                i3++;
                            }
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
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
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

                    for (int i3 = 0; i3 < appointmentList.Count; i3++)
                    {

                        if (appointmentList.ElementAt(i3).doctor.id == doc.id && appointmentList.ElementAt(i3).time.Equals(myDate))
                        {
                            patientId = appointmentList.ElementAt(i3).patient.id;
                            serviceType = appointmentList.ElementAt(i3).serviceType;
                        }
                    }
                    new Thread(() => new Appointment(myDate, doctorId, patientId, serviceType).ShowDialog()).Start();
                }
            }
            
             
             new Thread(() => new ErrorWindow("Choose a date"));
            
        }
        private void WeekForward(object sender, EventArgs e)
        {

            UpdateColumns();
            CalculateWeekNumber();
            CreateCells(doctorId);
        }

        private void WeekPrevious(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-14);
            UpdateColumns();
            CalculateWeekNumber();
            CreateCells(doctorId);
           
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
          
            return doc;
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               dataGridView1.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.LightBlue;
               dataGridView1.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.LightBlue;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.FromArgb(208, 221, 238);
                dataGridView1.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(208, 221, 238);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string value = stringUntilThatChar(comboBox1.Text);
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
        public static string stringUntilThatChar(string s)
        {
            int l = s.IndexOf(")");
            if (l > 0)
            {
                return s.Substring(1, l-1);
            }
            return "";

        }
        public void getAllDoctorName()
        {
            doctorList.AddRange(doctorService.GetAllDoctors());
           
            doctorsName = new List<String>();

            for (int i =0; i < doctorList.Count; i++)
            {
                doctorsName.Add("(" + doctorList.ElementAt(i).id +") " + doctorList.ElementAt(i).firstName + " " + doctorList.ElementAt(i).lastName);
            }
        }

      


    }
}