namespace UPVApp
{
    partial class Prog2Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertParcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAddressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listParcelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1134, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(214, 44);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(214, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertAddressToolStripMenuItem,
            this.insertParcelToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(94, 36);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // insertAddressToolStripMenuItem
            // 
            this.insertAddressToolStripMenuItem.Name = "insertAddressToolStripMenuItem";
            this.insertAddressToolStripMenuItem.Size = new System.Drawing.Size(233, 44);
            this.insertAddressToolStripMenuItem.Text = "Address";
            this.insertAddressToolStripMenuItem.Click += new System.EventHandler(this.insertAddressToolStripMenuItem_Click);
            // 
            // insertParcelToolStripMenuItem
            // 
            this.insertParcelToolStripMenuItem.Name = "insertParcelToolStripMenuItem";
            this.insertParcelToolStripMenuItem.Size = new System.Drawing.Size(233, 44);
            this.insertParcelToolStripMenuItem.Text = "Letter";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAddressesToolStripMenuItem,
            this.listParcelsToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(105, 36);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // listAddressesToolStripMenuItem
            // 
            this.listAddressesToolStripMenuItem.Name = "listAddressesToolStripMenuItem";
            this.listAddressesToolStripMenuItem.Size = new System.Drawing.Size(298, 44);
            this.listAddressesToolStripMenuItem.Text = "List Addresses";
            // 
            // listParcelsToolStripMenuItem
            // 
            this.listParcelsToolStripMenuItem.Name = "listParcelsToolStripMenuItem";
            this.listParcelsToolStripMenuItem.Size = new System.Drawing.Size(298, 44);
            this.listParcelsToolStripMenuItem.Text = "List Parcels";
            // 
            // reportBox
            // 
            this.reportBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportBox.Location = new System.Drawing.Point(0, 44);
            this.reportBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.reportBox.Multiline = true;
            this.reportBox.Name = "reportBox";
            this.reportBox.ReadOnly = true;
            this.reportBox.Size = new System.Drawing.Size(1134, 731);
            this.reportBox.TabIndex = 1;
            this.reportBox.Text = "Waiting for report...";
            // 
            // Prog2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 775);
            this.Controls.Add(this.reportBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Prog2Form";
            this.Text = "User Parcel View";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAddressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listParcelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertParcelToolStripMenuItem;
        private System.Windows.Forms.TextBox reportBox;
    }
}

