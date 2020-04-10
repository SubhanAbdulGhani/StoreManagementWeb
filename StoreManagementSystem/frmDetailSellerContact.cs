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
    public partial class frmDetailSellerContact : Form
    {
        DataTable table;
        int SellerMasterID;       

        public frmDetailSellerContact(int sellerID)
        {
            InitializeComponent();
            SellerMasterID = sellerID;
        }

        public void LoadSellerContact()
        {
            // frmSellerContact frmSeller = new frmSellerContact();
            //frmSeller.MdiParent = this.MdiParent;
            //frmSeller.Show();
            DetailSellerMaster detailSeller = new DetailSellerMaster(SellerMasterID);
            detailSeller.MdiParent = this.MdiParent;
            detailSeller.Show();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadSellerContact();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SellerContactBL contactBL = new SellerContactBL();
            if (table == null)
            {
               contactBL.AddSellerContact(txtName.Text, txtMobile.Text, txtEmail.Text, txtWhatsapp.Text,SellerMasterID);
            }
            else
            {
                contactBL.UpdateSellerContact(txtName.Text, txtMobile.Text, txtEmail.Text, txtWhatsapp.Text, (int)table.Rows[0]["SellerContactID"]);
            }
            this.Close();
            LoadSellerContact();
        }

        public void SetSellerContact(int ID)
        {
            SellerContactBL sellerContactBL = new SellerContactBL();
            table = sellerContactBL.GetContactById(ID);
            txtName.Text = table.Rows[0]["Name"].ToString();
            txtMobile.Text = table.Rows[0]["Mobile"].ToString();
            txtEmail.Text = table.Rows[0]["Email"].ToString();
            txtWhatsapp.Text = table.Rows[0]["Whatsapp"].ToString();
        }

        private void frmDetailSellerContact_Load(object sender, EventArgs e)
        {

        }
    }
}
