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
    public partial class frmOilInspectionShow : Form
    {
        DataSet dsCaster = new DataSet();
        DataSet dsChecker = new DataSet();

        //PersonDAL personDAL = new PersonDAL();
        //ItemDAL itemDAL = new ItemDAL();
        //DALItemStyle styleDAL = new DALItemStyle();
        //ItemSizeDAL sizeDAL = new ItemSizeDAL();
        //JobsDAL jobDal = new JobsDAL();
        //MoldCastingRepertDAL moldCastingDAL = new MoldCastingRepertDAL();
        //MoldStockWorkerDAL workerDAL = new MoldStockWorkerDAL();
        //OilInspectionReportDAL oilDAL = new OilInspectionReportDAL();

        List<OilInspectionReport> lstOilInspection;
        int  row = -1, selectedRow = -1;
        List<int> caster;
        List<int> checker;
        public frmOilInspectionShow()
        {
            InitializeComponent();
        }

        private void frmOilInspectionShow_Load(object sender, EventArgs e)
        {
            lblCaster.Enabled = false;
            lblChecker.Enabled = false;
            cbxCaster.Enabled = false;
            cbxChecker.Enabled = false;
        }
        private void datasetCasterPopulate()
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                JobsDAL jobDal = new JobsDAL();
                
                dsCaster.Clear();
                dsCaster = personDAL.getPersonByJobDataset(jobDal.getJobID(cbxCaster.Text));
                cbxCaster.DataSource = dsCaster.Tables[0];
                cbxCaster.DisplayMember = "Name";
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void datasetCheckerPopulate()
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                JobsDAL jobDal = new JobsDAL();
                
                dsChecker.Clear();
                dsChecker = personDAL.getPersonByJobDataset(jobDal.getJobID(cbxChecker.Text));
                cbxChecker.DataSource = dsChecker.Tables[0];
                cbxChecker.DisplayMember = "Name";
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void callShowReport()
        {
            try
            {
                OilInspectionReportDAL oilDAL = new OilInspectionReportDAL();

                if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false) && rbtnYear.Checked.Equals(false))
                {
                    MessageBox.Show("Please select some critaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (rbtnDay.Checked.Equals(true))
                {

                    lstOilInspection = new List<OilInspectionReport>();

                    if (chkbxCaster.Checked.Equals(false) && chkbxChecker.Checked.Equals(false))
                    {
                        lstOilInspection = oilDAL.getReportByDay(dtpGlazeHouse.Value);
                        loadDataGrid();
                    }
                    else if (chkbxCaster.Checked.Equals(true) && chkbxChecker.Checked.Equals(false))
                    {
                        lstOilInspection = oilDAL.getReportByDayAndCaster(dtpGlazeHouse.Value, Convert.ToInt32(dgvReport.Rows[selectedRow].Cells[2].Value));
                        loadDataGrid();
                    }
                    else if (chkbxCaster.Checked.Equals(false) && chkbxChecker.Checked.Equals(true))
                    {
                        lstOilInspection = oilDAL.getReportByDayAndChecker(dtpGlazeHouse.Value, Convert.ToInt32(dgvReport.Rows[selectedRow].Cells[0].Value));
                        loadDataGrid();
                    }
                    else
                    {
                        lstOilInspection = oilDAL.getReportByDayCasterAndChecker(dtpGlazeHouse.Value, Convert.ToInt32(dgvReport.Rows[selectedRow].Cells[2].Value), Convert.ToInt32(dgvReport.Rows[selectedRow].Cells[0].Value));
                        loadDataGrid();
                    }
                }
                else if (rbtnMonth.Checked.Equals(true))
                {
                    lstOilInspection = new List<OilInspectionReport>();
                    if (chkbxCaster.Checked.Equals(false) && chkbxChecker.Checked.Equals(false))
                    {
                        lstOilInspection = oilDAL.getReportByMonth(dtpGlazeHouse.Value);
                        loadDataGrid();
                    }
                    else if (chkbxCaster.Checked.Equals(true) && chkbxChecker.Checked.Equals(false))
                    {
                        lstOilInspection = oilDAL.getReportByMonthAndCaster(dtpGlazeHouse.Value, Convert.ToInt32(dgvReport.Rows[selectedRow].Cells[2].Value));
                        loadDataGrid();
                    }
                    else if (chkbxCaster.Checked.Equals(false) && chkbxChecker.Checked.Equals(true))
                    {
                        lstOilInspection = oilDAL.getReportByMonthAndChecker(dtpGlazeHouse.Value, Convert.ToInt32(dgvReport.Rows[selectedRow].Cells[0].Value));
                        loadDataGrid();
                    }
                    else
                    {
                        lstOilInspection = oilDAL.getReportByMonthCheckerAndCaster(dtpGlazeHouse.Value, Convert.ToInt32(dgvReport.Rows[selectedRow].Cells[2].Value), Convert.ToInt32(dgvReport.Rows[selectedRow].Cells[0].Value));
                        loadDataGrid();
                    }
                }
                else if (rbtnYear.Checked.Equals(true))
                {
                    lstOilInspection = new List<OilInspectionReport>();
                    if (chkbxCaster.Checked.Equals(false) && chkbxChecker.Checked.Equals(false))
                    {
                        lstOilInspection = oilDAL.getReportByYear(dtpGlazeHouse.Value);
                        loadDataGrid();
                    }
                    else if (chkbxCaster.Checked.Equals(true) && chkbxChecker.Checked.Equals(false))
                    {
                        lstOilInspection = oilDAL.getReportByYearAndCaster(dtpGlazeHouse.Value, Convert.ToInt32(dgvReport.Rows[selectedRow].Cells[2].Value));
                        loadDataGrid();
                    }
                    else if (chkbxCaster.Checked.Equals(false) && chkbxChecker.Checked.Equals(true))
                    {
                        lstOilInspection = oilDAL.getReportByYearAndChecker(dtpGlazeHouse.Value, Convert.ToInt32(dgvReport.Rows[selectedRow].Cells[0].Value));
                        loadDataGrid();
                    }
                    else
                    {
                        lstOilInspection = oilDAL.getReportByYearCheckerAndCaster(dtpGlazeHouse.Value, Convert.ToInt32(dgvReport.Rows[selectedRow].Cells[2].Value), Convert.ToInt32(dgvReport.Rows[selectedRow].Cells[0].Value));
                        loadDataGrid();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            callShowReport();
        }
        private void loadDataGrid()
        {
            PersonDAL personDAL = new PersonDAL();
            ItemDAL itemDAL = new ItemDAL();
            DALItemStyle styleDAL = new DALItemStyle();
            ItemSizeDAL sizeDAL = new ItemSizeDAL();
            
            if (lstOilInspection.Count.Equals(0))
            {
                caster = new List<int>();
                checker = new List<int>();
                row = -1;
                selectedRow = -1;
                dgvReport.Rows.Clear();
                MessageBox.Show("No record found !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                caster = new List<int>();
                checker = new List<int>();
                lstOilInspection.TrimExcess();
                row = -1;
                selectedRow = -1;
                dgvReport.Rows.Clear();
                for (Int16 i = 0; i < lstOilInspection.Count; i++)
                {
                    row = dgvReport.Rows.Add();
                    caster.Add(lstOilInspection[i].WorkerID);
                    checker.Add(lstOilInspection[i].CheckerID);
                    dgvReport.Rows[i].Cells[0].Value = personDAL.getPersonName(lstOilInspection[i].CheckerID);
                    dgvReport.Rows[i].Cells[1].Value = personDAL.getPersonName(lstOilInspection[i].WorkerID);
                    dgvReport.Rows[i].Cells[2].Value = itemDAL.getItemName(lstOilInspection[i].ItemID);
                    dgvReport.Rows[i].Cells[3].Value = styleDAL.getItemStyleName(lstOilInspection[i].StyleID);
                    dgvReport.Rows[i].Cells[4].Value = sizeDAL.getItemSizeName(lstOilInspection[i].SizeID);
                    dgvReport.Rows[i].Cells[5].Value = lstOilInspection[i].CheckedQuantity.ToString();
                    dgvReport.Rows[i].Cells[6].Value = lstOilInspection[i].RejectQuantity.ToString();
                    dgvReport.Rows[i].Cells[7].Value = lstOilInspection[i].Remarks;
                    dgvReport.Rows[i].Cells[8].Value = lstOilInspection[i].Date.ToShortDateString();
                }
            }
        }

        private void chkbxCaster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxCaster.Checked.Equals(true))
            {
                lblCaster.Enabled = true;
                cbxCaster.Enabled = true;
                datasetCasterPopulate();
            }
            else
            {
                lblCaster.Enabled = false;
                cbxCaster.Enabled = false;
                dsCaster.Clear();
            }
        }

        private void chkbxChecker_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxChecker.Checked.Equals(true))
            {
                lblChecker.Enabled = true;
                cbxChecker.Enabled = true;
                datasetCheckerPopulate();
            }
            else
            {
                lblChecker.Enabled = false;
                cbxChecker.Enabled = false;
                dsChecker.Clear();
            }
        }

        private void dgvReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow != -1)
            {
                populateTextFeilds();
            }
        }
        private void populateTextFeilds()
        {
            ItemDAL itemDAL = new ItemDAL();
            DALItemStyle styleDAL = new DALItemStyle();
            ItemSizeDAL sizeDAL = new ItemSizeDAL();
            MoldStockWorkerDAL workerDAL = new MoldStockWorkerDAL();

            txtChecker.Text=dgvReport.Rows[selectedRow].Cells[0].Value.ToString();
            txtCaster.Text = dgvReport.Rows[selectedRow].Cells[1].Value.ToString();
            txtItem.Text=dgvReport.Rows[selectedRow].Cells[2].Value.ToString();
            txtStyle.Text=dgvReport.Rows[selectedRow].Cells[3].Value.ToString();
            txtSize.Text=dgvReport.Rows[selectedRow].Cells[4].Value.ToString();
            txtSelectedQuantity.Text=dgvReport.Rows[selectedRow].Cells[5].Value.ToString();
            txtRejectedItems.Text=dgvReport.Rows[selectedRow].Cells[6].Value.ToString();
            txtRemarks.Text=dgvReport.Rows[selectedRow].Cells[7].Value.ToString();
            txtDate.Text=dgvReport.Rows[selectedRow].Cells[8].Value.ToString();
            //--------populate text feilds with caster mold stock--------------
            MoldStockWorker m = new MoldStockWorker();
            m.WorkerID = caster[selectedRow];
            m.ItemID = itemDAL.getItemID(txtItem.Text);
            m.StyleID = styleDAL.getStyleID(txtStyle.Text);
            m.SizeID = sizeDAL.getSizeID(txtSize.Text);
            txtFreeMold.Text = workerDAL.getFreeStock(m).ToString();
            txtCastedMold.Text = workerDAL.getCastedStock(m).ToString();
            //=================================================================
        }
        private void emptyTextFeilds()
        {
            txtChecker.Text = "";
            txtCaster.Text = "";
            txtItem.Text = "";
            txtStyle.Text = "";
            txtStyle.Text = "";
            txtSize.Text = "";
            txtRemarks.Text = "";
            txtSelectedQuantity.Text = "";
            txtRejectedItems.Text = "";
            txtRejectedItems.Text = "";
            txtDate.Text = "";
            txtFreeMold.Text = "";
            txtCastedMold.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                MoldStockWorkerDAL workerDAL = new MoldStockWorkerDAL();
                OilInspectionReportDAL oilDAL = new OilInspectionReportDAL();

                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select record...","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                if (txtSelectedQuantity.Text.Equals("") || txtRejectedItems.Text.Equals(""))
                {
                    MessageBox.Show("Enter quantity...","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    //=====delete report
                    GreenWareHouseWorkerStock workerUnglazeStock;
                    GreenWareHouseWorkerStockDAL workerUnglazeStockDal=new GreenWareHouseWorkerStockDAL();
                    OilInspectionReport o;
                    MoldStockWorker m;

                    //=====update add oil inspection report
                    o = new OilInspectionReport();
                    o.CheckerID = checker[selectedRow];
                    o.WorkerID = caster[selectedRow];
                    o.ItemID = itemDAL.getItemID(dgvReport.Rows[selectedRow].Cells[2].Value.ToString());
                    o.StyleID = styleDAL.getStyleID(dgvReport.Rows[selectedRow].Cells[3].Value.ToString());
                    o.SizeID = sizeDAL.getSizeID(dgvReport.Rows[selectedRow].Cells[4].Value.ToString());
                    o.CheckedQuantity = Convert.ToInt16(dgvReport.Rows[selectedRow].Cells[5].Value.ToString());
                    o.RejectQuantity = Convert.ToInt16(dgvReport.Rows[selectedRow].Cells[6].Value.ToString());
                    o.Remarks = dgvReport.Rows[selectedRow].Cells[7].Value.ToString();
                    o.Date = Convert.ToDateTime(dgvReport.Rows[selectedRow].Cells[8].Value.ToString());
                    oilDAL.deleteReport(o);
                    //=====end
                    //=====update the mold stock worker
                    m = new MoldStockWorker();
                    m.WorkerID = o.WorkerID;
                    m.ItemID = o.ItemID;
                    m.StyleID = o.StyleID;
                    m.SizeID = o.SizeID;
                    m.Quantity = Convert.ToInt16(workerDAL.getFreeStock(m) - (o.CheckedQuantity + o.RejectQuantity));
                    m.CastQuantity = Convert.ToInt16(workerDAL.getFreeStock(m) + o.CheckedQuantity + o.RejectQuantity);
                    workerDAL.updateStock(m);
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
                    MessageBox.Show("Caster unglaze item's stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Caster mold stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvReport.Rows.RemoveAt(selectedRow);
                    selectedRow = -1;
                    row = -1;
                    MessageBox.Show("Report has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //=====end
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                MoldStockWorkerDAL workerDAL = new MoldStockWorkerDAL();
                OilInspectionReportDAL oilDAL = new OilInspectionReportDAL();

                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select record...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtUpdatedSelectedItems.Text.Equals(""))
                {
                    MessageBox.Show("Enter qunatity for selected item's...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtUpdatedRejectedItems.Text.Equals(""))
                {
                    MessageBox.Show("Enter qunatity for rejected item's...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((Convert.ToInt32(txtSelectedQuantity.Text) + Convert.ToInt32(txtRejectedItems.Text) + Convert.ToInt32(txtCastedMold.Text)) < (Convert.ToInt32(txtUpdatedRejectedItems.Text) + Convert.ToInt32(txtUpdatedSelectedItems.Text)))
                {
                    MessageBox.Show("Enter qunatity is greater than casted mold stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GreenWareHouseWorkerStock workerUnglazeStock;
                    GreenWareHouseWorkerStockDAL workerUnglazeStockDal=new GreenWareHouseWorkerStockDAL();
                    OilInspectionReport o;
                    MoldStockWorker m;
                    //=====update add oil inspection report
                    o = new OilInspectionReport();
                    o.CheckerID = checker[selectedRow];
                    o.WorkerID = caster[selectedRow];
                    o.ItemID = itemDAL.getItemID(dgvReport.Rows[selectedRow].Cells[2].Value.ToString());
                    o.StyleID = styleDAL.getStyleID(dgvReport.Rows[selectedRow].Cells[3].Value.ToString());
                    o.SizeID = sizeDAL.getSizeID(dgvReport.Rows[selectedRow].Cells[4].Value.ToString());
                    o.CheckedQuantity = Convert.ToInt16(txtUpdatedSelectedItems.Text);
                    o.RejectQuantity = Convert.ToInt16(txtUpdatedRejectedItems.Text);
                    o.Remarks = dgvReport.Rows[selectedRow].Cells[7].Value.ToString();
                    o.Date = Convert.ToDateTime(dgvReport.Rows[selectedRow].Cells[8].Value.ToString());
                    oilDAL.updateReport(o);
                    //=====end
                    //=====update the mold stock worker
                    m = new MoldStockWorker();
                    m.WorkerID = o.WorkerID;
                    m.ItemID = o.ItemID;
                    m.StyleID = o.StyleID;
                    m.SizeID = o.SizeID;
                    m.Quantity = Convert.ToInt16((workerDAL.getFreeStock(m) - (Convert.ToInt16(txtSelectedQuantity.Text) + Convert.ToInt16(txtRejectedItems.Text))) + (o.CheckedQuantity + o.RejectQuantity));
                    m.CastQuantity = Convert.ToInt16((workerDAL.getCastedStock(m) + (Convert.ToInt16(txtSelectedQuantity.Text) + Convert.ToInt16(txtRejectedItems.Text))) - (o.CheckedQuantity + o.RejectQuantity));
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
                        workerUnglazeStock.Quantity = ((q - (o.CheckedQuantity + o.RejectQuantity)) + (Convert.ToInt32(txtUpdatedSelectedItems.Text) + Convert.ToInt32(txtUpdatedRejectedItems.Text)));
                        workerUnglazeStockDal.updateStock(workerUnglazeStock);
                    }
                    else
                    {
                        workerUnglazeStock.Quantity= Convert.ToInt32(txtUpdatedSelectedItems.Text) + Convert.ToInt32(txtUpdatedRejectedItems.Text);
                        workerUnglazeStockDal.addStock(workerUnglazeStock);
                    }
                    //==========end
                }
                    MessageBox.Show("Caster unglaze item's stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Caster mold stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Report has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----report object
        rptFrmOutwardGatePass report;
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false) && rbtnYear.Checked.Equals(false))
                {
                    MessageBox.Show("Select some citaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PersonDAL personDAL = new PersonDAL();
                    
                    //if (!this.Parent.Contains(report))
                    //{
                        report = new rptFrmOutwardGatePass();
                        //report.TopLevel = false;
                        //report.Dock = DockStyle.Fill;
                        //this.Parent.Controls.Add(report);
                        //report.Show();

                        if (rbtnDay.Checked.Equals(true) && chkbxCaster.Checked.Equals(false) && chkbxChecker.Checked.Equals(false))
                        {
                            report.reportByDate(dtpGlazeHouse.Value.Date);
                            report.BringToFront();
                            report.Show();
                        }
                        else if (rbtnDay.Checked.Equals(true) && chkbxCaster.Checked.Equals(true) && chkbxChecker.Checked.Equals(false))
                        {
                            report.reportByDateAndCaster(dtpGlazeHouse.Value.Date, personDAL.getPersonID(cbxCaster.Text));
                            report.BringToFront();
                            report.Show();
                        }
                        else if (rbtnDay.Checked.Equals(true) && chkbxCaster.Checked.Equals(false) && chkbxChecker.Checked.Equals(true))
                        {
                            report.reportByDateAndChecker(dtpGlazeHouse.Value.Date, personDAL.getPersonID(cbxChecker.Text));
                            report.BringToFront();
                            report.Show();
                        }
                        else if (rbtnDay.Checked.Equals(true) && chkbxCaster.Checked.Equals(true) && chkbxChecker.Checked.Equals(true))
                        {
                            report.reportByDateAndCaster_Checker(dtpGlazeHouse.Value.Date, personDAL.getPersonID(cbxCaster.Text), personDAL.getPersonID(cbxChecker.Text));
                            report.BringToFront();
                            report.Show();
                        }
                            //-----month
                        else if (rbtnMonth.Checked.Equals(true) && chkbxCaster.Checked.Equals(false) && chkbxChecker.Checked.Equals(false))
                        {
                            report.reportByMonth(Convert.ToInt16(dtpGlazeHouse.Value.Month), Convert.ToInt16(dtpGlazeHouse.Value.Year));
                            report.BringToFront();
                            report.Show();
                        }
                        else if (rbtnMonth.Checked.Equals(true) && chkbxCaster.Checked.Equals(true) && chkbxChecker.Checked.Equals(false))
                        {
                            report.reportByMonthAndCaster(Convert.ToInt16(dtpGlazeHouse.Value.Month), Convert.ToInt16(dtpGlazeHouse.Value.Year), personDAL.getPersonID(cbxCaster.Text));
                            report.BringToFront();
                            report.Show();
                        }
                        else if (rbtnMonth.Checked.Equals(true) && chkbxCaster.Checked.Equals(false) && chkbxChecker.Checked.Equals(true))
                        {
                            report.reportByMonthAndChecker(Convert.ToInt16(dtpGlazeHouse.Value.Month), Convert.ToInt16(dtpGlazeHouse.Value.Year), personDAL.getPersonID(cbxChecker.Text));
                            report.BringToFront();
                            report.Show();
                        }
                        else if (rbtnMonth.Checked.Equals(true) && chkbxCaster.Checked.Equals(true) && chkbxChecker.Checked.Equals(true))
                        {
                            report.reportByMonthAndCaster_Checker(Convert.ToInt16(dtpGlazeHouse.Value.Month), Convert.ToInt16(dtpGlazeHouse.Value.Year), personDAL.getPersonID(cbxCaster.Text), personDAL.getPersonID(cbxChecker.Text));
                            report.BringToFront();
                            report.Show();
                        }
                    //-----year
                        else if (rbtnYear.Checked.Equals(true) && chkbxCaster.Checked.Equals(false) && chkbxChecker.Checked.Equals(false))
                        {
                            report.reportByYear(dtpGlazeHouse.Value);
                            report.BringToFront();
                            report.Show();
                        }
                        else if (rbtnYear.Checked.Equals(true) && chkbxCaster.Checked.Equals(true) && chkbxChecker.Checked.Equals(false))
                        {
                            report.reportByYearAndCaster(dtpGlazeHouse.Value, personDAL.getPersonID(cbxCaster.Text));
                            report.BringToFront();
                            report.Show();
                        }
                        else if (rbtnYear.Checked.Equals(true) && chkbxCaster.Checked.Equals(false) && chkbxChecker.Checked.Equals(true))
                        {
                            report.reportByYearAndChecker(dtpGlazeHouse.Value, personDAL.getPersonID(cbxChecker.Text));
                            report.BringToFront();
                            report.Show();
                        }
                        else if (rbtnYear.Checked.Equals(true) && chkbxCaster.Checked.Equals(true) && chkbxChecker.Checked.Equals(true))
                        {
                            report.reportByYearAndCaster_Checker(dtpGlazeHouse.Value, personDAL.getPersonID(cbxCaster.Text), personDAL.getPersonID(cbxChecker.Text));
                            report.BringToFront();
                            report.Show();
                        }
                    //---year end
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUpdatedSelectedItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtUpdatedRejectedItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            emptyTextFeilds();
            callShowReport();
        }

        private void txtUpdatedSelectedItems_MouseClick(object sender, MouseEventArgs e)
        {
            txtUpdatedSelectedItems.Focus();
        }

        private void txtUpdatedRejectedItems_MouseClick(object sender, MouseEventArgs e)
        {
            txtUpdatedRejectedItems.Focus();
        }
        //===============================================================================================================================
    }
}
