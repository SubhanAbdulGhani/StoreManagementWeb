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
    public partial class FrmMDIParent : Form
    {
        private int childFormNumber = 0;

        public FrmMDIParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ShowSellerMaster()
        {
            FrmSellerMaster frmSeller = new FrmSellerMaster();
            frmSeller.MdiParent = this;
            frmSeller.Show();
        }

        private void sellerMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSellerMaster();
        }

        private void ShowRawMaterial()
        {
            frmRawMaterial frmRaw = new frmRawMaterial();
            frmRaw.MdiParent = this;
            frmRaw.Show();
        }

        private void rawMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRawMaterial();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void tsSellerMaster_Click(object sender, EventArgs e)
        {
            ShowSellerMaster();
        }

        private void tsRawMaterial_Click(object sender, EventArgs e)
        {
            ShowRawMaterial();
        }

        private void ShowSellerContact()
        {
            frmSellerContact sellerContact = new frmSellerContact();
            sellerContact.MdiParent = this;
            sellerContact.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ShowSellerContact();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void ShowBuyerMaster()
        {
            FrmBuyerMaster frmBuy = new FrmBuyerMaster();
            frmBuy.MdiParent = this;
            frmBuy.Show();
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            ShowBuyerMaster();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            FrmPurchaseContract purchaseContract = new FrmPurchaseContract();
            purchaseContract.MdiParent = this;
            purchaseContract.Show();
        }

        private void toolStripButton1_Click_3(object sender, EventArgs e)
        {
            FrmProductCategory productCategory = new FrmProductCategory();
            productCategory.MdiParent = this;
            productCategory.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmProduct product = new FrmProduct();
            product.MdiParent = this;
            product.Show();
        }

        private void tsbSalesContract_Click(object sender, EventArgs e)
        {
            FrmSalesContract salesContract = new FrmSalesContract();
            salesContract.MdiParent = this;
            salesContract.Show();
        }

        private void tsbUserMaster_Click(object sender, EventArgs e)
        {
            FrmUserMaster userMaster = new FrmUserMaster();
            userMaster.MdiParent = this;
            userMaster.Show();
        }

        private void tsbInventory_Click(object sender, EventArgs e)
        {
            FrmInventory frmInventory = new FrmInventory();
            frmInventory.MdiParent = this;
            frmInventory.Show();
        }

        private void tsbReport_Click(object sender, EventArgs e)
        {
            RDLC_ReportTutorail tutorail = new RDLC_ReportTutorail();
            tutorail.Show();
        }
    }
}
