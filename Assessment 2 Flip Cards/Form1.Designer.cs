
namespace Assessment_2_Flip_Cards
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.flipButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.textDisplay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.darkMode = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.startbutton = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lightMode = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.selectafiletext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(199, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(388, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "File:";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(593, 21);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.previousButton.Location = new System.Drawing.Point(162, 345);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(112, 34);
            this.previousButton.TabIndex = 4;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // flipButton
            // 
            this.flipButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flipButton.Location = new System.Drawing.Point(355, 345);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(112, 34);
            this.flipButton.TabIndex = 5;
            this.flipButton.Text = "FLIP";
            this.flipButton.UseVisualStyleBackColor = false;
            this.flipButton.Click += new System.EventHandler(this.flipButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nextButton.Location = new System.Drawing.Point(556, 345);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(112, 34);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // shuffleButton
            // 
            this.shuffleButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.shuffleButton.Location = new System.Drawing.Point(256, 404);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(112, 34);
            this.shuffleButton.TabIndex = 7;
            this.shuffleButton.Text = "Shuffle";
            this.shuffleButton.UseVisualStyleBackColor = false;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.randomButton.Location = new System.Drawing.Point(457, 404);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(112, 34);
            this.randomButton.TabIndex = 8;
            this.randomButton.Text = "Random";
            this.randomButton.UseVisualStyleBackColor = false;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // textDisplay
            // 
            this.textDisplay.AutoSize = true;
            this.textDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textDisplay.Location = new System.Drawing.Point(376, 188);
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.Size = new System.Drawing.Size(65, 25);
            this.textDisplay.TabIndex = 9;
            this.textDisplay.Text = "TEXT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(378, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "PROGRESS";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(162, 307);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(506, 18);
            this.progressBar1.TabIndex = 12;
            // 
            // darkMode
            // 
            this.darkMode.Location = new System.Drawing.Point(6, 7);
            this.darkMode.Name = "darkMode";
            this.darkMode.Size = new System.Drawing.Size(86, 24);
            this.darkMode.TabIndex = 13;
            this.darkMode.Text = "Dark Mode";
            this.darkMode.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(670, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(75, 24);
            this.comboBox2.TabIndex = 14;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(751, 144);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(75, 24);
            this.comboBox3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(727, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "N/A";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.startbutton.Location = new System.Drawing.Point(670, 209);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(75, 23);
            this.startbutton.TabIndex = 18;
            this.startbutton.Text = "START";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // stopbutton
            // 
            this.stopbutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.stopbutton.Location = new System.Drawing.Point(751, 209);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(75, 23);
            this.stopbutton.TabIndex = 19;
            this.stopbutton.Text = "STOP";
            this.stopbutton.UseVisualStyleBackColor = false;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(713, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "TIMER";
            // 
            // lightMode
            // 
            this.lightMode.Location = new System.Drawing.Point(6, 37);
            this.lightMode.Name = "lightMode";
            this.lightMode.Size = new System.Drawing.Size(86, 24);
            this.lightMode.TabIndex = 21;
            this.lightMode.Text = "Light Mode";
            this.lightMode.UseVisualStyleBackColor = true;
            this.lightMode.Click += new System.EventHandler(this.lightMode_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(339, 47);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(39, 17);
            this.Time.TabIndex = 22;
            this.Time.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // selectafiletext
            // 
            this.selectafiletext.AutoSize = true;
            this.selectafiletext.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.selectafiletext.Location = new System.Drawing.Point(350, 217);
            this.selectafiletext.Name = "selectafiletext";
            this.selectafiletext.Size = new System.Drawing.Size(125, 13);
            this.selectafiletext.TabIndex = 23;
            this.selectafiletext.Text = "PLEASE SELECT A FILE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(835, 462);
            this.Controls.Add(this.selectafiletext);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.lightMode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.darkMode);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textDisplay);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.flipButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Label textDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button darkMode;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button lightMode;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label selectafiletext;
    }
}

