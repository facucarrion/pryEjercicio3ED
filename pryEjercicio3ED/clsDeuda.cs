using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEjercicio3ED
{
    internal class clsDeuda
    {
        private Decimal deuda = 0;

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
