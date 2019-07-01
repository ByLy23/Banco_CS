using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;
namespace Fase2
{
    
    public partial class RegistroEmpleado : System.Web.UI.Page
    {
        Administrador admi = new Administrador();
        public static bool comprobarEliminado=false;

        DataSet1TableAdapters.empleadoTableAdapter tabst = new DataSet1TableAdapters.empleadoTableAdapter();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        int numoe = 0;
        long dp = 0;
        int busc = 0;
        protected void Button5_Click(object sender, EventArgs e)
        {
            Int64.TryParse(dpi.Text, out dp);
            Int32.TryParse(telefono.Text, out numoe);
            admi.registrarEmpleado(dp,Nombre.Text,Apellido.Text,FechaNAc.Text,correo.Text,numoe,usuario.Text,contrasenia.Text,Clave.Text,rol.Text);
            Response.Write("Registrado Jefaso");
            limpiar();
        }


        public void buscarEmpleado(string dp)
        {

                con.Open();
                string eliminar = "SELECT * FROM empleado WHERE dpi=" + dp + ";";

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
                    Role.Text = Convert.ToString(resd["idTipoEmpleado"]);

                }
                con.Close();
           
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            admi.eliminarEmpleado(dpi.Text);
            if (comprobarEliminado)
            {
                Response.Write("Usuario despedido sin prestaciones equis de");
            }
            else
            {
                Response.Write("Hijo de perra aun sigues con vida");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            buscarEmpleado(dpi.Text);
            Role.Enabled = true;
        }

        protected void Role_TextChanged(object sender, EventArgs e)
        {

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
            Role.Text = "";
            Role.Enabled = false;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Int64.TryParse(dpi.Text, out dp);
            Int32.TryParse(telefono.Text, out numoe);
            Int32.TryParse(Role.Text, out busc);
            admi.modificarEmpleado(dp, Nombre.Text, Apellido.Text, FechaNAc.Text, correo.Text, numoe, usuario.Text, contrasenia.Text, Clave.Text, busc);
            Response.Write("Modificado jefaso");
            limpiar();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("Admin.aspx");
        }
    }
}