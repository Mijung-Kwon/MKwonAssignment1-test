/*
 * Name of Project  : Assignment #1 
 * Revision History : version 1.0
 * Written by       : Mijung Kwon (Mkwon6638@conestogac.on.ca, 8736638)
 * Date             : Oct. 01. 2023
 * Purpose          : Tic Tac Toe Game
 * Game Programming with Data Stuctures (PROG2370)
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKwonAssignment1
{
    public partial class Form1 : Form
    {
        bool turn = true; // true:X turn, false:O turn
        int turn_count = 0;

        // Get the sources from Resources
        Image xImage = MKwonAssignment1.Properties.Resources.imagex;
        Image oImage = MKwonAssignment1.Properties.Resources.imageo;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;  //used to cast the sender object to a PictureBox type, declares a new variable p of type PictureBox

            // Check if the PictureBox is already filled or the game is over
            if (p.Image == null)
            {
                if (turn)
                    p.Image = xImage; // Load the X image from resources

                else
                    p.Image = oImage; // Load the O image from resources


                p.Enabled = false; // Disable this PictureBox

                turn = !turn; //to switch between X and O players after each move
                turn_count++;


                CheckForWinner();
            }
        }

        private void CheckForWinner()
        {
            bool thewinner = false;

            // Check for win conditions...
            // Horizontal checks
            if ((pictureBox1.Image == pictureBox2.Image) && (pictureBox2.Image == pictureBox3.Image) && (pictureBox1.Image != null))
                thewinner = true;
            else if ((pictureBox4.Image == pictureBox5.Image) && (pictureBox5.Image == pictureBox6.Image) && (pictureBox4.Image != null))
                thewinner = true;
            else if ((pictureBox7.Image == pictureBox8.Image) && (pictureBox8.Image == pictureBox9.Image) && (pictureBox7.Image != null))
                thewinner = true;

            // Vertical checks
            else if ((pictureBox1.Image == pictureBox4.Image) && (pictureBox4.Image == pictureBox7.Image) && (pictureBox1.Image != null))
                thewinner = true;
            else if ((pictureBox2.Image == pictureBox5.Image) && (pictureBox5.Image == pictureBox8.Image) && (pictureBox2.Image != null))
                thewinner = true;
            else if ((pictureBox3.Image == pictureBox6.Image) && (pictureBox6.Image == pictureBox9.Image) && (pictureBox3.Image != null))
                thewinner = true;

            // Diagonal checks
            else if ((pictureBox1.Image == pictureBox5.Image) && (pictureBox5.Image == pictureBox9.Image) && (pictureBox1.Image != null))
                thewinner = true;
            else if ((pictureBox3.Image == pictureBox5.Image) && (pictureBox5.Image == pictureBox7.Image) && (pictureBox3.Image != null))
                thewinner = true;



            // Check for a winner or draw               
            if (thewinner)
            {
                disableButtons();

                string winner = "";

                if (turn)
                    winner = "O";  //turn is true - winner O because Player O made winning move.
                else
                    winner = "X";  //turn is false - winner X because Player X made winning move.

                MessageBox.Show(winner + " Wins!!");
                ResetGame();
            }
            else if (turn_count == 9)
            {
                MessageBox.Show("Draw!!");
                ResetGame();
            }
        }

        private void disableButtons()
        {
            foreach (Control c in Controls)
            {
                PictureBox p = (PictureBox)c;
                p.Enabled = false;
            }
        }

        private void ResetGame()
        {
            // Reset all buttons to their initial state
            foreach (Control c in Controls)
            {
                if (c is PictureBox p)
                {
                    p.Enabled = true;
                    p.Image = null;
                }
            }

            // Reset game-related variables
            turn = true;
            turn_count = 0;
        }
        
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            // Check if the PictureBox is already filled or the game is over
            if (p.Image == null)
            {
                if (turn)
                    p.Image = xImage; // Load the X image from resources

                else
                    p.Image = oImage; // Load the O image from resources


                p.Enabled = false; // Disable this PictureBox

                turn = !turn; //to switch between X and O players after each move
                turn_count++;


                CheckForWinner();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            // Check if the PictureBox is already filled or the game is over
            if (p.Image == null)
            {
                if (turn)
                    p.Image = xImage; // Load the X image from resources

                else
                    p.Image = oImage; // Load the O image from resources


                p.Enabled = false; // Disable this PictureBox

                turn = !turn; //to switch between X and O players after each move
                turn_count++;


                CheckForWinner();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            // Check if the PictureBox is already filled or the game is over
            if (p.Image == null)
            {
                if (turn)
                    p.Image = xImage; // Load the X image from resources

                else
                    p.Image = oImage; // Load the O image from resources


                p.Enabled = false; // Disable this PictureBox

                turn = !turn; //to switch between X and O players after each move
                turn_count++;


                CheckForWinner();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            // Check if the PictureBox is already filled or the game is over
            if (p.Image == null)
            {
                if (turn)
                    p.Image = xImage; // Load the X image from resources

                else
                    p.Image = oImage; // Load the O image from resources


                p.Enabled = false; // Disable this PictureBox

                turn = !turn; //to switch between X and O players after each move
                turn_count++;


                CheckForWinner();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            // Check if the PictureBox is already filled or the game is over
            if (p.Image == null)
            {
                if (turn)
                    p.Image = xImage; // Load the X image from resources

                else
                    p.Image = oImage; // Load the O image from resources


                p.Enabled = false; // Disable this PictureBox

                turn = !turn; //to switch between X and O players after each move
                turn_count++;


                CheckForWinner();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            // Check if the PictureBox is already filled or the game is over
            if (p.Image == null)
            {
                if (turn)
                    p.Image = xImage; // Load the X image from resources

                else
                    p.Image = oImage; // Load the O image from resources


                p.Enabled = false; // Disable this PictureBox

                turn = !turn; //to switch between X and O players after each move
                turn_count++;


                CheckForWinner();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            // Check if the PictureBox is already filled or the game is over
            if (p.Image == null)
            {
                if (turn)
                    p.Image = xImage; // Load the X image from resources

                else
                    p.Image = oImage; // Load the O image from resources


                p.Enabled = false; // Disable this PictureBox

                turn = !turn; //to switch between X and O players after each move
                turn_count++;


                CheckForWinner();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            // Check if the PictureBox is already filled or the game is over
            if (p.Image == null)
            {
                if (turn)
                    p.Image = xImage; // Load the X image from resources

                else
                    p.Image = oImage; // Load the O image from resources


                p.Enabled = false; // Disable this PictureBox

                turn = !turn; //to switch between X and O players after each move
                turn_count++;


                CheckForWinner();
            }
        }
    }
}
