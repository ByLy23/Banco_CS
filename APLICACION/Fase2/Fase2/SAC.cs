using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fase2
{
    public class SAC
    {
        private string problema;
        private string estado;
        private int idCliente;
        private int idEmpleado;
        private int tipoConsulta;
        private int turno;
        public SAC()
        {

        }

        public SAC(string problema, string estado, int idCliente, int idEmpleado, int tipoConsulta, int turno)
        {
            this.problema = problema;
            this.estado = estado;
            this.idCliente = idCliente;
            this.idEmpleado = idEmpleado;
            this.tipoConsulta = tipoConsulta;
            this.Turno = turno;
        }

        public string Problema { get => problema; set => problema = value; }
        public string Estado { get => estado; set => estado = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public int TipoConsulta { get => tipoConsulta; set => tipoConsulta = value; }
        public int Turno { get => turno; set => turno = value; }
    }
}