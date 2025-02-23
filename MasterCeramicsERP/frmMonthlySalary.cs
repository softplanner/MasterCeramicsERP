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
    public partial class frmMonthlySalary : Form
    {
        int row=-1, recordRow = -1, selectedRow = -1;

        public frmMonthlySalary()
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

        private void frmMonthlySalary_Load(object sender, EventArgs e)
        {
            lblDate.Text = "Date :" + " " + DateTime.Now.Date.ToLongDateString();
            loadPersonDGV();
        }

        private void dgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow != -1)
            {
                getLoanInfo();
            }
        }
        private void getLoanInfo()
        {
            try
            {
                WorkerLoanInfoTableAdapter dal = new WorkerLoanInfoTableAdapter();
                SalaryForTheMonthOfTableAdapter dalSal = new SalaryForTheMonthOfTableAdapter();
                
                int workerID = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells["ID"].Value.ToString());
                if (dalSal.getSalary(workerID) == null)
                {
                    txtSalary.Text = "0";
                }
                else
                {
                    txtSalary.Text = dalSal.getSalary(workerID).ToString();
                }
                if (dal.getShortLoan(workerID) == null)
                {
                    txtShortTermLoanTotal.Text = "0";
                }
                else
                {
                    txtShortTermLoanTotal.Text = dal.getShortLoan(workerID).ToString();
                }
                if (dal.getAdvanceLoan(workerID) == null)
                {
                    txtAdvanceLoanTotal.Text = "0";
                }
                else
                {
                    txtAdvanceLoanTotal.Text = dal.getAdvanceLoan(workerID).ToString();
                }
                if (dalSal.getTotalAttendance(workerID, dtpMonthlySalary.Value.Month, dtpMonthlySalary.Value.Year) == null )
                {
                    txtAttendence.Text = "0";
                }
                else
                {
                    txtAttendence.Text = dalSal.getTotalAttendance(workerID, dtpMonthlySalary.Value.Month, dtpMonthlySalary.Value.Year).ToString();
                }
                if (dalSal.getTotalExtraAttendance(workerID, dtpMonthlySalary.Value.Month, dtpMonthlySalary.Value.Year) == null)
                {
                    txtExtraAttendence.Text = "0";
                }
                else
                {
                    txtExtraAttendence.Text = dalSal.getTotalExtraAttendance(workerID, dtpMonthlySalary.Value.Month, dtpMonthlySalary.Value.Year).ToString();
                }
                txtPerDay.Text = Math.Round(Convert.ToSingle(txtSalary.Text) / 30, 2).ToString();
                txtTotalAttendence.Text = (Convert.ToInt32(txtAttendence.Text) + Convert.ToInt32(txtExtraAttendence.Text)).ToString();
                txtTotalAmount.Text = Math.Round(Convert.ToSingle(Convert.ToInt32(txtTotalAttendence.Text) * Convert.ToSingle(txtPerDay.Text)),2).ToString();
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First select worker...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtShortLoanDeduction.Text.Equals(""))
                {
                    MessageBox.Show("Enter short term loan deduction amount...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtAdvanceLoanDeduction.Text.Equals(""))
                {
                    MessageBox.Show("Enter advance loan deduction amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int shortLoan = Convert.ToInt32(txtShortLoanDeduction.Text);
                    int AdvanceLoan = Convert.ToInt32(txtAdvanceLoanDeduction.Text);
                    float totalAmount = Convert.ToInt32(txtTotalAttendence.Text) * Convert.ToSingle(txtPerDay.Text);

                    if (shortLoan > Convert.ToInt32(txtShortTermLoanTotal.Text))
                    {
                        MessageBox.Show("Entered short term loan deduction amount is greater than, loan contain by the worker...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (AdvanceLoan > Convert.ToInt32(txtAdvanceLoanTotal.Text))
                    {
                        MessageBox.Show("Entered advance loan deduction amount is greater than, loan contain by the worker...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if ((shortLoan + AdvanceLoan) > totalAmount)
                    {
                        MessageBox.Show("Worker does not contain sufficient amount to return loan...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtTotalAmount.Text = totalAmount.ToString();
                        txtBalanceAmount.Text = Convert.ToString(totalAmount - (shortLoan + AdvanceLoan));
                        txtBalanceShortLoan.Text = Convert.ToString(Convert.ToInt32(txtShortTermLoanTotal.Text) - shortLoan);
                        txtBalanceAdvance.Text = Convert.ToString(Convert.ToInt32(txtAdvanceLoanTotal.Text) - AdvanceLoan);
                        btnCalculate.Enabled = false;
                        addRecord();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnCalculate.Enabled = true;
            refreshRecord();
        }
        private void refreshRecord()
        {
            row = selectedRow = recordRow = -1;
            txtAdvanceLoanDeduction.Text = "";
            txtAdvanceLoanTotal.Text = "";
            txtShortLoanDeduction.Text = "";
            txtShortTermLoanTotal.Text = "";
            txtAttendence.Text= "";
            txtExtraAttendence.Text = "";
            txtTotalAttendence.Text = "";
            txtPerDay.Text = "";
            txtTotalAmount.Text = "";
            txtBalanceAmount.Text = "";
            txtBalanceAdvance.Text = "";
            txtBalanceShortLoan.Text="";
            txtSalary.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRecord.Rows.Count.Equals(0))
                {
                    MessageBox.Show("No Record Found... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SalaryForTheMonthOfTableAdapter dal = new SalaryForTheMonthOfTableAdapter();
                    WorkerLoanInfoTableAdapter dalLoan = new WorkerLoanInfoTableAdapter();
                    int wid =0,sal=0,att=0,EAtt=0,TAtt=0,DSL=0,DAL=0,BSL=0,BAL=0;
                    float perDay = 0, TAmo = 0, BAmo = 0;
                    for (int i = 0; i < dgvRecord.Rows.Count;i++ )
                    {
                        wid = Convert.ToInt32(dgvRecord.Rows[i].Cells["WorkerID"].Value.ToString());
                        sal = Convert.ToInt32(dgvRecord.Rows[i].Cells["Salary"].Value.ToString());
                        att = Convert.ToInt32(dgvRecord.Rows[i].Cells["Attendance"].Value.ToString());
                        EAtt = Convert.ToInt32(dgvRecord.Rows[i].Cells["ExtraAttendance"].Value.ToString());
                        TAtt = Convert.ToInt32(dgvRecord.Rows[i].Cells["TotalAttendance"].Value.ToString());
                        perDay = Convert.ToSingle(dgvRecord.Rows[i].Cells["PerDay"].Value.ToString());
                        TAmo = Convert.ToSingle(dgvRecord.Rows[i].Cells["TotalAmount"].Value.ToString());
                        DSL = Convert.ToInt32(dgvRecord.Rows[i].Cells["DeductShortLoan"].Value.ToString());
                        DAL = Convert.ToInt32(dgvRecord.Rows[i].Cells["DeductAdvanceLoan"].Value.ToString());
                        BAmo = Convert.ToSingle(dgvRecord.Rows[i].Cells["BalanceAmount"].Value.ToString());
                        BSL = Convert.ToInt32(dgvRecord.Rows[i].Cells["BalanceShortLoan"].Value.ToString());
                        BAL = Convert.ToInt32(dgvRecord.Rows[i].Cells["BalanceAdvanceLoan"].Value.ToString());
                        dal.InsertQuery(wid,sal,att,EAtt,TAtt,perDay,TAmo,DSL,DAL,BAmo,BAL,BSL,dtpMonthlySalary.Value,DateTime.Now);
                    }
                    
                    MessageBox.Show("Monthly salary report has been added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //=====upadte loan info
                    dalLoan.UpdateShortLoan(BSL, wid);
                    dalLoan.UpdateAdvanceLoan(BAL, wid);
                    MessageBox.Show("Loan updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //-----end update loan info
                    refreshRecord();
                    dgvRecord.Rows.Clear();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPerDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtShortLoanDeduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtAdvanceLoanDeduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtPerDay_MouseClick(object sender, MouseEventArgs e)
        {
            txtPerDay.Focus();
        }

        private void txtShortLoanDeduction_MouseClick(object sender, MouseEventArgs e)
        {
            txtShortLoanDeduction.Focus();
        }

        private void txtAdvanceLoanDeduction_MouseClick(object sender, MouseEventArgs e)
        {
            txtAdvanceLoanDeduction.Focus();
        }

        private void dgvRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            recordRow = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (recordRow.Equals(-1))
                {
                    MessageBox.Show("Select Record to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("Are you sure you want to delete ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvRecord.Rows.RemoveAt(recordRow);
                    row--;
                }
                else { }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addRecord()
        {
            int wid=Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells["ID"].Value.ToString());
            if (row != -1)
            {
                for (int i = 0; i < dgvRecord.Rows.Count; i++)
                {
                    if (dgvRecord.Rows[i].Cells["WorkerID"].Value.ToString().Equals(wid.ToString()))
                    {
                        dgvRecord.Rows.RemoveAt(i);
                        row--;
                        break;
                    }
                }
            }
            row = dgvRecord.Rows.Add();
            dgvRecord.Rows[row].Cells["WorkerID"].Value = wid.ToString();
            dgvRecord.Rows[row].Cells["rWorker"].Value = dgvPerson.Rows[selectedRow].Cells["Worker"].Value.ToString();
            dgvRecord.Rows[row].Cells["Salary"].Value = txtSalary.Text;
            dgvRecord.Rows[row].Cells["Attendance"].Value = txtAttendence.Text;
            dgvRecord.Rows[row].Cells["ExtraAttendance"].Value = txtExtraAttendence.Text;
            dgvRecord.Rows[row].Cells["TotalAttendance"].Value = txtTotalAttendence.Text;
            dgvRecord.Rows[row].Cells["PerDay"].Value = txtPerDay.Text;
            dgvRecord.Rows[row].Cells["TotalAmount"].Value = txtTotalAmount.Text;
            dgvRecord.Rows[row].Cells["DeductShortLoan"].Value = txtShortLoanDeduction.Text;
            dgvRecord.Rows[row].Cells["DeductAdvanceLoan"].Value = txtAdvanceLoanDeduction.Text;
            dgvRecord.Rows[row].Cells["BalanceAmount"].Value = txtBalanceAmount.Text;
            dgvRecord.Rows[row].Cells["BalanceAdvanceLoan"].Value = txtBalanceAdvance.Text;
            dgvRecord.Rows[row].Cells["BalanceShortLoan"].Value = txtBalanceShortLoan.Text;
            dgvRecord.Rows[row].Cells["Date"].Value = DateTime.Now.ToString();    
        }
    }
}
