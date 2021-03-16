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
        private string FileName;
        Card[] Cards;

        public Deck(string FileName)
        {
            this.FileName = FileName;
            Cards = new Card[4];
        }

        public string GetFileName()
        {
            return FileName;
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

        public void ShuffleCard()
        {
            Random rnd = new Random();
            int count = 0;

            for(int i = 0; i < Cards.Length; i++)
            {
                int num = rnd.Next(4);
                Cards[count] = Cards[num];
                count++;
            }
        }

        public void RandomCard()
        {
            
        }
    }
}