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
    public partial class FrmUserMaster : Form
    {
        public FrmUserMaster()
        {
            InitializeComponent();
        }

        public void LoadUserMaster()
        {
            UserMasterBL userMaster = new UserMasterBL();
            dgvUserMaster.DataSource = userMaster.GetUserMaster();

        }

        private void FrmUserMaster_Load(object sender, EventArgs e)
        {
            LoadUserMaster();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmDetailUserMaster detailUser = new FrmDetailUserMaster();
            detailUser.MdiParent = this.MdiParent;
            detailUser.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UserMasterBL userBL = new UserMasterBL();
            if (dgvUserMaster.SelectedRows.Count > 0)
            {
                var id = (int)dgvUserMaster.SelectedRows[0].Cells["UserID"].Value;
                userBL.DeleteUserMaster(id);
                LoadUserMaster();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUserMaster.SelectedRows.Count > 0)
            {
                var id = (int)dgvUserMaster.SelectedRows[0].Cells["UserID"].Value;
                FrmDetailUserMaster detailUser = new FrmDetailUserMaster();
                detailUser.SetUserMaster(id);
                detailUser.Show();
            }
        }

        private void dgvUserMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
