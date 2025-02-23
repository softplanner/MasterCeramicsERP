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
    public partial class frmGreenWareMoldCastingShow : Form
    {
        Int16 selectedRow = -1;
        DataSet dsJobs = new DataSet();
        DataSet dsWorker = new DataSet();
        //DataTable dtEmpty = new DataTable();
        public frmGreenWareMoldCastingShow()
        {
            InitializeComponent();
        }
        //=======================================================================
        private void frmGreenWareMoldCastingShow_Load(object sender, EventArgs e)
        {
            try
            {
                populateJobsCBX();
                //dtEmpty = (DataTable)dgvMold.DataSource;
                //dgvMold.Columns[0].Visible = false;
                //dgvMold.Columns[1].Visible = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //==========================================================================
        private void emptyTextBoxes()
        {
            
        }
        //========================================================================================================
        private void dgvMold_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = Convert.ToInt16(e.RowIndex);
        }
        //========================================================================================================
        private int getSlip()
        {
            SlipStockDAL slipStockDAL = new SlipStockDAL();

            int slip =Convert.ToInt32(slipStockDAL.getSlipInStock());
            return slip;
            //float w = itemWeightDAL.getItemWeight(itemDAL.getItemID(dgvMold.Rows[selectedRow].Cells[1].Value.ToString()), styleDAL.getStyleID(dgvMold.Rows[selectedRow].Cells[2].Value.ToString()), sizeDAL.getSizeID(dgvMold.Rows[selectedRow].Cells[3].Value.ToString()));
           // txtSlip.Text = Convert.ToString(Convert.ToInt32(txtSlip.Text) - ((Convert.ToInt32(w)) * Convert.ToInt32(txtCastQuantity.Text)));
        }
        //========================================================================================================
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                dsDB.DailyReportGreenwareDataTable dt = new dsDB.DailyReportGreenwareDataTable();
                DailyReportGreenwareTableAdapter dal = new DailyReportGreenwareTableAdapter();
                BindingSource bs = new BindingSource();

                if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false))
                {
                    MessageBox.Show("Please select some critaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //===============================
                else
                {
                    selectedRow = -1;
                    
                    if (rbtnDay.Checked.Equals(true))
                    {
                        if (chkbxShowByCaster.Checked.Equals(true))
                        {
                            int casterId = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                            dt = dal.getCastingReportByCasterDaily(dtpGlazeHouse.Value.Day, dtpGlazeHouse.Value.Month, dtpGlazeHouse.Value.Year, casterId);
                        }
                        else
                        {
                            dt = dal.getCastingReportsByDay(dtpGlazeHouse.Value.Day, dtpGlazeHouse.Value.Month, dtpGlazeHouse.Value.Year);
                        }
                        if (dt.Rows.Count.Equals(0))
                        {
                            selectedRow = -1;
                            //dgvMold.DataSource = dtEmpty;
                            MessageBox.Show("No record found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dgvMold.DataSource = dt;
                            dgvMold.Columns["Status"].Visible = false;
                            dgvMold.Columns["Date"].Visible = false;
                        }
                    }
                    else if (rbtnMonth.Checked.Equals(true))
                    {
                        if (chkbxShowByCaster.Checked.Equals(true))
                        {
                            int casterId = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                            dt = dal.getCastingReportByCasterMonthly(dtpGlazeHouse.Value.Month, dtpGlazeHouse.Value.Year, casterId);
                        }
                        else
                        {
                            dt = dal.getCastingReportsByMonth(dtpGlazeHouse.Value.Month, dtpGlazeHouse.Value.Year);
                        }
                        if (dt.Rows.Count.Equals(0))
                        {
                            selectedRow = -1;
                            //dgvMold.DataSource = dtEmpty;
                            MessageBox.Show("No record found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dgvMold.DataSource = dt;
                            dgvMold.Columns["Status"].Visible = false;
                            dgvMold.Columns["Date"].Visible = true;
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //========================================================================================================
        //==================================================================================
        private void loadDataGrid()
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                
                //id = new List<int>();
                //selectedRow = -1;
                //for (Int16 i = 0; i < list.Count; i++)
                //{
                //    dgvMold.Rows.Add();
                //    id.Add(list[i].WorkerID);
                //    dgvMold.Rows[i].Cells[0].Value = personDAL.getPersonName(list[i].WorkerID);
                //    dgvMold.Rows[i].Cells[1].Value = itemDAL.getItemName(list[i].ItemID);
                //    dgvMold.Rows[i].Cells[2].Value = styleDAL.getItemStyleName(list[i].StyleID);
                //    dgvMold.Rows[i].Cells[3].Value = sizeDAL.getItemSizeName(list[i].SizeID);
                //    dgvMold.Rows[i].Cells[4].Value = list[i].Quantity;
                //    dgvMold.Rows[i].Cells[5].Value = list[i].Date.ToString();
                //}
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void updateSlip()
        {

            try
            {
                //ItemDAL itemDAL = new ItemDAL();
                //DALItemStyle styleDAL = new DALItemStyle();
                //ItemSizeDAL sizeDAL = new ItemSizeDAL();
                //ItemWeightDAL itemWeightDAL = new ItemWeightDAL();
                
                ////=====update the slip
                //int weight = Convert.ToInt32(itemWeightDAL.getItemWeight(itemDAL.getItemID(txtItem.Text), styleDAL.getStyleID(txtStyle.Text), sizeDAL.getSizeID(txtSize.Text)));
                //int previousWeight = weight * Convert.ToInt32(txtQuantity.Text);
                //int newWeight = weight * Convert.ToInt32(txtUpdateQuantity.Text);
                //int netWeight = (Convert.ToInt32(txtSlip.Text) + previousWeight) - newWeight;
                //txtSlip.Text = Convert.ToString(netWeight);
                ////=====end
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void updateMoldStockCaster()
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                MoldStockWorkerDAL moldStockWorkerDAL = new MoldStockWorkerDAL();
                
                MoldStockWorker m = new MoldStockWorker();

                //m.ItemID = itemDAL.getItemID(txtItem.Text);
                //m.StyleID = styleDAL.getStyleID(txtStyle.Text);
                //m.SizeID = sizeDAL.getSizeID(txtSize.Text);
                //m.WorkerID = id[selectedRow];
                //m.Quantity = Convert.ToInt16((moldStockWorkerDAL.getFreeStock(m) + Convert.ToInt16(txtQuantity.Text)) - Convert.ToInt16(txtUpdateQuantity.Text));
                //m.CastQuantity = Convert.ToInt16((moldStockWorkerDAL.getCastedStock(m) - Convert.ToInt16(txtQuantity.Text)) + Convert.ToInt16(txtUpdateQuantity.Text));
                //moldStockWorkerDAL.updateStock(m);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select Record...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (MessageBox.Show("Are you sure you want to delete this record ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(chkbxShowByCaster.Checked.Equals(true))
                    {
                        //-----return respective slip to stock
                        addSlipToStock();
                        //-----update report status as 0 pretend to delete...
                    }
                    DailyReportGreenwareTableAdapter dal = new DailyReportGreenwareTableAdapter();
                    int casterID = 0,ItemID = 0,StyleID = 0,SizeID = 0;
                    DateTime d;
                    casterID = Convert.ToInt32(dgvMold.Rows[selectedRow].Cells["CasterID"].Value.ToString());
                    ItemID = Convert.ToInt32(dgvMold.Rows[selectedRow].Cells["ItemID"].Value.ToString());
                    StyleID = Convert.ToInt32(dgvMold.Rows[selectedRow].Cells["StyleID"].Value.ToString());
                    SizeID = Convert.ToInt32(dgvMold.Rows[selectedRow].Cells["SizeID"].Value.ToString());
                    d = Convert.ToDateTime(dgvMold.Rows[selectedRow].Cells["Date"].Value.ToString());
                    dal.updateStatus(casterID,ItemID,StyleID,SizeID,d);
                    //-----update caster unglaze item stock
                    updateCasterStock();
                    //-----update company unglaze item stock
                    updateCompanyStock();
                    //deleteCastingReport();//change status
                    dgvMold.Rows.RemoveAt(selectedRow);
                    selectedRow = -1;

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addSlipToStock()
        {
            try
            {
                ItemWeightDAL dalItemWeight = new ItemWeightDAL();
                SlipStockDAL dalSlipStock = new SlipStockDAL();
                float item_Weight = dalItemWeight.getItemWeightByName(dgvMold.Rows[selectedRow].Cells["Item"].Value.ToString(), dgvMold.Rows[selectedRow].Cells["Style"].Value.ToString(), dgvMold.Rows[selectedRow].Cells["Size"].Value.ToString());
                float totalWeight = item_Weight * Convert.ToSingle(dgvMold.Rows[selectedRow].Cells["MouldCasting"].Value.ToString());
                dalSlipStock.updateSlipStock(totalWeight + dalSlipStock.getSlipInStock());
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }
        //==================================================================================
        private void updateCasterStock()
        {
            try
            {
                CasterItemStockTableAdapter dal = new CasterItemStockTableAdapter();
                CasterCheckedItemInfoTableAdapter dalCheckedItem = new CasterCheckedItemInfoTableAdapter();
                int item_quantity = 0;
                int checked_item_quantity = 0;
                int casterId = Convert.ToInt32(dgvMold.Rows[selectedRow].Cells[1].Value.ToString());
                string item = dgvMold.Rows[selectedRow].Cells["Item"].Value.ToString();
                string style = dgvMold.Rows[selectedRow].Cells["Style"].Value.ToString();
                string size = dgvMold.Rows[selectedRow].Cells["Size"].Value.ToString();
                item_quantity = Convert.ToInt32(dal.getStockByName(item, style, size, casterId)) + Convert.ToInt32(dgvMold.Rows[selectedRow].Cells["Breakage"].Value.ToString()) + Convert.ToInt32(dgvMold.Rows[selectedRow].Cells["DryBreakage"].Value.ToString()) + Convert.ToInt32(dgvMold.Rows[selectedRow].Cells["Checked"].Value.ToString()) + Convert.ToInt32(dgvMold.Rows[selectedRow].Cells["Rejected"].Value.ToString()) - Convert.ToInt32(dgvMold.Rows[selectedRow].Cells["MouldCasting"].Value.ToString());
                dal.UpdateStockByName(item_quantity, item, style, size, casterId);
                checked_item_quantity = Convert.ToInt32(dalCheckedItem.getStockByName(casterId, item, style, size)) - Convert.ToInt32(dgvMold.Rows[selectedRow].Cells["Checked"].Value.ToString());
                dalCheckedItem.UpdateQueryByName(checked_item_quantity, item, style, size, casterId);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void updateCompanyStock()
        {
            try
            {
                taUnglazeStockCompany dal = new taUnglazeStockCompany();
                string item = dgvMold.Rows[selectedRow].Cells["Item"].Value.ToString();
                string style = dgvMold.Rows[selectedRow].Cells["Style"].Value.ToString();
                string size = dgvMold.Rows[selectedRow].Cells["Size"].Value.ToString();
                int item_quantity = Convert.ToInt32(dal.getUnglazeStock(item, style, size)) - Convert.ToInt32(dgvMold.Rows[selectedRow].Cells["Checked"].Value.ToString());
                dal.updateStockByName(item_quantity, item, style, size);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----report object
        rptFrmMoldCastingReport report;
        private void btnprintReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false))
                {
                    MessageBox.Show("Select Some Critaria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = (DataTable)dgvMold.DataSource;

                    //if (!this.Parent.Contains(report))
                    //{
                    report = new rptFrmMoldCastingReport();
                    //report.TopLevel = false;
                    //report.Dock = DockStyle.Fill;
                    //this.Parent.Controls.Add(report);

                    if (rbtnDay.Checked.Equals(true))
                    {
                        if (chkbxShowByCaster.Checked.Equals(true))
                        {
                            report.reportByCasterDailyByDT(dt);
                        }
                        else
                        {
                            report.reportByDateByDT(dt);
                        }
                        report.BringToFront();
                        report.Show();
                    }
                    else if (rbtnMonth.Checked.Equals(true))
                    {
                        if (chkbxShowByCaster.Checked.Equals(true))
                        {
                            report.reportByCasterMonthDT(dt);
                        }
                        else
                        {
                            report.reportByMonthDT(dt);
                        }
                        
                        report.BringToFront();
                        report.Show();
                    }
                    //else
                    //{
                    //    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //====================================================================================
    }
}
