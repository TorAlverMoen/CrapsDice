using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrapsDice
{
    public partial class Craps : Form
    {
        public Craps()
        {
            InitializeComponent();
        }

        int[] dice = { 0, 0 };
        int CurrentDiceSum = 0;
        int PreviousDiceSum = 0;
        int Turn = 0;
        int Points = 0;
        bool bIsFirstTurn = true;

        void NewGame()  // Reset variables for a new game
        {
            dice[0] = 0;
            dice[1] = 0;

            CurrentDiceSum = 0;
            PreviousDiceSum = 0;
            bIsFirstTurn = true;

            Turn = 0;
            DisplayTurns(Turn);

            Points = 0;
            DisplayPoints(Points);
        }

        void DisplayTurns(int newTurns)
        {
            displayTurns.Text = newTurns.ToString();
        }

        void DisplayPoints(int newPoints)
        {
            displayPoints.Text = newPoints.ToString();
        }

        private void Craps_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        int GetDiceSum(int InDice1, int InDice2)
        {
            return InDice1 + InDice2;
        }

        void DisplayDiceNumber(PictureBox InPictureBox, int DiceNumber)
        {
            switch (DiceNumber)
            {
                case 1:
                    InPictureBox.Image = Properties.Resources._1;
                    break;
                case 2:
                    InPictureBox.Image = Properties.Resources._2;
                    break;
                case 3:
                    InPictureBox.Image = Properties.Resources._3;
                    break;
                case 4:
                    InPictureBox.Image = Properties.Resources._4;
                    break;
                case 5:
                    InPictureBox.Image = Properties.Resources._5;
                    break;
                case 6:
                    InPictureBox.Image = Properties.Resources._6;
                    break;
            }
        }

        void Winner()
        {
            if (!bIsFirstTurn)
            {
                MessageBox.Show($"You win with {Points} points in {Turn} turns.", "You win!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show($"You rolled {CurrentDiceSum} in the first turn and win the game!", "You win!", MessageBoxButtons.OK);
            }
            NewGame();
        }

        void Loser()
        {
            if (!bIsFirstTurn)
            {
                MessageBox.Show($"Sorry! You rolled {CurrentDiceSum} and lost the game!", "You lost!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show($"Sorry! You rolled {CurrentDiceSum} in the first turn and lost the game!", "You lost!", MessageBoxButtons.OK);
            }
            NewGame();
        }

        // called every time the player rolls the dice
        void GameLoop()
        {
            Turn++;                                         // Update and
            DisplayTurns(Turn);                             // display the number of turns

            Random diceRoll = new Random();

            dice[0] = diceRoll.Next(1, 6);                  // roll dice one
            dice[1] = diceRoll.Next(1, 6);                  // roll dice two

            DisplayDiceNumber(pictureBox1, dice[0]);        // Display the result of dice one roll
            DisplayDiceNumber(pictureBox2, dice[1]);        // Display the result of dice two roll

            CurrentDiceSum = GetDiceSum(dice[0], dice[1]);  // Get the sum of the two dice

            if (bIsFirstTurn)                               // The rules are different for the first turn
            {
                // check win conditions
                if ((CurrentDiceSum == 7) || (CurrentDiceSum == 11))
                {
                    Winner();
                }

                // check lose conditions
                if ((CurrentDiceSum == 2) || (CurrentDiceSum == 3) || (CurrentDiceSum == 12))
                {
                    Loser();
                }

                bIsFirstTurn = false;
                PreviousDiceSum = CurrentDiceSum;
            }
            else
            {
                // check win condition
                if (PreviousDiceSum == CurrentDiceSum)
                {
                    Winner();
                }

                // check lose condition
                if (CurrentDiceSum == 7)
                {
                    Loser();
                }
            }

            // Update the number of points
            Points = Points + CurrentDiceSum;
            DisplayPoints(Points);

            // Prepare for the next roll
            PreviousDiceSum = CurrentDiceSum;

            // Return control to the player for the next roll
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            GameLoop();
        }

        // Buttons at the bottom of the window

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutCrapsDice = new AboutBox1();
            aboutCrapsDice.ShowDialog();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {

        }

        private void btnRules_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }

}
