namespace UPVApp
{
    partial class LetterForm
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
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.fromBox = new System.Windows.Forms.ComboBox();
            this.toBox = new System.Windows.Forms.ComboBox();
            this.costBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.letterErrors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.letterErrors)).BeginInit();
            this.SuspendLayout();
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(13, 26);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(67, 25);
            this.fromLabel.TabIndex = 0;
            this.fromLabel.Text = "From:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(37, 91);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(43, 25);
            this.toLabel.TabIndex = 1;
            this.toLabel.Text = "To:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(19, 154);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(62, 25);
            this.costLabel.TabIndex = 2;
            this.costLabel.Text = "Cost:";
            // 
            // fromBox
            // 
            this.fromBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromBox.FormattingEnabled = true;
            this.fromBox.Location = new System.Drawing.Point(87, 23);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(367, 33);
            this.fromBox.TabIndex = 3;
            this.fromBox.Validating += new System.ComponentModel.CancelEventHandler(this.From_Validating);
            this.fromBox.Validated += new System.EventHandler(this.From_Validated);
            // 
            // toBox
            // 
            this.toBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toBox.FormattingEnabled = true;
            this.toBox.Location = new System.Drawing.Point(87, 88);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(367, 33);
            this.toBox.TabIndex = 4;
            this.toBox.Validating += new System.ComponentModel.CancelEventHandler(this.To_Validating);
            this.toBox.Validated += new System.EventHandler(this.To_Validated);
            // 
            // costBox
            // 
            this.costBox.Location = new System.Drawing.Point(87, 151);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(367, 31);
            this.costBox.TabIndex = 5;
            this.costBox.Validating += new System.ComponentModel.CancelEventHandler(this.Cost_Validating);
            this.costBox.Validated += new System.EventHandler(this.Cost_Validated);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(307, 206);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(105, 39);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(134, 206);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(104, 39);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // letterErrors
            // 
            this.letterErrors.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 266);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Name = "LetterForm";
            this.Text = "Letter Form";
            this.Load += new System.EventHandler(this.LetterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.letterErrors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.ComboBox fromBox;
        private System.Windows.Forms.ComboBox toBox;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider letterErrors;
    }
}