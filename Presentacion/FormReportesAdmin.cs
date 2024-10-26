using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormReportesAdmin : Form
    {
        public FormReportesAdmin()
        {
            InitializeComponent();
        }

        private void btnReporteVenta_Click(object sender, EventArgs e)
        {
            FormReporteVenta form = new FormReporteVenta();
            form.Show();
            this.Close();
        }

        private void btnReporteCliente_Click(object sender, EventArgs e)
        {
            FormReporteCliente form = new FormReporteCliente();
            form.Show();
            this.Close();
        }

        private void btnReporteProductos_Click(object sender, EventArgs e)
        {
            FormReporteProducto form = new FormReporteProducto();
            form.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormMenuAdmin form = new FormMenuAdmin();
            form.Show();
            this.Close();
        }
    }
}
