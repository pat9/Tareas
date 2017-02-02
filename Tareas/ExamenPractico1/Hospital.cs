using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPractico1
{
    class Hospital
    {
        private double presupuesto;
        private double presupuestoGine;
        private double presupuestoTraum;
        private double presupuestoPed;

        public double Presupuesto
        {
            get
            {
                return presupuesto;
            }

            set
            {
                presupuesto = value;
            }
        }

        public double PresupuestoGine
        {
            get
            {
                return presupuestoGine;
            }

            set
            {
                presupuestoGine = value;
            }
        }

        public double PresupuestoTraum
        {
            get
            {
                return presupuestoTraum;
            }

            set
            {
                presupuestoTraum = value;
            }
        }

        public double PresupuestoPed
        {
            get
            {
                return presupuestoPed;
            }

            set
            {
                presupuestoPed = value;
            }
        }

        public void CalcularPresupesto()
        {
            presupuestoGine = presupuesto * .40;
            presupuestoPed = presupuesto * .30;
            presupuestoTraum = presupuesto * .30;

        }

    }
}
