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
    public partial class rptFrmLetterHead : Form
    {
        public rptFrmLetterHead()
        {
            InitializeComponent();
        }
        public void getReport()
        {
            try
            {
                salesCompanyLetterHead report = new salesCompanyLetterHead();
                crvLetterHead.ReportSource = report;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error in crystal reporting connection"+ exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
