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
    public partial class DetailSellerMaster : Form
    {
        DataTable table;

        public DetailSellerMaster()
        {
            InitializeComponent();           
        }

        public DetailSellerMaster(int sellerID)
        {
            InitializeComponent();
            SetSellerMaster(sellerID);
        }

        private void DetailSellerMaster_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadSellerMaster()
        {
            FrmSellerMaster frmSeller = new FrmSellerMaster();
            frmSeller.MdiParent = this.MdiParent;
            frmSeller.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadSellerMaster();
            this.Close();           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SellerMasterBL sellerMasterBL = new SellerMasterBL();
            if (table == null)
            {
                sellerMasterBL.AddSellerMaster(txtCompanyName.Text);
            }
            else
            {
                sellerMasterBL.UpdateSellerMaster((int)table.Rows[0]["ID"],txtCompanyName.Text);
            }
            this.Close();
            //SellerMasterBL.MdiParent = this;
            LoadSellerMaster();
        }

        public void SetSellerMaster(int ID)
        {
            SellerMasterBL sellerMasterBL = new SellerMasterBL();
            table = sellerMasterBL.GetSellerByID(ID);
            txtCompanyName.Text = table.Rows[0]["CompanyName"].ToString();

            SellerContactBL seller = new SellerContactBL();
            dgvSellerContact.DataSource = seller.GetContactById((int)table.Rows[0]["ID"]);

            SellerAddressBL sellerAddress = new SellerAddressBL();
            dgvSellerAddress.DataSource = sellerAddress.GetAddressById((int)table.Rows[0]["ID"]);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadSellerContact()
        {
            SellerContactBL seller = new SellerContactBL();
            dgvSellerContact.DataSource = seller.GetSellerContact();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSellerContact sellerContact = new frmSellerContact();
            sellerContact.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                frmDetailSellerContact sellerContact = new frmDetailSellerContact((int)table.Rows[0]["ID"]);
                sellerContact.Show();
                this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SellerContactBL contactBL = new SellerContactBL();
            if (dgvSellerContact.SelectedRows.Count > 0)
            {
                var id = (int)dgvSellerContact.SelectedRows[0].Cells["SellerID"].Value;
                contactBL.DeleteSellerContact(id);
                LoadSellerContact();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmDetailSellerContact frmDetailSeller = new frmDetailSellerContact((int)table.Rows[0]["ID"]);
            //DetailSellerMaster detailSeller = new DetailSellerMaster();
            if (dgvSellerContact.SelectedRows.Count > 0)
            {
                  var id = (int)dgvSellerContact.SelectedRows[0].Cells["SellerID"].Value;
                  frmDetailSeller.SetSellerContact(id);
                  frmDetailSeller.Show();
            }
        }

        private void LoadSellerAddress()
        {
            SellerAddressBL seller = new SellerAddressBL();
            dgvSellerAddress.DataSource = seller.GetSellerAddress();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmDetailSellerAddress detailSellerAddress = new FrmDetailSellerAddress((int)table.Rows[0]["ID"]);
            detailSellerAddress.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SellerAddressBL contactBL = new SellerAddressBL();
            if (dgvSellerAddress.SelectedRows.Count > 0)
            {
                var id = (int)dgvSellerAddress.SelectedRows[0].Cells["SellerID"].Value;
                contactBL.DeleteSellerAddress(id);
                LoadSellerAddress();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmDetailSellerAddress sellerAddress = new FrmDetailSellerAddress((int)table.Rows[0]["ID"]);
            if (dgvSellerAddress.SelectedRows.Count > 0)
            {
                var id = (int)dgvSellerAddress.SelectedRows[0].Cells["SellerID"].Value;
                sellerAddress.SetSellerAddress(id);
                sellerAddress.Show();
            }
        }
    }
}