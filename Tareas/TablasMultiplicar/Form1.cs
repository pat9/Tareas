using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablasMultiplicar
{
    public partial class frm_Tabla : Form
    {
        Tabla objTabla = new Tabla();
        public frm_Tabla()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            rtb_Tabla.Clear();
            objTabla.Num = Convert.ToInt32(txt_Tabla.Text);
            for (int x = 1; x <= 10; x++)
            {
                objTabla.Num2 = x;
                objTabla.Multiplicar();

                rtb_Tabla.AppendText(objTabla.Num + " * " + objTabla.Num2 + " = " + objTabla.Res + "\n");
            }
           
        }

        private void frm_Tabla_Load(object sender, EventArgs e)
        {

        }
    }
}
