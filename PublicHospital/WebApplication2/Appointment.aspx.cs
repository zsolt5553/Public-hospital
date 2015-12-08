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
        List<DoctorServiceRef.Doctor> doctorList = new List<DoctorServiceRef.Doctor>();
        List<String> dropdownListItems = new List<String>();
        List<Button> buttons = new List<Button>();



        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["patientObj"] != null)
            {
                addTimeButtons();
                DoctorId = 2;
            }
            else
            {
                Response.Redirect("~/Account/Login.aspx");
            }
            
        }

        public void addTimeButtons()
        {

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
            dropdownListItems = new List<String>();

            for (int i = 0; i < doctorList.Count; i++)
            {
                dropdownListItems.Add("(" + doctorList.ElementAt(i).id + ") " + doctorList.ElementAt(i).firstName + " " + doctorList.ElementAt(i).lastName);
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
            SelectedDate = Calendar1.SelectedDate;
            SetButtonColor();
            Label1.Visible = true;
        }
        private void SetButtonColor()
        {
            List<String> appointmentDates = new List<String>();
            appointmentDates.AddRange(appointmentService.getAppointmentsByDocAndDate(SelectedDate, DoctorId));

            if (appointmentDates.Count<1)
            {
                for (int i = 0; i < buttons.Count; i++)
                {
                    buttons[i].BackColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                for (int i = 0; i < buttons.Count; i++)
                {
                    int e = 0;
                    Boolean found = false;
                    while (e < appointmentDates.Count && found == false)
                    {
                        if (appointmentDates[e].Equals(buttons[i].Text))
                        {
                            buttons[i].BackColor = System.Drawing.Color.Red;
                            found = true;
                        }

                        else
                        {
                            buttons[i].BackColor = System.Drawing.Color.Green;
                            e++;
                        }
                    }
                }
            }
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
                AppointmentServiceRef.Appointment appointment = new AppointmentServiceRef.Appointment();
                appointment.doctor = new AppointmentServiceRef.Doctor();
                appointment.doctor.id = DoctorId;
                PatientServiceRef.Patient pat = (PatientServiceRef.Patient)Session["patientObj"];
                appointment.patient = new AppointmentServiceRef.Patient();
                appointment.patient.id = pat.id;
                appointment.serviceType = doctorService.GetDoctor(DoctorId).specialty;
                string value;
                string value2;
                if (myButton.Text.Length > 5)
                {
                    value = myButton.Text.Substring(0, 2);
                    value2 = myButton.Text.Substring(3, 2);
                }
                else
                {
                    value = myButton.Text.Substring(0, 1);
                    value2 = myButton.Text.Substring(2, 2);
                }
                DateTime finalDate;
                finalDate = SelectedDate.AddHours(convertInt(value));
                finalDate = finalDate.AddMinutes(convertInt(value2));
                appointment.time = finalDate;
                string message = "";
                var client = new AppointmentServiceRef.AppointmentServiceClient();
                client.SaveAppointment(ref appointment, ref message);
                Calendar1.Visible = false;
                Panel1.Visible = false;
                DropDownList1.Visible = false;
                Label2.Visible = false;
                Label1.Visible = true;
                Label1.Text = "You have made an appointent on: " + finalDate.ToShortDateString();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
            string value = stringUntilThatChar(DropDownList1.Text);
            DoctorId = convertInt(value);

        }

        private int convertInt(String convertableString)
        {

            int value2 = -1;
            Int32.TryParse(convertableString, out value2);
            if (value2 != -1)
            {
                return value2;
            }
            return value2;
        }

        protected void DropDownList1_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getAllDoctorName();

                foreach (string name in dropdownListItems)
                {
                    DropDownList1.Items.Add(new ListItem(name));
                }
                DropDownList1.DataBind();
            }
            DropDownList1.SelectedIndex = 0;
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {

            if (e.Day.Date < DateTime.Today)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.Silver;
            }
        }

        public int DoctorId
        {
            get
            {
                return (int)this.ViewState["DoctorId"];
            }
            set { this.ViewState["DoctorId"] = value; }
        }
        public DateTime SelectedDate
        {
            get
            {
                return (DateTime)this.ViewState["SelectedDate"];
            }
            set { this.ViewState["SelectedDate"] = value; }
        }


    }
}