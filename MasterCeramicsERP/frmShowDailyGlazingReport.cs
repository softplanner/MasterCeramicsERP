using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MCERP.DAL;
using MCERP.Entities;
using MasterCeramicsERP.Datasets.dsDBTableAdapters;
using MasterCeramicsERP.Datasets;

namespace MasterCeramicsERP
{
    public partial class frmShowDailyGlazingReport : Form
    {
        rptFrmDailyGlazingReport obj;
        int row=-1,selectedRow=-1;
        List<int> id = new List<int>();
        public frmShowDailyGlazingReport()
        {
            InitializeComponent();
        }

        private void frmShowDailyGlazingReport_Load(object sender, EventArgs e)
        {

        }
        private void loadDailyGlazingDGV()
        {
            DailyGlazingReportTableAdapter dal = new DailyGlazingReportTableAdapter();
            dsDB.DailyGlazingReportDataTable dt = new dsDB.DailyGlazingReportDataTable();
            if(rbtnDailyReport.Checked.Equals(true))
            {
                dt = dal.GetDataByDate(dtpDatedReport.Value.Day,dtpDatedReport.Value.Month, dtpDatedReport.Value.Year);
            }
            else if(rbtnMonthlyReport.Checked.Equals(true))
            {
                dt = dal.GetDataByMonth(dtpDatedReport.Value.Month, dtpDatedReport.Value.Year);
            }
            else
            { 
            }
            if (dt.Rows.Equals(0))
            {
                MessageBox.Show("No Record Found ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                dgvDatedReport.DataSource = dt;
                dgvDatedReport.Columns["SprayManID"].Visible = false;
                dgvDatedReport.Columns["ItemID"].Visible = false;
                dgvDatedReport.Columns["StyleID"].Visible = false;
                dgvDatedReport.Columns["SizeID"].Visible = false;
                dgvDatedReport.Columns["ColorID"].Visible = false;
            }
        }
        private void showCall()
        {
            try
            {
                DailyGlazingReportDAL dailyGlazingDAL = new DailyGlazingReportDAL();

                if (rbtnDailyReport.Checked.Equals(false) && rbtnMonthlyReport.Checked.Equals(false))
                {
                    MessageBox.Show("Select some critaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    loadDailyGlazingDGV();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            showCall();
        }
        //=====report object
        rptFrmDailyGlazingReport report;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnDailyReport.Checked.Equals(false) && rbtnMonthlyReport.Checked.Equals(false))
                {
                    MessageBox.Show("Select some critaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = (DataTable)dgvDatedReport.DataSource;
                    //if (!this.Parent.Contains(report))
                    //{
                        report = new rptFrmDailyGlazingReport();
                        //report.TopLevel = false;
                        //report.Dock = DockStyle.Fill;
                        //this.Parent.Controls.Add(report);
                        //report.Show();

                        if (rbtnDailyReport.Checked.Equals(true))
                        {
                            report.reportByDateDT(dt);
                            report.BringToFront();
                            report.Show();
                        }
                        else if (rbtnMonthlyReport.Checked.Equals(true))
                        {
                            report.reportByMonthDT(dt);
                            report.BringToFront();
                            report.Show();
                        }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvDatedReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select some record...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    if (MessageBox.Show("Are you sure you want to delete this record ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DailyGlazingReportN obj = new DailyGlazingReportN();
                        DailyGlazingReportTableAdapter dalGReport = new DailyGlazingReportTableAdapter();
                        taUnglazeStockCompany dalUStock = new taUnglazeStockCompany();
                        GlazeStockCompanyTableAdapter dalGStock = new GlazeStockCompanyTableAdapter();
                        int new_Quantity = 0;
                        obj.ItemID = Convert.ToInt32(dgvDatedReport.Rows[selectedRow].Cells["ItemID"].Value.ToString());
                        obj.StyleID = Convert.ToInt32(dgvDatedReport.Rows[selectedRow].Cells["StyleID"].Value.ToString());
                        obj.SizeID = Convert.ToInt32(dgvDatedReport.Rows[selectedRow].Cells["SizeID"].Value.ToString());
                        obj.ColorID = Convert.ToInt32(dgvDatedReport.Rows[selectedRow].Cells["ColorID"].Value.ToString());
                        obj.SprayManID = Convert.ToInt32(dgvDatedReport.Rows[selectedRow].Cells["SprayManID"].Value.ToString());
                        obj.Date = Convert.ToDateTime(dgvDatedReport.Rows[selectedRow].Cells["Date"].Value.ToString());
                        obj.Quantity = Convert.ToInt32(dgvDatedReport.Rows[selectedRow].Cells["Quantity"].Value.ToString());
                        obj.Breakage = Convert.ToInt32(dgvDatedReport.Rows[selectedRow].Cells["Breakage"].Value.ToString());
                        //----------update unglaze company stock
                        new_Quantity = 0;
                        new_Quantity = Convert.ToInt32(dalUStock.getStockByID(obj.ItemID,obj.StyleID,obj.SizeID)) + obj.Quantity + obj.Breakage;
                        dalUStock.UpdateStockByID(new_Quantity, obj.ItemID, obj.StyleID, obj.SizeID);
                        //--------------------------------------
                        //-----------update company glazed Stock
                        new_Quantity = 0;
                        new_Quantity = Convert.ToInt32(dalGStock.getStockQuantity(obj.ItemID, obj.StyleID, obj.SizeID, obj.ColorID)) - obj.Quantity;
                        dalGStock.UpdateQueryByID(new_Quantity, obj.ItemID, obj.StyleID,obj.SizeID,obj.ColorID);
                        //--------------------------------------
                        dalGReport.DeleteQuery(obj.ItemID, obj.StyleID, obj.SizeID, obj.ColorID, obj.SprayManID, obj.Date.Day, obj.Date.Month, obj.Date.Year);
                    }
                    MessageBox.Show("Daily Glazing Report has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
