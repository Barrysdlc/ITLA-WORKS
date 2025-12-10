namespace CarpinteriaAdolf.UI
{
    partial class FormPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTituloPedidos = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbMueble = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblMueble = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.btnGuardarPedido = new System.Windows.Forms.Button();
            this.btnEliminarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloPedidos
            // 
            this.lblTituloPedidos.AutoSize = true;
            this.lblTituloPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPedidos.Location = new System.Drawing.Point(12, 9);
            this.lblTituloPedidos.Name = "lblTituloPedidos";
            this.lblTituloPedidos.Size = new System.Drawing.Size(148, 20);
            this.lblTituloPedidos.TabIndex = 0;
            this.lblTituloPedidos.Text = "Gestión de Pedidos";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(70, 48);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 24);
            this.cbCliente.TabIndex = 1;
            // 
            // cbMueble
            // 
            this.cbMueble.FormattingEnabled = true;
            this.cbMueble.Location = new System.Drawing.Point(70, 87);
            this.cbMueble.Name = "cbMueble";
            this.cbMueble.Size = new System.Drawing.Size(121, 24);
            this.cbMueble.TabIndex = 2;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(13, 51);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 16);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblMueble
            // 
            this.lblMueble.AutoSize = true;
            this.lblMueble.Location = new System.Drawing.Point(13, 90);
            this.lblMueble.Name = "lblMueble";
            this.lblMueble.Size = new System.Drawing.Size(55, 16);
            this.lblMueble.TabIndex = 4;
            this.lblMueble.Text = "Mueble:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(13, 126);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 16);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(83, 123);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 6;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDetalles.Location = new System.Drawing.Point(0, 223);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersWidth = 49;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(800, 227);
            this.dgvDetalles.TabIndex = 7;
            this.dgvDetalles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellDoubleClick);
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Location = new System.Drawing.Point(25, 176);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(135, 41);
            this.btnAgregarDetalle.TabIndex = 8;
            this.btnAgregarDetalle.Text = "Agregar";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(320, 95);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 16);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalValor
            // 
            this.lblTotalValor.AutoSize = true;
            this.lblTotalValor.Location = new System.Drawing.Point(320, 129);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(76, 16);
            this.lblTotalValor.TabIndex = 10;
            this.lblTotalValor.Text = "Valor Total:";
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.Location = new System.Drawing.Point(185, 185);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(106, 32);
            this.btnNuevoPedido.TabIndex = 11;
            this.btnNuevoPedido.Text = "Limpiar todo.";
            this.btnNuevoPedido.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPedido
            // 
            this.btnGuardarPedido.Location = new System.Drawing.Point(297, 185);
            this.btnGuardarPedido.Name = "btnGuardarPedido";
            this.btnGuardarPedido.Size = new System.Drawing.Size(109, 32);
            this.btnGuardarPedido.TabIndex = 12;
            this.btnGuardarPedido.Text = "Guardar todo.";
            this.btnGuardarPedido.UseVisualStyleBackColor = true;
            this.btnGuardarPedido.Click += new System.EventHandler(this.btnGuardarPedido_Click);
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.Location = new System.Drawing.Point(412, 185);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Size = new System.Drawing.Size(105, 32);
            this.btnEliminarPedido.TabIndex = 13;
            this.btnEliminarPedido.Text = "Borrar Pedido.";
            this.btnEliminarPedido.UseVisualStyleBackColor = true;
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarPedido);
            this.Controls.Add(this.btnGuardarPedido);
            this.Controls.Add(this.btnNuevoPedido);
            this.Controls.Add(this.lblTotalValor);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAgregarDetalle);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblMueble);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cbMueble);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.lblTituloPedidos);
            this.Name = "FormPedidos";
            this.Text = "FormPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloPedidos;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbMueble;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblMueble;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Button btnGuardarPedido;
        private System.Windows.Forms.Button btnEliminarPedido;
    }
}