using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Results : UserControl
    {
        public Results()
        {
            InitializeComponent();
            resultOutput.Text += Form1.integerCount + "\n\nOriginal Order: \n";

            for(int i = 0; i < Form1.madeGuess.Count; i++)
            {
                resultOutput.Text += Form1.madeGuess[i] + " ";
            }
            resultOutput.Text += "\n\nSorted Order: \n";

            Form1.madeGuess.Sort();
            for (int i = 0; i < Form1.madeGuess.Count; i++)
            {
                resultOutput.Text += Form1.madeGuess[i] + " ";
            }
        }
    }
}
