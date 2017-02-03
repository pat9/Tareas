using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajadorDescuento
{
    public partial class frm_Descuento : Form
    {
        Trabajador objTrab = new Trabajador();
        public frm_Descuento()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            objTrab.Salario = Convert.ToDouble(txt_Sal.Text);

            objTrab.CalcularSalario();

            txt_Descuento.Text = objTrab.Descuento.ToString();
            txt_Total.Text = objTrab.TotalSalrio.ToString();
        }
    }
}
