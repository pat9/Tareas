using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Promedio
    {
        double num1;
        double num2;
        double prom;

        public double Num1
        {
            set
            {
                num1 = value;
            }
        }

        public double Num2
        {
            set
            {
                num2 = value;
            }
        }

        public double CalcularPromedio()
        {
            return prom = (num1 + num2)/2;
        }
    }
}
