using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace PDSA_Game.Games
{


    

    public partial class Game02 : Form


    {

        private Random random = new Random();
        private int score = 0;
        private String name = "";
        private string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public Game02()    
        {
          
            InitializeComponent();          

        }
   
        private string LongestCommonSequenceRecursive(string S1, string S2, int m, int n)
        {
            // Base case: If either of the strings is empty, return an empty string
            if (m == 0 || n == 0)
                return "";

            // If the last characters match, append it to the LCS and recurse for the rest
            if (S1[m - 1] == S2[n - 1])
                return LongestCommonSequenceRecursive(S1, S2, m - 1, n - 1) + S1[m - 1];

            // If the last characters don't match, find the longer of two possibilities
            string lcs1 = LongestCommonSequenceRecursive(S1, S2, m - 1, n);
            string lcs2 = LongestCommonSequenceRecursive(S1, S2, m, n - 1);

            return (lcs1.Length > lcs2.Length) ? lcs1 : lcs2;
        }

        private void UpdateScoreLabel()
        {
            // Update the score label to display the current score
            scoreLabel.Text = "Score: " + score;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String S1 = text1.Text;
            String S2 = text2.Text;


            string longestCommonSeq = LongestCommonSequenceRecursive(S1, S2, S1.Length, S2.Length);
            String input = userInput.Text;

            bool isEmpty = input.Length == 0;

            if (isEmpty)
            {
                return;
            }
           
            bool isSame = string.Equals(input, longestCommonSeq, StringComparison.OrdinalIgnoreCase);

            if (isSame) {
                score++;
                MessageBox.Show("Congrats! You Won!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                UpdateScoreLabel();
                RestartForm();
                
            }
            else
            {
                
                MessageBox.Show(name +" Score is "+ score, "You Lost !", MessageBoxButtons.OK, MessageBoxIcon.None);
                score = 0;
                UpdateScoreLabel();
                RestartForm();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void RestartForm()
        {
            // Generate new random strings and update the label
            string S1 = GenerateRandomString(10);
            string S2 = GenerateRandomString(10);
            string longestCommonSeq = LongestCommonSequenceRecursive(S1, S2, S1.Length, S2.Length);
            if(longestCommonSeq.Length == 0)
            {
                RestartForm();
            }
            text1.Text = S1;
            text2.Text = S2;
            label1.Text = longestCommonSeq;


            // Clear user input
            userInput.Text = string.Empty;
        }

        private void restart_Click(object sender, EventArgs e)
        {
            RestartForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {

            

            name = inputName.Text;

            bool isEmpty = name.Length != 0;

            if (isEmpty)
            {
                string S1 = GenerateRandomString(10);
                string S2 = GenerateRandomString(10);
                string longestCommonSeq = LongestCommonSequenceRecursive(S1, S2, S1.Length, S2.Length);
                text1.Text = S1;
                text2.Text = S2;

                UpdateScoreLabel();
                label1.Text = longestCommonSeq;
            }
            
        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

