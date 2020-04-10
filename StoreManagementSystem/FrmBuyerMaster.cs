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
    public partial class FrmBuyerMaster : Form
    {
        public FrmBuyerMaster()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadBuyerMaster()
        {
            BuyerMasterBL buyerMasterBL = new BuyerMasterBL();
            dgvBuyerMaster.DataSource = buyerMasterBL.GetBuyerMaster();

        }

        private void FrmBuyerMaster_Load(object sender, EventArgs e)
        {
            LoadBuyerMaster();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            FrmdetailBuyerMaster frmdetailBuyer = new FrmdetailBuyerMaster();
            frmdetailBuyer.MdiParent = this.MdiParent;
            frmdetailBuyer.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BuyerMasterBL sellerMasterBL = new BuyerMasterBL();
            if (dgvBuyerMaster.SelectedRows.Count > 0)
            {
                var id = (int)dgvBuyerMaster.SelectedRows[0].Cells["ID"].Value;
                sellerMasterBL.DeleteBuyerMaster(id);
                LoadBuyerMaster();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBuyerMaster.SelectedRows.Count > 0)
            {
                var id = (int)dgvBuyerMaster.SelectedRows[0].Cells["ID"].Value;
                FrmdetailBuyerMaster detailBuyer = new FrmdetailBuyerMaster(id);
                detailBuyer.MdiParent = this.MdiParent;
                detailBuyer.SetBuyerMaster(id);
                detailBuyer.Show();
            }
        }
    }
}
