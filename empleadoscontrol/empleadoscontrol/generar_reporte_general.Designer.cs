namespace empleadoscontrol
{
    partial class generar_reporte_general
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.Dtp_fechaDe = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Dtp_fechaA = new System.Windows.Forms.DateTimePicker();
            this.Dgv_vistaPreliminar = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_generarExcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_vistaPreliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generar Reporte General";
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(649, 83);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(212, 43);
            this.btn_consultar.TabIndex = 3;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // Dtp_fechaDe
            // 
            this.Dtp_fechaDe.CustomFormat = "dd-MM-yy";
            this.Dtp_fechaDe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fechaDe.Location = new System.Drawing.Point(197, 89);
            this.Dtp_fechaDe.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.Dtp_fechaDe.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.Dtp_fechaDe.Name = "Dtp_fechaDe";
            this.Dtp_fechaDe.Size = new System.Drawing.Size(187, 26);
            this.Dtp_fechaDe.TabIndex = 1;
            this.Dtp_fechaDe.Value = new System.DateTime(2020, 6, 4, 0, 0, 0, 0);
            this.Dtp_fechaDe.ValueChanged += new System.EventHandler(this.Dtp_fechaDe_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "De:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(404, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "A:";
            // 
            // Dtp_fechaA
            // 
            this.Dtp_fechaA.CustomFormat = "dd-MM-yy";
            this.Dtp_fechaA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fechaA.Location = new System.Drawing.Point(433, 89);
            this.Dtp_fechaA.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.Dtp_fechaA.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.Dtp_fechaA.Name = "Dtp_fechaA";
            this.Dtp_fechaA.Size = new System.Drawing.Size(187, 26);
            this.Dtp_fechaA.TabIndex = 2;
            this.Dtp_fechaA.Value = new System.DateTime(2020, 6, 4, 0, 0, 0, 0);
            // 
            // Dgv_vistaPreliminar
            // 
            this.Dgv_vistaPreliminar.AllowUserToAddRows = false;
            this.Dgv_vistaPreliminar.AllowUserToDeleteRows = false;
            this.Dgv_vistaPreliminar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_vistaPreliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_vistaPreliminar.Location = new System.Drawing.Point(31, 169);
            this.Dgv_vistaPreliminar.Name = "Dgv_vistaPreliminar";
            this.Dgv_vistaPreliminar.ReadOnly = true;
            this.Dgv_vistaPreliminar.RowHeadersWidth = 51;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Dgv_vistaPreliminar.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_vistaPreliminar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_vistaPreliminar.Size = new System.Drawing.Size(917, 287);
            this.Dgv_vistaPreliminar.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vista Preliminar:";
            // 
            // btn_generarExcel
            // 
            this.btn_generarExcel.Location = new System.Drawing.Point(352, 473);
            this.btn_generarExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_generarExcel.Name = "btn_generarExcel";
            this.btn_generarExcel.Size = new System.Drawing.Size(288, 43);
            this.btn_generarExcel.TabIndex = 4;
            this.btn_generarExcel.Text = "Generar Excel";
            this.btn_generarExcel.UseVisualStyleBackColor = true;
            this.btn_generarExcel.Click += new System.EventHandler(this.Btn_generarExcel_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Reporte";
            this.saveFileDialog1.Filter = "Archivos XLSX(*.xlsx)|*.xlsx";
            this.saveFileDialog1.Title = "Reporte";
            // 
            // generar_reporte_general
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 542);
            this.Controls.Add(this.btn_generarExcel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Dgv_vistaPreliminar);
            this.Controls.Add(this.Dtp_fechaA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dtp_fechaDe);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "generar_reporte_general";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Reporte General";
            this.Load += new System.EventHandler(this.Generar_reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_vistaPreliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.DateTimePicker Dtp_fechaDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Dtp_fechaA;
        private System.Windows.Forms.DataGridView Dgv_vistaPreliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_generarExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}