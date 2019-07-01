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
    public partial class Agente : System.Web.UI.Page
    {
        static int numero=0;
        static int otronumeroxd = 0;
        public static int codigoEmpleado = 0;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
        ClientesTableAdapters.historialConsultaTableAdapter consul = new ClientesTableAdapters.historialConsultaTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            codEm.Text = inicio.numers.ToString() ;
            codigoEmpleado = inicio.numers;
            num.Text = numero.ToString() ;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            buscarCliente(elde.Text);
        }
        public void buscarCliente(string dp)
        {
            try
            {
                con.Open();
                string eliminar = "SELECT * FROM cliente WHERE dpi=" + dp + ";";

                SqlCommand cmd = new SqlCommand(eliminar, con);
                SqlDataReader resd = cmd.ExecuteReader();
                if (resd.Read())
                {
                    nomclie.Text = Convert.ToString(resd["nombre"]);
                    corrcli.Text = Convert.ToString(resd["correo"]);

                }
                else
                {
                    Response.Write("No existe ese vato :v");
                }
                con.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void colocarDatos()
        {
            foreach (var item in menuTransfers.atencionCliente)
            {
                if (otronumeroxd == 10)
                {
                    verificarCola();
                    break;
                }
                else
                {


                    if (numero == item.Turno)
                    {
                        item.Problema = motivo.Text;
                        item.Estado = "Procesado";
                        item.IdEmpleado = codigoEmpleado;
                        if (cojun.Text.Equals("Queja"))
                        {
                            item.TipoConsulta = 1;
                        }
                        else if (cojun.Text.Equals("Reclamo"))
                        {
                            item.TipoConsulta = 2;
                        }
                        else if (cojun.Text.Equals("Sugerencia"))
                        {
                            item.TipoConsulta = 3;
                        }
                        else if (cojun.Text.Equals("Duda"))
                        {
                            item.TipoConsulta = 4;
                        }
                        try
                        {
                            con.Open();
                            string eliminar = "SELECT * FROM cliente WHERE dpi=" + elde.Text + ";";

                            SqlCommand cmd = new SqlCommand(eliminar, con);
                            SqlDataReader resd = cmd.ExecuteReader();
                            if (resd.Read())
                            {
                                item.IdCliente = Convert.ToInt32(resd["idCliente"]);

                            }
                            else
                            {
                                Response.Write("No existe ese vato :v");
                            }
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }
                }
                                                      
            }

        }
        public void verificarCola()
        {
                    agregarenBase();

                
            
        }
        public void agregarenBase()
        {
            foreach (var item in menuTransfers.atencionCliente)
            {
                if (item.Estado.Equals("Procesado"))
                {
                    consul.insertarConsulta(item.Problema, item.IdCliente, item.IdEmpleado, item.TipoConsulta);
                    Response.Write("Listo mano");
                }
            }
            try
            {


                for (int i = 0; i < 10; i++)
                {
                    menuTransfers.atencionCliente.Dequeue();
                }
                otronumeroxd = 0;
            }catch(Exception ex)
            {
                Response.Write("No hay nada en cola");
            }
          
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            numero++;
            otronumeroxd++;
            colocarDatos();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            Response.Redirect("RegistroCliente.aspx");
        }
    }
}