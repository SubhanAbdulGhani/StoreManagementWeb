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
    public partial class FrmDetailSellerAddress : Form
    {
        DataTable table;
        int SellerMasterID;

        public FrmDetailSellerAddress(int sellerID)
        {
            InitializeComponent();
            SellerMasterID = sellerID;
        }

        public void LoadSellerAddress()
        {
            // frmSellerContact frmSeller = new frmSellerContact();
            //frmSeller.MdiParent = this.MdiParent;
            //frmSeller.Show();
            DetailSellerMaster detailSeller = new DetailSellerMaster(SellerMasterID);
            detailSeller.MdiParent = this.MdiParent;
            detailSeller.Show();
            detailSeller.SetSellerMaster(SellerMasterID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellerAddressBL addressBL = new SellerAddressBL();
            if (table == null)
            {
                addressBL.AddSellerAddress(txtAddress.Text, txtCity.Text, txtPhone.Text, txtStreet.Text, SellerMasterID);
            }
            else
            {
                addressBL.UpdateSellerAddress(txtAddress.Text, txtCity.Text, txtPhone.Text, txtStreet.Text, (int)table.Rows[0]["SellerAddressID"]);
            }
            this.Close();
            LoadSellerAddress();
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            DetailSellerMaster sellerMaster = new DetailSellerMaster(SellerMasterID);
            sellerMaster.Show();
            this.Close();
        }

        public void SetSellerAddress(int ID)
        {
            SellerAddressBL sellerContactBL = new SellerAddressBL();
            table = sellerContactBL.GetAddressById(ID);
            txtAddress.Text = table.Rows[0]["Address"].ToString();
            txtCity.Text = table.Rows[0]["City"].ToString();
            txtPhone.Text = table.Rows[0]["Phone"].ToString();
            txtStreet.Text = table.Rows[0]["Street"].ToString();
        }

        private void FrmDetailSellerAddress_Load(object sender, EventArgs e)
        {

        }
    }
}
