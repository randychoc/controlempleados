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

namespace empleadoscontrol
{
    public partial class registrar_salidas : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=ERP");
        string hora_de_entrada = "";
        string hora_de_salida = "";
        public registrar_salidas()
        {
            InitializeComponent();
            limpiarCampos();            
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        void limpiarCampos()
        {
            txt_codEmpleado.Text = "";
            txt_nombre.Text = "";
            txt_puesto.Text = "";
            txt_departamento.Text = "";
            btn_registrarSalida.Enabled = false;
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
                    txt_codEmpleado.Focus();
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    OdbcDataReader reader2 = cod.ExecuteReader();
                    btn_registrarSalida.Enabled = true;
                    while (reader2.Read())
                    {
                        txt_nombre.Text = reader2.GetValue(0).ToString();
                        txt_puesto.Text = reader2.GetValue(1).ToString();
                        txt_departamento.Text = reader2.GetValue(2).ToString();
                    }                    
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al consultar empleado." + e.ToString());
                conn.Close();
            }

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_codEmpleado.Text == "")
                {
                    MessageBox.Show("Debe ingresar un código de usuario");
                }
                else
                {
                    consultar();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar empleado" + ex.ToString());
            }
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        string consultarHoraEntrada()
        {
            hora_de_entrada = "";
            DateTime hoy = DateTime.Now;
            string formatoDate = hoy.ToString("yyyy-MM-dd");
            //llenado de DataGrid Renta Detalle
            OdbcCommand cod = new OdbcCommand();
            cod.Connection = conn;
            cod.CommandText = ("SELECT `hora_entrada` FROM `registro_empleados` " +
                "WHERE `codigo_empleado`= '" + txt_codEmpleado.Text + "' " +
                "AND `fecha_registro`= '" + formatoDate + "' " +
                "AND `estado`= 1");
            try
            {
                conn.Open();
                OdbcDataReader reader1 = cod.ExecuteReader();
                if (reader1.Read() == false)
                {                    
                    MessageBox.Show("Hora de entrada no encontrada. ", "Consulta",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                    
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    OdbcDataReader reader2 = cod.ExecuteReader();                    
                    while (reader2.Read())
                    {
                        hora_de_entrada = reader2.GetValue(0).ToString();                       
                    }                    
                }
                conn.Close();
            }
            catch (Exception e)
            {                
                MessageBox.Show("Error al consultar la hora de entrada." + e.ToString());
                conn.Close();
            }
            return hora_de_entrada;
        }

        string consultarHoraSalida()
        {
            hora_de_salida = "";
            DateTime hoy = DateTime.Now;
            string formatoDate = hoy.ToString("yyyy-MM-dd");
            //llenado de DataGrid Renta Detalle
            OdbcCommand cod = new OdbcCommand();
            cod.Connection = conn;
            cod.CommandText = ("SELECT `hora_salida` FROM `registro_empleados` " +
                "WHERE `codigo_empleado`= '" + txt_codEmpleado.Text + "' " +
                "AND `fecha_registro`= '" + formatoDate + "' " +
                "AND `estado`= 1");
            try
            {
                conn.Open();                                
                OdbcDataReader reader2 = cod.ExecuteReader();
                while (reader2.Read())
                {
                    hora_de_salida = reader2.GetValue(0).ToString();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al consultar la hora de salida." + e.ToString());
                conn.Close();
            }
            return hora_de_salida;
        }

        private void Btn_registrarEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                if (consultarHoraSalida() == "")
                {
                    if (consultarHoraEntrada() == "")
                    {
                        limpiarCampos();
                        MessageBox.Show("No puede registrar una salida si el empleado no ha ingresado. ",
                            "Salida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        //REGISTRAR SALIDA                                           
                        string totaldehoras = "";
                        DateTime hoy = DateTime.Now;
                        string formatoDate = hoy.ToString("yyyy-MM-dd");
                        string formatoTimeSalida = hoy.ToString("hh:mm tt");

                        //INICIO HORAS EFECTIVAS
                        DateTime fecha1 = Convert.ToDateTime(consultarHoraEntrada());
                        DateTime fecha2 = Convert.ToDateTime(formatoTimeSalida);

                        TimeSpan auxFormatoTimeSalida = fecha2.TimeOfDay;

                        double horas = fecha2.Subtract(fecha1).TotalHours;

                        string data = horas.ToString();
                        string[] words = data.Split('.');

                        if (data.Length > 2)
                        {
                            string concWord = "0." + words[1];
                            double auxWord = Convert.ToDouble(concWord);

                            int minuto = Convert.ToInt32(auxWord * 60);
                            totaldehoras = words[0] + ":" + minuto + ":00";
                            /* MessageBox.Show(" formatoTime: " + formatoTimeSalida +
                                " \n auxFormatoTimeSalida: " + auxFormatoTimeSalida +
                                " \n totaldehoras IF: " + totaldehoras); */
                        }
                        else
                        {
                            totaldehoras = horas + ":00:00";
                            /* MessageBox.Show("formatoTime: " + formatoTimeSalida +
                                " \n auxFormatoTimeSalida: " + auxFormatoTimeSalida +
                                " \n totaldehoras ELSE: " + totaldehoras); */
                        }
                        //FIN HORAS EFECTIVAS


                        conn.Open();
                        OdbcCommand codigo1 = new OdbcCommand();
                        codigo1.Connection = conn;
                        codigo1.CommandText = ("UPDATE `registro_empleados` SET " +
                            "`hora_salida`='" + auxFormatoTimeSalida + "'," +
                            "`total_de_horas`='" + totaldehoras + "' " +
                            "WHERE `codigo_empleado`= '" + txt_codEmpleado.Text + "' " +
                            "AND `fecha_registro`= '" + formatoDate + "' AND `estado`=1");
                        try
                        {
                            codigo1.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Se registro correctamente! \n " +
                                "Fecha: " + hoy.ToString("dd-MM-yy") + " \n " +
                                "Hora: " + auxFormatoTimeSalida + "", "Salida",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            txt_codEmpleado.Focus();
                            limpiarCampos();
                        }
                        catch (OdbcException ex)
                        {
                            limpiarCampos();
                            MessageBox.Show(" Error al registrar la salida. \n\n Error: " + ex.ToString());
                            conn.Close();
                        }
                    }
                }
                else
                {
                    limpiarCampos();
                    MessageBox.Show("El empleado ya tiene una salida registrada. ",
                            "Salida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al consultar la entrada del empleado. " +
                    "\n\n Error: " + ex.ToString(), "Salida", 
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                conn.Close();
            }                                 
        }

        private void Button1_Click(object sender, EventArgs e)
        {
                        
        }
    }
}
