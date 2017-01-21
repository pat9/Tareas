using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreasFiguras
{
    public partial class frm_Areas : Form
    {
        AreasFiguras objAreas = new AreasFiguras();
        public frm_Areas()
        {
            InitializeComponent();
        }

        public void HabilitarTextBox(bool estado)
        {
            if (estado == true)
            {
                lbl_Lado1.Text = "Altura";
                lbl_Lado2.Text = "Base";
            }
            else
            {
                if( rbt_Cuadrado.Checked)
                {
                    lbl_Lado1.Text = "Lado";
                }
                else
                {
                    lbl_Lado1.Text = "Radio";
                }
                
            }

            lbl_Lado2.Visible = estado;
            txt_Lado2.Visible = estado;
        }

        public void MostrarArea(double area)
        {
            txt_Area.Text = area.ToString();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if(rbt_Cuadrado.Checked == true)
            {
                objAreas.Vlado1 = Convert.ToDouble(txt_Lado1.Text);

                MostrarArea(objAreas.CalcularAreaCuadrado());
            }
            else if (rbt_Triangulo.Checked == true)
            {
                objAreas.Vlado1 = Convert.ToDouble(txt_Lado1.Text);
                objAreas.Lado2  = Convert.ToDouble(txt_Lado2.Text);

                MostrarArea(objAreas.CalcularAreaTriangulo());
            }
            else if(rbt_Rectangulo.Checked == true)
            {
                double lado = Convert.ToDouble(txt_Lado1.Text);
                double lado2 = Convert.ToDouble(txt_Lado2.Text);
                objAreas.ObtnerDatos(lado, lado2);

                MostrarArea(objAreas.CalcularAreaRectangulo());
            }
            else
            {
                double lado = Convert.ToDouble(txt_Lado1.Text);
                objAreas.ObtenerDatos(lado);

                MostrarArea(objAreas.CalcularAreaCirculo());
            }
        }


        private void rbt_Triangulo_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarTextBox(true);
        }

        private void rbt_Rectangulo_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarTextBox(true);
        }

        private void rbt_Cuadrado_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarTextBox(false);
        }

        private void rbt_Circulo_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarTextBox(false);
        }
    }
}
