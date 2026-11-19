namespace DrogueriaWinForms.Forms
{
    partial class FormCatalogo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblCategoriaFiltro;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel pnlListado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel pnlEdicion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlFiltros = new System.Windows.Forms.Panel();
            lblBuscar = new System.Windows.Forms.Label();
            txtBuscar = new System.Windows.Forms.TextBox();
            lblCategoriaFiltro = new System.Windows.Forms.Label();
            cmbCategoria = new System.Windows.Forms.ComboBox();
            btnRefrescar = new System.Windows.Forms.Button();
            pnlListado = new System.Windows.Forms.Panel();
            dgvProductos = new System.Windows.Forms.DataGridView();
            pnlEdicion = new System.Windows.Forms.Panel();
            lblNombre = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            lblCategoria = new System.Windows.Forms.Label();
            txtCategoria = new System.Windows.Forms.TextBox();
            lblPrecio = new System.Windows.Forms.Label();
            numPrecio = new System.Windows.Forms.NumericUpDown();
            lblStock = new System.Windows.Forms.Label();
            numStock = new System.Windows.Forms.NumericUpDown();
            btnNuevo = new System.Windows.Forms.Button();
            btnEditar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();

            pnlFiltros.SuspendLayout();
            pnlListado.SuspendLayout();
            pnlEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();

            pnlFiltros.BackColor = System.Drawing.Color.FromArgb(45, 58, 70);
            pnlFiltros.Controls.Add(lblBuscar);
            pnlFiltros.Controls.Add(txtBuscar);
            pnlFiltros.Controls.Add(lblCategoriaFiltro);
            pnlFiltros.Controls.Add(cmbCategoria);
            pnlFiltros.Controls.Add(btnRefrescar);
            pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Padding = new System.Windows.Forms.Padding(12);
            pnlFiltros.Size = new System.Drawing.Size(934, 72);

            lblBuscar.AutoSize = true;
            lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblBuscar.ForeColor = System.Drawing.Color.Gainsboro;
            lblBuscar.Location = new System.Drawing.Point(12, 14);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Text = "Buscar:";

            txtBuscar.Location = new System.Drawing.Point(12, 32);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(280, 23);
            txtBuscar.TextChanged += txtBuscar_TextChanged;

            lblCategoriaFiltro.AutoSize = true;
            lblCategoriaFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblCategoriaFiltro.ForeColor = System.Drawing.Color.Gainsboro;
            lblCategoriaFiltro.Location = new System.Drawing.Point(308, 14);
            lblCategoriaFiltro.Name = "lblCategoriaFiltro";
            lblCategoriaFiltro.Text = "Categoría:";

            cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCategoria.Location = new System.Drawing.Point(308, 32);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new System.Drawing.Size(220, 23);
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;

            btnRefrescar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnRefrescar.BackColor = System.Drawing.Color.FromArgb(38, 166, 154);
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefrescar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnRefrescar.ForeColor = System.Drawing.Color.White;
            btnRefrescar.Location = new System.Drawing.Point(820, 29);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new System.Drawing.Size(100, 32);
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;

            pnlListado.BackColor = System.Drawing.Color.FromArgb(30, 42, 54);
            pnlListado.Controls.Add(dgvProductos);
            pnlListado.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlListado.Name = "pnlListado";
            pnlListado.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);

            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(245, 248, 250);
            dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;

            pnlEdicion.BackColor = System.Drawing.Color.FromArgb(45, 58, 70);
            pnlEdicion.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlEdicion.Name = "pnlEdicion";
            pnlEdicion.Padding = new System.Windows.Forms.Padding(12);
            pnlEdicion.Size = new System.Drawing.Size(934, 163);
            pnlEdicion.Controls.Add(lblNombre);
            pnlEdicion.Controls.Add(txtNombre);
            pnlEdicion.Controls.Add(lblCategoria);
            pnlEdicion.Controls.Add(txtCategoria);
            pnlEdicion.Controls.Add(lblPrecio);
            pnlEdicion.Controls.Add(numPrecio);
            pnlEdicion.Controls.Add(lblStock);
            pnlEdicion.Controls.Add(numStock);
            pnlEdicion.Controls.Add(btnNuevo);
            pnlEdicion.Controls.Add(btnEditar);
            pnlEdicion.Controls.Add(btnEliminar);

            lblNombre.AutoSize = true;
            lblNombre.ForeColor = System.Drawing.Color.Gainsboro;
            lblNombre.Location = new System.Drawing.Point(12, 12);
            lblNombre.Name = "lblNombre";
            lblNombre.Text = "Nombre:";
            txtNombre.Location = new System.Drawing.Point(12, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(260, 23);

            lblCategoria.AutoSize = true;
            lblCategoria.ForeColor = System.Drawing.Color.Gainsboro;
            lblCategoria.Location = new System.Drawing.Point(288, 12);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Text = "Categoría:";
            txtCategoria.Location = new System.Drawing.Point(288, 30);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new System.Drawing.Size(220, 23);

            lblPrecio.AutoSize = true;
            lblPrecio.ForeColor = System.Drawing.Color.Gainsboro;
            lblPrecio.Location = new System.Drawing.Point(524, 12);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Text = "Precio:";
            numPrecio.DecimalPlaces = 2;
            numPrecio.Location = new System.Drawing.Point(524, 30);
            numPrecio.Maximum = 100000;
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new System.Drawing.Size(150, 23);

            lblStock.AutoSize = true;
            lblStock.ForeColor = System.Drawing.Color.Gainsboro;
            lblStock.Location = new System.Drawing.Point(690, 12);
            lblStock.Name = "lblStock";
            lblStock.Text = "Stock:";
            numStock.DecimalPlaces = 2;
            numStock.Location = new System.Drawing.Point(690, 30);
            numStock.Maximum = 100000;
            numStock.Name = "numStock";
            numStock.Size = new System.Drawing.Size(150, 23);

            btnNuevo.BackColor = System.Drawing.Color.FromArgb(38, 166, 154);
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNuevo.ForeColor = System.Drawing.Color.White;
            btnNuevo.Location = new System.Drawing.Point(12, 82);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(120, 38);
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;

            btnEditar.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditar.ForeColor = System.Drawing.Color.White;
            btnEditar.Location = new System.Drawing.Point(142, 82);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(120, 38);
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;

            btnEliminar.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEliminar.ForeColor = System.Drawing.Color.White;
            btnEliminar.Location = new System.Drawing.Point(272, 82);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(120, 38);
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(30, 42, 54);
            ClientSize = new System.Drawing.Size(934, 561);
            Controls.Add(pnlListado);
            Controls.Add(pnlEdicion);
            Controls.Add(pnlFiltros);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            MinimumSize = new System.Drawing.Size(800, 500);
            Name = "FormCatalogo";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Catálogo de Sustancias";
            Load += FormCatalogo_Load;

            pnlFiltros.ResumeLayout(false);
            pnlFiltros.PerformLayout();
            pnlListado.ResumeLayout(false);
            pnlEdicion.ResumeLayout(false);
            pnlEdicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
