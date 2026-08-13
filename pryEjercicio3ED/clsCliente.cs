using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEjercicio3ED
{
    internal class clsCliente
    {
        private Int32 codigo;
        private String nombre;
        private Decimal deuda = 0;

        public Int32 Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Decimal Deuda
        {
            get { return deuda; }
            set { deuda = value; }
        }

        public void Pagar(Decimal importe)
        {
            deuda -= importe;
        }

        public void Comprar(Decimal importe)
        {
            deuda += importe;
        }
    }
}
