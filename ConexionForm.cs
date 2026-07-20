using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Proyecto_Camiones
{
    public partial class ConexionForm : Form
    {
        private bool conexionValida = false;
        private bool conexionValidata = false;
        public ConexionForm()
        {
            InitializeComponent();

            txtServidor.Text = Properties.Settings.Default.SERVIDOR;
            txtPuerto.Text = Properties.Settings.Default.PUERTO;
            txtBaseDeDatos.Text = Properties.Settings.Default.BASEDEDATOS;
            txtUsuario.Text = Properties.Settings.Default.USUARIO;

            chbRecordar.Checked =
                Properties.Settings.Default.RECORDAR;

            if (chbRecordar.Checked)
            {
                txtContraseña.Text =
                    Properties.Settings.Default.CONTRASEÑA;
            }

            lblConexion.Text = "Sin conexión";
            pConexion.BackColor = Color.Red;
        }

        private void lblConexion_Click(object sender, EventArgs e)
        {

        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            if (!conexionValida)
            {
                MessageBox.Show(
                    "Primero debe probar la conexión.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            Properties.Settings.Default.SERVIDOR = txtServidor.Text;
            Properties.Settings.Default.PUERTO = txtPuerto.Text;
            Properties.Settings.Default.BASEDEDATOS = txtBaseDeDatos.Text;
            Properties.Settings.Default.USUARIO = txtUsuario.Text;
            Properties.Settings.Default.RECORDAR = chbRecordar.Checked;
            if (chbRecordar.Checked)
            {
                Properties.Settings.Default.CONTRASEÑA =
                    txtContraseña.Text;
            }
            else
            {
                Properties.Settings.Default.CONTRASEÑA = "";
            }
            Properties.Settings.Default.Save();

            Configuracion.CadenaConexion =
                $"Server={txtServidor.Text},{txtPuerto.Text};" +
                $"Database={txtBaseDeDatos.Text};" +
                $"User Id={txtUsuario.Text};" +
                $"Password={txtContraseña.Text};" +
                $"TrustServerCertificate=True;";


            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txtServidor.Text = "";
            txtPuerto.Text = "";
            txtBaseDeDatos.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void btProbarCon_Click(object sender, EventArgs e)
        {
            if (
    string.IsNullOrWhiteSpace(txtServidor.Text) ||
    string.IsNullOrWhiteSpace(txtPuerto.Text) ||
    string.IsNullOrWhiteSpace(txtBaseDeDatos.Text) ||
    string.IsNullOrWhiteSpace(txtUsuario.Text) ||
    string.IsNullOrWhiteSpace(txtContraseña.Text)
)
            {
                MessageBox.Show(
                    "Complete todos los campos.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string cadena =
    $"Server={txtServidor.Text.Trim()},{txtPuerto.Text.Trim()};" +
    $"Database={txtBaseDeDatos.Text.Trim()};" +
    $"User Id={txtUsuario.Text.Trim()};" +
    $"Password={txtContraseña.Text.Trim()};" +
    $"TrustServerCertificate=True;";


            try
            {
                using SqlConnection cn = new(cadena);

                cn.Open();

                conexionValida = true;

                lblConexion.Text = "Conexión exitosa";
                pConexion.BackColor = Color.Green;
                MessageBox.Show(
                    "La conexión fue exitosa.",
                    "Correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                conexionValida = false;
                pConexion.BackColor = Color.Red;

                lblConexion.Text = "Error de conexión";

                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtServidor_TextChanged(object sender, EventArgs e)
        {
            conexionValida = false;
            lblConexion.Text = "Sin conexión";
            pConexion.BackColor = Color.Red;
        }

        private void txtBaseDeDatos_TextChanged(object sender, EventArgs e)
        {
            conexionValida = false;
            lblConexion.Text = "Sin conexión";
            pConexion.BackColor = Color.Red;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            conexionValida = false;
            lblConexion.Text = "Sin conexión";
            pConexion.BackColor = Color.Red;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            conexionValida = false;
            lblConexion.Text = "Sin conexión";
            pConexion.BackColor = Color.Red;
        }

        private void txtPuerto_TextChanged(object sender, EventArgs e)
        {
            conexionValida = false;
            lblConexion.Text = "Sin conexión";
            pConexion.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new();

            abrir.Filter = "Base de datos SQL (*.mdf)|*.mdf";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                txtDireccion.Text = abrir.FileName;
            }
        }

        private void btConectarAR_Click(object sender, EventArgs e)
        {
            if (!conexionValidata)
            {
                MessageBox.Show(
                    "Primero pruebe la conexión.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Configuracion.CadenaConexion =
                $@"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename={txtDireccion.Text};
        Integrated Security=True;
        Connect Timeout=30;";

            MenuPrincipal menu = new();

            menu.Show();

            this.Hide();
        }

        private void btProbarConAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show(
                    "Seleccione un archivo MDF.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string cadena =
                $@"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename={txtDireccion.Text};
        Integrated Security=True;
        Connect Timeout=30;";

            try
            {
                using SqlConnection cn = new(cadena);

                cn.Open();

                conexionValidata = true;

                lblConexionAR.Text = "Conexión exitosa";
                pConexionAR.BackColor = Color.Green;

                MessageBox.Show(
                    "El archivo fue abierto correctamente.",
                    "Correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                conexionValidata = false;

                lblConexionAR.Text = "Error de conexión";
                pConexionAR.BackColor = Color.Red;

                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btCancelarAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLimpiarAR_Click(object sender, EventArgs e)
        {
            txtDireccion.Text = "";
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            lblConexionAR.Text = "Sin conexión";
            pConexionAR.BackColor = Color.Red;
            conexionValidata = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void chbRecordar_CheckedChanged(object sender, EventArgs e)
        {
            if (!chbRecordar.Checked)
            {
                txtContraseña.Clear();
            }
        }
    }
}
