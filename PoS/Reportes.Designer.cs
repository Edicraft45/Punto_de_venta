
namespace PoS
{
    partial class Reportes
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
            this.components = new System.ComponentModel.Container();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.bienvenida = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoVendidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoVendidoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorConVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorConVentasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbVD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.hora_fecha = new System.Windows.Forms.Label();
            this.nombreTienda = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReportes
            // 
            this.dgvReportes.AllowUserToAddRows = false;
            this.dgvReportes.AllowUserToDeleteRows = false;
            this.dgvReportes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.GridColor = System.Drawing.SystemColors.Control;
            this.dgvReportes.Location = new System.Drawing.Point(87, 171);
            this.dgvReportes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvReportes.MultiSelect = false;
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.ReadOnly = true;
            this.dgvReportes.RowHeadersWidth = 51;
            this.dgvReportes.RowTemplate.Height = 25;
            this.dgvReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportes.Size = new System.Drawing.Size(591, 397);
            this.dgvReportes.TabIndex = 6;
            // 
            // bienvenida
            // 
            this.bienvenida.AutoSize = true;
            this.bienvenida.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bienvenida.ForeColor = System.Drawing.Color.Blue;
            this.bienvenida.Location = new System.Drawing.Point(66, 99);
            this.bienvenida.Name = "bienvenida";
            this.bienvenida.Size = new System.Drawing.Size(647, 40);
            this.bienvenida.TabIndex = 4;
            this.bienvenida.Text = "Bienvenido al sistema de reportes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúPrincipalToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1318, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúPrincipalToolStripMenuItem
            // 
            this.menúPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.menúPrincipalToolStripMenuItem.Name = "menúPrincipalToolStripMenuItem";
            this.menúPrincipalToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.menúPrincipalToolStripMenuItem.Text = "Menú Principal";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoVendidoToolStripMenuItem,
            this.productoVendidoToolStripMenuItem1,
            this.vendedorConVentasToolStripMenuItem,
            this.vendedorConVentasToolStripMenuItem1});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // productoVendidoToolStripMenuItem
            // 
            this.productoVendidoToolStripMenuItem.Name = "productoVendidoToolStripMenuItem";
            this.productoVendidoToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.productoVendidoToolStripMenuItem.Text = "Producto + vendido";
            this.productoVendidoToolStripMenuItem.Click += new System.EventHandler(this.productoVendidoToolStripMenuItem_Click);
            // 
            // productoVendidoToolStripMenuItem1
            // 
            this.productoVendidoToolStripMenuItem1.Name = "productoVendidoToolStripMenuItem1";
            this.productoVendidoToolStripMenuItem1.Size = new System.Drawing.Size(244, 26);
            this.productoVendidoToolStripMenuItem1.Text = "Producto - vendido";
            this.productoVendidoToolStripMenuItem1.Click += new System.EventHandler(this.productoVendidoToolStripMenuItem1_Click);
            // 
            // vendedorConVentasToolStripMenuItem
            // 
            this.vendedorConVentasToolStripMenuItem.Name = "vendedorConVentasToolStripMenuItem";
            this.vendedorConVentasToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.vendedorConVentasToolStripMenuItem.Text = "Vendedor con + ventas";
            this.vendedorConVentasToolStripMenuItem.Click += new System.EventHandler(this.vendedorConVentasToolStripMenuItem_Click);
            // 
            // vendedorConVentasToolStripMenuItem1
            // 
            this.vendedorConVentasToolStripMenuItem1.Name = "vendedorConVentasToolStripMenuItem1";
            this.vendedorConVentasToolStripMenuItem1.Size = new System.Drawing.Size(244, 26);
            this.vendedorConVentasToolStripMenuItem1.Text = "Vendedor con - ventas";
            this.vendedorConVentasToolStripMenuItem1.Click += new System.EventHandler(this.vendedorConVentasToolStripMenuItem1_Click);
            // 
            // cbVD
            // 
            this.cbVD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVD.FormattingEnabled = true;
            this.cbVD.Location = new System.Drawing.Point(358, 0);
            this.cbVD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbVD.Name = "cbVD";
            this.cbVD.Size = new System.Drawing.Size(180, 28);
            this.cbVD.TabIndex = 7;
            this.cbVD.SelectionChangeCommitted += new System.EventHandler(this.cbVD_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ventas por dia";
            // 
            // logo
            // 
            this.logo.Image = global::PoS.Properties.Resources.supermercado;
            this.logo.Location = new System.Drawing.Point(742, 110);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(523, 519);
            this.logo.TabIndex = 11;
            this.logo.TabStop = false;
            // 
            // hora_fecha
            // 
            this.hora_fecha.AutoSize = true;
            this.hora_fecha.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.hora_fecha.ForeColor = System.Drawing.Color.Blue;
            this.hora_fecha.Location = new System.Drawing.Point(913, 71);
            this.hora_fecha.Name = "hora_fecha";
            this.hora_fecha.Size = new System.Drawing.Size(181, 35);
            this.hora_fecha.TabIndex = 10;
            this.hora_fecha.Text = "Hora y Fecha";
            // 
            // nombreTienda
            // 
            this.nombreTienda.AutoSize = true;
            this.nombreTienda.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.nombreTienda.ForeColor = System.Drawing.Color.Blue;
            this.nombreTienda.Location = new System.Drawing.Point(831, 19);
            this.nombreTienda.Name = "nombreTienda";
            this.nombreTienda.Size = new System.Drawing.Size(377, 52);
            this.nombreTienda.TabIndex = 9;
            this.nombreTienda.Text = "Nombre del Super";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1318, 657);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.hora_fecha);
            this.Controls.Add(this.nombreTienda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVD);
            this.Controls.Add(this.dgvReportes);
            this.Controls.Add(this.bienvenida);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reportes_FormClosing);
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.Label bienvenida;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoVendidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoVendidoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendedorConVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorConVentasToolStripMenuItem1;
        private System.Windows.Forms.ComboBox cbVD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label hora_fecha;
        private System.Windows.Forms.Label nombreTienda;
        private System.Windows.Forms.Timer timer1;
    }
}