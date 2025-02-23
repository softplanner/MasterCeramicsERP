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
    public partial class rptFrmSaleCreateBill : Form
    {
        public rptFrmSaleCreateBill()
        {
            InitializeComponent();
        }
        public void getReport(DataSet ds)
        {
            try
            {
                rptSaleCreateBill report = new rptSaleCreateBill();
                report.SetDataSource(ds.Tables[0]);
                crvCreateBill.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void printItemPriceList(DataTable dt)
        {
            try
            {
                rptItemPriceList report = new rptItemPriceList();
                report.SetDataSource(dt);
                crvCreateBill.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ReportByDT(DataTable dt)
        {
            try
            {
                rptBill report = new rptBill();
                report.SetDataSource(dt);
                crvCreateBill.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
