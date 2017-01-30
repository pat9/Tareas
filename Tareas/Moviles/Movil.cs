using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviles
{
    class Movil
    {
        protected string color;
        protected string tamaño;
        protected string compañia;
        protected string informacion;
        protected int precio;

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public string Tamaño
        {
            get
            {
                return tamaño;
            }

            set
            {
                tamaño = value;
            }
        }

        public string Compañia
        {
            get
            {
                return compañia;
            }

            set
            {
                compañia = value;
            }
        }

        public string Informacion
        {
            get
            {
                return informacion;
            }
            set
            {
                informacion = value;
            }
        }

        public int Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }
    }
}
