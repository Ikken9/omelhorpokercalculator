using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Combinatoria
{
    public static class Calcs
    {
        // factorial de un numero natural n.
        private static BigInteger Factorial(int n)
        {
            BigInteger resultado = new BigInteger(1);
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        private static bool CheckIfCardIsReal(Card card)
        {
            switch (card.Value)
            {
                case "10":
                    return true;

                case "J":
                    return true;

                case "Q":
                    return true;

                case "K":
                    return true;

                case "A":
                    return true;
            }
            return false;
        }

        // n número de arriba / p número de abajo.
        public static long Combinaciones(int n, int p)
        {
            BigInteger resultado = Factorial(n) / (Factorial(p) * Factorial(n - p));
            return (long)resultado;
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
                colorResult = Math.Round(SuitedCardsFlush(), 6);

                // Cartas del mismo palo y ambas reales. (10 o J o Q o K o A)
                if (CheckIfCardIsReal(card1) && CheckIfCardIsReal(card2))
                {
                    royalFlushResult = Math.Round(SuitedRoyalCardsFlush(), 6);
                }

                // dos cartas mismo palo, una real.
                else if (CheckIfCardIsReal(card1) && !CheckIfCardIsReal(card2) || !CheckIfCardIsReal(card1) && CheckIfCardIsReal(card2))
                {
                    royalFlushResult = Math.Round(SingleRoyalCardFlush(), 6);
                }

                // dos cartas mismo palo, ninguna real.
                else if (!CheckIfCardIsReal(card1) && !CheckIfCardIsReal(card2))
                {
                    royalFlushResult = Math.Round(NoRoyalCardsFlush(), 6);
                }

            }

            // distinto palo.
            else
            {
                colorResult = Math.Round(NotSuitedCardsFlush(), 6);

                // Cartas de diferente palo y ambas reales.
                if (CheckIfCardIsReal(card1) && CheckIfCardIsReal(card2))
                {
                    royalFlushResult = Math.Round(NotSuitedRoyalCardsFlush(), 6);
                }

                // diferente palo, una carta es real y otra no
                else if (CheckIfCardIsReal(card1) && !CheckIfCardIsReal(card2) || !CheckIfCardIsReal(card1) && CheckIfCardIsReal(card2))
                {
                    royalFlushResult = Math.Round(SingleRoyalCardFlush(), 6);
                }

                // diferente palo, ninguna carta real.
                else if (!CheckIfCardIsReal(card1) && !CheckIfCardIsReal(card2))
                {
                    royalFlushResult = Math.Round(NoRoyalCardsFlush(), 6);
                }
            }

            return (colorResult, fullHouseResult, pokerResult, royalFlushResult);
        }

        // Calcular la probabilidad de que salga color con dos cartas del mismo palo.
        public static double SuitedCardsFlush()
        {
            double pColor = 0;

            double dividendo = (Combinaciones(11, 3) * 39 * 38) + Combinaciones(11, 4) * 39 + Combinaciones(11, 5) + 3 * (Combinaciones(13, 5));
            double divisor = Combinaciones(50,5);

            pColor = dividendo / divisor;

            return pColor * 100;
        }

        // Calcular la probabilidad de que salga color con cartas de diferente palo.
        public static double NotSuitedCardsFlush()
        {
            double pColor = 0;

            double dividendo = ((Combinaciones(12, 4) * 38) + Combinaciones(12, 5)) * 2 + 2 * (Combinaciones(13, 5));
            double divisor = Combinaciones(50, 5);

            pColor = dividendo / divisor;

            return pColor * 100;
        }

        // Método para calcular la probabilidad de escalera real con dos cartas reales.
        public static double SuitedRoyalCardsFlush()
        {
            double pRoyalFlush = 0;

            double dividendo = Combinaciones(3,3) * 47 * 46 + 3;
            double divisor = Combinaciones(50, 5);

            pRoyalFlush = dividendo / divisor;

            return pRoyalFlush * 100;
        }

        // Ambas cartas reales, distinto palo.
        public static double NotSuitedRoyalCardsFlush()
        {
            double pRoyalFlush = 0;

            double dividendo = 2 * 46 + 2;
            double divisor = Combinaciones(50, 5);

            pRoyalFlush = dividendo / divisor;

            return pRoyalFlush * 100;
        }

        // Una carta real y otra no.
        public static double SingleRoyalCardFlush()
        {
            double pRoyalFlush = 0;

            double dividendo = 46 + 3;
            double divisor = Combinaciones(50, 5);

            pRoyalFlush = dividendo / divisor;

            return pRoyalFlush * 100;
        }

        // Ninguna carta real
        public static double NoRoyalCardsFlush()
        {
            double pRoyalFlush = 0;

            double dividendo = 4;
            double divisor = Combinaciones(50, 5);

            pRoyalFlush = dividendo / divisor;

            return pRoyalFlush * 100;
        }
    }
}
