using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace CenterLicenseManager
{
    class ConnectionString
    {
        SqlConnection cnn;
        public void ConnectSqlParam()
        {
            string connectionString = null;
            
            connectionString = "Data Source=192.168.9.20\\SQLExpress;Initial Catalog=LICENSE INFO;User ID=license_admin;Password=Hoabinh123";
            cnn = new SqlConnection(connectionString);
            try
            {
                this.cnn.Open();
               
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cannot open connection" + ex);
            }
        }

        public bool CheckLogin(string username, string password)
        {
            SqlCommand cmd = new SqlCommand("SELECT username, password from AUT_USER where username = '" 
                + username + "' and password = '" + password + "'",this.cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            { return true; }
            else { return false; }
            this.cnn.Close();             
        }
    }
}
