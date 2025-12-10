using System;
using System.Windows.Forms;
using CarpinteriaAdolf.Models;
using CarpinteriaAdolf.Data;
using CarpinteriaAdolf.UI;   // ← IMPORTANTE para usar FormMuebles

namespace CarpinteriaAdolf
{
    public partial class Form1 : Form
    {
        private readonly ClienteRepositorio _repo = new ClienteRepositorio();
        private int _idActual = 0;

        public Form1()
        {
            InitializeComponent();
            CargarGrid();
        }

        private void CargarGrid()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = _repo.Listar();
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LimpiarCampos()
        {
            _idActual = 0;
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtNombre.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }

            var cli = new Cliente
            {
                IdCliente = _idActual,
                Nombre = txtNombre.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text
            };

            if (_idActual == 0)
                _repo.Insertar(cli);
            else
                _repo.Actualizar(cli);

            CargarGrid();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idActual == 0)
            {
                MessageBox.Show("Selecciona un cliente en la tabla.");
                return;
            }

            if (MessageBox.Show("¿Seguro que deseas eliminar el cliente?",
                                "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _repo.Eliminar(_idActual);
                CargarGrid();
                LimpiarCampos();
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvClientes.Rows[e.RowIndex];

            _idActual = Convert.ToInt32(fila.Cells["IdCliente"].Value);
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
            txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            txtEmail.Text = fila.Cells["Email"].Value.ToString();
        }

        // BOTÓN PARA ABRIR FORM DE MUEBLES
        private void btnMuebles_Click(object sender, EventArgs e)
        {
            FormMuebles f = new FormMuebles();
            f.Show();          // abre la ventana de Muebles
            // this.Hide();    // descomenta si quieres ocultar Form1
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            FormMateriales f = new FormMateriales();
            f.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos f = new FormPedidos();
            f.Show();
        }

    }
}
