using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Configuration;

namespace Fase2
{
    public class Administrador : Empleado
    {
        ClientesTableAdapters.clienteTableAdapter clisd = new ClientesTableAdapters.clienteTableAdapter();
        DataSet1TableAdapters.empleadoTableAdapter tabst = new DataSet1TableAdapters.empleadoTableAdapter();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
        
        public Administrador()
        {
        }
        public void registrarEmpleado(long dpi, string nombre, string apellido, string fecha, string correo, int telefono, string usuario, string contrasenia, string clave, string rol)
        {
            if (rol.Equals("Administrador"))
            {
                tabst.ingresoEmpleados(dpi,nombre,apellido,fecha,correo,telefono,usuario,contrasenia,clave,1);
            }
            if (rol.Equals("Cajero"))
            {
                tabst.ingresoEmpleados(dpi, nombre, apellido, fecha, correo, telefono, usuario, contrasenia, clave, 2);
            }
            if (rol.Equals("Agente"))
            {
                
                tabst.ingresoEmpleados(dpi, nombre, apellido, fecha, correo, telefono, usuario, contrasenia, clave, 3);
            }
        }
        public void eliminarEmpleado(string dp)
        {
         
            try
            {
                con.Open();
                string eliminar = "DELETE  FROM empleado WHERE dpi="+dp+";";
                SqlCommand cmd = new SqlCommand(eliminar,con);
                SqlDataReader resd= cmd.ExecuteReader();
                if (resd.Read())
                {
                    RegistroEmpleado.comprobarEliminado= false;
                }
                else
                {
                    RegistroEmpleado.comprobarEliminado= true;
                }
                con.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
      public void eliminarCliente(string dp)
        {
            try { 
            con.Open();
            string eliminar = "DELETE  FROM cliente WHERE dpi=" + dp + ";";
            SqlCommand cmd = new SqlCommand(eliminar, con);
            SqlDataReader resd = cmd.ExecuteReader();
            if (resd.Read())
            {
                RegistroCliente.comprobarEliminado = false;
            }
            else
            {
                RegistroCliente.comprobarEliminado = true;
            }
            con.Close();
        }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
}
        public void modificarCliente(long dpi, string nombre, string apellido, string fecha, string correo, int telefono, string usuario, string contrasenia, string clave)
        {
            clisd.actualizaCliente(dpi, nombre, apellido, fecha, correo, telefono, usuario, contrasenia, clave, dpi);
        }
        public void modificarEmpleado(long dpi, string nombre, string apellido, string fecha, string correo, int telefono, string usuario, string contrasenia, string clave, int rol)
        {
            tabst.ActualizarUser(dpi,nombre,apellido,fecha,correo,telefono,usuario,contrasenia,clave,rol,dpi);
        }
    }
}