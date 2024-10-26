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
    public partial class FormMetodoDePago : Form
    {
        private int id_Cliente;
        private NMetodosDePago nMetodosDePago = new NMetodosDePago();
        public FormMetodoDePago(int id_Cliente)
        {
            InitializeComponent();
            this.id_Cliente = id_Cliente;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormDatosDelCliente form = new FormDatosDelCliente(id_Cliente);
            form.Show();
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if ( tbCVV.Text == "" ||  tbNumeroTarjeta.Text == "" || tbTitular.Text == "" || dtCaducidad.Text == "" || cbTipo.Text == "")
            {
                MessageBox.Show("Debe completar los campos vacíos!");
                return;
            }
           
            if (tbCVV.Text.Length != 3)
            {
                MessageBox.Show("El CVV debe tener 3 dígitos");
                return;
            }
           
            if (tbNumeroTarjeta.Text.Length != 19)
            {
                MessageBox.Show("El Numero de Tarjeta debe tener 16 dígitos (Usar formato: ´xxxx-xxxx-xxxx-xxxx´)");
                return;
            }
            Metodos_Pago mPago = new Metodos_Pago()
            {
                ID_Cliente = id_Cliente,
                CVV = tbCVV.Text,
                Numero_Tarjeta = tbNumeroTarjeta.Text,
                Fecha_Caducidad = dtCaducidad.Value,
                Metodo_Pago = cbTipo.Text,
                Titular_Tarjeta = tbTitular.Text
                
            };

            String mensaje = nMetodosDePago.Registrar(mPago);
            MessageBox.Show(mensaje);
        }
    }
}
