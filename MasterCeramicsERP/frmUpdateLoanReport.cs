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
    public partial class frmUpdateLoanReport : Form
    {
        int row = -1, selectedRow = -1,recordRow=-1,recordSelectedRow=-1;
        public frmUpdateLoanReport()
        {
            InitializeComponent();
        }
        private void loadPersonDGV()
        {
            try
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
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(selectedRow!=-1)
            {
                getLoanInfo();
            }
        }
        private void getLoanInfo()
        {
            try
            {
                WorkerLoanInfoDAL loanInfoDAL = new WorkerLoanInfoDAL();
                
                int workerID = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells["ID"].Value);
                WorkerLoanInfo w = new WorkerLoanInfo();
                if (loanInfoDAL.checkIsWorkerExist(workerID).Equals(true))
                {
                    w = loanInfoDAL.getWorkerLoanInfo(workerID);
                    txtShortTermLoan.Text = w.ShortTermLoan.ToString();
                    txtAdvanceLoan.Text = w.Advance.ToString();
                }
                else
                {
                    w.WorkerID = workerID;
                    w.ShortTermLoan = 0;
                    w.Advance = 0;
                    loanInfoDAL.addNewWorkerAccount(w);
                    txtShortTermLoan.Text = "0";
                    txtAdvanceLoan.Text = "0";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            selectedRow = -1;
            recordSelectedRow = -1;
            txtUpdatedAmount.Text = "";
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            show();
        }
        private void show()
        {
            try
            {
                WorkerLoanReportTableAdapter dal = new WorkerLoanReportTableAdapter();
                dsPayroll.WorkerLoanReportDataTable dt = new dsPayroll.WorkerLoanReportDataTable();

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
                if (dt.Rows.Equals(0))
                {
                    MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    selectedRow = -1;
                }
                else
                {
                    dgvRecord.DataSource = dt;
                    dgvRecord.Columns["WorkerID"].Visible = false;
                }

                //===============================//
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUpdateLoanReport_Load(object sender, EventArgs e)
        {
            dtpAttendence.Format = DateTimePickerFormat.Time;
            loadPersonDGV();
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
                    WorkerLoanReportTableAdapter dal = new WorkerLoanReportTableAdapter();
                    WorkerLoanReport report = new WorkerLoanReport();
                    WorkerLoanInfoTableAdapter dalLoanInfo = new WorkerLoanInfoTableAdapter();

                    int workerID = Convert.ToInt32(dgvRecord.Rows[recordSelectedRow].Cells["WorkerID"].Value);
                    string loanType = dgvRecord.Rows[recordSelectedRow].Cells["LoanType"].Value.ToString();
                    DateTime date = Convert.ToDateTime(dgvRecord.Rows[recordSelectedRow].Cells["Date"].Value);
                    int amount = Convert.ToInt32(dgvRecord.Rows[recordSelectedRow].Cells["Amount"].Value);

                    //report.WorkerID = workerID;
                    //report.Date = date;
                    //report.LoanType = loanType;
                    //report.Amount = amount;
                    dal.DeleteQuery(date.Day,date.Month,date.Year,workerID,loanType,amount);
                    MessageBox.Show("Report has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //=====update worker loan grant
                    if (loanType.Equals("Short Term Loan Grant"))
                    {
                        int loan = Convert.ToInt32(dalLoanInfo.getShortLoan(workerID));
                        dalLoanInfo.UpdateShortLoan(Convert.ToInt32(loan - amount), workerID);
                    }
                    else if (loanType.Equals("Advance Loan Grant"))
                    {
                        int loan = Convert.ToInt32(dalLoanInfo.getAdvanceLoan(workerID));
                        dalLoanInfo.UpdateAdvanceLoan(Convert.ToInt32(loan - amount),workerID);
                    }
                    //end update worker loan grant

                    //=====update worker loan deduct
                    else if (loanType.Equals("Short Term Loan Deduct"))
                    {
                        int loan = Convert.ToInt32(dalLoanInfo.getShortLoan(workerID));
                        dalLoanInfo.UpdateShortLoan(Convert.ToInt32(loan + amount), workerID);
                    }
                    else if (loanType.Equals("Advance Loan Deduct"))
                    {
                        int loan = Convert.ToInt32(dalLoanInfo.getAdvanceLoan(workerID));
                        dalLoanInfo.UpdateAdvanceLoan(Convert.ToInt32(loan + amount), workerID);
                    }
                    //end update worker loan deduct

                    MessageBox.Show("Worker loan has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAdvanceLoan.Text = "";
                    txtShortTermLoan.Text = "";
                    txtUpdatedAmount.Text = "";
                    dgvRecord.Rows.RemoveAt(recordSelectedRow);
                    recordSelectedRow = -1;
                }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (recordSelectedRow.Equals(-1))
                {
                    MessageBox.Show("First select record...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtUpdatedAmount.Text.Equals(""))
                {
                    MessageBox.Show("Enter updated amount...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    WorkerLoanReportTableAdapter dal = new WorkerLoanReportTableAdapter();
                    WorkerLoanReport report = new WorkerLoanReport();
                    WorkerLoanInfoTableAdapter dalLoanInfo = new WorkerLoanInfoTableAdapter();

                    int workerID = Convert.ToInt32(dgvRecord.Rows[recordSelectedRow].Cells["WorkerID"].Value);
                    string loanType = dgvRecord.Rows[recordSelectedRow].Cells["LoanType"].Value.ToString();
                    DateTime date = Convert.ToDateTime(dgvRecord.Rows[recordSelectedRow].Cells["Date"].Value);
                    int amount = Convert.ToInt32(dgvRecord.Rows[recordSelectedRow].Cells["Amount"].Value);
                    int updatedAmount = Convert.ToInt32(txtUpdatedAmount.Text);
                    dal.UpdateQuery(amount,date.Day,date.Month,date.Year,workerID,loanType);
                    MessageBox.Show("Report has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //=====update worker loan grant
                    if (loanType.Equals("Short Term Loan Grant") || loanType.Equals("Short Term Loan Deduct"))
                    {
                        int loan = Convert.ToInt32(dalLoanInfo.getShortLoan(workerID));
                        dalLoanInfo.UpdateShortLoan(Convert.ToInt32(loan - amount + updatedAmount), workerID);
                    }
                    else if (loanType.Equals("Advance Loan Grant") || loanType.Equals("Advance Loan Deduct"))
                    {
                        int loan = Convert.ToInt32(dalLoanInfo.getAdvanceLoan(workerID));
                        dalLoanInfo.UpdateAdvanceLoan(Convert.ToInt32(loan - amount + updatedAmount), workerID);
                    }
                    //end update worker loan grant


                    MessageBox.Show("Worker loan has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAdvanceLoan.Text = "";
                    txtShortTermLoan.Text = "";
                    txtUpdatedAmount.Text = "";
                    recordSelectedRow = -1;
                    //-----refresh databse of worker loan report
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUpdatedAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtUpdatedAmount_MouseClick(object sender, MouseEventArgs e)
        {
            txtUpdatedAmount.Focus();
        }
        //-----report object
        rptFrmPLoan report;
        private void btnprintReport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = (DataTable)dgvRecord.DataSource;
                //if (!this.Parent.Contains(report))
                //{
                    report = new rptFrmPLoan();
                    //report.TopLevel = false;
                    //report.Dock = DockStyle.Fill;
                    //this.Parent.Controls.Add(report);
                    //report.Show();

                    if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false) && rbtnYear.Checked.Equals(false))
                    {
                        MessageBox.Show("Select view report type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (rbtnDay.Checked.Equals(true) || rbtnMonth.Checked.Equals(true) || rbtnYear.Checked.Equals(true))
                    {
                        if (selectedRow.Equals(-1))
                        {
                            report.dailyReportByDateDT(dt);
                            report.BringToFront();
                            report.Show();
                        }
                        else
                        {
                            report.dailyReportByDateWorkerDT(dt);
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
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
