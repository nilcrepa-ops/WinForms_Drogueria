namespace DrogueriaWinForms.Forms
{
    partial class FormVentas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label lblKilos;
        private System.Windows.Forms.NumericUpDown numKilos;
        private System.Windows.Forms.Button btnAnadirCarrito;
        private System.Windows.Forms.Button btnQuitarLinea;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnConfirmarVenta;

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
            lblProducto = new System.Windows.Forms.Label();
            cmbProductos = new System.Windows.Forms.ComboBox();
            lblKilos = new System.Windows.Forms.Label();
            numKilos = new System.Windows.Forms.NumericUpDown();
            btnAnadirCarrito = new System.Windows.Forms.Button();
            btnQuitarLinea = new System.Windows.Forms.Button();
            pnlCentral = new System.Windows.Forms.Panel();
            dgvCarrito = new System.Windows.Forms.DataGridView();
            pnlInferior = new System.Windows.Forms.Panel();
            lblTotal = new System.Windows.Forms.Label();
            btnConfirmarVenta = new System.Windows.Forms.Button();

            pnlSuperior.SuspendLayout();
            pnlCentral.SuspendLayout();
            pnlInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numKilos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();

            pnlSuperior.BackColor = System.Drawing.Color.FromArgb(45, 58, 70);
            pnlSuperior.Controls.Add(lblProducto);
            pnlSuperior.Controls.Add(cmbProductos);
            pnlSuperior.Controls.Add(lblKilos);
            pnlSuperior.Controls.Add(numKilos);
            pnlSuperior.Controls.Add(btnAnadirCarrito);
            pnlSuperior.Controls.Add(btnQuitarLinea);
            pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Padding = new System.Windows.Forms.Padding(12);
            pnlSuperior.Size = new System.Drawing.Size(884, 86);

            lblProducto.AutoSize = true;
            lblProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblProducto.ForeColor = System.Drawing.Color.Gainsboro;
            lblProducto.Location = new System.Drawing.Point(12, 10);
            lblProducto.Name = "lblProducto";
            lblProducto.Text = "Producto:";

            cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbProductos.Location = new System.Drawing.Point(12, 30);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new System.Drawing.Size(360, 23);

            lblKilos.AutoSize = true;
            lblKilos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblKilos.ForeColor = System.Drawing.Color.Gainsboro;
            lblKilos.Location = new System.Drawing.Point(388, 10);
            lblKilos.Name = "lblKilos";
            lblKilos.Text = "Cantidad (kg):";

            numKilos.DecimalPlaces = 2;
            numKilos.Location = new System.Drawing.Point(388, 30);
            numKilos.Minimum = 0.01M;
            numKilos.Maximum = 10000M;
            numKilos.Name = "numKilos";
            numKilos.Size = new System.Drawing.Size(120, 23);
            numKilos.Value = 1M;

            btnAnadirCarrito.BackColor = System.Drawing.Color.FromArgb(38, 166, 154);
            btnAnadirCarrito.FlatAppearance.BorderSize = 0;
            btnAnadirCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAnadirCarrito.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnAnadirCarrito.ForeColor = System.Drawing.Color.White;
            btnAnadirCarrito.Location = new System.Drawing.Point(524, 27);
            btnAnadirCarrito.Name = "btnAnadirCarrito";
            btnAnadirCarrito.Size = new System.Drawing.Size(150, 36);
            btnAnadirCarrito.Text = "Añadir al carrito";
            btnAnadirCarrito.UseVisualStyleBackColor = false;
            btnAnadirCarrito.Click += btnAnadirCarrito_Click;

            btnQuitarLinea.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            btnQuitarLinea.FlatAppearance.BorderSize = 0;
            btnQuitarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnQuitarLinea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnQuitarLinea.ForeColor = System.Drawing.Color.White;
            btnQuitarLinea.Location = new System.Drawing.Point(684, 27);
            btnQuitarLinea.Name = "btnQuitarLinea";
            btnQuitarLinea.Size = new System.Drawing.Size(170, 36);
            btnQuitarLinea.Text = "Quitar seleccionado";
            btnQuitarLinea.UseVisualStyleBackColor = false;
            btnQuitarLinea.Click += btnQuitarLinea_Click;

            pnlCentral.BackColor = System.Drawing.Color.FromArgb(30, 42, 54);
            pnlCentral.Controls.Add(dgvCarrito);
            pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlCentral.Name = "pnlCentral";
            pnlCentral.Padding = new System.Windows.Forms.Padding(12);

            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.BackgroundColor = System.Drawing.Color.FromArgb(245, 248, 250);
            dgvCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.CellValueChanged += dgvCarrito_CellValueChanged;

            pnlInferior.BackColor = System.Drawing.Color.FromArgb(45, 58, 70);
            pnlInferior.Controls.Add(lblTotal);
            pnlInferior.Controls.Add(btnConfirmarVenta);
            pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Padding = new System.Windows.Forms.Padding(12);
            pnlInferior.Size = new System.Drawing.Size(884, 76);

            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTotal.ForeColor = System.Drawing.Color.FromArgb(224, 242, 241);
            lblTotal.Location = new System.Drawing.Point(12, 22);
            lblTotal.Name = "lblTotal";
            lblTotal.Text = "Total: 0,00 €";

            btnConfirmarVenta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            btnConfirmarVenta.BackColor = System.Drawing.Color.FromArgb(38, 166, 154);
            btnConfirmarVenta.FlatAppearance.BorderSize = 0;
            btnConfirmarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirmarVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnConfirmarVenta.ForeColor = System.Drawing.Color.White;
            btnConfirmarVenta.Location = new System.Drawing.Point(690, 18);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new System.Drawing.Size(170, 40);
            btnConfirmarVenta.Text = "Confirmar venta";
            btnConfirmarVenta.UseVisualStyleBackColor = false;
            btnConfirmarVenta.Click += btnConfirmarVenta_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(30, 42, 54);
            ClientSize = new System.Drawing.Size(884, 541);
            Controls.Add(pnlCentral);
            Controls.Add(pnlInferior);
            Controls.Add(pnlSuperior);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            MinimumSize = new System.Drawing.Size(800, 500);
            Name = "FormVentas";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Registro de Ventas";
            Load += FormVentas_Load;

            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            pnlCentral.ResumeLayout(false);
            pnlInferior.ResumeLayout(false);
            pnlInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numKilos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
