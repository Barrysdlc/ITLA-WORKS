using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CarpinteriaAdolf.Data;
using CarpinteriaAdolf.Models;

namespace CarpinteriaAdolf.UI
{
    public partial class FormPedidos : Form
    {
        private readonly ClienteRepositorio _repoClientes = new ClienteRepositorio();
        private readonly MuebleRepositorio _repoMuebles = new MuebleRepositorio();
        private readonly PedidoRepositorio _repoPedidos = new PedidoRepositorio();

        private readonly List<PedidoDetalle> _detalles = new List<PedidoDetalle>();
        private decimal _total = 0m;

        public FormPedidos()
        {
            InitializeComponent();
            CargarCombos();
            RefrescarDetalles();
        }

        private void CargarCombos()
        {
            
            cbCliente.DataSource = _repoClientes.Listar();
            cbCliente.DisplayMember = "Nombre";
            cbCliente.ValueMember = "IdCliente";

            
            cbMueble.DataSource = _repoMuebles.Listar();
            cbMueble.DisplayMember = "Nombre";
            cbMueble.ValueMember = "IdMueble";
        }

        private void RefrescarDetalles()
        {
            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = _detalles
                .Select(d => new
                {
                    d.IdMueble,
                    NombreMueble = _repoMuebles.Listar()
                        .First(m => m.IdMueble == d.IdMueble).Nombre,
                    d.Cantidad,
                    d.Precio,
                    d.Subtotal
                })
                .ToList();

            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            _total = _detalles.Sum(d => d.Subtotal);
            lblTotalValor.Text = _total.ToString("0.00");
        }

        private void LimpiarPedido()
        {
            _detalles.Clear();
            _total = 0m;
            txtCantidad.Clear();
            lblTotalValor.Text = "0.00";
            RefrescarDetalles();
        }

        
        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (cbMueble.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un mueble.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad no válida.");
                return;
            }

            var muebleSeleccionado = (mueble)cbMueble.SelectedItem;

            var detalle = new PedidoDetalle
            {
                IdMueble = muebleSeleccionado.IdMueble,
                Cantidad = cantidad,
                Precio = muebleSeleccionado.PrecioBase,
                Subtotal = muebleSeleccionado.PrecioBase * cantidad
            };

            _detalles.Add(detalle);
            RefrescarDetalles();
            txtCantidad.Clear();
        }

        
        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            if (cbCliente.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un cliente.");
                return;
            }

            if (_detalles.Count == 0)
            {
                MessageBox.Show("Agrega al menos un mueble al pedido.");
                return;
            }

            var cliente = (Cliente)cbCliente.SelectedItem;

            var pedido = new Pedido
            {
                IdCliente = cliente.IdCliente,
                FechaPedido = DateTime.Now,
             
                Estado = "Pendiente",
                CostoTotal = _total
            };

            int idGenerado = _repoPedidos.InsertarPedido(pedido, _detalles);
            MessageBox.Show("Pedido guardado con Id: " + idGenerado);

            LimpiarPedido();
        }

        
        private void dgvDetalles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            _detalles.RemoveAt(e.RowIndex);
            RefrescarDetalles();
        }
    }
}
