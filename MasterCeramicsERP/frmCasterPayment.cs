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
    public partial class frmCasterPayment : Form
    {
        int row = -1, selectedRow = -1,recordRow = -1;

        public frmCasterPayment()
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

        private void frmCasterPayment_Load(object sender, EventArgs e)
        {
            loadPersonDGV();
        }
        private void dgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow != -1)
            {
                btnCalculate.Enabled = true;
                emptyTextFields();
                getLoanInfo();
            }
        }
        private void getLoanInfo()
        {
            try
            {
                int casterId = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells["ID"].Value.ToString());
                CasterCheckedItemInfoTableAdapter dal = new CasterCheckedItemInfoTableAdapter();
                DataTable dt = new DataTable();
                dt = (DataTable)dal.getCheckedItemByCasterID(casterId);
                WorkerLoanInfoTableAdapter dalLoan = new WorkerLoanInfoTableAdapter();
                ItemCastingRateTableAdapter dalItemRate = new ItemCastingRateTableAdapter();
                //----------------------------------------------------
                if (dt.Rows.Count != 0)
                {
                    dt = (DataTable)dal.getCheckedItemByCasterID(casterId);
                    txtItem.Text = dt.Rows[0]["Item"].ToString();
                    txtStyle.Text = dt.Rows[0]["Style"].ToString();
                    txtSize.Text = dt.Rows[0]["Size"].ToString();
                    txtQuantity.Text = dt.Rows[0]["Quantity"].ToString();
                    //---------------------------
                    if (dalLoan.getAdvanceLoan(casterId) == null)
                    {
                        txtAdvanceLoanTotal.Text = "0";
                        txtShortLoanDeduction.Text = "0";
                    }
                    else
                    {
                        txtAdvanceLoanTotal.Text = dalLoan.getAdvanceLoan(casterId).ToString();
                        txtShortTermLoanTotal.Text = dalLoan.getShortLoan(casterId).ToString();
                    }
                    //---------------------------
                    if (dalItemRate.getItemRateByItemName(txtItem.Text, txtStyle.Text, txtSize.Text) == null)
                    {
                        txtRate.Text = "0";
                    }
                    else
                    {
                        txtRate.Text = dalItemRate.getItemRateByItemName(txtItem.Text, txtStyle.Text, txtSize.Text).ToString();
                    }
                    txtTotalAmount.Text = (Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(txtRate.Text)).ToString();
                }
                else 
                {
                    MessageBox.Show("No record found ?...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                else
                {
                    if (txtQuantity.Text == "")
                    {
                        txtQuantity.Text = "0";
                    }
                    if (txtRate.Text == "0")
                    {
                        txtRate.Text = "0";
                    }
                    int totalAmount = Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(txtRate.Text);
                    txtTotalAmount.Text = totalAmount.ToString();
                    int shortLoan = Convert.ToInt32(txtShortLoanDeduction.Text);
                    int AdvanceLoan = Convert.ToInt32(txtAdvanceLoanDeduction.Text);

                    if (shortLoan > Convert.ToInt32(txtShortTermLoanTotal.Text))
                    {
                        MessageBox.Show("Entered short term loan deduction amount is greater than, loan contain by the selected worker...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (AdvanceLoan > Convert.ToInt32(txtAdvanceLoanTotal.Text))
                    {
                        MessageBox.Show("Entered advance loan deduction amount is greater than, loan contain by the selected worker...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if ((shortLoan + AdvanceLoan) > totalAmount)
                    {
                        MessageBox.Show("Worker does not contain sufficient amount to return loan ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        txtBalanceAmount.Text = Convert.ToString(totalAmount - (shortLoan + AdvanceLoan));
                        txtBalanceShortLoan.Text = (Convert.ToInt32(txtShortTermLoanTotal.Text) - shortLoan).ToString();
                        txtBalanceAdvance.Text = (Convert.ToInt32(txtAdvanceLoanTotal.Text) - AdvanceLoan).ToString();
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
            try
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
                dgvRecord.Rows[row].Cells["Item"].Value = txtItem.Text;
                dgvRecord.Rows[row].Cells["Style"].Value = txtStyle.Text;
                dgvRecord.Rows[row].Cells["Size"].Value = txtSize.Text;
                dgvRecord.Rows[row].Cells["Quantity"].Value = txtQuantity.Text;
                dgvRecord.Rows[row].Cells["Rate"].Value = txtRate.Text;
                dgvRecord.Rows[row].Cells["TotalAmount"].Value = txtTotalAmount.Text;
                dgvRecord.Rows[row].Cells["ShortLoan"].Value = txtShortTermLoanTotal.Text;
                dgvRecord.Rows[row].Cells["AdvanceLoan"].Value = txtAdvanceLoanTotal.Text;
                dgvRecord.Rows[row].Cells["DeductShortLoan"].Value = txtShortLoanDeduction.Text;
                dgvRecord.Rows[row].Cells["DeductAdvanceLoan"].Value = txtAdvanceLoanDeduction.Text;
                dgvRecord.Rows[row].Cells["BalanceAmount"].Value = txtBalanceAmount.Text;
                dgvRecord.Rows[row].Cells["BalanceAdvanceLoan"].Value = txtBalanceAdvance.Text;
                dgvRecord.Rows[row].Cells["BalanceShortLoan"].Value = txtBalanceShortLoan.Text;
                dgvRecord.Rows[row].Cells["Date"].Value = DateTime.Now.ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnCalculate.Enabled = true;
            btnSave.Enabled = true;
            emptyTextFields();
            selectedRow = recordRow = -1;
        }
        private void emptyTextFields() 
        {
            txtAdvanceLoanDeduction.Text = "";
            txtAdvanceLoanTotal.Text = "";
            txtShortLoanDeduction.Text = "";
            txtShortTermLoanTotal.Text = "";
            txtQuantity.Text = "";
            txtRate.Text = "";
            txtTotalAmount.Text = "";
            txtBalanceAmount.Text = "";
            txtBalanceAdvance.Text = "";
            txtBalanceShortLoan.Text = "";
            txtItem.Text = "";
            txtStyle.Text = "";
            txtSize.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRecord.Rows.Count.Equals(0))
                {
                    MessageBox.Show("No rrecord found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CasterPaymentNewTableAdapter dal = new CasterPaymentNewTableAdapter();
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    WorkerLoanInfoDAL loanInfoDAL = new WorkerLoanInfoDAL();
                    CasterPaymentNew c = new CasterPaymentNew();
                    for (int i = 0; i < dgvRecord.Rows.Count; i++)
                    {
                        c = new CasterPaymentNew();
                        c.WorkerID = Convert.ToInt32(dgvRecord.Rows[i].Cells["WorkerID"].Value.ToString());
                        c.ItemID = itemDAL.getItemID(dgvRecord.Rows[i].Cells["Item"].Value.ToString());
                        c.StyleID = styleDAL.getStyleID(dgvRecord.Rows[i].Cells["Style"].Value.ToString());
                        c.SizeID = sizeDAL.getSizeID(dgvRecord.Rows[i].Cells["Size"].Value.ToString());
                        c.Quantity = Convert.ToInt32(dgvRecord.Rows[i].Cells["Quantity"].Value.ToString());
                        c.Rate = Convert.ToInt32(dgvRecord.Rows[i].Cells["Rate"].Value.ToString());
                        c.TotalAmount = Convert.ToInt32(dgvRecord.Rows[i].Cells["TotalAmount"].Value.ToString());
                        c.ShortLoan = Convert.ToInt32(dgvRecord.Rows[i].Cells["ShortLoan"].Value.ToString());
                        c.AdvanceLoan = Convert.ToInt32(dgvRecord.Rows[i].Cells["AdvanceLoan"].Value.ToString());
                        c.DeductAdvLoan = Convert.ToInt32(dgvRecord.Rows[i].Cells["DeductAdvanceLoan"].Value.ToString());
                        c.DeductSTLoan = Convert.ToInt32(dgvRecord.Rows[i].Cells["DeductShortLoan"].Value.ToString());
                        c.BalanceAdvLoan = Convert.ToInt32(dgvRecord.Rows[i].Cells["BalanceAdvanceLoan"].Value.ToString());
                        c.BalanceSTLoan = Convert.ToInt32(dgvRecord.Rows[i].Cells["BalanceShortLoan"].Value.ToString());
                        c.BalanceAmount = Convert.ToInt32(dgvRecord.Rows[i].Cells["BalanceAmount"].Value.ToString());
                        c.Date = DateTime.Now;
                        dal.InsertQuery(c.WorkerID,c.ItemID,c.StyleID,c.SizeID,c.Quantity,c.Rate,c.TotalAmount,c.ShortLoan,c.AdvanceLoan,c.DeductSTLoan,c.DeductAdvLoan,c.BalanceSTLoan,c.BalanceAdvLoan,c.BalanceAmount,c.Date);
                        
                        //=====upadte loan info
                        loanInfoDAL.updateShortTermLoan(c.WorkerID, Convert.ToInt32(txtBalanceShortLoan.Text));
                        loanInfoDAL.updateAdvanceLoan(c.WorkerID, Convert.ToInt32(txtBalanceAdvance.Text));
                        
                        //-----end update loan info
                        //-----update checked item to zero
                        CasterCheckedItemInfoTableAdapter dalCheckeditem = new CasterCheckedItemInfoTableAdapter();
                        dalCheckeditem.UpdateCheckedItemToZero(0, c.ItemID, c.StyleID, c.SizeID, c.WorkerID);
                        //--------------------------------
                    }
                    MessageBox.Show("Report has been added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Loan record has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                    emptyTextFields();
                    selectedRow = recordRow = -1;
                    dgvRecord.Rows.Clear();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            txtQuantity.Focus();
        }

        private void txtRate_MouseClick(object sender, MouseEventArgs e)
        {
            txtRate.Focus();
        }

        private void txtShortLoanDeduction_MouseClick(object sender, MouseEventArgs e)
        {
            txtShortLoanDeduction.Focus();
        }

        private void txtAdvanceLoanDeduction_MouseClick(object sender, MouseEventArgs e)
        {
            txtAdvanceLoanDeduction.Focus();
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

        private void dgvRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            recordRow = e.RowIndex;
        }
    }
}
