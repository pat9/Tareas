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

        public void CalcularDescuento()
        {
            if (color == "Rojo")
            {
                descuento = montoPagar * .10;
            }
            else if (color == "Verde")
            {
                descuento = montoPagar * .30;
            }

            else if (color == "Morado")
            {
                descuento = montoPagar * .40;
            }
            else if (color == "Azul")
            {
                descuento = montoPagar * .50;
            }
            else if (color == "Gris")
            {
                descuento = montoPagar * .80;
            }
            else
            {
                descuento = montoPagar * 1;
            }
        }

        public void CalcularTotalPago()
        {
            totalPagar = montoPagar - descuento;
        }

    }
}
