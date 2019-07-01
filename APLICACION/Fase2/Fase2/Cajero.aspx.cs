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
    public partial class Cajero : System.Web.UI.Page
    {
        
        static int numero = 0;
        static int[] ciclo = new int[10];
        static int ns = 0;
        public static int codigocajero = 0;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
        ClientesTableAdapters.historialTransferenciaTableAdapter consi = new ClientesTableAdapters.historialTransferenciaTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            Turnos.Items.Clear();
            codEm.Text = inicio.numers.ToString();
            codigocajero = inicio.numers;
            if (menuTransfers.transfer == null)
            {
                Turnos.Text.Equals("No hay datos");
            }
            else
            {
                foreach (var item in menuTransfers.transfer)
                {
                    if (item.Estado.Equals("Procesado"))
                    {
                        Turnos.Text.Equals("No hay registros");
                    }
                    else
                    {


                        Turnos.Items.Add(item.Turno.ToString());
                    }
                }
            }
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            numero++;
            colocarDatos();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void colocarDatos()
        {
            foreach (var item in menuTransfers.transfer)
            {
                if (numero == 10)
                {
                    agregarenBase();
                    break;
                }
                else
                {


                    if (Convert.ToInt32(Turnos.SelectedValue) == item.Turno)
                    {                    
                        try
                        {
                            con.Open();
                            string eliminar = "SELECT * FROM cliente WHERE dpi=" + elde.Text + ";";

                            SqlCommand cmd = new SqlCommand(eliminar, con);
                            SqlDataReader resd = cmd.ExecuteReader();
                            if (resd.Read())
                            {
                                item.IdCliente = Convert.ToInt32(resd["idCliente"]);
                                item.Banco = bans.Text;
                                item.Estado = "Procesado";
                                item.IdEmpleado = Convert.ToInt32(codEm.Text);
                                item.Monto = Convert.ToDecimal(dinero.Text);
                                if (DropDownList1.Text.Equals("Deposito"))
                                {
                                    item.TipoTrans = 1;
                                }
                                ciclo[ns] = Convert.ToInt32(Turnos.Text);
                                ns++;
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
            public void agregarenBase()
            {
                foreach (var item in menuTransfers.transfer)
                {
                    if (item.Estado.Equals("Procesado"))
                    {
                    consi.insertarTransferencia(item.Banco, item.Monto, item.IdCliente, item.IdEmpleado, item.TipoTrans);
                        Response.Write("Listo mano");
                    }
                }
                try
                {

                for (int i = 0; i < 10; i++)
                {
                    menuTransfers.transfer.Remove(new Transferencia() { Turno=ciclo[i]});
                }
                }
                catch (Exception ex)
                {
                    Response.Write("No hay nada en cola");
                }

            }
            protected void siguiente_Click(object sender, EventArgs e)
        {
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroCliente.aspx");
        }
    }
}