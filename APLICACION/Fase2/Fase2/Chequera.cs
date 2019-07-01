using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fase2
{
    public class Chequera
    {
        private int turno;
        private int cliente;
        private int codChequera;
        private string codigoExtendido;
        private int codempleado;
        private string comentario;
        private string estado;
        public Chequera()
        {
        }

        public Chequera(int turno, int cliente, int codChequera, string codigoExtendido, int codempleado, string comentario, string estado)
        {
            this.turno = turno;
            this.cliente = cliente;
            this.codChequera = codChequera;
            this.codigoExtendido = codigoExtendido;
            this.codempleado = codempleado;
            this.comentario = comentario;
            this.Estado = estado;
        }

        public int Turno { get => turno; set => turno = value; }
        public int Cliente { get => cliente; set => cliente = value; }
        public int CodChequera { get => codChequera; set => codChequera = value; }
        public string CodigoExtendido { get => codigoExtendido; set => codigoExtendido = value; }
        public int Codempleado { get => codempleado; set => codempleado = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public string Estado { get => estado; set => estado = value; }
    }

}