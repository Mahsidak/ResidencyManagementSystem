using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProject1
{
    public partial class CommonUtilityBills : Form
    {
        private Manager Cb1
        {
            get;
            set;
        }
        public CommonUtilityBills()
        {
            InitializeComponent();
        }
        public CommonUtilityBills(Manager cb1) : this()
        {
            this.Cb1 = cb1;

        }

        private void CommonUtilityBills_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Cb1.Close();
            MessageBox.Show("Closing App");
            Application.Exit();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Cb1.Visible = true;
            this.Hide();
        }

        private void btnaddutilitybill_Click(object sender, EventArgs e)
        {
            try
            {

                string sql1 = "select * from UtilityBills where Month='" + this.cmbmonth.Text + "';";
                int servicecharge = Convert.ToInt32(this.txtservicecharge.Text.ToString());
                DataAccess da = new DataAccess();
                var ds = da.ExecuteQuery(sql1);
                // || !ValidateData()
                if (!IsDataValidToSave() || ds.Tables[0].Rows.Count == 1 || !ValidateData())
                {

                    MessageBox.Show("Please Fill all the Data Correctly or Insert the correct Data.");
                    return;

                }

                var sql = @"insert into UtilityBills values('" + this.txtgasbill.Text + "','" + this.txtwaterbill.Text + "','" + this.txtcurrentbill.Text + "','" + this.txtsecuritybill.Text + "','" + this.txtgardenercharge.Text + "','" + this.txtservicecharge.Text + "','" + this.cmbmonth.Text + "');";
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


            if (String.IsNullOrEmpty(this.txtcurrentbill.Text) || String.IsNullOrEmpty(this.txtgardenercharge.Text) ||
                String.IsNullOrEmpty(this.txtgasbill.Text) || String.IsNullOrEmpty(this.txtsecuritybill.Text) ||
                String.IsNullOrEmpty(this.txtservicecharge.Text) || String.IsNullOrEmpty(this.txtwaterbill.Text) || String.IsNullOrEmpty(this.cmbmonth.Text))
                return false;
            else
                return true;
        }

        private bool ValidateData()
        {
            int gasbill = Convert.ToInt32(this.txtgasbill.Text.ToString());
            int waterbill = Convert.ToInt32(this.txtwaterbill.Text.ToString());
            int currentbill = Convert.ToInt32(this.txtcurrentbill.Text.ToString());
            int gardenercharge = Convert.ToInt32(this.txtgardenercharge.Text.ToString());
            int securitybill = Convert.ToInt32(this.txtsecuritybill.Text.ToString());
            int servicecharge = Convert.ToInt32(this.txtservicecharge.Text.ToString());
            if ((gasbill != 1080) || (servicecharge != 250) || (securitybill!=350)||(gardenercharge!=300) ||(waterbill<500 || waterbill>900) ||(currentbill<1000 || currentbill>2500))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowUtilityBills su1 = new ShowUtilityBills(this);
            su1.Show();
        }
    }
}
