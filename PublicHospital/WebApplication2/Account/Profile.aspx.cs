using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.Account
{
    public partial class Profile : System.Web.UI.Page
    {
        PatientServiceRef.Patient pat;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["patientObj"] !=null)
            {
                SetTextBoxes();
            }
            else
            {
                Response.Redirect("~/Account/Login.aspx");
            }
        }

        private void SetTextBoxes()
        {
            pat = (PatientServiceRef.Patient)Session["patientObj"];
            FName.Text = pat.firstName;
            LName.Text = pat.lastName;
            City.Text = pat.city;
            Street.Text = pat.street;
            StreetNr.Text = pat.streetNr.ToString();
            Zip.Text = pat.zip.ToString();
            Username.Text = pat.login;
            DateOfBirth.Text = pat.dateOfBirth.ToString("MM:dd:yyyy");
            Phone.Text = pat.phoneNr;

        }

        protected void Appointment_Deleting(object sender, ObjectDataSourceMethodEventArgs e)
        {
            IDictionary paramsFromPage = e.InputParameters;

            paramsFromPage.Remove("Appointment");

            AppointmentServiceRef.Appointment app = new AppointmentServiceRef.Appointment();
            app.id = (int)paramsFromPage["id"];
            app.doctor = new AppointmentServiceRef.Doctor();
            app.patient = new AppointmentServiceRef.Patient();

            paramsFromPage.Add("Appointment",app);
            paramsFromPage.Remove("id");
        }

        protected void Appointment_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["id"] = pat.id;
        }
    }
}