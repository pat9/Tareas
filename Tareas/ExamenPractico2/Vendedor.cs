using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPractico2
{
    class Vendedor : Persona
    {
        private string codint;

        public string CodigoInterno
        {
            get
            {
                return codint;
            }

            set
            {
                codint = value;
            }
        }

        public string DatoVendedor()
        {
            return "La persona: " + nombre + " " + apellido + " \nes un Vendedor y su codigo interno es: " + codint;
        }
    }
}
