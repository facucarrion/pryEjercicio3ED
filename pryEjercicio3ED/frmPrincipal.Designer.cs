namespace pryEjercicio3ED
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.MaskedTextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblDeudaActual = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDeudaInicial = new System.Windows.Forms.Label();
            this.txtDeuda = new System.Windows.Forms.MaskedTextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblResultadoMostrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(15, 169);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(42, 13);
            this.lblImporte.TabIndex = 0;
            this.lblImporte.Text = "Importe";
            this.lblImporte.Click += new System.EventHandler(this.lblImporte_Click);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(61, 166);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(169, 20);
            this.txtImporte.TabIndex = 1;
            this.txtImporte.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtImporte_MaskInputRejected);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(16, 192);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(104, 23);
            this.btnComprar.TabIndex = 2;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(126, 192);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(104, 23);
            this.btnPagar.TabIndex = 3;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblDeudaActual
            // 
            this.lblDeudaActual.AutoSize = true;
            this.lblDeudaActual.Location = new System.Drawing.Point(15, 148);
            this.lblDeudaActual.Name = "lblDeudaActual";
            this.lblDeudaActual.Size = new System.Drawing.Size(72, 13);
            this.lblDeudaActual.TabIndex = 4;
            this.lblDeudaActual.Text = "Deuda Actual";
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Location = new System.Drawing.Point(91, 147);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(139, 16);
            this.lblResultado.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(61, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(169, 20);
            this.txtCodigo.TabIndex = 7;
            this.txtCodigo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Codigo";
            this.lblCodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(61, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDeudaInicial
            // 
            this.lblDeudaInicial.AutoSize = true;
            this.lblDeudaInicial.Location = new System.Drawing.Point(13, 70);
            this.lblDeudaInicial.Name = "lblDeudaInicial";
            this.lblDeudaInicial.Size = new System.Drawing.Size(69, 13);
            this.lblDeudaInicial.TabIndex = 10;
            this.lblDeudaInicial.Text = "Deuda Inicial";
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(91, 67);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(139, 20);
            this.txtDeuda.TabIndex = 11;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(16, 93);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(214, 27);
            this.btnMostrar.TabIndex = 12;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblResultadoMostrar
            // 
            this.lblResultadoMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultadoMostrar.Location = new System.Drawing.Point(18, 125);
            this.lblResultadoMostrar.Name = "lblResultadoMostrar";
            this.lblResultadoMostrar.Size = new System.Drawing.Size(212, 16);
            this.lblResultadoMostrar.TabIndex = 13;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 229);
            this.Controls.Add(this.lblResultadoMostrar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtDeuda);
            this.Controls.Add(this.lblDeudaInicial);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDeudaActual);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lblImporte);
            this.Name = "frmPrincipal";
            this.Text = "Ejercicio 3";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.MaskedTextBox txtImporte;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblDeudaActual;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDeudaInicial;
        private System.Windows.Forms.MaskedTextBox txtDeuda;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblResultadoMostrar;
    }
}

