using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalarioTrabajador
{
    public partial class Form1 : Form
    {
        Trabajador ObjTrab = new Trabajador();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObjTrab.Horas = Convert.ToInt32(txt_Horas.Text);
            ObjTrab.SueldoHora = Convert.ToDouble(txt_PagoHora.Text);

            ObjTrab.CalcularSalario();

            txt_TotalNormal.Text = ObjTrab.TotalSalarioNormal.ToString();
            txt_TotalExtra.Text = ObjTrab.TotalExtra.ToString();
            txt_Total.Text = ObjTrab.TotalSueldo.ToString();

        }
    }
}
