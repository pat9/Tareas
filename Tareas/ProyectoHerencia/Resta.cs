using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia
{
    class Resta : Operacion
    {
        public void Operar()
        {
            resultado = valor1 - valor2;
        }
    }
}
