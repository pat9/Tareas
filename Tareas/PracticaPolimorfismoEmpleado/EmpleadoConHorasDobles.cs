using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismoEmpleado
{
    class EmpleadoConHorasDobles : Empleado
    {
        public override double CalcularSalario()
        {
            return (base.CalcularSalario()) * 2;
        }
    }
}
