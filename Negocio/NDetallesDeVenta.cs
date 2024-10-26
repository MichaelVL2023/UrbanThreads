using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NDetallesDeVenta
    {
        private DDetallesDeVenta dDetallesDeVenta= new DDetallesDeVenta();
        public List<Detalles_Venta> ListarTodo()
        {
            return dDetallesDeVenta.ListarTodo();
        }
    }
}
