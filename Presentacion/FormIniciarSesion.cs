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
    public partial class FormIniciarSesion : Form
    {
        private NClientes nCliente = new NClientes();   
        public FormIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbDNI.Text == "")
            {
                MessageBox.Show("Debe completar los campos vacíos!");
                return;
            }

            List<Clientes> clientesTemp = nCliente.ListarTodo();

            if (tbNombre.Text == "ADMIN" && tbDNI.Text == "00000000")
            {
                FormMenuAdmin menuAdmin = new FormMenuAdmin();
                menuAdmin.Show();
            }
            else {
                switch (nCliente.ExistePorNombreDNI(tbNombre.Text, tbDNI.Text))
                {
                    case 0:
                        MessageBox.Show("Usuario no registrado. ¡Registrate para disfrutar UrbanThreads!");
                        return;
                    case 1:
                        Clientes cliente = clientesTemp.Find(elem => elem.Nombre.Equals(tbNombre.Text) && elem.DNI.Equals(tbDNI.Text));
                    
                            FormMenuCliente menuCliente = new FormMenuCliente(cliente.ID_Cliente);
                            menuCliente.Show();
                        
                        break;
                    case 2:
                        MessageBox.Show("DNI incorrecto. Por favor, verifica tus datos para acceder!");
                        return;
                }
            }
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormPrincipal prin = new FormPrincipal();
            prin.Show();
            this.Close();
        }
    }
}
