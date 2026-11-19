namespace DrogueriaWinForms.Forms
{
    partial class FormMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Panel pnlContenido;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnCatalogo = new Button();
            btnStock = new Button();
            btnVentas = new Button();
            btnInformes = new Button();
            pnlContenido = new Panel();
            pnlContenido.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(224, 242, 241);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(14, 13, 14, 11);
            lblTitulo.Size = new Size(553, 77);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "DROGUERÍA ESPECIALIZADA - PANEL DE CONTROL";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCatalogo
            // 
            btnCatalogo.Anchor = AnchorStyles.Top;
            btnCatalogo.BackColor = Color.FromArgb(38, 166, 154);
            btnCatalogo.FlatAppearance.BorderSize = 0;
            btnCatalogo.FlatStyle = FlatStyle.Flat;
            btnCatalogo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCatalogo.ForeColor = Color.White;
            btnCatalogo.Location = new Point(105, 24);
            btnCatalogo.Margin = new Padding(3, 4, 3, 4);
            btnCatalogo.Name = "btnCatalogo";
            btnCatalogo.Size = new Size(343, 64);
            btnCatalogo.TabIndex = 0;
            btnCatalogo.Text = "Catálogo de Sustancias";
            btnCatalogo.UseVisualStyleBackColor = false;
            btnCatalogo.Click += btnCatalogo_Click;
            // 
            // btnStock
            // 
            btnStock.Anchor = AnchorStyles.Top;
            btnStock.BackColor = Color.FromArgb(52, 73, 94);
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnStock.ForeColor = Color.White;
            btnStock.Location = new Point(105, 101);
            btnStock.Margin = new Padding(3, 4, 3, 4);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(343, 64);
            btnStock.TabIndex = 1;
            btnStock.Text = "Control de Stock";
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // btnVentas
            // 
            btnVentas.Anchor = AnchorStyles.Top;
            btnVentas.BackColor = Color.FromArgb(52, 73, 94);
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(105, 179);
            btnVentas.Margin = new Padding(3, 4, 3, 4);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(343, 64);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Registro de Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnInformes
            // 
            btnInformes.Anchor = AnchorStyles.Top;
            btnInformes.BackColor = Color.FromArgb(52, 73, 94);
            btnInformes.FlatAppearance.BorderSize = 0;
            btnInformes.FlatStyle = FlatStyle.Flat;
            btnInformes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInformes.ForeColor = Color.White;
            btnInformes.Location = new Point(105, 256);
            btnInformes.Margin = new Padding(3, 4, 3, 4);
            btnInformes.Name = "btnInformes";
            btnInformes.Size = new Size(343, 64);
            btnInformes.TabIndex = 3;
            btnInformes.Text = "Informes Diarios";
            btnInformes.UseVisualStyleBackColor = false;
            btnInformes.Click += btnInformes_Click;
            // 
            // pnlContenido
            // 
            pnlContenido.Controls.Add(btnCatalogo);
            pnlContenido.Controls.Add(btnStock);
            pnlContenido.Controls.Add(btnVentas);
            pnlContenido.Controls.Add(btnInformes);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(0, 77);
            pnlContenido.Margin = new Padding(3, 4, 3, 4);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Padding = new Padding(23, 27, 23, 27);
            pnlContenido.Size = new Size(553, 431);
            pnlContenido.TabIndex = 0;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 42, 54);
            ClientSize = new Size(553, 508);
            Controls.Add(pnlContenido);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Droguería Especializada - Panel de Control";
            pnlContenido.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
