using System;
using System.Windows.Forms;
using CarpinteriaAdolf.Data;
using CarpinteriaAdolf.Models;

namespace CarpinteriaAdolf.UI
{
    public partial class FormMuebles : Form
    {
        private readonly MuebleRepositorio _repo = new MuebleRepositorio();
        private int _idActual = 0;

        public FormMuebles()
        {
            InitializeComponent();
            CargarGrid();
        }

        private void CargarGrid()
        {
            dgvMuebles.DataSource = null;
            dgvMuebles.DataSource = _repo.Listar();
            dgvMuebles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Limpiar()
        {
            _idActual = 0;
            txtNombreMueble.Clear();
            txtDescripcionMueble.Clear();
            txtPrecioBase.Clear();
            txtTiempoProduccion.Clear();
            txtNombreMueble.Focus();
        }

        private void btnNuevoMueble_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardarMueble_Click(object sender, EventArgs e)
        {
            var m = new mueble
            {
                IdMueble = _idActual,
                Nombre = txtNombreMueble.Text,
                Descripcion = txtDescripcionMueble.Text,
                PrecioBase = decimal.Parse(txtPrecioBase.Text),
                TiempoProduccion = int.Parse(txtTiempoProduccion.Text)
            };

            if (_idActual == 0)
                _repo.Insertar(m);
            else
                _repo.Actualizar(m);

            CargarGrid();
            Limpiar();
        }

        private void btnEliminarMueble_Click(object sender, EventArgs e)
        {
            if (_idActual == 0)
            {
                MessageBox.Show("Selecciona un mueble en la tabla.");
                return;
            }

            if (MessageBox.Show("¿Eliminar este mueble?", "Confirmar",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _repo.Eliminar(_idActual);
                CargarGrid();
                _idActual = 0;
                Limpiar();
            }
        }



        private void dgvMuebles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvMuebles.Rows[e.RowIndex];

            _idActual = Convert.ToInt32(fila.Cells["IdMueble"].Value);
            txtNombreMueble.Text = fila.Cells["Nombre"].Value.ToString();
            txtDescripcionMueble.Text = fila.Cells["Descripcion"].Value.ToString();
            txtPrecioBase.Text = fila.Cells["PrecioBase"].Value.ToString();
            txtTiempoProduccion.Text = fila.Cells["TiempoProduccion"].Value.ToString();
        }

    }
}
