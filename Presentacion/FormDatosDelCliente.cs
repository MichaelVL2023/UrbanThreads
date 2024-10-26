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
    public partial class FormDatosDelCliente : Form
    {
        private bool EsNumero(string texto)
        {
            return texto.All(char.IsDigit);
        }
        private bool EsCorreoValido(string email)
        {

            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            int atIndex = email.IndexOf('@');
            int dotIndex = email.LastIndexOf('.');


            if (atIndex > 0 && dotIndex > atIndex + 1 && dotIndex < email.Length - 1)
            {
                return true;
            }

            return false;
        }
        private NClientes nClientes = new NClientes();
        private int id_Cliente;


        public FormDatosDelCliente(int id_Cliente)
        {
            InitializeComponent();
            this.id_Cliente = id_Cliente;
            MostrarDatos(nClientes.ListarDatos(id_Cliente));

        }

        private void MostrarDatos(List<Clientes> clientes)
        {
            dgDatos.DataSource = null;
            if (clientes.Count == 0)
            {
                return;
            }
            else
            {
                dgDatos.DataSource = clientes;
            }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione sus Datos");
                return;
            }
            if (tbDNI.Text == "" || tbNombre.Text == "" || tbApellido.Text == "" ||
            cbPais.Text == "" || cbSexo.Text == "" || tbCorreo.Text == "" || tbTelefono.Text == "" ||
            tbDireccion.Text == "" || tbCiudad.Text == "" || dtFechaN.Text == "")
            {
                MessageBox.Show("Debe completar los campos vacíos!");
                return;
            }
            string dni = tbDNI.Text;
            if (dni.Length != 8 || !EsNumero(dni))
            {
                MessageBox.Show("El DNI debe ser de 8 dígitos y contener solo números");
                return;
            }
            string email = tbCorreo.Text;

            if (!EsCorreoValido(email))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido");
                return;
            }
            string telefono = tbTelefono.Text;
            if (telefono.Length != 9 || !EsNumero(telefono))
            {
                MessageBox.Show("El número telefónico debe tener 9 dígitos y contener solo números");
                return;
            }
            int id_CL = int.Parse(dgDatos.SelectedRows[0].Cells[0].Value.ToString());
            Clientes cliente = new Clientes()
            {
                ID_Cliente = id_CL,
                DNI = dni,
                Nombre = tbNombre.Text,
                Sexo = cbSexo.Text,
                Pais = cbPais.Text,
                Telefono = telefono,
                Apellido = tbApellido.Text,
                Correo_Electronico = email,
                Direccion = tbDireccion.Text,
                Ciudad = tbCiudad.Text,
                Fecha_de_Nacimiento = dtFechaN.Value,
            };
            String mensaje = nClientes.Modificar(cliente);
            MessageBox.Show(mensaje);
            MostrarDatos(nClientes.ListarDatos(id_Cliente));

        }
       

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sesión finalizada en UrbanThreads. ¡Vuelve pronto!");
            FormPrincipal form = new FormPrincipal();
            form.Show();
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormMenuCliente form = new FormMenuCliente(id_Cliente);
            form.Show();
            this.Close();
        }

        private void btnMetodosDePago_Click(object sender, EventArgs e)
        {
            FormMetodoDePago form = new FormMetodoDePago(id_Cliente);
            form.Show();
            this.Close();
        }
    }
}
