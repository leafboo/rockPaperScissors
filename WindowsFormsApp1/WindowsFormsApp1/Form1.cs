using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string playerChoice;
        string computerChoice;
        string[] options = { "R", "P", "S", "P", "S", "R" };
        Random random = new Random();
        int computerScore;
        int playerScore;
        string tie;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MakeChoiceEvent(object sender, EventArgs e)
        {
            Button tempButton = sender as Button;

            playerChoice = (string)tempButton.Tag;

            int i = random.Next(0, options.Length);

            computerChoice = options[i];   

            lblPlayerChoice.Text = "Player is: " + updateTextAndImage(playerChoice, PLAYER_PIC);
            lblCPUChoice.Text = "Computer is: " + updateTextAndImage(computerChoice, CPU_PIC);
            checkGame();
        }

        private string updateTextAndImage(string text, PictureBox pic)
        {
            string word = null;

            switch (text)
            {
                case "R":
                    word = "Rock";
                    pic.Image = Properties.Resources.rock_emoji;
                    break;
                case "P":
                    word = "Paper";
                    pic.Image = Properties.Resources.paper_emoji;
                    break;
                case "S":
                    word = "Scissors";
                    pic.Image = Properties.Resources.scissors_emoji;
                    break;
                
            }

            return word;
        }
        private void checkGame()
        {

        }
    }
}
