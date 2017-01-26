using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia
{
    class Operacion
    {
        //Atributos
        protected double valor1;
        protected double valor2;
        protected double resultado;

        public double Valor1
        {
            set { valor1 = value; }
            get { return valor1;  }
        }

        public double Valor2
        {
            get { return valor2; }
            set { valor2 = value; }
        }

        public double Resultado
        {
            get {return resultado;}

            set
            {
                resultado = value;
            }
        }
    }
}
