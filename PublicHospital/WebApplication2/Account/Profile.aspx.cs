using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.Account
{
    public partial class Profile : System.Web.UI.Page
    {

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
            PatientServiceRef.Patient pat = (PatientServiceRef.Patient)Session["patientObj"];
            FName.Text = pat.firstName;
            LName.Text = pat.lastName;
            City.Text = pat.city;
            Street.Text = pat.street;
            StreetNr.Text = pat.streetNr.ToString();
            Zip.Text = pat.zip.ToString();
            Username.Text = pat.login;
            DateOfBirth.Text = pat.dateOfBirth.ToShortDateString();
            Phone.Text = pat.phoneNr;

            //Session["patientId"] = pat.id;
            //AppointmentsGridView.DataSource = (int)Session["patientId"];
            //AppointmentsGridView.DataBind();

            IDField.Text = pat.id.ToString();
            IDField.Visible = false;
        }

        protected void AppointmentsGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
            string id = AppointmentsGridView.Rows[e.RowIndex].Cells[0].Text;
            int idNum;
            int.TryParse(id, out idNum);
            AppointmentServiceRef.Appointment app = new AppointmentServiceRef.Appointment();
            string message = "";
            var client = new AppointmentServiceRef.AppointmentServiceClient();
            app = client.GetAppointment(idNum);
            client.DeleteAppointment(ref app,ref message);
            Session["appointmentObj"] = app;
        }
    }
}