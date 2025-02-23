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
    public partial class rptFrmUnglazeItemStock : Form
    {
        public rptFrmUnglazeItemStock()
        {
            InitializeComponent();
        }

        public void UnglazeStock()
        {
            try
            {
                UnGlazeStockCompanyDAL dal = new UnGlazeStockCompanyDAL();
                rptUnglazeStock unglazeReport = new rptUnglazeStock();
                unglazeReport.SetDataSource(dal.getStockReport().Tables[0]);
                crvUnglazedItemStock.ReportSource = unglazeReport;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UnglazeStockByDT(DataTable dt)
        {
            try
            {
                rptUnglazeStock unglazeReport = new rptUnglazeStock();
                unglazeReport.SetDataSource(dt);
                crvUnglazedItemStock.ReportSource = unglazeReport;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void glazedItemStock()
        {
            try
            {
                GlazeStockCompanyDAL dal = new GlazeStockCompanyDAL();
                rptGlazedStockReport report = new rptGlazedStockReport();
                report.Load();
                report.SetDataSource(dal.getStockReportDataTable());
                crvUnglazedItemStock.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void glazedItemStockByDT(DataTable dt)
        {
            try
            {
                rptGlazedStockReport report = new rptGlazedStockReport();
                report.Load();
                report.SetDataSource(dt);
                crvUnglazedItemStock.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void readyItemStock()
        {
            try
            {
                ReadyItemStockDAL dal = new ReadyItemStockDAL();
                rptReadyItemStock report = new rptReadyItemStock();
                report.SetDataSource(dal.getStockReport().Tables[0]);
                crvUnglazedItemStock.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void readyItemStockByDT(DataTable dt)
        {
            try
            {
                ReadyItemStockDAL dal = new ReadyItemStockDAL();
                rptReadyItemStock report = new rptReadyItemStock();
                report.SetDataSource(dt);
                crvUnglazedItemStock.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
