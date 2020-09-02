using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true; // when it is true x turn false y turn
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Harsha", "TicTacToe");//When we click on about it will show this message
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//When we click on exit it will stop running the program
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            try
            {   //When w click on NewGame button this loop will clear all the char which is present in the blocks
                foreach(Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }


        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";

            }
            else
            {
                b.Text = "O";
            }
            turn = !turn;
            b.Enabled = false;// at one box only one person can select 
            turn_count++;
            checkForWinner();

        }
        private void checkForWinner()
        { bool winner = false;
            //horizontal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text)&&(!A1.Enabled))
            {
                winner = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text)&&(!B1.Enabled))
            {
                winner = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text)&&(!C1.Enabled))
            {
                winner = true;
            }
            //Vertical checks
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                winner = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                winner = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                winner = true;
            }
            //diagonal checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                winner = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                winner = true;
            }
           
            if (winner)
            {
                
                String Winner = "";
                if (turn)
                {
                    Winner = "O";
                }
                else
                {
                    Winner = "X";
                }
                MessageBox.Show(Winner + "Wins!!");
            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!!!!!!");
                }
            }

        }//End for checkforwinner it gives the winner 
      
    }
}
