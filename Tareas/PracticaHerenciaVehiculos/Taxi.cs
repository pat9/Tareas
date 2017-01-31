using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerenciaVehiculos
{
    class Taxi : Vehiculo
    {
        private string numeroDeLicencia;

        public string NumeroDeLicencia
        {
            get
            {
                return numeroDeLicencia;
            }

            set
            {
                numeroDeLicencia = value;
            }
        }

        public string ImprimirDatos()
        {
            return "El Vehículo con Matrícula: " + matricula + "de Modelo: " + modelo + " \ncon potencia de: " + potenciaCV + " caballos y su licencia es: " + numeroDeLicencia;
        }
    }
}
