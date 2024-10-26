using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DProveedores
    {
        public String Registrar(Proveedores proveedores)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Proveedores.Add(proveedores);
                    context.SaveChanges();
                }
                return "Registrado Correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Proveedores proveedores)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Proveedores proveedorestemp = context.Proveedores.Find(proveedores.ID_Proveedor);
                    proveedorestemp.Nombre_Proveedor = proveedores.Nombre_Proveedor;
                    proveedorestemp.Contacto = proveedores.Contacto;
                    proveedorestemp.Telefono =proveedores.Telefono;
                    proveedorestemp.Direccion = proveedores.Direccion;
                    proveedorestemp.Correo_Electronico = proveedores.Correo_Electronico;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int ID_Proveedor)
        {
            try
            {
                using(var context = new BDEFEntities())
                {
                    Proveedores proveedorestemp = context.Proveedores.Find(ID_Proveedor);
                    context.Proveedores.Remove(proveedorestemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Proveedores> ListarTodo()
        {
            List<Proveedores> proveedores = new List<Proveedores>();
            try
            {
                using(var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    proveedores = context.Proveedores.ToList();
                }
                return proveedores;
            }
            catch (Exception ex)
            {
                return proveedores;
            }
        }


    }
}
