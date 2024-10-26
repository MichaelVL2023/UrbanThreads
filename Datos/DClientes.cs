using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DClientes
    {
        public String Registrar(Clientes clientes)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Clientes.Add(clientes);
                    context.SaveChanges();
                }
                return "Cliente registrado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

        public String Modificar(Clientes clientes)
        {


            try
            {
                using (var context = new BDEFEntities())
                {
                    Clientes clientetemp = context.Clientes.Find(clientes.ID_Cliente);
                    clientetemp.DNI = clientes.DNI;
                    clientetemp.Nombre = clientes.Nombre;
                    clientetemp.Apellido = clientes.Apellido;
                    clientetemp.Correo_Electronico = clientes.Correo_Electronico;
                    clientetemp.Direccion = clientes.Direccion;
                    clientetemp.Ciudad = clientes.Ciudad;
                    clientetemp.Pais = clientes.Pais;
                    clientetemp.Telefono = clientes.Telefono;
                    clientetemp.Sexo = clientes.Sexo;
                    context.SaveChanges();

                }
                return "Cliente modificado exitosamente";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public String Eliminar(int ID_Cliente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Clientes clienteTemp = context.Clientes.Find(ID_Cliente);
                    context.Clientes.Remove(clienteTemp);
                    context.SaveChanges();
                }
                return "Cliente eliminado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public List<Clientes> ListarTodo()
        {
            List<Clientes> clientes = new List<Clientes>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    clientes = context.Clientes.ToList();
                }
                return clientes;
            }
            catch (Exception ex)
            {
                return clientes;
            }

        }
        public int ExistePorNombreDNI(String nombre, String DNI)
        {
            int result = 0;
            List<Clientes> clientesTemp = new List<Clientes>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    if (context.Clientes.Where(x => x.Nombre.Equals(nombre) && x.DNI.Equals(DNI)).Count() > 0) result = 1;
                    if (context.Clientes.Where(x => x.Nombre.Equals(nombre) && !x.DNI.Equals(DNI)).Count() > 0) result = 2;
                }
                return result;

            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public List<Clientes> ListarDatos(int ID)
        {
            List<Clientes> clientes = new List<Clientes>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    clientes = context.Clientes.Where(c => c.ID_Cliente.Equals(ID)).ToList();
                }
                return clientes;
            }
            catch (Exception ex)
            {
                return clientes;
            }
        }
         public List<Clientes> ListarPorDni(String dni)
        {
            List<Clientes> clientes = new List<Clientes>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    clientes = context.Clientes.Where(x => x.DNI.Contains(dni)).ToList();
                }
                return clientes;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public List<Clientes> ListarPorNombre(String nombre)
        {
            List<Clientes> clientes = new List<Clientes>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    clientes = context.Clientes.Where(x => x.Nombre.Contains(nombre)).ToList();
                }
                return clientes;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public List<Clientes> ListarPorPais(String pais)
        {
            List<Clientes> clientes = new List<Clientes>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    clientes = context.Clientes.Where(x => x.Pais.Contains(pais)).ToList();
                }
                return clientes;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public List<Clientes> ListarPorGenero(String sexo)
        {
            List<Clientes> clientes = new List<Clientes>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    clientes = context.Clientes.Where(x => x.Sexo.Equals(sexo)).ToList();
                }
                return clientes;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public List<Clientes> ListarMayorVentas()
        {
            int maximo = 0;

            List<Clientes> clientes = new List<Clientes>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    //clientes = context.Cliente.Where(x => x.Nombre_usuario != "admin").ToList();
                    context.Configuration.LazyLoadingEnabled = false;
                    maximo = context.Clientes.Max(x => x.Ventas.Count);
                    clientes = context.Clientes.Where(x => x.Ventas.Count.Equals(maximo) && x.Nombre != "admin").ToList();



                }

                return clientes;
            }
            catch (Exception ex)
            {
                return clientes;
            }

        }
        public List<Clientes> ListarMenorVentas()
        {
            int minimo = 0;

            List<Clientes> clientes = new List<Clientes>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    //clientes = context.Cliente.Where(x => x.Nombre_usuario != "admin").ToList();
                    context.Configuration.LazyLoadingEnabled = false;
                    minimo = context.Clientes.Min(x => x.Ventas.Count);
                    clientes = context.Clientes.Where(x => x.Ventas.Count.Equals(minimo) && x.Nombre != "admin").ToList();



                }

                return clientes;
            }
            catch (Exception ex)
            {
                return clientes;
            }

        }
        public double PromedioEdad(List<Clientes> clientesTemp)
        {
            double promedio = 0;
            double total = 0;
            try
            {
                using (var context = new BDEFEntities())
                {
                    foreach (Clientes clientes in clientesTemp)

                    {
                        context.Configuration.LazyLoadingEnabled = false;
                        int edad = DateTime.Now.Year - clientes.Fecha_de_Nacimiento.Year;
                        total += edad;


                    }
                    promedio = total / clientesTemp.Count;
                }
                return Math.Round(promedio, 2);
            }
            catch (Exception ex)
            {
                return promedio;
            }

        }
    }
}
