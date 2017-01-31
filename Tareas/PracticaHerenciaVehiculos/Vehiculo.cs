using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerenciaVehiculos
{
    class Vehiculo
    {
        protected string matricula;
        protected string modelo;
        protected string potenciaCV;

        public string Matricula
        {
            get
            {
                return matricula;
            }

            set
            {
                matricula = value;
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

        public string PotenciaCV
        {
            get
            {
                return potenciaCV;
            }

            set
            {
                potenciaCV = value;
            }
        }
    }
}
