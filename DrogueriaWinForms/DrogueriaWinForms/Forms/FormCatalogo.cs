using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrogueriaWinForms.Models;
using DrogueriaWinForms.Services;

namespace DrogueriaWinForms.Forms
{
    public partial class FormCatalogo : Form
    {
        private readonly ApiClient _apiClient;
        private List<Producto> _listaProductos = new();
        private int _productoSeleccionadoId = 0;

        public FormCatalogo(ApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
        }

        private async void FormCatalogo_Load(object sender, EventArgs e)
        {
            await CargarProductosAsync();
        }

        private async Task CargarProductosAsync()
        {
            try
            {
                _listaProductos = await _apiClient.GetProductosAsync();
                ActualizarComboCategorias();
                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarComboCategorias()
        {
            string seleccionPrevia = cmbCategoria.SelectedItem?.ToString() ?? "Todas";
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Todas");

            var categorias = _listaProductos
                .Select(p => p.Categoria)
                .Distinct()
                .OrderBy(c => c);

            foreach (var cat in categorias)
            {
                cmbCategoria.Items.Add(cat);
            }

            cmbCategoria.SelectedItem = cmbCategoria.Items.Contains(seleccionPrevia) ? seleccionPrevia : "Todas";
        }

        private void AplicarFiltros()
        {
            string texto = txtBuscar.Text.Trim().ToLower();
            string categoria = cmbCategoria.SelectedItem?.ToString() ?? "Todas";

            var filtrados = _listaProductos.Where(p =>
                (string.IsNullOrEmpty(texto) || p.Nombre.ToLower().Contains(texto)) &&
                (categoria == "Todas" || p.Categoria == categoria)
            ).ToList();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = filtrados;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) => AplicarFiltros();
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e) => AplicarFiltros();
        private async void btnRefrescar_Click(object sender, EventArgs e) => await CargarProductosAsync();

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow?.DataBoundItem is Producto prod)
            {
                _productoSeleccionadoId = prod.Id;
                txtNombre.Text = prod.Nombre;
                txtCategoria.Text = prod.Categoria;
                numPrecio.Value = (decimal)prod.PrecioKg;
                numStock.Value = (decimal)prod.StockKg;
            }
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("Nombre y categoría son obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevo = new Producto
            {
                Id = 0,
                Nombre = txtNombre.Text.Trim(),
                Categoria = txtCategoria.Text.Trim(),
                PrecioKg = (double)numPrecio.Value,
                StockKg = (double)numStock.Value
            };

            try
            {
                await _apiClient.CrearProductoAsync(nuevo);
                MessageBox.Show("Sustancia añadida al catálogo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CargarProductosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo crear: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (_productoSeleccionadoId <= 0)
            {
                MessageBox.Show("Selecciona primero un producto de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var editado = new Producto
            {
                Id = _productoSeleccionadoId,
                Nombre = txtNombre.Text.Trim(),
                Categoria = txtCategoria.Text.Trim(),
                PrecioKg = (double)numPrecio.Value,
                StockKg = (double)numStock.Value
            };

            try
            {
                await _apiClient.ActualizarProductoAsync(_productoSeleccionadoId, editado);
                MessageBox.Show("Sustancia actualizada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CargarProductosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo actualizar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_productoSeleccionadoId <= 0)
            {
                MessageBox.Show("Selecciona un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("¿Seguro que deseas eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                await _apiClient.EliminarProductoAsync(_productoSeleccionadoId);
                _productoSeleccionadoId = 0;
                await CargarProductosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}