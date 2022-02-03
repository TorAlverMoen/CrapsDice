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

        int dice1 = 0;
        int dice2 = 0;

        void NewGame()
        {
            Random diceRoll = new Random();
            dice1 = diceRoll.Next(1, 6);
            dice2 = diceRoll.Next(1, 6);


        }
    }
}
