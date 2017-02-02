using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajadorIncremento
{
    class Trabajador
    {
        private int horas;
        private double pagoPorHora;
        private double porcentaje;
        private double totalSalrio;

        public int Horas
        {
            get
            {
                return horas;
            }

            set
            {
                horas = value;
            }
        }

        public double PagoPorHora
        {
            get
            {
                return pagoPorHora;
            }

            set
            {
                pagoPorHora = value;
            }
        }

        public double Porcentaje
        {
            get
            {
                return porcentaje;
            }

            set
            {
                porcentaje = value;
            }
        }

        public double TotalSalrio
        {
            get
            {
                return totalSalrio;
            }

            set
            {
                totalSalrio = value;
            }
        }

        public void CalcularSalario()
        {
            totalSalrio = horas * pagoPorHora;
            if(horas > 40)
            {
             porcentaje = totalSalrio * .5;
            }
            totalSalrio = totalSalrio + porcentaje;
        }


    }
}
