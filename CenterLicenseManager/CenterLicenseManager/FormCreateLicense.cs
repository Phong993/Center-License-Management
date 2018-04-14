using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CenterLicenseManager
{
    
    public partial class FormCreateLicense : Form
    {
        Dictionary<String, String> mAddinNameList;
        Dictionary<String, String> mVersionList;
        string SQLHID;
        string strCode;        
        
        const string TRIDES_KEY = "NaQ8K@t59#ZaQ21!Mgu=";
        const string EXTRA_KEY = ".Bg19@1F8d=";
        public FormCreateLicense()
        {
            InitializeComponent();
            this.createAddinList();
            this.createVersionList();
            this.initExpirationTimeList();
            this.initAddinNameList();
            this.initVersionList();
            //MessageBox.Show(TempSystem.UserName);
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
        private TripleDES CreateDES(string key)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            TripleDES des = new TripleDESCryptoServiceProvider();
            des.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(key));
            des.IV = new byte[des.BlockSize / 8];
            md5.Clear();
            return des;
        }
        private void checkCustomerName(string customerName)
        {
            

        }
        private void genSerialKey()
        {
            try
            {
                FileStream fs = new FileStream(this.tbImportFile.Text, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fs);
                strCode = reader.ReadToEnd();
                SQLHID = strCode;
                reader.Close();                
            }
            catch
            {
                MessageBox.Show("Please insert a *.HID file.");
				return;
            }
                   
            //Get file name
            string filename = Path.GetFileName(this.tbImportFile.Text);
            int index = filename.IndexOf(".");
            if (index > 0)
                filename = filename.Substring(0, index);            

            AddinNameItem item = this.cbLicenseFor.SelectedItem as AddinNameItem;
            VersionItem itemver = this.cbVersionFor.SelectedItem as VersionItem;

            strCode = strCode + item.Value + itemver.Value + "|" + this.createExpiredTime();

            String randomKey = this.randomKey() + EXTRA_KEY;
            strCode = this.encodeByDES(strCode, randomKey);

            strCode = strCode + "." + this.encodeByDES(randomKey, TRIDES_KEY);
			//FolderBrowserDialog openFileDiaglog = new FolderBrowserDialog();
			SaveFileDialog openFileDiaglog = new SaveFileDialog();
			openFileDiaglog.Filter = "All Files (*.cert)|*.cert";
			openFileDiaglog.FileName = filename;
			if (openFileDiaglog.ShowDialog() == DialogResult.OK)
            {
                string filePath = Path.Combine(openFileDiaglog.FileName/*,filename+".cert"*/);

				FileStream fscert = new FileStream(filePath, FileMode.Create, FileAccess.Write);
				StreamWriter writer = new StreamWriter(fscert);
				writer.Write(strCode);
				writer.Close();

				ConnectionString connection = new ConnectionString();
				connection.ConnectSqlParam();
				connection.insertInfo(tbCustomerName.Text, tbAddress.Text, this.cbLicenseFor.SelectedItem.ToString(), cbVersionFor.SelectedItem.ToString()
						, cbExpirationTime.SelectedItem.ToString(), SQLHID, TempSystem.UserName);
				//if (!File.Exists(filePath))
    //            {                    
    //            }
    //            else
    //            {
    //                MessageBox.Show("File " + filename + ".cert already exists.");
    //            }
            }

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            ConnectionString connection = new ConnectionString();
            connection.ConnectSqlParam();            
            try
            {
                if (!(connection.checkDuplicateUser(tbCustomerName.Text)))
                {                    
                    genSerialKey();                    
                }
                else { MessageBox.Show("Customer Name is already exitst."); }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private String encodeByDES(String pText, String pKey)
        {
            byte[] toEncryptArray = UTF8Encoding.Unicode.GetBytes(pText);
            TripleDES cryptic = CreateDES(pKey);
            byte[] resultArray = cryptic.CreateEncryptor().TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        private String randomKey(int len = 8)
        {
            String strChar = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Random rnd = new Random();
            String key = "";
            int k = 0;
            while (k < len)
            {
                int pos = rnd.Next(0, strChar.Length - 1);
                String ch = strChar[pos].ToString();
                if (key.Contains(ch))
                    continue;
                key += ch;
                k++;
            }

            return key;
        }
        private void createAddinList()
        {
            this.mAddinNameList = new Dictionary<string, string>();

            //this.mAddinNameList.Add("d578b210-3fa4-4528-9a6a-6ca60bbd51d3", "Rebar Detailing");
            //this.mAddinNameList.Add("cbbd3d14-d9f6-454f-8349-3237847ccfd4", "Sheet Maker - Duplicate View - Align View");
            //this.mAddinNameList.Add("e6ffda32-58f8-4e88-b19c-8123bf45e2fa", "Formwork Area");
            //this.mAddinNameList.Add("483ada3a-a4ff-4f59-9c71-4189d0dfffcc", "Export/Import Schedule To/From Excel");
            this.mAddinNameList.Add("18bca09b-da16-4171-a955-7692d0e3713f", "Element Locate 2017");
            this.mAddinNameList.Add("647fb033-66e1-45c9-8ea7-4e7c7cc00692", "TotalRebar - MutipleSelect 2017");
            this.mAddinNameList.Add("e4f0facc-6828-43a1-9213-30ae72839e35", "AutoJoinElements");
            this.mAddinNameList.Add("5045b6d9-899f-4ec0-9fa8-e672aa8dd966", "AddinBimHoaBinh");
            this.mAddinNameList.Add("a277ca6b-1b46-476e-8372-2bbf7e31ff8d", "Tile Count - Write");
			this.mAddinNameList.Add("4b5163b6-7d43-44ba-9f2f-16f4096eebda", "RoomAssign_2017");
            this.mAddinNameList.Add("790bce87-413e-40f2-915e-c548c751ae51", "Quick DIM Floor 2017");
            this.mAddinNameList.Add("d010b7d7-2adf-4410-995b-76a7c0eaf631", "BiM Hoa Binh 2018");

        }

        private void createVersionList()
        {
            this.mVersionList = new Dictionary<string, string>();

            this.mVersionList.Add("1", "Version 1.0");
            this.mVersionList.Add("2", "Version 2.0");
            this.mVersionList.Add("3", "Version 3.0");
            this.mVersionList.Add("4", "Version 4.0");
            this.mVersionList.Add("5", "Version 5.0");
            this.mVersionList.Add("6", "Version 6.0");
        }
        private void initVersionList()
        {
            foreach (KeyValuePair<string, string> entry in this.mVersionList)
            {
                VersionItem item = new VersionItem();
                item.Text = entry.Value;
                item.Value = entry.Key;
                this.cbVersionFor.Items.Add(item);
            }
            this.cbVersionFor.SelectedIndex = 0;
        }
        private void initExpirationTimeList()
        {
            ExpirationTimeItem item0 = new ExpirationTimeItem();
            item0.Text = "15 Days";
            item0.Value = ExpirationTime.FIFTEEN_DAYS;
            this.cbExpirationTime.Items.Add(item0);

            ExpirationTimeItem item1 = new ExpirationTimeItem();
            item1.Text = "3 Months";
            item1.Value = ExpirationTime.THREE_MONTHS;
            this.cbExpirationTime.Items.Add(item1);

            ExpirationTimeItem item2 = new ExpirationTimeItem();
            item2.Text = "6 Months";
            item2.Value = ExpirationTime.SIX_MONTHS;
            this.cbExpirationTime.Items.Add(item2);

            ExpirationTimeItem item3 = new ExpirationTimeItem();
            item3.Text = "1 Year";
            item3.Value = ExpirationTime.ONE_YEAR;
            this.cbExpirationTime.Items.Add(item3);

            ExpirationTimeItem item4 = new ExpirationTimeItem();
            item4.Text = "2 Years";
            item4.Value = ExpirationTime.TWO_YEARS;
            this.cbExpirationTime.Items.Add(item4);

            ExpirationTimeItem item5 = new ExpirationTimeItem();
            item5.Text = "Unlimited";
            item5.Value = ExpirationTime.UNLIMITED;
            this.cbExpirationTime.Items.Add(item5);

            this.cbExpirationTime.SelectedIndex = 3;
        }
        private void initAddinNameList()
        {
            foreach (KeyValuePair<string, string> entry in this.mAddinNameList)
            {
                AddinNameItem item = new AddinNameItem();
                item.Text = entry.Value;
                item.Value = entry.Key;
                this.cbLicenseFor.Items.Add(item);
            }

            this.cbLicenseFor.SelectedIndex = 0;
        }
        private String createExpiredTime()
        {

            DateTime d1 = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0);

            DateTime d2 = d1;

            ExpirationTimeItem item = this.cbExpirationTime.SelectedItem as ExpirationTimeItem;

            switch (item.Value)
            {
                case ExpirationTime.FIFTEEN_DAYS:
                    d2 = d1.AddDays(15);
                    break;
                case ExpirationTime.THREE_MONTHS:
                    d2 = d1.AddMonths(3);
                    break;
                case ExpirationTime.SIX_MONTHS:
                    d2 = d1.AddMonths(6);
                    break;
                case ExpirationTime.ONE_YEAR:
                    d2 = d1.AddYears(1);
                    break;
                case ExpirationTime.TWO_YEARS:
                    d2 = d1.AddYears(2);
                    break;
                case ExpirationTime.UNLIMITED:
                    d2 = d1;
                    break;
            }

            if (d1 == d2)
                return "0";

            return d1.Ticks.ToString() + "-" + d2.Ticks.ToString();

        }


    }
    enum ExpirationTime
    {
        FIFTEEN_DAYS = 15,
        THREE_MONTHS = 3,
        SIX_MONTHS = 6,
        ONE_YEAR = 1,
        TWO_YEARS = 2,
        UNLIMITED = 0

    }
    class AddinNameItem
    {
        public String Text
        {
            get; set;
        }

        public String Value
        {
            get; set;
        }

        public override string ToString()
        {
            return Text;
        }
    }
    class VersionItem
    {
        public String Text
        {
            get; set;
        }

        public String Value
        {
            get; set;
        }

        public override string ToString()
        {
            return Text;
        }
    }
    class ExpirationTimeItem
    {
        public String Text
        {
            get; set;
        }

        public ExpirationTime Value
        {
            get; set;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
