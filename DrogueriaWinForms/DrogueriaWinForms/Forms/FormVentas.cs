using System.ComponentModel;
using DrogueriaWinForms.Models;
using DrogueriaWinForms.Services;

namespace DrogueriaWinForms.Forms
{
    public partial class FormVentas : Form
    {
        private readonly ApiClient _apiClient;
        private List<Producto> _catalogo = new();
        private readonly BindingList<LineaVentaDetalle> _carrito = new();

        public FormVentas(ApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
            dgvCarrito.DataSource = _carrito;
        }

        private async void FormVentas_Load(object sender, EventArgs e)
        {
            await CargarProductosAsync();
        }

        private async Task CargarProductosAsync()
        {
            try
            {
                var productos = await _apiClient.GetProductosAsync();
                _catalogo = productos.Where(p => p.StockKg > 0).ToList();

                cmbProductos.DataSource = null;
                cmbProductos.DataSource = _catalogo;
                cmbProductos.DisplayMember = nameof(Producto.ToString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo cargar el catálogo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnadirCarrito_Click(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem is not Producto producto)
            {
                MessageBox.Show("Selecciona un producto del catálogo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double kilosSolicitados = (double)numKilos.Value;
            var lineaExistente = _carrito.FirstOrDefault(l => l.ProductoId == producto.Id);
            double kilosActuales = lineaExistente?.Kilos ?? 0;

            if (kilosActuales + kilosSolicitados > producto.StockKg)
            {
                MessageBox.Show($"No hay stock suficiente. Disponible: {producto.StockKg} kg.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lineaExistente is not null)
            {
                lineaExistente.Kilos = kilosActuales + kilosSolicitados;
                lineaExistente.Subtotal = Math.Round(lineaExistente.Kilos * lineaExistente.PrecioKg, 2);
            }
            else
            {
                _carrito.Add(new LineaVentaDetalle
                {
                    ProductoId = producto.Id,
                    Nombre = producto.Nombre,
                    Kilos = kilosSolicitados,
                    PrecioKg = producto.PrecioKg,
                    Subtotal = Math.Round(kilosSolicitados * producto.PrecioKg, 2)
                });
            }

            dgvCarrito.Refresh();
            RecalcularTotal();
        }

        private void btnQuitarLinea_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow?.DataBoundItem is LineaVentaDetalle linea)
            {
                _carrito.Remove(linea);
                dgvCarrito.Refresh();
                RecalcularTotal();
            }
        }

        private void dgvCarrito_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvCarrito.Rows[e.RowIndex].DataBoundItem is not LineaVentaDetalle linea)
                return;

            if (linea.Kilos <= 0)
            {
                linea.Kilos = 0.01;
                MessageBox.Show("Los kilos deben ser mayores que cero. Se ha aplicado 0,01 kg.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            var producto = _catalogo.FirstOrDefault(p => p.Id == linea.ProductoId);
            if (producto is not null && linea.Kilos > producto.StockKg)
            {
                linea.Kilos = producto.StockKg;
                MessageBox.Show($"Los kilos exceden el stock disponible. Se ajustó a {producto.StockKg} kg.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            linea.Subtotal = Math.Round(linea.Kilos * linea.PrecioKg, 2);
            dgvCarrito.Refresh();
            RecalcularTotal();
        }

        private void RecalcularTotal()
        {
            double total = _carrito.Sum(l => l.Subtotal);
            lblTotal.Text = $"Total: {total:C2}";
        }

        private async void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (_carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnConfirmarVenta.Enabled = false;
            try
            {
                var payload = _carrito.Select(l => new LineaVentaInput
                {
                    ProductoId = l.ProductoId,
                    Kilos = l.Kilos
                }).ToList();

                var venta = await _apiClient.RegistrarVentaAsync(payload);
                if (venta is null)
                    throw new InvalidOperationException("La API no devolvió los datos de la venta registrada.");

                MessageBox.Show($"Venta registrada correctamente.\nID: {venta.Id}\nTotal: {venta.Total:C2}", "Venta confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _carrito.Clear();
                lblTotal.Text = "Total: 0,00 €";
                await CargarProductosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo confirmar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnConfirmarVenta.Enabled = true;
            }
        }
    }
}
