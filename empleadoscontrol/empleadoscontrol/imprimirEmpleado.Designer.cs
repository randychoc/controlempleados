namespace empleadoscontrol
{
    partial class imprimirEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(imprimirEmpleado));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.pnl_marbete = new System.Windows.Forms.Panel();
            this.lb_depto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_puesto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_barras = new System.Windows.Forms.Panel();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_marbete.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(23, 226);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(167, 31);
            this.btn_imprimir.TabIndex = 2;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(222, 226);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(167, 31);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // pnl_marbete
            // 
            this.pnl_marbete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_marbete.Controls.Add(this.lb_depto);
            this.pnl_marbete.Controls.Add(this.label6);
            this.pnl_marbete.Controls.Add(this.lb_puesto);
            this.pnl_marbete.Controls.Add(this.label4);
            this.pnl_marbete.Controls.Add(this.pnl_barras);
            this.pnl_marbete.Controls.Add(this.lb_nombre);
            this.pnl_marbete.Controls.Add(this.label1);
            this.pnl_marbete.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.pnl_marbete.Location = new System.Drawing.Point(12, 12);
            this.pnl_marbete.Name = "pnl_marbete";
            this.pnl_marbete.Size = new System.Drawing.Size(400, 195);
            this.pnl_marbete.TabIndex = 5;
            // 
            // lb_depto
            // 
            this.lb_depto.AutoSize = true;
            this.lb_depto.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lb_depto.Location = new System.Drawing.Point(79, 54);
            this.lb_depto.Name = "lb_depto";
            this.lb_depto.Size = new System.Drawing.Size(148, 19);
            this.lb_depto.TabIndex = 10;
            this.lb_depto.Text = "NOMBRE COMPLETO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(21, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Depto.:";
            // 
            // lb_puesto
            // 
            this.lb_puesto.AutoSize = true;
            this.lb_puesto.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lb_puesto.Location = new System.Drawing.Point(79, 33);
            this.lb_puesto.Name = "lb_puesto";
            this.lb_puesto.Size = new System.Drawing.Size(148, 19);
            this.lb_puesto.TabIndex = 8;
            this.lb_puesto.Text = "NOMBRE COMPLETO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(23, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Puesto:";
            // 
            // pnl_barras
            // 
            this.pnl_barras.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.pnl_barras.Location = new System.Drawing.Point(109, 86);
            this.pnl_barras.Name = "pnl_barras";
            this.pnl_barras.Size = new System.Drawing.Size(180, 90);
            this.pnl_barras.TabIndex = 6;
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lb_nombre.Location = new System.Drawing.Point(79, 12);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(148, 19);
            this.lb_nombre.TabIndex = 5;
            this.lb_nombre.Text = "NOMBRE COMPLETO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // imprimirEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 269);
            this.Controls.Add(this.pnl_marbete);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_imprimir);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "imprimirEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir Empleado";
            this.pnl_marbete.ResumeLayout(false);
            this.pnl_marbete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Panel pnl_marbete;
        private System.Windows.Forms.Label lb_depto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_puesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_barras;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label label1;
    }
}