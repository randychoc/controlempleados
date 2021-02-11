using CapaVistaFRM;
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
using System.Security.Cryptography;

namespace empleadoscontrol
{
    public partial class login : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=ERP");        
        seguridad seg = new seguridad();
        string[] listaReturn = { "" };
        public login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
        
        void limpiarCampos()
        {
            txt_user.Text = "";
            txt_pass.Text = "";
            txt_user.Focus();
        }       

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "" || txt_pass.Text == "")
            {                
                MessageBox.Show("Debe ingresar usuario y contraseña!", "LOGIN",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                limpiarCampos();
            }
            else
            {
                //consultarUsuario();                
                listaReturn = seg.consultarUsuario(txt_user.Text, txt_pass.Text);                
                //MessageBox.Show("[0] = " + listaReturn[0] + " [1] = " + listaReturn[1]);
                if (listaReturn[0] == "" || listaReturn[1] == "")
                {
                    limpiarCampos();
                }
                else
                {                    
                    this.Hide();
                    mdi_control mdi = new mdi_control(listaReturn[0], listaReturn[1]);
                    mdi.Show();
                }                
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {            
            Application.ExitThread();
        }
    }
}
