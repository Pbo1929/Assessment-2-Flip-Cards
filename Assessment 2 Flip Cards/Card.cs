using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2_Flip_Cards
{
    class Card
    {
        private string CardName;
        private string CardDefinition;
        private int CardCount;
        private bool Flip;

        public Card(string CardName, string CardDefinition)
        {
            this.CardName = CardName;
            this.CardDefinition = CardDefinition;
            Flip = false;
        }

        public int GetCount()
        {
            return CardCount;
        }

        public string Flipcard()
        {
            if (Flip == false)
            {
                Flip = true;
                return CardDefinition;
            }
            else
            {
                Flip = false;
                return CardName;
            }
        }
    }
}
