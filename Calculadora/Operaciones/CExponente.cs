using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Operaciones
{
    public class CExponente
    {
        public double OperacionExpoenciación(double x1, double x2)
        {
            double result;
            result = Convert.ToDouble(Math.Pow(x1,x2));
            return result;
        }
    }
}
