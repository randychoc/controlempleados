using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using SpreadsheetLight;
using System.Diagnostics;

namespace empleadoscontrol
{
    public partial class generar_reporte_individual : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=ERP");
        DateTime hoy = DateTime.Now;
        //Variables para la verificación de fechas        
        int horas_ley = 0;
        string aux_horas_ley = "";
        string auxfechaDe = "";
        string auxfechaA = "";

        public generar_reporte_individual()
        {
            InitializeComponent();
            Dtp_fechaDe.Value = hoy;
            Dtp_fechaA.Value = hoy;
            btn_generarExcel.Enabled = false;
            Dtp_fechaA.Enabled = false;
            horas_ley = 192;
            aux_horas_ley = horas_ley.ToString() + ":00";
            txt_codEmpleado.Focus();
        }

        private void Generar_reportes_Load(object sender, EventArgs e)
        {

        }
        
        void limpiarCampos()
        {
            txt_codEmpleado.Text = "";
            txt_nombre.Text = "";
            txt_puesto.Text = "";
            txt_departamento.Text = "";            
            txt_codEmpleado.Focus();
        }
        void consultar()
        {
            //llenado de DataGrid Renta Detalle
            OdbcCommand cod = new OdbcCommand();
            cod.Connection = conn;
            cod.CommandText = ("SELECT `nombre_completo`, `puesto`, `departamento` FROM `empleados` " +
                "WHERE `estado`=1 AND `codigo_empleado`='" + txt_codEmpleado.Text + "'");
            try
            {
                conn.Open();
                OdbcDataReader reader1 = cod.ExecuteReader();
                if (reader1.Read() == false)
                {
                    limpiarCampos();
                    MessageBox.Show("Empleado no encontrado. ", "Consulta",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    btn_buscar.Text = "Buscar";
                    txt_codEmpleado.Enabled = true;
                    txt_codEmpleado.Focus();
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    OdbcDataReader reader2 = cod.ExecuteReader();                    
                    while (reader2.Read())
                    {
                        txt_nombre.Text = reader2.GetValue(0).ToString();
                        txt_puesto.Text = reader2.GetValue(1).ToString();
                        txt_departamento.Text = reader2.GetValue(2).ToString();
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {                
                MessageBox.Show("Error al consultar empleado. \nError: " + ex.ToString(), "Consulta",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btn_buscar.Text = "Buscar";
                txt_codEmpleado.Enabled = true;
                txt_codEmpleado.Focus();
                conn.Close();
            }

        }

        void generarexcel(DataGridView dt)
        {
            Process proceso = new Process();
            SLDocument sl = new SLDocument();
            SLStyle sls = new SLStyle();

            sls.Font.FontSize = 10;
            sls.Font.Bold = true;

            if (dt.Rows.Count > 0)
            {
                string ruta = "";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //ruta y codigo para guardar
                    ruta = saveFileDialog1.FileName;

                    try
                    {
                        int ic = 1;
                        foreach (DataGridViewColumn column in dt.Columns)
                        {

                            sl.SetCellValue(1, ic, column.HeaderText.ToString());
                            sl.SetCellStyle(1, ic, sls);
                            sl.SetColumnWidth(ic, 25);
                            ic++;
                        }

                        int ir = 2;
                        foreach (DataGridViewRow row in dt.Rows)
                        {

                            sl.SetCellValue(ir, 1, row.Cells[0].Value.ToString());
                            sl.SetCellValue(ir, 2, row.Cells[1].Value.ToString());
                            sl.SetCellValue(ir, 3, row.Cells[2].Value.ToString());
                            sl.SetCellValue(ir, 4, row.Cells[3].Value.ToString());
                            sl.SetCellValue(ir, 5, row.Cells[4].Value.ToString());
                            ir++;
                        }
                        sl.AutoFitColumn(1, 10);
                        sl.AutoFitRow(1, 100000);
                        sl.SaveAs(ruta);
                        MessageBox.Show("Guardado Correctamente!", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saveFileDialog1.FileName = "Reporte";

                        proceso.StartInfo.FileName = ruta;
                        proceso.Start();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("La acción no se puede completar porque el Excel tiene abierto el archivo. " +
                            "\nCierre el archivo e inténtelo de nuevo. ", "Guardado", 
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saveFileDialog1.FileName = "Reporte";
                    }
                }
            }
            else
            {
                MessageBox.Show("No existen datos para poder generar el reporte.", "Reporte", 
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        void llenarDataGrid(string codEmpleado, string fechaInicio, string fechaFin)
        {
            /*/ MessageBox.Show("fechaInicio: " + fechaInicio + "\n\n fechaFin: " + fechaFin); /*/
            //llenado de DataGrid Renta Detalle
            OdbcCommand cod = new OdbcCommand();
            cod.Connection = conn;
            cod.CommandText = ("SELECT `codigo_empleado` AS Cod_Empleado, `fecha_registro` AS Fecha, `hora_entrada` AS Entrada, `hora_salida` AS Salida, `total_de_horas` AS Total_De_Horas " +
                "FROM `registro_empleados` WHERE `codigo_empleado`= '" + codEmpleado + "' " +
                "AND `fecha_registro` between '" + fechaInicio + "' " +
                "and '" + fechaFin + "' AND `estado`= 1");
            try
            {
                OdbcDataAdapter eje = new OdbcDataAdapter();
                eje.SelectCommand = cod;
                DataTable datos = new DataTable();
                eje.Fill(datos);
                Dgv_vistaPreliminar.DataSource = datos;
                eje.Update(datos);                
                Dgv_vistaPreliminar.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                Dgv_vistaPreliminar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                Dgv_vistaPreliminar.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                Dgv_vistaPreliminar.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                Dgv_vistaPreliminar.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar los datos. \n\n Error: " + ex.ToString(), 
                    "Mostrar Datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                conn.Close();
            }
        }
        
        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_codEmpleado.Text == "" || txt_nombre.Text == "" || 
                    txt_puesto.Text == "" || txt_departamento.Text == "")
                {
                    MessageBox.Show("Primero debe consultar los datos de un empleado. ", "Consultar",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }                                
                else
                {
                    if (Dtp_fechaA.Enabled == false)
                    {
                        btn_generarExcel.Enabled = false;
                        MessageBox.Show("Debe seleccionar una rango de fechas. ", "Fechas",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        auxfechaDe = Dtp_fechaDe.Value.ToString("yyyy-MM-dd");
                        auxfechaA = Dtp_fechaA.Value.ToString("yyyy-MM-dd");
                        /*/
                        MessageBox.Show("auxfechaDe: " + auxfechaDe + "\n auxfechaA: " + auxfechaA); 
                        /*/
                        llenarDataGrid(txt_codEmpleado.Text, auxfechaDe, auxfechaA);                        
                        if (Dgv_vistaPreliminar.Rows.Count >= 1)
                        {
                            btn_generarExcel.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("No existen datos entre las fechas seleccionadas.", "Consultar",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            btn_generarExcel.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fecha no válida. \n\n Error:" + ex.ToString(), "Consultar",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }                        
        }

        private void Dtp_fechaDe_ValueChanged(object sender, EventArgs e)
        {
            Dtp_fechaA.MinDate = Dtp_fechaDe.Value;
            Dtp_fechaA.Enabled = true;
        }

        private void Btn_generarExcel_Click(object sender, EventArgs e)
        {
            generarexcel(Dgv_vistaPreliminar);            
        }

        private void Txt_departamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_codEmpleado.Text == "")
                {                    
                    MessageBox.Show("Debe ingresar un código de usuario. ", "Buscar",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txt_codEmpleado.Focus();
                }
                else
                {
                    if (txt_codEmpleado.Enabled == true)
                    {
                        txt_codEmpleado.Enabled = false;
                        btn_buscar.Text = "Buscar Nuevo";
                        consultar();                        
                    }
                    else
                    {
                        limpiarCampos();
                        Dgv_vistaPreliminar.Columns.Clear();
                        txt_codEmpleado.Enabled = true;
                        btn_buscar.Text = "Buscar";
                        txt_codEmpleado.Focus();
                    }
                }
            }
            catch (Exception ex)
            {                
                MessageBox.Show("Error al consultar empleado. \n\n Error:" + ex.ToString(), "Buscar",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btn_buscar.Text = "Buscar";
                txt_codEmpleado.Enabled = true;
                txt_codEmpleado.Focus();
            }
        }

        private void Txt_codEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTextbox.soloNumeros(e);
        }
    }
}
