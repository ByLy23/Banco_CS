using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fase2
{
    public partial class Indes : System.Web.UI.Page
    {
        public static bool verificaCliente = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            verificaCliente = true;
            Response.Redirect("RegistroCliente.aspx");
            verificaCliente = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}