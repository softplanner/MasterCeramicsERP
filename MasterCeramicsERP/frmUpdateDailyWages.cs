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
using MasterCeramicsERP.Datasets.dsPayrollTableAdapters;

namespace MasterCeramicsERP
{
    public partial class frmUpdateDailyWages : Form
    {
        int row = -1, selectedRow = -1, recordRow = -1, recordSelectedRow = -1;

        public frmUpdateDailyWages()
        {
            InitializeComponent();
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

        private void frmUpdateDailyWages_Load(object sender, EventArgs e)
        {
            loadPersonDGV();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DailyWagesTableAdapter dal=new DailyWagesTableAdapter();
                dsPayroll.DailyWagesDataTable dt = new dsPayroll.DailyWagesDataTable();

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
                        dt = dal.GetDataByDateWorker(dtpAttendence.Value.Day, dtpAttendence.Value.Month, dtpAttendence.Value.Year, workerID);
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
                        dt = dal.GetDataByMonthWorker(dtpAttendence.Value.Month, dtpAttendence.Value.Year, workerID);
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
                        dt = dal.GetDataByYearWorker(dtpAttendence.Value.Year, workerID);
                    }
                }
                else { }
                if (dt.Rows.Count.Equals(0))
                {
                    MessageBox.Show("No record found ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dgvRecord.DataSource = dt;
                    selectedRow = -1;
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
                DailyWagesTableAdapter dal = new DailyWagesTableAdapter();
                
                if (recordSelectedRow.Equals(-1))
                {
                    MessageBox.Show("First select from record... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("Are you sure you want to delete ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //=====delete report
                    int id = Convert.ToInt32(dgvRecord.Rows[recordSelectedRow].Cells["WorkerID"].Value.ToString());
                    DateTime d = Convert.ToDateTime(dgvRecord.Rows[recordSelectedRow].Cells["Date"].Value.ToString());
                    dal.DeleteQuery(d.Day,d.Month,d.Year,id);
                    MessageBox.Show("Selected record deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //=====end delete report
                    //=====update worker loan
                    int loan = Convert.ToInt32(dgvRecord.Rows[recordSelectedRow].Cells["DeductAdvance"].Value);
                    if (loan > 0)
                    {
                        WorkerLoanInfoTableAdapter dalLoan = new WorkerLoanInfoTableAdapter();
                        int workerLoan = Convert.ToInt32(dalLoan.getAdvanceLoan(id));
                        dalLoan.UpdateAdvanceLoan(workerLoan + loan,id);
                        MessageBox.Show("Worker loan updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //====end uupdate worker loan
                    dgvRecord.Rows.RemoveAt(recordSelectedRow);
                    recordRow--;
                    selectedRow = -1;
                }
                else { }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            recordSelectedRow = e.RowIndex;
        }
        rptFrmPDailyWages report;
        private void btnprintReport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = (DataTable)dgvRecord.DataSource;
                //if (!this.Parent.Contains(report))
                //{
                    report = new rptFrmPDailyWages();
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
                    selectedRow = -1;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
