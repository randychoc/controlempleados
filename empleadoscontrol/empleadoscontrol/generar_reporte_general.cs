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
    public partial class generar_reporte_general : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=ERP");
        DateTime hoy = DateTime.Now;
        //Variables para la verificación de fechas        
        int horas_ley = 0;
        string aux_horas_ley = "";
        string auxfechaDe = "";
        string auxfechaA = "";

        public generar_reporte_general()
        {
            InitializeComponent();
            Dtp_fechaDe.Value = hoy;
            Dtp_fechaA.Value = hoy;
            btn_generarExcel.Enabled = false;
            Dtp_fechaA.Enabled = false;
            horas_ley = 192;
            aux_horas_ley = horas_ley.ToString() + ":00";
        }

        private void Generar_reportes_Load(object sender, EventArgs e)
        {

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
                            "\nCierre el archivo e inténtelo de nuevo. " , "Guardado", 
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
        void llenarDataGrid(string fechaInicio, string fechaFin)
        {
            /*/ MessageBox.Show("fechaInicio: " + fechaInicio + "\n\n fechaFin: " + fechaFin); /*/
            //llenado de DataGrid Renta Detalle
            OdbcCommand cod = new OdbcCommand();
            cod.Connection = conn;
            cod.CommandText = ("SELECT CE.`codigo_empleado` AS Cod_Empleado, E.`nombre_completo` AS Nombre_Completo, E.`departamento` AS Departamento, TIME_FORMAT(SEC_TO_TIME(SUM(TIME_TO_SEC(CE.`total_de_horas`))), '%H:%i') AS Total_Horas, if ((TIME_FORMAT(SEC_TO_TIME(SUM(TIME_TO_SEC(CE.`total_de_horas`))), '%H:%i')) " +
                "> " + horas_ley +", CONCAT('Horas Extras', ' ', TIMEDIFF((TIME_FORMAT(SEC_TO_TIME(SUM(TIME_TO_SEC(CE.`total_de_horas`))), '%H:%i'))," +
                " '" + aux_horas_ley + "')), if ((TIME_FORMAT(SEC_TO_TIME(SUM(TIME_TO_SEC(CE.`total_de_horas`))), '%H:%i')) " +
                "< " + horas_ley + ", CONCAT('Falta', ' ', TIMEDIFF('" + aux_horas_ley + "', (TIME_FORMAT(SEC_TO_TIME(SUM(TIME_TO_SEC(CE.`total_de_horas`))), '%H:%i'))), ' '), 'Horas Exactas')) AS Falta_HorasExtra FROM `registro_empleados` CE, `empleados` E " + 
                "WHERE CE.`fecha_registro` between '" + fechaInicio +"' and '" + fechaFin + "' " +
                "AND CE.`codigo_empleado` = E.`codigo_empleado` AND E.`estado`= 1 AND CE.`estado`= 1 GROUP BY CE.`codigo_empleado`");
            try
            {
                OdbcDataAdapter eje = new OdbcDataAdapter();
                eje.SelectCommand = cod;
                DataTable datos = new DataTable();
                eje.Fill(datos);
                Dgv_vistaPreliminar.DataSource = datos;
                eje.Update(datos);
                Dgv_vistaPreliminar.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Dgv_vistaPreliminar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                Dgv_vistaPreliminar.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Dgv_vistaPreliminar.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Dgv_vistaPreliminar.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
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
                    llenarDataGrid(auxfechaDe, auxfechaA);                    
                    if (Dgv_vistaPreliminar.Rows.Count >= 1)
                    {
                        btn_generarExcel.Enabled = true;
                    }
                    else {
                        MessageBox.Show("No existen datos entre las fechas seleccionadas.","Consulta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        btn_generarExcel.Enabled = false;
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
    }
}
