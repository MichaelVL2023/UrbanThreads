using Datos;
using Negocio;
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
    public partial class FormReporteCliente : Form
    {
        NClientes ncliente = new NClientes();
        public FormReporteCliente()
        {
            InitializeComponent();
            MostrarDatos(ncliente.ListarTodo());
        }
        private void MostrarDatos(List<Clientes> clientes)
        {
            dgReporteClientes.DataSource = null;
            if (clientes.Count == 0)
            {
                return;
            }
            else
            {
                dgReporteClientes.DataSource = clientes;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormReportesAdmin form = new FormReportesAdmin();
            form.Show();
            this.Close();
        }


        private void btnBuscarPorSexo_Click(object sender, EventArgs e)
        {
            if (cbSexo.Text == "")
            {
                MessageBox.Show("Elijan un Sexo");
                return;
            }
            MostrarDatos(ncliente.ListarPorGenero(cbSexo.Text));
        }

        private void btnClienteVenta_Click(object sender, EventArgs e)
        {
            MostrarDatos(ncliente.ListarMayorVentas());
        }

        private void btnMenorClienteVentas_Click(object sender, EventArgs e)
        {
            MostrarDatos(ncliente.ListarMenorVentas());
        }
    }
}
