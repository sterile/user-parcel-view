/*
 * Grading ID: E3780
 * Program: 2
 * Due Date: October 19 2020
 * Course: CIS 200-76
 * Description: Provides backend code for the Address form.
 */

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class AddressForm : Form
    {

        // Event Handlers

        /*
         * Preconditions: Form is initialized
         * Postcondition: Form is loaded
         */

        public AddressForm()
        {
            InitializeComponent();
        }

        /*
         * Preconditions: Form is loaded
         * Postcondition: State is initialized to first value
         */

        private void AddressForm_Load(object sender, EventArgs e)
        {
            // Set an initial state to avoid crashing the form
            const int ZERO = 0; // First index
            stateList.SelectedIndex = ZERO;
        }

        /*
         * Preconditions: OK button is clicked
         * Postcondition: Window closes if fields are valid
         */

        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        // Address Property

        internal Address newAddress
        {
            /*
             * Preconditions: None
             * Postcondition: Return address
             */

            get
            {
                int.TryParse(zipBox.Text, out int zip);
                return new Address(nameBox.Text, address1Box.Text, address2Box.Text, cityBox.Text, stateList.Text, zip);
            }
        }
        
        // Field Validation

        /*
         * Preconditions: Data entered in name field
         * Postcondition: Name is validated to not be empty
         */

        private void NameField_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nameBox.Text)) {
                e.Cancel = true;
                fieldError.SetError(nameBox, "Name must not be empty!");
            }
        }

        /*
         * Preconditions: Data is not empty
         * Postcondition: Form allowed to continue
         */

        private void NameField_Validated(object sender, EventArgs e)
        {
            fieldError.SetError(nameBox, string.Empty); // Clears Error Message
        }

        /*
         * Preconditions: Data entered in address field
         * Postcondition: Address is validated to not be empty
         */

        private void Adr1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(address1Box.Text))
            {
                e.Cancel = true;
                fieldError.SetError(address1Box, "Address must not be empty!");
            }
        }

        /*
         * Preconditions: Data is not empty
         * Postcondition: Form allowed to continue
         */

        private void Adr1_Validated(object sender, EventArgs e)
        {
            fieldError.SetError(address1Box, string.Empty); // Clears Error Message
        }

        /*
         * Preconditions: Data entered in city field
         * Postcondition: City is validated to not be empty
         */

        private void City_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cityBox.Text))
            {
                e.Cancel = true;
                fieldError.SetError(cityBox, "City must not be empty!");
            }
        }

        /*
         * Preconditions: Data is not empty
         * Postcondition: Form allowed to continue
         */

        private void City_Validated(object sender, EventArgs e)
        {
            fieldError.SetError(cityBox, string.Empty); // Clears Error Message
        }

        /*
         * Preconditions: Data entered in zip field
         * Postcondition: Zip is validated to not be empty
         */

        private void Zip_Validating(object sender, CancelEventArgs e)
        {
            int zip;
            const int MAX_ZIP = 99999,
                MIN_ZIP = 0;
            bool textToInt;

            textToInt = int.TryParse(zipBox.Text, out zip);
            if (!textToInt || zip < MIN_ZIP || zip > MAX_ZIP)
            {
                e.Cancel = true;
                fieldError.SetError(zipBox, "Invalid ZIP provided.");
            }
        }

        /*
         * Preconditions: Data is not empty
         * Postcondition: Form allowed to continue
         */

        private void Zip_Validated(object sender, EventArgs e)
        {
            fieldError.SetError(zipBox, String.Empty);
        }
    }
}
