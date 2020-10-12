/*
 * Grading ID: E3780
 * Program: 2
 * Due Date: October 19 2020
 * Course: CIS 200-76
 * Description: Provides backend code for the Program 2 form.
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

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        /*
         * Preconditions: None
         * Postcondition: Form is initialized.
         */

        public Prog2Form()
        {
            InitializeComponent();
        }

        /*
         * Preconditions: The about button is clicked.
         * Postcondition: The about window appears.
         */

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        /*
         * Preconditions: The exit button is clicked.
         * Postcondition: The program exits.
         */

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
