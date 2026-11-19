using DrogueriaWinForms.Services;

namespace DrogueriaWinForms.Forms
{
    public partial class FormInformes : Form
    {
        private readonly ApiClient _apiClient;

        public FormInformes(ApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
        }

        private async void FormInformes_Load(object sender, EventArgs e)
        {
            await CargarInformeAsync();
        }

        private async void btnActualizarInforme_Click(object sender, EventArgs e)
        {
            await CargarInformeAsync();
        }

        private async Task CargarInformeAsync()
        {
            try
            {
                var informe = await _apiClient.GetInformeVentasHoyAsync();
                if (informe is null)
                    throw new InvalidOperationException("La API no devolvió el informe diario.");

                lblFecha.Text = $"Fecha del informe: {informe.Fecha}";
                lblTotalVendido.Text = $"Total vendido hoy: {informe.TotalVendidoHoy:C2}";
                lblNumVentas.Text = $"Operaciones realizadas hoy: {informe.NumeroVentas}";
                lblProductoTop.Text = $"Sustancia estrella: {informe.ProductoMasVendido} ({informe.KilosProductoMasVendido} kg)";

                var ventas = await _apiClient.GetVentasAsync();
                dgvHistorialVentas.DataSource = null;
                dgvHistorialVentas.DataSource = ventas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo cargar el informe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
