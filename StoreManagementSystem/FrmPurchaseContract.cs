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
    public partial class FrmPurchaseContract : Form
    {
        public FrmPurchaseContract()
        {
            InitializeComponent();
        }

        private void LoadPurchaseContract()
        {
            PurchaseContractBL purchaseContract = new PurchaseContractBL();
            dgvPurchaseContract.DataSource = purchaseContract.GetPurchaseContract();

        }


        private void FrmPurchaseContract_Load(object sender, EventArgs e)
        {
            LoadPurchaseContract();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDetailPurchaseContract detailPurchaseContract = new FrmDetailPurchaseContract();
            detailPurchaseContract.MdiParent = this.MdiParent;
            detailPurchaseContract.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PurchaseContractDetailBL contractDetailBL = new PurchaseContractDetailBL();
           
            PurchaseContractBL productBL = new PurchaseContractBL();
            if (dgvPurchaseContract.SelectedRows.Count > 0)
            {
                var id = (int)dgvPurchaseContract.SelectedRows[0].Cells["PurchaseContractID"].Value;
                contractDetailBL.DeletePurchaseContractDetail(id);
                productBL.DeletePurchaseContract(id);
                LoadPurchaseContract();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
        //    if (dgvPurchaseContract.SelectedRows.Count > 0 && (bool)dgvPurchaseContract.SelectedRows[0].Cells["Approve"].Value == false)
        //    {
        //        var id = (int)dgvPurchaseContract.SelectedRows[0].Cells["PurchaseContractID"].Value;
        //        FrmDetailPurchaseContract detailSeller = new FrmDetailPurchaseContract(id);
        //        detailSeller.SetPurchaseContract(id);
        //        detailSeller.Show();
        //    }
        //    //this.Close();
        //    else{
        //        this.Close();
        //        MessageBox.Show("You cannot Edit");
        //    }

            if (dgvPurchaseContract.SelectedRows.Count > 0)
            {
                var id = (int)dgvPurchaseContract.SelectedRows[0].Cells["PurchaseContractID"].Value;
        FrmDetailPurchaseContract detailSeller = new FrmDetailPurchaseContract(id);
        detailSeller.SetPurchaseContract(id);
                detailSeller.Show();
            }
            this.Close();
        }
}
}
