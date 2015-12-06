using System;
using System.Collections.Generic;
using System.Data;
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

        protected void Page_Load(object sender, EventArgs e)
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


        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
                Panel1.Visible = true;
                Calendar1.Visible = false;            
        }

        void MyButtonClick(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            myButton.Text = "cefe";
        }



        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
            Label1.Text = "fasz";
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