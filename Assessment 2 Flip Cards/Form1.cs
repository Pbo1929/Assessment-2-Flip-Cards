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
        private int TotalSeconds;
        /// <summary>
        /// All buttons are disabled until they actually get a file so it won't keep crashing if they forget to get a file.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.startbutton.Enabled = false;
            this.stopbutton.Enabled = false;
            this.previousButton.Enabled = false;
            this.nextButton.Enabled = false;
            this.flipButton.Enabled = false;
            this.shuffleButton.Enabled = false;
            this.randomButton.Enabled = false;
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
            this.startbutton.Enabled = true;
            this.stopbutton.Enabled = true;
            this.previousButton.Enabled = true;
            this.nextButton.Enabled = true;
            this.flipButton.Enabled = true;
            this.shuffleButton.Enabled = true;
            this.randomButton.Enabled = true;
            for (int i = 0; i < 60; i++)
            {
                this.comboBox2.Items.Add(i.ToString());
                this.comboBox3.Items.Add(i.ToString());
            }
            this.comboBox2.SelectedIndex = 59;
            this.comboBox3.SelectedIndex = 59;

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
            this.BackColor = Color.Black;

            browseButton.ForeColor = Color.White;
            darkMode.ForeColor = Color.White;
            lightMode.ForeColor = Color.White;
            textDisplay.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            previousButton.ForeColor = Color.White;
            flipButton.ForeColor = Color.White;
            nextButton.ForeColor = Color.White;
            shuffleButton.ForeColor = Color.White;
            randomButton.ForeColor = Color.White;
            startbutton.ForeColor = Color.White;
            stopbutton.ForeColor = Color.White;
        }

        private void lightMode_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            browseButton.ForeColor = Color.Black;
            darkMode.ForeColor = Color.Black;
            lightMode.ForeColor = Color.Black;
            textDisplay.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            previousButton.ForeColor = Color.Black;
            flipButton.ForeColor = Color.Black;
            nextButton.ForeColor = Color.Black;
            shuffleButton.ForeColor = Color.Black;
            randomButton.ForeColor = Color.Black;
            startbutton.ForeColor = Color.Black;
            stopbutton.ForeColor = Color.Black;
        }
        /// <summary>
        /// For the timer - when start is pressed, it cannot be pressed again. The minutes and seconds are converted to string so they can be
        /// displayed. A variable called TotalSeconds is created in order to calculate the total seconds, used for later.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startbutton_Click(object sender, EventArgs e)
        {
            this.startbutton.Enabled = false;
            this.stopbutton.Enabled = true;

            int minutes = int.Parse(this.comboBox2.SelectedItem.ToString());
            int seconds = int.Parse(this.comboBox2.SelectedItem.ToString());

            TotalSeconds = (minutes * 60) + seconds;

            this.timer2.Enabled = true;
        }
        /// <summary>
        /// Works exactly like the start button but has the opposite role. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopbutton_Click(object sender, EventArgs e)
        {
            this.stopbutton.Enabled = false;
            this.startbutton.Enabled = true;

            TotalSeconds = 0;
            this.timer2.Enabled = false;
        }
        /// <summary>
        /// This is used to display the minutes and seconds as a text and finding out whether time is up or not. If it is, "Time's up!" is displayed,
        /// showing that the time is up.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(TotalSeconds > 0)
            {
                TotalSeconds--;
                int minutes = TotalSeconds / 60;
                int seconds = TotalSeconds - (minutes * 60);
                this.label4.Text = minutes.ToString() + ":" + seconds.ToString();
            }
            else
            {
                this.timer2.Stop();
                MessageBox.Show("Time's Up!");
            }
        }
    }
}
