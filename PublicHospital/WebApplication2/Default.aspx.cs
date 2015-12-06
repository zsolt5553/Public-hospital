using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.PatientServiceRef;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Patient patient = (Patient)Session["patientObj"];
            if(patient != null)
            {
                nameUser.Text = "Hello "+patient.firstName;
            }
        }
    }
}