using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fase2
{
    public class Empleado
    {
        // https://github.com/ByLy23/IPC2Fase2.git
        private int rol;
        private long dpi;
        private string nombre;
        private string apellido;
        private string fechanac;
        private string correo;
        private int telefono;
        private string usuario;
        private string contrasenia;
        private string palabraClave;

        ClientesTableAdapters.clienteTableAdapter cta = new ClientesTableAdapters.clienteTableAdapter();
        public int Rol { get => rol; set => rol = value; }
        public long Dpi { get => dpi; set => dpi = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Fechanac { get => fechanac; set => fechanac = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string PalabraClave { get => palabraClave; set => palabraClave = value; }

        public void registrarClientes(long dpi, string nombre, string apellido, string fecha, string correo, int telefono, string usuario, string contrasenia, string clave)
        {
            cta.insertaUsuario(dpi,nombre,apellido,fecha,correo,telefono,usuario,contrasenia,clave);
        }
    }
}