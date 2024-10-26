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
    public partial class FormReporteVenta : Form
    {
        NVentas nVentas = new NVentas();
        public FormReporteVenta()
        {
            InitializeComponent();
            MostrarDatos(nVentas.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormReportesAdmin form = new FormReportesAdmin();
            form.Show();
            this.Close();
        }
        private void MostrarDatos(List<Ventas> ventas)
        {
            dgReporteVentas.DataSource = null;
            if (ventas.Count == 0)
            {
                return;
            }
            else
            {
                dgReporteVentas.DataSource = ventas;
            }
        }
        private void btnVentaFecha_Click(object sender, EventArgs e)
        {
            if (dtFin.Text == "" || dtInicio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            DateTime FechaInicial = dtInicio.Value.Date;
            DateTime FechaFinal = dtFin.Value.Date;


            MostrarDatos(nVentas.BuscarVentasPorRangoDeFechas(FechaInicial, FechaFinal));
        }

        private void btnMenorMonto_Click(object sender, EventArgs e)
        {
            MostrarDatos(nVentas.MostrarVentasConMenorMontoTotalVenta());
        }

        private void btnMayorMonto_Click(object sender, EventArgs e)
        {
            MostrarDatos(nVentas.MostrarVentasConMayorMontoTotalVenta());
        }
    }
}
