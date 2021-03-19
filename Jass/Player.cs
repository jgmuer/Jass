using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Jass
{

    class Player
    {
        private List<Card> cardInventory;

        public Player()
        {
            cardInventory = new List<Card>();
        }

        public void addCard(Card card)
        {
            cardInventory.Add(card);
        }

        public List<Card> getCards()
        {
            return cardInventory;
        }
    }
}
