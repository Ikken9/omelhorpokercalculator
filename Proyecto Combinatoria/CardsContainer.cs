using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Combinatoria
{
    internal class CardsContainer
    {
        //Esta lista contiene las 52 cartas en un principio, cuando el jugador seleccione 2 cartas, se quitan de la lista,
        //quedando disponibles otras 50 cartas.
        List<String> Cards = new List<String>();
        

        //Metodo para llenar la lista con las 52 cartas.
        public void generateCards()
        {
            Cards.Add("AsCorazones");
            for(int i = 2; i < 10; i++)
            {
                Cards.Add(i.ToString() + "Corazones");
            }
            Cards.Add("JCorazones");
            Cards.Add("QCorazones");
            Cards.Add("KCorazones");

            Cards.Add("AsDiamantes");
            for (int i = 2; i < 10; i++)
            {
                Cards.Add(i.ToString() + "Diamantes");
            }
            Cards.Add("JDiamantes");
            Cards.Add("QDiamantes");
            Cards.Add("QDiamantes");

            Cards.Add("AsPikas");
            for (int i = 2; i < 10; i++)
            {
                Cards.Add(i.ToString() + "Pikas");
            }
            Cards.Add("JPikas");
            Cards.Add("QPikas");
            Cards.Add("KPikas");

            Cards.Add("AsTrebol");
            for (int i = 2; i < 10; i++)
            {
                Cards.Add(i.ToString() + "Trebol");
            }
            Cards.Add("JTrebol");
            Cards.Add("QTrebol");
            Cards.Add("KTrebol");
        }


    }
}
