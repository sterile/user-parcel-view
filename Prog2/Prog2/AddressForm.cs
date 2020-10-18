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
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();
        }

        internal Address newAddress
        {
            get
            {
                int.TryParse(zipBox.Text, out int zip);
                return new Address(nameBox.Text, address1Box.Text, address2Box.Text, cityBox.Text, stateList.SelectedText, zip);
            }
        }
        
        private void NameField_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nameBox.Text)) {
                e.Cancel = true;
                fieldError.SetError(nameBox, "Name must not be empty!");
            }
        }

        private void NameField_Validated(object sender, EventArgs e)
        {
            fieldError.SetError(nameBox, string.Empty); // Clears Error Message
        }

        private void Adr1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(address1Box.Text))
            {
                e.Cancel = true;
                fieldError.SetError(address1Box, "Address must not be empty!");
            }
        }
        private void Adr1_Validated(object sender, EventArgs e)
        {
            fieldError.SetError(address1Box, string.Empty); // Clears Error Message
        }

        private void City_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cityBox.Text))
            {
                e.Cancel = true;
                fieldError.SetError(cityBox, "City must not be empty!");
            }
        }

        private void City_Validated(object sender, EventArgs e)
        {
            fieldError.SetError(cityBox, string.Empty); // Clears Error Message
        }

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

        private void Zip_Validated(object sender, EventArgs e)
        {
            fieldError.SetError(zipBox, String.Empty);
        }


        private void AddressForm_Load(object sender, EventArgs e)
        {
            // Set an initial state to avoid crashing the form
            const int ZERO = 0; // First index
            stateList.SelectedIndex = ZERO;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
    }
}
