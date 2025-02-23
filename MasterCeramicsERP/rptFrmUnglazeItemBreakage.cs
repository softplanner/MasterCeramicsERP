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
    public partial class rptFrmUnglazeItemBreakage : Form
    {
        public rptFrmUnglazeItemBreakage()
        {
            InitializeComponent();
        }

        public void reportByDate(DateTime date)
        {
            try
            {
                GreenWareHouseBreakageDAL dal = new GreenWareHouseBreakageDAL();
                rptUnglazeItemBreak report = new rptUnglazeItemBreak();
                report.SetDataSource(dal.getDailyReport(date).Tables[0]);
                crvUnglazeItemBreakage.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByMonth(DateTime date)
        {
            try
            {
                GreenWareHouseBreakageDAL dal = new GreenWareHouseBreakageDAL();
                rptUnglazeitemBreakageMonthly report = new rptUnglazeitemBreakageMonthly();
                report.SetDataSource(dal.getMonthlyReportDataset(date).Tables[0]);
                crvUnglazeItemBreakage.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByYear(DateTime date)
        {
            try
            {
           
                GreenWareHouseBreakageDAL dal = new GreenWareHouseBreakageDAL();
                rptUnglazeItemBreakageYearly report = new rptUnglazeItemBreakageYearly();
                report.SetDataSource(dal.getYearlyReportDataset(date).Tables[0]);
                crvUnglazeItemBreakage.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
