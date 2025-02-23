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
    public partial class rptFrmDailyKillenReport : Form
    {
        public rptFrmDailyKillenReport()
        {
            InitializeComponent();
        }
        public void reportByDate(DateTime date)
        {
            try
            {
                DailyKillenReportDAL dal = new DailyKillenReportDAL();
                rptDailyKillen report = new rptDailyKillen();
                report.SetDataSource(dal.getDailyKillenReport(date).Tables[0]);
                crvDailyKillenReport.ReportSource = report;
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
                rptDailyKillenReportByDay report = new rptDailyKillenReportByDay();
                report.SetDataSource(dt);
                crvDailyKillenReport.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByDateAndKillen(DateTime date,Int16 killenID)
        {
            try
            {
                DailyKillenReportDAL dal = new DailyKillenReportDAL();
                rptDailyKillenByKillDa report = new rptDailyKillenByKillDa();
                report.SetDataSource(dal.getDailyKillenReportByKillen(date, killenID).Tables[0]);
                crvDailyKillenReport.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void reportByMonth(DateTime d)
        {
            try
            {
                DailyKillenReportDAL dal = new DailyKillenReportDAL();
                rptDailyKillenByMon report = new rptDailyKillenByMon();
                report.SetDataSource(dal.getMonthlyKillenReport(d).Tables[0]);
                crvDailyKillenReport.ReportSource = report;
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
                rptDailyKillenReportByMonth report = new rptDailyKillenReportByMonth();
                report.SetDataSource(dt);
                crvDailyKillenReport.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByMonthAndKillen(DateTime d,Int16 killenID)
        {
            try
            {
                DailyKillenReportDAL dal = new DailyKillenReportDAL();
                rptDailyKillenByMonKill report = new rptDailyKillenByMonKill();
                report.SetDataSource(dal.getMonthlyKillenReportByKillen(d,killenID).Tables[0]);
                crvDailyKillenReport.ReportSource = report;
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
        public void reportByYear(DateTime d)
        {
            try
            {
                DailyKillenReportDAL dal = new DailyKillenReportDAL();
                rptDailyKillenByMon report = new rptDailyKillenByMon();
                report.SetDataSource(dal.getYearlyKillenReport(d).Tables[0]);
                crvDailyKillenReport.ReportSource = report;
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
        public void reportByYearAndKillen(DateTime d, Int16 killenID)
        {
            try
            {
                DailyKillenReportDAL dal = new DailyKillenReportDAL();
                rptDailyKillenByMonKill report = new rptDailyKillenByMonKill();
                report.SetDataSource(dal.getYearlyKillenReportByKillen(d, killenID).Tables[0]);
                crvDailyKillenReport.ReportSource = report;
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
