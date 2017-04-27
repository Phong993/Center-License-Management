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
    public partial class FormTransferLicense : Form
    {
        public FormTransferLicense()
        {
            InitializeComponent();
            cbAddress.Items.Add("diachi1");
            cbAddress.Items.Add("diachi2");
            cbAddress.Items.Add("diachi3");
            cbVersionFor.Items.Add("phien ban 1");
            cbVersionFor.Items.Add("phien ban 2");
            cbVersionFor.Items.Add("phien ban 3");
            cbExpirationTime.Items.Add("15 day");
            cbExpirationTime.Items.Add("1 month");

            this.tbCustomerName.TextChanged += new EventHandler(this.btnTransfer_Hightlighted);
            this.cbAddress.TextChanged += new EventHandler(this.btnTransfer_Hightlighted);
            this.cbVersionFor.TextChanged += new EventHandler(this.btnTransfer_Hightlighted);
            this.cbExpirationTime.TextChanged += new EventHandler(this.btnTransfer_Hightlighted);
            this.tbImportFileHid.TextChanged += new EventHandler(this.btnTransfer_Hightlighted);
            this.tbImportFileTer.TextChanged += new EventHandler(this.btnTransfer_Hightlighted);

        }
        private void btnTransfer_Hightlighted(object sender, EventArgs e)
        {
            if (tbCustomerName.Text != "" &&
                cbAddress.Text != "" &&
                cbVersionFor.Text != "" &&
                cbAddress.Text != "" &&
                cbExpirationTime.Text != "" &&
                tbImportFileHid.Text != "" &&
                tbImportFileTer.Text != "")
            {
                btnTransfer.Enabled = true;
            }
            else
                btnTransfer.Enabled = false;
        }
        private void FormTransferLicense_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowseTer_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.ter)|*.ter";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                tbImportFileTer.Text = choofdlog.FileName;
                string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true           
            }
        }

        private void btnBrowseHid_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.hid)|*.hid";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                tbImportFileHid.Text = choofdlog.FileName;
                string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true           
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbCustomerName.Text = "";
            cbAddress.Text = "";
            cbVersionFor.Text = "";
            cbAddress.Text = "";
            cbExpirationTime.Text = "";
            tbImportFileHid.Text = "";
            tbImportFileTer.Text = "";
        }
    }
}
