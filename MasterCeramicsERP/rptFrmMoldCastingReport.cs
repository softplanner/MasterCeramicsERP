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
    public partial class rptFrmMoldCastingReport : Form
    {
        public rptFrmMoldCastingReport()
        {
            InitializeComponent();
        }
        public void reportByDateByDT(DataTable dt)
        {
            try
            {
                rptMoldCasting report = new rptMoldCasting();
                report.SetDataSource(dt);
                crvMoldCasingReport.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByCasterDailyByDT(DataTable dt)
        {
            try
            {
                rptMouldCastingByCasterDaily report = new rptMouldCastingByCasterDaily();
                report.SetDataSource(dt);
                crvMoldCasingReport.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByDate(DateTime date)
        {
            try
            {
                MoldCastingRepertDAL dal = new MoldCastingRepertDAL();
                rptMoldCasting report = new rptMoldCasting();
                report.SetDataSource(dal.getDailyReport(date).Tables[0]);
                crvMoldCasingReport.ReportSource = report;
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
                rptMoldCastingMonthly report = new rptMoldCastingMonthly();
                report.SetDataSource(dt);
                crvMoldCasingReport.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByCasterMonthDT(DataTable dt)
        {
            try
            {
                rptMouldCastingMonByCaster report = new rptMouldCastingMonByCaster();
                report.SetDataSource(dt);
                crvMoldCasingReport.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByMonth(DateTime d)
        {
            try
            {
                MoldCastingRepertDAL dal = new MoldCastingRepertDAL();
                rptMoldCastingMonthly report = new rptMoldCastingMonthly();
                report.SetDataSource(dal.getMonthlyReport(d).Tables[0]);
                crvMoldCasingReport.ReportSource = report;
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
        public void reportByYear(DateTime d)
        {
            try
            {
                MoldCastingRepertDAL dal = new MoldCastingRepertDAL();
                rptMoldCastingMonthly report = new rptMoldCastingMonthly();
                report.SetDataSource(dal.getYearlyReport(d).Tables[0]);
                crvMoldCasingReport.ReportSource = report;
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
