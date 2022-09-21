using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraherencia
{
    internal class Multiplicar : Operacion
    {
        public double operar(double v1, double v2)
        {
            Valor11 = v1; //se puede aseder alos atributos 
            Valor22 = v2; // por la relacion de erencia

            Resultadi1 = Valor11 * Valor22;

            return Resultadi1;
        }

        public double operar()
        {

            return Resultadi1 = Valor11 * Valor22;

        }
    }
}
