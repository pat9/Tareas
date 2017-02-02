using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPractico2
{
    class Cliente : Persona
    {
        private string direc;


        public string Direcccion
        {
            get
            {
                return direc;
            }

            set
            {
                direc = value;
            }
        }

        public string DatoCliente()
        {
            return "La persona: " + nombre + " " + apellido + " \nes un Cliente y su direccion es: " + direc;
        }
    }
}
