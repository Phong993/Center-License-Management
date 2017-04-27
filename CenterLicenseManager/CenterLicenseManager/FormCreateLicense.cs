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
    public partial class FormCreateLicense : Form
    {
        public FormCreateLicense()
        {
            InitializeComponent();
            cbLicenseFor.Items.Add("Phuoc");
            cbLicenseFor.Items.Add("Tai");
            cbLicenseFor.Items.Add("Phong");

            cbVersionFor.Items.Add("Phuoc");
            cbVersionFor.Items.Add("Tai");
            cbVersionFor.Items.Add("Phong");

            this.tbCustomerName.TextChanged += new EventHandler(this.btnCreate_Hightlighted);
            this.tbAddress.TextChanged += new EventHandler(this.btnCreate_Hightlighted);
            this.cbLicenseFor.TextChanged += new EventHandler(this.btnCreate_Hightlighted);
            this.cbVersionFor.TextChanged += new EventHandler(this.btnCreate_Hightlighted);
            this.cbExpirationTime.TextChanged += new EventHandler(this.btnCreate_Hightlighted);
            this.tbImportFile.TextChanged += new EventHandler(this.btnCreate_Hightlighted);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.txt)|*.txt";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                tbImportFile.Text = choofdlog.FileName;
                string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true           
            }
        }

        private void btnCreate_Hightlighted(object sender, EventArgs e)
        {
            if (tbCustomerName.Text != "" && 
                tbAddress.Text != "" &&
                cbLicenseFor.Text != "" && 
                cbVersionFor.Text != "" &&
                cbExpirationTime.Text != "" &&
                tbImportFile.Text != "")
            {
                btnCreate.Enabled = true;
            }
            else
                btnCreate.Enabled = false;
        }

        private void grpCreateLicense_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbCustomerName.Text = "";
            tbAddress.Text = "";
            cbLicenseFor.Text = "";
            cbVersionFor.Text = "";
            cbExpirationTime.Text = "";
            tbImportFile.Text = "";
        }
    }
}
