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
    public partial class registrar_entradas : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=ERP");
        string hora_de_entrada = "";
        public registrar_entradas()
        {
            InitializeComponent();
            limpiarCampos();
            hora_de_entrada = "";
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
            btn_registrarEntrada.Enabled = false;
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
                    btn_registrarEntrada.Enabled = true;
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
                
                while (reader1.Read())
                {
                    hora_de_entrada = reader1.GetValue(0).ToString();
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

        private void Btn_registrarEntrada_Click(object sender, EventArgs e)
        {
            try
            {                
                if (consultarHoraEntrada() == "")
                {
                    //REGISTRAR ENTRADA
                    DateTime hoy = DateTime.Now;
                    string formatoTimeEntrada = hoy.ToString("hh:mm tt");
                    string formatoDate = hoy.ToString("yyyy-MM-dd");
                    DateTime fecha2 = Convert.ToDateTime(formatoTimeEntrada);
                    TimeSpan auxFormatoTimeEntrada = fecha2.TimeOfDay;

                    conn.Open();
                    OdbcCommand codigo1 = new OdbcCommand();
                    codigo1.Connection = conn;
                    codigo1.CommandText = ("INSERT INTO `registro_empleados`(`codigo_empleado`, `fecha_registro`, `hora_entrada`) " +
                        "VALUES ('" + txt_codEmpleado.Text + "','" + formatoDate + "','" + auxFormatoTimeEntrada + "')");
                    try
                    {
                        codigo1.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Se registro correctamente! \n " +
                            "Fecha: " + hoy.ToString("dd-MM-yy") + " \n " +
                            "Hora: " + auxFormatoTimeEntrada + "", "Entrada",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txt_codEmpleado.Focus();
                        limpiarCampos();
                    }
                    catch (OdbcException ex)
                    {
                        limpiarCampos();
                        MessageBox.Show(" Error al regisrar la entrada. \n\n Error: " + ex.ToString());
                        conn.Close();
                    }
                }
                else
                {
                    limpiarCampos();
                    MessageBox.Show("No puede registrar más de 1 entrada al día.",
                        "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception)
            {
                limpiarCampos();
                MessageBox.Show("Error al consultar la entrada del empleado ",
                        "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }            
        }


        private void Button1_Click(object sender, EventArgs e)
        {
                        
        }
    }
}
