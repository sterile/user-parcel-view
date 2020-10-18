/*
 * Grading ID: E3780
 * Program: 2
 * Due Date: October 19 2020
 * Course: CIS 200-76
 * Description: Provides backend code for the Program 2 form.
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        private List<Address> homes = new List<Address> {
            new Address("Helen C. Bice", "1163 Thompson Drive", "El Sobrante", "CA", 94803),
            new Address("Teresa T. Johnson", "3542 Farland Street", "Apt 101", "Westborough", "MA", 01581),
            new Address("Troy H. Thomas", "1299 Saints Alley", "Plant City", "FL", 33564),
            new Address("Susan K. McCrady", "3118 Chenoweth Drive", "Apt B3", "Clarksville", "TN", 37040),
            new Address("Nicholle C. Warren", "2187 Leo Street", "Pittsburgh", "PA", 15203),
            new Address("Vanessa P. Burgos", "373 Wayback Lane", "New York", "NY", 10013),
            new Address("Amy T. Hight", "4254 Valley Drive", "North Wales", "PA", 19454),
            new Address("Lauren A. Proffitt", "2269 Boggess Street", "Apt 101", "Wichita Falls", "TX", 76301)
        };

        private List<Parcel> parcels = new List<Parcel> { };

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

        /*
         * Preconditions: The insert letter button is clicked.
         * Postcondition: The letter form appears and address is added to the list if necessary.
         */

        private void insertParcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm = new LetterForm(homes);

            DialogResult result; // Result from dialog - OK/Cancel?

            result = letterForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                parcels.Add(letterForm.newLetter);
            }
        }

        /*
         * Preconditions: The list addresses button is clicked.
         * Postcondition: The addresses appear in the report.
         */

        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportBox.Text = String.Empty;

            foreach (Address adr in homes)
                reportBox.Text += adr.ToString() + Environment.NewLine + Environment.NewLine;
        }


        /*
         * Preconditions: The list addresses button is clicked.
         * Postcondition: The addresses appear in the report.
         */

        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportBox.Text = String.Empty;

            foreach (Parcel parcel in parcels)
                reportBox.Text += parcel.ToString() + Environment.NewLine + Environment.NewLine;
        }
    }
}
