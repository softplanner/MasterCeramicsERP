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
    public partial class rptFrmPCasterPay : Form
    {
        public rptFrmPCasterPay()
        {
            InitializeComponent();
        }
        public void dailyReport(DateTime date)
        {
            CasterPaymentReportDAL dal = new CasterPaymentReportDAL();
            rptPCasterPay report = new rptPCasterPay();
            report.SetDataSource(dal.getSelectedDateCasterPaymentReport(date).Tables[0]);
            crvCasterPayment.ReportSource = report;
        }
        public void dailyReportByDT(DataTable dt)
        {
            rptCasterPaymenrNewByDate report = new rptCasterPaymenrNewByDate();
            report.SetDataSource(dt);
            crvCasterPayment.ReportSource = report;
        }
        public void dailyReportByWorker(DateTime date, int wid)
        {
            CasterPaymentReportDAL dal = new CasterPaymentReportDAL();
            rptPCasterPay report = new rptPCasterPay();
            report.SetDataSource(dal.getSelectedDateReportByCaster(date, wid).Tables[0]);
            crvCasterPayment.ReportSource = report;
        }
        public void dailyReportByWorkerDT(DataTable dt)
        {
            rptCasterPaymentNewByWorker report = new rptCasterPaymentNewByWorker();
            report.SetDataSource(dt);
            crvCasterPayment.ReportSource = report;
        }
        public void monthlyReport(DateTime date)
        {
            CasterPaymentReportDAL dal = new CasterPaymentReportDAL();
            rptPCasterPayMon report = new rptPCasterPayMon();
            report.SetDataSource(dal.getMonthlyReport(date).Tables[0]);
            crvCasterPayment.ReportSource = report;
            //-----for test pupose only
            CrystalDecisions.CrystalReports.Engine.TextObject temp =
            ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text12"]);
            temp.Text = "Monthly Report";
            //----- end test
        }
        public void monthlyReportByWorker(DateTime date, int wid)
        {
            CasterPaymentReportDAL dal = new CasterPaymentReportDAL();
            rptCasPayByWorker report = new rptCasPayByWorker();
            report.SetDataSource(dal.getMonthlyReportByCaster(date, wid).Tables[0]);
            crvCasterPayment.ReportSource = report;
            //-----for test pupose only
            CrystalDecisions.CrystalReports.Engine.TextObject temp =
            ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text12"]);
            temp.Text = "Monthly Report";
            //----- end test

        }
        public void yearlyReport(DateTime date)
        {
            CasterPaymentReportDAL dal = new CasterPaymentReportDAL();
            rptPCasterPayMon report = new rptPCasterPayMon();
            report.SetDataSource(dal.getYearlyReport(date).Tables[0]);
            crvCasterPayment.ReportSource = report;
            //-----for test pupose only
            CrystalDecisions.CrystalReports.Engine.TextObject temp =
            ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text12"]);
            temp.Text = "Yearly Report";
            //----- end test
        }
        public void yearlyReportByWorker(DateTime date, int wid)
        {
            CasterPaymentReportDAL dal = new CasterPaymentReportDAL();
            rptCasPayByWorker report = new rptCasPayByWorker();
            report.SetDataSource(dal.getYearlyReportByCaster(date, wid).Tables[0]);
            crvCasterPayment.ReportSource = report;
            //-----for test pupose only
            CrystalDecisions.CrystalReports.Engine.TextObject temp =
            ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text12"]);
            temp.Text = "Yearly Report";
            //----- end test
        }
    }
}
