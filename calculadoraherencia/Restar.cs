using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraherencia
{
    internal class Restar : Operacion 
    {
        public double operar(double v1, double v2)
        {
            Valor11 = v1; //se puede acceder a los atributos directamente
            Valor22 = v2; // por la relación de herencia
           return Resultadi1 = Valor11 - Valor22;
        }

        public double operar()
        {

            return Resultadi1 = Valor11 - Valor22;

        }
    }
}
