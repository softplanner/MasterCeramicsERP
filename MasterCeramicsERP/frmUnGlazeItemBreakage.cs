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
    public partial class frmUnGlazeItemBreakage : Form
    {
        List<MoldStockWorker> stockList;
        DataSet dsRemarks = new DataSet();
        DataSet dsJobs = new DataSet();
        DataSet dsWorker = new DataSet();

        //PersonDAL personDAL = new PersonDAL();
        //ItemDAL itemDAL = new ItemDAL();
        //DALItemStyle styleDAL = new DALItemStyle();
        //ItemSizeDAL sizeDAL = new ItemSizeDAL();
        //RemarksDAL remarksDAL = new RemarksDAL();
        //MoldStockWorkerDAL moldStockWorkerDAL = new MoldStockWorkerDAL();
        //PersonJobsDAL personJobsDAL = new PersonJobsDAL();
        //JobsDAL jobDal = new JobsDAL();

        int row = -1, selectedRow = -1,stockRow=-1,stockSelectedRow=-1;

        public frmUnGlazeItemBreakage()
        {
            InitializeComponent();
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
        private void populateDGVWorkerStock()
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                
                stockRow = -1;
                stockSelectedRow = -1;
                dgvStock.Rows.Clear();
                for (Int16 i = 0; i < stockList.Count; i++)
                {
                    stockRow = dgvStock.Rows.Add();
                    dgvStock.Rows[stockRow].Cells[0].Value = itemDAL.getItemName(stockList[i].ItemID);
                    dgvStock.Rows[stockRow].Cells[1].Value = styleDAL.getItemStyleName(stockList[i].StyleID);
                    dgvStock.Rows[stockRow].Cells[2].Value = sizeDAL.getItemSizeName(stockList[i].SizeID);
                    dgvStock.Rows[stockRow].Cells[3].Value = stockList[i].CastQuantity;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void frmUnGlazeItemBreakage_Load(object sender, EventArgs e)
        {
            populateJobsCBX();
            populateRemarksCBX();
            txtRemarks.Enabled = false;
        }
        private void populateRemarksCBX()
        {
            try
            {
                RemarksDAL remarksDAL = new RemarksDAL();
                
                dsRemarks.Clear();
                dsRemarks = remarksDAL.getRemarks();
                cbxRemarks.DataSource = dsRemarks.Tables[0];
                cbxRemarks.DisplayMember = "Remark";
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvWorker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stockSelectedRow = e.RowIndex;
        }

        private void dgvReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        
        private void populateCasterStock() 
        {
            try
            {
                MoldStockWorkerDAL moldStockWorkerDAL = new MoldStockWorkerDAL();
                
                dgvReport.Rows.Clear();
                row = -1;
                selectedRow = -1;

                stockList = new List<MoldStockWorker>();
                stockList = moldStockWorkerDAL.getCastStockByWorker(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]));
                stockList.TrimExcess();
                if (stockList.Count.Equals(0))
                {
                    MessageBox.Show("No stock found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    populateDGVWorkerStock();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void chkbxRemarks_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbxRemarks.Checked.Equals(true))
            {
                txtRemarks.Enabled = true;
                lblRemark.Enabled = false;
                dsRemarks.Clear();
                txtRemarks.Enabled = true;
            }
            else if (chkbxRemarks.Checked.Equals(false))
            {
                lblRemark.Enabled = true;
                populateRemarksCBX();
                txtRemarks.Text="";
                txtRemarks.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (stockSelectedRow.Equals(-1))
            {
                MessageBox.Show("Select item from stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtQuantity.Text == "")
            {
                MessageBox.Show("Enter some quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cbxBreakageType.Text.Equals(""))
            {
                MessageBox.Show("Select breakage type...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(Convert.ToInt32(txtQuantity.Text)) > Convert.ToInt32(dgvStock.Rows[stockSelectedRow].Cells[3].Value))
            {
                MessageBox.Show("Entered quantity is greater than available stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addRowToDataGrid();
                deductQuantityFromStock();
                stockSelectedRow = -1;
                txtQuantity.Text = "";
            }
        }
        //======deduct quantity from stock
        private void deductQuantityFromStock()
        {
            try
            {
                dgvStock.Rows[stockSelectedRow].Cells[3].Value = Convert.ToString(Convert.ToInt32(dgvStock.Rows[stockSelectedRow].Cells[3].Value.ToString()) - Convert.ToInt32(txtQuantity.Text));
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //======
        //====================================================================================================================================    
        private void addRowToDataGrid()
        {
            PersonDAL personDAL = new PersonDAL();
           
            for (Int16 i = 0; i <= row; i++)
            {

                if (personDAL.getPersonName(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"])).Equals(dgvReport.Rows[i].Cells[0].Value.ToString()))
                {
                    if (dgvReport.Rows[i].Cells[1].Value.ToString().Equals(dgvStock.Rows[stockSelectedRow].Cells[0].Value.ToString()))
                    {
                        if (dgvStock.Rows[stockSelectedRow].Cells[1].Value.Equals(dgvReport.Rows[i].Cells[2].Value))
                        {
                            if (dgvStock.Rows[stockSelectedRow].Cells[2].Value.Equals(dgvReport.Rows[i].Cells[3].Value))
                            {
                                dgvReport.Rows[i].Cells[5].Value = Convert.ToString(Convert.ToInt32(dgvReport.Rows[i].Cells[5].Value.ToString()) + Convert.ToInt32(txtQuantity.Text));
                                return;
                            }
                        }
                    }
                }
            }
            //////------Show record in the data grid view------//////
            row = dgvReport.Rows.Add();
            dgvReport.Rows[row].Cells[0].Value = personDAL.getPersonName(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]));
            dgvReport.Rows[row].Cells[1].Value = dgvStock.Rows[stockSelectedRow].Cells[0].Value;
            dgvReport.Rows[row].Cells[2].Value = dgvStock.Rows[stockSelectedRow].Cells[1].Value;
            dgvReport.Rows[row].Cells[3].Value = dgvStock.Rows[stockSelectedRow].Cells[2].Value;
            dgvReport.Rows[row].Cells[4].Value = cbxBreakageType.Text;
            dgvReport.Rows[row].Cells[5].Value = txtQuantity.Text;
            if (chkbxRemarks.Checked.Equals(true))
            {
                dgvReport.Rows[row].Cells[6].Value = txtRemarks.Text;
            }
            else
            {
                dgvReport.Rows[row].Cells[6].Value = cbxRemarks.Text;
            }

            ////------End show record in the data grid view------////
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (row == -1)
                {
                    MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select record...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (Int16 i = 0; i <= stockRow; i++)
                    {
                        MessageBox.Show(stockRow.ToString());
                        if (dgvReport.Rows[selectedRow].Cells[1].Value.Equals(dgvStock.Rows[i].Cells[0].Value))
                        {
                            if (dgvReport.Rows[selectedRow].Cells[2].Value.Equals(dgvStock.Rows[i].Cells[1].Value))
                            {
                                if (dgvReport.Rows[selectedRow].Cells[3].Value.Equals(dgvStock.Rows[i].Cells[2].Value))
                                {
                                    dgvStock.Rows[i].Cells[3].Value = Convert.ToString(Convert.ToInt32(dgvStock.Rows[i].Cells[3].Value.ToString()) + Convert.ToInt32(dgvReport.Rows[selectedRow].Cells[5].Value.ToString()));
                                    dgvReport.Rows.RemoveAt(selectedRow);
                                    selectedRow = -1;
                                    row--;
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddDB_Click(object sender, EventArgs e)
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
                    MoldStockWorkerDAL moldStockWorkerDAL = new MoldStockWorkerDAL();
                    /////////////////////////////////////////////////////////////////////////
                    GreenWareHouseBreakageDAL breakageDAL = new GreenWareHouseBreakageDAL();
                    SlipStockDAL slipDAL = new SlipStockDAL();
                    ItemWeightDAL wdal = new ItemWeightDAL();
                    float slipInStock=slipDAL.getSlipInStock();

                    for (Int16 i = 0; i <= row; i++)
                    {
                        //=====update worker mold stock
                        MoldStockWorker w = new MoldStockWorker();
                        w.WorkerID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                        w.ItemID = itemDAL.getItemID(dgvReport.Rows[i].Cells[1].Value.ToString());
                        w.StyleID = styleDAL.getStyleID(dgvReport.Rows[i].Cells[2].Value.ToString());
                        w.SizeID = sizeDAL.getSizeID(dgvReport.Rows[i].Cells[3].Value.ToString());
                        w.CastQuantity = Convert.ToInt16(moldStockWorkerDAL.getCastedStock(w) - Convert.ToInt16(dgvReport.Rows[i].Cells[5].Value.ToString()));
                        w.Quantity = Convert.ToInt16(moldStockWorkerDAL.getFreeStock(w) + Convert.ToInt16(dgvReport.Rows[i].Cells[5].Value.ToString()));
                        moldStockWorkerDAL.updateStockByCasting(w);
                        //=====end
                        //-----manage slip
                        slipInStock = wdal.getItemWeight(w.ItemID, w.StyleID, w.SizeID) + slipInStock ;
                        //---end 
                        //=====add report
                        GreenWareHouseBreakage g = new GreenWareHouseBreakage();
                        g.WorkerID = w.WorkerID;
                        g.ItemID = w.ItemID;
                        g.StyleID = w.StyleID;
                        g.SizeID = w.SizeID;
                        g.BreakageType = dgvReport.Rows[i].Cells[4].Value.ToString();
                        g.Quantity = Convert.ToInt16(dgvReport.Rows[i].Cells[5].Value.ToString());
                        g.Remarks = dgvReport.Rows[i].Cells[6].Value.ToString();
                        g.Date = DateTime.Now;
                        breakageDAL.addReport(g);
                        //=====end
                    }
                    slipDAL.updateSlipStock(slipInStock);
                    MessageBox.Show("Slip stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Worker mold stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvReport.Rows.Clear();
                    row = -1;
                    selectedRow = -1;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void txtRemarks_MouseClick(object sender, MouseEventArgs e)
        {
            txtRemarks.Focus();
        }

        private void cbxWorker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            populateCasterStock();
        }
        //===============================================================================================================
    }
}
