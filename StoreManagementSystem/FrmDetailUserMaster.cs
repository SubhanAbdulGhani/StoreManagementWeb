using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessLayer;

namespace StoreManagementSystem
{
    public partial class FrmDetailUserMaster : Form
    {
        DataTable table;

        public FrmDetailUserMaster()
        {
            InitializeComponent();
        }

        public void LoadUserMaster()
        {
            FrmUserMaster userMaster = new FrmUserMaster();
            userMaster.MdiParent = this.MdiParent;
            userMaster.Show();
        }

        public void SetUserMaster(int UserID)
        {
            UserMasterBL sellerMasterBL = new UserMasterBL();
            table = sellerMasterBL.GetUserMasterByID(UserID);
            txtName.Text = table.Rows[0]["UserName"].ToString();
            txtPassword.Text = table.Rows[0]["Password"].ToString();
            txtStatus.Text = table.Rows[0]["Status"].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserMasterBL userBL = new UserMasterBL();
            if (table == null)
            {
                userBL.AddUserMaster(txtName.Text, txtPassword.Text, txtStatus.Text);
            }
            else
            {
                userBL.UpdateUserMaster((int)table.Rows[0]["UserID"],txtName.Text, txtPassword.Text, txtStatus.Text);
            }
            this.Close();
            LoadUserMaster();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadUserMaster();
            this.Close();
        }

        private void FrmDetailUserMaster_Load(object sender, EventArgs e)
        {

        }
    }
}
