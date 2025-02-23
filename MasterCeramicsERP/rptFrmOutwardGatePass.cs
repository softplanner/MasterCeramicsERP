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
    public partial class rptFrmOutwardGatePass : Form
    {
        public rptFrmOutwardGatePass()
        {
            InitializeComponent();
        }

        public void reportByDate(DateTime date)
        {
            try
            {
                //OilInspectionReportDAL dal = new OilInspectionReportDAL();
                //rptOutwardgatePass report = new rptOutwardgatePass();
                //report.SetDataSource(dal.getDailyReport(date).Tables[0]);
                //crvOutwardGatePass.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByDataTable(DataTable dt)
        {
            try
            {
                rptOutwardgatePass report = new rptOutwardgatePass();
                report.SetDataSource(dt);
                crvOutwardGatePass.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByDateAndCaster(DateTime date,int casterID)
        {
            try
            {
                //OilInspectionReportDAL dal = new OilInspectionReportDAL();
                //rptOutwardgatePassDailyByCaster report = new rptOutwardgatePassDailyByCaster();
                //report.SetDataSource(dal.getDailyReportByCaster(date, casterID).Tables[0]);
                //crvOutwardGatePass.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByDateAndChecker(DateTime date,int checkerID)
        {
            try
            {
                //OilInspectionReportDAL dal = new OilInspectionReportDAL();
                //rptOutwardgatePassDailyByChecker report = new rptOutwardgatePassDailyByChecker();
                //report.SetDataSource(dal.getDailyReportByChecker(date, checkerID).Tables[0]);
                //crvOutwardGatePass.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByDateAndCaster_Checker(DateTime date, int casterID,int checkerID)
        {
            try
            {
                //OilInspectionReportDAL dal = new OilInspectionReportDAL();
                //rptOutwardgatePassDailyByCasterChecker report = new rptOutwardgatePassDailyByCasterChecker();
                //report.SetDataSource(dal.getDailyReportByCaster_Checker(date, casterID, checkerID).Tables[0]);
                //crvOutwardGatePass.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByMonth(Int16 month, Int16 year)
        {
            try
            {
            //    OilInspectionReportDAL dal = new OilInspectionReportDAL();
            //    rptOutwardgatePassMonthly report = new rptOutwardgatePassMonthly();
            //    report.SetDataSource(dal.getMonthlyReport(month, year).Tables[0]);
            //    crvOutwardGatePass.ReportSource = report;
            //    //-----for test pupose only
            //    CrystalDecisions.CrystalReports.Engine.TextObject temp =
            //    ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text12"]);
            //    temp.Text = "Monthlty Report";
            //    //----- end test
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByMonthAndCaster(Int16 month, Int16 year,int casterID)
        {
            try
            {
                //OilInspectionReportDAL dal = new OilInspectionReportDAL();
                //rptOutwardgatePassMonthlyByCaster report = new rptOutwardgatePassMonthlyByCaster();
                //report.SetDataSource(dal.getMonthlyReportByCaster(month, year, casterID).Tables[0]);
                //crvOutwardGatePass.ReportSource = report;
                ////-----for test pupose only
                //CrystalDecisions.CrystalReports.Engine.TextObject temp =
                //((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text12"]);
                //temp.Text = "Monthlty Report";
                ////----- end test
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByMonthAndChecker(Int16 month, Int16 year,int checkerID)
        {
            try
            {
                //OilInspectionReportDAL dal = new OilInspectionReportDAL();
                //rptOutwardgatePassMonthlyByChecker report = new rptOutwardgatePassMonthlyByChecker();
                //report.SetDataSource(dal.getMonthlyReportByChecker(month, year, checkerID).Tables[0]);
                //crvOutwardGatePass.ReportSource = report;
                ////-----for test pupose only
                //CrystalDecisions.CrystalReports.Engine.TextObject temp =
                //((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text12"]);
                //temp.Text = "Monthlty Report";
                ////----- end test
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByMonthAndCaster_Checker(Int16 month, Int16 year, int casterID,int checkerID)
        {
            try
            {
                //OilInspectionReportDAL dal = new OilInspectionReportDAL();
                //rptOutwardgatePassMonthlyByCasterChecker report = new rptOutwardgatePassMonthlyByCasterChecker();
                //report.SetDataSource(dal.getMonthlyReportByCaster_Checker(month, year, casterID, checkerID).Tables[0]);
                //crvOutwardGatePass.ReportSource = report;
                ////-----for test pupose only
                //CrystalDecisions.CrystalReports.Engine.TextObject temp =
                //((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text12"]);
                //temp.Text = "Monthlty Report";
                ////----- end test
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--year
        public void reportByYear(DateTime date)
        {
            try
            {
                //OilInspectionReportDAL dal = new OilInspectionReportDAL();
                //rptOutwardgatePassMonthly report = new rptOutwardgatePassMonthly();
                //report.SetDataSource(dal.getYearlyReport(date).Tables[0]);
                //crvOutwardGatePass.ReportSource = report;
                ////-----for test pupose only
                //CrystalDecisions.CrystalReports.Engine.TextObject temp =
                //((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text12"]);
                //temp.Text = "Yearly Report";
                ////----- end test
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByYearAndCaster(DateTime date, int casterID)
        {
            try
            {
                //OilInspectionReportDAL dal = new OilInspectionReportDAL();
                //rptOutwardgatePassMonthlyByCaster report = new rptOutwardgatePassMonthlyByCaster();
                //report.SetDataSource(dal.getYearlyReportByCaster(date, casterID).Tables[0]);
                //crvOutwardGatePass.ReportSource = report;
                ////-----for test pupose only
                //CrystalDecisions.CrystalReports.Engine.TextObject temp =
                //((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text12"]);
                //temp.Text = "Yearly Report";
                ////----- end test
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByYearAndChecker(DateTime date, int checkerID)
        {
            try
            {
                //OilInspectionReportDAL dal = new OilInspectionReportDAL();
                //rptOutwardgatePassMonthlyByChecker report = new rptOutwardgatePassMonthlyByChecker();
                //report.SetDataSource(dal.getYearlyReportByChecker(date, checkerID).Tables[0]);
                //crvOutwardGatePass.ReportSource = report;
                ////-----for test pupose only
                //CrystalDecisions.CrystalReports.Engine.TextObject temp =
                //((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text12"]);
                //temp.Text = "Yearly Report";
                //----- end test
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByYearAndCaster_Checker(DateTime date, int casterID, int checkerID)
        {
            try
            {
                //OilInspectionReportDAL dal = new OilInspectionReportDAL();
                //rptOutwardgatePassMonthlyByCasterChecker report = new rptOutwardgatePassMonthlyByCasterChecker();
                //report.SetDataSource(dal.getYearlyReportByCaster_Checker(date, casterID, checkerID).Tables[0]);
                //crvOutwardGatePass.ReportSource = report;
                ////-----for test pupose only
                //CrystalDecisions.CrystalReports.Engine.TextObject temp =
                //((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text12"]);
                //temp.Text = "Yearly Report";
                ////----- end test
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // end year
    }
}
