using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Combinatoria
{
    public class CardsManager
    {
        // Array de 13 objetos "Card" de corazones.
        private Card[] heart = new Card[13];

        // Array de 13 objetos "Card" de picas.
        private Card[] spades = new Card[13];

        // Array de 13 objetos "Card" de diamantes.
        private Card[] diamonds = new Card[13];

        // Array de 13 objetos "Card" de trébol.
        private Card[] clubs = new Card[13];

        // Genera las 13 cartas de corazones.
        public void generateHeartCards()
        {
            Card aceCard = new Card("A", "Corazones");
            heart.Append(aceCard);

            for (byte i = 2; i < 10; i++)
            {
                Card card = new Card(i.ToString(), "Corazones");
                heart.Append(card);
            }
            Card jCard = new Card("J", "Corazones");
            heart.Append(jCard);
            Card qCard = new Card("Q", "Corazones");
            heart.Append(qCard);
            Card kCard = new Card("K", "Corazones");
            heart.Append(kCard);
        }

        // Genera las 13 cartas de picas.
        public void generateSpadeCards()
        {
            Card aceCard = new Card("A", "Picas");
            spades.Append(aceCard);

            for (byte i = 2; i < 10; i++)
            {
                Card card = new Card(i.ToString(), "Picas");
                spades.Append(card);
            }
            Card jCard = new Card("J", "Picas");
            spades.Append(jCard);
            Card qCard = new Card("Q", "Picas");
            spades.Append(qCard);
            Card kCard = new Card("K", "Picas");
            spades.Append(kCard);
        }

        // Genera las 13 cartas de diamantes.
        public void generateDiamondsCards()
        {
            Card aceCard = new Card("A", "Diamantes");
            diamonds.Append(aceCard);

            for (byte i = 2; i < 10; i++)
            {
                Card card = new Card(i.ToString(), "Diamantes");
                diamonds.Append(card);
            }
            Card jCard = new Card("J", "Diamantes");
            diamonds.Append(jCard);
            Card qCard = new Card("Q", "Diamantes");
            diamonds.Append(qCard);
            Card kCard = new Card("K", "Diamantes");
            diamonds.Append(kCard);
        }

        // Genera las 13 cartas de tréboles.
        public void generateClubsCards()
        {
            Card aceCard = new Card("A", "Tréboles");
            clubs.Append(aceCard);

            for (byte i = 2; i < 10; i++)
            {
                Card card = new Card(i.ToString(), "Tréboles");
                clubs.Append(card);
            }
            Card jCard = new Card("J", "Tréboles");
            clubs.Append(jCard);
            Card qCard = new Card("Q", "Tréboles");
            clubs.Append(qCard);
            Card kCard = new Card("K", "Tréboles");
            clubs.Append(kCard);
        }

        // Genera las 52 cartas.
        public void generateGame()
        {
            generateHeartCards();
            generateSpadeCards();
            generateDiamondsCards();
            generateClubsCards();
        }
    }
}
