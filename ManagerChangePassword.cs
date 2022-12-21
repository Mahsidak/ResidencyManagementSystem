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
    public partial class ManagerChangePassword : Form
    {

        private Manager M1
        {
            get;
            set;
        }
        public ManagerChangePassword()
        {
            InitializeComponent();
        }
        public ManagerChangePassword(Manager m1)
        {
            this.M1 = m1;
            InitializeComponent();

        }

        private void btnchangepasswordpreviousmanager_Click(object sender, EventArgs e)
        {
            this.M1.Visible = true;
            this.Hide();
        }

        private void btnchangepasswordmanager_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from LoginInfo where AdminId='" + this.txtchangemanagerpasswordid.Text + "';";


                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-PCEH0DP;Initial Catalog=Admin;Persist Security Info=True;User ID=sa;Password=20438672");
                SqlCommand sqlcom = new SqlCommand(query, sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = @"UPDATE LoginInfo SET Password = '" + this.txtchngmanagerpass.Text + "'WHERE AdminId ='" + this.txtchangemanagerpasswordid.Text + "';";
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

        private void ManagerChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            MessageBox.Show("Closing App");
            Application.Exit();
            this.M1.Close();
        }
    }
}
