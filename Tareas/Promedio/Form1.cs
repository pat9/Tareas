using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedio
{
    public partial class frm_Prom : Form
    {
        Promedio objPro = new Promedio();
        public frm_Prom()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            objPro.Num1 = Convert.ToDouble(txt_Num1.Text);
            objPro.Num2 = Convert.ToDouble(txt_Num2.Text);

            txt_Resultado.Text = objPro.CalcularPromedio().ToString();
        }
    }
}
