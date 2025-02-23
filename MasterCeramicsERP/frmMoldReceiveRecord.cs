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
    public partial class frmMoldReceiveRecord : Form
    {
        DataSet dsItem = new DataSet();
        DataSet dsStyle = new DataSet();
        DataSet dsSize = new DataSet();
        DataSet dsJobs = new DataSet();
        DataSet dsWorker = new DataSet();
        
        Int16 row = -1, selectedRow = -1, casterRow = -1;
        
        
        public frmMoldReceiveRecord()
        {
            InitializeComponent();
        }

        private void frmMoldReceiveRecord_Load(object sender, EventArgs e)
        {
            populateJobsCBX();
            populateComboBoxes();
            //loadCasterDGV();
        }
        private void populateJobsCBX()
        {
            try
            {
                
                JobsDAL jobDal = new JobsDAL();

                //populate cbx supplier
                dsJobs.Clear();
                dsJobs = jobDal.getAllJobsDataSet();
                cbxSelectJob.DataSource = dsJobs.Tables[0];
                cbxSelectJob.DisplayMember = "Name";
                //end populate
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void populateComboBoxes()
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                
                //populate item cbx
                dsItem.Clear();
                dsItem = itemDAL.getAllItem();
                cbxItem.DataSource = dsItem.Tables[0];
                cbxItem.DisplayMember = "Name";
                //end populate

                //populate style cbx
                dsStyle.Clear();
                dsStyle = styleDAL.getAllItemStyle();
                cbxStyle.DataSource = dsStyle.Tables[0];
                cbxStyle.DisplayMember = "Name";
                //end populate

                //populate size cbx
                dsSize.Clear();
                dsSize = sizeDAL.getAllItemSize();
                cbxSize.DataSource = dsSize.Tables[0];
                cbxSize.DisplayMember = "Name";
                //end populate
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxWorker.Text.Equals(""))
            {
                MessageBox.Show("Select caster...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtQuantityReceived.Text == "")
            {
                MessageBox.Show("Enter received quantity... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtQunatityIssued.Text.Equals(""))
            {
                MessageBox.Show("Enter issued quantity... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtBreakage.Text.Equals(""))
            {
                MessageBox.Show("Enter breakage quantity... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(txtQunatityIssued.Text) + Convert.ToInt32(txtBreakage.Text) > Convert.ToInt32(txtQuantityReceived.Text))
            {
                MessageBox.Show("Entered issued and breakage quantity is greater than available received quantity... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                    addRowToDataGrid();
            }
        }

        private void addRowToDataGrid()
        {
            int id = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
            for (Int16 i = 0; i <= row;i++ )
            {
                if(dgvMold.Rows[i].Cells["Item"].Value.ToString().Equals(cbxItem.Text))
                {
                    if (dgvMold.Rows[i].Cells["Style"].Value.ToString().Equals(cbxStyle.Text))
                    {
                        if (dgvMold.Rows[i].Cells["Size"].Value.ToString().Equals(cbxSize.Text))
                        {
                            if (dgvMold.Rows[i].Cells["CasterID"].Value.ToString().Equals(id.ToString()))
                            {
                                dgvMold.Rows.RemoveAt(i);
                                row--;
                                break;
                            }
                        }
                    }
                }
            }
            //////------Show record in the data grid view------//////
            row = Convert.ToInt16(dgvMold.Rows.Add());
            int quantity = 0;
            //MessageBox.Show(row.ToString());
            dgvMold.Rows[row].Cells["CasterID"].Value = id.ToString();
            dgvMold.Rows[row].Cells["Caster"].Value = cbxWorker.Text;
            dgvMold.Rows[row].Cells["Item"].Value = cbxItem.Text;
            dgvMold.Rows[row].Cells["Style"].Value = cbxStyle.Text;
            dgvMold.Rows[row].Cells["Size"].Value = cbxSize.Text;
            dgvMold.Rows[row].Cells["DateReceived"].Value = dtpDateReceipt.Value.ToString();
            dgvMold.Rows[row].Cells["QuantityReceived"].Value = txtQuantityReceived.Text;
            dgvMold.Rows[row].Cells["QuantityIssued"].Value = txtQunatityIssued.Text;
            dgvMold.Rows[row].Cells["DateExpiry"].Value = dtpDateExpiry.Value.ToString();
            dgvMold.Rows[row].Cells["Breakage"].Value = txtBreakage.Text;
            dgvMold.Rows[row].Cells["BreakageCause"].Value = txtBreakageCause.Text;
            quantity = Convert.ToInt32(dgvMold.Rows[row].Cells["QuantityReceived"].Value.ToString()) - Convert.ToInt32(dgvMold.Rows[row].Cells["QuantityIssued"].Value.ToString());
            quantity = quantity - Convert.ToInt32(dgvMold.Rows[row].Cells["Breakage"].Value.ToString());
            txtBalance.Text = quantity.ToString();
            dgvMold.Rows[row].Cells["Balance"].Value = txtBalance.Text;
            ////------End show record in the data grid view------////
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (selectedRow == -1)
            {
                MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvMold.Rows.RemoveAt(selectedRow);
                    selectedRow = -1;
                    row--;
                }
            }
            txtQuantityReceived.Text = "";
            txtQunatityIssued.Text = "";
            txtBreakage.Text = "";
            txtBreakageCause.Text = "";
            txtBalance.Text = "";
        }

        private void btnAddDB_Click(object sender, EventArgs e)
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                MoldRegisterRecord m;
                MoldRegisterRecordTableAdapter dalReport = new MoldRegisterRecordTableAdapter();
                MoldStockCompanyTableAdapter dalCompany = new MoldStockCompanyTableAdapter();
                CasterMoldStockTableAdapter dalCaster = new CasterMoldStockTableAdapter();
                int stock_quantity = 0;
                if (row == -1)
                {
                    MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int i = 0; i <= row; i++)
                    {
                        m = new MoldRegisterRecord();
                        m.CasterID = Convert.ToInt32(dgvMold.Rows[i].Cells["CasterID"].Value.ToString());
                        m.ItemID = itemDAL.getItemID(dgvMold.Rows[i].Cells["Item"].Value.ToString());
                        m.Style = styleDAL.getStyleID(dgvMold.Rows[i].Cells["Style"].Value.ToString());
                        m.SizeID = sizeDAL.getSizeID(dgvMold.Rows[i].Cells["Size"].Value.ToString());
                        m.DateReceived = Convert.ToDateTime(dgvMold.Rows[i].Cells["DateReceived"].Value.ToString());
                        m.QuantityReceived = Convert.ToInt32(dgvMold.Rows[i].Cells["QuantityReceived"].Value.ToString());
                        m.QuantityIssued = Convert.ToInt32(dgvMold.Rows[i].Cells["QuantityIssued"].Value.ToString());
                        m.DateExpiry = Convert.ToDateTime(dgvMold.Rows[i].Cells["DateExpiry"].Value.ToString());
                        m.Breakage = Convert.ToInt32(dgvMold.Rows[i].Cells["Breakage"].Value.ToString());
                        m.BreakageCause = dgvMold.Rows[i].Cells["BreakageCause"].Value.ToString();
                        m.Balance = Convert.ToInt32(dgvMold.Rows[i].Cells["Balance"].Value.ToString());
                        dalReport.InsertQuery(m.ItemID, m.Style, m.SizeID, m.CasterID, m.DateReceived, m.QuantityReceived, m.QuantityIssued, m.DateExpiry, m.Breakage, m.BreakageCause, m.Balance);
                        //=====check  if company contain already record then update the record
                        if (Convert.ToInt32(dalCompany.checkIsItemExist(m.ItemID, m.Style, m.SizeID)) > 0)
                        {
                            stock_quantity = 0;
                            stock_quantity = Convert.ToInt32(dalCompany.getStockByID(m.ItemID, m.Style, m.SizeID));
                            stock_quantity = stock_quantity + m.Balance;
                            dalCompany.UpdateQuery(stock_quantity, m.ItemID, m.Style, m.SizeID);
                        }
                        else
                        {
                            dalCompany.InsertQuery(m.ItemID, m.Style, m.SizeID, m.Balance);
                        }
                        //=====check  if caster contain already record then update the record
                        if (Convert.ToInt32(dalCaster.CheckIsItemExistByItemId(m.ItemID, m.Style, m.SizeID, m.CasterID)) > 0)
                        {
                            stock_quantity = 0;
                            stock_quantity = Convert.ToInt32(dalCaster.getMouldQuantityByInfo(m.ItemID, m.Style, m.SizeID, m.CasterID)) + m.QuantityIssued;
                            dalCaster.UpdateQuery(stock_quantity, m.CasterID, m.ItemID, m.Style, m.SizeID);
                        }
                        else
                        {
                            dalCaster.InsertQuery(m.CasterID, m.ItemID, m.Style, m.SizeID, m.QuantityIssued);
                        }
                    }
                    MessageBox.Show("Report added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvMold.Rows.Clear();
                    row = -1;
                    selectedRow = -1;
                    txtQuantityReceived.Text = "";
                    txtBalance.Text = "";
                    txtQunatityIssued.Text = "";
                    txtBreakage.Text = "";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //=======================================================================================================================
        private void dgvMold_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = Convert.ToInt16(e.RowIndex);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }
        private void txtQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            txtQuantityReceived.Focus();
        }

        private void cbxSelectJob_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                JobsDAL jobDal = new JobsDAL();

                lblWorker.Text = cbxSelectJob.Text;
                //populate cbx supplier
                dsWorker.Clear();
                dsWorker = personDAL.getPersonByJobDataset(jobDal.getJobID(cbxSelectJob.Text));
                cbxWorker.DataSource = dsWorker.Tables[0];
                cbxWorker.DisplayMember = "Name";
                //end populate
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQunatityIssued_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtQunatityIssued_MouseClick(object sender, MouseEventArgs e)
        {
            txtQunatityIssued.Focus();
        }

        private void txtBreakage_MouseClick(object sender, MouseEventArgs e)
        {
            txtBreakage.Focus();
        }

        private void txtBreakage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }
        //=====================================end of function--------------------------------------------------------
    }
}
