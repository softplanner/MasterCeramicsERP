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

namespace MasterCeramicsERP
{
    public partial class frmChangeWorkerLoanAmount : Form
    {
        int row = -1, selectedRow = -1;
        //PersonDAL personDAL = new PersonDAL();
        //WorkerLoanInfoDAL loanInfoDAL = new WorkerLoanInfoDAL();
        public frmChangeWorkerLoanAmount()
        {
            InitializeComponent();
        }
        private void loadPersonDGV()
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                
                row = -1;
                selectedRow = -1;
                dgvPerson.Rows.Clear();
                List<Person> lst = new List<Person>();
                lst = personDAL.getPersonIDNameByCategory("Worker");
                lst.TrimExcess();
                for (int i = 0; i < lst.Count; i++)
                {
                    row = dgvPerson.Rows.Add();
                    dgvPerson.Rows[row].Cells[0].Value = lst[i].ID.ToString();
                    dgvPerson.Rows[row].Cells[1].Value = lst[i].Name;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                PersonDAL personDAL = new PersonDAL();
                WorkerLoanInfoDAL loanInfoDAL = new WorkerLoanInfoDAL();

                int workerID = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells[0].Value);
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
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmChangeWorkerLoanAmount_Load(object sender, EventArgs e)
        {
            loadPersonDGV();
        }

        private void btnUpdateLoan_Click(object sender, EventArgs e)
        {
            if(selectedRow.Equals(-1))
            {
                MessageBox.Show("First select worker... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtUpdatedAmount.Text.Equals(""))
            {
                MessageBox.Show("Enter loan amount...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rbtnShortLoan.Checked.Equals(false) && rbtnAdvanceLoan.Checked.Equals(false))
            {
                MessageBox.Show("Select loan type...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PersonDAL personDAL = new PersonDAL();
                WorkerLoanInfoDAL loanInfoDAL = new WorkerLoanInfoDAL();

                int workerID = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells[0].Value);
                if (rbtnShortLoan.Checked.Equals(true))
                {
                    int amount = Convert.ToInt32(txtUpdatedAmount.Text);
                    loanInfoDAL.updateShortTermLoan(workerID, amount);
                    MessageBox.Show("Short term loan has been updated... ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int amount = Convert.ToInt32(txtUpdatedAmount.Text);
                    loanInfoDAL.updateAdvanceLoan(workerID, amount);
                    MessageBox.Show("Advance loan has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtUpdatedAmount.Text = "";
                getLoanInfo();
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
