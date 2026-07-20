using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Camiones
{
    public partial class MenuPrincipal : Form
    {
        private void AbrirUnico<T>() where T : Form, new()
        {
            Form frmAbierto = Application.OpenForms
                .OfType<T>()
                .FirstOrDefault();

            if (frmAbierto != null)
            {
                frmAbierto.BringToFront();
                frmAbierto.Focus();
                return;
            }

            new T().Show();
        }

        private Form formularioActivo = null;
        private void AbrirFormulario(Form formulario)
        {
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formulario;

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(formulario);

            formulario.Show();
        }
        public MenuPrincipal()
        {
            InitializeComponent();
            AbrirFormulario(new Fondo());
        }

        private void tRANSPORTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnico<Registro>();
        }

        private void tRANSPORTEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirUnico<Transporte>();
        }

        private void oPERADORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnico<Operadores>();
        }

        private void mAESTROToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConexionForm conexion = Application.OpenForms
             .OfType<ConexionForm>()
             .FirstOrDefault();

            if (conexion != null)
            {
                conexion.Show();
                conexion.WindowState = FormWindowState.Normal;
                conexion.BringToFront();
            }

            foreach (Form frm in Application.OpenForms.Cast<Form>().ToList())
            {
                if (frm != conexion)
                {
                    frm.Close();
                }
            }
        }
    }
}
