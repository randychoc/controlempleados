using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empleadoscontrol
{
    public partial class imprimirEmpleado : Form
    {        
        public imprimirEmpleado(string codigoEmp, string nombreEmp, string puestoEmp, string deptoEmp)
        {
            InitializeComponent();            
            generarCodigo(codigoEmp);            
            lb_nombre.Text = nombreEmp;
            lb_puesto.Text = puestoEmp;
            lb_depto.Text = deptoEmp;
        }
        Bitmap bmp;
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        void generarCodigo(string codEmpl)
        {
            try
            {
                BarcodeLib.Barcode codigo = new BarcodeLib.Barcode();
                codigo.IncludeLabel = true;
                pnl_barras.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE11, codEmpl,
                    Color.Black, Color.White, 180, 90);
            }
            catch (Exception)
            {
                this.Hide();
                MessageBox.Show("No se pudo generar el código de barras.", "Código de Barras",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                btn_salir.Visible = false;
                btn_imprimir.Visible = false;
                Graphics g = this.CreateGraphics();
                bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
                Graphics mg = Graphics.FromImage(bmp);
                mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
                printPreviewDialog1.ShowDialog();
                btn_salir.Visible = true;
                btn_imprimir.Visible = true;
            }
            catch (Exception)
            {
                this.Hide();
                MessageBox.Show("No se pudo generar el marbete.", "Marbete",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
