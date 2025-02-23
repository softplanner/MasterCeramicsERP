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
    public partial class salesFrmEmptyBill : Form
    {
        public salesFrmEmptyBill()
        {
            InitializeComponent();
        }
        public void getReport()
        {
            try
            {
                rptSaleEmptyBill report = new rptSaleEmptyBill();
                crvCreateBill.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crvCreateBill_Load(object sender, EventArgs e)
        {
            getReport();
        }
    }
}
