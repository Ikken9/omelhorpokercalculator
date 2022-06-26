using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Combinatoria.src
{
    public static class Calcs
    {
        // factorial de un numero natural n.
        private static int Factorial(int n)
        {
            int resultado = 0;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        // n número de arriba / p número de abajo.
        public static int Combinaciones(int n, int p)
        {
            return Factorial(n) / (Factorial(p) * Factorial(n - p));
        }
    }
}
