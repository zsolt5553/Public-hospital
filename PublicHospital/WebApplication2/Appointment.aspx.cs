﻿using System;
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
            makeTable();
         

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
            DoctorServiceRef.Doctor doc;
              doc = doctorService.GetDoctor(1);
              Label1.Text = doc.firstName;
          
              foreach (string name in doctorsName)
              {
                  DropDownList1.Items.Add(new ListItem(name));
              }
              DropDownList1.DataBind();

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


        protected void makeTable()
        {
            if (!this.IsPostBack)
            {
             
                GridView1.DataBind();
            }
        }

        protected void DataList1_Load(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}