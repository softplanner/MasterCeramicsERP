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
    public partial class frmGreenWareItemChecking : Form
    {
        //PersonDAL personDAL = new PersonDAL();
        //ItemDAL itemDAL = new ItemDAL();
        //DALItemStyle styleDAL = new DALItemStyle();
        //ItemSizeDAL sizeDAL = new ItemSizeDAL();
        //JobsDAL jobDal = new JobsDAL();
        //GreenWareHouseItemCheckReportDAL greenWareItemCheckingDAL=new GreenWareHouseItemCheckReportDAL();
        //UnGlazeStockCompanyDAL unglazeCompanyStockDAL = new UnGlazeStockCompanyDAL();

        DataSet dsJobs = new DataSet();
        DataSet dsWorker = new DataSet();
        DataSet dsJobsChecker = new DataSet();
        DataSet dsChecker = new DataSet();
        
        Int16 row = -1, selectedRow = -1,companyRow=-1,companySelectedRow=-1;
        List<int> casterID = new List<int>();
        List<int> checkerID = new List<int>();
        int lastCasterID = 0;
        List<GreenWareHouseWorkerStock> listMoldStockWorker;

        public frmGreenWareItemChecking()
        {
            InitializeComponent();
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
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void populateJobsForChecker()
        {
            try
            {
                JobsDAL jobDal = new JobsDAL();
                
                //populate cbx supplier
                dsJobsChecker.Clear();
                dsJobsChecker = jobDal.getAllJobsDataSet();
                cbxJobChecker.DataSource = dsJobsChecker.Tables[0];
                cbxJobChecker.DisplayMember = "Name";
                //end populate
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmGreenWareItemChecking_Load(object sender, EventArgs e)
        {
            populateJobsCBX();
            populateJobsForChecker();
        }
        private void loadCasterStockDGV()
        {
            
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                
                dgvStock.Rows.Clear();
                companyRow = -1;
                companySelectedRow = -1;
                GreenWareHouseWorkerStockDAL dal = new GreenWareHouseWorkerStockDAL();
                listMoldStockWorker = new List<GreenWareHouseWorkerStock>();
                listMoldStockWorker = dal.getStockByCaster(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]));
                listMoldStockWorker.TrimExcess();
                if (listMoldStockWorker.Count.Equals(0))
                {
                    MessageBox.Show("Selected caster does not contain any item in his stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (Int16 i = 0; i < listMoldStockWorker.Count; i++)
                    {
                        companyRow = Convert.ToInt16(dgvStock.Rows.Add());
                        dgvStock.Rows[companyRow].Cells[0].Value = itemDAL.getItemName(listMoldStockWorker[i].ItemID);
                        dgvStock.Rows[companyRow].Cells[1].Value = styleDAL.getItemStyleName(listMoldStockWorker[i].StyleID);
                        dgvStock.Rows[companyRow].Cells[2].Value = sizeDAL.getItemSizeName(listMoldStockWorker[i].SizeID);
                        dgvStock.Rows[companyRow].Cells[3].Value = listMoldStockWorker[i].Quantity;
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxWorker.Text.Equals(""))
                {
                    MessageBox.Show("Select caster...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbxChecker.Text.Equals(""))
                {
                    MessageBox.Show("Select checker...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (companySelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select item from caster unglaze item's stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtQuantity.Text == "")
                {
                    MessageBox.Show("Enter quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(dgvStock.Rows[companySelectedRow].Cells[3].Value) < Convert.ToInt32(txtQuantity.Text))
                {
                    MessageBox.Show("Entered quantity is greater than item's stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    addRowToDataGrid();
                    dgvStock.Rows[companySelectedRow].Cells[3].Value = Convert.ToString(Convert.ToInt32(dgvStock.Rows[companySelectedRow].Cells[3].Value.ToString()) - Convert.ToInt32(txtQuantity.Text));
                    //dgvStock.Rows[companySelectedRow].Cells[4].Value = Convert.ToString(Convert.ToInt32(dgvStock.Rows[companySelectedRow].Cells[4].Value.ToString()) - Convert.ToInt32(txtQuantity.Text));
                    companySelectedRow = -1;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addRowToDataGrid()
        {
            try
            {
                for (Int16 i = 0; i <= row; i++)
                {
                    if (checkerID[i].Equals(Convert.ToInt32(dsChecker.Tables[0].Rows[cbxChecker.SelectedIndex]["ID"])))
                    {
                        if (dgvGreenWare.Rows[i].Cells[0].Value.Equals(dgvStock.Rows[companySelectedRow].Cells[0].Value))
                        {
                            if (dgvGreenWare.Rows[i].Cells[1].Value.Equals(dgvStock.Rows[companySelectedRow].Cells[1].Value))
                            {
                                if (dgvGreenWare.Rows[i].Cells[2].Value.Equals(dgvStock.Rows[companySelectedRow].Cells[2].Value))
                                {
                                    dgvGreenWare.Rows[i].Cells[3].Value = Convert.ToString(Convert.ToInt32(dgvGreenWare.Rows[i].Cells[3].Value) + Convert.ToInt32(txtQuantity.Text));
                                    return;
                                }
                            }
                        }
                    }
                }
                //////------Show record in the data grid view------//////
                row = Convert.ToInt16(dgvGreenWare.Rows.Add());
                //MessageBox.Show(row.ToString());
                dgvGreenWare.Rows[row].Cells[0].Value = dgvStock.Rows[companySelectedRow].Cells[0].Value.ToString();
                dgvGreenWare.Rows[row].Cells[1].Value = dgvStock.Rows[companySelectedRow].Cells[1].Value.ToString();
                dgvGreenWare.Rows[row].Cells[2].Value = dgvStock.Rows[companySelectedRow].Cells[2].Value.ToString();
                dgvGreenWare.Rows[row].Cells[3].Value = txtQuantity.Text;
                ////------End show record in the data grid view------////
                casterID.Add(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]));
                checkerID.Add(Convert.ToInt32(dsChecker.Tables[0].Rows[cbxChecker.SelectedIndex]["ID"]));
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearGrids();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow == -1)
                {
                    MessageBox.Show("Select record...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    for (Int16 i = 0; i <= companyRow; i++)
                    {
                        if (dgvGreenWare.Rows[selectedRow].Cells[0].Value.Equals(dgvStock.Rows[i].Cells[0].Value))
                        {
                            if (dgvGreenWare.Rows[selectedRow].Cells[1].Value.Equals(dgvStock.Rows[i].Cells[1].Value))
                            {
                                if (dgvGreenWare.Rows[selectedRow].Cells[2].Value.Equals(dgvStock.Rows[i].Cells[2].Value))
                                {
                                    dgvStock.Rows[i].Cells[3].Value = Convert.ToString(Convert.ToInt32(dgvStock.Rows[i].Cells[3].Value) + Convert.ToInt32(dgvGreenWare.Rows[selectedRow].Cells[3].Value));
                                    //dgvStock.Rows[i].Cells[4].Value = Convert.ToString(Convert.ToInt32(dgvStock.Rows[i].Cells[4].Value) + Convert.ToInt32(dgvGreenWare.Rows[selectedRow].Cells[3].Value));
                                    break;
                                }
                            }
                        }
                    }
                    casterID.RemoveAt(Convert.ToInt32(selectedRow));
                    checkerID.RemoveAt(Convert.ToInt32(selectedRow));
                    dgvGreenWare.Rows.RemoveAt(selectedRow);
                    selectedRow = -1;
                    row--;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void updateCasterUnglazeItemStock()
        {
            try
            {
                int workerID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                GreenWareHouseWorkerStock workerStock;
                GreenWareHouseWorkerStockDAL dal = new GreenWareHouseWorkerStockDAL(); 
                //=================================update worker unglaze Stock
                for (int i = 0; i < listMoldStockWorker.Count;i++ )
                {
                    workerStock = new GreenWareHouseWorkerStock();
                    workerStock.WorkerID = workerID;
                    workerStock.ItemID = listMoldStockWorker[i].ItemID;
                    workerStock.StyleID = listMoldStockWorker[i].StyleID;
                    workerStock.SizeID = listMoldStockWorker[i].SizeID;
                    workerStock.Quantity = Convert.ToInt32(dgvStock.Rows[i].Cells[3].Value);
                    dal.updateStock(workerStock);
                }
                MessageBox.Show("Caster unglaze item's stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void saveReport()
        {
            try
            {
                if (row == -1)
                {
                    MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    GreenWareHouseItemCheckReportDAL greenWareItemCheckingDAL = new GreenWareHouseItemCheckReportDAL();
                    UnGlazeStockCompanyDAL unglazeCompanyStockDAL = new UnGlazeStockCompanyDAL();

                    GreenWareHouseItemCheckReport itemCheck;
                    UnGlazeStockCompany companyStock = new UnGlazeStockCompany();
                    //=====add report
                    for (Int16 i = 0; i <= row; i++)
                    {
                        itemCheck = new GreenWareHouseItemCheckReport();
                        //================================
                        itemCheck.WorkerID = casterID[i];
                        itemCheck.CheckerID = checkerID[i];
                        itemCheck.ItemID = itemDAL.getItemID(dgvGreenWare.Rows[i].Cells[0].Value.ToString());
                        itemCheck.StyleID = styleDAL.getStyleID(dgvGreenWare.Rows[i].Cells[1].Value.ToString());
                        itemCheck.SizeID = sizeDAL.getSizeID(dgvGreenWare.Rows[i].Cells[2].Value.ToString());
                        itemCheck.Quantity = Convert.ToInt32(dgvGreenWare.Rows[i].Cells[3].Value);
                        itemCheck.Date = DateTime.Now;
                        //=====Add to daily report
                        if (greenWareItemCheckingDAL.checkIsReportExist(itemCheck).Equals(true))
                        {
                            itemCheck.Quantity = itemCheck.Quantity + greenWareItemCheckingDAL.getCurrentStock(itemCheck);
                            greenWareItemCheckingDAL.updateReport(itemCheck);
                        }
                        else
                        {
                            greenWareItemCheckingDAL.addReport(itemCheck);
                        }
                        //=================================add to the company Unglaze Stock
                        if (unglazeCompanyStockDAL.checkIsItemExist(itemCheck.ItemID, itemCheck.StyleID, itemCheck.SizeID).Equals(1))
                        {
                            //====means that company contain information about that item
                            int quantityInStock = unglazeCompanyStockDAL.getStockByItemStyleSize(itemCheck.ItemID, itemCheck.StyleID, itemCheck.SizeID);
                            companyStock.ItemID = itemCheck.ItemID;
                            companyStock.StyleID = itemCheck.StyleID;
                            companyStock.SizeID = itemCheck.SizeID;
                            companyStock.Quantity = quantityInStock + Convert.ToInt32(dgvGreenWare.Rows[i].Cells[3].Value);
                            unglazeCompanyStockDAL.updateStock(companyStock);
                        }
                        else
                        {
                            //====means that company not contain information about that item
                            companyStock.ItemID = itemCheck.ItemID;
                            companyStock.StyleID = itemCheck.StyleID;
                            companyStock.SizeID = itemCheck.SizeID;
                            companyStock.Quantity = Convert.ToInt32(dgvGreenWare.Rows[i].Cells[3].Value);
                            unglazeCompanyStockDAL.addStock(companyStock);
                        }
                        //=================================end add to compnay stock
                    }
                    MessageBox.Show("Report has been added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Company unglaze stock has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //================================ update worker stock from worker stock
                    //for end
                    txtQuantity.Text = "";
                    dgvGreenWare.Rows.Clear();
                    row = -1;
                    selectedRow = -1;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddDB_Click(object sender, EventArgs e)
        {
            updateCasterUnglazeItemStock();
            saveReport();
        }
        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            companySelectedRow = Convert.ToInt16(e.RowIndex);
        }

        private void dgvGreenWare_CellClick(object sender, DataGridViewCellEventArgs e)
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
            txtQuantity.Focus();
        }

        private void cbxSelectJob_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (row >= 0)
                {
                    clearGrids();
                }
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

        private void cbxWorker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (row >= 0)
            {
                clearGrids();
            }
            loadCasterStockDGV();
            lastCasterID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
        }

        private void cbxJobChecker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (row >= 0)
                {
                    clearGrids();
                }
                PersonDAL personDAL = new PersonDAL();
                JobsDAL jobDal = new JobsDAL();
                
                lblChecker.Text = cbxJobChecker.Text;
                //populate cbx supplier
                dsChecker.Clear();
                dsChecker = personDAL.getPersonByJobDataset(jobDal.getJobID(cbxJobChecker.Text));
                cbxChecker.DataSource = dsChecker.Tables[0];
                cbxChecker.DisplayMember = "Name";
                //end populate

            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearGrids()
        {
            dgvGreenWare.Rows.Clear();
            dgvStock.Rows.Clear();
            row = -1;
            selectedRow = -1;
            companyRow=-1;
            companySelectedRow=-1;
            casterID.Clear();
            checkerID.Clear();
            txtQuantity.Text = "";
        }

        private void cbxChecker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (row >= 0)
            {
                clearGrids();
            }
        }
        //=======================================================================================================================
    }
}
