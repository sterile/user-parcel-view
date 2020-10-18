namespace UPVApp
{
    partial class AddressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.address1Box = new System.Windows.Forms.TextBox();
            this.address2Box = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.stateList = new System.Windows.Forms.ComboBox();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.fieldError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fieldError)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(32, 23);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(74, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(12, 67);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(97, 25);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(54, 179);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(55, 25);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(38, 237);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(68, 25);
            this.stateLabel.TabIndex = 3;
            this.stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(58, 302);
            this.zipLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(48, 25);
            this.zipLabel.TabIndex = 4;
            this.zipLabel.Text = "Zip:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(116, 17);
            this.nameBox.Margin = new System.Windows.Forms.Padding(6);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(342, 31);
            this.nameBox.TabIndex = 5;
            this.nameBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameField_Validating);
            this.nameBox.Validated += new System.EventHandler(this.NameField_Validated);
            // 
            // address1Box
            // 
            this.address1Box.Location = new System.Drawing.Point(116, 67);
            this.address1Box.Margin = new System.Windows.Forms.Padding(6);
            this.address1Box.Name = "address1Box";
            this.address1Box.Size = new System.Drawing.Size(342, 31);
            this.address1Box.TabIndex = 6;
            this.address1Box.Validating += new System.ComponentModel.CancelEventHandler(this.Adr1_Validating);
            this.address1Box.Validated += new System.EventHandler(this.Adr1_Validated);
            // 
            // address2Box
            // 
            this.address2Box.Location = new System.Drawing.Point(116, 113);
            this.address2Box.Margin = new System.Windows.Forms.Padding(6);
            this.address2Box.Name = "address2Box";
            this.address2Box.Size = new System.Drawing.Size(342, 31);
            this.address2Box.TabIndex = 7;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(116, 179);
            this.cityBox.Margin = new System.Windows.Forms.Padding(6);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(342, 31);
            this.cityBox.TabIndex = 8;
            this.cityBox.Validating += new System.ComponentModel.CancelEventHandler(this.City_Validating);
            this.cityBox.Validated += new System.EventHandler(this.City_Validated);
            // 
            // stateList
            // 
            this.stateList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateList.FormattingEnabled = true;
            this.stateList.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AS",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "GU",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "MP",
            "OH",
            "OK",
            "OR",
            "PA",
            "PR",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "VI",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.stateList.Location = new System.Drawing.Point(116, 231);
            this.stateList.Margin = new System.Windows.Forms.Padding(6);
            this.stateList.Name = "stateList";
            this.stateList.Size = new System.Drawing.Size(342, 33);
            this.stateList.TabIndex = 9;
            // 
            // zipBox
            // 
            this.zipBox.Location = new System.Drawing.Point(122, 296);
            this.zipBox.Margin = new System.Windows.Forms.Padding(6);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(336, 31);
            this.zipBox.TabIndex = 10;
            this.zipBox.Validating += new System.ComponentModel.CancelEventHandler(this.Zip_Validating);
            this.zipBox.Validated += new System.EventHandler(this.Zip_Validated);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(312, 379);
            this.okButton.Margin = new System.Windows.Forms.Padding(6);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(150, 44);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(150, 379);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 44);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // fieldError
            // 
            this.fieldError.ContainerControl = this;
            // 
            // AddressForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 452);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.zipBox);
            this.Controls.Add(this.stateList);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.address2Box);
            this.Controls.Add(this.address1Box);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            this.Load += new System.EventHandler(this.AddressForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fieldError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox address1Box;
        private System.Windows.Forms.TextBox address2Box;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.ComboBox stateList;
        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider fieldError;
    }
}