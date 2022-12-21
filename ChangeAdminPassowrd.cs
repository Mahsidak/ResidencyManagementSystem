using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsAppProject1
{
    public partial class ChangeAdminPassowrd : Form
    {
        private DataAccess Da { get; set; }
        private Admin C1
        {
            get;
            set;
        }
        public ChangeAdminPassowrd()
        {
            
            InitializeComponent();
            this.Da = new DataAccess();
        }

        public ChangeAdminPassowrd(Admin c1)
        {
            this.C1 = c1;
            InitializeComponent();

        }

        private void ChangeAdminPassowrd_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            MessageBox.Show("Closing App");
            Application.Exit();
            this.C1.Close();
        }

        private void btnchangepasswordadmin_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from LoginInfo where AdminId='" + this.txtchangeadminpassenterid.Text+"';";
                

                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-PCEH0DP;Initial Catalog=Admin;Persist Security Info=True;User ID=sa;Password=20438672");
                SqlCommand sqlcom = new SqlCommand(query, sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = @"UPDATE LoginInfo SET Password = '" + this.txtadminchangepassword.Text+"'WHERE AdminId ='" + this.txtchangeadminpassenterid.Text + "';";
                    DataAccess da = new DataAccess();
                    int count = da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated properly");
                    else
                        MessageBox.Show("Data upgradation failed");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private void btnchangepasswordprevious_Click(object sender, EventArgs e)
        {
            this.C1.Visible = true;
            this.Hide();
        }
    }
}
