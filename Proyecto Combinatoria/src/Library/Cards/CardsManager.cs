using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Combinatoria.Resources;

namespace Proyecto_Combinatoria
{
    public class CardsManager
    {
        private static CardsManager instance = new CardsManager();

        // Array de 13 objetos "Card" de corazones.
        private Card[] heart = new Card[13];

        // Array de 13 objetos "Card" de picas.
        private Card[] spades = new Card[13];

        // Array de 13 objetos "Card" de diamantes.
        private Card[] diamonds = new Card[13];

        // Array de 13 objetos "Card" de trébol.
        private Card[] clubs = new Card[13];

        public static CardsManager GetInstance()
        {
            if (instance == null)
            {
                instance = new CardsManager();
                CardsManager.GenerateGame();
            }
            return instance;
        }

        // Genera las 13 cartas de corazones.
        public void GenerateHeartCards()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeartCardsResource));
            Card aceCard = new Card("A", "Corazones", ((System.Drawing.Image)(resources.GetObject("ace_of_hearts"))));
            instance.heart[0] = aceCard;

            for (byte i = 2; i <= 10; i++)
            {
                Card card = new Card(i.ToString(), "Corazones", ((System.Drawing.Image)(resources.GetObject($"_{i}_of_hearts"))));
                instance.heart[i - 1] = card;
            }
            Card jCard = new Card("J", "Corazones", ((System.Drawing.Image)(resources.GetObject("jack_of_hearts2"))));
            instance.heart[10] = jCard;
            Card qCard = new Card("Q", "Corazones", ((System.Drawing.Image)(resources.GetObject("queen_of_hearts2"))));
            instance.heart[11] = qCard;
            Card kCard = new Card("K", "Corazones", ((System.Drawing.Image)(resources.GetObject("king_of_hearts2"))));
            instance.heart[12] = kCard;
        }
        
        // Genera las 13 cartas de picas.
        public void GenerateSpadeCards()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpadeCardsResource));
            Card aceCard = new Card("A", "Picas", ((System.Drawing.Image)(resources.GetObject("ace_of_spades2"))));
            instance.spades[0] = aceCard;

            for (byte i = 2; i <= 10; i++)
            {
                Card card = new Card(i.ToString(), "Picas", ((System.Drawing.Image)(resources.GetObject($"_{i}_of_spades"))));
                instance.spades[i - 1] = card;
            }
            Card jCard = new Card("J", "Picas", ((System.Drawing.Image)(resources.GetObject("jack_of_spades2"))));
            instance.spades[10] = jCard;
            Card qCard = new Card("Q", "Picas", ((System.Drawing.Image)(resources.GetObject("queen_of_spades2"))));
            instance.spades[11] = qCard;
            Card kCard = new Card("K", "Picas", ((System.Drawing.Image)(resources.GetObject("king_of_spades2"))));
            instance.spades[12] = kCard;
        }

        // Genera las 13 cartas de diamantes.
        public void GenerateDiamondsCards()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiamondCardsResource));
            Card aceCard = new Card("A", "Diamantes", ((System.Drawing.Image)(resources.GetObject("ace_of_diamonds"))));
            instance.diamonds[0] = aceCard;

            for (byte i = 2; i <= 10; i++)
            {
                Card card = new Card(i.ToString(), "Diamantes", ((System.Drawing.Image)(resources.GetObject($"_{i}_of_diamonds"))));
                instance.diamonds[i - 1] = card;
            }
            Card jCard = new Card("J", "Diamantes", ((System.Drawing.Image)(resources.GetObject("jack_of_diamonds2"))));
            instance.diamonds[10] = jCard;
            Card qCard = new Card("Q", "Diamantes", ((System.Drawing.Image)(resources.GetObject("queen_of_diamonds2"))));
            instance.diamonds[11] = qCard;
            Card kCard = new Card("K", "Diamantes", ((System.Drawing.Image)(resources.GetObject("king_of_diamonds2"))));
            instance.diamonds[12] = kCard;
        }

        // Genera las 13 cartas de tréboles.
        public void GenerateClubsCards()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClubCardsResource));
            Card aceCard = new Card("A", "Tréboles", ((System.Drawing.Image)(resources.GetObject("ace_of_clubs"))));
            instance.clubs[0] = aceCard;

            for (byte i = 2; i <= 10; i++)
            {
                Card card = new Card(i.ToString(), "Tréboles", ((System.Drawing.Image)(resources.GetObject($"_{i}_of_clubs"))));
                instance.clubs[i - 1] = card;
            }
            Card jCard = new Card("J", "Tréboles", ((System.Drawing.Image)(resources.GetObject("jack_of_clubs2"))));
            instance.clubs[10] = jCard;
            Card qCard = new Card("Q", "Tréboles", ((System.Drawing.Image)(resources.GetObject("queen_of_clubs2"))));
            instance.clubs[11] = qCard;
            Card kCard = new Card("K", "Tréboles", ((System.Drawing.Image)(resources.GetObject("king_of_clubs2"))));
            instance.clubs[12] = kCard;
        }

        // Genera las 52 cartas.
        public static void GenerateGame()
        {
            instance.GenerateHeartCards();
            instance.GenerateSpadeCards();
            instance.GenerateDiamondsCards();
            instance.GenerateClubsCards();
        }

        // Método que dado un nombre de palo como string devuelve el array de cartas de ese palo.
        public static Card[] GetSuit(string suit)
        {
            switch (suit)
            {
                case "Corazones":
                    return instance.heart;

                case "Diamantes":
                    return instance.diamonds;

                case "Picas":
                    return instance.spades;

                case "Tréboles":
                    return instance.clubs;
            }
            return null;
        }

        public static Card GetCard(Card[] suit, int value)
        {
            Card card = suit[value];
            return card;
        }

    }
}
