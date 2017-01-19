using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intereses
{
    public partial class frm_CapInte : Form
    {
        Capital objCap = new Capital();
        public frm_CapInte()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double capital = Convert.ToDouble(txt_Cap.Text);
            int porcentaje = Convert.ToInt32(txt_PorInt.Text);

            objCap.ObtenerDatos(capital, porcentaje);

            txt_IntPro.Text = objCap.CalcularInteres().ToString();
            txt_CapAcom.Text = objCap.CalcularCapitalAcomulado().ToString();
        }
    }
}
