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
    public delegate void Showmnu();
    public partial class LoginForm : Form
    {
        public event Showmnu evtMnu;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                MessageBox.Show("You must enter username!");
                return;
            }
            //Initialize connection to SQL Server
            ConnectionString connection = new ConnectionString();
            connection.ConnectSqlParam();
            // Check username and password not match
            if(!(connection.CheckLogin(txtUsername.Text,txtPassword.Text)))
            {
                MessageBox.Show("Username or Password incorrect");
            }
            //else if 
            // Check username and password match
            else
            {
                MainForm mainForm = new MainForm();
                evtMnu();
                this.Close();
            }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
