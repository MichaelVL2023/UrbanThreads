using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DVentas
    {
        public String Registrar(Ventas ventas)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Ventas.Add(ventas);
                    context.SaveChanges();
                }
                return "Registrado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

        public List<Ventas> ListarTodo()
        {
            List<Ventas> ventas = new List<Ventas>();
            try
            {
                 using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    ventas = context.Ventas.ToList();
                }
                return ventas;
            }
            catch (Exception ex)
            {
                return ventas;
            }

        }
        public List<Ventas> BuscarVentasPorRangoDeFechas(DateTime fechaInicial, DateTime fechaFinal)
        {
            List<Ventas> productoras = new List<Ventas>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productoras = context.Ventas.Where(e => e.Fecha_Venta >= fechaInicial && e.Fecha_Venta <= fechaFinal).ToList();
                }
                return productoras;
            }
            catch (Exception ex)
            {
                return productoras;
            }

        }
        public List<Ventas> MostrarVentasConMayorMontoTotalVenta()
        {
            List<Ventas> ventas = new List<Ventas>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    Decimal Total_Venta = context.Ventas.Max(v => v.Total_Venta);
                    ventas = context.Ventas.Where(v => v.Total_Venta == Total_Venta).ToList();

                }
                return ventas;
            }
            catch (Exception ex)
            {
                return ventas;
            }
        }
        public List<Ventas> MostrarVentasConMenorMontoTotalVenta()
        {
            List<Ventas> ventas = new List<Ventas>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    Decimal Total_Venta = context.Ventas.Min(v => v.Total_Venta);
                    ventas = context.Ventas.Where(v => v.Total_Venta == Total_Venta).ToList();

                }
                return ventas;
            }
            catch (Exception ex)
            {
                return ventas;
            }
        }
    }
}
