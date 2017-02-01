using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaPolimorfismoEmpleado
{
    public partial class frm_Empleado : Form
    {
        EmpleadoSinHorasExtra empSinExtra = new EmpleadoSinHorasExtra();
        EmpleadoConHorasDobles empDoble = new EmpleadoConHorasDobles();
        EmpleadoConHorasTriples empTriple = new EmpleadoConHorasTriples();

        public frm_Empleado()
        {
            InitializeComponent();
        }

        private void btn_SinExtra_Click(object sender, EventArgs e)
        {
            empSinExtra.HorasTrabajadas = int.Parse(txt_Horas.Text);
            empSinExtra.SueldoPorHora = double.Parse(txt_SueldoHora.Text);

            MessageBox.Show("El salario es: $" + empSinExtra.CalcularSalario());
        }

        private void btn_HorasDobles_Click(object sender, EventArgs e)
        {
            empDoble.HorasTrabajadas = int.Parse(txt_Horas.Text);
            empDoble.SueldoPorHora = double.Parse(txt_SueldoHora.Text);

            MessageBox.Show("El salario es: $" + empDoble.CalcularSalario());
        }

        private void btn_Triples_Click(object sender, EventArgs e)
        {
            empTriple.HorasTrabajadas = int.Parse(txt_Horas.Text);
            empTriple.SueldoPorHora = double.Parse(txt_SueldoHora.Text);

            MessageBox.Show("El salario es: $" + empTriple.CalcularSalario());
        }
    }
}
