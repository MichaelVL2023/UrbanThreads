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
    public partial class FormReporteProducto : Form
    {
        NProductos nProducto = new NProductos();
        public FormReporteProducto()
        {
            InitializeComponent();
            MostrarDatos(nProducto.ListarTodoDeTodos());
        }
        private void MostrarDatos(List<Productos> productos)
        {
            dgReporteProducto.DataSource = null;
            if (productos.Count == 0)
            {
                return;
            }
            else
            {
                dgReporteProducto.DataSource = productos;
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormReportesAdmin form = new FormReportesAdmin();
            form.Show();
            this.Close();
        }

        private void btnMenorStock_Click(object sender, EventArgs e)
        {
            MostrarDatos(nProducto.MenorCantidadDeStock());
        }

        private void btnBuscarPorCategoria_Click(object sender, EventArgs e)
        {
            if (cbCategoria.Text == "")
            {
                MessageBox.Show("Elijan una Categoria");
                return;
            }
            MostrarDatos(nProducto.ListarPorCategoria(cbCategoria.Text));
        }

        private void btnListarPorCostoMayor_Click(object sender, EventArgs e)
        {
            MostrarDatos(nProducto.ListarPorCostoMayor());
        }
    }
}
