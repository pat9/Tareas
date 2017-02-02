using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajadorIncremento
{
    public partial class frm_Salario : Form
    {
        Trabajador objTrab = new Trabajador();
        public frm_Salario()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            objTrab.Horas = Convert.ToInt32(txt_Horas.Text);
            objTrab.PagoPorHora = Convert.ToDouble(txt_Pago.Text);
            
            objTrab.TotalSalrio = Convert.ToInt32(txt_Sal.Text);

            objTrab.CalcularSalario();

            txt_Porcent.Text = objTrab.Porcentaje.ToString();
            txt_Sal.Text = 

        }
    }
}
