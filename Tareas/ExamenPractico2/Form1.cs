using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPractico2
{
    public partial class frm_persona : Form
    {
        Cliente objClient = new Cliente();
        Vendedor objVend = new Vendedor();
        public frm_persona()
        {
            InitializeComponent();
        }

        private void cmb_Opcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_Opcion.SelectedIndex == 0)
            {
                txt_Direccion.Enabled = true;
                txt_CodInt.Enabled = false;
            }
            else
            {
                txt_Direccion.Enabled = false;
                txt_CodInt.Enabled = true;
            }

        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            if (cmb_Opcion.SelectedIndex == 0)
            {
                objClient.Nombre = txt_Nombre.Text;
                objClient.Apellido = txt_Apellido.Text;
                objClient.Direcccion = txt_Direccion.Text;

                rtb_Info.Text = objClient.DatoCliente();
            }
            else
            {
                objVend.Nombre = txt_Nombre.Text;
                objVend.Apellido = txt_Apellido.Text;
                objVend.CodigoInterno = txt_CodInt.Text;

                rtb_Info.Text = objVend.DatoVendedor();
            }
        }
    }
}
