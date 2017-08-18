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
            
            connectionString = "Data Source=192.168.9.24\\SQLExpress;Initial Catalog=LICENSE INFO;User ID=license_admin;Password=Hoabinh123";
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

        public bool checkDuplicateUser(string customerName)
        {
            SqlCommand cmd = new SqlCommand("SELECT customer_name from LIC_INFO where customer_name = '" + customerName + "'",this.cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count>0)
            { return true; }
            else { return false; }
            this.cnn.Close();
        }

        public void insertInfo(string customerName, string address, string licensefor, string versionfor, string expireday, string hid, string createdBy)
        {
            SqlCommand cmd = new SqlCommand("Insert into LIC_INFO(CUSTOMER_NAME,ADDRESS,LICENSE_FOR,VERSION_FOR,EXPIRE_DAY,HID,STATUS,CREATED_BY,CREATED_DAY) VALUES('" 
                + customerName + "','" + address + "','" + licensefor + "','" + versionfor + "','" + expireday + "','" + hid + "','1','" 
                + createdBy + "',GETDATE())", this.cnn);

            cmd.ExecuteNonQuery();
        }
    }
}
