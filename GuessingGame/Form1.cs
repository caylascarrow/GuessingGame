/// Description: The program generates a random number between 1-100 which
///              the use must guess
/// Author:      Mr. T

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        //creates a random number between 1 and 100 and stores it in a global 
        //variable that can be used throughout the program 
        public static Random randNum = new Random();
        public static int rand = randNum.Next(1, 101);

        //made list that can be used throghout the program
        public static List<int> madeGuess = new List<int>();

        //made a counter so no numbers get rewritten in list
        public static int integerCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            // get the users guess and place into a variable
            int guess = Convert.ToInt16(inputBox.Text);

            //use list to store guesses
                madeGuess[integerCount] = guess;

            // check guess against the random value and output appropriate message
            if (guess < rand)
            {
                outputLabel.Text = "Too Low!";
            }
            else if (guess > rand)
            {
                outputLabel.Text = "Too High!";
            }
            else
            {
                outputLabel.Text = "You Got it!";
                this.Refresh();
                Thread.Sleep(1500);

                //change to new screen
                Results rs = new Results();
                this.Controls.Add(rs);
            }

            // clear out the input box 
            inputBox.Text = "";

            //add on to integer count
            integerCount++;
        }
    }
}
