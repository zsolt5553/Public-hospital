using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Appointment : System.Web.UI.Page
    {
        DoctorServiceRef.IDoctorService doctorService = new DoctorServiceRef.DoctorServiceClient();
        AppointmentServiceRef.IAppointmentService appointmentService = new AppointmentServiceRef.AppointmentServiceClient();
        List<AppointmentServiceRef.Appointment> appointmentList = new List<AppointmentServiceRef.Appointment>();
        List<DoctorServiceRef.Doctor> doctorList = new List<DoctorServiceRef.Doctor>();
        List<String> doctorsName = new List<String>();
        private int doctorId;
        private DateTime selectedDate;
        AppointmentServiceRef.Appointment appointment = new AppointmentServiceRef.Appointment();
      

        protected void Page_Load(object sender, EventArgs e)
        {
            addTimeButtons();
        }

        public void addTimeButtons()
        {
            List<Button> buttons = new List<Button>();
            buttons = new List<Button>();
            buttons.Add(Button730);
            buttons.Add(Button800);
            buttons.Add(Button830);
            buttons.Add(Button900);
            buttons.Add(Button930);
            buttons.Add(Button1000);
            buttons.Add(Button1030);
            buttons.Add(Button1100);
            buttons.Add(Button1130);
            buttons.Add(Button1200);
            buttons.Add(Button1230);
            buttons.Add(Button1300);
            buttons.Add(Button1330);
            buttons.Add(Button1400);
            buttons.Add(Button1430);
            buttons.Add(Button1500);
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Click += MyButtonClick;
            }


        }

        public void getAllDoctorName()
        {
            doctorList.AddRange(doctorService.GetAllDoctors());
            doctorsName = new List<String>();

            for (int i = 0; i < doctorList.Count; i++)
            {
                doctorsName.Add("(" + doctorList.ElementAt(i).id + ") " + doctorList.ElementAt(i).firstName + " " + doctorList.ElementAt(i).lastName);
            }
        }

        public static string stringUntilThatChar(string s)
        {
            int l = s.IndexOf(")");
            if (l > 0)
            {
                return s.Substring(1, l - 1);
            }
            return "";

        }


        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
                Panel1.Visible = true;
                Calendar1.Visible = false;
                
                selectedDate = Calendar1.SelectedDate;
                Label1.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        void MyButtonClick(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            if (myButton.BackColor == Color.Red)
            {
                Label1.Text = "This appointment is not available, please choose another one";
            }
            else
            {
            
            }
        }



        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
            string value = stringUntilThatChar(DropDownList1.Text);
            int value2 = -1;
            Int32.TryParse(value, out value2);
            if (value2 != -1)
            {
                appointment.doctor.id = value2;

            }
          Label1.Text = stringUntilThatChar(DropDownList1.Text);
        }

        protected void DropDownList1_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getAllDoctorName();

                foreach (string name in doctorsName)
                {
                    DropDownList1.Items.Add(new ListItem(name));
                }
                DropDownList1.DataBind();
            }
        }



    }
}