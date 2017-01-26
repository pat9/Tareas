using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    class Empleado : Persona
    {
        protected string clave;

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        public void ImprimirDato()
        {
            info = "El Empleado: " + nombre + " tiene: " + edad + " y su clave es: " + clave;
        }
    }
}
