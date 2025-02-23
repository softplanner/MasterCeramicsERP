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
    public partial class rptFrmMoldReceive : Form
    {
        public rptFrmMoldReceive()
        {
            InitializeComponent();
        }

        public void reportByDate(DateTime date)
        {
            try
            {
                MoldReceiveRecordDAL dal = new MoldReceiveRecordDAL();
                rptMoldReceiveDaily report = new rptMoldReceiveDaily();
                report.SetDataSource(dal.getDailyReport(date).Tables[0]);
                crvMoldReceive.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByDayDT(DataTable dt)
        {
            try
            {
                rptMouldRegisterRecordByMonth report = new rptMouldRegisterRecordByMonth();
                report.SetDataSource(dt);
                crvMoldReceive.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByMonthDT(DataTable dt)
        {
            try
            {
                rptMouldRegisterByDay report = new rptMouldRegisterByDay();
                report.SetDataSource(dt);
                crvMoldReceive.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByMonth(DateTime date)
        {
            try
            {
                MoldReceiveRecordDAL dal = new MoldReceiveRecordDAL();
                rptMoldReceive report = new rptMoldReceive();
                report.SetDataSource(dal.getMonthlyReport(date).Tables[0]);
                crvMoldReceive.ReportSource = report;
                //-----for test pupose only
                CrystalDecisions.CrystalReports.Engine.TextObject temp =
                ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text9"]);
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
                MoldReceiveRecordDAL dal = new MoldReceiveRecordDAL();
                rptMoldReceive report = new rptMoldReceive();
                report.SetDataSource(dal.getyearlyReport(date).Tables[0]);
                crvMoldReceive.ReportSource = report;
                //-----for test pupose only
                CrystalDecisions.CrystalReports.Engine.TextObject temp =
                ((CrystalDecisions.CrystalReports.Engine.TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["Text9"]);
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
