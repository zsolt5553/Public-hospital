using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using WebApplication2.Models;
using WebApplication2.PasswordService;
using WebApplication2.PatientServiceRef;

namespace WebApplication2.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Labell.Visible = false;
        }

        protected void LogIn(object sender, EventArgs e)
        {
            Labell.Visible = false;
            string message = null;
            var passwordClient = new PasswordServiceClient();
            string[] idAndType = passwordClient.authenticatePerson(Loginn.Text, Password.Text, ref message);
            if (idAndType != null && idAndType[1].Equals("2"))
            {
                int id = 0;
                Int32.TryParse(idAndType[0], out id);
                Patient patientClient = new PatientServiceClient().GetPatient(id);
                patientClient.sessionID = idAndType[2];
                Session["patientObj"] = patientClient;
                Response.Redirect("~/Default.aspx");//MyObject obj1 = (MyObject)Session["Passing Object"];
            }
            else
            {
                Labell.Visible = true;
                Labell.Text = "Try once again";
            }
        }
    }
}