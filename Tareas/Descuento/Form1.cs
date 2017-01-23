using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descuento
{
    public partial class frm_Descuentos : Form
    {
        Descuentos objDesc = new Descuentos();
        public frm_Descuentos()
        {
            InitializeComponent();
        }

        public void AsignarValores(string color, int descuento)
        {
            objDesc.MontoPagar = Convert.ToDouble(txt_Monto.Text);
            objDesc.Pordescuento = descuento;
            objDesc.Color = color;
        }

        public void MostrarResultados()
        {
            objDesc.CalcularDescuento();
            objDesc.CalcularTotalPago();
            txt_Descuento.Text = objDesc.Descuento.ToString();
            txt_Total.Text = objDesc.TotalPagar.ToString();
        }

        private void rbt_Rojo_CheckedChanged(object sender, EventArgs e)
        {
           AsignarValores("Rojo",10);
           MostrarResultados(); 
        }

        private void rbt_Verde_CheckedChanged(object sender, EventArgs e)
        {
            AsignarValores("Verde", 30);
            MostrarResultados();
        }

        private void rbt_Morado_CheckedChanged(object sender, EventArgs e)
        {
            AsignarValores("Morado", 40);
            MostrarResultados();
        }

        private void rbt_Azul_CheckedChanged(object sender, EventArgs e)
        {
            AsignarValores("Azul", 50);
            MostrarResultados();
        }

        private void rbt_Gris_CheckedChanged(object sender, EventArgs e)
        {
            AsignarValores("Gris", 80);
            MostrarResultados();
        }

        private void rbt_Blanco_CheckedChanged(object sender, EventArgs e)
        {
            AsignarValores("Blanco", 100);
            if(rbt_Blanco.Checked)
            {
              MessageBox.Show("Felicidades tiene el 100% de descuento", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MostrarResultados();
        }
    }
}
