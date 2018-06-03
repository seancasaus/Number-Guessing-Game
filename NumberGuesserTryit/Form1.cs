using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NumberGuesserTryit.NumberGuesser;

namespace NumberGuesserTryit
{
    public partial class Form1 : Form
    {
        private static int SecretNumber = 0;
        private static int numAttempts = 0;
        public Form1()
        {
            InitializeComponent();
        }
   
        //uses the Secret Number Service to Generate a Random Secret Number
        private void Generate_Click(object sender, EventArgs e)
        {
            NumberGuesser.Service1Client gen = new NumberGuesser.Service1Client();
            int low;
            int high;
            try
            {
                low = int.Parse(this.LL_Box.Text);
            }
            catch (FormatException er)
            {
                low = 0;
                Console.WriteLine(er.Message);
            }
            try
            {
                high = int.Parse(this.UL_Box.Text);
            }
            catch (FormatException er)
            {
                high = 0;
                Console.WriteLine(er.Message);
            }
            SecretNumber = gen.SecretNumber(low, high);
            //use this to display the secret number on screen you cheater
            //this.SecretNum.Text = "Secret Num: " + SecretNumber;
        }

        //uses the checkNumber API to compare user input to the secret number
        private void Play_Click(object sender, EventArgs e)
        {
            NumberGuesser.Service1Client gen = new NumberGuesser.Service1Client();
            int guess;
            try
            {
                guess = int.Parse(this.GuessBox.Text);
            }
            catch (FormatException er)
            {
                guess = 0;
                Console.WriteLine(er.Message);
            }
            String result;
            result = gen.CheckNumber(guess, SecretNumber);
            if (result == "too big" || result == "too small")
            {
                numAttempts++;
                this.Attempts.Text = "Attempts: " + numAttempts;
                this.NumberIs.Text = "The Number is: " + result;
            }
            else if(result == "correct")
            {
                this.Attempts.Text = "Total Attempts: " + numAttempts;
                this.NumberIs.Text = "The Number is: " + result;
                numAttempts = 0;
                SecretNumber = 0;

            }
            else
            {
                this.Attempts.Text = "Error";
                this.NumberIs.Text = "";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
