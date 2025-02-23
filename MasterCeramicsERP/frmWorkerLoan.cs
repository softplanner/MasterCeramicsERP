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
    public partial class frmWorkerLoan : Form
    {
        int row = -1, selectedRow = -1;
        public frmWorkerLoan()
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

        private void frmWorkerLoan_Load(object sender, EventArgs e)
        {
            dtpLoan.Format = DateTimePickerFormat.Time;
            loadPersonDGV();
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

        private void btnAddShortLoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First select worker...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (txtUpdatedAmount.Text.Equals(""))
                {
                    MessageBox.Show("Enter amount...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    WorkerLoanInfoDAL loanInfoDAL = new WorkerLoanInfoDAL();
                    WorkerLoanReportDAL loanReportDAL = new WorkerLoanReportDAL();

                    int workerID = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells["ID"].Value);
                    int previousAmount = Convert.ToInt32(txtShortTermLoan.Text);
                    int newAmount = Convert.ToInt32(txtUpdatedAmount.Text);
                    int netAmount = previousAmount + newAmount;
                    loanInfoDAL.updateShortTermLoan(workerID, netAmount);
                    MessageBox.Show("Loan amount has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUpdatedAmount.Text = "";
                    txtShortTermLoan.Text = netAmount.ToString();
                    //=====add report
                    WorkerLoanReport report = new WorkerLoanReport();
                    report.WorkerID = workerID;
                    report.LoanType = "Short Term Loan Grant";
                    report.Amount= Convert.ToInt32(newAmount);
                    report.Date = dtpLoan.Value;
                    loanReportDAL.addReport(report);
                    MessageBox.Show("Loan report has been added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //=====end add report
                    selectedRow = -1;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeductShortTermLoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First select worker...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (txtUpdatedAmount.Text.Equals(""))
                {
                    MessageBox.Show("Enter amount...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    int workerID = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells["ID"].Value);
                    int previousAmount = Convert.ToInt32(txtShortTermLoan.Text);
                    int newAmount = Convert.ToInt32(txtUpdatedAmount.Text);
                    if (previousAmount < newAmount)
                    {
                        MessageBox.Show("Worker has insufficient amount...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        WorkerLoanInfoDAL loanInfoDAL = new WorkerLoanInfoDAL();
                        WorkerLoanReportDAL loanReportDAL = new WorkerLoanReportDAL();

                        int netAmount = previousAmount - newAmount;
                        loanInfoDAL.updateShortTermLoan(workerID, netAmount);
                        MessageBox.Show("Amount has deducted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUpdatedAmount.Text = "";
                        txtShortTermLoan.Text = netAmount.ToString();
                        //=====add report
                        WorkerLoanReport report = new WorkerLoanReport();
                        report.WorkerID = workerID;
                        report.LoanType = "Short Term Loan Deduct";
                        report.Amount = Convert.ToInt32(newAmount);
                        report.Date = dtpLoan.Value;
                        loanReportDAL.addReport(report);
                        //=====end add report
                    }
                }
                selectedRow = -1;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddAdvanceLoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First select worker...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (txtUpdatedAmount.Text.Equals(""))
                {
                    MessageBox.Show("Enter amount...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    WorkerLoanInfoDAL loanInfoDAL = new WorkerLoanInfoDAL();
                    WorkerLoanReportDAL loanReportDAL = new WorkerLoanReportDAL();

                    int workerID = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells["ID"].Value);
                    int previousAmount = Convert.ToInt32(txtAdvanceLoan.Text);
                    int newAmount = Convert.ToInt32(txtUpdatedAmount.Text);
                    int netAmount = previousAmount + newAmount;
                    loanInfoDAL.updateAdvanceLoan(workerID, netAmount);
                    MessageBox.Show("Loan amount has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUpdatedAmount.Text = "";
                    txtAdvanceLoan.Text = netAmount.ToString();
                    //=====add report
                    WorkerLoanReport report = new WorkerLoanReport();
                    report.WorkerID = workerID;
                    report.LoanType = "Advance Loan Grant";
                    report.Amount = Convert.ToInt32(newAmount);
                    report.Date = dtpLoan.Value;
                    loanReportDAL.addReport(report);
                    MessageBox.Show("Loan report has been added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //=====end add report
                }
                selectedRow = -1;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeductAdvanceLoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First select worker...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (txtUpdatedAmount.Text.Equals(""))
                {
                    MessageBox.Show("Enter amount...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    int workerID = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells["ID"].Value);
                    int previousAmount = Convert.ToInt32(txtAdvanceLoan.Text);
                    int newAmount = Convert.ToInt32(txtUpdatedAmount.Text);
                    if (previousAmount < newAmount)
                    {
                        MessageBox.Show("Worker has insufficient amount...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        WorkerLoanInfoDAL loanInfoDAL = new WorkerLoanInfoDAL();
                        WorkerLoanReportDAL loanReportDAL = new WorkerLoanReportDAL();

                        int netAmount = previousAmount - newAmount;
                        loanInfoDAL.updateAdvanceLoan(workerID, netAmount);
                        MessageBox.Show("Amount has been deducted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUpdatedAmount.Text = "";
                        txtAdvanceLoan.Text = netAmount.ToString();
                        //=====add report
                        WorkerLoanReport report = new WorkerLoanReport();
                        report.WorkerID = workerID;
                        report.LoanType = "Advance Loan Deduct";
                        report.Amount = Convert.ToInt32(newAmount);
                        report.Date = dtpLoan.Value;
                        loanReportDAL.addReport(report);
                        //=====end add report
                    }
                }
                selectedRow = -1;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtnDailyWager_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDailyWager.Checked.Equals(true))
            {
                //lblShortTermLoan.Text = "Advance Loan";
                //btnAddShortLoan.Text = "Add Advance Loan";
                //btnDeductShortTermLoan.Text = "Deduct Advance Loan";
                //lblAdvanceLoan.Visible = false;
                //txtAdvanceLoan.Visible = false;
                //btnAddAdvanceLoan.Visible = false;
                //btnDeductAdvanceLoan.Visible = false;
                btnAddShortLoan.Visible = false;
                btnDeductShortTermLoan.Visible = false;
                lblShortTermLoan.Visible = false;
                txtShortTermLoan.Visible = false;
                
            }
        }

        private void rbtnOtherWorker_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnOtherWorker.Checked.Equals(true))
            {
                //lblShortTermLoan.Text = "Short Term Loan";
                //btnAddShortLoan.Text = "Add Short Term Loan";
                //btnDeductShortTermLoan.Text = "Deduct Short Term Loan";
                //lblAdvanceLoan.Visible = true;
                //txtAdvanceLoan.Visible = true;
                //btnAddAdvanceLoan.Visible = true;
                //btnDeductAdvanceLoan.Visible = true;

                btnAddShortLoan.Visible = true;
                btnDeductShortTermLoan.Visible = true;
                lblShortTermLoan.Visible = true;
                txtShortTermLoan.Visible = true;
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
    }
}
