using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using DataAccessLayer;
using System.Data;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace StoreManagementSystem
{
    public partial class RDLC_ReportTutorail : Form
    {
        public RDLC_ReportTutorail()
        {
            InitializeComponent();
        }

        private void RDLC_ReportTutorail_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            var connection = ConnectionManager.GetConnection();
            connection.Open();
            var query = "Select * from PurchaseContract";
            SqlCommand sql = new SqlCommand(query,connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            //reportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportDataSource rds = new ReportDataSource("DataSet1", table);
            LocalReport rpt = new LocalReport();
           var reportPath = @"C:\Users\Habib\source\repos\StoreManagementSystem\StoreManagementSystem\ReportTutorialMyInfo.rdlc";
           // var reportPath = Path.GetFullPath("ReportTutorialMyInfo.rdlc");
            //reportViewer1.LocalReport.ReportPath = 
            reportViewer1.LocalReport.ReportPath = reportPath;
            //reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();

           
            //reportViewer1.LocalReport.ReportPath = Server.MapPath("ReportTutorialMyInfo.rdlc");
            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", table));
            //reportViewer1.LocalReport.Refresh();

        }
    }
}
