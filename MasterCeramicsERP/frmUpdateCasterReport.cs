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
using MasterCeramicsERP.Datasets.dsPayrollTableAdapters;

namespace MasterCeramicsERP
{
    public partial class frmUpdateCasterReport : Form
    {
        int row = -1, selectedRow = -1, recordRow = -1, recordSelectedRow = -1;

        public frmUpdateCasterReport()
        {
            InitializeComponent();
        }
        
        private void frmUpdateCasterReport_Load(object sender, EventArgs e)
        {
            loadPersonDGV();
        }
        private void loadPersonDGV()
        {
            try
            {
                PersonTableAdapter dal = new PersonTableAdapter();
                dsPayroll.PersonDataTable dt = new dsPayroll.PersonDataTable();
                dt = dal.GetPersonInfo("Worker");
                dgvPerson.DataSource = dt;
                dgvPerson.Columns["ID"].Visible = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }
        private void clearRecordDGV()
        {
            recordRow = -1;
            recordSelectedRow = -1;
            dgvRecord.Rows.Clear();
        }

        private void dgvRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            recordSelectedRow = e.RowIndex;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                CasterPaymentNewTableAdapter dal = new CasterPaymentNewTableAdapter();
                dsPayroll.CasterPaymentNewDataTable dt = new dsPayroll.CasterPaymentNewDataTable();
                
                if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false) && rbtnYear.Checked.Equals(false))
                {
                    MessageBox.Show("First select some critaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //===============================
                else if (rbtnDay.Checked.Equals(true))
                {
                    if (selectedRow.Equals(-1))
                    {
                        dt = dal.GetDataByDate(dtpAttendence.Value.Day, dtpAttendence.Value.Month, dtpAttendence.Value.Year);
                    }
                    else
                    {
                        int workerID = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells["ID"].Value.ToString());
                        dt = dal.GetDataByDateWorker(dtpAttendence.Value.Day, dtpAttendence.Value.Month, dtpAttendence.Value.Year,workerID);
                    }
                }
                else if (rbtnMonth.Checked.Equals(true))
                {
                    if (selectedRow.Equals(-1))
                    {
                        dt = dal.GetDataByMonth(dtpAttendence.Value.Month, dtpAttendence.Value.Year);
                    }
                    else
                    {
                        int workerID = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells["ID"].Value.ToString());
                        dt = dal.GetDataByMonthWorker(dtpAttendence.Value.Month, dtpAttendence.Value.Year,workerID);
                    }
                }
                else if (rbtnYear.Checked.Equals(true))
                {
                    if (selectedRow.Equals(-1))
                    {
                        dt = dal.GetDataByYear(dtpAttendence.Value.Year);
                    }
                    else
                    {
                        int workerID = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells["ID"].Value.ToString());
                        dt = dal.GetDataByYearCaster(dtpAttendence.Value.Year, workerID);
                    }
                }
                else { }
                if (dt.Rows.Count.Equals(0))
                {
                    MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dgvRecord.DataSource = dt;
                    dgvRecord.Columns["ItemID"].Visible = false;
                    dgvRecord.Columns["StyleID"].Visible = false;
                    dgvRecord.Columns["SizeID"].Visible = false;
                }
                //===============================//
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (recordSelectedRow.Equals(-1))
                {
                    MessageBox.Show("First select record...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CasterPaymentNewTableAdapter dal = new CasterPaymentNewTableAdapter();
                    //=====delete report
                    int id = Convert.ToInt32(dgvRecord.Rows[recordSelectedRow].Cells["WorkerID"].Value.ToString());
                    DateTime d = Convert.ToDateTime(dgvRecord.Rows[recordSelectedRow].Cells["Date"].Value.ToString());
                    dal.DeleteQuery(d.Day, d.Month, d.Year, id);
                    //=====end delete report
                    //=====update worker loan
                    int shortLoan = Convert.ToInt32(dgvRecord.Rows[recordSelectedRow].Cells["DeductShortLoan"].Value.ToString());
                    int advanceLoan = Convert.ToInt32(dgvRecord.Rows[recordSelectedRow].Cells["DeductAdvanceLoan"].Value.ToString());
                    WorkerLoanInfoDAL dalLoan = new WorkerLoanInfoDAL();
                    if (shortLoan > 0)
                    {
                        int workerLoan = dalLoan.getShortTermLoan(id);
                        dalLoan.updateShortTermLoan(id, workerLoan + shortLoan);
                    }
                    if (advanceLoan > 0)
                    {
                        int workerLoan = dalLoan.getAdvanceLoan(id);
                        dalLoan.updateAdvanceLoan(id, workerLoan + advanceLoan);
                    }

                    //====end uupdate worker loan
                    //-----return checked item
                    CasterCheckedItemInfoTableAdapter dalCheckedItem = new CasterCheckedItemInfoTableAdapter();
                    int itemID = 0, styleID = 0, sizeID = 0,chkItem =0;
                    itemID = Convert.ToInt32(dgvRecord.Rows[recordSelectedRow].Cells["ItemID"].Value.ToString());
                    styleID = Convert.ToInt32(dgvRecord.Rows[recordSelectedRow].Cells["StyleID"].Value.ToString());
                    sizeID = Convert.ToInt32(dgvRecord.Rows[recordSelectedRow].Cells["SizeID"].Value.ToString());
                    chkItem = Convert.ToInt32(dgvRecord.Rows[recordSelectedRow].Cells["Quantity"].Value.ToString()) + Convert.ToInt32(dalCheckedItem.getStock(itemID, styleID, sizeID, id));
                    dalCheckedItem.UpdateQuery(chkItem, itemID, styleID, sizeID, id);
                    //------------------------
                    MessageBox.Show("Reprot Deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvRecord.Rows.RemoveAt(recordSelectedRow);
                    recordRow--;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        rptFrmPCasterPay report;
        private void btnprintReport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = (DataTable)dgvRecord.DataSource;
                //if (!this.Parent.Contains(report))
                //{
                    report = new rptFrmPCasterPay();
                    //report.TopLevel = false;
                    //report.Dock = DockStyle.Fill;
                    //this.Parent.Controls.Add(report);
                    //report.Show();

                    if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false) && rbtnYear.Checked.Equals(false))
                    {
                        MessageBox.Show("Select view report type...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (rbtnDay.Checked.Equals(true) || rbtnMonth.Checked.Equals(true) || rbtnYear.Checked.Equals(true))
                    {
                        if (selectedRow.Equals(-1))
                        {
                            report.dailyReportByDT(dt);
                            report.BringToFront();
                            report.Show();
                        }
                        else
                        {
                            report.dailyReportByWorkerDT(dt);
                            report.BringToFront();
                            report.Show();
                        }
                    }
                    else { }
                //}
                //else
                //{
                //    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            catch (Exception exp)
            {
                //MessageBox.Show("Error Accessing Database   " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
