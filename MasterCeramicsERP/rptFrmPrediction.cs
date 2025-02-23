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
    public partial class rptFrmPrediction : Form
    {
        public rptFrmPrediction()
        {
            InitializeComponent();
        }
        public void calculateSlipFromItems(DataSet ds)
        {
            try
            {
                rptCalculateSlipFromItems report = new rptCalculateSlipFromItems();
                report.SetDataSource(ds.Tables[0]);
                crvPrediction.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ItemEstimationFromSlipByItem(DataSet ds)
        {
            try
            {
                rptItemEstimationFromSlip report = new rptItemEstimationFromSlip();
                report.SetDataSource(ds.Tables[0]);
                crvPrediction.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ItemEstimationFromSlipByStyle(DataSet ds)
        {
            try
            {
                rptItemEstimationFromSlipByStyle report = new rptItemEstimationFromSlipByStyle();
                report.SetDataSource(ds.Tables[0]);
                crvPrediction.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ItemEstimationFromSlipBySize(DataSet ds)
        {
            try
            {
                rptItemEstimationFromSlipBySize report = new rptItemEstimationFromSlipBySize();
                report.SetDataSource(ds.Tables[0]);
                crvPrediction.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
