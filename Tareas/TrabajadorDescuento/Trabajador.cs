using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajadorDescuento
{
    class Trabajador
    {
        private double descuento;
        private double salario;
        private double totalSalario;

        public double Descuento
        {
            get
            {
                return descuento;
            }

            set
            {
                descuento = value;
            }
        }

        public double Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }

        public double TotalSalrio
        {
            get
            {
                return totalSalario;
            }

            set
            {
                totalSalario = value;
            }
        }

        public void CalcularSalario()
        {
            if (salario <= 1000)
            {
                descuento = salario * .1;
            }
            else if (salario > 1000 && salario <= 2000)
            {
                descuento = salario * .05;
            }
            else
            {
                descuento = salario * .03;
            }

            totalSalario = salario - descuento;
        }
    }
}
