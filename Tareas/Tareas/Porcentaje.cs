using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    class Porcentaje
    {
        double cantidad;
        double rPor10;
        double rPor40;
        double rPor80;

        public void ObtenerCantidad(double cant)
        {
            cantidad = cant;
        }

        public double DiezPorciento()
        {
            return rPor10 = cantidad * .10;
        }
        public double CuarentaPorciento()
        {
            return rPor10 = cantidad * .40;
        }

        public double OchentaPorciento()
        {
            return rPor10 = cantidad * .80;
        }
    }
}
