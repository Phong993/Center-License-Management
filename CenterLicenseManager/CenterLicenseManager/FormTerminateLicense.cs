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
    public partial class FormTerminateLicense : Form
    {
        public FormTerminateLicense()
        {
            InitializeComponent();
        }

        private void FormTerminateLicense_Load(object sender, EventArgs e)
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }
    }
}
