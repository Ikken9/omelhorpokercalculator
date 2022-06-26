using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto_Combinatoria
{
    public class Card
    {
        // valor de la carta.
        public readonly string Value;

        // palo de la carta.
        public readonly string Suit;

        // imagen correspondiente a la carta
        public readonly Image CardImage;

        public Card(string value, string suit, Image cardImage)
        {
            this.Value = value;
            this.Suit = suit;
            this.CardImage = cardImage;
        }
    }
}
