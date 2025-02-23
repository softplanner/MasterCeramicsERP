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
    public partial class rptFrmPostOrderView : Form
    {
        public rptFrmPostOrderView()
        {
            InitializeComponent();
        }
        public void dailyReportByDealer(int dealID,DateTime date)
        {
            OrderPostInfocs dal = new OrderPostInfocs();
            rptSPostOrderByDealerDaily report = new rptSPostOrderByDealerDaily();
            report.SetDataSource(dal.getSelectedDateOrderReportByDealer(date,dealID).Tables[0]);
            crvPostOrderView.ReportSource = report;
        }
        public void dailyReportBySubDealer(int subDealID,DateTime date)
        {
            OrderPostInfocs dal = new OrderPostInfocs();
            rptSPostOrderBySubDealerDaily report = new rptSPostOrderBySubDealerDaily();
            report.SetDataSource(dal.getSelectedDateOrderReportByCustomer(date,subDealID).Tables[0]);
            crvPostOrderView.ReportSource = report;
        }
        public void monthlyReportByDealer(int dealID,DateTime date)
        {
            OrderPostInfocs dal = new OrderPostInfocs();
            rptSPostOrderByDealerMon report = new rptSPostOrderByDealerMon();
            report.SetDataSource(dal.getMonthlyOrderReportByDealer(date,dealID).Tables[0]);
            crvPostOrderView.ReportSource = report;
        }
        public void monthlyReportBySubDealer(int cusID,DateTime date)
        {
            OrderPostInfocs dal = new OrderPostInfocs();
            rptSPostOrderBySubDealerMon report = new rptSPostOrderBySubDealerMon();
            report.SetDataSource(dal.getMonthlyOrderReportByCustomer(date,cusID).Tables[0]);
            crvPostOrderView.ReportSource = report;
        }
    }
}
