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
    public partial class LetterForm : Form
    {
        private List<Address> addressList;
        internal Letter newLetter
        {
            get
            {
                decimal.TryParse(costBox.Text, out decimal cost);
                return new Letter(addressList[fromBox.SelectedIndex], addressList[toBox.SelectedIndex], cost);
            }
        }
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

        private void LetterForm_Load(object sender, EventArgs e)
        {
            const int ZERO = 0;
            fromBox.SelectedIndex = ZERO;
            toBox.SelectedIndex = ZERO;
        }

        private void To_Validating(object sender, CancelEventArgs e)
        {
            if (int.Equals(fromBox.SelectedIndex, toBox.SelectedIndex))
            {
                e.Cancel = true;
                letterErrors.SetError(toBox, "Cannot send letter to sender!");
            }
        }
        private void To_Validated(object sender, EventArgs e)
        {
            letterErrors.SetError(toBox, string.Empty); // Clears Error Message
        }

        private void Cost_Validating(object sender, CancelEventArgs e)
        {
            decimal cost;
            bool tryParse;

            tryParse = decimal.TryParse(costBox.Text, out cost);

            if (!tryParse || cost < decimal.Zero)
            {
                e.Cancel = true;
                letterErrors.SetError(costBox, $"Cost must be at least {decimal.Zero:C}");
            }
        }

        private void Cost_Validated(object sender, EventArgs e)
        {
            letterErrors.SetError(costBox, string.Empty); // Clears Error Message
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
    }
}
