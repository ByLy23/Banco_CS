using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fase2
{
    public partial class menuTransfers : System.Web.UI.Page
    {
       public  static Queue<SAC> atencionCliente = new Queue<SAC>();
        public static LinkedList<Transferencia> transfer = new LinkedList<Transferencia>();
        public static LinkedList<Chequera> cheque = new LinkedList<Chequera>();
        public static int turnotra = 0;
       public static int turno = 0;
        public static int turnocheq = 0;
        static int pruebita = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
      
        protected void Button2_Click(object sender, EventArgs e)
        {
            turno++;
            atencionCliente.Enqueue(new SAC("","Pendiente",0,0,0,turno));
            foreach (var item in atencionCliente)
            {
               
                Response.Write(item.Turno);
            }
            turs.Text = turno.ToString();
            
          
        }

        
        protected void Button3_Click(object sender, EventArgs e)
        {
            turnocheq++;
            cheque.AddLast(new Chequera(turnocheq, 0, 0, "", 0, "Solicitud de chequera", "Pendiente"));
            foreach (var item in atencionCliente)
            {

                Response.Write(item.Turno);
            }
            turs.Text = turnocheq.ToString();
            /*foreach (var item in atencionCliente)
            {
                DropDownList1.Items.Add(item.Turno.ToString());
                item.Estado = "Procesado";
               
            }
            foreach (var item in atencionCliente)
            {
                if (item.Estado.Equals("Procesado"))
                {
                    pruebita++;
                    prueba.Text = pruebita.ToString();
                }
               
            }*/
           
            
        }
      
        protected void Button1_Click(object sender, EventArgs e)
        {
            turnotra++;
            transfer.AddLast(new Transferencia("", 0, 0, "Pendiente", 0, 0, turnotra)) ;
            foreach (var item in transfer)
            {

                Response.Write(item.Turno);
            }
            prueba.Text = turnotra.ToString();
        }
    }
}