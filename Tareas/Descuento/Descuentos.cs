using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descuento
{
    class Descuentos
    {
        double montoPagar;
        string color;
        double descuento;
        double totalPagar;
        int pordescuento;


        public double MontoPagar
        {
            set { montoPagar = value; }
        }

        public string Color
        {
            set { color = value; }
        }

        public double Descuento
        {
            get { return descuento; }
        }

        public double TotalPagar
        {
            get { return totalPagar; }
        }

        public int Pordescuento
        {
            get
            {
                return pordescuento;
            }

            set
            {
                pordescuento = value;
            }
        }

        public void CalcularDescuento()
        {
            descuento = (montoPagar * pordescuento)/100;
        }

        public void CalcularTotalPago()
        {
            totalPagar = montoPagar - descuento;
        }

    }
}