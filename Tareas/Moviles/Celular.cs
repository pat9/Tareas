using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviles
{
    class Celular : Movil
    {
        protected string marca;
        protected string sistema;
        protected int cantidad;
        protected string version;
        protected string modelo;

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Sistema
        {
            get
            {
                return sistema;
            }

            set
            {
                sistema = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public string Version
        {
            get
            {
                return version;
            }

            set
            {
                version = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public void ImprimirDescripcion()
        {
            informacion = "El celular marca: " + marca + " Tiene el precio de: $" + precio  + "\n" + "Sistema operativo: " + sistema;
        }

        public double PrecioTotalCompra()
        {
            double total;
            return total = precio * cantidad;
        }
    }
}
