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
    public partial class FrmDetailBuyerAddress : Form
    {
        DataTable table;
        int BuyerMasterID;

        public FrmDetailBuyerAddress(int ID)
        {
            InitializeComponent();
            BuyerMasterID = ID;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadBuyerAddress()
        {
            // frmSellerContact frmSeller = new frmSellerContact();
            //frmSeller.MdiParent = this.MdiParent;
            //frmSeller.Show();
            FrmdetailBuyerMaster detailSeller = new FrmdetailBuyerMaster(BuyerMasterID);
            detailSeller.MdiParent = this.MdiParent;
            detailSeller.Show();
            detailSeller.SetBuyerMaster(BuyerMasterID);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            BuyerAddressBL addressBL = new BuyerAddressBL();
            if (table == null)
            {
                addressBL.AddBuyerAddress(txtAddress.Text, txtCity.Text, txtPhone.Text, txtStreet.Text, BuyerMasterID);
            }
            else
            {
                addressBL.UpdateBuyerAddress(txtAddress.Text, txtCity.Text, txtPhone.Text, txtStreet.Text, (int)table.Rows[0]["SellerAddressID"]);
            }
            this.Close();
            LoadBuyerAddress();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmdetailBuyerMaster buyerMaster = new FrmdetailBuyerMaster(BuyerMasterID);
            buyerMaster.Show();
            this.Close();
        }

        public void SetBuyerAddress(int ID)
        {
            BuyerAddressBL buyerAddressBL = new BuyerAddressBL();
            table = buyerAddressBL.GetAddressById(ID);
            txtAddress.Text = table.Rows[0]["Address"].ToString();
            txtCity.Text = table.Rows[0]["City"].ToString();
            txtPhone.Text = table.Rows[0]["Phone"].ToString();
            txtStreet.Text = table.Rows[0]["Street"].ToString();
        }
    }
}
