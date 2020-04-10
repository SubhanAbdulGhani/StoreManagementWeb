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
    public partial class FrmDetailProductCategory : Form
    {
        DataTable table;

        public FrmDetailProductCategory()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            FrmProductCategory frmProduct = new FrmProductCategory();
            frmProduct.Show();
            this.Close();
        }

        public void SetProductCategory(int ID)
        {
            ProductCategoryBL productCategoryBL = new ProductCategoryBL();
            table = productCategoryBL.GetProductCategoryByID(ID);
            txtName.Text = table.Rows[0]["Name"].ToString();
        }

        public void LoadProductCategory()
        {
            FrmProductCategory detailSeller = new FrmProductCategory();
            detailSeller.MdiParent = this.MdiParent;
            detailSeller.Show();

        }

        private void Save_Click(object sender, EventArgs e)
        {
            ProductCategoryBL contactBL = new ProductCategoryBL();
            if (table == null)
            {
                contactBL.AddProductCategory(txtName.Text);
            }
            else
            {
                contactBL.UpdateProductCategory((int)table.Rows[0]["ID"], txtName.Text);
            }
            this.Close();
            LoadProductCategory();
        }
    }
}
