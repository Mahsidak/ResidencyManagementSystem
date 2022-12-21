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
    public partial class AddEmployeeAdmin : Form
    {
        private static int serialno ;
        Regex r = new Regex(@"^([A-Z][a-z-A-Z]+)$");
        private string str;
        private DataAccess Da { get; set; }
        private Admin A1
        {
            get;
            set;
        }
        public AddEmployeeAdmin()
        {
            InitializeComponent();
        }

        public AddEmployeeAdmin(Admin a1)
        {
            this.A1 = a1;
            InitializeComponent();

        }

        private void AddEmployeeAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.A1.Close();
            MessageBox.Show("Closing App");
            Application.Exit();
            
        }

        private void btnaddempad_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "SELECT * FROM EmployeeInfo1 where Nid='" + this.txtaddempnid.Text + "';";
                string sql2 = "SELECT * FROM EmployeeInfo1 where PhoneNumber='" + this.txtaddempphonenumber.Text + "';";
                DataAccess da = new DataAccess();
                var ds = da.ExecuteQuery(sql1);
                var ds1 = da.ExecuteQuery(sql2);
                if (!IsDataValidToSave() || r.IsMatch(this.txtaddempname.Text)== false || ds.Tables[0].Rows.Count == 1|| ds1.Tables[0].Rows.Count == 1)
                {
                    
                        MessageBox.Show("Please Fill all the Data Correctly or Insert the correct Data.");
                        return;
                    
                   
                }
                
                str = Setupid();
                var sql = @"insert into EmployeeInfo1 VALUES('" + str+"', '"+this.txtaddempname.Text+"', '"+this.cmbaddemgender.Text+"', '"+this.txtaddempphonenumber.Text+ "','" + this.txtaddempnid.Text+"' , '" + this.cmbaddemprole.Text + "');";
                
                int count = da.ExecuteDMLQuery(sql);
                if(count==1)
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
             
            
            if (String.IsNullOrEmpty(this.txtaddempname.Text) || String.IsNullOrEmpty(this.cmbaddemgender.Text) ||
                String.IsNullOrEmpty(this.txtaddempphonenumber.Text) || String.IsNullOrEmpty(this.txtaddempnid.Text) ||
                String.IsNullOrEmpty(this.cmbaddemprole.Text) || (this.txtaddempphonenumber.Text.Length!=11)||(this.txtaddempnid.Text.Length!=10))
                return false;
            else
                return true;
        }

        
        
        private string Setupid()
        {

            string newId = "";
            var sql = "select * from EmployeeInfo1 order by EmployeeId desc;";
            DataAccess da = new DataAccess();
            var dt = da.ExecuteQueryTable(sql);
            if (dt.Rows.Count == 0)
            {
                newId = "E-00" + (1).ToString();
                return newId;
            }

            string lastId = dt.Rows[0][0].ToString();
            string[] temp = lastId.Split('-');
            int no = Convert.ToInt32(temp[1]);
            newId = "E-00" + (++no).ToString();
            return newId;

        }

        private void btnaddemployeeprevious_Click(object sender, EventArgs e)
        {
            this.A1.Visible = true;
            this.Hide();
        }
    }
}
