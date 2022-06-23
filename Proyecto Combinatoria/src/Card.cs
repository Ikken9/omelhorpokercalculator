using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Combinatoria
{
    public class Card
    {
        // valor de la carta.
        public readonly string Value;

        // palo de la carta.
        public readonly string Suit;

        public Card(string value, string suit)
        {
            this.Value = value;
            this.Suit = suit;
        }
    }
}
