using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Camiones
{
    public partial class MenuPrincipal : Form
    {

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
            AbrirFormulario(new Form2());
        }

        private void tRANSPORTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Form1());
        }

        private void tRANSPORTEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Transporte());
        }

        private void oPERADORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Operadores());
        }

        private void mAESTROToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Form2());
        }
    }
}
