namespace CenterLicenseManager
{
    partial class FormTransferLicense
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
            this.txtTransferLicense = new System.Windows.Forms.Label();
            this.grpTransferLicense = new System.Windows.Forms.GroupBox();
            this.cbExpirationTime = new System.Windows.Forms.ComboBox();
            this.cbVersionFor = new System.Windows.Forms.ComboBox();
            this.cbAddress = new System.Windows.Forms.ComboBox();
            this.txtExpirationTime = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBrowseHid = new System.Windows.Forms.Button();
            this.btnBrowseTer = new System.Windows.Forms.Button();
            this.txtVersionFor = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.Label();
            this.tbImportFileHid = new System.Windows.Forms.TextBox();
            this.txtImportFileHid = new System.Windows.Forms.Label();
            this.tbImportFileTer = new System.Windows.Forms.TextBox();
            this.txtImportFileTer = new System.Windows.Forms.Label();
            this.grpTransferLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTransferLicense
            // 
            this.txtTransferLicense.AutoSize = true;
            this.txtTransferLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransferLicense.Location = new System.Drawing.Point(13, 13);
            this.txtTransferLicense.Name = "txtTransferLicense";
            this.txtTransferLicense.Size = new System.Drawing.Size(102, 13);
            this.txtTransferLicense.TabIndex = 0;
            this.txtTransferLicense.Text = "Transfer License";
            // 
            // grpTransferLicense
            // 
            this.grpTransferLicense.Controls.Add(this.cbExpirationTime);
            this.grpTransferLicense.Controls.Add(this.cbVersionFor);
            this.grpTransferLicense.Controls.Add(this.cbAddress);
            this.grpTransferLicense.Controls.Add(this.txtExpirationTime);
            this.grpTransferLicense.Controls.Add(this.btnTransfer);
            this.grpTransferLicense.Controls.Add(this.btnClear);
            this.grpTransferLicense.Controls.Add(this.btnBrowseHid);
            this.grpTransferLicense.Controls.Add(this.btnBrowseTer);
            this.grpTransferLicense.Controls.Add(this.txtVersionFor);
            this.grpTransferLicense.Controls.Add(this.tbCustomerName);
            this.grpTransferLicense.Controls.Add(this.txtAddress);
            this.grpTransferLicense.Controls.Add(this.txtCustomerName);
            this.grpTransferLicense.Controls.Add(this.tbImportFileHid);
            this.grpTransferLicense.Controls.Add(this.txtImportFileHid);
            this.grpTransferLicense.Controls.Add(this.tbImportFileTer);
            this.grpTransferLicense.Controls.Add(this.txtImportFileTer);
            this.grpTransferLicense.Enabled = false;
            this.grpTransferLicense.Location = new System.Drawing.Point(12, 29);
            this.grpTransferLicense.Name = "grpTransferLicense";
            this.grpTransferLicense.Size = new System.Drawing.Size(276, 290);
            this.grpTransferLicense.TabIndex = 1;
            this.grpTransferLicense.TabStop = false;
            // 
            // cbExpirationTime
            // 
            this.cbExpirationTime.Enabled = false;
            this.cbExpirationTime.FormattingEnabled = true;
            this.cbExpirationTime.Location = new System.Drawing.Point(100, 152);
            this.cbExpirationTime.Name = "cbExpirationTime";
            this.cbExpirationTime.Size = new System.Drawing.Size(163, 21);
            this.cbExpirationTime.TabIndex = 3;
            // 
            // cbVersionFor
            // 
            this.cbVersionFor.Enabled = false;
            this.cbVersionFor.FormattingEnabled = true;
            this.cbVersionFor.Location = new System.Drawing.Point(100, 125);
            this.cbVersionFor.Name = "cbVersionFor";
            this.cbVersionFor.Size = new System.Drawing.Size(163, 21);
            this.cbVersionFor.TabIndex = 3;
            // 
            // cbAddress
            // 
            this.cbAddress.Enabled = false;
            this.cbAddress.FormattingEnabled = true;
            this.cbAddress.Location = new System.Drawing.Point(100, 95);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(163, 21);
            this.cbAddress.TabIndex = 3;
            // 
            // txtExpirationTime
            // 
            this.txtExpirationTime.AutoSize = true;
            this.txtExpirationTime.Enabled = false;
            this.txtExpirationTime.Location = new System.Drawing.Point(12, 155);
            this.txtExpirationTime.Name = "txtExpirationTime";
            this.txtExpirationTime.Size = new System.Drawing.Size(82, 13);
            this.txtExpirationTime.TabIndex = 0;
            this.txtExpirationTime.Text = "Expiration Time:";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(107, 245);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(75, 23);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(188, 245);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnBrowseHid
            // 
            this.btnBrowseHid.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBrowseHid.ForeColor = System.Drawing.Color.White;
            this.btnBrowseHid.Location = new System.Drawing.Point(188, 205);
            this.btnBrowseHid.Name = "btnBrowseHid";
            this.btnBrowseHid.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseHid.TabIndex = 2;
            this.btnBrowseHid.Text = "Browse";
            this.btnBrowseHid.UseVisualStyleBackColor = false;
            // 
            // btnBrowseTer
            // 
            this.btnBrowseTer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBrowseTer.ForeColor = System.Drawing.Color.White;
            this.btnBrowseTer.Location = new System.Drawing.Point(185, 34);
            this.btnBrowseTer.Name = "btnBrowseTer";
            this.btnBrowseTer.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseTer.TabIndex = 2;
            this.btnBrowseTer.Text = "Browse";
            this.btnBrowseTer.UseVisualStyleBackColor = false;
            // 
            // txtVersionFor
            // 
            this.txtVersionFor.AutoSize = true;
            this.txtVersionFor.Enabled = false;
            this.txtVersionFor.Location = new System.Drawing.Point(34, 128);
            this.txtVersionFor.Name = "txtVersionFor";
            this.txtVersionFor.Size = new System.Drawing.Size(60, 13);
            this.txtVersionFor.TabIndex = 0;
            this.txtVersionFor.Text = "Version for:";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Enabled = false;
            this.tbCustomerName.Location = new System.Drawing.Point(100, 71);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(163, 20);
            this.tbCustomerName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.AutoSize = true;
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(46, 98);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(48, 13);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.Text = "Address:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AutoSize = true;
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Location = new System.Drawing.Point(9, 74);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(85, 13);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.Text = "Customer Name:";
            // 
            // tbImportFileHid
            // 
            this.tbImportFileHid.Enabled = false;
            this.tbImportFileHid.Location = new System.Drawing.Point(100, 179);
            this.tbImportFileHid.Name = "tbImportFileHid";
            this.tbImportFileHid.Size = new System.Drawing.Size(163, 20);
            this.tbImportFileHid.TabIndex = 1;
            // 
            // txtImportFileHid
            // 
            this.txtImportFileHid.AutoSize = true;
            this.txtImportFileHid.Enabled = false;
            this.txtImportFileHid.Location = new System.Drawing.Point(17, 182);
            this.txtImportFileHid.Name = "txtImportFileHid";
            this.txtImportFileHid.Size = new System.Drawing.Size(79, 13);
            this.txtImportFileHid.TabIndex = 0;
            this.txtImportFileHid.Text = "Import *.hid file:";
            // 
            // tbImportFileTer
            // 
            this.tbImportFileTer.Location = new System.Drawing.Point(97, 8);
            this.tbImportFileTer.Name = "tbImportFileTer";
            this.tbImportFileTer.Size = new System.Drawing.Size(163, 20);
            this.tbImportFileTer.TabIndex = 1;
            // 
            // txtImportFileTer
            // 
            this.txtImportFileTer.AutoSize = true;
            this.txtImportFileTer.Location = new System.Drawing.Point(17, 11);
            this.txtImportFileTer.Name = "txtImportFileTer";
            this.txtImportFileTer.Size = new System.Drawing.Size(74, 13);
            this.txtImportFileTer.TabIndex = 0;
            this.txtImportFileTer.Text = "Import *.ter file";
            // 
            // FormTransferLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 341);
            this.Controls.Add(this.grpTransferLicense);
            this.Controls.Add(this.txtTransferLicense);
            this.Name = "FormTransferLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer License";
            this.Load += new System.EventHandler(this.FormTransferLicense_Load);
            this.grpTransferLicense.ResumeLayout(false);
            this.grpTransferLicense.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTransferLicense;
        private System.Windows.Forms.GroupBox grpTransferLicense;
        private System.Windows.Forms.ComboBox cbExpirationTime;
        private System.Windows.Forms.ComboBox cbVersionFor;
        private System.Windows.Forms.ComboBox cbAddress;
        private System.Windows.Forms.Label txtExpirationTime;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBrowseHid;
        private System.Windows.Forms.Button btnBrowseTer;
        private System.Windows.Forms.Label txtVersionFor;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label txtAddress;
        private System.Windows.Forms.Label txtCustomerName;
        private System.Windows.Forms.TextBox tbImportFileHid;
        private System.Windows.Forms.Label txtImportFileHid;
        private System.Windows.Forms.TextBox tbImportFileTer;
        private System.Windows.Forms.Label txtImportFileTer;
    }
}