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
    public partial class inicio : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());

        public static int numers = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                string usuario = user.Text;
                string passwo = pass.Text;
                con.Open();
                if (lista.Text.Equals("Administrador"))
                {
                    string solicitud = "SELECT username,contrasenia,idTipoEmpleado,idEmpleado FROM empleado WHERE username='" + usuario + "' AND contrasenia='" + passwo + "' AND idTipoEmpleado=1";
                    SqlCommand comm = new SqlCommand(solicitud, con);
                    SqlDataReader sdr = comm.ExecuteReader();
                    if (sdr.Read())
                    {

                    numers = Convert.ToInt32(sdr["idEmpleado"]);
                    Response.Redirect("Admin.aspx");
                    }
                    else
                    {
                        Label1.Text = "pendeje";
                    }
                }
                else if (lista.Text.Equals("Cajero"))
                {
                    string solicitud = "SELECT username,contrasenia,idTipoEmpleado,idEmpleado FROM empleado WHERE username='" + usuario + "' AND contrasenia='" + passwo + "' AND idTipoEmpleado=2";
                    SqlCommand comm = new SqlCommand(solicitud, con);
                    SqlDataReader sdr = comm.ExecuteReader();
                    if (sdr.Read())
                    {

                    numers = Convert.ToInt32(sdr["idEmpleado"]);
                    Response.Redirect("agenteMenu.aspx");
                    }
                    else
                    {
                        Label1.Text = "pendeje";
                    }
                }
                else if (lista.Text.Equals("Agente"))
                {
                    string solicitud = "SELECT username,contrasenia,idTipoEmpleado,idEmpleado FROM empleado WHERE username='" + usuario + "' AND contrasenia='" + passwo + "' AND idTipoEmpleado=3";
                    SqlCommand comm = new SqlCommand(solicitud, con);
                    SqlDataReader sdr = comm.ExecuteReader();
                    if (sdr.Read())
                    {
                        numers = Convert.ToInt32(sdr["idEmpleado"]);
                        Response.Redirect("Agente.aspx");
                    }
                    else
                    {
                        Label1.Text = "pendeje";
                    }
                   
                }
                

                con.Close();
            /*}catch(Exception ex)
            {
                Response.Write(ex.Message);
            }*/
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
        }
    }
}