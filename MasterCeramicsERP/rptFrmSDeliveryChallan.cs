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
    public partial class rptFrmSDeliveryChallan : Form
    {
        public rptFrmSDeliveryChallan()
        {
            InitializeComponent();
        }
        public void getReportByGatePass(string gatePass)
        {
            deliveryChallanDAL dal = new deliveryChallanDAL();
            rptSChallanByGatePass report = new rptSChallanByGatePass();
            report.SetDataSource(dal.getReportByGatePass(gatePass).Tables[0]);
            crvDeliveryChallan.ReportSource = report;
        }
        public void dailyReportByDealer(int dealID, DateTime date)
        {
            deliveryChallanDAL dal = new deliveryChallanDAL();
            rptSChallanByDealerDate report = new rptSChallanByDealerDate();
            report.SetDataSource(dal.getSelectedDayReportByDealer(date, dealID).Tables[0]);
            crvDeliveryChallan.ReportSource = report;
        }
        public void dailyReportBySubDealer(int subDealID, DateTime date)
        {
            deliveryChallanDAL dal = new deliveryChallanDAL();
            rptSChallanBySubDealerDate report = new rptSChallanBySubDealerDate();
            //report.SetDataSource(dal.getSelectedDayReportByCustomer(subDealID,date).Tables[0]);
            crvDeliveryChallan.ReportSource = report;
        }
        public void monthlyReportByDealer(int dealID, DateTime date)
        {
            deliveryChallanDAL dal = new deliveryChallanDAL();
            rptSChallanByDealerMonth report = new rptSChallanByDealerMonth();
            report.SetDataSource(dal.getMonthlyReportByDealer(date,dealID).Tables[0]);
            crvDeliveryChallan.ReportSource = report;
        }
        public void monthlyReportBySubDealer(int cusID, DateTime date)
        {
            deliveryChallanDAL dal = new deliveryChallanDAL();
            rptSChallanBySubDealerMonth report = new rptSChallanBySubDealerMonth();
            report.SetDataSource(dal.getMonthlyReportByCustomer(date, cusID).Tables[0]);
            crvDeliveryChallan.ReportSource = report;
        }
    }
}
