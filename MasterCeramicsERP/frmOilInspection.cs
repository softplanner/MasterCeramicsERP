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
    public partial class frmOilInspection : Form
    {
        DataSet dsRemarks = new DataSet();
        List<MoldStockWorker> lstCasterMoldStock;
        int companyRow = -1, companySelectedRow = -1, row = -1, selectedRow = -1;
        DataSet dsJobs = new DataSet();
        DataSet dsWorker = new DataSet();
        DataSet dsJobsChecker = new DataSet();
        DataSet dsChecker = new DataSet();

        //PersonDAL personDAL = new PersonDAL();
        //JobsDAL jobsDal = new JobsDAL();
        //ItemDAL itemDAL = new ItemDAL();
        //DALItemStyle styleDAL = new DALItemStyle();
        //ItemSizeDAL sizeDAL = new ItemSizeDAL();
        //RemarksDAL remarksDAL = new RemarksDAL();
        //MoldStockWorkerDAL workerDAL = new MoldStockWorkerDAL();
        //OilInspectionReportDAL oilDAL = new OilInspectionReportDAL();
        

        public frmOilInspection()
        {
            InitializeComponent();
        }

        private void populateRemarksDatasets()
        {
            try
            {
                RemarksDAL remarksDAL = new RemarksDAL();
                
                //populate Remarks cbx
                dsRemarks.Clear();
                dsRemarks = remarksDAL.getRemarks();
                cbxRemarks.DataSource = dsRemarks.Tables[0];
                cbxRemarks.DisplayMember = "Remark";
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
                JobsDAL jobsDal = new JobsDAL();
                
                //populate cbx supplier
                dsJobs.Clear();
                dsJobs = jobsDal.getAllJobsDataSet();
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
                JobsDAL jobsDal = new JobsDAL();
                
                //populate cbx supplier
                dsJobsChecker.Clear();
                dsJobsChecker = jobsDal.getAllJobsDataSet();
                cbxJobChecker.DataSource = dsJobsChecker.Tables[0];
                cbxJobChecker.DisplayMember = "Name";
                //end populate
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmOilInspection_Load(object sender, EventArgs e)
        {
            try
            {
                populateJobsCBX();
                populateJobsForChecker();

                //datasetCasterPopulate();
                //datasetCheckerPopulate();
                lblRemarks.Enabled = false;
                txtRemarks.Enabled = false;
                populateRemarksDatasets();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void callShow()
        {
            try
            {
                MoldStockWorkerDAL workerDAL = new MoldStockWorkerDAL();
                
                lstCasterMoldStock = new List<MoldStockWorker>();
                lstCasterMoldStock = workerDAL.getStockByWorker(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]));
                companyRow = -1;
                if (lstCasterMoldStock.Count.Equals(0))
                {
                    MessageBox.Show("No casted item's found...","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    loadDGVCasterStock();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         private void loadDGVCasterStock()
        {
            ItemDAL itemDAL = new ItemDAL();
            DALItemStyle styleDAL = new DALItemStyle();
            ItemSizeDAL sizeDAL = new ItemSizeDAL();

            dgvCaster.Rows.Clear();
            companyRow = -1;
            companySelectedRow = -1;
            lstCasterMoldStock.TrimExcess();

            for (Int16 i = 0; i < lstCasterMoldStock.Count; i++)
            {
                companyRow = dgvCaster.Rows.Add();
                dgvCaster.Rows[i].Cells[0].Value = itemDAL.getItemName(lstCasterMoldStock[i].ItemID);
                dgvCaster.Rows[i].Cells[1].Value = styleDAL.getItemStyleName(lstCasterMoldStock[i].StyleID);
                dgvCaster.Rows[i].Cells[2].Value = sizeDAL.getItemSizeName(lstCasterMoldStock[i].SizeID);
                dgvCaster.Rows[i].Cells[3].Value = lstCasterMoldStock[i].CastQuantity.ToString();
            }
        }

       private void emptyDGVReport()
        {
            dgvReport.Rows.Clear();
            row = -1;
            selectedRow = -1;
        }
        private void emptyDGVCasterStock()
        {
            dgvCaster.Rows.Clear();
            companyRow = -1;
            companySelectedRow = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(companySelectedRow.Equals(-1))
            {
                MessageBox.Show("Select some item's from casting stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtSelectedQuantity.Text.Equals(""))
            {
                MessageBox.Show("Enter selected item's quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtRejectedItems.Text.Equals(""))
            {
                MessageBox.Show("Enter rejected item's quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if((Convert.ToInt16(txtSelectedQuantity.Text) + Convert.ToInt16(txtRejectedItems.Text)) >Convert.ToInt16(dgvCaster.Rows[companySelectedRow].Cells[3].Value.ToString()))
            {
                MessageBox.Show("Entered qyantity is greater than available stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                addRowToDataGrid();
                dgvCaster.Rows[companySelectedRow].Cells[3].Value = Convert.ToString(Convert.ToInt32(dgvCaster.Rows[companySelectedRow].Cells[3].Value.ToString()) - (Convert.ToInt32(txtSelectedQuantity.Text) + Convert.ToInt32(txtRejectedItems.Text)));
                selectedRow = -1;
                companySelectedRow = -1;
                txtSelectedQuantity.Text = "";
                txtRejectedItems.Text = "";
                txtRemarks.Text = "";
            }
        }
        //====================================================================================================================================    
        private void addRowToDataGrid()
        {
            for (Int16 i = 0; i <= row; i++)
            {
                //if (dsChecker.Tables[0].Rows[cbxChecker.SelectedIndex]["ID"].Equals(oilInspectorID[i]))
                //{
                //    if (dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"].Equals(casterID[i]))
                //    {
                if (dgvCaster.Rows[companySelectedRow].Cells[0].Value.Equals(dgvReport.Rows[i].Cells[0].Value))
                {
                    if (dgvCaster.Rows[companySelectedRow].Cells[1].Value.Equals(dgvReport.Rows[i].Cells[1].Value))
                    {
                        if (dgvCaster.Rows[companySelectedRow].Cells[2].Value.Equals(dgvReport.Rows[i].Cells[2].Value))
                        {
                            dgvReport.Rows[i].Cells[3].Value = Convert.ToString(Convert.ToInt32(dgvReport.Rows[i].Cells[3].Value.ToString()) + Convert.ToInt32(txtSelectedQuantity.Text));
                            dgvReport.Rows[i].Cells[4].Value = Convert.ToString(Convert.ToInt32(dgvReport.Rows[i].Cells[4].Value.ToString()) + Convert.ToInt32(txtRejectedItems.Text));
                            return;
                        }
                    }
                }
                //    }
                //}
            }
            //////------Show record in the data grid view------//////
            row = dgvReport.Rows.Add();
            //MessageBox.Show(row.ToString());
            //dgvReport.Rows[row].Cells[0].Value = dsChecker.Tables[0].Rows[cbxChecker.SelectedIndex]["ID"].ToString();
            //dgvReport.Rows[row].Cells[1].Value = dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"].ToString();
            dgvReport.Rows[row].Cells[0].Value = dgvCaster.Rows[companySelectedRow].Cells[0].Value;
            dgvReport.Rows[row].Cells[1].Value = dgvCaster.Rows[companySelectedRow].Cells[1].Value;
            dgvReport.Rows[row].Cells[2].Value = dgvCaster.Rows[companySelectedRow].Cells[2].Value;
            dgvReport.Rows[row].Cells[3].Value = txtSelectedQuantity.Text;
            dgvReport.Rows[row].Cells[4].Value = txtRejectedItems.Text;
            //dgvReport.Rows[row].Cells[8].Value = DateTime.Today.ToString();
            if (chkbxAddRemarks.Checked.Equals(true))
            {
                dgvReport.Rows[row].Cells[5].Value = txtRemarks.Text;
                txtRemarks.Text = "";
            }
            else 
            {
                dgvReport.Rows[row].Cells[5].Value = cbxRemarks.Text;
            }
            //casterID.Add(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]));
            //oilInspectorID.Add(Convert.ToInt32(dsChecker.Tables[0].Rows[cbxChecker.SelectedIndex]["ID"]));
            ////------End show record in the data grid view------////
        }

        private void dgvCaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            companySelectedRow = e.RowIndex;
            if (companySelectedRow != -1)
            {
                txtSelectedQuantity.Text = dgvCaster.Rows[companySelectedRow].Cells[3].Value.ToString();
                txtRejectedItems.Text = "0";
            }
        }

        private void chkbxAddRemarks_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxAddRemarks.Checked.Equals(true))
            {
                lblSelectRemarks.Enabled = false;
                lblRemarks.Enabled = true;
                cbxRemarks.Enabled = false;
                txtRemarks.Enabled = true;
            }
            else
            {
                lblSelectRemarks.Enabled = true;
                lblRemarks.Enabled = false;
                txtRemarks.Text = "";
                txtRemarks.Enabled = false;
                cbxRemarks.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRow == -1)
            {
                MessageBox.Show("Select record...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                returnToCasterStock();
            }
        }
        //===========================================================================================================
        private void returnToCasterStock()
        {
            for (Int16 i = 0; i <= companyRow; i++)
            {
                //if (dsChecker.Tables[0].Rows[cbxChecker.SelectedIndex]["ID"].Equals(dgvReport.Rows[selectedRow].Cells[0].Value.ToString()))
                //{
                //if (dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"].Equals(dgvReport.Rows[selectedRow].Cells[1].Value.ToString()))
                //{
                if (dgvCaster.Rows[i].Cells[0].Value.Equals(dgvReport.Rows[selectedRow].Cells[0].Value))
                {
                    if (dgvCaster.Rows[i].Cells[1].Value.Equals(dgvReport.Rows[selectedRow].Cells[1].Value))
                    {
                        if (dgvCaster.Rows[i].Cells[2].Value.Equals(dgvReport.Rows[selectedRow].Cells[2].Value))
                        {
                            dgvCaster.Rows[i].Cells[3].Value = Convert.ToString((Convert.ToInt32(dgvCaster.Rows[i].Cells[3].Value.ToString()) + Convert.ToInt32(dgvReport.Rows[selectedRow].Cells[3].Value.ToString())) + Convert.ToInt32(dgvReport.Rows[selectedRow].Cells[4].Value.ToString()));
                            dgvReport.Rows.RemoveAt(selectedRow);
                            row--;
                            selectedRow = -1;
                            companySelectedRow = -1;
                            txtSelectedQuantity.Text = "";
                            txtRejectedItems.Text = "";
                            txtRemarks.Text = "";
                            break;
                        }
                    }
                }
                //}
                //}
            }
        }

         private void dgvReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //casterID = new List<int>();
            //oilInspectorID = new List<int>();
            populateRemarksDatasets();
            emptyDGVReport();
            emptyDGVCasterStock();
            txtSelectedQuantity.Text = "";
            txtRejectedItems.Text = "";
            txtRemarks.Text = "";
            chkbxAddRemarks.Checked = false;
            txtRemarks.Enabled = false;
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
                    MoldStockWorkerDAL workerDAL = new MoldStockWorkerDAL();
                    OilInspectionReportDAL oilDAL = new OilInspectionReportDAL();

                    GreenWareHouseWorkerStock workerUnglazeStock;
                    GreenWareHouseWorkerStockDAL workerUnglazeStockDal=new GreenWareHouseWorkerStockDAL();
                    OilInspectionReport o;
                    MoldStockWorker m;
                    for (Int16 i = 0; i <= row; i++)
                    {
                        //=====update add oil inspection report
                        o = new OilInspectionReport();
                        o.CheckerID = Convert.ToInt32(dsChecker.Tables[0].Rows[cbxChecker.SelectedIndex]["ID"]);
                        o.WorkerID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                        o.ItemID = itemDAL.getItemID(dgvReport.Rows[i].Cells[0].Value.ToString());
                        o.StyleID = styleDAL.getStyleID(dgvReport.Rows[i].Cells[1].Value.ToString());
                        o.SizeID = sizeDAL.getSizeID(dgvReport.Rows[i].Cells[2].Value.ToString());
                        o.CheckedQuantity = Convert.ToInt16(dgvReport.Rows[i].Cells[3].Value.ToString());
                        o.RejectQuantity = Convert.ToInt16(dgvReport.Rows[i].Cells[4].Value.ToString());
                        o.Remarks = dgvReport.Rows[i].Cells[5].Value.ToString();
                        o.Date = DateTime.Now;
                        if(oilDAL.checkIsreportExist(o).Equals(true))
                        {
                            o.CheckedQuantity = Convert.ToInt16(o.CheckedQuantity + oilDAL.getCurrentCheckedQuantity(o));
                            o.RejectQuantity = Convert.ToInt16(o.RejectQuantity + oilDAL.getCurrentRejectQuantity(o));
                            oilDAL.updateReport(o);
                        }
                        else
                        {
                            oilDAL.addReport(o);
                        }
                        //=====end
                        //=====update the mold stock worker
                        m = new MoldStockWorker();
                        m.WorkerID = o.WorkerID;
                        m.ItemID = o.ItemID;
                        m.StyleID = o.StyleID;
                        m.SizeID = o.SizeID;
                        m.Quantity = Convert.ToInt16((workerDAL.getFreeStock(m) + o.CheckedQuantity) + o.RejectQuantity);
                        m.CastQuantity = Convert.ToInt16(workerDAL.getCastedStock(m) - (o.CheckedQuantity + o.RejectQuantity));
                        workerDAL.updateStockByCasting(m);
                        //=====end
                        //-----update caster unglaze stock
                        workerUnglazeStock = new GreenWareHouseWorkerStock();
                        workerUnglazeStock.WorkerID = m.WorkerID;
                        workerUnglazeStock.ItemID = m.ItemID;
                        workerUnglazeStock.StyleID = m.StyleID;
                        workerUnglazeStock.SizeID = m.SizeID;
                        if (workerUnglazeStockDal.checkIsRecordExist(workerUnglazeStock).Equals(true))
                        {
                            int q = workerUnglazeStockDal.getStock(workerUnglazeStock);
                            workerUnglazeStock.Quantity = q + o.CheckedQuantity + o.RejectQuantity;
                            workerUnglazeStockDal.updateStock(workerUnglazeStock);
                        }
                        else
                        {
                            workerUnglazeStock.Quantity = o.CheckedQuantity + o.RejectQuantity;
                            workerUnglazeStockDal.addStock(workerUnglazeStock);
                        }
                        //==========end
                    }
                    MessageBox.Show("Caster unglaze item's stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Caster mold stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Report has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selectedRow = -1;
                    row = -1;
                    dgvReport.Rows.Clear();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void emptyTextBoxes()
        {
            txtRejectedItems.Text = "";
            txtRemarks.Text = "";
            txtSelectedQuantity.Text = "";
        }
        //private void datasetCasterPopulate()
        //{
        //    try
        //    {
        //        dsWorker.Clear();
        //        dsWorker = personDAL.getPersonByJobDataset(jobsDal.getJobID(cbxWorker.Text));
        //        cbxWorker.DataSource = dsWorker.Tables[0];
        //        cbxWorker.DisplayMember = "Name";
        //    }
        //    catch (Exception exp)
        //    {
        //        MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //private void datasetCheckerPopulate()
        //{
        //    try
        //    {
        //        dsChecker.Clear();
        //        dsChecker = personDAL.getPersonByJobDataset(jobsDal.getJobID(cbxChecker.Text));
        //        cbxChecker.DataSource = dsChecker.Tables[0];
        //        cbxChecker.DisplayMember = "Name";
        //    }
        //    catch (Exception exp)
        //    {
        //        MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void txtSelectedQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtRejectedItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtSelectedQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            txtSelectedQuantity.Focus();
        }

        private void txtRejectedItems_MouseClick(object sender, MouseEventArgs e)
        {
            txtRejectedItems.Focus();
        }

        private void txtRemarks_MouseClick(object sender, MouseEventArgs e)
        {
            txtRemarks.Focus();
        }

        private void cbxSelectJob_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                JobsDAL jobsDal = new JobsDAL();
                
                //if (updateCounter > 0)
                //{
                //    updateCasterMoldStock();
                //    dgvStock.Rows.Clear();
                //    companyRow = companySelectedRow = -1;
                //    updateCounter = 0;
                //}
                lblWorker.Text = cbxSelectJob.Text;
                //populate cbx supplier
                dsWorker.Clear();
                dsWorker = personDAL.getPersonByJobDataset(jobsDal.getJobID(cbxSelectJob.Text));
                cbxWorker.DataSource = dsWorker.Tables[0];
                cbxWorker.DisplayMember = "Name";
                //end populate
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxJobChecker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                JobsDAL jobsDal = new JobsDAL();
                
                lblChecker.Text = cbxJobChecker.Text;
                //populate cbx supplier
                dsChecker.Clear();
                dsChecker = personDAL.getPersonByJobDataset(jobsDal.getJobID(cbxJobChecker.Text));
                cbxChecker.DataSource = dsChecker.Tables[0];
                cbxChecker.DisplayMember = "Name";
                //end populate

            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxWorker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            emptyDGVCasterStock();
            emptyDGVReport();
            callShow();
        }

        private void cbxChecker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            emptyDGVReport();
            emptyDGVCasterStock();
        }

  
        //=================================================================================================================
    }
}
