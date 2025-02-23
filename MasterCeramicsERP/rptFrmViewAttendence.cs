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
    public partial class rptFrmViewAttendence : Form
    {
        public rptFrmViewAttendence()
        {
            InitializeComponent();
        }
        public void  dailyReport(DateTime date)
        {
            AttendenceAccountDAL dal = new AttendenceAccountDAL();
            rptPAttendence report = new rptPAttendence();
            report.SetDataSource(dal.getSelectedDateAttendenceReport(date).Tables[0]);
            crvViewAttendence.ReportSource = report;
        }
        public void dailyReportByWorkerDT(DataTable dt)
        {
            rptAttandanceReportByWorker report = new rptAttandanceReportByWorker();
            report.SetDataSource(dt);
            crvViewAttendence.ReportSource = report;
        }
        public void dailyReportByDateDT(DataTable dt)
        {
            rptAttendanceReportByDate report = new rptAttendanceReportByDate();
            report.SetDataSource(dt);
            crvViewAttendence.ReportSource = report;
        }
        public void dailyReportByWorker(DateTime date,int wid)
        {
            AttendenceAccountDAL dal = new AttendenceAccountDAL();
            rptPAttendence report = new rptPAttendence();
            report.SetDataSource(dal.getSelectedDateAttendenceReportByWorker(date,wid).Tables[0]);
            crvViewAttendence.ReportSource = report;
        }
        public void monthlyReport(DateTime date)
        {
            AttendenceAccountDAL dal = new AttendenceAccountDAL();
            rptPMonthlyAtt report = new rptPMonthlyAtt();
            report.SetDataSource(dal.getMonthlyAttendenceReport(date).Tables[0]);
            crvViewAttendence.ReportSource = report;
            //-----for test pupose only
            CrystalDecisions.CrystalReports.Engine.TextObject temp =
            ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text6"]);
            temp.Text = "Monthly Report";
            //----- end test
        }
        public void monthlyReportByWorker(DateTime date,int wid)
        {
            AttendenceAccountDAL dal = new AttendenceAccountDAL();
            rptPAttendenceByWorker report = new rptPAttendenceByWorker();
            report.SetDataSource(dal.getMonthlyAttendenceReportByWorker(date,wid).Tables[0]);
            crvViewAttendence.ReportSource = report;
            //-----for test pupose only
            CrystalDecisions.CrystalReports.Engine.TextObject temp =
            ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text6"]);
            temp.Text = "Monthly Report";
            //----- end test

        }
        public void yearlyReport(DateTime date,int wid)
        {
            AttendenceAccountDAL dal = new AttendenceAccountDAL();
            rptPAttendenceByWorker report = new rptPAttendenceByWorker();
            report.SetDataSource(dal.getYearlyAttendenceReportByWorker(date,wid).Tables[0]);
            crvViewAttendence.ReportSource = report;
            //-----for test pupose only
            CrystalDecisions.CrystalReports.Engine.TextObject temp =
            ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text6"]);
            temp.Text = "Yearly Report";
            //----- end test
        }
    }
}
