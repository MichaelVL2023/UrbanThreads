using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NVentas
    {
        private DVentas dVentas = new DVentas();

        public String Registrar(Ventas ventas)
        {
            return dVentas.Registrar(ventas);

        }

        public List<Ventas> ListarTodo()
        {
            return dVentas.ListarTodo();

        }
        public List<Ventas> BuscarVentasPorRangoDeFechas(DateTime fechaInicial, DateTime fechaFinal)
        {
            return dVentas.BuscarVentasPorRangoDeFechas(fechaInicial, fechaFinal);
        }
        public List<Ventas> MostrarVentasConMayorMontoTotalVenta()
        {
            return dVentas.MostrarVentasConMayorMontoTotalVenta();
        }
        public List<Ventas> MostrarVentasConMenorMontoTotalVenta()
        {
            return dVentas.MostrarVentasConMenorMontoTotalVenta();
        }
    }
}
