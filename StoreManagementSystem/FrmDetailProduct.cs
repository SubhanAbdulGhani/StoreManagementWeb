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
    public partial class FrmDetailProduct : Form
    {
        DataTable table;

        public FrmDetailProduct()
        {
            InitializeComponent();
            LoadProduct();
        }

        public FrmDetailProduct(int ProductID)
        {
            InitializeComponent();
            LoadProduct();
            SetProducts(ProductID);
        }

        public void SetProducts(int ID)
        {
            ProductBL productBL = new ProductBL();
            table = productBL.GetProductsById(ID);
            txtName.Text = table.Rows[0]["Name"].ToString();
            txtType.Text = table.Rows[0]["Type"].ToString();
            txtColor.Text = table.Rows[0]["Color"].ToString();
            ProductCategoryBL productCategoryBL = new ProductCategoryBL();
            cmbProductCategory.SelectedValue = (int)table.Rows[0]["ProductCategoryID"];

        }

        private void LoadProduct()
        {
            ProductCategoryBL productBL = new ProductCategoryBL();
            cmbProductCategory.DataSource = productBL.GetProductCategory();
            cmbProductCategory.DisplayMember = "Name";
            cmbProductCategory.ValueMember = "ID";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            FrmProduct product = new FrmProduct();
            product.Show();
            product.MdiParent = this.MdiParent;
            //product.Show();
            this.Close();
        }

        private void LoadProducts()
        {
            FrmProduct frmProduct = new FrmProduct();
            frmProduct.MdiParent = this.MdiParent;
            frmProduct.Show();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            ProductBL product = new ProductBL();
            if (table == null)
            {
                product.AddProducts(txtName.Text, txtType.Text, txtColor.Text ,int.Parse(cmbProductCategory.SelectedValue.ToString()));
            }
            else
            {
                product.UpdateProducts((int)table.Rows[0]["ProductID"], txtName.Text, txtType.Text, txtColor.Text, int.Parse(cmbProductCategory.SelectedValue.ToString()));
            }
            this.Close();
            LoadProducts();
        }

        private void FrmDetailProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
