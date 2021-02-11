namespace CapaVistaFRM
{
    partial class mdi_control
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem_inicio = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_mantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_procesos = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEntradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarSalidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_reporte = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteIndividualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_usuario = new System.Windows.Forms.Label();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_inicio,
            this.menuItem_mantenimientos,
            this.menuItem_procesos,
            this.menuItem_reporte});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItem_inicio
            // 
            this.menuItem_inicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem});
            this.menuItem_inicio.Name = "menuItem_inicio";
            this.menuItem_inicio.Size = new System.Drawing.Size(61, 24);
            this.menuItem_inicio.Text = "Inicio";
            this.menuItem_inicio.Click += new System.EventHandler(this.MenuItem_inicio_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.CerrarSesiónToolStripMenuItem_Click);
            // 
            // menuItem_mantenimientos
            // 
            this.menuItem_mantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem});
            this.menuItem_mantenimientos.Name = "menuItem_mantenimientos";
            this.menuItem_mantenimientos.Size = new System.Drawing.Size(138, 24);
            this.menuItem_mantenimientos.Text = "Mantenimientos";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.EmpleadosToolStripMenuItem_Click);
            // 
            // menuItem_procesos
            // 
            this.menuItem_procesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEntradasToolStripMenuItem,
            this.registrarSalidasToolStripMenuItem});
            this.menuItem_procesos.Name = "menuItem_procesos";
            this.menuItem_procesos.Size = new System.Drawing.Size(87, 24);
            this.menuItem_procesos.Text = "Procesos";
            // 
            // registrarEntradasToolStripMenuItem
            // 
            this.registrarEntradasToolStripMenuItem.Name = "registrarEntradasToolStripMenuItem";
            this.registrarEntradasToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.registrarEntradasToolStripMenuItem.Text = "Registrar Entradas";
            this.registrarEntradasToolStripMenuItem.Click += new System.EventHandler(this.RegistrarEntradasToolStripMenuItem_Click);
            // 
            // registrarSalidasToolStripMenuItem
            // 
            this.registrarSalidasToolStripMenuItem.Name = "registrarSalidasToolStripMenuItem";
            this.registrarSalidasToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.registrarSalidasToolStripMenuItem.Text = "Registrar Salidas";
            this.registrarSalidasToolStripMenuItem.Click += new System.EventHandler(this.RegistrarSalidasToolStripMenuItem_Click);
            // 
            // menuItem_reporte
            // 
            this.menuItem_reporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteGeneralToolStripMenuItem,
            this.reporteIndividualToolStripMenuItem});
            this.menuItem_reporte.Name = "menuItem_reporte";
            this.menuItem_reporte.Size = new System.Drawing.Size(80, 24);
            this.menuItem_reporte.Text = "Reporte";
            this.menuItem_reporte.Click += new System.EventHandler(this.ReporteToolStripMenuItem_Click);
            // 
            // reporteGeneralToolStripMenuItem
            // 
            this.reporteGeneralToolStripMenuItem.Name = "reporteGeneralToolStripMenuItem";
            this.reporteGeneralToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.reporteGeneralToolStripMenuItem.Text = "Reporte General";
            this.reporteGeneralToolStripMenuItem.Click += new System.EventHandler(this.ReporteGeneralToolStripMenuItem_Click);
            // 
            // reporteIndividualToolStripMenuItem
            // 
            this.reporteIndividualToolStripMenuItem.Name = "reporteIndividualToolStripMenuItem";
            this.reporteIndividualToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.reporteIndividualToolStripMenuItem.Text = "Reporte Individual";
            this.reporteIndividualToolStripMenuItem.Click += new System.EventHandler(this.ReporteIndividualToolStripMenuItem_Click);
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.AutoSize = true;
            this.Lbl_usuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_usuario.Location = new System.Drawing.Point(0, 429);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(66, 21);
            this.Lbl_usuario.TabIndex = 2;
            this.Lbl_usuario.Text = "Usuario";
            this.Lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del Sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.SalirDelSistemaToolStripMenuItem_Click);
            // 
            // mdi_control
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_usuario);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mdi_control";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Entradas/Salidas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mdi_control_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mdi_control_FormClosed);
            this.Load += new System.EventHandler(this.MDI_FRM_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_inicio;
        private System.Windows.Forms.ToolStripMenuItem menuItem_mantenimientos;
        private System.Windows.Forms.ToolStripMenuItem menuItem_procesos;
        private System.Windows.Forms.Label Lbl_usuario;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEntradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarSalidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem_reporte;
        private System.Windows.Forms.ToolStripMenuItem reporteGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteIndividualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
    }
}