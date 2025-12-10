namespace CarpinteriaAdolf.UI
{
    partial class FormMateriales
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
            this.lblTituloMateriales = new System.Windows.Forms.Label();
            this.lblNombreMaterial = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblCostoUnitario = new System.Windows.Forms.Label();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.txtNombreMaterial = new System.Windows.Forms.TextBox();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.txtCostoUnitario = new System.Windows.Forms.TextBox();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.btnNuevoMaterial = new System.Windows.Forms.Button();
            this.btnGuardarMaterial = new System.Windows.Forms.Button();
            this.btnEliminarMaterial = new System.Windows.Forms.Button();
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloMateriales
            // 
            this.lblTituloMateriales.AutoSize = true;
            this.lblTituloMateriales.Location = new System.Drawing.Point(12, 9);
            this.lblTituloMateriales.Name = "lblTituloMateriales";
            this.lblTituloMateriales.Size = new System.Drawing.Size(164, 20);
            this.lblTituloMateriales.TabIndex = 0;
            this.lblTituloMateriales.Text = "Gestión de Materiales";
            // 
            // lblNombreMaterial
            // 
            this.lblNombreMaterial.AutoSize = true;
            this.lblNombreMaterial.Location = new System.Drawing.Point(12, 50);
            this.lblNombreMaterial.Name = "lblNombreMaterial";
            this.lblNombreMaterial.Size = new System.Drawing.Size(69, 20);
            this.lblNombreMaterial.TabIndex = 1;
            this.lblNombreMaterial.Text = "Nombre:";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(12, 93);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(120, 20);
            this.lblUnidad.TabIndex = 2;
            this.lblUnidad.Text = "Unidad medida:";
            // 
            // lblCostoUnitario
            // 
            this.lblCostoUnitario.AutoSize = true;
            this.lblCostoUnitario.Location = new System.Drawing.Point(12, 135);
            this.lblCostoUnitario.Name = "lblCostoUnitario";
            this.lblCostoUnitario.Size = new System.Drawing.Size(111, 20);
            this.lblCostoUnitario.TabIndex = 3;
            this.lblCostoUnitario.Text = "Costo unitario:";
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Location = new System.Drawing.Point(12, 176);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(101, 20);
            this.lblStockActual.TabIndex = 4;
            this.lblStockActual.Text = "Stock actual:";
            // 
            // txtNombreMaterial
            // 
            this.txtNombreMaterial.Location = new System.Drawing.Point(87, 47);
            this.txtNombreMaterial.Name = "txtNombreMaterial";
            this.txtNombreMaterial.Size = new System.Drawing.Size(100, 26);
            this.txtNombreMaterial.TabIndex = 5;
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Location = new System.Drawing.Point(138, 90);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(100, 26);
            this.txtUnidadMedida.TabIndex = 6;
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.Location = new System.Drawing.Point(129, 132);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(100, 26);
            this.txtCostoUnitario.TabIndex = 7;
            // 
            // txtStockActual
            // 
            this.txtStockActual.Location = new System.Drawing.Point(119, 173);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.Size = new System.Drawing.Size(100, 26);
            this.txtStockActual.TabIndex = 8;
            // 
            // btnNuevoMaterial
            // 
            this.btnNuevoMaterial.Location = new System.Drawing.Point(12, 264);
            this.btnNuevoMaterial.Name = "btnNuevoMaterial";
            this.btnNuevoMaterial.Size = new System.Drawing.Size(75, 31);
            this.btnNuevoMaterial.TabIndex = 9;
            this.btnNuevoMaterial.Text = "Nuevo";
            this.btnNuevoMaterial.UseVisualStyleBackColor = true;
            this.btnNuevoMaterial.Click += new System.EventHandler(this.btnNuevoMaterial_Click);
            // 
            // btnGuardarMaterial
            // 
            this.btnGuardarMaterial.Location = new System.Drawing.Point(112, 264);
            this.btnGuardarMaterial.Name = "btnGuardarMaterial";
            this.btnGuardarMaterial.Size = new System.Drawing.Size(75, 31);
            this.btnGuardarMaterial.TabIndex = 10;
            this.btnGuardarMaterial.Text = "Guardar";
            this.btnGuardarMaterial.UseVisualStyleBackColor = true;
            this.btnGuardarMaterial.Click += new System.EventHandler(this.btnGuardarMaterial_Click);
            // 
            // btnEliminarMaterial
            // 
            this.btnEliminarMaterial.Location = new System.Drawing.Point(220, 264);
            this.btnEliminarMaterial.Name = "btnEliminarMaterial";
            this.btnEliminarMaterial.Size = new System.Drawing.Size(75, 31);
            this.btnEliminarMaterial.TabIndex = 11;
            this.btnEliminarMaterial.Text = "Eliminar";
            this.btnEliminarMaterial.UseVisualStyleBackColor = true;
            this.btnEliminarMaterial.Click += new System.EventHandler(this.btnEliminarMaterial_Click);
            // 
            // dgvMateriales
            // 
            this.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMateriales.Location = new System.Drawing.Point(0, 329);
            this.dgvMateriales.Name = "dgvMateriales";
            this.dgvMateriales.RowHeadersWidth = 49;
            this.dgvMateriales.RowTemplate.Height = 24;
            this.dgvMateriales.Size = new System.Drawing.Size(900, 233);
            this.dgvMateriales.TabIndex = 12;
            this.dgvMateriales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMateriales_CellClick);
            
            // 
            // FormMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.dgvMateriales);
            this.Controls.Add(this.btnEliminarMaterial);
            this.Controls.Add(this.btnGuardarMaterial);
            this.Controls.Add(this.btnNuevoMaterial);
            this.Controls.Add(this.txtStockActual);
            this.Controls.Add(this.txtCostoUnitario);
            this.Controls.Add(this.txtUnidadMedida);
            this.Controls.Add(this.txtNombreMaterial);
            this.Controls.Add(this.lblStockActual);
            this.Controls.Add(this.lblCostoUnitario);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.lblNombreMaterial);
            this.Controls.Add(this.lblTituloMateriales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMateriales";
            this.Text = "FormMateriales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloMateriales;
        private System.Windows.Forms.Label lblNombreMaterial;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblCostoUnitario;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.TextBox txtNombreMaterial;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.TextBox txtCostoUnitario;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.Button btnNuevoMaterial;
        private System.Windows.Forms.Button btnGuardarMaterial;
        private System.Windows.Forms.Button btnEliminarMaterial;
        private System.Windows.Forms.DataGridView dgvMateriales;
    }
}