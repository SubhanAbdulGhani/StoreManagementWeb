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
    public partial class frmRawMaterial : Form
    {
        public frmRawMaterial()
        {
            InitializeComponent();
        }

        private void frmRawMaterial_Load(object sender, EventArgs e)
        {
            LoadRawMaterial();
        }

        private void LoadRawMaterial()
        {
            RawMaterialBL rawMaterial = new RawMaterialBL();
            dgvRawMaterial.DataSource = rawMaterial.GetRawMaterial();
        }
        

        private void btnAddRawMaterial_Click(object sender, EventArgs e)
        {
            frmDetailRawMaterial frmDetail = new frmDetailRawMaterial();
            frmDetail.MdiParent = this.MdiParent;
            frmDetail.Show();
            this.Close();
           
        }

        private void btnDeleteRawMaterial_Click(object sender, EventArgs e)
        {
            RawMaterialBL rawMaterial = new RawMaterialBL();
            var id = (int)dgvRawMaterial.SelectedRows[0].Cells["RawMaterialID"].Value;
            rawMaterial.DeleteRawMaterial(id);
            LoadRawMaterial();
        }

        private void btnUpdateRawMaterial_Click(object sender, EventArgs e)
        {
            frmDetailRawMaterial frmDetail = new frmDetailRawMaterial();
            if (dgvRawMaterial.SelectedRows.Count > 0)
            {
                var id = (int)dgvRawMaterial.SelectedRows[0].Cells["RawMaterialID"].Value;
                frmDetail.SetRawMaterial(id);
                frmDetail.Show();
                this.Close();
                
            }
        }
    }
}
