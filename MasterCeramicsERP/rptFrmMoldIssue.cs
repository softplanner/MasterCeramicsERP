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
    public partial class rptFrmMoldIssue : Form
    {
        public rptFrmMoldIssue()
        {
            InitializeComponent();
        }
        public void reportByDate(DateTime date)
        {
            try
            {
                MoldIssueRecordDAL dal = new MoldIssueRecordDAL();
                rptMoldIssue report = new rptMoldIssue();
                report.SetDataSource(dal.getDailyReport(date).Tables[0]);
                crvMoldIssue.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByMonth(DateTime da)
        {
            try
            {
                MoldIssueRecordDAL dal = new MoldIssueRecordDAL();
                rptMoldIssMon report = new rptMoldIssMon();
                report.SetDataSource(dal.getMonthlyReport(da).Tables[0]);
                crvMoldIssue.ReportSource = report;
                //-----for test pupose only
                CrystalDecisions.CrystalReports.Engine.TextObject temp =
                ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text8"]);
                temp.Text = "Monthly Report";
                //----- end test
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByYear(DateTime da)
        {
            try
            {
                MoldIssueRecordDAL dal = new MoldIssueRecordDAL();
                rptMoldIssMon report = new rptMoldIssMon();
                report.SetDataSource(dal.getYearlyReport(da).Tables[0]);
                crvMoldIssue.ReportSource = report;
                //-----for test pupose only
                CrystalDecisions.CrystalReports.Engine.TextObject temp =
                ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text8"]);
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
