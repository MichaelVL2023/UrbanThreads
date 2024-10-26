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
    public partial class FormMenuCliente : Form
    {
        private int id_Cliente;
        private NClientes nClientes = new NClientes();

        public FormMenuCliente(int id_Cliente)
        {   
            InitializeComponent();
            this.id_Cliente = id_Cliente;
            
        }

        private void btnRealizarCompra_Click(object sender, EventArgs e)
        {
            FormRealizarCompra form = new FormRealizarCompra(id_Cliente);
            form.Show();
            this.Close();
        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            FormDatosDelCliente form = new FormDatosDelCliente(id_Cliente);
            form.Show();
            this.Close();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sesión finalizada en UrbanThreads. ¡Vuelva Pronto!");
            FormPrincipal form = new FormPrincipal();
            form.Show();
            this.Close();
        }
    }
}
