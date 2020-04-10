using BuisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementSystem
{
    public partial class FrmSellerMaster : Form
    {
        public FrmSellerMaster()
        {
            InitializeComponent();
        }

        private void FrmSellerMaster_Load(object sender, EventArgs e)
        {
            LoadSellerMaster();
        }

        private void LoadSellerMaster()
        {
            SellerMasterBL sellerMasterBL = new SellerMasterBL();
            //lstSellerMaster.DataSource = sellerMasterBL.GetSeller();
            //lstSellerMaster.DisplayMember = "CompanyName";
            
            dgvSellerMaster.DataSource = sellerMasterBL.GetSeller();
            //cbSellerMaster.DataSource = sellerMasterBL.GetSeller();
            //cbSellerMaster.DisplayMember = "CompanyName";
            //lstSellerMaster.ValueMember = "ID";
            //
            //sellerMasterBL.UpdateSellerMaster(2, "OLX");
            //sellerMasterBL.DeleteSellerMaster(1);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //SellerMasterBL sellerMasterBL = new SellerMasterBL();
            //sellerMasterBL.AddSellerMaster(tbSellerMaster.Text);
            //LoadSellerMaster();
            //tbSellerMaster.Text = String.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SellerMasterBL sellerMasterBL = new SellerMasterBL();
            if (dgvSellerMaster.SelectedRows.Count > 0)
            {
                var id = (int)dgvSellerMaster.SelectedRows[0].Cells["ID"].Value;
                sellerMasterBL.DeleteSellerMaster(id);
                LoadSellerMaster();
            }
            //var value = lstSellerMaster.SelectedItem;
            //sellerMasterBL.DeleteSellerMaster((int)((DataRowView)value)[1]);
            //sellerMasterBL.DeleteSellerMaster((int)((DataRowView)value)[1]);
            //LoadSellerMaster();
         }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           // SellerMasterBL sellerMasterBL = new SellerMasterBL();
            //var value = lstSellerMaster.SelectedItem;
            //sellerMasterBL.UpdateSellerMaster((int)((DataRowView)value)[1], updateSellerMaster.Text);
            //LoadSellerMaster();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DetailSellerMaster detailSeller = new DetailSellerMaster();
            detailSeller.MdiParent = this.MdiParent;
            detailSeller.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (dgvSellerMaster.SelectedRows.Count > 0)
            {
                var id = (int)dgvSellerMaster.SelectedRows[0].Cells["ID"].Value;
                DetailSellerMaster detailSeller = new DetailSellerMaster(id);
                detailSeller.SetSellerMaster(id);
                detailSeller.Show();
            }
        }
    }
}
