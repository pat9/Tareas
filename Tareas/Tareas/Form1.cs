using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tareas
{
    public partial class frm_Porcentaje : Form
    {
        Porcentaje ObjPor = new Porcentaje();

        public frm_Porcentaje()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double cantidad;

            if (txt_Cantidad.TextLength > 0)
            {
                cantidad = Convert.ToDouble(txt_Cantidad.Text);
                ObjPor.ObtenerCantidad(cantidad);

                if (rbt_P10.Checked == true)
                {
                    txt_Resultado.Text = ObjPor.DiezPorciento().ToString();
                }
                else if (rbt_P40.Checked == true)
                {
                    txt_Resultado.Text = ObjPor.CuarentaPorciento().ToString();
                }
                else if (rbt_P80.Checked == true)
                {
                    txt_Resultado.Text = ObjPor.OchentaPorciento().ToString();
                }
            }
            else
            {
                MessageBox.Show("Favor de ingresar un valor","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Cantidad.Focus();
            }

        }
             

            

        private void txt_Cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                
            }
        }

        private void d(object sender, EventArgs e)
        {

        }
    }
}
