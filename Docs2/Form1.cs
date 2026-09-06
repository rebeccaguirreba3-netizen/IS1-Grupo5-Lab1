using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_EPICA1REBECCA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Establecer límites de longitud para los campos de texto
            txtusuario.MaxLength = 50;
            txtcontraseña.MaxLength = 20;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btniniciarsesion_Click_1(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text.Trim().ToUpper();
            string contraseña = txtcontraseña.Text.Trim();

            if (usuario == "REBECCA AURORA AGUIRRE BATRES" && contraseña == "1234")
            {
                label4.Text = "Inicio de sesión correcto";
                label4.ForeColor = Color.Green;
                MessageBox.Show("Bienvenida REBECCA\nUsuario REBECCA - Especialidad: Cardiología", "Acceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("bienvenido a tu calendario", "Calendario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (usuario == "FRANKLIN ALONSO MAJANO MEDRANO" && contraseña == "1234")
            {
                label4.Text = "Inicio de sesión correcto";
                label4.ForeColor = Color.Green;
                MessageBox.Show("Bienvenido FRANKLIN\nUsuario FRANKLIN - Especialidad: Traumatología", "Acceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (usuario == "KIMBERLY MARIFER MARTINEZ AGUIRRE" && contraseña == "1234")
            {
                label4.Text = "Inicio de sesión correcto";
                label4.ForeColor = Color.Green;
                MessageBox.Show("Bienvenida KIMBERLY\nUsuario KIMBERLY - Especialidad: Pediatría", "Acceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (usuario == "JESUS ELIAS CASTILLO MIRA" && contraseña == "1234")
            {
                label4.Text = "Inicio de sesión correcto";
                label4.ForeColor = Color.Green;
                MessageBox.Show("Bienvenido JESUS\nUsuario JESUS - Especialidad: Medicina General", "Acceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (usuario == "INVITADO" && contraseña == "invitado123")
            {
                label4.Text = "Inicio de sesión correcto";
                label4.ForeColor = Color.Green;
                MessageBox.Show("Usted a iniciado sesion como usuario invitado en este sitio web", "Acceso Invitado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("bienvenido usuario", "Invitado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                label4.Text = "Error de acceso";
                label4.ForeColor = Color.Red;
                MessageBox.Show("error usted no tiene permitida esta accion", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}