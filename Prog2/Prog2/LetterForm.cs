/*
 * Grading ID: E3780
 * Program: 2
 * Due Date: October 19 2020
 * Course: CIS 200-76
 * Description: Provides backend code for the Letter form.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class LetterForm : Form
    {
        // Address list

        private List<Address> addressList;
        
        // Letter Properties

        internal int From
        {
            /*
             * Preconditions: None
             * Postcondition: Returns the "From" address index
             */

            get => fromBox.SelectedIndex;
        }

        internal int To
        {
            /*
             * Preconditions: None
             * Postcondition: Returns the "To" address index
             */

            get => toBox.SelectedIndex;
        }

        internal decimal Cost
        {
            /*
             * Preconditions: None
             * Postcondition: Returns the cost.
             */

            get => decimal.Parse(costBox.Text);
        }
      
        // Event Handlers

        /*
         * Preconditions: Letter form is initialized
         * Postcondition: Addresses are added to combo boxes
         */

        public LetterForm(List<Address> addresses)
        {
            InitializeComponent();

            addressList = addresses;

            foreach (Address adr in addresses)
            {
                fromBox.Items.Add(adr.Name);
                toBox.Items.Add(adr.Name);
            }
        }

        /*
         * Preconditions: Letter form is loaded
         * Postcondition: Combo boxes default to first address
         */

        private void LetterForm_Load(object sender, EventArgs e)
        {
            fromBox.SelectedIndex = 0;                    // Select first address in list
            toBox.SelectedIndex = addressList.Count - 1;  // Select last address in list
        }

        /*
         * Preconditions: OK button clicked
         * Postcondition: After validation, close form
         */

        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        // Data Validation

        /*
         * Preconditions: Address selcted in to box
         * Postcondition: Address is validated to not be same as "To" address
         */

        private void From_Validating(object sender, CancelEventArgs e)
        {
            if (int.Equals(fromBox.SelectedIndex, toBox.SelectedIndex))
            {
                e.Cancel = true;
                letterErrors.SetError(fromBox, "Sender cannot be receiver!");
            }
        }

        /*
         * Preconditions: From != To
         * Postcondition: Allow form to continue.
         */

        private void From_Validated(object sender, EventArgs e)
        {
            letterErrors.SetError(fromBox, string.Empty); // Clears Error Message
        }


        /*
         * Preconditions: Address selcted in to box
         * Postcondition: Address is validated to not be same as "To" address
         */

        private void To_Validating(object sender, CancelEventArgs e)
        {
            if (int.Equals(fromBox.SelectedIndex, toBox.SelectedIndex))
            {
                e.Cancel = true;
                letterErrors.SetError(toBox, "Receiver cannot be sender!");
            }
        }

        /*
         * Preconditions: From != To
         * Postcondition: Allow form to continue.
         */

        private void To_Validated(object sender, EventArgs e)
        {
            letterErrors.SetError(toBox, string.Empty); // Clears Error Message
        }

        /*
         * Preconditions: Cost entered in text box
         * Postcondition: Cost is validated to be at least 0.
         */

        private void Cost_Validating(object sender, CancelEventArgs e)
        {
            decimal cost;
            bool tryParse;

            tryParse = decimal.TryParse(costBox.Text, out cost);

            if (!tryParse || cost < decimal.Zero)
            {
                e.Cancel = true;
                costBox.SelectAll();
                letterErrors.SetError(costBox, $"Cost must be at least {decimal.Zero:C}");
            }
        }

        /*
         * Preconditions: Cost >= 0.
         * Postcondition: Allow form to continue.
         */

        private void Cost_Validated(object sender, EventArgs e)
        {
            letterErrors.SetError(costBox, string.Empty); // Clears Error Message
        }
    }
}
