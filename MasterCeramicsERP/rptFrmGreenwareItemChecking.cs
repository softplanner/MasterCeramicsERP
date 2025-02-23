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
    public partial class rptFrmGreenwareItemChecking : Form
    {
        public rptFrmGreenwareItemChecking()
        {
            InitializeComponent();
        }

        public void reportByDate(DateTime date)
        {
            try
            {
                GreenWareHouseItemCheckReportDAL dal = new GreenWareHouseItemCheckReportDAL();
                rptGreenwareItemChecking report = new rptGreenwareItemChecking();
                report.SetDataSource(dal.getDailyReport(date).Tables[0]);
                crvGreenwareItemChecking.ReportSource = report;
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
                GreenWareHouseItemCheckReportDAL dal = new GreenWareHouseItemCheckReportDAL();
                GrItChMon report = new GrItChMon();
                report.SetDataSource(dal.getMonthlyReport(d).Tables[0]);
                crvGreenwareItemChecking.ReportSource = report;
                //-----for test pupose only
                CrystalDecisions.CrystalReports.Engine.TextObject temp =
                ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text11"]);
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
                GreenWareHouseItemCheckReportDAL dal = new GreenWareHouseItemCheckReportDAL();
                GrItChMon report = new GrItChMon();
                report.SetDataSource(dal.getyearlyReport(d).Tables[0]);
                crvGreenwareItemChecking.ReportSource = report;
                //-----for test pupose only
                CrystalDecisions.CrystalReports.Engine.TextObject temp =
                ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text11"]);
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
