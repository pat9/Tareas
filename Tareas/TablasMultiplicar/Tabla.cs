using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasMultiplicar
{
    class Tabla
    {
        int num;
        int num2;
        int res;

        public int Num
        {
            get
            {
                return num;
            }

            set
            {
                num = value;
            }
        }

        public int Num2
        {
            get
            {
                return num2;
            }

            set
            {
                num2 = value;
            }
        }

        public int Res
        {
            get
            {
                return res;
            }
        }

        public void Multiplicar()
        {
            res = num * num2;
        }


    }
}
