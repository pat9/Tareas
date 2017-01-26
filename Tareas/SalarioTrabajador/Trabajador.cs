using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioTrabajador
{
    class Trabajador
    {
        int horas;
        double sueldoHora;
        double totalExtra;
        double totalSalarioNormal;
        double totalSueldo;

        public int Horas
        {
            set
            {
                horas = value;
            }
        }

        public double SueldoHora
        {
            set
            {
                sueldoHora = value;
            }
        }

        public double TotalExtra
        {
            get
            {
                return totalExtra;
            }
        }

        public double TotalSalarioNormal
        {
            get
            {
                return totalSalarioNormal;
            }
        }

        public double TotalSueldo
        {
            get
            {
                return totalSueldo;
            }
        }

        public void CalcularSalario()
        {
            if (horas <= 10)
            {
                totalSalarioNormal = sueldoHora * horas;
            }
            else
            {
                int horasExtra;
                horasExtra = horas - 10;
                totalSalarioNormal = sueldoHora * 10;
                totalExtra = (sueldoHora * 2) * horasExtra;
            }

            totalSueldo = totalSalarioNormal + totalExtra;
        }

    }
}
