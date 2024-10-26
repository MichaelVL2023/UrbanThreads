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
    public partial class FormRegistroProductosAdmin : Form
    {
        private int ID_Proveedor;
        private NProductos nProductos = new NProductos();

        public FormRegistroProductosAdmin(int ID_Proveedor)
        {
            InitializeComponent();
            this.ID_Proveedor = ID_Proveedor;
            MostrarProductos(nProductos.ListarTodo(ID_Proveedor));
        }

        private void MostrarProductos(List<Productos> productos)
        {
                dgProductos.DataSource = null;
            if (productos.Count == 0)
            {
                return;
            }
            else
            {
                dgProductos.DataSource = productos;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(tbNombre.Text == "" ||  tbPrecio.Text == "" || 
               cbCategoria.Text == "" || cbTallas.Text == "" || tbColor.Text == "" || tbStock.Text == "")
            {
                 MessageBox.Show("Ingrese todos los campos");
                return;
            }
            // Campos númericos
            int precio = 0;

            try
            {
                precio = int.Parse(tbPrecio.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese el campo correctamente");
                return;
            }
            int stock = 0;

            try
            {
                stock = int.Parse(tbStock.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese el campo correctamente");
                return;
            }
            Productos productos = new Productos()
            {
                Nombre = tbNombre.Text,
                Precio = precio,
                Categoria = cbCategoria.Text,
                Tallas_disponibles = cbTallas.Text,
                Color = tbColor.Text,
                Stock = stock,
                ID_Proveedor = ID_Proveedor
            };

            String mensaje = nProductos.Registrar(productos);
            MessageBox.Show(mensaje);

            MostrarProductos(nProductos.ListarTodo(ID_Proveedor));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
             if (dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Producto");
                return;
            }

            int ID_Producto = int.Parse(dgProductos.SelectedRows[0].Cells[0].Value.ToString());

            String mensaje = nProductos.Eliminar(ID_Producto);
            MessageBox.Show(mensaje);

            MostrarProductos(nProductos.ListarTodo(ID_Proveedor));



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Producto");
                return;
            }

            if (tbNombre.Text == "" || tbPrecio.Text == "" ||
               cbCategoria.Text == "" || cbTallas.Text == "" || tbColor.Text == "" || tbStock.Text == "")
            {
                 MessageBox.Show("Ingrese todos los campos");
                return;
            }
            int precio = 0;

            try
            {
                precio = int.Parse(tbPrecio.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese el campo correctamente");
                return;
            }
            int stock = 0;

            try
            {
                stock = int.Parse(tbStock.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese el campo correctamente");
                return;
            }
            int ID_Producto = int.Parse(dgProductos.SelectedRows[0].Cells[0].Value.ToString());

            Productos productos = new Productos()
            {
                ID_Producto = ID_Producto,
                Nombre = tbNombre.Text,
                Precio = precio,
                Categoria = cbCategoria.Text,
                Tallas_disponibles = cbTallas.Text,
                Color = tbColor.Text,
                Stock = stock,
                ID_Proveedor = ID_Proveedor
            };

            String mensaje = nProductos.Modificar(productos);
            MessageBox.Show(mensaje);

            MostrarProductos(nProductos.ListarTodo(ID_Proveedor));



        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormRegistroProveedorAdmin form = new FormRegistroProveedorAdmin();
            form.Show();
            this.Close();
        }
    }
}
