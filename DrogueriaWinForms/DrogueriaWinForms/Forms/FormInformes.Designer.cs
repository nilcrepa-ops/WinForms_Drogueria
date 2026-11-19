namespace DrogueriaWinForms.Forms
{
    partial class FormInformes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTotalVendido;
        private System.Windows.Forms.Label lblNumVentas;
        private System.Windows.Forms.Label lblProductoTop;
        private System.Windows.Forms.Button btnActualizarInforme;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Label lblTituloHistorial;
        private System.Windows.Forms.DataGridView dgvHistorialVentas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlSuperior = new System.Windows.Forms.Panel();
            lblFecha = new System.Windows.Forms.Label();
            lblTotalVendido = new System.Windows.Forms.Label();
            lblNumVentas = new System.Windows.Forms.Label();
            lblProductoTop = new System.Windows.Forms.Label();
            btnActualizarInforme = new System.Windows.Forms.Button();
            pnlCentral = new System.Windows.Forms.Panel();
            lblTituloHistorial = new System.Windows.Forms.Label();
            dgvHistorialVentas = new System.Windows.Forms.DataGridView();

            pnlSuperior.SuspendLayout();
            pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialVentas).BeginInit();
            SuspendLayout();

            pnlSuperior.BackColor = System.Drawing.Color.FromArgb(45, 58, 70);
            pnlSuperior.Controls.Add(lblFecha);
            pnlSuperior.Controls.Add(lblTotalVendido);
            pnlSuperior.Controls.Add(lblNumVentas);
            pnlSuperior.Controls.Add(lblProductoTop);
            pnlSuperior.Controls.Add(btnActualizarInforme);
            pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Padding = new System.Windows.Forms.Padding(16);
            pnlSuperior.Size = new System.Drawing.Size(734, 150);

            lblFecha.AutoSize = true;
            lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblFecha.ForeColor = System.Drawing.Color.Gainsboro;
            lblFecha.Location = new System.Drawing.Point(16, 16);
            lblFecha.Name = "lblFecha";
            lblFecha.Text = "Fecha: -";

            lblTotalVendido.AutoSize = true;
            lblTotalVendido.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTotalVendido.ForeColor = System.Drawing.Color.FromArgb(224, 242, 241);
            lblTotalVendido.Location = new System.Drawing.Point(16, 48);
            lblTotalVendido.Name = "lblTotalVendido";
            lblTotalVendido.Text = "Total vendido hoy: 0,00 €";

            lblNumVentas.AutoSize = true;
            lblNumVentas.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblNumVentas.ForeColor = System.Drawing.Color.Gainsboro;
            lblNumVentas.Location = new System.Drawing.Point(16, 86);
            lblNumVentas.Name = "lblNumVentas";
            lblNumVentas.Text = "Número de ventas: 0";

            lblProductoTop.AutoSize = true;
            lblProductoTop.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblProductoTop.ForeColor = System.Drawing.Color.Gainsboro;
            lblProductoTop.Location = new System.Drawing.Point(16, 112);
            lblProductoTop.Name = "lblProductoTop";
            lblProductoTop.Text = "Producto más vendido: -";

            btnActualizarInforme.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnActualizarInforme.BackColor = System.Drawing.Color.FromArgb(38, 166, 154);
            btnActualizarInforme.FlatAppearance.BorderSize = 0;
            btnActualizarInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizarInforme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnActualizarInforme.ForeColor = System.Drawing.Color.White;
            btnActualizarInforme.Location = new System.Drawing.Point(570, 24);
            btnActualizarInforme.Name = "btnActualizarInforme";
            btnActualizarInforme.Size = new System.Drawing.Size(148, 40);
            btnActualizarInforme.Text = "Actualizar datos";
            btnActualizarInforme.UseVisualStyleBackColor = false;
            btnActualizarInforme.Click += btnActualizarInforme_Click;

            pnlCentral.BackColor = System.Drawing.Color.FromArgb(30, 42, 54);
            pnlCentral.Controls.Add(dgvHistorialVentas);
            pnlCentral.Controls.Add(lblTituloHistorial);
            pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlCentral.Name = "pnlCentral";
            pnlCentral.Padding = new System.Windows.Forms.Padding(12);

            lblTituloHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            lblTituloHistorial.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblTituloHistorial.ForeColor = System.Drawing.Color.FromArgb(224, 242, 241);
            lblTituloHistorial.Name = "lblTituloHistorial";
            lblTituloHistorial.Padding = new System.Windows.Forms.Padding(0, 4, 0, 8);
            lblTituloHistorial.Size = new System.Drawing.Size(710, 32);
            lblTituloHistorial.Text = "Historial de Ventas";

            dgvHistorialVentas.AllowUserToAddRows = false;
            dgvHistorialVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialVentas.BackgroundColor = System.Drawing.Color.FromArgb(245, 248, 250);
            dgvHistorialVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvHistorialVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvHistorialVentas.Location = new System.Drawing.Point(12, 44);
            dgvHistorialVentas.Name = "dgvHistorialVentas";
            dgvHistorialVentas.ReadOnly = true;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(30, 42, 54);
            ClientSize = new System.Drawing.Size(734, 461);
            Controls.Add(pnlCentral);
            Controls.Add(pnlSuperior);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            MinimumSize = new System.Drawing.Size(700, 450);
            Name = "FormInformes";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Informes Diarios";
            Load += FormInformes_Load;

            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            pnlCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorialVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
