using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPractico1
{
    public partial class frm_Hospital : Form
    {
        Hospital objHosp = new Hospital();
        public frm_Hospital()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            objHosp.Presupuesto = Convert.ToDouble(txt_PresupuestoA.Text);

            objHosp.CalcularPresupesto();

            txt_PresupuestoG.Text = objHosp.PresupuestoGine.ToString();
            txt_PresupuestoT.Text = objHosp.PresupuestoTraum.ToString();
            txt_PresupestoP.Text = objHosp.PresupuestoPed.ToString();

        }
    }
}
