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
    public partial class FrmDetailInventory : Form
    {
        DataTable table;

        public FrmDetailInventory()
        {
            InitializeComponent();
        }

        public void SetInventory(int ID)
        {
            InventoryBL inventoryBL = new InventoryBL();
            //table = inventoryBL.GetInventoryByID(ID);
            txtProductID.Text = table.Rows[0]["ProductID"].ToString();
            txtQuantity.Text = table.Rows[0]["Quantity"].ToString();
            txtUpdatedBy.Text = table.Rows[0]["UpdatedBy"].ToString();
            dtpUpdatedDate.Value = DateTime.Parse(table.Rows[0]["UpdatedDate"].ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmInventory inventory = new FrmInventory();
            inventory.MdiParent = this.MdiParent;
            inventory.Show();
            this.Hide();
        }

        private void LoadInventory()
        {
            FrmInventory inventory = new FrmInventory();
            inventory.MdiParent = this.MdiParent;
            inventory.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InventoryBL inventory = new InventoryBL();
            if (table == null)
            {
                //inventory.AddInventory(int.Parse(txtProductID.Text.ToString()), int.Parse(txtQuantity.Text.ToString()), dtpUpdatedDate.Value, txtUpdatedBy.Text);
            }
            else
            {
                //inventory.UpdateInventory((int)table.Rows[0]["ID"], int.Parse(txtProductID.Text), int.Parse(txtQuantity.Text), dtpUpdatedDate.Value, txtUpdatedBy.Text);
            }
            this.Close();
            LoadInventory();
        }
    }
}
