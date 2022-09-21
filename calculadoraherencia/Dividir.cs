using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraherencia
{
    internal class Dividir: Operacion
    {
        public double Operacion (double V1, double V2)
        {
            Valor11 = V1;
            Valor22 = V2;

            Resultadi1 = Valor11 / Valor22;

            return Resultadi1;
        }

        public double Operacion()
        {
            return Resultadi1 = Valor11 / Valor22;
        }
    }
}
