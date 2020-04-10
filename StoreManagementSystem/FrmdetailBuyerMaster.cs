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
    public partial class FrmdetailBuyerMaster : Form
    {
        DataTable table;

        public FrmdetailBuyerMaster()
        {
            InitializeComponent();
        }

        public FrmdetailBuyerMaster(int BuyerMasterID)
        {
            InitializeComponent();
            SetBuyerMaster(BuyerMasterID);
        }

        private void LoadBuyerMaster()
        {
            FrmBuyerMaster frmSeller = new FrmBuyerMaster();
            frmSeller.MdiParent = this.MdiParent;
            frmSeller.Show();
        }

        public void SetBuyerMaster(int ID)
        {
            BuyerMasterBL buyerMasterBL = new BuyerMasterBL();
            table = buyerMasterBL.GetBuyerByID(ID);
            txtCompanyName.Text = table.Rows[0]["CompanyName"].ToString();

            BuyerContactBL buyer = new BuyerContactBL();
            dgvBuyerContact.DataSource = buyer.GetContactById((int)table.Rows[0]["ID"]);

            BuyerAddressBL buyerAddress = new BuyerAddressBL();
            dgvBuyerAddress.DataSource = buyerAddress.GetAddressById((int)table.Rows[0]["ID"]);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BuyerMasterBL buyerMasterBL = new BuyerMasterBL();
            if (table == null)
            {
                buyerMasterBL.AddBuyerMaster(txtCompanyName.Text);
            }
            else
            {
                buyerMasterBL.UpdateBuyerMaster(txtCompanyName.Text, (int)table.Rows[0]["ID"]);
            }
            this.Close();
            LoadBuyerMaster();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmBuyerMaster buyerMaster = new FrmBuyerMaster();
            buyerMaster.MdiParent = this.MdiParent;
            buyerMaster.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDetailBuyerContact buyerContact = new FrmDetailBuyerContact((int)table.Rows[0]["ID"]);
            buyerContact.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmDetailBuyerContact frmDetailBuyer = new FrmDetailBuyerContact((int)table.Rows[0]["ID"]);
            //DetailSellerMaster detailSeller = new DetailSellerMaster();
            if (dgvBuyerContact.SelectedRows.Count > 0)
            {
                var id = (int)dgvBuyerContact.SelectedRows[0].Cells["BuyerMasterID"].Value;
                frmDetailBuyer.SetBuyerContact(id);
                frmDetailBuyer.Show();
            }
        }

        private void LoadBuyerContact()
        {
            BuyerContactBL seller = new BuyerContactBL();
            dgvBuyerContact.DataSource = seller.GetBuyerContact();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuyerContactBL contactBL = new BuyerContactBL();
            if (dgvBuyerContact.SelectedRows.Count > 0)
            {
                var id = (int)dgvBuyerContact.SelectedRows[0].Cells["BuyerMasterID"].Value;
                contactBL.DeleteBuyerContact(id);
                LoadBuyerContact();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDetailBuyerAddress detailSellerAddress = new FrmDetailBuyerAddress((int)table.Rows[0]["ID"]);
            detailSellerAddress.Show();
            this.Close();
        }

        private void LoadBuyerAddress()
        {
            BuyerAddressBL buyer = new BuyerAddressBL();
            dgvBuyerAddress.DataSource = buyer.GetBuyerAddress();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BuyerAddressBL contactBL = new BuyerAddressBL();
            if (dgvBuyerAddress.SelectedRows.Count > 0)
            {
                var id = (int)dgvBuyerAddress.SelectedRows[0].Cells["SellerID"].Value;
                contactBL.DeleteBuyerAddress(id);
                LoadBuyerAddress();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDetailBuyerAddress sellerAddress = new FrmDetailBuyerAddress((int)table.Rows[0]["ID"]);
            if (dgvBuyerAddress.SelectedRows.Count > 0)
            {
                var id = (int)dgvBuyerAddress.SelectedRows[0].Cells["SellerID"].Value;
                sellerAddress.SetBuyerAddress(id);
                sellerAddress.Show();
            }
        }

        private void FrmdetailBuyerMaster_Load(object sender, EventArgs e)
        {

        }
    }
}
