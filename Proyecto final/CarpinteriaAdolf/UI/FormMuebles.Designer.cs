namespace CarpinteriaAdolf.UI
{
    partial class FormMuebles
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblTituloMuebles = new System.Windows.Forms.Label();
            this.lblNombreMueble = new System.Windows.Forms.Label();
            this.txtNombreMueble = new System.Windows.Forms.TextBox();
            this.lblDescripcionMueble = new System.Windows.Forms.Label();
            this.txtDescripcionMueble = new System.Windows.Forms.TextBox();
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.txtPrecioBase = new System.Windows.Forms.TextBox();
            this.lblTiempoProduccion = new System.Windows.Forms.Label();
            this.txtTiempoProduccion = new System.Windows.Forms.TextBox();
            this.btnNuevoMueble = new System.Windows.Forms.Button();
            this.btnGuardarMueble = new System.Windows.Forms.Button();
            this.btnEliminarMueble = new System.Windows.Forms.Button();
            this.dgvMuebles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuebles)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblTituloMuebles
            // 
            this.lblTituloMuebles.AutoSize = true;
            this.lblTituloMuebles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMuebles.Location = new System.Drawing.Point(12, 9);
            this.lblTituloMuebles.Name = "lblTituloMuebles";
            this.lblTituloMuebles.Size = new System.Drawing.Size(151, 20);
            this.lblTituloMuebles.TabIndex = 2;
            this.lblTituloMuebles.Text = "Gestión de Muebles";
            // 
            // lblNombreMueble
            // 
            this.lblNombreMueble.AutoSize = true;
            this.lblNombreMueble.Location = new System.Drawing.Point(14, 45);
            this.lblNombreMueble.Name = "lblNombreMueble";
            this.lblNombreMueble.Size = new System.Drawing.Size(59, 16);
            this.lblNombreMueble.TabIndex = 3;
            this.lblNombreMueble.Text = "Nombre:";
            // 
            // txtNombreMueble
            // 
            this.txtNombreMueble.Location = new System.Drawing.Point(78, 42);
            this.txtNombreMueble.Name = "txtNombreMueble";
            this.txtNombreMueble.Size = new System.Drawing.Size(100, 22);
            this.txtNombreMueble.TabIndex = 4;
            // 
            // lblDescripcionMueble
            // 
            this.lblDescripcionMueble.AutoSize = true;
            this.lblDescripcionMueble.Location = new System.Drawing.Point(14, 106);
            this.lblDescripcionMueble.Name = "lblDescripcionMueble";
            this.lblDescripcionMueble.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcionMueble.TabIndex = 5;
            this.lblDescripcionMueble.Text = "Descripción:";
            // 
            // txtDescripcionMueble
            // 
            this.txtDescripcionMueble.Location = new System.Drawing.Point(102, 100);
            this.txtDescripcionMueble.Name = "txtDescripcionMueble";
            this.txtDescripcionMueble.Size = new System.Drawing.Size(100, 22);
            this.txtDescripcionMueble.TabIndex = 6;
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Location = new System.Drawing.Point(14, 164);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(83, 16);
            this.lblPrecioBase.TabIndex = 7;
            this.lblPrecioBase.Text = "Precio base:";
            // 
            // txtPrecioBase
            // 
            this.txtPrecioBase.Location = new System.Drawing.Point(102, 161);
            this.txtPrecioBase.Name = "txtPrecioBase";
            this.txtPrecioBase.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioBase.TabIndex = 8;
            // 
            // lblTiempoProduccion
            // 
            this.lblTiempoProduccion.AutoSize = true;
            this.lblTiempoProduccion.Location = new System.Drawing.Point(14, 208);
            this.lblTiempoProduccion.Name = "lblTiempoProduccion";
            this.lblTiempoProduccion.Size = new System.Drawing.Size(164, 16);
            this.lblTiempoProduccion.TabIndex = 9;
            this.lblTiempoProduccion.Text = "Tiempo producción (días):";
            // 
            // txtTiempoProduccion
            // 
            this.txtTiempoProduccion.Location = new System.Drawing.Point(184, 205);
            this.txtTiempoProduccion.Name = "txtTiempoProduccion";
            this.txtTiempoProduccion.Size = new System.Drawing.Size(91, 22);
            this.txtTiempoProduccion.TabIndex = 10;
            // 
            // btnNuevoMueble
            // 
            this.btnNuevoMueble.Location = new System.Drawing.Point(16, 259);
            this.btnNuevoMueble.Name = "btnNuevoMueble";
            this.btnNuevoMueble.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoMueble.TabIndex = 11;
            this.btnNuevoMueble.Text = "Nuevo";
            this.btnNuevoMueble.UseVisualStyleBackColor = true;
            this.btnNuevoMueble.Click += new System.EventHandler(this.btnNuevoMueble_Click);
            // 
            // btnGuardarMueble
            // 
            this.btnGuardarMueble.Location = new System.Drawing.Point(114, 259);
            this.btnGuardarMueble.Name = "btnGuardarMueble";
            this.btnGuardarMueble.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarMueble.TabIndex = 12;
            this.btnGuardarMueble.Text = "Guardar";
            this.btnGuardarMueble.UseVisualStyleBackColor = true;
            this.btnGuardarMueble.Click += new System.EventHandler(this.btnGuardarMueble_Click);
            // 
            // btnEliminarMueble
            // 
            this.btnEliminarMueble.Location = new System.Drawing.Point(218, 259);
            this.btnEliminarMueble.Name = "btnEliminarMueble";
            this.btnEliminarMueble.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMueble.TabIndex = 13;
            this.btnEliminarMueble.Text = "Eliminar";
            this.btnEliminarMueble.UseVisualStyleBackColor = true;
            this.btnEliminarMueble.Click += new System.EventHandler(this.btnEliminarMueble_Click);
            // 
            // dgvMuebles
            // 
            this.dgvMuebles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuebles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMuebles.Location = new System.Drawing.Point(0, 300);
            this.dgvMuebles.Name = "dgvMuebles";
            this.dgvMuebles.RowHeadersWidth = 49;
            this.dgvMuebles.RowTemplate.Height = 24;
            this.dgvMuebles.Size = new System.Drawing.Size(800, 150);
            this.dgvMuebles.TabIndex = 14;
            this.dgvMuebles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuebles_CellClick);
            // 
            // FormMuebles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMuebles);
            this.Controls.Add(this.btnEliminarMueble);
            this.Controls.Add(this.btnGuardarMueble);
            this.Controls.Add(this.btnNuevoMueble);
            this.Controls.Add(this.txtTiempoProduccion);
            this.Controls.Add(this.lblTiempoProduccion);
            this.Controls.Add(this.txtPrecioBase);
            this.Controls.Add(this.lblPrecioBase);
            this.Controls.Add(this.txtDescripcionMueble);
            this.Controls.Add(this.lblDescripcionMueble);
            this.Controls.Add(this.txtNombreMueble);
            this.Controls.Add(this.lblNombreMueble);
            this.Controls.Add(this.lblTituloMuebles);
            this.Name = "FormMuebles";
            this.Text = "FormMuebles";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuebles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblTituloMuebles;
        private System.Windows.Forms.Label lblNombreMueble;
        private System.Windows.Forms.TextBox txtNombreMueble;
        private System.Windows.Forms.Label lblDescripcionMueble;
        private System.Windows.Forms.TextBox txtDescripcionMueble;
        private System.Windows.Forms.Label lblPrecioBase;
        private System.Windows.Forms.TextBox txtPrecioBase;
        private System.Windows.Forms.Label lblTiempoProduccion;
        private System.Windows.Forms.TextBox txtTiempoProduccion;
        private System.Windows.Forms.Button btnNuevoMueble;
        private System.Windows.Forms.Button btnGuardarMueble;
        private System.Windows.Forms.Button btnEliminarMueble;
        private System.Windows.Forms.DataGridView dgvMuebles;
    }
}