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

        void NewGame()
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
            MessageBox.Show($"You win with {Points} points in {Turn} turns.", "You win!", MessageBoxButtons.OK);
            NewGame();
        }

        void Loser()
        {
            MessageBox.Show($"Sorry! You lost the game!", "You lost!", MessageBoxButtons.OK);
            NewGame();
        }

        void GameLoop()     // called every time the player rolls the dice
        {
            Turn++;
            DisplayTurns(Turn);

            Random diceRoll = new Random();

            dice[0] = diceRoll.Next(1, 6);
            dice[1] = diceRoll.Next(1, 6);

            DisplayDiceNumber(pictureBox1, dice[0]);
            DisplayDiceNumber(pictureBox2, dice[1]);

            CurrentDiceSum = GetDiceSum(dice[0], dice[1]);

            if (bIsFirstTurn)
            {
                bIsFirstTurn = false;

            }

            Points = Points + CurrentDiceSum;
            DisplayPoints(Points);

            // roll again
            PreviousDiceSum = CurrentDiceSum;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            GameLoop();
        }
    }
}
