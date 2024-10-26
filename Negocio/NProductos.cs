using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProductos
    {
        private DProductos dProductos = new DProductos();
        public String Registrar(Productos productos)
        {
            return dProductos.Registrar(productos);
        }

        public String Modificar(Productos productos)
        {
           return dProductos.Modificar(productos);
        }

        public String Eliminar(int ID_Producto)
        {
            return dProductos.Eliminar(ID_Producto);
        }

        public List<Productos> ListarTodo(int ID_Proveedor)
        {
           return dProductos.ListarTodo(ID_Proveedor); 
        }
        public List<Productos> ListarTodoDeTodos()
        {
            return dProductos.ListarTodoDeTodos();
        }
        public List<Productos> MenorCantidadDeStock()
        {
            return dProductos.MenorCantidadDeStock();
        }
        public List<Productos> ListarPorCategoria(String categoria)
        {
            return dProductos.ListarPorCategoria(categoria);
        }
        public List<Productos> ListarPorCostoMayor()
        {
            return dProductos.ListarPorCostoMayor();
        }
    }
}
