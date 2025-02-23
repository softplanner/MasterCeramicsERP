using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MCERP.DAL;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace MasterCeramicsERP
{
    public partial class rptFrmSalesGatePassBill : Form
    {
        public rptFrmSalesGatePassBill()
        {
            InitializeComponent();
        }
        public void getReport(DataSet dataSet)
        {
            try
            {
                rptSalesGatePassBill report = new rptSalesGatePassBill();
                report.SetDataSource(dataSet.Tables[0]);
                crvKillenFeed.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
