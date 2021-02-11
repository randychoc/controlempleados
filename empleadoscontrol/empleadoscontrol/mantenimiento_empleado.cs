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
    public partial class mantenimiento_empleado : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=ERP");        
        public mantenimiento_empleado()
        {
            InitializeComponent();
            configInicio();
            llenarDataGrid();
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
            txt_codEmpleado.Focus();
        }
        void bloquearBotones(bool estadoBtn)
        {
            btn_buscar.Enabled = estadoBtn;
            btn_guardar.Enabled = estadoBtn;
            btn_nuevo.Enabled = estadoBtn;
            btn_modificar.Enabled = estadoBtn;
            btn_eliminar.Enabled = estadoBtn;
            btn_cancelar.Enabled = estadoBtn;
            btn_editar.Enabled = estadoBtn;
            btn_imprimir.Enabled = estadoBtn;
        }

        void bloquearCampos(bool estadoCam)
        {
            txt_codEmpleado.Enabled = estadoCam;
            txt_nombre.Enabled = estadoCam;
            txt_puesto.Enabled = estadoCam;
            txt_departamento.Enabled = estadoCam;            
        }

        void configInicio()
        {
            bloquearBotones(false);
            btn_nuevo.Enabled = true;
            btn_editar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_imprimir.Enabled = true;
            limpiarCampos();
            bloquearCampos(false);
        }

        void consultarEmpleado()
        {
            //CONSULTAR EMPLEADO POR CODIGO_EMPLEADO
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
                    bloquearCampos(false);
                    txt_codEmpleado.Enabled = true;
                    txt_codEmpleado.Focus();
                    btn_buscar.Text = "Buscar";
                    MessageBox.Show("Empleado no encontrado. ", "Buscar",
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
                        txt_nombre.Text = reader2.GetValue(0).ToString();
                        txt_puesto.Text = reader2.GetValue(1).ToString();
                        txt_departamento.Text = reader2.GetValue(2).ToString();                        
                    }                    
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar el empleado. \nError: " + ex.ToString(), "Buscar",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                conn.Close();
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            //BOTON BUSCAR
            if (btn_modificar.Enabled == true && txt_codEmpleado.Enabled == true)
            {
                bloquearBotones(false);
                btn_buscar.Enabled = true;
                btn_modificar.Enabled = true;
                btn_cancelar.Enabled = true;
                try
                {
                    if (txt_codEmpleado.Text == "")
                    {
                        MessageBox.Show("Debe ingresar un código de usuario", "Buscar",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        bloquearCampos(true);
                        btn_buscar.Text = "Buscar Nuevo";
                        txt_codEmpleado.Enabled = false;                        
                        consultarEmpleado();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo consultar el empleado. \nError: " + ex.ToString(), "Buscar",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else if (btn_eliminar.Enabled == true && txt_codEmpleado.Enabled == true)
            {
                bloquearBotones(false);
                btn_buscar.Enabled = true;
                btn_eliminar.Enabled = true;
                btn_cancelar.Enabled = true;
                try
                {
                    if (txt_codEmpleado.Text == "")
                    {
                        MessageBox.Show("Debe ingresar un código de usuario.", "Buscar",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        bloquearCampos(false);
                        btn_buscar.Text = "Buscar Nuevo";
                        txt_codEmpleado.Enabled = false;
                        consultarEmpleado();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo consultar el empleado. \nError: " + ex.ToString(), "Buscar",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else if (btn_imprimir.Enabled == true && txt_codEmpleado.Enabled == true)
            {
                bloquearBotones(false);
                btn_buscar.Enabled = true;                
                btn_cancelar.Enabled = true;
                btn_imprimir.Enabled = true;
                try
                {
                    if (txt_codEmpleado.Text == "")
                    {
                        MessageBox.Show("Debe ingresar un código de usuario", "Imprimir",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        bloquearCampos(false);
                        btn_buscar.Text = "Buscar Nuevo";
                        txt_codEmpleado.Enabled = false;
                        consultarEmpleado();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo consultar el empleado. \nError: " + ex.ToString(), "Imprimir",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else if (btn_modificar.Enabled == true && txt_codEmpleado.Enabled == false)
            {
                btn_buscar.Text = "Buscar";
                bloquearBotones(false);
                btn_buscar.Enabled = true;
                btn_modificar.Enabled = true;
                btn_cancelar.Enabled = true;
                bloquearCampos(false);
                txt_codEmpleado.Enabled = true;
                txt_codEmpleado.Focus();
                limpiarCampos();                
            }
            else if (btn_eliminar.Enabled == true && txt_codEmpleado.Enabled == false)
            {
                btn_buscar.Text = "Buscar";
                bloquearBotones(false);
                btn_buscar.Enabled = true;
                btn_eliminar.Enabled = true;
                btn_cancelar.Enabled = true;
                bloquearCampos(false);
                txt_codEmpleado.Enabled = true;
                txt_codEmpleado.Focus();
                limpiarCampos();                
            }
            else if (btn_imprimir.Enabled == true && txt_codEmpleado.Enabled == false)
            {
                btn_buscar.Text = "Buscar";
                bloquearBotones(false);
                btn_buscar.Enabled = true;                
                btn_cancelar.Enabled = true;
                btn_imprimir.Enabled = true;
                bloquearCampos(false);
                txt_codEmpleado.Enabled = true;
                txt_codEmpleado.Focus();
                limpiarCampos();
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }                

        void consultarSigID()
        {            
            OdbcCommand cod = new OdbcCommand();
            cod.Connection = conn;
            cod.CommandText = ("SELECT MAX(`codigo_empleado`) FROM `empleados`");
            try
            {
                conn.Open();
                OdbcDataReader reader2 = cod.ExecuteReader();
                while (reader2.Read())
                {
                     txt_codEmpleado.Text = reader2.GetValue(0).ToString();
                }                
                conn.Close();
                int sigID = Convert.ToInt32(txt_codEmpleado.Text) + 1;
                txt_codEmpleado.Text = sigID.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al consultar la hora de salida. \n Error: " + e.ToString());
                conn.Close();
            }            
        }        

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            //BOTON NUEVO
            bloquearBotones(false);
            btn_cancelar.Enabled = true;
            btn_guardar.Enabled = true;
            bloquearCampos(true);
            txt_codEmpleado.Enabled = false;
            txt_nombre.Focus();
            consultarSigID();            
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            //BOTON CANCELAR
            configInicio();
            btn_buscar.Text = "Buscar";
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            //BOTON EDITAR
            bloquearBotones(false);
            btn_buscar.Enabled = true;
            btn_modificar.Enabled = true;
            btn_cancelar.Enabled = true;
            bloquearCampos(false);
            txt_codEmpleado.Enabled = true;
            txt_codEmpleado.Focus();            
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            //BOTON GUARDAR
            if (txt_nombre.Text == "" || txt_puesto.Text == "" || txt_departamento.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos.", "Guardar",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {                
                try
                {
                    conn.Open();
                    OdbcCommand codigo1 = new OdbcCommand();
                    codigo1.Connection = conn;
                    codigo1.CommandText = ("INSERT INTO `empleados`(`nombre_completo`, `puesto`, `departamento`) " +
                        "VALUES ('" + txt_nombre.Text + "','" + txt_puesto.Text + "','" + txt_departamento.Text + "')");
                    try
                    {
                        codigo1.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Se registro correctamente! \n\n " +
                            "Nombre: " + txt_nombre.Text + " \n CODIGO: " + txt_codEmpleado.Text , "Guardar",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        configInicio();
                        llenarDataGrid();
                    }
                    catch (OdbcException ex)
                    {
                        limpiarCampos();
                        MessageBox.Show(" Error al ingresar nuevo empleado. " +
                            "\n\n Error: " + ex.ToString(), "Guardar",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Error al ingresar nuevo empleado. " +
                        "\n\n Error: " + ex.ToString(), "Guardar",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    conn.Close();
                }                                 
            }            
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            //BOTON ELIMINAR
            if (btn_eliminar.Enabled == true)
            {
                bloquearBotones(false);
                btn_buscar.Enabled = true;
                btn_eliminar.Enabled = true;
                btn_cancelar.Enabled = true;
                bloquearCampos(false);
                txt_codEmpleado.Enabled = true;                
                txt_codEmpleado.Focus();

                if (txt_codEmpleado.Text == "")
                {
                    MessageBox.Show("Debe ingresar un código de empleado.", "Eliminar",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (txt_nombre.Text == "" || txt_puesto.Text == "" || txt_departamento.Text == "")
                    {
                        MessageBox.Show("Debe consultar primero un empleado para poder eliminarlo!", "Eliminar",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                        
                    }
                    else
                    {
                        try
                        {
                            conn.Open();
                            OdbcCommand codigo1 = new OdbcCommand();
                            codigo1.Connection = conn;
                            codigo1.CommandText = ("UPDATE `empleados` SET `estado`=0 " +
                                "WHERE `codigo_empleado`=" + txt_codEmpleado.Text);
                            try
                            {
                                codigo1.ExecuteNonQuery();
                                conn.Close();
                                btn_buscar.Text = "Buscar";
                                MessageBox.Show("Empleado eliminado correctamente!", "Eliminar",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                                
                                configInicio();
                                llenarDataGrid();
                            }
                            catch (OdbcException ex)
                            {
                                limpiarCampos();
                                MessageBox.Show(" Error al eliminar empleado. " +
                                    "\n\n Error: " + ex.ToString(), "Eliminar",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                conn.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(" Error al eliminar empleado. " +
                                "\n\n Error: " + ex.ToString(), "Eliminar",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            conn.Close();
                        }                        
                    }                    
                }
            }
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            //BOTON MODIFICAR
            if (txt_nombre.Text == "" || txt_puesto.Text == "" || txt_departamento.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos.", "Modificar",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    conn.Open();
                    OdbcCommand codigo1 = new OdbcCommand();
                    codigo1.Connection = conn;
                    codigo1.CommandText = ("UPDATE `empleados` SET `nombre_completo`='" + txt_nombre.Text + 
                        "',`puesto`='" + txt_puesto.Text + "',`departamento`='" + txt_departamento.Text + 
                        "' WHERE `codigo_empleado`= '" + txt_codEmpleado.Text + "'");
                    try
                    {
                        codigo1.ExecuteNonQuery();
                        conn.Close();
                        btn_buscar.Text = "Buscar";
                        MessageBox.Show("Empleado modificado correctamente!", "Modificar",
                               MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                        
                        configInicio();
                        llenarDataGrid();
                    }
                    catch (OdbcException ex)
                    {
                        limpiarCampos();
                        MessageBox.Show(" Error al modificar los datos del empleado. " +
                            "\n\n Error: " + ex.ToString(), "Modificar",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Error al modificar los datos del empleado. " +
                        "\n\n Error: " + ex.ToString(), "Modificar",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    conn.Close();
                }               
            }
        }        

        private void Txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTextbox.soloLetras(e);
        }

        private void Txt_puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTextbox.soloLetras(e);
        }

        private void Txt_departamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTextbox.soloLetras(e);
        }

        private void Txt_codEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTextbox.soloNumeros(e); 
        }
        void llenarDataGrid()
        {
            /*/ MessageBox.Show("fechaInicio: " + fechaInicio + "\n\n fechaFin: " + fechaFin); /*/
            //llenado de DataGrid Renta Detalle
            OdbcCommand cod = new OdbcCommand();
            cod.Connection = conn;
            cod.CommandText = ("SELECT `codigo_empleado` AS Codigo, `nombre_completo` AS Nombre_Completo, " +
                "`puesto` AS Puesto, `departamento` AS Departamento FROM `empleados` WHERE `estado`=1");
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
                Dgv_vistaPreliminar.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                Dgv_vistaPreliminar.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar los datos. \n\n Error: " + ex.ToString(),
                    "Mostrar Datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                conn.Close();
            }
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            if (btn_imprimir.Enabled == true)
            {
                bloquearBotones(false);
                btn_buscar.Enabled = true;                
                btn_cancelar.Enabled = true;
                btn_imprimir.Enabled = true;
                bloquearCampos(false);
                txt_codEmpleado.Enabled = true;
                txt_codEmpleado.Focus();

                if (txt_codEmpleado.Text == "")
                {
                    MessageBox.Show("Debe ingresar un código de empleado.", "Imprimir",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (txt_nombre.Text == "" || txt_puesto.Text == "" || txt_departamento.Text == "")
                    {
                        MessageBox.Show("Debe consultar primero un empleado para poder imprimir!", "Imprimir",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        txt_codEmpleado.Enabled = false;
                        imprimirEmpleado impE = new imprimirEmpleado(txt_codEmpleado.Text, txt_nombre.Text, 
                            txt_puesto.Text, txt_departamento.Text);
                        impE.Show();
                    }
                }
            }            
        }
    }
}
