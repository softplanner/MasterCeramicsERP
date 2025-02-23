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
    public partial class rptFrmRawMaterialReport : Form
    {
        public rptFrmRawMaterialReport()
        {
            InitializeComponent();
        }

        public void reportByDate(DateTime date)
        {
            try
            {
                RawMaterialReportDAL dal = new RawMaterialReportDAL();
                rptRawMaterialPurchaseReportDaily report = new rptRawMaterialPurchaseReportDaily();
                report.SetDataSource(dal.getdailyReport(date).Tables[0]);
                crvRawMaterialReport.ReportSource = report;
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
                RawMaterialReportDAL dal = new RawMaterialReportDAL();
                rptRawMaterial report = new rptRawMaterial();
                report.SetDataSource(dal.getMonthlyReport(date).Tables[0]);
                crvRawMaterialReport.ReportSource = report;
                //-----for test pupose only
                CrystalDecisions.CrystalReports.Engine.TextObject temp =
                ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text6"]);
                temp.Text = "Monthlty Report";
                //----- end test
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
                RawMaterialReportDAL dal = new RawMaterialReportDAL();
                rptRawMaterial report = new rptRawMaterial();
                report.SetDataSource(dal.getYearlyReportDataSet(date).Tables[0]);
                crvRawMaterialReport.ReportSource = report;
                //-----for test pupose only
                CrystalDecisions.CrystalReports.Engine.TextObject temp =
                ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text6"]);
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
