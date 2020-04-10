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
    public partial class FrmProductCategory : Form
    {
        DataTable table;

        public FrmProductCategory()
        {
            InitializeComponent();
        }

        private void LoadProductCategory()
        {
            ProductCategoryBL ProductCategory = new ProductCategoryBL();
            dgvProductCategory.DataSource = ProductCategory.GetProductCategory();
           
        }

        private void FrmProductCategory_Load(object sender, EventArgs e)
        {
            LoadProductCategory();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FrmDetailProductCategory productCategory = new FrmDetailProductCategory();
            productCategory.MdiParent = this.MdiParent;
            productCategory.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductCategoryBL contactBL = new ProductCategoryBL();
            if (dgvProductCategory.SelectedRows.Count > 0 && dgvProductCategory.SelectedRows[0].Cells["ID"].Value != null)
            {
                var id = (int)dgvProductCategory.SelectedRows[0].Cells["ID"].Value;
                contactBL.DeleteProductCategory(id);
                ProductCategoryBL productCategoryBL = new ProductCategoryBL();
                dgvProductCategory.DataSource = productCategoryBL.GetProductCategory();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvProductCategory.SelectedRows.Count > 0)
            {
                var id = (int)dgvProductCategory.SelectedRows[0].Cells["ID"].Value;
                FrmDetailProductCategory detailBuyer = new FrmDetailProductCategory();
                detailBuyer.SetProductCategory(id);
                detailBuyer.Show();
                this.Close();
            }
        }
    }
}
