using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProveedores
    {
        private DProveedores dProveedores = new DProveedores();
        public String Registrar(Proveedores proveedores)
        {
            return dProveedores.Registrar(proveedores);
        }

        public String Modificar(Proveedores proveedores)
        {
            return dProveedores.Modificar(proveedores);
        }

        public String Eliminar(int ID_Proveedor)
        {
            return dProveedores.Eliminar(ID_Proveedor);
        }

        public List<Proveedores> ListarTodo()
        {
            return dProveedores.ListarTodo();
        }
    }
}
