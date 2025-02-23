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
    public partial class rptFrmCasterMoldStock : Form
    {
        public rptFrmCasterMoldStock()
        {
            InitializeComponent();
        }

        public void printReport(int casterID)
        {
            try
            {
                MoldStockWorkerDAL dal = new MoldStockWorkerDAL();
                rptMoldStockWorker report = new rptMoldStockWorker();
                report.SetDataSource(dal.getStockReport(casterID).Tables[0]);
                crvCasterMoldStock.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void printReportByDT(DataTable dt)
        {
            try
            {
                rptMoldStockWorker report = new rptMoldStockWorker();
                report.SetDataSource(dt);
                crvCasterMoldStock.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
