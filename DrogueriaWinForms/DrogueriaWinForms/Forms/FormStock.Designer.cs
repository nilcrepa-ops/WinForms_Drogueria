namespace DrogueriaWinForms.Forms
{
    partial class FormStock
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.CheckBox chkSoloStockBajo;
        private System.Windows.Forms.Button btnActualizarStock;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel pnlListado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlSuperior = new System.Windows.Forms.Panel();
            chkSoloStockBajo = new System.Windows.Forms.CheckBox();
            btnActualizarStock = new System.Windows.Forms.Button();
            pnlListado = new System.Windows.Forms.Panel();
            dgvStock = new System.Windows.Forms.DataGridView();

            pnlSuperior.SuspendLayout();
            pnlListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();

            pnlSuperior.BackColor = System.Drawing.Color.FromArgb(45, 58, 70);
            pnlSuperior.Controls.Add(chkSoloStockBajo);
            pnlSuperior.Controls.Add(btnActualizarStock);
            pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Padding = new System.Windows.Forms.Padding(12);
            pnlSuperior.Size = new System.Drawing.Size(784, 64);

            chkSoloStockBajo.AutoSize = true;
            chkSoloStockBajo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            chkSoloStockBajo.ForeColor = System.Drawing.Color.Gainsboro;
            chkSoloStockBajo.Location = new System.Drawing.Point(12, 20);
            chkSoloStockBajo.Name = "chkSoloStockBajo";
            chkSoloStockBajo.Size = new System.Drawing.Size(220, 19);
            chkSoloStockBajo.Text = "Mostrar solo stock crítico (< 5 kg)";
            chkSoloStockBajo.UseVisualStyleBackColor = true;
            chkSoloStockBajo.CheckedChanged += chkSoloStockBajo_CheckedChanged;

            btnActualizarStock.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnActualizarStock.BackColor = System.Drawing.Color.FromArgb(38, 166, 154);
            btnActualizarStock.FlatAppearance.BorderSize = 0;
            btnActualizarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizarStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnActualizarStock.ForeColor = System.Drawing.Color.White;
            btnActualizarStock.Location = new System.Drawing.Point(660, 14);
            btnActualizarStock.Name = "btnActualizarStock";
            btnActualizarStock.Size = new System.Drawing.Size(112, 36);
            btnActualizarStock.Text = "Refrescar";
            btnActualizarStock.UseVisualStyleBackColor = false;
            btnActualizarStock.Click += btnActualizarStock_Click;

            pnlListado.BackColor = System.Drawing.Color.FromArgb(30, 42, 54);
            pnlListado.Controls.Add(dgvStock);
            pnlListado.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlListado.Name = "pnlListado";
            pnlListado.Padding = new System.Windows.Forms.Padding(12);

            dgvStock.AllowUserToAddRows = false;
            dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.BackgroundColor = System.Drawing.Color.FromArgb(245, 248, 250);
            dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvStock.CellFormatting += dgvStock_CellFormatting;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(30, 42, 54);
            ClientSize = new System.Drawing.Size(784, 461);
            Controls.Add(pnlListado);
            Controls.Add(pnlSuperior);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            MinimumSize = new System.Drawing.Size(700, 450);
            Name = "FormStock";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Control de Stock Crítico";
            Load += FormStock_Load;

            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            pnlListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
