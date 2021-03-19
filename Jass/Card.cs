using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jass
{
    class Card
    {
        private Farbe farbe;
        private CardValue cardValue;

        public Card(Farbe farbe, CardValue value)
        {
            this.farbe = farbe;
            this.cardValue = value;
        }

        public Farbe getFarb()
        {
            return farbe;
        }

        public CardValue getValue()
        {
            return cardValue;
        }
    }
}
