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
    public partial class rptFrmPDailyWages : Form
    {
        public rptFrmPDailyWages()
        {
            InitializeComponent();
        }
        public void dailyReport(DateTime date)
        {
            DailyWagesReportDAL dal = new DailyWagesReportDAL();
            rptPDailyWages report = new rptPDailyWages();
            report.SetDataSource(dal.getSelectedDateReport(date).Tables[0]);
            crvDailyWages.ReportSource = report;
        }
        public void dailyReportByDT(DataTable dt)
        {
            rptDailyWagesNewByDate report = new rptDailyWagesNewByDate();
            report.SetDataSource(dt);
            crvDailyWages.ReportSource = report;
        }
        public void dailyReportByWorker(DateTime date, int wid)
        {
            DailyWagesReportDAL dal = new DailyWagesReportDAL();
            rptPDailyWageByWorkerDaily report = new rptPDailyWageByWorkerDaily();
            report.SetDataSource(dal.getSelectedDateReportByWorker(date, wid).Tables[0]);
            crvDailyWages.ReportSource = report;
        }
        public void dailyReportByWorkerDT(DataTable dt)
        {
            rptDailyWagesNewByWorker report = new rptDailyWagesNewByWorker();
            report.SetDataSource(dt);
            crvDailyWages.ReportSource = report;
        }
        public void monthlyReport(DateTime date)
        {
            DailyWagesReportDAL dal = new DailyWagesReportDAL();
            rptPDailyWagesMon report = new rptPDailyWagesMon();
            report.SetDataSource(dal.getMonthlyReport(date).Tables[0]);
            crvDailyWages.ReportSource = report;
            //-----for test pupose only
            CrystalDecisions.CrystalReports.Engine.TextObject temp =
            ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text8"]);
            temp.Text = "Monthly Report";
            //----- end test
        }
        public void monthlyReportByWorker(DateTime date, int wid)
        {
            DailyWagesReportDAL dal = new DailyWagesReportDAL();
            rptPDailyWagesByWorker report = new rptPDailyWagesByWorker();
            report.SetDataSource(dal.getMonthlyReportByWorker(date, wid).Tables[0]);
            crvDailyWages.ReportSource = report;
            //-----for test pupose only
            CrystalDecisions.CrystalReports.Engine.TextObject temp =
            ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text1"]);
            temp.Text = "Monthly Report";
            //----- end test

        }
        public void yearlyReport(DateTime date)
        {
            DailyWagesReportDAL dal = new DailyWagesReportDAL();
            rptPDailyWagesMon report = new rptPDailyWagesMon();
            report.SetDataSource(dal.getYearlyReport(date).Tables[0]);
            crvDailyWages.ReportSource = report;
            //-----for test pupose only
            CrystalDecisions.CrystalReports.Engine.TextObject temp =
            ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text8"]);
            temp.Text = "Yearly Report";
            //----- end test
        }
        public void yearlyReportByWorker(DateTime date, int wid)
        {
            DailyWagesReportDAL dal = new DailyWagesReportDAL();
            rptPDailyWagesByWorker report = new rptPDailyWagesByWorker();
            report.SetDataSource(dal.getYearlyReportByWorker(date, wid).Tables[0]);
            crvDailyWages.ReportSource = report;
            //-----for test pupose only
            CrystalDecisions.CrystalReports.Engine.TextObject temp =
            ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text1"]);
            temp.Text = "Yearly Report";
            //----- end test
        }
    }
}
