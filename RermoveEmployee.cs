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
    public partial class RermoveEmployee : Form
    {
        public RermoveEmployee()
        {
            InitializeComponent();
        }
        private Admin R1
        {
            get;
            set;
        }
        public RermoveEmployee(Admin r1):this()
        {
            this.R1 = r1;
           

        }

        private void RermoveEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            MessageBox.Show("Closing App");
            Application.Exit();
            this.R1.Close();
        }

        private void btndeleteemployeeprevious_Click(object sender, EventArgs e)
        {
            this.R1.Visible = true;
            this.Hide();
        }

        private void btnremoveemployee_Click(object sender, EventArgs e)
        {
            try
            {
                
                var sql = @"delete from EmployeeInfo1 where EmployeeId='" + this.txtdeleteemployee.Text+"';";
                DataAccess da = new DataAccess();
                int count = da.ExecuteDMLQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show("Data Deletion Successful");
                }
                else
                {
                    MessageBox.Show("Data Deletion Failed");
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }
    }
}
