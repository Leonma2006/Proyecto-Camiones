namespace Proyecto_Camiones
{
    partial class MenuPrincipal
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            mAESTROToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            mAESTROToolStripMenuItem1 = new ToolStripMenuItem();
            mAESTROSToolStripMenuItem = new ToolStripMenuItem();
            tRANSPORTEToolStripMenuItem = new ToolStripMenuItem();
            mAESTROSToolStripMenuItem1 = new ToolStripMenuItem();
            tRANSPORTEToolStripMenuItem1 = new ToolStripMenuItem();
            oPERADORToolStripMenuItem = new ToolStripMenuItem();
            panelPrincipal = new Panel();
            contextMenuStrip2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { mAESTROToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(146, 28);
            // 
            // mAESTROToolStripMenuItem
            // 
            mAESTROToolStripMenuItem.Name = "mAESTROToolStripMenuItem";
            mAESTROToolStripMenuItem.Size = new Size(145, 24);
            mAESTROToolStripMenuItem.Text = "MAESTRO";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mAESTROToolStripMenuItem1, mAESTROSToolStripMenuItem, mAESTROSToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(934, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // mAESTROToolStripMenuItem1
            // 
            mAESTROToolStripMenuItem1.Name = "mAESTROToolStripMenuItem1";
            mAESTROToolStripMenuItem1.Size = new Size(97, 24);
            mAESTROToolStripMenuItem1.Text = "CONEXION";
            mAESTROToolStripMenuItem1.Click += mAESTROToolStripMenuItem1_Click;
            // 
            // mAESTROSToolStripMenuItem
            // 
            mAESTROSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tRANSPORTEToolStripMenuItem });
            mAESTROSToolStripMenuItem.Name = "mAESTROSToolStripMenuItem";
            mAESTROSToolStripMenuItem.Size = new Size(98, 24);
            mAESTROSToolStripMenuItem.Text = "REGISTROS";
            // 
            // tRANSPORTEToolStripMenuItem
            // 
            tRANSPORTEToolStripMenuItem.Name = "tRANSPORTEToolStripMenuItem";
            tRANSPORTEToolStripMenuItem.Size = new Size(166, 26);
            tRANSPORTEToolStripMenuItem.Text = "CAMIONES";
            tRANSPORTEToolStripMenuItem.Click += tRANSPORTEToolStripMenuItem_Click;
            // 
            // mAESTROSToolStripMenuItem1
            // 
            mAESTROSToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { tRANSPORTEToolStripMenuItem1, oPERADORToolStripMenuItem });
            mAESTROSToolStripMenuItem1.Name = "mAESTROSToolStripMenuItem1";
            mAESTROSToolStripMenuItem1.Size = new Size(98, 24);
            mAESTROSToolStripMenuItem1.Text = "MAESTROS";
            // 
            // tRANSPORTEToolStripMenuItem1
            // 
            tRANSPORTEToolStripMenuItem1.Name = "tRANSPORTEToolStripMenuItem1";
            tRANSPORTEToolStripMenuItem1.Size = new Size(181, 26);
            tRANSPORTEToolStripMenuItem1.Text = "TRANSPORTE";
            tRANSPORTEToolStripMenuItem1.Click += tRANSPORTEToolStripMenuItem1_Click;
            // 
            // oPERADORToolStripMenuItem
            // 
            oPERADORToolStripMenuItem.Name = "oPERADORToolStripMenuItem";
            oPERADORToolStripMenuItem.Size = new Size(181, 26);
            oPERADORToolStripMenuItem.Text = "OPERADOR";
            oPERADORToolStripMenuItem.Click += oPERADORToolStripMenuItem_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.AutoSize = true;
            panelPrincipal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 28);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(934, 422);
            panelPrincipal.TabIndex = 3;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 450);
            Controls.Add(panelPrincipal);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            WindowState = FormWindowState.Maximized;
            contextMenuStrip2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem mAESTROToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mAESTROToolStripMenuItem1;
        private ToolStripMenuItem mAESTROSToolStripMenuItem;
        private ToolStripMenuItem tRANSPORTEToolStripMenuItem;
        private Panel panelPrincipal;
        private ToolStripMenuItem mAESTROSToolStripMenuItem1;
        private ToolStripMenuItem tRANSPORTEToolStripMenuItem1;
        private ToolStripMenuItem oPERADORToolStripMenuItem;
    }
}