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
    public partial class RemoveHomeOwners : Form
    {
        private Manager Ah1
        { get; set; }
        public RemoveHomeOwners()
        {
            InitializeComponent();
        }

        public RemoveHomeOwners(Manager ah1):this()
        {
            this.Ah1 = ah1;
        }

        private void btnremovehomeownerback_Click(object sender, EventArgs e)
        {
            this.Ah1.Visible = true;
            this.Hide();
        }

        private void RemoveHomeOwners_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Closing App");
            Application.Exit();
            this.Ah1.Close();
        }

        private void btnremovehoeowner_Click(object sender, EventArgs e)
        {
            try
            {

                var sql = @"delete from OwnerInfo where OwnerId='" + this.txthomeowneridremove.Text + "';";
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
