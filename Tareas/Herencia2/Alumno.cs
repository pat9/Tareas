using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    class Alumno : Persona
    {
        protected string matricula;

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
         public void ImprimirDato()
        {
            info = "El Alumno: " + nombre + " tiene: " + edad + " y su matricula es: " + matricula; 
        }
    }
}
