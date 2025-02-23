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
    public partial class rptFrmPMonSal : Form
    {
        public rptFrmPMonSal()
        {
            InitializeComponent();
        }
        public void dailyReport(DateTime date)
        {
            SaloryMonthOffDAL dal = new SaloryMonthOffDAL();
            rptPMonSal report = new rptPMonSal();
            report.SetDataSource(dal.getSelectedDayReport(date).Tables[0]);
            crvMonthlySal.ReportSource = report;
        }
        public void dailyReportByWorker(DateTime date, int wid)
        {
            SaloryMonthOffDAL dal = new SaloryMonthOffDAL();
            rptMonSalByWorkerDaily report = new rptMonSalByWorkerDaily();
            report.SetDataSource(dal.getSelectedDayReportByWorker(date, wid).Tables[0]);
            crvMonthlySal.ReportSource = report;
        }
        public void dailyReportByMonthDT(DataTable dt)
        {
            rptSalaryForTheMonthOf report = new rptSalaryForTheMonthOf();
            report.SetDataSource(dt);
            crvMonthlySal.ReportSource = report;
        }
        public void monthlyReport(DateTime date)
        {
            SaloryMonthOffDAL dal = new SaloryMonthOffDAL();
            rptPSalYearly report = new rptPSalYearly();
            report.SetDataSource(dal.getMonthlyReport(date).Tables[0]);
            crvMonthlySal.ReportSource = report;
            //-----for test pupose only
            CrystalDecisions.CrystalReports.Engine.TextObject temp =
            ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text12"]);
            temp.Text = "Monthly Report";
            //----- end test
        }
        public void monthlyReportByWorker(DateTime date, int wid)
        {
            SaloryMonthOffDAL dal = new SaloryMonthOffDAL();
            rptPMonSalByWorker report = new rptPMonSalByWorker();
            report.SetDataSource(dal.getMonthlyReportByWorker(date, wid).Tables[0]);
            crvMonthlySal.ReportSource = report;
            //-----for test pupose only
            CrystalDecisions.CrystalReports.Engine.TextObject temp =
            ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text1"]);
            temp.Text = "Monthly Report";
            //----- end test

        }
        public void yearlyReport(DateTime date)
        {
            SaloryMonthOffDAL dal = new SaloryMonthOffDAL();
            rptPSalYearly report = new rptPSalYearly();
            report.SetDataSource(dal.getYearlyReport(date).Tables[0]);
            crvMonthlySal.ReportSource = report;
            //-----for test pupose only
            CrystalDecisions.CrystalReports.Engine.TextObject temp =
            ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text12"]);
            temp.Text = "Yearly Report";
            //----- end test
        }
        public void yearlyReportByWorker(DateTime date, int wid)
        {
            SaloryMonthOffDAL dal = new SaloryMonthOffDAL();
            rptPMonSalByWorker report = new rptPMonSalByWorker();
            report.SetDataSource(dal.getYearlyReportByWorker(date, wid).Tables[0]);
            crvMonthlySal.ReportSource = report;
            //-----for test pupose only
            CrystalDecisions.CrystalReports.Engine.TextObject temp =
            ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text1"]);
            temp.Text = "Yearly Report";
            //----- end test
        }
    }
}
