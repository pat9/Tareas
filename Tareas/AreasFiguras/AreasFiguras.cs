using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasFiguras
{
    class AreasFiguras
    {
        double lado1;
        double lado2;
        double resultado;

        public void ObtenerDatos(double lad1)
        {
            lado1 = lad1;
        }

        public void ObtnerDatos(double lad1, double lad2)
        {
            lado1 = lad1;
            lado2 = lad2;
        }

        public double CalcularAreaCuadrado()
        {
            return resultado = lado1 * lado1;
        }

        public double CalcularAreaTriangulo()
        {
            return resultado = (lado1 * lado2) / 2;
        }

        public double CalcularAreaCirculo()
        {
            return resultado = Math.PI * Math.Pow(lado1, 2);
        }

        public double CalcularAreaRectangulo()
        {
            return resultado = lado1 * lado2;
        }

    }
}
