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
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    RegisterHyperLink.NavigateUrl = "Register";
        //    // Enable this once you have account confirmation enabled for password reset functionality
        //    // ForgotPasswordHyperLink.NavigateUrl = "Forgot";
        //    OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
        //    var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
        //    if (!String.IsNullOrEmpty(returnUrl))
        //    {
        //        RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
        //    }
        //}
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
                int id = -1;
                Int32.TryParse(idAndType[0], out id);
                Patient patientClient = new PatientServiceClient().GetPatient(id);
                patientClient.sessionID = idAndType[2];
                Session["patientObj"] = patientClient;
                Response.Redirect("~/Default.aspx");//MyObject obj1 = (MyObject)Session["Passing Object"];
            }
            else
            {
                Labell.Visible = true;
                Labell.Text = message;
            }
        }
        //protected void LogIn(object sender, EventArgs e)
        //{
        //    if (IsValid)
        //    {
        //        // Validate the user password
        //        var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
        //        ApplicationUser user = manager.Find(Email.Text, Password.Text);
        //        if (user != null)
        //        {
        //            IdentityHelper.SignIn(manager, user, RememberMe.Checked);
        //            IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
        //        }
        //        else
        //        {
        //            FailureText.Text = "Invalid username or password.";
        //            ErrorMessage.Visible = true;
        //        }
        //    }
        //}
    }
}