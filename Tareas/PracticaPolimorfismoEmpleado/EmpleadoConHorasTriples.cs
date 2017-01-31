using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismoEmpleado
{
    class EmpleadoConHorasTriples : Empleado
    {
        public override double CalcularSalario()
        {
            return (base.CalcularSalario()) * 3;
        }
    }
}
