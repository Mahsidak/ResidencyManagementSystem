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
    public partial class SearchHomeOwners : Form
    {
        private Manager Sh1
        {
            get;
            set;
        }
        public SearchHomeOwners()
        {
            InitializeComponent();
        }

        public SearchHomeOwners(Manager sh1):this()
        {
            this.Sh1 = sh1;
        }

        private void SearchHomeOwners_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Sh1.Close();
            MessageBox.Show("Closing App");
            Application.Exit();
        }

        private void btnsearchhomeownerprevious_Click(object sender, EventArgs e)
        {
            this.Sh1.Visible = true;
            this.Hide();

        }

        private void btnhomeownersearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from OwnerInfo where OwnerId='"+this.txtowneridsearch.Text+"';";

                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-PCEH0DP;Initial Catalog=Admin;Persist Security Info=True;User ID=sa;Password=20438672");
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                this.dgvsearhomeowners.AutoGenerateColumns = false;
                this.dgvsearhomeowners.DataSource = ds.Tables[0];

                //DataAccess da = new DataAccess();
                //this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error, please try again\n" + exc.Message);
            }
        }
    }
}
