using DrogueriaWinForms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DrogueriaWinForms.Forms
{
    public partial class FormMenu : Form
    {
        private readonly ApiClient _apiClient;
        public FormMenu()
        {
            InitializeComponent();
            _apiClient = new ApiClient("http://127.0.0.1:8000");
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            using var frm = new FormCatalogo(_apiClient);
            frm.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            using var frm = new FormStock(_apiClient);
            frm.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            using var frm = new FormVentas(_apiClient);
            frm.ShowDialog();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            using var frm = new FormInformes(_apiClient);
            frm.ShowDialog();
        }
    }
}
