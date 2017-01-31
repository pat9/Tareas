using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismoEmpleado
{
    class Empleado
    {
        protected int horasTrabajadas;
        protected double sueldoPorHora;

        public int HorasTrabajadas
        {
            get
            {
                return horasTrabajadas;
            }

            set
            {
                horasTrabajadas = value;
            }
        }

        public double SueldoPorHora
        {
            get
            {
                return sueldoPorHora;
            }

            set
            {
                sueldoPorHora = value;
            }
        }

        public virtual double CalcularSalario()
        {
            return SueldoPorHora * horasTrabajadas;
        }
    }
}
