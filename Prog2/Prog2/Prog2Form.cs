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
        private List<Address> homes = new List<Address> { };

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

        /*
         * Preconditions: The insert Address button is clicked.
         * Postcondition: The address form appears and address is added to the list if necessary.
         */

        private void insertAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();

            DialogResult result; // Result from dialog - OK/Cancel?

            result = addressForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                homes.Add(addressForm.newAddress);
            }
        }

        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportBox.Text = String.Empty;

            foreach (Address adr in homes)
                reportBox.Text += adr.ToString() + Environment.NewLine + Environment.NewLine;
        }

        private void insertParcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm = new LetterForm();
            letterForm.ShowDialog();
        }
    }
}
