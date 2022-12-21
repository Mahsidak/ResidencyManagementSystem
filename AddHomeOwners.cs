using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsAppProject1
{
    public partial class AddHomeOwners : Form
    {
        Regex r = new Regex(@"^([A-Z][a-z-A-Z]+)$");
        
        private string str;
        private Manager Ah1
        {
            get;
            set;
        }
        private DataAccess Da { get; set; }
        public AddHomeOwners()
        {
            InitializeComponent();
        }

        public AddHomeOwners(Manager ah1):this()
        {
            this.Ah1 = ah1;
            this.Da = new DataAccess();
        }

        private void AddHomeOwners_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Ah1.Close();
            MessageBox.Show("Closing App");
            Application.Exit();
            
        }

        private void btnaddhomeownermanagerback_Click(object sender, EventArgs e)
        {
            this.Ah1.Visible=true;
            this.Hide();

        }

        private void btnaddhomeowneraddmanager_Click(object sender, EventArgs e)
        {
            try
            {
                int b = Convert.ToInt32(this.txthomeownerage.Text.ToString());
                string sql1 = "select* from OwnerInfo where Phone = '" + this.txthomeownerphonenumber.Text + "';";
                string sql2 = "select * from OwnerInfo where FlatNumber='"+this.txthomeownerflatnumber.Text+"';";
                DataAccess da = new DataAccess();
                var ds = da.ExecuteQuery(sql1);
                var ds1 = da.ExecuteQuery(sql2);
                if (!IsDataValidToSave() || r.IsMatch(this.txthomeownername.Text) == false || ds.Tables[0].Rows.Count == 1||(b<18 || b>75) || (this.cmbhomeownertype.Text.ToString().Equals("Family") && ds1.Tables[0].Rows.Count == 1))
                {

                    MessageBox.Show("Please Fill all the Data Correctly or Insert the correct Data.");
                    return;

                }
                str = Setupid();
                var sql = @"insert into OwnerInfo values('"+str+"','"+this.txthomeownername.Text+"','"+this.txthomeownerage.Text+"','"+this.txthomeownerphonenumber.Text+"','"+this.cmbhomeowneroccupassion.Text+"','"+this.txthomeownerflatnumber.Text+"','"+this.cmbhomeownertype.Text+"');";
                int count = da.ExecuteDMLQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show("Data Insertion Successful");
                }
                else
                {
                    MessageBox.Show("Data Insertion Failed");
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }
        private bool IsDataValidToSave()
        {
            int a = Convert.ToInt32(this.txthomeownerflatnumber.Text.ToString());
            
            if (String.IsNullOrEmpty(this.txthomeownername.Text) || String.IsNullOrEmpty(this.cmbhomeowneroccupassion.Text) ||
                String.IsNullOrEmpty(this.txthomeownerage.Text) || String.IsNullOrEmpty(this.txthomeownerphonenumber.Text) ||
                String.IsNullOrEmpty(this.cmbhomeownertype.Text) || String.IsNullOrEmpty(this.txthomeownerflatnumber.Text)||
                (this.txthomeownerphonenumber.Text.Length != 11)
                || (this.cmbhomeownertype.Text.ToString().Equals("Male Batchelor") && (a < 200 || a > 299))
                || (this.cmbhomeownertype.Text.ToString().Equals("Female Batchelor") && (a < 300 || a > 399))
                || (this.cmbhomeownertype.Text.ToString().Equals("Family") && (a < 100 || a > 199)))
            {
                return false;
            }
                
            else
                return true;
        }

        
        

        private string Setupid()
        {

            string newId = "";
            var sql = "select * from OwnerInfo order by OwnerId desc;";
            DataAccess da = new DataAccess();
            var dt = da.ExecuteQueryTable(sql);
            if (dt.Rows.Count == 0)
            {
                newId = "AO-00" + (1).ToString();
                return newId;
            }

            string lastId = dt.Rows[0][0].ToString();
            string[] temp = lastId.Split('-');
            int no = Convert.ToInt32(temp[1]);
            newId = "AO-00" + (++no).ToString();
            return newId;

            

        }



    }
}
