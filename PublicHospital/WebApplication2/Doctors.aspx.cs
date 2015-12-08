using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;


namespace WebApplication2
{
    public partial class Doctor : System.Web.UI.Page
    {
        DoctorServiceRef.IDoctorService doctorService = new DoctorServiceRef.DoctorServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            string[][] doctors = doctorService.GetAllDoctorsSafe();
            Table table1 = new Table();
            table1.BorderWidth = 1;
            table1.BorderColor = Color.Black;
            table1.GridLines = GridLines.Both;
            table1.BorderStyle = BorderStyle.Solid;
            TableRow row = new TableRow();
            TableCell c1 = new TableCell();
            c1.Controls.Add(new LiteralControl("Name"));
            row.Controls.Add(c1);
            TableCell c2 = new TableCell();
            c2.Controls.Add(new LiteralControl("Specialty"));
            row.Controls.Add(c2);
            TableCell c3 = new TableCell();
            c3.Controls.Add(new LiteralControl("City"));
            row.Controls.Add(c3);
            TableCell c4 = new TableCell();
            c4.Controls.Add(new LiteralControl("PhoneNumber"));
            row.Controls.Add(c4);
            table1.Controls.Add(row);
            foreach (string[] doc in doctors)
            {
                row = new TableRow();
                foreach (string info in doc)
                {
                    TableCell c = new TableCell();
                    c.Controls.Add(new LiteralControl(info));
                    row.Controls.Add(c);
                }
                table1.Controls.Add(row);
            }
            PlaceHolder1.Controls.Add(table1);
        }
    }
}