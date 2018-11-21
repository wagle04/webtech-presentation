using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace part_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/countries1.xml"));

                GridView1.DataSource = ds;
                GridView1.DataBind();
        }
        protected void Page_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            Server.ClearError();
            Response.Redirect("~/error.aspx");
        }
    }
}