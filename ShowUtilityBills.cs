using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProject1
{
    public partial class ShowUtilityBills : Form
    {
        private CommonUtilityBills Su1
        {
            get;
            set;
        }
        public ShowUtilityBills()
        {
            InitializeComponent();
        }

        public ShowUtilityBills(CommonUtilityBills su1):this()
        {
            this.Su1 = su1;
        }

        private void btnshowutility_Click(object sender, EventArgs e)
        {
            
            try
            {
                string sql = "select * FROM UtilityBills;";
                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-PCEH0DP;Initial Catalog=Admin;Persist Security Info=True;User ID=sa;Password=20438672");
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                this.dgvutilitybills.AutoGenerateColumns = false;
                this.dgvutilitybills.DataSource = ds.Tables[0];
                sqlcon.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error, please try again\n" + exc.Message);
            }
        }

        private void btnutilitybillshowback_Click(object sender, EventArgs e)
        {
            this.Su1.Visible = true;
            this.Hide();
        }

        private void ShowUtilityBills_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Su1.Close();
            MessageBox.Show("Closing App");
            Application.Exit();
        }
    }
}
