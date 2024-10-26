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
    public partial class FormMenuAdmin : Form
    {    
        
        
        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormRegistroDeClientesAdmin form = new FormRegistroDeClientesAdmin();
            form.Show();
            this.Close();
        }


        private void btnProveedor_Click(object sender, EventArgs e)
        {
            FormRegistroProveedorAdmin form = new FormRegistroProveedorAdmin();
            form.Show();
            this.Close();

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportesAdmin form = new FormReportesAdmin();
            form.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {   
            FormPrincipal form = new FormPrincipal();
            form.Show();
            this.Close();

        }
    }
}
