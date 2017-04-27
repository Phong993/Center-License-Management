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

            cbVersionFor.Items.Add("1.0");
            cbVersionFor.Items.Add("1.1");
            cbVersionFor.Items.Add("1.2");

            cbExpirationTime.Items.Add("15 days");
            cbExpirationTime.Items.Add("1 months");
            cbExpirationTime.Items.Add("3 months");
            cbExpirationTime.Items.Add("9 months");

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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.hid)|*.hid";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                tbImportFile.Text = choofdlog.FileName;
                string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true           
            }
        }
        //private void btnCreate_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Tao ra file*.cert");
        //}

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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create *.cert file :D a hi hi");
        }
    }
}
