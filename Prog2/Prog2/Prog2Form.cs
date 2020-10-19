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
        private UserParcelView upv = new UserParcelView();

        /*
         * Preconditions: None
         * Postcondition: Form is initialized.
         */

        public Prog2Form()
        {
            InitializeComponent();


            upv.AddAddress("Helen C. Bice", "1163 Thompson Drive", "El Sobrante", "CA", 94803);
            upv.AddAddress("Teresa T. Johnson", "3542 Farland Street", "Apt 101", "Westborough", "MA", 01581);
            upv.AddAddress("Troy H. Thomas", "1299 Saints Alley", "Plant City", "FL", 33564);
            upv.AddAddress("Susan K. McCrady", "3118 Chenoweth Drive", "Apt B3", "Clarksville", "TN", 37040);
            upv.AddAddress("Nicholle C. Warren", "2187 Leo Street", "Pittsburgh", "PA", 15203);
            upv.AddAddress("Vanessa P. Burgos", "373 Wayback Lane", "New York", "NY", 10013);
            upv.AddAddress("Amy T. Hight", "4254 Valley Drive", "North Wales", "PA", 19454);
            upv.AddAddress("Lauren A. Proffitt", "2269 Boggess Street", "Apt 101", "Wichita Falls", "TX", 76301);

            upv.AddGroundPackage(upv.AddressAt(0), upv.AddressAt(1), 5, 5, 6, 1);
            upv.AddGroundPackage(upv.AddressAt(0), upv.AddressAt(1), 30, 42, 18, 60);
            upv.AddNextDayAirPackage(upv.AddressAt(0), upv.AddressAt(3), 40, 20, 60, 74, 10M);
            upv.AddNextDayAirPackage(upv.AddressAt(4), upv.AddressAt(2), 10, 13, 13, 100, 50M);
            upv.AddTwoDayAirPackage(upv.AddressAt(2), upv.AddressAt(1), 20, 25, 50, 75, TwoDayAirPackage.Delivery.Early);
            upv.AddTwoDayAirPackage(upv.AddressAt(2), upv.AddressAt(3), 40, 40, 20, 76, TwoDayAirPackage.Delivery.Saver);
            upv.AddLetter(upv.AddressAt(2), upv.AddressAt(0), 0.46M);
            upv.AddLetter(upv.AddressAt(4), upv.AddressAt(6), 0.77M);
            upv.AddGroundPackage(upv.AddressAt(7), upv.AddressAt(5), 30, 23, 98, 12);
            upv.AddNextDayAirPackage(upv.AddressAt(3), upv.AddressAt(6), 22, 32, 18, 32, 15M);
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
            AddressForm adf = new AddressForm();

            DialogResult result; // Result from dialog - OK/Cancel?
            result = adf.ShowDialog();

            if (result == DialogResult.OK)
            {
                upv.AddAddress(adf.AddressName, adf.Address1, adf.Address2, adf.City, adf.State, adf.Zip);
            }
        }

        /*
         * Preconditions: The insert letter button is clicked.
         * Postcondition: The letter form appears and address is added to the list if necessary.
         */

        private void insertParcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm = new LetterForm(upv.AddressList);

            DialogResult result; // Result from dialog - OK/Cancel?

            result = letterForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                upv.AddLetter(upv.AddressAt(letterForm.From), upv.AddressAt(letterForm.To), letterForm.Cost);
            }
        }

        /*
         * Preconditions: The list addresses button is clicked.
         * Postcondition: The addresses appear in the report.
         */

        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportBox.Text = String.Empty;

            foreach (Address adr in upv.AddressList)
                reportBox.Text += adr.ToString() + Environment.NewLine + Environment.NewLine;
        }


        /*
         * Preconditions: The list addresses button is clicked.
         * Postcondition: The addresses appear in the report.
         */

        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal cost = decimal.Zero;
            reportBox.Text = String.Empty;

            foreach (Parcel parcel in upv.ParcelList)
            {
                reportBox.Text += parcel.ToString() + Environment.NewLine + Environment.NewLine;
                cost += parcel.CalcCost();
            }
            reportBox.Text += $"Total Cost: {cost:C}";
        }
    }
}
