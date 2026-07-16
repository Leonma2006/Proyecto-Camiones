namespace Proyecto_Camiones
{
    partial class Transporte
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
            tableLayoutPanel2 = new TableLayoutPanel();
            label8 = new Label();
            txtTransporte = new TextBox();
            txtMarca = new TextBox();
            label9 = new Label();
            button1 = new Button();
            dgvTransportes = new DataGridView();
            button6 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button4 = new Button();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransportes).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.LightSteelBlue;
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.Controls.Add(label8, 0, 1);
            tableLayoutPanel2.Controls.Add(txtTransporte, 1, 1);
            tableLayoutPanel2.Controls.Add(txtMarca, 1, 0);
            tableLayoutPanel2.Controls.Add(label9, 0, 0);
            tableLayoutPanel2.Controls.Add(button1, 5, 4);
            tableLayoutPanel2.Controls.Add(dgvTransportes, 0, 3);
            tableLayoutPanel2.Controls.Add(button6, 2, 2);
            tableLayoutPanel2.Controls.Add(button2, 0, 2);
            tableLayoutPanel2.Controls.Add(button3, 1, 2);
            tableLayoutPanel2.Controls.Add(button5, 5, 2);
            tableLayoutPanel2.Controls.Add(button4, 0, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.Size = new Size(1015, 561);
            tableLayoutPanel2.TabIndex = 39;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(3, 40);
            label8.Name = "label8";
            label8.Size = new Size(144, 40);
            label8.TabIndex = 37;
            label8.Text = "TRANSPORTE";
            // 
            // txtTransporte
            // 
            txtTransporte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.SetColumnSpan(txtTransporte, 3);
            txtTransporte.Location = new Point(153, 43);
            txtTransporte.Name = "txtTransporte";
            txtTransporte.Size = new Size(444, 27);
            txtTransporte.TabIndex = 36;
            // 
            // txtMarca
            // 
            txtMarca.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.SetColumnSpan(txtMarca, 3);
            txtMarca.Location = new Point(153, 3);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(444, 27);
            txtMarca.TabIndex = 34;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(144, 40);
            label9.TabIndex = 35;
            label9.Text = "MARCA";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Stencil", 12F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = Properties.Resources.Excel;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(868, 504);
            button1.Name = "button1";
            button1.Size = new Size(144, 54);
            button1.TabIndex = 24;
            button1.Text = "EXCEL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvTransportes
            // 
            dgvTransportes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTransportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTransportes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTransportes.BackgroundColor = Color.SteelBlue;
            dgvTransportes.ColumnHeadersHeight = 29;
            tableLayoutPanel2.SetColumnSpan(dgvTransportes, 6);
            dgvTransportes.Location = new Point(3, 143);
            dgvTransportes.Name = "dgvTransportes";
            dgvTransportes.RowHeadersWidth = 51;
            dgvTransportes.Size = new Size(1009, 355);
            dgvTransportes.TabIndex = 25;
            dgvTransportes.SelectionChanged += dgvTransportes_SelectionChanged_1;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button6.BackColor = Color.Orange;
            button6.Font = new Font("Stencil", 12F);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Image = Properties.Resources.limpiar;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(303, 83);
            button6.Name = "button6";
            button6.Size = new Size(144, 54);
            button6.TabIndex = 26;
            button6.Text = "Limpiar";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.LightGreen;
            button2.Font = new Font("Stencil", 12F);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = Properties.Resources.nuevo;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 83);
            button2.Name = "button2";
            button2.Size = new Size(144, 54);
            button2.TabIndex = 30;
            button2.Text = "Nuevo";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.RoyalBlue;
            button3.Font = new Font("Stencil", 12F);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = Properties.Resources.guardar;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(153, 83);
            button3.Name = "button3";
            button3.Size = new Size(144, 54);
            button3.TabIndex = 29;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.BackColor = Color.DarkTurquoise;
            button5.Font = new Font("Stencil", 12F);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Image = Properties.Resources.buscar;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(868, 83);
            button5.Name = "button5";
            button5.Size = new Size(144, 54);
            button5.TabIndex = 27;
            button5.Text = "Filtrar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.DarkRed;
            button4.Font = new Font("Stencil", 12F);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = Properties.Resources.trash;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 504);
            button4.Name = "button4";
            button4.Size = new Size(144, 54);
            button4.TabIndex = 28;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // Transporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 561);
            Controls.Add(tableLayoutPanel2);
            Name = "Transporte";
            Text = "Transporte";
            Load += Transporte_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label8;
        private TextBox txtTransporte;
        private Button button2;
        private TextBox txtMarca;
        private Button button5;
        private Button button6;
        private Label label9;
        private Button button3;
        private Button button4;
        private Button button1;
        private DataGridView dgvTransportes;
    }
}