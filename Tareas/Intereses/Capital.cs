using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intereses
{
    class Capital
    {
        double capital;
        int porcent;
        double intereses;
        double capitalAcomulado;

        public void ObtenerDatos(double cap, int por)
        {
            capital = cap;
            porcent = por;
        }

        public double CalcularInteres()
        {
            intereses = (capital * porcent) / 100;
            return intereses;
        }

        public double CalcularCapitalAcomulado()
        {
            capitalAcomulado = capital + intereses;
            return capitalAcomulado;
        }
    }
}
