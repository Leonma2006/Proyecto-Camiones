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
            button2 = new Button();
            txtMarca = new TextBox();
            button5 = new Button();
            button6 = new Button();
            label9 = new Label();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            dgvTransportes = new DataGridView();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransportes).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.Controls.Add(label8, 0, 1);
            tableLayoutPanel2.Controls.Add(txtTransporte, 1, 1);
            tableLayoutPanel2.Controls.Add(button2, 0, 4);
            tableLayoutPanel2.Controls.Add(txtMarca, 1, 0);
            tableLayoutPanel2.Controls.Add(button5, 1, 4);
            tableLayoutPanel2.Controls.Add(button6, 0, 2);
            tableLayoutPanel2.Controls.Add(label9, 0, 0);
            tableLayoutPanel2.Controls.Add(button3, 2, 4);
            tableLayoutPanel2.Controls.Add(button4, 3, 4);
            tableLayoutPanel2.Controls.Add(button1, 5, 4);
            tableLayoutPanel2.Controls.Add(dgvTransportes, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(800, 450);
            tableLayoutPanel2.TabIndex = 39;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(3, 40);
            label8.Name = "label8";
            label8.Size = new Size(114, 40);
            label8.TabIndex = 37;
            label8.Text = "TRANSPORTE";
            // 
            // txtTransporte
            // 
            txtTransporte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.SetColumnSpan(txtTransporte, 3);
            txtTransporte.Location = new Point(123, 43);
            txtTransporte.Name = "txtTransporte";
            txtTransporte.Size = new Size(354, 27);
            txtTransporte.TabIndex = 36;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(3, 403);
            button2.Name = "button2";
            button2.Size = new Size(114, 44);
            button2.TabIndex = 30;
            button2.Text = "Nuevo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtMarca
            // 
            txtMarca.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.SetColumnSpan(txtMarca, 3);
            txtMarca.Location = new Point(123, 3);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(354, 27);
            txtMarca.TabIndex = 34;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.Location = new Point(123, 403);
            button5.Name = "button5";
            button5.Size = new Size(114, 44);
            button5.TabIndex = 27;
            button5.Text = "Filtrar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button6.Location = new Point(3, 83);
            button6.Name = "button6";
            button6.Size = new Size(114, 34);
            button6.TabIndex = 26;
            button6.Text = "Limpiar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(114, 40);
            label9.TabIndex = 35;
            label9.Text = "MARCA";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(243, 403);
            button3.Name = "button3";
            button3.Size = new Size(114, 44);
            button3.TabIndex = 29;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.Location = new Point(363, 403);
            button4.Name = "button4";
            button4.Size = new Size(114, 44);
            button4.TabIndex = 28;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.ImageAlign = ContentAlignment.BottomRight;
            button1.Location = new Point(683, 403);
            button1.Name = "button1";
            button1.Size = new Size(114, 44);
            button1.TabIndex = 24;
            button1.Text = "EXCEL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvTransportes
            // 
            dgvTransportes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTransportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTransportes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTransportes.ColumnHeadersHeight = 29;
            tableLayoutPanel2.SetColumnSpan(dgvTransportes, 6);
            dgvTransportes.Location = new Point(3, 123);
            dgvTransportes.Name = "dgvTransportes";
            dgvTransportes.RowHeadersWidth = 51;
            dgvTransportes.Size = new Size(794, 274);
            dgvTransportes.TabIndex = 25;
            // 
            // Transporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel2);
            Name = "Transporte";
            Text = "Transporte";
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