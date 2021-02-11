using empleadoscontrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaFRM
{
    public partial class mdi_control : Form
    {
        //mantenimiento_concepto
        //private mantenimiento_empleados frm_mantenimiento_empleados;          
        private registrar_entradas frm_registrar_entradas;
        private registrar_salidas frm_registrar_salidas;
        private generar_reporte_general frm_generar_reporte_general;
        private mantenimiento_empleado frm_mantenimiento_empleado;
        private generar_reporte_individual frm_generar_reporte_individual;                   

        //sentencia sn = new sentencia();
        //String usuarioActivo = "rchocm";  
        string[] listaReturn = {""};
        public mdi_control(string codEmp, string nivel)
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            nivelesPermisos(nivel);
            Lbl_usuario.Text = "Código del Empleado: " + codEmp + " Nivel: " + nivel;           
        }

       
        //==========Funciones para evitar que se habrá 2 veces la misma ventana==========          
        private void frm_registrar_entradas_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_registrar_entradas = null; }
        private void frm_registrar_salidas_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_registrar_salidas = null; }
        private void frm_generar_reporte_general_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_generar_reporte_general = null; }
        private void frm_mantenimiento_empleado_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_empleado = null; }
        private void frm_generar_reporte_individual_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_generar_reporte_individual = null; }              

        //====================Inicio de funciones====================        
        
        public void nivelesPermisos(string auxNivel)
        {
            if (auxNivel == "1")
            {
                menuItem_inicio.Enabled = true;
                menuItem_mantenimientos.Enabled = true;
                menuItem_procesos.Enabled = true;
                menuItem_reporte.Enabled = true;
            }
            else if (auxNivel == "2")
            {
                menuItem_inicio.Enabled = true;
                menuItem_mantenimientos.Enabled = false;
                menuItem_procesos.Enabled = true;
                menuItem_reporte.Enabled = true;
            }            
            else if (auxNivel == "0")
            {
                menuItem_inicio.Enabled = false;
                menuItem_mantenimientos.Enabled = false;
                menuItem_procesos.Enabled = false;
                menuItem_reporte.Enabled = false;
            }
        }
        private void MDI_FRM_Load(object sender, EventArgs e)
        {
            
        }

        private void SeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*/
            MDI_Seguridad seguridad = new MDI_Seguridad(Lbl_usuario.Text);
            seguridad.lbl_nombreUsuario.Text = Lbl_usuario.Text;
            seguridad.ShowDialog(); 
            /*/
        }

        private void Btn_prueba_Click(object sender, EventArgs e)
        {
            //                      Usuario        Mensaje a guardar     Tabla
            //sn.insertarBitacora(Lbl_usuario.Text, "Probó la Bitacora", "General");
        }       

        private void RegistrarEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //REGISTRAR ENTRADAS
            //registrar_entradas
            if (frm_registrar_entradas == null)
            {
                frm_registrar_entradas = new registrar_entradas();
                frm_registrar_entradas.MdiParent = this;
                frm_registrar_entradas.FormClosed += new FormClosedEventHandler(frm_registrar_entradas_FormClosed);
                frm_registrar_entradas.Show();
            }
            else
            {
                frm_registrar_entradas.Activate();
            }
        }

        private void RegistrarSalidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //REGISTRAR SALIDAS
            //registrar_salidas
            if (frm_registrar_salidas == null)
            {
                frm_registrar_salidas = new registrar_salidas();
                frm_registrar_salidas.MdiParent = this;
                frm_registrar_salidas.FormClosed += new FormClosedEventHandler(frm_registrar_salidas_FormClosed);
                frm_registrar_salidas.Show();
            }
            else
            {
                frm_registrar_salidas.Activate();
            }
        }

        private void ReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ReporteGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GENERAR REPORTE GENERAL
            //generar_reporte_general
            if (frm_generar_reporte_general == null)
            {
                frm_generar_reporte_general = new generar_reporte_general();
                frm_generar_reporte_general.MdiParent = this;
                frm_generar_reporte_general.FormClosed += new FormClosedEventHandler(frm_generar_reporte_general_FormClosed);
                frm_generar_reporte_general.Show();
            }
            else
            {
                frm_generar_reporte_general.Activate();
            }
        }

        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EMPLEADOS
            //mantenimiento_empleado
            if (frm_mantenimiento_empleado == null)
            {
                frm_mantenimiento_empleado = new mantenimiento_empleado();
                frm_mantenimiento_empleado.MdiParent = this;
                frm_mantenimiento_empleado.FormClosed += new FormClosedEventHandler(frm_mantenimiento_empleado_FormClosed);
                frm_mantenimiento_empleado.Show();
            }
            else
            {
                frm_mantenimiento_empleado.Activate();
            }
        }

        private void ReporteIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GENERAR REPORTE INDIVIDUAL 
            //generar_reporte_individual
            if (frm_generar_reporte_individual == null)
            {
                frm_generar_reporte_individual = new generar_reporte_individual();
                frm_generar_reporte_individual.MdiParent = this;
                frm_generar_reporte_individual.FormClosed += new FormClosedEventHandler(frm_generar_reporte_individual_FormClosed);
                frm_generar_reporte_individual.Show();
            }
            else
            {
                frm_generar_reporte_individual.Activate();
            }
        }

        private void CerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            login nuevo = new login();
            nuevo.Show();                     
        }

        private void Mdi_control_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "¿Esta seguro que quiere salir del sistema?";
            const string caption = "Salir del Sistema";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Application.ExitThread();
                Environment.Exit(0);
            }
            else if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Mdi_control_FormClosed(object sender, FormClosedEventArgs e)
        {            
            
        }

        private void MenuItem_inicio_Click(object sender, EventArgs e)
        {
            
        }

        private void SalirDelSistemaToolStripMenuItem_Click(object sender, EventArgs ex)
        {
            this.Close();            
        }
    }
}
