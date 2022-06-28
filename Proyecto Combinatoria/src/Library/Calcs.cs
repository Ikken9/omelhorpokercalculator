using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Combinatoria
{
    public static class Calcs
    {
        private static long combinaciones50in5 = 2118760;
        // factorial de un numero natural n.
        private static long Factorial(int n)
        {
            long resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        // n número de arriba / p número de abajo.
        public static long Combinaciones(int n, int p)
        {
            return Factorial(n) / (Factorial(p) * Factorial(n - p));
        }

        public static (double, double, double, double) CalculateProbability(Card card1, Card card2)
        {
            double colorResult = 0;
            double fullHouseResult = 0;
            double pokerResult = 0;
            double royalFlushResult = 0;

            // Las dos cartas de input son del mismo palo. 
            if (card1.Suit.Equals(card2.Suit))
            {
                colorResult = Math.Round(SuitedCardsFlush(), 4);
            }
            else
            {
                colorResult = Math.Round(NotSuitedCardsFlush(), 4);
            }
            return (colorResult, fullHouseResult, pokerResult, royalFlushResult);
        }

        // Calcular la probabilidad de que salga color con dos cartas del mismo palo.
        public static double SuitedCardsFlush()
        {
            double pColor = 0;

            double dividendo = (Combinaciones(11, 3) * 39 * 38) + Combinaciones(11, 4) * 39 + Combinaciones(11, 5);
            double divisor = combinaciones50in5 + (3 * (Combinaciones(13, 5) / combinaciones50in5));

            //no funciona
            //pColor = ((Combinaciones(11, 3) * 39 * 38) + Combinaciones(11, 4) * 39 + Combinaciones(11, 5)) / (combinaciones50in5 + (3 * (Combinaciones(13, 5) / combinaciones50in5)));

            return (dividendo / divisor) * 100;
        }

        // Calcular la probabilidad de que salga color con cartas de diferente palo.
        public static double NotSuitedCardsFlush()
        {
            double pColor = 0;

            pColor = ((Combinaciones(12, 4) * 38) + Combinaciones(12, 5) * 2) / Combinaciones(50, 5) + 2 * (Combinaciones(13, 5) / Combinaciones(50, 5));

            return pColor;
        }
    }
}
