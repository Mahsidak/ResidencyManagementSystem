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
    public partial class SearchEmployeeAdmin : Form
    {
        private DataAccess Da { get; set; }
        private Admin S1
        {
            get;
            set;
        }
        public SearchEmployeeAdmin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        public SearchEmployeeAdmin(Admin s1)
        {
            this.S1 = s1;
            InitializeComponent();

        }

        private void PopulateGridView(string sql)
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvshowinfo.AutoGenerateColumns = false;
            this.dgvshowinfo.DataSource = ds.Tables[0];
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = "select * from EmployeeInfo1 where EmployeeId='" + this.txtemployeeid.Text + "';  ";

                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-PCEH0DP;Initial Catalog=Admin;Persist Security Info=True;User ID=sa;Password=20438672");
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                this.dgvshowinfo.AutoGenerateColumns = false;
                this.dgvshowinfo.DataSource = ds.Tables[0];
                
                //DataAccess da = new DataAccess();
                //this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error, please try again\n" + exc.Message);
            }
        }

        private void SearchEmployeeAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.S1.Close();
            MessageBox.Show("Closing App");
            Application.Exit();
            
        }

        private void btnsearchemployeeprevious_Click(object sender, EventArgs e)
        {
            this.S1.Visible = true;
            this.Hide();
        }
    }
}
