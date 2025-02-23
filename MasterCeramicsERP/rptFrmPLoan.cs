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
    public partial class rptFrmPLoan : Form
    {
        public rptFrmPLoan()
        {
            InitializeComponent();
        }
        public void dailyReport(DateTime date)
        {
            WorkerLoanReportDAL dal = new WorkerLoanReportDAL();
            rptPLoan report = new rptPLoan();
            report.SetDataSource(dal.getSelectedDayReport(date).Tables[0]);
            crvWorkerLoan.ReportSource = report;
        }
        public void dailyReportByDateDT(DataTable dt)
        {
            rptWorkerLoanByDateNew report = new rptWorkerLoanByDateNew();
            report.SetDataSource(dt);
            crvWorkerLoan.ReportSource = report;
        }
        public void dailyReportByDateWorkerDT(DataTable dt)
        {
            rptWorkerLoanByWorkerNew report = new rptWorkerLoanByWorkerNew();
            report.SetDataSource(dt);
            crvWorkerLoan.ReportSource = report;
        }
        public void dailyReportByWorker(DateTime date, int wid)
        {
            WorkerLoanReportDAL dal = new WorkerLoanReportDAL();
            rptPLoan report = new rptPLoan();
            report.SetDataSource(dal.getSelectedDayReportByWorker(date, wid).Tables[0]);
            crvWorkerLoan.ReportSource = report;
        }
        public void monthlyReport(DateTime date)
        {
            WorkerLoanReportDAL dal = new WorkerLoanReportDAL();
            rptPMonLoan report = new rptPMonLoan();
            report.SetDataSource(dal.getMonthlyReport(date).Tables[0]);
            crvWorkerLoan.ReportSource = report;
            //-----for test pupose only
            CrystalDecisions.CrystalReports.Engine.TextObject temp =
            ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text5"]);
            temp.Text = "Monthly Report";
            //----- end test
        }
        public void monthlyReportByWorker(DateTime date, int wid)
        {
            WorkerLoanReportDAL dal = new WorkerLoanReportDAL();
            rptPWorkerLoanByWorker report = new rptPWorkerLoanByWorker();
            report.SetDataSource(dal.getMonthlyReportByWorker(date, wid).Tables[0]);
            crvWorkerLoan.ReportSource = report;
            //-----for test pupose only
            CrystalDecisions.CrystalReports.Engine.TextObject temp =
            ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text5"]);
            temp.Text = "Monthly Report";
            //----- end test

        }
        public void yearlyReport(DateTime date)
        {
            WorkerLoanReportDAL dal = new WorkerLoanReportDAL();
            rptPMonLoan report = new rptPMonLoan();
            report.SetDataSource(dal.getYearlyReport(date).Tables[0]);
            crvWorkerLoan.ReportSource = report;
            //-----for test pupose only
            CrystalDecisions.CrystalReports.Engine.TextObject temp =
            ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text5"]);
            temp.Text = "Yearly Report";
            //----- end test
        }
        public void yearlyReportByWorker(DateTime date, int wid)
        {
            WorkerLoanReportDAL dal = new WorkerLoanReportDAL();
            rptPWorkerLoanByWorker report = new rptPWorkerLoanByWorker();
            report.SetDataSource(dal.getYearlyReportByWorker(date, wid).Tables[0]);
            crvWorkerLoan.ReportSource = report;
            //-----for test pupose only
            CrystalDecisions.CrystalReports.Engine.TextObject temp =
            ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text5"]);
            temp.Text = "Yearly Report";
            //----- end test
        }
    }
}
