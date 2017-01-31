using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaHerenciaVehiculos
{
    public partial class frm_Vehiculo : Form
    {
        Taxi objTaxi = new Taxi();
        Autobus objAB = new Autobus();

        public frm_Vehiculo()
        {
            InitializeComponent();
        }

        private void btn_Taxi_Click(object sender, EventArgs e)
        {
            objTaxi.Matricula = txt_Matricula.Text;
            objTaxi.Modelo = txt_Modelo.Text;
            objTaxi.PotenciaCV = txt_Potencia.Text;
            objTaxi.NumeroDeLicencia = txt_Licencia.Text;

            MessageBox.Show(objTaxi.ImprimirDatos(), "Taxi");
        }

        private void btn_Autobus_Click(object sender, EventArgs e)
        {
            objAB.Matricula = txt_Matricula.Text;
            objAB.Modelo = txt_Modelo.Text;
            objAB.PotenciaCV = txt_Potencia.Text;
            objAB.NumeroPlazas = txt_Plazas.Text;

            MessageBox.Show(objAB.ImprimirDatos(), "AutoBus");
        }
    }
}
