using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DDetallesDeVenta
    {
        public List<Detalles_Venta> ListarTodo()
        {
            List<Detalles_Venta> detalles_ventas = new List<Detalles_Venta>();
            try
            {
                 using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    detalles_ventas = context.Detalles_Venta.ToList();
                }
                return detalles_ventas;
            }
            catch (Exception ex)
            {
                return detalles_ventas;
            }

        }
    }
}
