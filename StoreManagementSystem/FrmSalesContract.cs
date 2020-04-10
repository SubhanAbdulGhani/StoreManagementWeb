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
    public partial class FrmSalesContract : Form
    {
        public FrmSalesContract()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmDetailSalesContract detailPSalesContract = new FrmDetailSalesContract();
            detailPSalesContract.MdiParent = this.MdiParent;
            detailPSalesContract.Show();
            this.Close();
        }

        private void LoadSalesContract()
        {
            SalesContractBL salesContract = new SalesContractBL();
            dgvSalesContract.DataSource = salesContract.GetSalesContract();

        }

        private void FrmSalesContract_Load(object sender, EventArgs e)
        {
            LoadSalesContract();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSalesContract.SelectedRows.Count > 0 && (bool)dgvSalesContract.SelectedRows[0].Cells["Approve"].Value == false)
            {
                var id = (int)dgvSalesContract.SelectedRows[0].Cells["SalesContractID"].Value;
                FrmDetailSalesContract detailSales = new FrmDetailSalesContract(id);
                detailSales.SetSalesContract(id);
                detailSales.Show();
            }
            else
            {
                this.Close();
                MessageBox.Show("You cannot Edit");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SalesContractDetailBL contractDetailBL = new SalesContractDetailBL();

            SalesContractBL productBL = new SalesContractBL();
            if (dgvSalesContract.SelectedRows.Count > 0)
            {
                var id = (int)dgvSalesContract.SelectedRows[0].Cells["SalesContractID"].Value;
                contractDetailBL.DeleteSalesContractDetail(id);
                productBL.DeleteSalesContract(id);
                LoadSalesContract();
            }
        }
    }
}
