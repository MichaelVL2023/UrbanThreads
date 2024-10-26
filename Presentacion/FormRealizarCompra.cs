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
    public partial class FormRealizarCompra : Form
    {
        private NProductos nProductos = new NProductos();
        private int id_Cliente;
        private NClientes nClientes = new NClientes();
        private NVentas nVentas = new NVentas();
        private NMetodosDePago nMetodosDePago = new NMetodosDePago();
        public FormRealizarCompra(int id_Cliente)
        {
            InitializeComponent();
            this.id_Cliente = id_Cliente;
            MostrarTarjeta(nMetodosDePago.ListarTodo(id_Cliente));
            MostrarProductos(nProductos.ListarTodoDeTodos());
        }
        private void MostrarProductos(List<Productos> productos)
        {
            dgProducto.DataSource = null;
            if (productos.Count == 0)
            {
                return;
            }
            else
            {
                dgProducto.DataSource = productos;
            }
        }
        private void MostrarTarjeta(List<Metodos_Pago> metodos_Pagos)
        {
            dgTarjeta.DataSource = null;
            if (metodos_Pagos.Count == 0)
            {
                return;
            }
            else
            {
                dgTarjeta.DataSource = metodos_Pagos;
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormMenuCliente form = new FormMenuCliente(id_Cliente);
            form.Show();
            this.Close();
        }


        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (cbEnvio.Text == "")
            {
                MessageBox.Show("Debe completar el campo de envio");
                return;
            }
            if (numCant.Value == 0)
            {
                MessageBox.Show("La cantidad a comprar debe ser mayor a 0");
                return;
            }
            int CostoEnvio = 0;
            if (cbEnvio.Text == "Nacional")
            {
                CostoEnvio = 70;
            }
            else if(cbEnvio.Text == "Internacional")
            {
                CostoEnvio = 30;
            }
            if(dgTarjeta.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un método de pago.");
                return;
            }

            // Validar que se haya seleccionado una fila en dgProducto
            if (dgProducto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un producto.");
                return;
            }

            DateTime fechaActual = DateTime.Today;
            int id_metodo = int.Parse(dgTarjeta.SelectedRows[0].Cells[0].Value.ToString());
            int cant = (int)numCant.Value;
            int precio = int.Parse(dgProducto.SelectedRows[0].Cells[2].Value.ToString());
            int precioTotal = precio * cant;
            string estado = "Completo";
            Ventas venta = new Ventas()
            {
                ID_Cliente = id_Cliente,
                Fecha_Venta = fechaActual,
                Estado_Venta = estado,
                Total_Venta = precioTotal,
                Costo_Envio = CostoEnvio,
                ID_Metodo_Pago = id_metodo
            };

            String mensaje = nVentas.Registrar(venta);
            MessageBox.Show(mensaje);
            FormRealizarCompra form = new FormRealizarCompra(id_Cliente);
            form.Show();
            this.Close();

        }
    }
 
}
