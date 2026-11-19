using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrogueriaWinForms.Models;
using DrogueriaWinForms.Services;

namespace DrogueriaWinForms.Forms
{
    public partial class FormStock : Form
    {
        private readonly ApiClient _apiClient;
        private List<Producto> _productos = new();
        private const double UMBRAL_CRITICO = 5.0; // Menos de 5 kg se marca como crítico

        public FormStock(ApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
        }

        private async void FormStock_Load(object sender, EventArgs e)
        {
            await CargarDatosAsync();
        }

        private async Task CargarDatosAsync()
        {
            try
            {
                _productos = await _apiClient.GetProductosAsync();
                FiltrarVista();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FiltrarVista()
        {
            var lista = chkSoloStockBajo.Checked
                ? _productos.Where(p => p.StockKg < UMBRAL_CRITICO).ToList()
                : _productos;

            dgvStock.DataSource = null;
            dgvStock.DataSource = lista;
        }

        private void chkSoloStockBajo_CheckedChanged(object sender, EventArgs e) => FiltrarVista();
        private async void btnActualizarStock_Click(object sender, EventArgs e) => await CargarDatosAsync();

        // Evento CellFormatting requerido por la guía para resaltar stock crítico[cite: 1]
        private void dgvStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvStock.Rows[e.RowIndex].DataBoundItem is Producto prod)
            {
                if (prod.StockKg <= 2.0)
                {
                    // Nivel extremo: rojo claro
                    e.CellStyle.BackColor = Color.LightCoral;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (prod.StockKg < UMBRAL_CRITICO)
                {
                    // Nivel bajo: amarillo/ámbar
                    e.CellStyle.BackColor = Color.Khaki;
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}