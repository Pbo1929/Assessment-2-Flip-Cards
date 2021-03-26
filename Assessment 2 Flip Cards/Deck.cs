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
        /// <summary>
        /// Constructor for Deck containin the number of cards.
        /// </summary>
        public Deck()
        {
            Cards = new Card[4];
        }
        /// <summary>
        /// Gets a single card within an array of cards.
        /// </summary>
        /// <param name="i"></param>
        /// <returns>A single card ( e.g. Cards[1] = Cat, 4 legs )</returns>
        public Card GetCard(int i)
        {
            return Cards[i];
        }
        /// <summary>
        /// Used to load the deck. This is never used as I have already made a loading method in Form.
        /// </summary>
        /// <param name="FileName"></param>
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
        /// <summary>
        /// A method for shuffling the card ( changes their positions like if Cat was in Cards[1] it becomes Cards[3] and same goes for the rest ).
        /// </summary>
        public void ShuffleCard()
        {
            Random rnd = new Random();
            int count = 0;
            int num = 0;

            for(int i = 0; i < Cards.Length; i++)
            {
                num = rnd.Next(Cards.Length);

                Card SecondCards = Cards[i];
                Cards[i] = Cards[num];
                Cards[num] = SecondCards;
                count++;
            }
        }
        /// <summary>
        /// Gets a random card within the array using a pseudo-random number generator. 
        /// </summary>
        /// <returns>A random card within the array of cards.</returns>
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
