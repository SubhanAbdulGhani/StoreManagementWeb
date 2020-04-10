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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void LoadProducts()
        {
            ProductBL product = new ProductBL();
            dgvProducts.DataSource = product.GetProducts();

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            FrmDetailProduct detailProduct = new FrmDetailProduct();
            detailProduct.MdiParent = this.MdiParent;
            detailProduct.Show();
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            ProductBL productBL = new ProductBL();
            if (dgvProducts.SelectedRows.Count > 0)
            {
                var id = (int)dgvProducts.SelectedRows[0].Cells["ProductID"].Value;
                productBL.DeleteProducts(id);
                LoadProducts();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0 )
            {
                var id = (int)dgvProducts.SelectedRows[0].Cells["ProductID"].Value;
                FrmDetailProduct detailProduct = new FrmDetailProduct(id);
                detailProduct.SetProducts(id);
                detailProduct.Show();
                this.Close();
            }
        }
    }
}
