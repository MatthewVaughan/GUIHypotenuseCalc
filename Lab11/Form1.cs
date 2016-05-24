using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// File/Project Prolog
// Name: Matthew Vaughan
// CS 1400 Section 003
// Project: Lab 11
// Date: 02/10/2015 12:30:27 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Lab11
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// About Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display message box that shows programmers name and class
            MessageBox.Show("Matthew Vaughan\nCS1400 Section 003");
        }

        /// <summary>
        /// Exit Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close program when clicked
            this.Close();
        }

        /// <summary>
        /// Calculate Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Read in the length of the first side
            double sideOne = double.Parse(txtFirstSide.Text);

            //Read in the length of the second side
            double sideTwo = double.Parse(txtSecondSide.Text);

            //Call hypotenuse calc method and store answer
            double answer = CalcHypotenuse(sideOne, sideTwo);

            //Package and display the answer
            string hypotenuse = ($"{answer:N2}");
            txtHypotenuse.Text = hypotenuse;
        }

        /// <summary>
        /// Hypotenuse Calculator
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <returns>newHyp</returns>
        static double CalcHypotenuse(double side1, double side2)
        {
            //Take the input side1 and square it
            double newSide1 = side1 * side1;

            //Take the input side2 and sqaure it
            double newSide2 = side2 * side2;

            //Take the new side1 & side2 and add them together
            double hyp = newSide1 + newSide2;

            //Take the square root of the sum
            double newHyp = Math.Sqrt(hyp);

            //Return the value
            return newHyp;
        }
    }
}
