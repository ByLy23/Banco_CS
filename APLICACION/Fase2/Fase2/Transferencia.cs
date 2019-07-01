using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fase2
{
    public class Transferencia
    {
        private string banco;
        private int idCliente;
        private decimal monto;
        private string estado;
        private int idEmpleado;
        private int tipoTrans;
        private int turno;

        public Transferencia()
        {
            this.banco = "";
            this.idCliente = 0;
            this.monto = 0;
            this.estado ="" ;
            this.idEmpleado =0;
            this.tipoTrans = 0;
            this.turno = 0;
        }
        public Transferencia(string banco, int idCliente, decimal monto, string estado, int idEmpleado, int tipoTrans, int turno)
        {
            this.banco = banco;
            this.idCliente = idCliente;
            this.monto = monto;
            this.estado = estado;
            this.idEmpleado = idEmpleado;
            this.tipoTrans = tipoTrans;
            this.turno = turno;
        }

        public string Banco { get => banco; set => banco = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public string Estado { get => estado; set => estado = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public int TipoTrans { get => tipoTrans; set => tipoTrans = value; }
        public int Turno { get => turno; set => turno = value; }
    }
}