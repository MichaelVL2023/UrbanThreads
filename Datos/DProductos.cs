using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DProductos
    {
        public String Registrar(Productos productos)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Productos.Add(productos);
                    context.SaveChanges();
                }
                return "Producto Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Productos productos)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Productos productostemp = context.Productos.Find(productos.ID_Producto);
                    productostemp.Nombre = productos.Nombre;
                    productostemp.Precio = productos.Precio;
                    productostemp.Categoria = productos.Categoria;
                    productostemp.Tallas_disponibles = productos.Tallas_disponibles;
                    productostemp.Color = productos.Color;
                    productostemp.Stock = productos.Stock;
                    productostemp.ID_Proveedor = productos.ID_Proveedor;
                    context.SaveChanges();

                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int ID_Producto)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Productos productostemp = context.Productos.Find(ID_Producto);
                    context.Productos.Remove(productostemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Productos> ListarTodo(int ID_Proveedor)
        {
            List<Productos> productos = new List<Productos>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productos = context.Productos.Where(c => c.ID_Proveedor.Equals(ID_Proveedor)).ToList();

                }
                return productos;
            }
            catch (Exception ex)
            {
                return productos;
            }
        }
        public List<Productos> ListarTodoDeTodos()
        {
            List<Productos> productos = new List<Productos>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productos = context.Productos.ToList();

                }
                return productos;
            }
            catch (Exception ex)
            {
                return productos;
            }
        }

        public List<Productos> MenorCantidadDeStock()
        {
            int minimo = 0;

            List<Productos> productos = new List<Productos>();
            {
                try
                {
                    using (var context = new BDEFEntities())
                    {

                        context.Configuration.LazyLoadingEnabled = false;
                        minimo = context.Productos.Min(p => p.Stock);
                        productos = context.Productos.Where(p => p.Stock.Equals(minimo)).ToList();



                    }
                    return productos;
                }
                catch (Exception ex)
                {
                    return productos;
                }
            }
        }
        public List<Productos> ListarPorCategoria(String categoria)
        {
            List<Productos> productos = new List<Productos>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productos = context.Productos.Where(x => x.Categoria.Equals(categoria)).ToList();
                }
                return productos;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public List<Productos> ListarPorCostoMayor()
        {

            List<Productos> productos = new List<Productos>();
            {
                try
                {
                    using (var context = new BDEFEntities())
                    {

                        context.Configuration.LazyLoadingEnabled = false;
                        productos = context.Productos.OrderByDescending(p => p.Precio).ToList();



                    }
                    return productos;
                }
                catch (Exception ex)
                {
                    return productos;
                }
            }
        }
    }
}
