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
        private bool Flip;
        private int CardCount;
        /// <summary>
        /// Constructor for Card containing its front and back side.
        /// </summary>
        /// <param name="CardName"></param>
        /// <param name="CardDefinition"></param>
        public Card(string CardName, string CardDefinition)
        {
            this.CardName = CardName;
            this.CardDefinition = CardDefinition;
            Flip = false;
        }
        /// <summary>
        /// Flips the card.
        /// </summary>
        /// <returns></returns>
        public bool Flipcard()
        {
            if (Flip == false)
            {
                Flip = true;
            }
            else
            {
                Flip = false;
            }
            return Flip;
        }

        public string GetCardName()
        {
            return CardName;
        }

        public string GetCardDefinition()
        {
            return CardDefinition;
        }

        public int GetCount()
        {
            return CardCount;
        }

        public bool IsFlipped()
        {
            return Flip;
        }
        /// <summary>
        /// Returns its name or definition depending on its current status ( true or false ).
        /// </summary>
        /// <returns></returns>
        public string GetCardText()
        {
            if (Flip == true)
            {
                return CardDefinition;
            }
            else
            {
                return CardName;
            }
        }
    }
}

