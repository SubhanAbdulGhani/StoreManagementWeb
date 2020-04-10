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
    public partial class frmDetailRawMaterial : Form
    {
        DataTable table;

        public frmDetailRawMaterial()
        {
            InitializeComponent();
        }

        private void LoadRawMaterial()
        {
            frmRawMaterial rawMaterial = new frmRawMaterial();
            rawMaterial.MdiParent = this.MdiParent;
            rawMaterial.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RawMaterialBL raw = new RawMaterialBL();
            if (table == null)
            {
                raw.AddRawMaterial(txtType.Text, txtColor.Text, txtName.Text);
            }
            else
            {
                raw.UpdateRawMaterial((int)table.Rows[0]["RawMaterialID"], txtType.Text,txtColor.Text,txtName.Text);
            }
            this.Close();
            LoadRawMaterial();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmRawMaterial rawMaterial = new frmRawMaterial();
            rawMaterial.MdiParent = this.MdiParent;
            rawMaterial.Show();
            this.Close();
        }

        public void SetRawMaterial(int ID)
        {
            RawMaterialBL rawBL = new RawMaterialBL();
            table = rawBL.GetRawMaterialByID(ID);
            txtType.Text = table.Rows[0]["Type"].ToString();
            txtColor.Text = table.Rows[0]["Color"].ToString();
            txtName.Text = table.Rows[0]["Name"].ToString();
        }

    }
}
