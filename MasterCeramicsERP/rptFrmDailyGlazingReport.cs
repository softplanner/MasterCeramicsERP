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
    public partial class rptFrmDailyGlazingReport : Form
    {
        public rptFrmDailyGlazingReport()
        {
            InitializeComponent();
        }
        public void reportByDate(DateTime date)
        {
            try
            {
                DailyGlazingReportDAL dal = new DailyGlazingReportDAL();
                rptDailyGlazingReport report = new rptDailyGlazingReport();
                report.SetDataSource(dal.getDailyStockReport(date).Tables[0]);
                crvDailyGlazingReport.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByDateDT(DataTable dt)
        {
            try
            {
                DailyGlazingReportDAL dal = new DailyGlazingReportDAL();
                rptDailyGlazingReport report = new rptDailyGlazingReport();
                report.SetDataSource(dt);
                crvDailyGlazingReport.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByMonth(DateTime date)
        {
            try
            {
                DailyGlazingReportDAL dal = new DailyGlazingReportDAL();
                rptDailyGlazingMon report = new rptDailyGlazingMon();
                report.SetDataSource(dal.getMonthlyStockReport(date).Tables[0]);
                crvDailyGlazingReport.ReportSource = report;
                //-----for test pupose only
                CrystalDecisions.CrystalReports.Engine.TextObject temp =
                ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text15"]);
                temp.Text = "Monthly Report";
                //----- end test
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByMonthDT(DataTable dt)
        {
            try
            {
                DailyGlazingReportDAL dal = new DailyGlazingReportDAL();
                rptDailyGlazingMon report = new rptDailyGlazingMon();
                report.SetDataSource(dt);
                crvDailyGlazingReport.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void getYearlyReport(DateTime date)
        {
            try
            {
                DailyGlazingReportDAL dal = new DailyGlazingReportDAL();
                rptDailyGlazingMon report = new rptDailyGlazingMon();
                report.SetDataSource(dal.getYearlyGlazingReport(date).Tables[0]);
                crvDailyGlazingReport.ReportSource = report;
                //-----for test pupose only
                CrystalDecisions.CrystalReports.Engine.TextObject temp =
                ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text15"]);
                temp.Text = "Yearly Report";
                //----- end test
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
