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
    public partial class rptFrmMoldStockCompany : Form
    {
        public rptFrmMoldStockCompany()
        {
            InitializeComponent();
        }

        private void rptFrmMoldStockCompany_Load(object sender, EventArgs e)
        {
            try
            {
            MoldStockCompanyDAL dal = new MoldStockCompanyDAL();
            rptMoldStockCompany report = new rptMoldStockCompany();
            report.SetDataSource(dal.getStockReport().Tables[0]);
            crvMoldStockCompany.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
