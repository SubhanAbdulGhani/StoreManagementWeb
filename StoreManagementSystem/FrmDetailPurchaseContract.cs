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
using System.Data;


namespace StoreManagementSystem
{
    public partial class FrmDetailPurchaseContract : Form
    {
        DataTable table;
        int purchaseContractId = 0;
        public FrmDetailPurchaseContract()
        {
            InitializeComponent();
            LoadData();
        }

        public FrmDetailPurchaseContract(int PurchaseContractID)
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            ProductBL productBL = new ProductBL();
            //Create the new combobox column and set it's DataSource to a DataTable
            var col = (DataGridViewComboBoxColumn)dgvPurchaseContract.Columns["Product"];
            col.DataSource = productBL.GetProducts();
            col.ValueMember = "ProductID";
            col.DisplayMember = "Name";
            col.DataPropertyName = "ProductID";

            dgvPurchaseContract.CellEndEdit += Calculate;
        }

        public void SetPurchaseContract(int ID)
        {
            PurchaseContractBL sellerMasterBL = new PurchaseContractBL();
            table = sellerMasterBL.GetPurchaseContractByID(ID);
            dtpPurchaseContractDate.Value =DateTime.Parse( table.Rows[0]["PurchaseContractDate"].ToString());
            cmbUserMaster.SelectedValue = table.Rows[0]["PreparedBy"].ToString();
            cmbSeller.SelectedValue = table.Rows[0]["SellerID"];
            //txtCompanyName.Text = table.Rows[0]["CompanyName"].ToString();

            PurchaseContractDetailBL contractDetailBL = new PurchaseContractDetailBL();            
            var tbl = contractDetailBL.GetPurchaseContractDetailByID((int)table.Rows[0]["PurchaseContractID"]);

            //foreach (var row in tbl.Rows)
            for (int i=0;i< tbl.Rows.Count;i++)
            {
                var index = dgvPurchaseContract.Rows.Add();
                dgvPurchaseContract.Rows[index].Cells["Weight"].Value = tbl.Rows[i]["Weight"];
                dgvPurchaseContract.Rows[index].Cells["Price"].Value = tbl.Rows[i]["Price"];
                dgvPurchaseContract.Rows[index].Cells["TotalAmount"].Value = tbl.Rows[i]["TotalAmount"];
                dgvPurchaseContract.Rows[index].Cells["Product"].Value = tbl.Rows[i]["ProductID"];                
            }
            if ((bool)table.Rows[0]["Approve"])
            {
                dtpPurchaseContractDate.Enabled = false;
                cmbApprovedBy.Enabled = false;
                cmbUserMaster.Enabled = false;
                cmbSeller.Enabled = false;
                dgvPurchaseContract.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                btnApprove.Enabled = false;
                btnAdd.Enabled = false;
            }
            // dtpPurchaseContractDate.Enabled = false;
        }


        private void Calculate(object sender, DataGridViewCellEventArgs e)
        {
            object Weight = dgvPurchaseContract.CurrentRow.Cells["Weight"].Value;
            object Price = dgvPurchaseContract.CurrentRow.Cells["Price"].Value;
            double WeighValue = 0;
            double PriceValue = 0;
            if (Weight != null)
                WeighValue = Double.Parse(Weight.ToString());
            if (Price != null)
                PriceValue = Double.Parse(Price.ToString());
            dgvPurchaseContract.CurrentRow.Cells["TotalAmount"].Value = WeighValue * PriceValue;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void FrmDetailPurchaseContract_Load(object sender, EventArgs e)
        {
            
            SellerMasterBL sellerMasterBL = new SellerMasterBL();
            cmbSeller.DataSource = sellerMasterBL.GetSeller();
            cmbSeller.DisplayMember = "CompanyName";
            cmbSeller.ValueMember = "ID";

            UserMasterBL userMasterBL = new UserMasterBL();
            cmbUserMaster.DataSource = userMasterBL.GetUserMaster();
            cmbUserMaster.DisplayMember = "UserName";
            cmbUserMaster.ValueMember = "UserName";

            cmbApprovedBy.DataSource = userMasterBL.GetUserMaster();
            cmbApprovedBy.DisplayMember = "UserName";
            cmbApprovedBy.ValueMember = "UserName";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPurchaseContract frmPurchaseContract = new FrmPurchaseContract();
            frmPurchaseContract.MdiParent = this.MdiParent;
            frmPurchaseContract.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvPurchaseContract.Rows.Add();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvPurchaseContract.CurrentRow != null)
            {
                dgvPurchaseContract.Rows.Remove(dgvPurchaseContract.CurrentRow);
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            MessageBox.Show("Save Successfully!");
        }

        private void Save()
        {
            PurchaseContractBL purchaseContractBL = new PurchaseContractBL();
            PurchaseContractDetailBL contractDetailBL = new PurchaseContractDetailBL();
            var sellerID = int.Parse(cmbSeller.SelectedValue.ToString());
            var userID = (cmbUserMaster.SelectedValue.ToString());
            var ApprovedBy = (cmbUserMaster.SelectedValue.ToString());
            if (table == null)
            {
                //var sellerID = int.Parse(((DataRowView)cmbSeller.SelectedItem)[1].ToString());
                purchaseContractId = purchaseContractBL.AddPurchaseContract(dtpPurchaseContractDate.Value, userID, sellerID, ApprovedBy);
            }
            else
            {
                purchaseContractId = (int)table.Rows[0]["PurchaseContractID"];
                purchaseContractBL.UpdatePurchaseContract(dtpPurchaseContractDate.Value, userID, sellerID, purchaseContractId, ApprovedBy);
                contractDetailBL.DeletePurchaseContractDetail(purchaseContractId);
            }

            foreach (DataGridViewRow row in dgvPurchaseContract.Rows)
            //for (int i=0;i< dgvPurchaseContract.Rows.Count;i++)
            {
                //var row = dgvPurchaseContract.Rows[i];
                var weight = Decimal.Parse(row.Cells["Weight"].Value.ToString());
                var price = Decimal.Parse(row.Cells["Price"].Value.ToString());
                var totalAmount = Decimal.Parse(row.Cells["TotalAmount"].Value.ToString());
                var rawmaterialID = int.Parse(row.Cells["Product"].Value.ToString());
                contractDetailBL.AddPurchaseContractDetail(weight, price, totalAmount, purchaseContractId, rawmaterialID);
            }
        }

        private void cmbSeller_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            Save();

            PurchaseContractBL purchaseContract = new PurchaseContractBL();
            if (table != null)
            {
                purchaseContractId = (int)table.Rows[0]["PurchaseContractID"];
            }
            purchaseContract.ApprovePurchaseContract(purchaseContractId,cmbApprovedBy.SelectedValue.ToString());
            MessageBox.Show("Approved Successfully");
        }
    }
}
