using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Proyecto_Camiones
{
    partial class Registro
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvRegistros = new DataGridView();
            btNuevo = new Button();
            btGuardar = new Button();
            btFiltrar = new Button();
            btEliminar = new Button();
            exF = new Button();
            btLimpiar = new Button();
            dgvOperador = new DataGridView();
            dgvTransportes = new DataGridView();
            conexionBindingSource = new BindingSource(components);
            sqlCommand1 = new SqlCommand();
            txtSellos = new TextBox();
            txtBultos = new TextBox();
            txtFolio = new TextBox();
            txtPlacas = new TextBox();
            chkHoraS = new CheckBox();
            chkHoraE = new CheckBox();
            chkFechaE = new DateTimePicker();
            chkFechaS = new DateTimePicker();
            dtHoraFinS = new DateTimePicker();
            dtHoraFinE = new DateTimePicker();
            dtHoraInS = new DateTimePicker();
            dtHoraInE = new DateTimePicker();
            cbOp = new ComboBox();
            cbTrans = new ComboBox();
            cbDestino = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)dgvRegistros).BeginInit();
            ((ISupportInitialize)dgvOperador).BeginInit();
            ((ISupportInitialize)dgvTransportes).BeginInit();
            ((ISupportInitialize)conexionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.LightSteelBlue;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Controls.Add(dgvRegistros, 0, 1);
            tableLayoutPanel1.Controls.Add(btNuevo, 0, 0);
            tableLayoutPanel1.Controls.Add(btGuardar, 1, 0);
            tableLayoutPanel1.Controls.Add(btFiltrar, 5, 0);
            tableLayoutPanel1.Controls.Add(btEliminar, 0, 2);
            tableLayoutPanel1.Controls.Add(exF, 5, 2);
            tableLayoutPanel1.Controls.Add(btLimpiar, 2, 0);
            tableLayoutPanel1.Location = new Point(6, 260);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(1159, 423);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvRegistros
            // 
            dgvRegistros.AllowUserToAddRows = false;
            dgvRegistros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistros.BackgroundColor = Color.SteelBlue;
            dgvRegistros.ColumnHeadersHeight = 29;
            tableLayoutPanel1.SetColumnSpan(dgvRegistros, 6);
            dgvRegistros.Location = new Point(3, 63);
            dgvRegistros.MultiSelect = false;
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.RowHeadersVisible = false;
            dgvRegistros.RowHeadersWidth = 51;
            dgvRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegistros.Size = new Size(1153, 297);
            dgvRegistros.TabIndex = 1;
            dgvRegistros.SelectionChanged += dgvRegistros_SelectionChanged_1;
            // 
            // btNuevo
            // 
            btNuevo.BackColor = Color.LightGreen;
            btNuevo.Dock = DockStyle.Fill;
            btNuevo.Font = new Font("Stencil", 12F);
            btNuevo.Image = Properties.Resources.nuevo;
            btNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btNuevo.Location = new Point(3, 3);
            btNuevo.Name = "btNuevo";
            btNuevo.Size = new Size(144, 54);
            btNuevo.TabIndex = 2;
            btNuevo.Text = "Nuevo";
            btNuevo.UseVisualStyleBackColor = false;
            btNuevo.Click += btNuevo_Click;
            // 
            // btGuardar
            // 
            btGuardar.BackColor = Color.RoyalBlue;
            btGuardar.Dock = DockStyle.Fill;
            btGuardar.Font = new Font("Stencil", 12F);
            btGuardar.ForeColor = SystemColors.ButtonHighlight;
            btGuardar.Image = Properties.Resources.guardar;
            btGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btGuardar.Location = new Point(153, 3);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(144, 54);
            btGuardar.TabIndex = 3;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = false;
            btGuardar.Click += btGuardar_Click;
            // 
            // btFiltrar
            // 
            btFiltrar.BackColor = Color.DarkTurquoise;
            btFiltrar.Dock = DockStyle.Fill;
            btFiltrar.Font = new Font("Stencil", 12F);
            btFiltrar.Image = Properties.Resources.buscar;
            btFiltrar.ImageAlign = ContentAlignment.MiddleLeft;
            btFiltrar.Location = new Point(1012, 3);
            btFiltrar.Name = "btFiltrar";
            btFiltrar.Size = new Size(144, 54);
            btFiltrar.TabIndex = 5;
            btFiltrar.Text = "Filtrar";
            btFiltrar.UseVisualStyleBackColor = false;
            btFiltrar.Click += btFiltrar_Click;
            // 
            // btEliminar
            // 
            btEliminar.BackColor = Color.DarkRed;
            btEliminar.Dock = DockStyle.Fill;
            btEliminar.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btEliminar.Image = Properties.Resources.trash;
            btEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btEliminar.Location = new Point(3, 366);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(144, 54);
            btEliminar.TabIndex = 6;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = false;
            btEliminar.Click += btEliminar_Click;
            // 
            // exF
            // 
            exF.BackColor = Color.ForestGreen;
            exF.Dock = DockStyle.Fill;
            exF.Font = new Font("Stencil", 12F);
            exF.Image = Properties.Resources.Excel;
            exF.ImageAlign = ContentAlignment.MiddleLeft;
            exF.Location = new Point(1012, 366);
            exF.Name = "exF";
            exF.Size = new Size(144, 54);
            exF.TabIndex = 7;
            exF.Text = "EXCEL";
            exF.UseVisualStyleBackColor = false;
            exF.Click += btnExportar_Click;
            // 
            // btLimpiar
            // 
            btLimpiar.BackColor = Color.Orange;
            btLimpiar.Dock = DockStyle.Fill;
            btLimpiar.Font = new Font("Stencil", 12F);
            btLimpiar.Image = Properties.Resources.limpiar;
            btLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btLimpiar.Location = new Point(303, 3);
            btLimpiar.Name = "btLimpiar";
            btLimpiar.Size = new Size(144, 54);
            btLimpiar.TabIndex = 4;
            btLimpiar.Text = "Limpiar";
            btLimpiar.UseVisualStyleBackColor = false;
            btLimpiar.Click += btLimpiar_Click;
            // 
            // dgvOperador
            // 
            dgvOperador.ColumnHeadersHeight = 29;
            dgvOperador.Location = new Point(0, 0);
            dgvOperador.Name = "dgvOperador";
            dgvOperador.RowHeadersWidth = 51;
            dgvOperador.Size = new Size(240, 150);
            dgvOperador.TabIndex = 0;
            dgvOperador.Visible = false;
            // 
            // dgvTransportes
            // 
            dgvTransportes.ColumnHeadersHeight = 29;
            dgvTransportes.Location = new Point(0, 0);
            dgvTransportes.Name = "dgvTransportes";
            dgvTransportes.RowHeadersWidth = 51;
            dgvTransportes.Size = new Size(240, 150);
            dgvTransportes.TabIndex = 0;
            dgvTransportes.Visible = false;
            // 
            // conexionBindingSource
            // 
            conexionBindingSource.DataSource = typeof(SistemaEntradasSalidas.Datos.Conexion);
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // txtSellos
            // 
            txtSellos.Location = new Point(110, 130);
            txtSellos.MaxLength = 7;
            txtSellos.Name = "txtSellos";
            txtSellos.Size = new Size(434, 27);
            txtSellos.TabIndex = 1;
            // 
            // txtBultos
            // 
            txtBultos.Location = new Point(110, 198);
            txtBultos.Name = "txtBultos";
            txtBultos.Size = new Size(160, 27);
            txtBultos.TabIndex = 2;
            // 
            // txtFolio
            // 
            txtFolio.Location = new Point(110, 163);
            txtFolio.Name = "txtFolio";
            txtFolio.Size = new Size(434, 27);
            txtFolio.TabIndex = 3;
            txtFolio.KeyPress += txtFolio_KeyPress;
            // 
            // txtPlacas
            // 
            txtPlacas.CharacterCasing = CharacterCasing.Upper;
            txtPlacas.Location = new Point(110, 97);
            txtPlacas.Name = "txtPlacas";
            txtPlacas.Size = new Size(434, 27);
            txtPlacas.TabIndex = 4;
            txtPlacas.TextChanged += txtPlacas_TextChanged;
            txtPlacas.KeyDown += txtPlacas_KeyDown;
            txtPlacas.KeyPress += txtPlacas_KeyPress;
            txtPlacas.Validated += txtPlacas_Validated;
            // 
            // chkHoraS
            // 
            chkHoraS.AutoSize = true;
            chkHoraS.Location = new Point(751, 196);
            chkHoraS.Name = "chkHoraS";
            chkHoraS.Size = new Size(77, 24);
            chkHoraS.TabIndex = 5;
            chkHoraS.Text = "HASTA";
            chkHoraS.UseVisualStyleBackColor = true;
            chkHoraS.CheckedChanged += chkHoraS_CheckedChanged;
            // 
            // chkHoraE
            // 
            chkHoraE.AutoSize = true;
            chkHoraE.Location = new Point(751, 86);
            chkHoraE.Name = "chkHoraE";
            chkHoraE.Size = new Size(77, 24);
            chkHoraE.TabIndex = 6;
            chkHoraE.Text = "HASTA";
            chkHoraE.UseVisualStyleBackColor = true;
            chkHoraE.CheckedChanged += chkHoraE_CheckedChanged_1;
            // 
            // chkFechaE
            // 
            chkFechaE.Format = DateTimePickerFormat.Custom;
            chkFechaE.Location = new Point(619, 52);
            chkFechaE.Name = "chkFechaE";
            chkFechaE.Size = new Size(126, 27);
            chkFechaE.TabIndex = 9;
            // 
            // chkFechaS
            // 
            chkFechaS.Format = DateTimePickerFormat.Custom;
            chkFechaS.Location = new Point(619, 160);
            chkFechaS.Name = "chkFechaS";
            chkFechaS.Size = new Size(126, 27);
            chkFechaS.TabIndex = 12;
            chkFechaS.ValueChanged += dateTimePicker4_ValueChanged;
            // 
            // dtHoraFinS
            // 
            dtHoraFinS.Format = DateTimePickerFormat.Time;
            dtHoraFinS.Location = new Point(834, 192);
            dtHoraFinS.Name = "dtHoraFinS";
            dtHoraFinS.Size = new Size(126, 27);
            dtHoraFinS.TabIndex = 13;
            // 
            // dtHoraFinE
            // 
            dtHoraFinE.Format = DateTimePickerFormat.Time;
            dtHoraFinE.Location = new Point(834, 82);
            dtHoraFinE.Name = "dtHoraFinE";
            dtHoraFinE.Size = new Size(126, 27);
            dtHoraFinE.TabIndex = 14;
            dtHoraFinE.ValueChanged += dtHoraFinE_ValueChanged;
            // 
            // dtHoraInS
            // 
            dtHoraInS.Format = DateTimePickerFormat.Time;
            dtHoraInS.Location = new Point(619, 193);
            dtHoraInS.Name = "dtHoraInS";
            dtHoraInS.Size = new Size(126, 27);
            dtHoraInS.TabIndex = 16;
            // 
            // dtHoraInE
            // 
            dtHoraInE.Format = DateTimePickerFormat.Time;
            dtHoraInE.Location = new Point(619, 86);
            dtHoraInE.Name = "dtHoraInE";
            dtHoraInE.Size = new Size(126, 27);
            dtHoraInE.TabIndex = 17;
            // 
            // cbOp
            // 
            cbOp.FormattingEnabled = true;
            cbOp.Location = new Point(110, 22);
            cbOp.Name = "cbOp";
            cbOp.Size = new Size(434, 28);
            cbOp.TabIndex = 19;
            // 
            // cbTrans
            // 
            cbTrans.FormattingEnabled = true;
            cbTrans.Location = new Point(110, 56);
            cbTrans.Name = "cbTrans";
            cbTrans.Size = new Size(434, 28);
            cbTrans.TabIndex = 20;
            // 
            // cbDestino
            // 
            cbDestino.FormattingEnabled = true;
            cbDestino.Items.AddRange(new object[] { "TODOS", "ENTRADA", "SALIDA" });
            cbDestino.Location = new Point(352, 196);
            cbDestino.Name = "cbDestino";
            cbDestino.Size = new Size(192, 28);
            cbDestino.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 59);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 24;
            label1.Text = "TRANSPORTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 30);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 25;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 100);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 26;
            label3.Text = "PLACAS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 133);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 27;
            label4.Text = "SELLOS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 205);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 28;
            label5.Text = "BULTOS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 166);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 29;
            label6.Text = "FOLIO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(276, 201);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 30;
            label7.Text = "DESTINO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Stencil", 14F);
            label8.Location = new Point(559, 20);
            label8.Name = "label8";
            label8.Size = new Size(120, 29);
            label8.TabIndex = 31;
            label8.Text = "ENTRADA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Stencil", 14F);
            label9.Location = new Point(559, 128);
            label9.Name = "label9";
            label9.Size = new Size(95, 29);
            label9.TabIndex = 32;
            label9.Text = "SALIDA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(559, 57);
            label10.Name = "label10";
            label10.Size = new Size(54, 20);
            label10.TabIndex = 34;
            label10.Text = "FECHA";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(559, 90);
            label11.Name = "label11";
            label11.Size = new Size(50, 20);
            label11.TabIndex = 35;
            label11.Text = "HORA";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(559, 197);
            label12.Name = "label12";
            label12.Size = new Size(50, 20);
            label12.TabIndex = 36;
            label12.Text = "HORA";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(559, 165);
            label13.Name = "label13";
            label13.Size = new Size(54, 20);
            label13.TabIndex = 37;
            label13.Text = "FECHA";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1177, 703);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbDestino);
            Controls.Add(cbTrans);
            Controls.Add(cbOp);
            Controls.Add(dtHoraInE);
            Controls.Add(dtHoraInS);
            Controls.Add(dtHoraFinE);
            Controls.Add(dtHoraFinS);
            Controls.Add(chkFechaS);
            Controls.Add(chkFechaE);
            Controls.Add(chkHoraE);
            Controls.Add(chkHoraS);
            Controls.Add(txtPlacas);
            Controls.Add(txtFolio);
            Controls.Add(txtBultos);
            Controls.Add(txtSellos);
            Controls.Add(tableLayoutPanel1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Registro";
            Text = "Registro Entradas/Salidas";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((ISupportInitialize)dgvRegistros).EndInit();
            ((ISupportInitialize)dgvOperador).EndInit();
            ((ISupportInitialize)dgvTransportes).EndInit();
            ((ISupportInitialize)conexionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private BindingSource conexionBindingSource;
        private SqlCommand sqlCommand1;

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvRegistros;
        private DataGridView dgvOperador;
        private DataGridView dgvTransportes;

        private Button btNuevo;
        private Button btGuardar;
        private Button btEliminar;
        private Button btLimpiar;
        private Button btFiltrar;
        private Button exF;
        private TextBox txtSellos;
        private TextBox txtBultos;
        private TextBox txtFolio;
        private TextBox txtPlacas;
        private CheckBox chkHoraS;
        private CheckBox chkHoraE;
        private DateTimePicker chkFechaE;
        private DateTimePicker chkFechaS;
        private DateTimePicker dtHoraFinS;
        private DateTimePicker dtHoraFinE;
        private DateTimePicker dtHoraInS;
        private DateTimePicker dtHoraInE;
        private ComboBox cbOp;
        private ComboBox cbTrans;
        private ComboBox cbDestino;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}