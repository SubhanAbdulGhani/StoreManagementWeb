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
    public partial class FrmInventory : Form
    {
        public FrmInventory()
        {
            InitializeComponent();
        }

        private void LoadInventory()
        {
            InventoryBL inventory = new InventoryBL();
            //dgvInventory.DataSource = inventory.GetInventory();
        }

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            LoadInventory();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmDetailInventory detailInventory = new FrmDetailInventory();
            detailInventory.MdiParent = this.MdiParent;
            detailInventory.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            InventoryBL inventoryBL = new InventoryBL();
            if (dgvInventory.SelectedRows.Count > 0)
            {
                var id = (int)dgvInventory.SelectedRows[0].Cells["ID"].Value;
                //inventoryBL.DeleteInventory(id);
                //LoadInventory();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                var id = (int)dgvInventory.SelectedRows[0].Cells["ID"].Value;
                FrmDetailInventory detailInventory = new FrmDetailInventory();
                detailInventory.SetInventory(id);
                detailInventory.Show();
                this.Close();
            }
        }
    }
}
