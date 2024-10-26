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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FormRegistrarUsuario registrarUsuario = new FormRegistrarUsuario();
            registrarUsuario.Show();
            this.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            FormIniciarSesion iniciarSesion = new FormIniciarSesion();
            iniciarSesion.Show();
            this.Visible = false;
        }
    }
    
}
