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
    public partial class rptFrmKillenFeed : Form
    {
        public rptFrmKillenFeed()
        {
            InitializeComponent();
        }

        public void reportByKillen(Int16 killenID)
        {
            try
            {
                KillenFeedDAL dal = new KillenFeedDAL();
                rptKillenFeed report = new rptKillenFeed();
                report.SetDataSource(dal.getKillenReport(killenID).Tables[0]);
                crvKillenFeed.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByDay(DataTable dt)
        {
            try
            {
                rptKillenFeedDaily report = new rptKillenFeedDaily();
                report.SetDataSource(dt);
                crvKillenFeed.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportByMonth(DataTable dt)
        {
            try
            {
                rptKillenFeedMonthly report = new rptKillenFeedMonthly();
                report.SetDataSource(dt);
                crvKillenFeed.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reportAllKillen()
        {
            try
            {
                KillenFeedDAL dal = new KillenFeedDAL();
                rptKillenFeed report = new rptKillenFeed();
                report.SetDataSource(dal.getAllKillenReport().Tables[0]);
                crvKillenFeed.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
