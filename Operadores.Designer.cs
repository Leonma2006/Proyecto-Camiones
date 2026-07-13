namespace Proyecto_Camiones
{
    partial class Operadores
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
            tableLayoutPanel3 = new TableLayoutPanel();
            dgvOperador = new DataGridView();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button11 = new Button();
            label12 = new Label();
            button12 = new Button();
            label13 = new Label();
            txtNombre = new TextBox();
            cbTrans3 = new ComboBox();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOperador).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.Controls.Add(dgvOperador, 0, 3);
            tableLayoutPanel3.Controls.Add(button10, 3, 4);
            tableLayoutPanel3.Controls.Add(button9, 2, 4);
            tableLayoutPanel3.Controls.Add(button8, 0, 4);
            tableLayoutPanel3.Controls.Add(button7, 5, 4);
            tableLayoutPanel3.Controls.Add(button11, 1, 4);
            tableLayoutPanel3.Controls.Add(label12, 0, 1);
            tableLayoutPanel3.Controls.Add(button12, 0, 2);
            tableLayoutPanel3.Controls.Add(label13, 0, 0);
            tableLayoutPanel3.Controls.Add(txtNombre, 1, 1);
            tableLayoutPanel3.Controls.Add(cbTrans3, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.Size = new Size(800, 450);
            tableLayoutPanel3.TabIndex = 50;
            // 
            // dgvOperador
            // 
            dgvOperador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvOperador.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOperador.ColumnHeadersHeight = 29;
            tableLayoutPanel3.SetColumnSpan(dgvOperador, 6);
            dgvOperador.Location = new Point(3, 123);
            dgvOperador.Name = "dgvOperador";
            dgvOperador.RowHeadersWidth = 51;
            dgvOperador.Size = new Size(794, 274);
            dgvOperador.TabIndex = 39;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button10.Location = new Point(363, 403);
            button10.Name = "button10";
            button10.Size = new Size(114, 44);
            button10.TabIndex = 42;
            button10.Text = "Eliminar";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button9.Location = new Point(243, 403);
            button9.Name = "button9";
            button9.Size = new Size(114, 44);
            button9.TabIndex = 43;
            button9.Text = "Guardar";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click_1;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button8.Location = new Point(3, 403);
            button8.Name = "button8";
            button8.Size = new Size(114, 44);
            button8.TabIndex = 44;
            button8.Text = "Nuevo";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button7.AutoSize = true;
            button7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button7.ImageAlign = ContentAlignment.BottomRight;
            button7.Location = new Point(683, 403);
            button7.Name = "button7";
            button7.Size = new Size(114, 44);
            button7.TabIndex = 38;
            button7.Text = "EXCEL";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button11.Location = new Point(123, 403);
            button11.Name = "button11";
            button11.Size = new Size(114, 44);
            button11.TabIndex = 41;
            button11.Text = "Filtrar";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 40);
            label12.Name = "label12";
            label12.Size = new Size(70, 20);
            label12.TabIndex = 48;
            label12.Text = "NOMBRE";
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button12.Location = new Point(3, 83);
            button12.Name = "button12";
            button12.Size = new Size(114, 34);
            button12.TabIndex = 40;
            button12.Text = "Limpiar";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 0);
            label13.Name = "label13";
            label13.Size = new Size(98, 40);
            label13.TabIndex = 46;
            label13.Text = "ID TRANSPORTE";
            // 
            // txtNombre
            // 
            tableLayoutPanel3.SetColumnSpan(txtNombre, 3);
            txtNombre.Location = new Point(123, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(354, 27);
            txtNombre.TabIndex = 47;
            // 
            // cbTrans3
            // 
            tableLayoutPanel3.SetColumnSpan(cbTrans3, 3);
            cbTrans3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrans3.FormattingEnabled = true;
            cbTrans3.Location = new Point(123, 3);
            cbTrans3.Name = "cbTrans3";
            cbTrans3.Size = new Size(151, 28);
            cbTrans3.TabIndex = 45;
            // 
            // Operadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel3);
            Name = "Operadores";
            Text = "Operadores";
            Load += Operadores_Load;
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOperador).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dgvOperador;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button11;
        private Label label12;
        private Button button12;
        private Label label13;
        private TextBox txtNombre;
        private ComboBox cbTrans3;
    }
}