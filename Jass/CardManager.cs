using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jass
{
    class CardManager
    {
        public static List<Card> getAllCards()
        {
            List<Card> cardList = new List<Card>();
            foreach (Farbe farbe in Enum.GetValues(typeof(Farbe)))
            {
                foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                    cardList.Add(new Card(farbe, value));
                }
            }
            return cardList;
        }
    }
}
