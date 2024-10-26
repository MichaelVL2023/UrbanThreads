using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormRegistroDeClientesAdmin : Form
    {
        private NClientes nClientes = new NClientes();
        public FormRegistroDeClientesAdmin()
        {
            InitializeComponent();
            MostrarClientes(nClientes.ListarTodo());
        }

        private void MostrarClientes(List<Clientes> clientes)
        {
            dgClientes.DataSource = null;
            if (clientes.Count == 0)
            {
                return;
            }
            else
            {
                dgClientes.DataSource = clientes;
            }
        }

        private void btnBuscarDNI_Click(object sender, EventArgs e)
        {
            if (tbBuscarDNI.Text == "")
            {
                MessageBox.Show("Ingrese un DNI a buscar");
            }
            MostrarClientes(nClientes.ListarPorDni(tbBuscarDNI.Text));
        }

        private void btnBuscarPorNombre_Click(object sender, EventArgs e)
        {
            if (tbBuscarPorNombre.Text == "")
            {
                MessageBox.Show("Ingrese un Nombre a buscar");
            }
            MostrarClientes(nClientes.ListarPorNombre(tbBuscarPorNombre.Text));
        }

        private void btnBuscarPorPais_Click(object sender, EventArgs e)
        {
            if (tbBuscarPorPais.Text == "")
            {
                MessageBox.Show("Ingrese un Pais a buscar");
            }
            MostrarClientes(nClientes.ListarPorPais(tbBuscarPorPais.Text));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            MostrarClientes(nClientes.ListarTodo());
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormMenuAdmin form = new FormMenuAdmin();
            form.Show();
            this.Close();
        }
    }
}
