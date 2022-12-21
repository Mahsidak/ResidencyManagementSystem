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
    public partial class Admin : Form
    {
        private AdminLoginForm A1
        {
            get;
            set;
        }
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(AdminLoginForm a1):this()
        {
            this.A1 = a1;
            
           
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.A1.Close();
            MessageBox.Show("Closing App");
            Application.Exit();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Log Out Complete");
            this.A1.Show();
        }

        private void btnsearchemployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchEmployeeAdmin s1 = new SearchEmployeeAdmin(this);
            s1.Show();
        }

        private void btnaddemployeeadmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployeeAdmin a1 = new AddEmployeeAdmin(this);
            a1.Show();
        }

        private void btnadminchangepassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeAdminPassowrd c1 = new ChangeAdminPassowrd(this);
            c1.Show();
        }

        private void btnremoveemployeeadmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            RermoveEmployee r1 = new RermoveEmployee(this);
            r1.Show();
        }
    }
}
