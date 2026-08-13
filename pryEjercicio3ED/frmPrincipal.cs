using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEjercicio3ED
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        clsDeuda objDeuda = new clsDeuda();

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblResultado.Text = objDeuda.Deuda.ToString();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            objDeuda.Comprar(Convert.ToDecimal(txtImporte.Text));

            txtImporte.Clear();

            lblResultado.Text = objDeuda.Deuda.ToString();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            objDeuda.Pagar(Convert.ToDecimal(txtImporte.Text));

            txtImporte.Clear();

            lblResultado.Text = objDeuda.Deuda.ToString();
        }
    }
}
