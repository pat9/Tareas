﻿using System;
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
        EmpleadoSinHorasExtra objEmpSinExtra = new EmpleadoSinHorasExtra();
        public frm_Empleado()
        {
            InitializeComponent();
        }

        private void btn_SinExtra_Click(object sender, EventArgs e)
        {

        }
    }
}
