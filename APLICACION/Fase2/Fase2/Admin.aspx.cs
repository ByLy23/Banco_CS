using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fase2
{
    public partial class Admin : Page 
    {
        Administrador admi = new Administrador();
        ClientesTableAdapters.inventarioTableAdapter invenr = new ClientesTableAdapters.inventarioTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroEmpleado.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("RegistroCliente.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (cant.Text.Equals(""))
            {
                Response.Write("Ingrese chequeras");
            }
            else
            {
                invenr.insertarChequeras(Convert.ToInt32(cant.Text));
                Response.Write("Cantidad Ingresada exitosamente");
                cant.Text = "";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reportes.aspx");
        }
    }
}