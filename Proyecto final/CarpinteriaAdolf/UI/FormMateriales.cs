using System;
using System.Windows.Forms;
using CarpinteriaAdolf.Data;
using CarpinteriaAdolf.Models;

namespace CarpinteriaAdolf.UI
{
    public partial class FormMateriales : Form
    {
        private readonly MaterialRepositorio _repo = new MaterialRepositorio();
        private int _idActual = 0;

        public FormMateriales()
        {
            InitializeComponent();
            CargarGrid();
        }

        private void CargarGrid()
        {
            dgvMateriales.DataSource = null;
            dgvMateriales.DataSource = _repo.Listar();
            dgvMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Limpiar()
        {
            _idActual = 0;
            txtNombreMaterial.Clear();
            txtUnidadMedida.Clear();
            txtCostoUnitario.Clear();
            txtStockActual.Clear();
            txtNombreMaterial.Focus();
        }

        private void btnNuevoMaterial_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardarMaterial_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreMaterial.Text))
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }

            if (!decimal.TryParse(txtCostoUnitario.Text, out decimal costo))
            {
                MessageBox.Show("Costo unitario no válido");
                return;
            }

            if (!int.TryParse(txtStockActual.Text, out int stock))
            {
                MessageBox.Show("Stock no válido");
                return;
            }

            var m = new Material
            {
                IdMaterial = _idActual,
                Nombre = txtNombreMaterial.Text,
                UnidadMedida = txtUnidadMedida.Text,
                CostoUnitario = costo,
                StockActual = stock
            };

            if (_idActual == 0)
                _repo.Insertar(m);
            else
                _repo.Actualizar(m);

            CargarGrid();
            Limpiar();
        }

        private void btnEliminarMaterial_Click(object sender, EventArgs e)
        {
            if (_idActual == 0)
            {
                MessageBox.Show("Selecciona un material en la tabla.");
                return;
            }

            if (MessageBox.Show("¿Eliminar este material?", "Confirmar",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _repo.Eliminar(_idActual);
                CargarGrid();
                Limpiar();
            }
        }

       

        private void dgvMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvMateriales.Rows[e.RowIndex];

            _idActual = Convert.ToInt32(fila.Cells["IdMaterial"].Value);
            MessageBox.Show("Id seleccionado: " + _idActual); // prueba

            txtNombreMaterial.Text = fila.Cells["Nombre"].Value.ToString();
            txtUnidadMedida.Text = fila.Cells["UnidadMedida"].Value.ToString();
            txtCostoUnitario.Text = fila.Cells["CostoUnitario"].Value.ToString();
            txtStockActual.Text = fila.Cells["StockActual"].Value.ToString();
        }



    }
}


