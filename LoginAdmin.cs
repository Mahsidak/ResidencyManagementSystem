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
    public partial class AdminLoginForm : Form
    {
        private DataAccess Da { get; set; }

        public AdminLoginForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from LoginInfo where AdminId='" + this.txtUserid.Text+"' and Password='"+this.txtpassword.Text+"';";
                //SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-PCEH0DP;Initial Catalog=Admin;Persist Security Info=True;User ID=sa;Password=20438672");
                //SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                //SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                //DataSet ds = new DataSet();
                //sda.Fill(ds);
                //DataAccess da = new DataAccess();
                
                var ds= this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    this.Hide();
                    MessageBox.Show("Valid Login");
                    
                    if (ds.Tables[0].Rows[0][2].ToString() == "Admin")
                    {
                        Admin m1 = new Admin(this);
                        m1.Show();
                    }
                   else if (ds.Tables[0].Rows[0][2].ToString() == "Manager")
                    {
                        Manager m1 = new Manager(this);
                        m1.Show();
                    }
                }
                else
                {
                    MessageBox.Show("InValid Login");
                }

                //sqlcon.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error, please try again\n" + exc.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.clearcontent();
        }
        private void clearcontent()
        {
            this.txtUserid.Clear();
            this.txtpassword.Clear();
        }
    }
}
