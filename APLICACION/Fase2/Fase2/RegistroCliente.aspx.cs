using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Fase2
{
    public partial class RegistroCliente : System.Web.UI.Page
    {
        Empleado em = new Empleado();
        Administrador admi = new Administrador();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
        public static bool comprobarEliminado = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Indes.verificaCliente)
            {
                Button2.Visible = false;
                Button3.Visible = false;
                Button4.Visible = false;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }
        int numoe = 0;
        long dp = 0;
        int busc = 0;
        protected void Button5_Click(object sender, EventArgs e)
        {
            if (dpi.Text.Equals("") || Nombre.Text.Equals("") || Apellido.Text.Equals("") || usuario.Text.Equals("") || contrasenia.Text.Equals("") || Clave.Text.Equals("") || FechaNAc.Text.Equals("") || correo.Text.Equals("") || telefono.Text.Equals(""))
            {
                Response.Write("No sabe escribir o que pez");
            }
            else
            {


                Int64.TryParse(dpi.Text, out dp);
                Int32.TryParse(telefono.Text, out numoe);
                em.registrarClientes(dp, Nombre.Text, Apellido.Text, FechaNAc.Text, correo.Text, numoe, usuario.Text, contrasenia.Text, Clave.Text);
                Response.Write("Registrado Jefaso");               
            }
            limpiar();
        }
        public void limpiar()
        {
            dpi.Text = "";
            Nombre.Text = "";
            Apellido.Text = "";
            FechaNAc.Text = "";
            correo.Text = "";
            telefono.Text = "";
            usuario.Text = "";
            contrasenia.Text = "";
            Clave.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            admi.eliminarCliente(dpi.Text);
            if (comprobarEliminado)
            {
                Response.Write("Usuario despedido sin prestaciones equis de");
            }
            else
            {
                Response.Write("Hijo de perra aun sigues con vida");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
            Int64.TryParse(dpi.Text, out dp);
            Int32.TryParse(telefono.Text, out numoe);
            admi.modificarCliente(dp, Nombre.Text, Apellido.Text, FechaNAc.Text, correo.Text, numoe, usuario.Text, contrasenia.Text, Clave.Text);
            Response.Write("Modificado jefaso");
            limpiar();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            buscarCliente(dpi.Text);
        }
        public void buscarCliente(string dp)
        {

            con.Open();
            string eliminar = "SELECT * FROM cliente WHERE dpi=" + dp + ";";

            SqlCommand cmd = new SqlCommand(eliminar, con);
            SqlDataReader resd = cmd.ExecuteReader();
            if (resd.Read())
            {
                dpi.Text = Convert.ToString(resd["dpi"]);
                Nombre.Text = Convert.ToString(resd["nombre"]);
                Apellido.Text = Convert.ToString(resd["apellido"]);
                FechaNAc.Text = Convert.ToString(resd["fecha_nac"]);
                correo.Text = Convert.ToString(resd["correo"]);
                telefono.Text = Convert.ToString(resd["telefono"]);
                usuario.Text = Convert.ToString(resd["username"]);
                contrasenia.Text = Convert.ToString(resd["contrasenia"]);
                Clave.Text = Convert.ToString(resd["palabra_clave"]);

            }
            con.Close();

        }
    }

}