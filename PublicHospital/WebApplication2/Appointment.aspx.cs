using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication2
{
    public partial class Appointment : Page
    {

        protected void Page_Load2(object sender, EventArgs e)
        {
           
        }


        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Attributes.Add("style", "cursor:help;");
            if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowState == DataControlRowState.Alternate)
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    e.Row.Attributes.Add("onmouseover", "this.style.backgroundColor='orange'");
                    e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='#E56E94'");
                    e.Row.BackColor = Color.FromName("#E56E94");
                }
            }
            else
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    e.Row.Attributes.Add("onmouseover", "this.style.backgroundColor='orange'");
                    e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='gray'");
                    e.Row.BackColor = Color.FromName("gray");
                }

                //e.Row.Cells[0].BackColor = Color.FromName("gray");
                //e.Row.Cells[1].BackColor = Color.FromName("gray");
                //e.Row.Cells[2].BackColor = Color.FromName("gray");
                //e.Row.Cells[3].BackColor = Color.FromName("gray");
                //e.Row.Cells[4].BackColor = Color.FromName("gray");
                //e.Row.BorderWidth = 2;
                //e.Row.BorderColor = Color.FromName("#43C6DB");
            }
        }



      

     
    }
}