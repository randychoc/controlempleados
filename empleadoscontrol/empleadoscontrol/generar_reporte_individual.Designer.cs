namespace empleadoscontrol
{
    partial class generar_reporte_individual
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
            this.txt_codEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_departamento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_puesto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_vistaPreliminar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generar Reporte Individual";
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(636, 247);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(173, 43);
            this.btn_consultar.TabIndex = 8;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // Dtp_fechaDe
            // 
            this.Dtp_fechaDe.CustomFormat = "dd-MM-yy";
            this.Dtp_fechaDe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fechaDe.Location = new System.Drawing.Point(184, 253);
            this.Dtp_fechaDe.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.Dtp_fechaDe.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.Dtp_fechaDe.Name = "Dtp_fechaDe";
            this.Dtp_fechaDe.Size = new System.Drawing.Size(187, 26);
            this.Dtp_fechaDe.TabIndex = 6;
            this.Dtp_fechaDe.Value = new System.DateTime(2020, 6, 4, 0, 0, 0, 0);
            this.Dtp_fechaDe.ValueChanged += new System.EventHandler(this.Dtp_fechaDe_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "De:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(391, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "A:";
            // 
            // Dtp_fechaA
            // 
            this.Dtp_fechaA.CustomFormat = "dd-MM-yy";
            this.Dtp_fechaA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fechaA.Location = new System.Drawing.Point(420, 253);
            this.Dtp_fechaA.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.Dtp_fechaA.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.Dtp_fechaA.Name = "Dtp_fechaA";
            this.Dtp_fechaA.Size = new System.Drawing.Size(187, 26);
            this.Dtp_fechaA.TabIndex = 7;
            this.Dtp_fechaA.Value = new System.DateTime(2020, 6, 4, 0, 0, 0, 0);
            // 
            // Dgv_vistaPreliminar
            // 
            this.Dgv_vistaPreliminar.AllowUserToAddRows = false;
            this.Dgv_vistaPreliminar.AllowUserToDeleteRows = false;
            this.Dgv_vistaPreliminar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_vistaPreliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_vistaPreliminar.Location = new System.Drawing.Point(31, 330);
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
            this.label7.Location = new System.Drawing.Point(28, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vista Preliminar:";
            // 
            // btn_generarExcel
            // 
            this.btn_generarExcel.Location = new System.Drawing.Point(353, 629);
            this.btn_generarExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_generarExcel.Name = "btn_generarExcel";
            this.btn_generarExcel.Size = new System.Drawing.Size(288, 43);
            this.btn_generarExcel.TabIndex = 9;
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
            // txt_codEmpleado
            // 
            this.txt_codEmpleado.Location = new System.Drawing.Point(460, 81);
            this.txt_codEmpleado.Name = "txt_codEmpleado";
            this.txt_codEmpleado.Size = new System.Drawing.Size(202, 26);
            this.txt_codEmpleado.TabIndex = 1;
            this.txt_codEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_codEmpleado_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ingrese código del empleado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_departamento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_puesto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(62, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 105);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Empleado";
            // 
            // txt_departamento
            // 
            this.txt_departamento.Enabled = false;
            this.txt_departamento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_departamento.Location = new System.Drawing.Point(570, 59);
            this.txt_departamento.Name = "txt_departamento";
            this.txt_departamento.Size = new System.Drawing.Size(245, 26);
            this.txt_departamento.TabIndex = 5;
            this.txt_departamento.TextChanged += new System.EventHandler(this.Txt_departamento_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(566, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Departamento:";
            // 
            // txt_puesto
            // 
            this.txt_puesto.Enabled = false;
            this.txt_puesto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_puesto.Location = new System.Drawing.Point(300, 60);
            this.txt_puesto.Name = "txt_puesto";
            this.txt_puesto.Size = new System.Drawing.Size(245, 26);
            this.txt_puesto.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Puesto: ";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(32, 60);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(245, 26);
            this.txt_nombre.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nombre: ";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(674, 74);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(172, 37);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // generar_reporte_individual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 688);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_codEmpleado);
            this.Controls.Add(this.label3);
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
            this.Name = "generar_reporte_individual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Reporte Individual";
            this.Load += new System.EventHandler(this.Generar_reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_vistaPreliminar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_codEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_departamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_puesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_buscar;
    }
}