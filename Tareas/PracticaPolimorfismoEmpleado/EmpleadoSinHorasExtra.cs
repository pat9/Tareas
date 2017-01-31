using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismoEmpleado
{
    class EmpleadoSinHorasExtra : Empleado
    {
        public override double CalcularSalario()
        {
            return base.CalcularSalario();
        }
    }
}
