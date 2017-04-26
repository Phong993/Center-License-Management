namespace CenterLicenseManager
{
    partial class FormCreateLicense
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
            this.txtCreateLicense = new System.Windows.Forms.Label();
            this.grpCreateLicense = new System.Windows.Forms.GroupBox();
            this.txtCustomerName = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtLicenseFor = new System.Windows.Forms.Label();
            this.cbLicenseFor = new System.Windows.Forms.ComboBox();
            this.txtVersionFor = new System.Windows.Forms.Label();
            this.cbVersionFor = new System.Windows.Forms.ComboBox();
            this.txtExpirationTime = new System.Windows.Forms.Label();
            this.cbExpirationTime = new System.Windows.Forms.ComboBox();
            this.txtImportFile = new System.Windows.Forms.Label();
            this.tbImportFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpCreateLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCreateLicense
            // 
            this.txtCreateLicense.AutoSize = true;
            this.txtCreateLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateLicense.Location = new System.Drawing.Point(12, 9);
            this.txtCreateLicense.Name = "txtCreateLicense";
            this.txtCreateLicense.Size = new System.Drawing.Size(92, 13);
            this.txtCreateLicense.TabIndex = 0;
            this.txtCreateLicense.Text = "Create License";
            this.txtCreateLicense.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpCreateLicense
            // 
            this.grpCreateLicense.Controls.Add(this.btnClear);
            this.grpCreateLicense.Controls.Add(this.btnCreate);
            this.grpCreateLicense.Controls.Add(this.btnBrowse);
            this.grpCreateLicense.Controls.Add(this.cbExpirationTime);
            this.grpCreateLicense.Controls.Add(this.cbVersionFor);
            this.grpCreateLicense.Controls.Add(this.txtExpirationTime);
            this.grpCreateLicense.Controls.Add(this.cbLicenseFor);
            this.grpCreateLicense.Controls.Add(this.txtVersionFor);
            this.grpCreateLicense.Controls.Add(this.tbImportFile);
            this.grpCreateLicense.Controls.Add(this.textBox2);
            this.grpCreateLicense.Controls.Add(this.txtImportFile);
            this.grpCreateLicense.Controls.Add(this.txtLicenseFor);
            this.grpCreateLicense.Controls.Add(this.txtAddress);
            this.grpCreateLicense.Controls.Add(this.tbCustomerName);
            this.grpCreateLicense.Controls.Add(this.txtCustomerName);
            this.grpCreateLicense.Location = new System.Drawing.Point(-1, 25);
            this.grpCreateLicense.Name = "grpCreateLicense";
            this.grpCreateLicense.Size = new System.Drawing.Size(398, 250);
            this.grpCreateLicense.TabIndex = 1;
            this.grpCreateLicense.TabStop = false;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AutoSize = true;
            this.txtCustomerName.Location = new System.Drawing.Point(6, 19);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(85, 13);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.Text = "Customer Name:";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(97, 16);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(169, 20);
            this.tbCustomerName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.AutoSize = true;
            this.txtAddress.Location = new System.Drawing.Point(43, 45);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(48, 13);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.Text = "Address:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 1;
            // 
            // txtLicenseFor
            // 
            this.txtLicenseFor.AutoSize = true;
            this.txtLicenseFor.Location = new System.Drawing.Point(29, 72);
            this.txtLicenseFor.Name = "txtLicenseFor";
            this.txtLicenseFor.Size = new System.Drawing.Size(62, 13);
            this.txtLicenseFor.TabIndex = 0;
            this.txtLicenseFor.Text = "License for:";
            // 
            // cbLicenseFor
            // 
            this.cbLicenseFor.FormattingEnabled = true;
            this.cbLicenseFor.Location = new System.Drawing.Point(97, 69);
            this.cbLicenseFor.Name = "cbLicenseFor";
            this.cbLicenseFor.Size = new System.Drawing.Size(169, 21);
            this.cbLicenseFor.TabIndex = 2;
            // 
            // txtVersionFor
            // 
            this.txtVersionFor.AutoSize = true;
            this.txtVersionFor.Location = new System.Drawing.Point(29, 99);
            this.txtVersionFor.Name = "txtVersionFor";
            this.txtVersionFor.Size = new System.Drawing.Size(60, 13);
            this.txtVersionFor.TabIndex = 0;
            this.txtVersionFor.Text = "Version for:";
            // 
            // cbVersionFor
            // 
            this.cbVersionFor.FormattingEnabled = true;
            this.cbVersionFor.Location = new System.Drawing.Point(97, 96);
            this.cbVersionFor.Name = "cbVersionFor";
            this.cbVersionFor.Size = new System.Drawing.Size(169, 21);
            this.cbVersionFor.TabIndex = 2;
            // 
            // txtExpirationTime
            // 
            this.txtExpirationTime.AutoSize = true;
            this.txtExpirationTime.Location = new System.Drawing.Point(6, 126);
            this.txtExpirationTime.Name = "txtExpirationTime";
            this.txtExpirationTime.Size = new System.Drawing.Size(82, 13);
            this.txtExpirationTime.TabIndex = 0;
            this.txtExpirationTime.Text = "Expiration Time:";
            // 
            // cbExpirationTime
            // 
            this.cbExpirationTime.FormattingEnabled = true;
            this.cbExpirationTime.Location = new System.Drawing.Point(97, 123);
            this.cbExpirationTime.Name = "cbExpirationTime";
            this.cbExpirationTime.Size = new System.Drawing.Size(169, 21);
            this.cbExpirationTime.TabIndex = 2;
            // 
            // txtImportFile
            // 
            this.txtImportFile.AutoSize = true;
            this.txtImportFile.Location = new System.Drawing.Point(9, 153);
            this.txtImportFile.Name = "txtImportFile";
            this.txtImportFile.Size = new System.Drawing.Size(79, 13);
            this.txtImportFile.TabIndex = 0;
            this.txtImportFile.Text = "Import *.hid file:";
            // 
            // tbImportFile
            // 
            this.tbImportFile.Location = new System.Drawing.Point(97, 150);
            this.tbImportFile.Name = "tbImportFile";
            this.tbImportFile.Size = new System.Drawing.Size(169, 20);
            this.tbImportFile.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(180, 176);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(74, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(111, 219);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(74, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(192, 219);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // FormCreateLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 282);
            this.Controls.Add(this.grpCreateLicense);
            this.Controls.Add(this.txtCreateLicense);
            this.Name = "FormCreateLicense";
            this.Text = "Create License";
            this.grpCreateLicense.ResumeLayout(false);
            this.grpCreateLicense.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCreateLicense;
        private System.Windows.Forms.GroupBox grpCreateLicense;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cbExpirationTime;
        private System.Windows.Forms.ComboBox cbVersionFor;
        private System.Windows.Forms.Label txtExpirationTime;
        private System.Windows.Forms.ComboBox cbLicenseFor;
        private System.Windows.Forms.Label txtVersionFor;
        private System.Windows.Forms.TextBox tbImportFile;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtImportFile;
        private System.Windows.Forms.Label txtLicenseFor;
        private System.Windows.Forms.Label txtAddress;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label txtCustomerName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
    }
}