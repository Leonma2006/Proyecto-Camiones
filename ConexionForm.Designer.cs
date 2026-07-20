namespace Proyecto_Camiones
{
    partial class ConexionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtServidor = new TextBox();
            txtBaseDeDatos = new TextBox();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btProbarCon = new Button();
            btConectar = new Button();
            btCancelar = new Button();
            lblConexion = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btLimpiar = new Button();
            pConexion = new Panel();
            label5 = new Label();
            label6 = new Label();
            txtPuerto = new TextBox();
            tbConexion = new TabControl();
            tabPage1 = new TabPage();
            chbRecordar = new CheckBox();
            tabPage2 = new TabPage();
            btExaminar = new Button();
            txtDireccion = new TextBox();
            label8 = new Label();
            label7 = new Label();
            pConexionAR = new Panel();
            lblConexionAR = new Label();
            btLimpiarAR = new Button();
            btProbarConAR = new Button();
            btConectarAR = new Button();
            btCancelarAR = new Button();
            pConexion.SuspendLayout();
            tbConexion.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            pConexionAR.SuspendLayout();
            SuspendLayout();
            // 
            // txtServidor
            // 
            txtServidor.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtServidor.Location = new Point(225, 83);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(289, 34);
            txtServidor.TabIndex = 0;
            txtServidor.TextChanged += txtServidor_TextChanged;
            // 
            // txtBaseDeDatos
            // 
            txtBaseDeDatos.Font = new Font("Segoe UI Variable Display", 12F);
            txtBaseDeDatos.Location = new Point(225, 176);
            txtBaseDeDatos.Name = "txtBaseDeDatos";
            txtBaseDeDatos.Size = new Size(289, 34);
            txtBaseDeDatos.TabIndex = 1;
            txtBaseDeDatos.TextChanged += txtBaseDeDatos_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI Variable Display", 12F);
            txtUsuario.Location = new Point(225, 226);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(289, 34);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI Variable Display", 12F);
            txtContraseña.Location = new Point(225, 282);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(289, 34);
            txtContraseña.TabIndex = 3;
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // btProbarCon
            // 
            btProbarCon.BackColor = Color.Gold;
            btProbarCon.Font = new Font("Stencil", 24F);
            btProbarCon.Location = new Point(22, 417);
            btProbarCon.Name = "btProbarCon";
            btProbarCon.Size = new Size(492, 60);
            btProbarCon.TabIndex = 5;
            btProbarCon.Text = "PROBAR CONEXION";
            btProbarCon.UseVisualStyleBackColor = false;
            btProbarCon.Click += btProbarCon_Click;
            // 
            // btConectar
            // 
            btConectar.BackColor = Color.GreenYellow;
            btConectar.Font = new Font("Stencil", 24F);
            btConectar.Location = new Point(22, 483);
            btConectar.Name = "btConectar";
            btConectar.Size = new Size(233, 60);
            btConectar.TabIndex = 6;
            btConectar.Text = "CONECTAR";
            btConectar.UseVisualStyleBackColor = false;
            btConectar.Click += btConectar_Click;
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.Crimson;
            btCancelar.Font = new Font("Stencil", 24F);
            btCancelar.Location = new Point(275, 483);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(235, 60);
            btCancelar.TabIndex = 7;
            btCancelar.Text = "CANCELAR";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += btCancelar_Click;
            // 
            // lblConexion
            // 
            lblConexion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblConexion.AutoSize = true;
            lblConexion.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold);
            lblConexion.Location = new Point(10, 3);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(154, 29);
            lblConexion.TabIndex = 8;
            lblConexion.Text = "Sin Conexion";
            lblConexion.Click += lblConexion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 80);
            label1.Name = "label1";
            label1.Size = new Size(133, 29);
            label1.TabIndex = 9;
            label1.Text = "SERVIDOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 176);
            label2.Name = "label2";
            label2.Size = new Size(197, 29);
            label2.TabIndex = 10;
            label2.Text = "BASE DE DATOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(98, 226);
            label3.Name = "label3";
            label3.Size = new Size(121, 29);
            label3.TabIndex = 11;
            label3.Text = "USUARIO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 279);
            label4.Name = "label4";
            label4.Size = new Size(174, 29);
            label4.TabIndex = 12;
            label4.Text = "CONTRASEÑA";
            // 
            // btLimpiar
            // 
            btLimpiar.BackColor = Color.Orange;
            btLimpiar.Font = new Font("Stencil", 12F);
            btLimpiar.Image = Properties.Resources.limpiar;
            btLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btLimpiar.Location = new Point(355, 370);
            btLimpiar.Name = "btLimpiar";
            btLimpiar.Size = new Size(159, 41);
            btLimpiar.TabIndex = 13;
            btLimpiar.Text = "LIMPIAR";
            btLimpiar.UseVisualStyleBackColor = false;
            btLimpiar.Click += btLimpiar_Click;
            // 
            // pConexion
            // 
            pConexion.BackColor = Color.GreenYellow;
            pConexion.Controls.Add(lblConexion);
            pConexion.Location = new Point(22, 370);
            pConexion.Name = "pConexion";
            pConexion.Size = new Size(197, 41);
            pConexion.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 20.8F, FontStyle.Bold);
            label5.Location = new Point(86, 18);
            label5.Name = "label5";
            label5.Size = new Size(376, 46);
            label5.TabIndex = 15;
            label5.Text = "CONECTAR CON SQL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(110, 121);
            label6.Name = "label6";
            label6.Size = new Size(109, 29);
            label6.TabIndex = 17;
            label6.Text = "PUERTO";
            // 
            // txtPuerto
            // 
            txtPuerto.Font = new Font("Segoe UI Variable Display", 12F);
            txtPuerto.Location = new Point(225, 123);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(289, 34);
            txtPuerto.TabIndex = 16;
            txtPuerto.TextChanged += txtPuerto_TextChanged;
            // 
            // tbConexion
            // 
            tbConexion.Controls.Add(tabPage1);
            tbConexion.Controls.Add(tabPage2);
            tbConexion.Dock = DockStyle.Fill;
            tbConexion.Location = new Point(0, 0);
            tbConexion.Name = "tbConexion";
            tbConexion.SelectedIndex = 0;
            tbConexion.Size = new Size(560, 595);
            tbConexion.TabIndex = 18;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Info;
            tabPage1.Controls.Add(chbRecordar);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtServidor);
            tabPage1.Controls.Add(txtPuerto);
            tabPage1.Controls.Add(txtBaseDeDatos);
            tabPage1.Controls.Add(txtUsuario);
            tabPage1.Controls.Add(pConexion);
            tabPage1.Controls.Add(txtContraseña);
            tabPage1.Controls.Add(btLimpiar);
            tabPage1.Controls.Add(btProbarCon);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(btConectar);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(btCancelar);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(552, 562);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "SQL";
            tabPage1.Click += tabPage1_Click;
            // 
            // chbRecordar
            // 
            chbRecordar.AutoSize = true;
            chbRecordar.Location = new Point(225, 322);
            chbRecordar.Name = "chbRecordar";
            chbRecordar.Size = new Size(270, 30);
            chbRecordar.TabIndex = 18;
            chbRecordar.Text = "Recordar Contraseña";
            chbRecordar.UseVisualStyleBackColor = true;
            chbRecordar.CheckedChanged += chbRecordar_CheckedChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Info;
            tabPage2.Controls.Add(btExaminar);
            tabPage2.Controls.Add(txtDireccion);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(pConexionAR);
            tabPage2.Controls.Add(btLimpiarAR);
            tabPage2.Controls.Add(btProbarConAR);
            tabPage2.Controls.Add(btConectarAR);
            tabPage2.Controls.Add(btCancelarAR);
            tabPage2.Font = new Font("Showcard Gothic", 12F);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(552, 562);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ARCHIVO";
            // 
            // btExaminar
            // 
            btExaminar.BackColor = Color.NavajoWhite;
            btExaminar.Font = new Font("Stencil", 12F);
            btExaminar.Image = Properties.Resources.carpeta;
            btExaminar.ImageAlign = ContentAlignment.MiddleLeft;
            btExaminar.Location = new Point(27, 181);
            btExaminar.Name = "btExaminar";
            btExaminar.Size = new Size(159, 41);
            btExaminar.TabIndex = 23;
            btExaminar.Text = "EXAMINAR";
            btExaminar.UseVisualStyleBackColor = false;
            btExaminar.Click += button1_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(27, 134);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(488, 32);
            txtDireccion.TabIndex = 22;
            txtDireccion.TextChanged += txtDireccion_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sylfaen", 20.8F, FontStyle.Bold);
            label8.Location = new Point(40, 19);
            label8.Name = "label8";
            label8.Size = new Size(479, 46);
            label8.TabIndex = 21;
            label8.Text = "CONECTAR CON ARCHIVO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 92);
            label7.Name = "label7";
            label7.Size = new Size(259, 29);
            label7.TabIndex = 20;
            label7.Text = "RUTA DE DIRECCION";
            // 
            // pConexionAR
            // 
            pConexionAR.BackColor = Color.GreenYellow;
            pConexionAR.Controls.Add(lblConexionAR);
            pConexionAR.Location = new Point(27, 327);
            pConexionAR.Name = "pConexionAR";
            pConexionAR.Size = new Size(197, 41);
            pConexionAR.TabIndex = 19;
            // 
            // lblConexionAR
            // 
            lblConexionAR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblConexionAR.AutoSize = true;
            lblConexionAR.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold);
            lblConexionAR.Location = new Point(10, 3);
            lblConexionAR.Name = "lblConexionAR";
            lblConexionAR.Size = new Size(154, 29);
            lblConexionAR.TabIndex = 8;
            lblConexionAR.Text = "Sin Conexion";
            // 
            // btLimpiarAR
            // 
            btLimpiarAR.BackColor = Color.Orange;
            btLimpiarAR.Font = new Font("Stencil", 12F);
            btLimpiarAR.Image = Properties.Resources.limpiar;
            btLimpiarAR.ImageAlign = ContentAlignment.MiddleLeft;
            btLimpiarAR.Location = new Point(360, 327);
            btLimpiarAR.Name = "btLimpiarAR";
            btLimpiarAR.Size = new Size(159, 41);
            btLimpiarAR.TabIndex = 18;
            btLimpiarAR.Text = "LIMPIAR";
            btLimpiarAR.UseVisualStyleBackColor = false;
            btLimpiarAR.Click += btLimpiarAR_Click;
            // 
            // btProbarConAR
            // 
            btProbarConAR.BackColor = Color.Gold;
            btProbarConAR.Font = new Font("Stencil", 24F);
            btProbarConAR.Location = new Point(27, 385);
            btProbarConAR.Name = "btProbarConAR";
            btProbarConAR.Size = new Size(492, 60);
            btProbarConAR.TabIndex = 15;
            btProbarConAR.Text = "PROBAR CONEXION";
            btProbarConAR.UseVisualStyleBackColor = false;
            btProbarConAR.Click += btProbarConAR_Click;
            // 
            // btConectarAR
            // 
            btConectarAR.BackColor = Color.GreenYellow;
            btConectarAR.Font = new Font("Stencil", 24F);
            btConectarAR.Location = new Point(27, 464);
            btConectarAR.Name = "btConectarAR";
            btConectarAR.Size = new Size(233, 60);
            btConectarAR.TabIndex = 16;
            btConectarAR.Text = "CONECTAR";
            btConectarAR.UseVisualStyleBackColor = false;
            btConectarAR.Click += btConectarAR_Click;
            // 
            // btCancelarAR
            // 
            btCancelarAR.BackColor = Color.Crimson;
            btCancelarAR.Font = new Font("Stencil", 24F);
            btCancelarAR.Location = new Point(280, 464);
            btCancelarAR.Name = "btCancelarAR";
            btCancelarAR.Size = new Size(235, 60);
            btCancelarAR.TabIndex = 17;
            btCancelarAR.Text = "CANCELAR";
            btCancelarAR.UseVisualStyleBackColor = false;
            btCancelarAR.Click += btCancelarAR_Click;
            // 
            // ConexionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(560, 595);
            Controls.Add(tbConexion);
            MaximizeBox = false;
            Name = "ConexionForm";
            Text = "ConexionForm";
            pConexion.ResumeLayout(false);
            pConexion.PerformLayout();
            tbConexion.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            pConexionAR.ResumeLayout(false);
            pConexionAR.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtServidor;
        private TextBox txtBaseDeDatos;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btProbarCon;
        private Button btConectar;
        private Button btCancelar;
        private Label lblConexion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btLimpiar;
        private Panel pConexion;
        private Label label5;
        private Label label6;
        private TextBox txtPuerto;
        private TabControl tbConexion;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel pConexionAR;
        private Label lblConexionAR;
        private Button btLimpiarAR;
        private Button btProbarConAR;
        private Button btConectarAR;
        private Button btCancelarAR;
        private TextBox txtDireccion;
        private Label label8;
        private Label label7;
        private Button btExaminar;
        private CheckBox chbRecordar;
    }
}