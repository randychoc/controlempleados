using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;

namespace empleadoscontrol
{
    public class seguridad
    {
        OdbcConnection conn = new OdbcConnection("Dsn=ERP");     
        public void nuevoUser(string usuario, string pass, string codEmp, string nivel)
        {
            try
            {
                conn.Open();
                OdbcCommand codigo1 = new OdbcCommand();
                codigo1.Connection = conn;
                codigo1.CommandText = ("INSERT INTO `login`(`usuario`, `contrasenia`, `codigo_empleado`, `nivel`) " +
                    "VALUES ('" + usuario + "',md5('" + pass + "'), '" + codEmp + "', '" + nivel + "');");
                try
                {
                    codigo1.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Se registro correctamente! \n\n " +
                        "Código de Empleado: " + codEmp + " \n Usuario: " + usuario, "Seguridad",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //configInicio();
                    //llenarDataGrid();
                }
                catch (OdbcException)
                {
                    //limpiarCampos();
                    MessageBox.Show(" El usuario ya existe. Intente con otro. ", "Seguridad",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar nuevo usuario. " +
                    "\n\n Error: " + ex.ToString(), "Seguridad",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                conn.Close();
            }
        }

        public void modificarUser()
        {
            //función para modificar USER
        }
        public string[] consultarUsuario(string auxUser, string auxPass)
        {            
            string[] listaReturn = {"",""};
            OdbcCommand cod = new OdbcCommand();
            cod.Connection = conn;
            cod.CommandText = ("SELECT `codigo_empleado`, `nivel` FROM `login` WHERE " +
                "`usuario`= '" + auxUser + "' AND " +
                "`contrasenia`= MD5('" + auxPass + "') AND `estado`= 1");
            try
            {
                conn.Open();
                OdbcDataReader reader1 = cod.ExecuteReader();
                if (reader1.Read() == false)
                {
                    MessageBox.Show("El usuario y/o contraseña es incorrecto! ", "Seguridad",
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
                        listaReturn[0] = reader2.GetValue(0).ToString();
                        listaReturn[1] = reader2.GetValue(1).ToString();
                    }                                      
                }
                conn.Close();
                return listaReturn;
            }
            catch (Exception e)
            {                
                MessageBox.Show(" No se pudo ingresar. \n\n Error: " + e.ToString(), "Seguridad",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
                conn.Close();                
            }
            return listaReturn;
        }
    }
}
