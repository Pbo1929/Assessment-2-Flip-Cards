using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assessment_2_Flip_Cards
{
    public partial class Form1 : Form
    {
        private Deck deck;
        int Order = 0;
        int Value = 0;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        public Form1()
        {
            InitializeComponent();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        }
        /// <summary>
        /// Used to get the previous card. Limits so it can't go less than 0.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void previousButton_Click(object sender, EventArgs e)
        {
            if (Order == 0)
            {
                Card myCard = deck.GetCard(0);
                textDisplay.Text = myCard.GetCardName();
            }
            else if (Order < 0)
            {
                Order = 0;
                Card myCard = deck.GetCard(Order);
                textDisplay.Text = myCard.GetCardName();

            }
            else
            {
                Order--;
                Card myCard = deck.GetCard(Order);
                textDisplay.Text = myCard.GetCardName();

            }
        } 
        /// <summary>
        /// Used to get the next card. Limits so it can't get over the length of the cards array.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            Order++;
            if (Order == deck.Cards.Length)
            {
                Order = 0;
                Card myCard = deck.GetCard(Order);
                textDisplay.Text = myCard.GetCardName();

            }
            else if ( Order > deck.Cards.Length)
            {
                Order = deck.Cards.Length;
                Card myCard = deck.GetCard(Order);
                textDisplay.Text = myCard.GetCardName();

            }
            else
            {
                Card myCard = deck.GetCard(Order);
                textDisplay.Text = myCard.GetCardName();

            }
        }
        /// <summary>
        /// Flips the card upon click and displays the result as a text on the GUI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flipButton_Click(object sender, EventArgs e)
        {
            deck.Cards[Order].Flipcard();
            textDisplay.Text = deck.Cards[Order].GetCardText();
        }
        /// <summary>
        /// Shuffles the cards upon click and displays the new card as a text on the GUI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shuffleButton_Click(object sender, EventArgs e)
        {
            deck.ShuffleCard();
            Card myCard = deck.GetCard(0);
            textDisplay.Text = myCard.GetCardName();
        }
        /// <summary>
        /// Gets a random card upon click and displays the received random card from the cards array as a text on the GUI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void randomButton_Click(object sender, EventArgs e)
        {
            string Random = deck.GetRandomCard().GetCardName();
            textDisplay.Text = Random;
        }
        /// <summary>
        /// Loads a text file and displays its first card.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string FileName = openFileDialog1.FileName;
            StreamReader FileReader = new StreamReader(FileName);
            int CardCount = 0;
            deck = new Deck();

            string line = "";

            while ((line = FileReader.ReadLine()) != null)
            {
                string[] cells = line.Split(',');
                string Name = cells[0];
                string Definition = cells[1];

                deck.Cards[CardCount] = new Card(Name, Definition);
                CardCount++;
         
            }
            Card myCard = deck.GetCard(0);
            textDisplay.Text = myCard.GetCardName();
        }

        private void darkMode_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.Black;
        }
    }
}
