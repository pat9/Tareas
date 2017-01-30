using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moviles
{
    public partial class frm_Movil : Form
    {
        Tableta ObjTab = new Tableta();
        Celular objCel = new Celular();
        public frm_Movil()
        {
            InitializeComponent();
        }

        private void frm_Movil_Load(object sender, EventArgs e)
        {

        }

        private void rbt_VerInfoTablet_CheckedChanged(object sender, EventArgs e)
        {
            ObjTab.Cantidad = Convert.ToInt32(txt_Cantidad.Text);
            ObjTab.Color = txt_Color.Text;
            ObjTab.Compañia = txt_Compania.Text;
            ObjTab.Marca = txt_Marca.Text;
            ObjTab.Precio = Convert.ToInt32(txt_Precio.Text);
            ObjTab.Tamaño = txt_Tamano.Text;
            ObjTab.Version = txt_Version.Text;

            ObjTab.ImprimirDescripcion();

            rtb_Info.Text = ObjTab.Informacion;
            txt_Total.Text = ObjTab.PrecioTotalCompra().ToString();

        }

        private void rbt_VerInfoCel_CheckedChanged(object sender, EventArgs e)
        {
            objCel.Cantidad = Convert.ToInt32(txt_Cantidad.Text);
            objCel.Color = txt_Color.Text;
            objCel.Compañia = txt_Compania.Text;
            objCel.Marca = txt_Marca.Text;
            objCel.Precio = Convert.ToInt32(txt_Precio.Text);
            objCel.Tamaño = txt_Tamano.Text;
            objCel.Version = txt_Version.Text;

            objCel.ImprimirDescripcion();

            rtb_Info.Text = objCel.Informacion;
            txt_Total.Text = objCel.PrecioTotalCompra().ToString();
        }
    }
}
