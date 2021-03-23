using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2_Flip_Cards
{
    class Deck
    {

        public Card[] Cards;
        private int Order = 0;

        public Deck()
        {
            Cards = new Card[4];
        }

        public int PreviousCard()
        {
            if (Order == 0)
            {
                Order = 0;
            }
            else if (Order > 0)
            {
                Order--;
            }
            return Order;
        }

        public int NextCard()
        {
            if (Order <= Cards.Length)
            {
                Order++;
            }
            return Order;
        }

        public Card GetCard(int i)
        {
            return Cards[i];
        }

            public void LoadDeck(string FileName)
        {
            string line;
            int count = 0;
            StreamReader FileReader = new StreamReader(FileName);
            while ((line = FileReader.ReadLine()) != null)
            {
                string[] cells = line.Split(',');
                string word = cells[0];
                string definition = cells[1];
                Cards[count] = new Card(word, definition);
                count++;
            }
        }

        public Card ShuffleCard()
        {
            Random rnd = new Random();
            int count = 0;
            int num = 0;

            for(int i = 0; i < Cards.Length; i++)
            {
                num = rnd.Next(4);

                Cards[count] = Cards[num];
                count++;
            }
            return Cards[num];
        }

        public Card GetRandomCard()
        {
            Random rnd = new Random();

            int Random = rnd.Next(Cards.Length);
            for(int i = 0; i < Cards.Length; i++)
            {
                Random = rnd.Next(Cards.Length);
            }
            return Cards[Random];
        }
        }
    }
