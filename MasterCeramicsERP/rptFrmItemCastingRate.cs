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
    public partial class rptFrmItemCastingRate : Form
    {
        public rptFrmItemCastingRate()
        {
            InitializeComponent();
        }
        public void showRateListDT(DataTable dt)
        {
            rptItemCastingRateList report = new rptItemCastingRateList();
            report.SetDataSource(dt);
            crvItemCastingRate.ReportSource = report;
        }
    }
}
