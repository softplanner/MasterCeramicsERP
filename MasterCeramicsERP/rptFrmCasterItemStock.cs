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
    public partial class rptFrmCasterItemStock : Form
    {
        public rptFrmCasterItemStock()
        {
            InitializeComponent();
        }
        public void showReport(int cid)
        {
            GreenWareHouseWorkerStockDAL dal = new GreenWareHouseWorkerStockDAL();
            rptCasterItemStock report = new rptCasterItemStock();
            report.SetDataSource(dal.getStockReport(cid).Tables[0]);
            crvCasterItemStock.ReportSource = report;
        }
    }
}
