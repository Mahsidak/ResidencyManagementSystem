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
    public partial class Manager : Form
    {
        private AdminLoginForm A1
        {
            get;
            set;
        }
        public Manager()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        private DataAccess Da { get; set; }

        public Manager(AdminLoginForm a1) : this()
        {
            this.A1 = a1;

            
        }

        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            MessageBox.Show("Closing App");
            Application.Exit();
            this.A1.Close();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Log Out Complete");
            this.A1.Show();
        }

        private void btnmanagerchangepassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerChangePassword m1 = new ManagerChangePassword(this);
            m1.Show();
        }

        private void btnaddhomeownersmanager_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddHomeOwners ah1 = new AddHomeOwners(this);
            ah1.Show();
        }

        private void btnremovehomeownersmanager_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveHomeOwners rh1 = new RemoveHomeOwners(this);
            rh1.Show();
        }

        private void btnsearchhomeownersmanager_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchHomeOwners sh1 = new SearchHomeOwners(this);
            sh1.Show();
        }

        private void btnaddcommonutilitybills_Click(object sender, EventArgs e)
        {
            this.Hide();
            CommonUtilityBills cb1 = new CommonUtilityBills(this);
            cb1.Show();
        }
    }
}
