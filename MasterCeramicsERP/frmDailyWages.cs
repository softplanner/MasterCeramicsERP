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
    public partial class frmDailyWages : Form
    {
        int row = -1, selectedRow = -1,recordRow=-1;
        public frmDailyWages()
        {
            InitializeComponent();
        }

        private void frmDailyWages_Load(object sender, EventArgs e)
        {
            refresh();
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
            if (selectedRow != -1)
            {
                getLoanInfo();
            }
        }
        private void getLoanInfo()
        {
            try
            {
                WorkerLoanInfoDAL loanInfoDAL = new WorkerLoanInfoDAL();
                int workerID = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells[0].Value);
                WorkerLoanInfo w = new WorkerLoanInfo();
                if (loanInfoDAL.checkIsWorkerExist(workerID).Equals(true))
                {
                    int advanceLoan = loanInfoDAL.getAdvanceLoan(workerID);
                    txtAdvanceLoan.Text = advanceLoan.ToString();
                }
                else
                {
                    w.WorkerID = workerID;
                    w.ShortTermLoan = 0;
                    w.Advance = 0;
                    loanInfoDAL.addNewWorkerAccount(w);
                    txtAdvanceLoan.Text = "0";
                }
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
                    MessageBox.Show("Select worker...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtAttendence.Text.Equals(""))
                {
                    MessageBox.Show("Enter no. of attendence...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPerDay.Text.Equals(""))
                {
                    MessageBox.Show("Enter per day wage of worker...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtLoanDeduction.Text.Equals(""))
                {
                    MessageBox.Show("Enter loan amount...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtTotalAmount.Text = Convert.ToString(Convert.ToInt32(txtAttendence.Text) * Convert.ToInt32(txtPerDay.Text));
                    if (Convert.ToInt32(txtLoanDeduction.Text) > Convert.ToInt32(txtAdvanceLoan.Text))
                    {
                        MessageBox.Show("Entered loan deduction amount is greater than advance loan amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (Convert.ToInt32(txtLoanDeduction.Text) > Convert.ToInt32(txtTotalAmount.Text))
                    {
                        MessageBox.Show("Worker does not contain sufficient amount to return loan ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtBalanceAmount.Text = Convert.ToString(Convert.ToInt32(txtTotalAmount.Text) - Convert.ToInt32(txtLoanDeduction.Text));
                        txtBalanceAdvance.Text = Convert.ToString(Convert.ToInt32(txtAdvanceLoan.Text) - Convert.ToInt32(txtLoanDeduction.Text));
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
        private void addRecord()
        {
            int wid = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells["ID"].Value.ToString());
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
            dgvRecord.Rows[row].Cells["PerDay"].Value = txtPerDay.Text;
            dgvRecord.Rows[row].Cells["Attendance"].Value = txtAttendence.Text;
            dgvRecord.Rows[row].Cells["PerDay"].Value = txtPerDay.Text;
            dgvRecord.Rows[row].Cells["TotalAmount"].Value = txtTotalAmount.Text;
            dgvRecord.Rows[row].Cells["AdvanceLoan"].Value = txtAdvanceLoan.Text;
            dgvRecord.Rows[row].Cells["DeductAdvance"].Value = txtLoanDeduction.Text;
            dgvRecord.Rows[row].Cells["BalanceAmount"].Value = txtBalanceAmount.Text;
            dgvRecord.Rows[row].Cells["BalanceAdvance"].Value = txtBalanceAdvance.Text;
            dgvRecord.Rows[row].Cells["Date"].Value = DateTime.Now.ToString();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
            btnCalculate.Enabled = true;
        }
        private void refresh()
        {
            txtAdvanceLoan.Text = "0";
            txtAttendence.Text = "0";
            txtPerDay.Text = "0";
            txtTotalAmount.Text = "0";
            txtLoanDeduction.Text = "0";
            txtBalanceAmount.Text = "0";
            txtBalanceAdvance.Text = "";
            selectedRow = -1;
            recordRow=-1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (row.Equals(-1))
                {
                    MessageBox.Show("No record found ?...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DailyWagesTableAdapter dal = new DailyWagesTableAdapter();
                    WorkerLoanInfoTableAdapter dalLoan = new WorkerLoanInfoTableAdapter();
                    int wid = 0, att = 0, perday = 0, totAmo = 0, advLoan=0,DedAdv = 0, BalAmo = 0, BalAdv = 0;
                    int wAdvLoan = 0;
                    for (int i = 0; i < dgvRecord.Rows.Count; i++)
                    {
                        wid = Convert.ToInt32(dgvRecord.Rows[i].Cells["WorkerID"].Value.ToString());
                        perday = Convert.ToInt32(dgvRecord.Rows[i].Cells["PerDay"].Value.ToString());
                        att = Convert.ToInt32(dgvRecord.Rows[i].Cells["Attendance"].Value.ToString());
                        totAmo = Convert.ToInt32(dgvRecord.Rows[i].Cells["TotalAmount"].Value.ToString());
                        advLoan = Convert.ToInt32(dgvRecord.Rows[i].Cells["AdvanceLoan"].Value.ToString());
                        DedAdv = Convert.ToInt32(dgvRecord.Rows[i].Cells["DeductAdvance"].Value.ToString());
                        BalAmo = Convert.ToInt32(dgvRecord.Rows[i].Cells["BalanceAmount"].Value.ToString());
                        BalAdv = Convert.ToInt32(dgvRecord.Rows[i].Cells["BalanceAdvance"].Value.ToString());
                        //=====add report
                        dal.InsertQuery(wid, perday, att, totAmo, DedAdv, BalAmo, BalAdv, DateTime.Now,advLoan);
                        //=====update loan info
                        wAdvLoan = Convert.ToInt32(dalLoan.getAdvanceLoan(wid)) - DedAdv;
                        dalLoan.UpdateAdvanceLoan(wAdvLoan, wid);
                    }
                    btnCalculate.Enabled = true;
                    dgvRecord.Rows.Clear();
                    refresh();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAttendence_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtPerDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtLoanDeduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtAttendence_MouseClick(object sender, MouseEventArgs e)
        {
            txtAttendence.Focus();
        }

        private void txtPerDay_MouseClick(object sender, MouseEventArgs e)
        {
            txtPerDay.Focus();
        }

        private void txtLoanDeduction_MouseClick(object sender, MouseEventArgs e)
        {
            txtLoanDeduction.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(recordRow.Equals(-1))
            {
                MessageBox.Show("Select record to delete ?...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Are you sure you want to delete ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvRecord.Rows.RemoveAt(recordRow);
                row--;
                refresh();
            }
        }

        private void dgvRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            recordRow = e.RowIndex;
        }

    }
}
