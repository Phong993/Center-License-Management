using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CenterLicenseManager
{
    public partial class MainForm : Form
    {
        public string uName;
        public MainForm()
        {
            InitializeComponent();
            LoginForm loginForm = new LoginForm();
            loginForm.MdiParent = this;

            //Delegate from Login Form
            loginForm.evtMnu += new Showmnu(EnableMenu);
            loginForm.pun = new Passusername(showUName);
            loginForm.Show();
            
        }
        
        private void EnableMenu()
        {
            this.createLicenseToolStripMenuItem.Enabled = true;
            this.transferLicenseToolStripMenuItem.Enabled = true;
            this.terminateLicenseToolStripMenuItem.Enabled = true;
        }

        private void showUName(object sender)
        {            
            menuStrip1.Items.Add((string)sender);
            label1.Text = (string)sender;
            TempSystem.UserName = label1.Text;    //Temp Table for store username        
        }
      

        private void createLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateLicense frmCreateLicense = new FormCreateLicense();
            frmCreateLicense.MdiParent = this;
            frmCreateLicense.Show();
        }

        private void transferLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransferLicense frmTransferLicense = new FormTransferLicense();
            frmTransferLicense.MdiParent = this;
            frmTransferLicense.Show();
        }

        private void terminateLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTerminateLicense frmTerminateLicense = new FormTerminateLicense();
            frmTerminateLicense.MdiParent = this;
            frmTerminateLicense.Show();
        }
    }
}
