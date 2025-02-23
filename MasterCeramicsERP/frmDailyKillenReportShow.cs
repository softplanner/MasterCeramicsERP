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
using MasterCeramicsERP.Datasets;
using MasterCeramicsERP.Datasets.dsDBTableAdapters;

namespace MasterCeramicsERP
{
    public partial class frmDailyKillenReportShow : Form
    {
        Int16 selectedRow = -1;
        public frmDailyKillenReportShow()
        {
            InitializeComponent();
        }
        private void frmDailyKillenReportShow_Load(object sender, EventArgs e)
        {
        }

        private void loadDataGrid()
        {
            try
            {
                DailyKillenReportsTableAdapter dal = new DailyKillenReportsTableAdapter();
                dsDB.DailyKillenReportsDataTable dt = new dsDB.DailyKillenReportsDataTable();
                if(rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false))
                {
                    MessageBox.Show("Select some critaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (rbtnDay.Checked.Equals(true))
                {
                    dt = dal.GetData(dtpKillen.Value.Day, dtpKillen.Value.Month, dtpKillen.Value.Year);
                }
                else if (rbtnMonth.Checked.Equals(true))
                {
                    dt = dal.GetDataByMonth(dtpKillen.Value.Month, dtpKillen.Value.Year);
                }
                else { }
                if (dt.Rows.Equals(0))
                {
                    MessageBox.Show("No record found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dgvKillenReport.DataSource = dt;
                    dgvKillenReport.Columns["ItemID"].Visible = false;
                    dgvKillenReport.Columns["StyleID"].Visible = false;
                    dgvKillenReport.Columns["SizeID"].Visible = false;
                    dgvKillenReport.Columns["ColorID"].Visible = false;
                    dgvKillenReport.Columns["ItemCategoryID"].Visible = false;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvKillenReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow =Convert.ToInt16(e.RowIndex);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRow.Equals(-1))
            {
                MessageBox.Show("Select record...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DailyKillenReportsTableAdapter dalDailyKillenReport = new DailyKillenReportsTableAdapter();
                    ReadyItemStockTableAdapter dalReadyItemStock = new ReadyItemStockTableAdapter();
                    KillenFeedStockTableAdapter dalKillenFeedStock = new KillenFeedStockTableAdapter();
                    int ready_stock_quantity = 0;
                    int feed_stock_quantity = 0;
                    DailyKillenReport obj = new DailyKillenReport();
                    obj.ItemID = Convert.ToInt32(dgvKillenReport.Rows[selectedRow].Cells["ItemID"].Value.ToString());
                    obj.StyleID = Convert.ToInt32(dgvKillenReport.Rows[selectedRow].Cells["StyleID"].Value.ToString());
                    obj.SizeID = Convert.ToInt32(dgvKillenReport.Rows[selectedRow].Cells["SizeID"].Value.ToString());
                    obj.ColorID = Convert.ToInt32(dgvKillenReport.Rows[selectedRow].Cells["ColorID"].Value.ToString());
                    obj.ItemCategoryID = Convert.ToInt32(dgvKillenReport.Rows[selectedRow].Cells["ItemCategoryID"].Value.ToString());
                    obj.KillenID = Convert.ToInt32(dgvKillenReport.Rows[selectedRow].Cells["KillenID"].Value.ToString());
                    obj.Date = Convert.ToDateTime(dgvKillenReport.Rows[selectedRow].Cells["Date"].Value.ToString());
                    obj.Quantity = Convert.ToInt32(dgvKillenReport.Rows[selectedRow].Cells["Quantity"].Value.ToString());
                    //----delete report
                    dalDailyKillenReport.DeleteQuery(obj.ItemID, obj.StyleID, obj.SizeID, obj.ColorID, obj.ItemCategoryID, obj.KillenID, obj.Date.Day, obj.Date.Month, obj.Date.Year);
                    //-----detuct from ready item stock
                    ready_stock_quantity = Convert.ToInt32(dalReadyItemStock.getStockByID(obj.ItemID, obj.StyleID, obj.SizeID, obj.ColorID, obj.ItemCategoryID));
                    dalReadyItemStock.UpdateQuery(ready_stock_quantity - obj.Quantity, obj.ItemID, obj.StyleID, obj.SizeID, obj.ColorID, obj.ItemCategoryID);    
                    //----return to killen feed stock
                    feed_stock_quantity = Convert.ToInt32(dalKillenFeedStock.getStockByID(obj.ItemID, obj.StyleID, obj.SizeID, obj.ColorID));
                    dalKillenFeedStock.UpdateQuery(feed_stock_quantity + obj.Quantity, obj.ItemID, obj.StyleID, obj.SizeID, obj.ColorID);
                    //------------------------
                    dgvKillenReport.Rows.RemoveAt(selectedRow);
                    selectedRow = -1;
                }
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        //-----report objects
        rptFrmDailyKillenReport report;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = (DataTable)dgvKillenReport.DataSource;
                if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false))
                {
                    MessageBox.Show("Select some citaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //if (!this.Parent.Contains(report))
                    //{
                        report = new rptFrmDailyKillenReport();
                        //report.TopLevel = false;
                        //report.Dock = DockStyle.Fill;
                        //this.Parent.Controls.Add(report);

                        if (rbtnDay.Checked.Equals(true))
                        {
                            report.reportByDateDT(dt);
                            report.BringToFront();
                            report.Show();
                        }
                        else if (rbtnMonth.Checked.Equals(true))
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
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //===================================================================================================================================================
    }
}
