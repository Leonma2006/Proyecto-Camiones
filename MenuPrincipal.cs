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
            AbrirFormulario(new Fondo());
        }

        private void tRANSPORTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro frm = new Registro();
            frm.Show();
        }

        private void tRANSPORTEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Transporte frm = new Transporte();
            frm.Show();
        }

        private void oPERADORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operadores frm = new Operadores();
            frm.Show();
        }

        private void mAESTROToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Fondo());
        }
    }
}
