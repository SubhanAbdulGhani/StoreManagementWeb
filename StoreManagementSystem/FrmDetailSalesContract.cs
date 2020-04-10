using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BuisnessLayer;

namespace StoreManagementSystem
{
    public partial class FrmDetailSalesContract : Form
    {
        DataTable table;
        int salesContractId = 0;

        public FrmDetailSalesContract()
        {
            InitializeComponent();
            LoadData();
        }

        public FrmDetailSalesContract(int SalesContractID)
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            ProductBL productBL = new ProductBL();
            //Create the new combobox column and set it's DataSource to a DataTable
            var col = (DataGridViewComboBoxColumn)dgvDetailSalesContract.Columns["Product"];
            col.DataSource = productBL.GetProducts();
            col.ValueMember = "ProductID";
            col.DisplayMember = "Name";
            col.DataPropertyName = "ProductID";

            dgvDetailSalesContract.CellEndEdit += Calculate;
        }

        public void SetSalesContract(int ID)
        {
            SalesContractBL salesContractBL = new SalesContractBL();
            table = salesContractBL.GetSalesContractByID(ID);
            dtpSalesContractDate.Value = DateTime.Parse(table.Rows[0]["SaleContractDate"].ToString());
            cmbUserMaster.SelectedValue = table.Rows[0]["PreparedBy"].ToString();
            cmbBuyer.SelectedValue = table.Rows[0]["BuyerID"];
            //txtCompanyName.Text = table.Rows[0]["CompanyName"].ToString();

            SalesContractDetailBL contractDetailBL = new SalesContractDetailBL();
            var tbl = contractDetailBL.GetSalesContractDetailByID((int)table.Rows[0]["SalesContractID"]);

            //foreach (var row in tbl.Rows)
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                var index = dgvDetailSalesContract.Rows.Add();
                dgvDetailSalesContract.Rows[index].Cells["Weight"].Value = tbl.Rows[i]["Weight"];
                dgvDetailSalesContract.Rows[index].Cells["Price"].Value = tbl.Rows[i]["Price"];
                dgvDetailSalesContract.Rows[index].Cells["TotalAmount"].Value = tbl.Rows[i]["TotalAmount"];
                dgvDetailSalesContract.Rows[index].Cells["Product"].Value = tbl.Rows[i]["ProductID"];
            }
        }

        private void Calculate(object sender, DataGridViewCellEventArgs e)
        {
            object Weight = dgvDetailSalesContract.CurrentRow.Cells["Weight"].Value;
            object Price = dgvDetailSalesContract.CurrentRow.Cells["Price"].Value;
            double WeighValue = 0;
            double PriceValue = 0;
            if (Weight != null)
                WeighValue = Double.Parse(Weight.ToString());
            if (Price != null)
                PriceValue = Double.Parse(Price.ToString());
            dgvDetailSalesContract.CurrentRow.Cells["TotalAmount"].Value = WeighValue * PriceValue;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmSalesContract frmSaleContract = new FrmSalesContract();
            frmSaleContract.MdiParent = this.MdiParent;
            frmSaleContract.Show();
            this.Close();
        }

        private void FrmDetailSalesContract_Load(object sender, EventArgs e)
        {
            BuyerMasterBL buyerMasterBL = new BuyerMasterBL();
            cmbBuyer.DataSource = buyerMasterBL.GetBuyerMaster();
            cmbBuyer.DisplayMember = "CompanyName";
            cmbBuyer.ValueMember = "ID";

            UserMasterBL userBL = new UserMasterBL();
            cmbUserMaster.DataSource = userBL.GetUserMaster();
            cmbUserMaster.DisplayMember = "UserName";
            cmbUserMaster.ValueMember = "UserName";

            cmbApprovedBy.DataSource = userBL.GetUserMaster();
            cmbApprovedBy.DisplayMember = "UserName";
            cmbApprovedBy.ValueMember = "UserName";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvDetailSalesContract.Rows.Add();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDetailSalesContract.CurrentRow != null)
            {
                dgvDetailSalesContract.Rows.Remove(dgvDetailSalesContract.CurrentRow);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SalesContractBL salesContractBL = new SalesContractBL();
            SalesContractDetailBL contractDetailBL = new SalesContractDetailBL();
            var buyerID = int.Parse(cmbBuyer.SelectedValue.ToString());
            var userID = (cmbUserMaster.SelectedValue.ToString());
            var ApprovedBy = (cmbUserMaster.SelectedValue.ToString());
            //int salesContractId = 0;
            if (table == null)
            {
                //var sellerID = int.Parse(((DataRowView)cmbSeller.SelectedItem)[1].ToString());
                salesContractId = salesContractBL.AddSalesContract(dtpSalesContractDate.Value, userID, buyerID, ApprovedBy);
            }
            else
            {
                salesContractId = (int)table.Rows[0]["SalesContractID"];
                salesContractBL.UpdateSalesContract(dtpSalesContractDate.Value, userID, buyerID, salesContractId, ApprovedBy);
                contractDetailBL.DeleteSalesContractDetail(salesContractId);
            }

            foreach (DataGridViewRow row in dgvDetailSalesContract.Rows)
            //for (int i=0;i< dgvPurchaseContract.Rows.Count;i++)
            {
                //var row = dgvPurchaseContract.Rows[i];
                var weight = Decimal.Parse(row.Cells["Weight"].Value.ToString());
                var price = Decimal.Parse(row.Cells["Price"].Value.ToString());
                var totalAmount = Decimal.Parse(row.Cells["TotalAmount"].Value.ToString());
                var rawmaterialID = int.Parse(row.Cells["Product"].Value.ToString());
                contractDetailBL.AddSalesContractDetail(weight, price, totalAmount, salesContractId, rawmaterialID);
            }

            MessageBox.Show("Save Successfully!");
        }

        private void brnApprove_Click(object sender, EventArgs e)
        {
            SalesContractBL salesContract = new SalesContractBL();
            if (table != null)
            {
                 salesContractId = (int)table.Rows[0]["SalesContractID"];
            }
            salesContract.ApproveSalesContract(salesContractId, cmbApprovedBy.SelectedValue.ToString());
            MessageBox.Show("Approved Successfully");
        }
    }
}
