using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using WebApplication2.Models;

namespace WebApplication2.Account
{
    public partial class Register : Page
    {
        protected void RegisterPatient(object sender, EventArgs e)
        {
            String message = "";
            int zip;
            int.TryParse(Zip.Text, out zip);
            int streetNr;
            int.TryParse(StreetNr.Text,out streetNr);
            DateTime dateOfBirth;
            DateTime.TryParse(DateOfBirth.Text,out dateOfBirth);
            PatientServiceRef.Patient patient = new PatientServiceRef.Patient()
            {
                firstName = FName.Text,
                lastName = LName.Text,
                city = City.Text,
                zip = zip,
                street = Street.Text,
                streetNr = streetNr,
                phoneNr = Phone.Text,
                dateOfBirth = dateOfBirth,
                login = Username.Text,
                pass = Password.Text
            };
            var client = new PatientServiceRef.PatientServiceClient();
            client.SavePatient(ref patient,ref message);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}