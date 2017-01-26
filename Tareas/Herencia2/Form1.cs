using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia2
{
    public partial class frm_Persona : Form
    {
        Alumno objAlumno = new Alumno();
        Empleado objEmpleado = new Empleado();
        public frm_Persona()
        {
            InitializeComponent();
        }

        private void btn_Alumno_Click(object sender, EventArgs e)
        {
            objAlumno.Nombre = txt_Nombre.Text;
            objAlumno.Edad = Convert.ToInt32(txt_Edad.Text);
            objAlumno.Matricula = txt_Matricula.Text;

            objAlumno.ImprimirDato();

            rbt_Info.Text = objAlumno.Info;

        }

        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            objEmpleado.Nombre = txt_Nombre.Text;
            objEmpleado.Edad = Convert.ToInt32(txt_Edad.Text);
            objEmpleado.Clave = txt_Matricula.Text;

            objEmpleado.ImprimirDato();

            rbt_Info.Text = objEmpleado.Info;
        }
    }
}
