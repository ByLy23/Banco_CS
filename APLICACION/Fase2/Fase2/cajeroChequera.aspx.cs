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
    public partial class cajeroChequera : System.Web.UI.Page
    {
        public static int codigocajeros=0;
        static int numerofijo = 0;
        static int[] ciclo = new int[10];
        static int ns = 0;
        ClientesTableAdapters.historialChequeraTableAdapter cheq = new ClientesTableAdapters.historialChequeraTableAdapter();
        ClientesTableAdapters.inventarioTableAdapter inventari = new ClientesTableAdapters.inventarioTableAdapter();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
            verificacion.Items.Clear();
            codEm.Text = inicio.numers.ToString();
            codigocajeros = inicio.numers;
            
        }

        protected void Button1_Click1(object sender, EventArgs e)
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
                    corrcli.Text = Convert.ToString(resd["idCliente"]);

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

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroCliente.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            colocarDatos();
        }

        private void colocarDatos()
        {
            foreach (var item in menuTransfers.cheque)
            {

                if (Convert.ToInt32(torn.SelectedItem.Value) == item.Turno)
                {
                    try
                    {
                        con.Open();
                        string eliminar = "SELECT * FROM cliente WHERE dpi=" + elde.Text + ";";

                        SqlCommand cmd = new SqlCommand(eliminar, con);
                        SqlDataReader resd = cmd.ExecuteReader();
                        if (resd.Read())
                        {
                            item.Cliente = Convert.ToInt32(resd["idCliente"]);
                            item.CodChequera = 1;
                            item.Estado = "Solicitud";
                            item.Codempleado = Convert.ToInt32(codEm.Text);
                            item.CodigoExtendido = generarRandom();
                            comrp.Text = item.CodigoExtendido;
                            if (comentario.Text.Equals(""))
                            {
                                item.Comentario = "5mentarios xd";
                            }
                            else
                            {
                                item.Comentario = comentario.Text;
                            }
                            ciclo[ns] = Convert.ToInt32(torn.Text);
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

            protected void TextBox1_TextChanged(object sender, EventArgs e)
        {



        }
        private string generarRandom()
        {
            Random num1 = new Random();
            Random num2 = new Random();
            Random num3 = new Random();
            string resultado = "";
            int dato1 = (int)num1.Next(200, 400) * 3;
            int dato2 = (int)num2.Next(100, 300);
            int dato3 = (int)num3.Next(0, 100);
            resultado = "" + dato1 + "" + dato2 + "" + dato3;
            return resultado;
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            foreach (var item in menuTransfers.cheque)
            {
                verificacion.Items.Add("La chequera: " + item.CodigoExtendido + " Estado: " + item.Estado);
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
           
        }
        private void buscarChequera(string codigo)
        {
            foreach (var item in menuTransfers.cheque)
            {
                if (codigo.Equals(item.CodigoExtendido))
                {
                    if (item.Estado.Equals("Solicitud"))
                    {


                        enco.Text = "En impresion";
                        item.Estado = "Impresion";
                        break;
                    }
                }
            }
        }
        private void entregarChequera(string codigo)
        {
            foreach (var item in menuTransfers.cheque)
            {
                if (codigo.Equals(item.CodigoExtendido))
                {
                    if (item.Estado.Equals("Impresion"))
                    {
                        item.Estado = "Entregada";
                        ciclo[numerofijo] = item.Turno;
                        cheq.insertarChequera(item.Comentario, item.CodChequera, item.CodigoExtendido, item.Cliente, item.Codempleado);
                        inventari.actualizarInventario();
                        //mandar a base
                        numerofijo++;
                        break;
                    }
                }
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            buscarChequera(busqueda.Text);
        }

        protected void Button6_Click1(object sender, EventArgs e)
        {
            int numero = 0;
            if (numerofijo==10)
            {
               
                for (int i = 0; i < 10; i++)
                {
                    var node = menuTransfers.cheque.First;
                    while (node != null)
                    {
                        var nextNode = node.Next;
                        if (node.Value.Turno == ciclo[numero])
                        {
                            menuTransfers.cheque.Remove(node);
                        }
                        node = nextNode;
                       
                    }
                    numero++;
                }
                numerofijo = 0;
                numero = 0;
            }
            else
            {
                entregarChequera(busqueda.Text);
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            torn.Items.Clear();
            foreach (var item in menuTransfers.cheque)
            {
                if (item.Estado.Equals("Pendiente"))
                {
                    torn.Items.Add(item.Turno.ToString());
                }

            }
        }
    }
}