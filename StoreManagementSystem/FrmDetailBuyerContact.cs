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
    public partial class FrmDetailBuyerContact : Form
    {
        DataTable table;
        int BuyerMasterID;

        public FrmDetailBuyerContact(int BuyerID)
        {
            InitializeComponent();
            BuyerMasterID = BuyerID;
        }

        public void LoadBuyerContact()
        {
            // frmSellerContact frmSeller = new frmSellerContact();
            //frmSeller.MdiParent = this.MdiParent;
            //frmSeller.Show();
            FrmdetailBuyerMaster detailSeller = new FrmdetailBuyerMaster(BuyerMasterID);
            detailSeller.MdiParent = this.MdiParent;
            detailSeller.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuyerContactBL contactBL = new BuyerContactBL();
            if (table == null)
            {
                contactBL.AddBuyerContact(txtName.Text, txtMobile.Text, txtEmail.Text, txtWhatsapp.Text, BuyerMasterID);
            }
            else
            {
                contactBL.UpdateBuyerContact(txtName.Text, txtMobile.Text, txtEmail.Text, txtWhatsapp.Text, (int)table.Rows[0]["BuyerMasterID"]);
            }
            this.Close();
            LoadBuyerContact();
        }

        public void SetBuyerContact(int ID)
        {
            BuyerContactBL sellerContactBL = new BuyerContactBL();
            table = sellerContactBL.GetContactById(ID);
            txtName.Text = table.Rows[0]["Name"].ToString();
            txtMobile.Text = table.Rows[0]["Mobile"].ToString();
            txtEmail.Text = table.Rows[0]["Email"].ToString();
            txtWhatsapp.Text = table.Rows[0]["Whatsapp"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadBuyerContact();
            this.Close();
        }
    }
}
