using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaPersona
{
    public partial class frm_Empleado : Form
    {
        Empleado objEmpleado = new Empleado();
        public frm_Empleado()
        {
            InitializeComponent();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            objEmpleado.Nombre = txt_Nombre.Text;
            objEmpleado.Edad = int.Parse(txt_Edad.Text);
            objEmpleado.Sueldo = int.Parse(txt_Sueldo.Text);

            MessageBox.Show("El empleado: " + objEmpleado.Nombre + " Tiene: " + objEmpleado.Edad + " Años" + " Y gana: $" + objEmpleado.Sueldo);

        }
    }
}
