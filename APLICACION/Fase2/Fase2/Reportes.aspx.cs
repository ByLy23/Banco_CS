using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fase2
{
    public partial class Reportes : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.Visible = false;
            reportesac.Visible = false;
            reportChe.Visible = false;
            plus.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            reportesac.Visible = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            reportChe.Visible = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            plus.Visible = true;
        }
    }
}