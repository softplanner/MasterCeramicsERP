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
    public partial class frmKillenFeedShow : Form
    {
        Int16 selectedRow = -1;

        public frmKillenFeedShow()
        {
            InitializeComponent();
        }

        private void dgvKillenReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = Convert.ToInt16(e.RowIndex);
        }

        private void loadDataGrid()
        {
            try
            {
                KillenFeedReportTableAdapter dal = new KillenFeedReportTableAdapter();
                dsDB.KillenFeedReportDataTable dt = new dsDB.KillenFeedReportDataTable();
                if(rbtnDailyReport.Checked.Equals(false) && rbtnMonthlyReport.Checked.Equals(false))
                {
                    MessageBox.Show("Select some critaria...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (rbtnDailyReport.Checked.Equals(true))
                {
                    dt = dal.GetDataByDate(dtpDatedReport.Value.Day, dtpDatedReport.Value.Month, dtpDatedReport.Value.Year);
                }
                else if (rbtnMonthlyReport.Checked.Equals(true))
                {
                    dt = dal.GetDataByMonth(dtpDatedReport.Value.Month, dtpDatedReport.Value.Year);
                }
                else { }
                if (dt.Rows.Equals(0))
                {
                    MessageBox.Show("No record found...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dgvKillenReport.DataSource = dt;
                    dgvKillenReport.Columns["ItemID"].Visible = false;
                    dgvKillenReport.Columns["StyleID"].Visible = false;
                    dgvKillenReport.Columns["SizeID"].Visible = false;
                    dgvKillenReport.Columns["ColorID"].Visible = false;
                }
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmKillenFeedShow_Load(object sender, EventArgs e)
        {
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                loadDataGrid();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRow.Equals(-1))
            {
                MessageBox.Show("First select some record...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int new_Quantity=0;
                int incentive_Quantity = 0;
                int killen_Feed_Quantity=0;
                GlazeStockCompanyTableAdapter dalGStock = new GlazeStockCompanyTableAdapter();
                KillenFeedReportTableAdapter dalKillen = new KillenFeedReportTableAdapter();
                KillenFeedStockTableAdapter dalKillenFeedStock = new KillenFeedStockTableAdapter();

                if (MessageBox.Show("Are you sure you want to delete ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    killenFeedReport obj = new killenFeedReport();
                    obj.ItemID = Convert.ToInt32(dgvKillenReport.Rows[selectedRow].Cells["ItemID"].Value.ToString());
                    obj.StyleID = Convert.ToInt32(dgvKillenReport.Rows[selectedRow].Cells["StyleID"].Value.ToString());
                    obj.SizeID = Convert.ToInt32(dgvKillenReport.Rows[selectedRow].Cells["SizeID"].Value.ToString());
                    obj.ColorID = Convert.ToInt32(dgvKillenReport.Rows[selectedRow].Cells["ColorID"].Value.ToString());
                    obj.Date = Convert.ToDateTime(dgvKillenReport.Rows[selectedRow].Cells["Date"].Value.ToString());
                    obj.Quantity = Convert.ToInt32(dgvKillenReport.Rows[selectedRow].Cells["kQuantity"].Value.ToString());
                    obj.Breakage = Convert.ToInt32(dgvKillenReport.Rows[selectedRow].Cells["kBreakage"].Value.ToString());
                    //--delte report from daily killen report...
                    dalKillen.DeleteQuery(obj.ItemID,obj.StyleID,obj.SizeID,obj.ColorID,obj.Date.Day,obj.Date.Month,obj.Date.Year);

                    //--return to glazed stock...
                    incentive_Quantity = obj.Quantity + obj.Breakage;
                    new_Quantity = Convert.ToInt32(dalGStock.getStockQuantity(obj.ItemID, obj.StyleID, obj.SizeID, obj.ColorID)) + incentive_Quantity;
                    dalGStock.UpdateQueryByID(new_Quantity, obj.ItemID, obj.StyleID, obj.SizeID, obj.ColorID);
                    //-----deduct from killen feed stock
                    killen_Feed_Quantity = Convert.ToInt32(dalKillenFeedStock.getStockByID(obj.ItemID, obj.StyleID, obj.SizeID, obj.ColorID));
                    dalKillenFeedStock.UpdateQuery(killen_Feed_Quantity - obj.Quantity, obj.ItemID, obj.StyleID, obj.SizeID, obj.ColorID);
                }
            }
        }

        //-----report object
        rptFrmKillenFeed report;
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!this.Parent.Contains(report))
                //{
                    report = new rptFrmKillenFeed();
                    DataTable dt = new DataTable();
                    dt = (DataTable)dgvKillenReport.DataSource;

                    //report.TopLevel = false;
                    //report.Dock = DockStyle.Fill;
                    //this.Parent.Controls.Add(report);
                    //report.Show();

                    if(rbtnDailyReport.Checked.Equals(false) && rbtnMonthlyReport.Checked.Equals(false))
                    {
                        MessageBox.Show("Select some critaria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);     
                    }
                    else if (rbtnDailyReport.Checked.Equals(true))
                    {
                        report.reportByDay(dt);
                        report.BringToFront();
                        report.Show();
                    }
                    else if (rbtnMonthlyReport.Checked.Equals(true))
                    {
                        report.reportByMonth(dt);
                        report.BringToFront();
                        report.Show();
                    }
                    else
                    { }
                //}
                //else
                //{
                //    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //==========================================================================================================
    }
}
