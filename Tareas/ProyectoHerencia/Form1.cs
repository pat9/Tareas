using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHerencia
{
    public partial class Form1 : Form
    {
        Suma objSuma = new Suma();
        Resta objResta = new Resta();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Suma_Click(object sender, EventArgs e)
        {
            objSuma.Valor1 = Convert.ToDouble(txt_Valor1.Text);
            objSuma.Valor2 = Convert.ToDouble(txt_Valor2.Text);

            objSuma.Operar();

            txt_Resultado.Text = objSuma.Resultado.ToString(); 

        }

        private void btn_Resta_Click(object sender, EventArgs e)
        {
            objResta.Valor1 = Convert.ToDouble(txt_Valor1.Text);
            objResta.Valor2 = Convert.ToDouble(txt_Valor2.Text);

            objResta.Operar();

            txt_Resultado.Text = objResta.Resultado.ToString();
        }
    }
}
