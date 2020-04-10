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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserMasterBL userMaster = new UserMasterBL();
            var user = userMaster.spCheckUserMasterByID(txtUserName.Text, txtPassword.Text);
            if (user == null)
            {
                MessageBox.Show("Invalid Username or Password");
            }
            else
            {
                FrmMDIParent frmMDI = new FrmMDIParent();
                this.Hide();
                frmMDI.Show();
            }
        }
    }
}
