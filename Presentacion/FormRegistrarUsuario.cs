﻿using Datos;
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
    public partial class FormRegistrarUsuario : Form
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
        public FormRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormPrincipal prin = new FormPrincipal();
            prin.Show();
            this.Close();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            if (tbDNI.Text == "" || tbNombre.Text == "" || tbApellido.Text == "" ||
            cbPais.Text == "" || cbSexo.Text == "" || tbCorreo.Text == "" || tbTelefono.Text == "" ||
            tbDirección.Text == "" || tbCiudad.Text == "" || dtFechaN.Text == "")
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

            Clientes cliente = new Clientes()
            {
                DNI = dni,
                Nombre = tbNombre.Text,
                Sexo = cbSexo.Text,
                Pais = cbPais.Text,
                Telefono = telefono,
                Apellido = tbApellido.Text,
                Correo_Electronico = email,
                Direccion = tbDirección.Text,
                Ciudad = tbCiudad.Text,
                Fecha_de_Nacimiento = dtFechaN.Value
            };

            String mensaje = nClientes.Registrar(cliente);
            MessageBox.Show(mensaje);
            FormIniciarSesion iniciarSesion= new FormIniciarSesion();
            iniciarSesion.Show();
            this.Close();
        }
    }
}
