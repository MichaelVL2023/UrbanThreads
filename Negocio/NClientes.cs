using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NClientes
    {
        private DClientes dClientes = new DClientes();

        public String Registrar(Clientes clientes)
        {
            return dClientes.Registrar(clientes);

        }

        public String Modificar(Clientes clientes)
        {
            return dClientes.Modificar(clientes);

        }

        public String Eliminar(int ID_Cliente)
        {
            return dClientes.Eliminar(ID_Cliente);

        }

        public List<Clientes> ListarTodo()
        {
            
            return dClientes.ListarTodo();

        }
        public int ExistePorNombreDNI(String nombre, String DNI)
        {
            return dClientes.ExistePorNombreDNI(nombre, DNI);
        }
        public List<Clientes> ListarDatos(int ID)
        {
            return dClientes.ListarDatos(ID);
        }
        public List<Clientes> ListarPorDni(String dni)
        {
            return dClientes.ListarPorDni(dni);
        }
        public List<Clientes> ListarPorNombre(String nombre)
        {
            return dClientes.ListarPorNombre(nombre);
        }
        public List<Clientes> ListarPorPais(String pais)
        {
            return dClientes.ListarPorPais(pais);

        }
        public List<Clientes> ListarPorGenero(String sexo)
        {
            return dClientes.ListarPorGenero(sexo);
        }
        public List<Clientes> ListarMayorVentas()
        {
            return dClientes.ListarMayorVentas();
        }
        public List<Clientes> ListarMenorVentas()
        {
            return dClientes.ListarMenorVentas();
        }
    }
}
