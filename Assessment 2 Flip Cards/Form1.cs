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
        int CardCount = 0;
        int Order = 0;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        public Form1()
        {
            InitializeComponent();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (Order >= 0)
            {
                Order--;
                int OrderNumber = deck.PreviousCard();

                Card myCard = deck.GetCard(OrderNumber);
                textDisplay.Text = myCard.GetCardName();
            }
        } 

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (Order <= deck.Cards.Length)
            {
                Order++;
                int OrderNumber = deck.NextCard();
                string Name = deck.GetCard(OrderNumber).GetCardName();
                textDisplay.Text = Name;
            }
        }

        private void flipButton_Click(object sender, EventArgs e)
        {
            deck.Cards[Order].Flipcard();
            textDisplay.Text = deck.Cards[Order].GetCardText();
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            string Shuffle = deck.ShuffleCard().ToString();
            textDisplay.Text = Shuffle;
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            //string Random = Decks[DeckCount].GetRandomCard().GetCardName();
            //textDisplay.Text = Random;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string FileName = openFileDialog1.FileName;
            StreamReader FileReader = new StreamReader(FileName);
            deck = new Deck();

            string line = FileReader.ReadLine();

            while ((line = FileReader.ReadLine()) != null)
            {
                string[] cells = line.Split(',');
                string Name = cells[0];
                string Definition = cells[1];
                Console.WriteLine("{0} {1}", Name, Definition);
                deck.Cards[CardCount] = new Card(Name, Definition);
                CardCount++;
         
            }
            Card myCard = deck.GetCard(0);
            textDisplay.Text = myCard.GetCardName();
        }
    }
}
