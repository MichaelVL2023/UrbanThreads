using Negocio;
using Datos;
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
    public partial class FormRegistroProveedorAdmin : Form
    {
        private NProveedores nProveedores = new NProveedores();
        public FormRegistroProveedorAdmin()
        {
            InitializeComponent();
            MostrarProveedores(nProveedores.ListarTodo());
        }

        private void MostrarProveedores(List<Proveedores> proveedores)
        {
            dgProveedores.DataSource = null;
            if (proveedores.Count == 0)
            {
                return;
            }
            else
            {
                dgProveedores.DataSource = proveedores;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbContacto.Text == "" || tbTelefono.Text == "" || tbDireccion.Text == "" || tbCorreo.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Proveedores proveedor = new Proveedores()
            {
                Nombre_Proveedor = tbNombre.Text,
                Contacto = tbContacto.Text,
                Telefono = tbTelefono.Text,
                Direccion = tbDireccion.Text,
                Correo_Electronico = tbCorreo.Text
            };

            String mensaje = nProveedores.Registrar(proveedor);
            MessageBox.Show(mensaje);

            MostrarProveedores(nProveedores.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgProveedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Proveedor");
                return;
            }

            int ID_Proveedor = int.Parse(dgProveedores.SelectedRows[0].Cells[0].Value.ToString());
            String mensaje = nProveedores.Eliminar(ID_Proveedor);
            MessageBox.Show(mensaje);

            MostrarProveedores(nProveedores.ListarTodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgProveedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Proveedor");
                return;
            }

            if (tbNombre.Text == "" || tbContacto.Text == "" || tbTelefono.Text == "" || tbDireccion.Text == "" || tbCorreo.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            int ID_Proveedor = int.Parse(dgProveedores.SelectedRows[0].Cells[0].Value.ToString());

            Proveedores proveedor = new Proveedores()
            {
                ID_Proveedor = ID_Proveedor,
                Nombre_Proveedor = tbNombre.Text,
                Contacto = tbContacto.Text,
                Telefono = tbTelefono.Text,
                Direccion = tbDireccion.Text,
                Correo_Electronico = tbCorreo.Text

            };

            String mensaje = nProveedores.Modificar(proveedor);
            MessageBox.Show(mensaje);

            MostrarProveedores(nProveedores.ListarTodo());
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormMenuAdmin form = new FormMenuAdmin();
            form.Show();
            this.Close();
        }

        private void btnRegistrarProductos_Click(object sender, EventArgs e)
        {
            if (dgProveedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione Proveedor");
                return;
            }

            int id = int.Parse(dgProveedores.SelectedRows[0].Cells[0].Value.ToString());
            FormRegistroProductosAdmin form = new FormRegistroProductosAdmin(id);
            form.Show();
            this.Close();
        }
    }
}

