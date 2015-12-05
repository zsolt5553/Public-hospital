using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class SrviceList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int numrows = 3;
            int numcells = 2;
            for (int j = 0; j < numrows; j++)
            {
                TableRow r = new TableRow();
                for (int i = 0; i < numcells; i++)
                {
                    TableCell c = new TableCell();
                    c.Controls.Add(new LiteralControl("row "
                        + j.ToString() + ", cell " + i.ToString()));
                    r.Cells.Add(c);
                }
                Tablee.Rows.Add(r);
            }
        }
    }
}