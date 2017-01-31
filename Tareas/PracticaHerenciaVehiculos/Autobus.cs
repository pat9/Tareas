using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerenciaVehiculos
{
    class Autobus : Vehiculo
    {
        private string numeroPlazas;

        public string NumeroPlazas
        {
            get
            {
                return numeroPlazas;
            }

            set
            {
                numeroPlazas = value;
            }
        }
        public string ImprimirDatos()
        {
            return "El Vehículo con Matrícula: " + matricula + "de Modelo: " + modelo + " \ncon potencia de: " + potenciaCV + " caballos y su numero de plazas es: " + numeroPlazas ;
        }
    }
}
