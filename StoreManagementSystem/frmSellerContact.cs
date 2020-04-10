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
    public partial class frmSellerContact : Form
    {
        public frmSellerContact()
        {
            InitializeComponent();
        }

        private void LoadSellerContact()
        {
            SellerContactBL seller = new SellerContactBL();
            dgvSellerContact.DataSource = seller.GetSellerContact();
        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    frmDetailSellerContact sellerContact = new frmDetailSellerContact();
        //    sellerContact.Show();
        //    this.Close();
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SellerContactBL contactBL = new SellerContactBL();
            if(dgvSellerContact.SelectedRows.Count > 0)
            {
                var id = (int)dgvSellerContact.SelectedRows[0].Cells["ID"].Value;
                contactBL.DeleteSellerContact(id);
                LoadSellerContact();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    frmDetailSellerContact detailContact = new frmDetailSellerContact();
        //    if (dgvSellerContact.SelectedRows.Count > 0)
        //    {
        //        var id = (int)dgvSellerContact.SelectedRows[0].Cells["ID"].Value;
        //        detailContact.SetSellerContact(id);
        //        detailContact.Show();
        //    }
        //}
    }
}
