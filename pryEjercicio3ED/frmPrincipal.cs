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

        clsCliente objCliente = new clsCliente();

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblResultado.Text = objCliente.Deuda.ToString();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            objCliente.Comprar(Convert.ToDecimal(txtImporte.Text));

            txtImporte.Clear();

            lblResultado.Text = objCliente.Deuda.ToString();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            objCliente.Pagar(Convert.ToDecimal(txtImporte.Text));

            txtImporte.Clear();

            lblResultado.Text = objCliente.Deuda.ToString();
        }

        private void lblImporte_Click(object sender, EventArgs e)
        {

        }

        private void txtImporte_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            objCliente.Codigo = Convert.ToInt32(txtCodigo.Text);
            objCliente.Nombre = txtNombre.Text;
            objCliente.Deuda = Convert.ToDecimal(txtDeuda.Text);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtDeuda.Clear();

            lblResultadoMostrar.Text = objCliente.Codigo.ToString() + " - " + objCliente.Nombre + ": $" + objCliente.Deuda;
            lblResultado.Text = objCliente.Deuda.ToString();
        }
    }
}
