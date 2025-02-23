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
    public partial class frmGreenWareItemCheckingShow : Form
    {
        
        //GreenWareHouseItemCheckReportDAL greenwareReportDAL=new GreenWareHouseItemCheckReportDAL();
        //PersonDAL personDAL = new PersonDAL();
        //ItemDAL itemDAL = new ItemDAL();
        //DALItemStyle styleDAL = new DALItemStyle();
        //ItemSizeDAL sizeDAL = new ItemSizeDAL();
        //UnGlazeStockCompanyDAL companyStockDAL = new UnGlazeStockCompanyDAL();

        List<GreenWareHouseItemCheckReport> list;
        List<int> caster;
        List<int> checker;
        Int16 selectedRow = -1;

        public frmGreenWareItemCheckingShow()
        {
            InitializeComponent();
        }
        private void showCall()
        {
            try
            {
                GreenWareHouseItemCheckReportDAL greenwareReportDAL = new GreenWareHouseItemCheckReportDAL();
                
                if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false) && rbtnYear.Checked.Equals(false))
                {
                    MessageBox.Show("Please select some critaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                list = new List<GreenWareHouseItemCheckReport>();
                dgvReport.Rows.Clear();
                //===============================
                if (rbtnDay.Checked.Equals(true))
                {
                    list = greenwareReportDAL.getReportByDay(dtpGlazeHouse.Value);
                    if (list.Count.Equals(0))
                    {
                        MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        list.TrimExcess();
                        loadDataGrid();
                    }
                }
                else if (rbtnMonth.Checked.Equals(true))
                {
                    list = greenwareReportDAL.getReportByMonth(dtpGlazeHouse.Value);
                    if (list.Count.Equals(0))
                    {
                        MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        list.TrimExcess();
                        loadDataGrid();
                    }
                }
                else if (rbtnYear.Checked.Equals(true))
                {
                    list = greenwareReportDAL.getReportByYear(dtpGlazeHouse.Value);
                    if (list.Count.Equals(0))
                    {
                        MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        list.TrimExcess();
                        loadDataGrid();
                    }
                }
                //===============================//
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            showCall();
        }
        //==========================================================================
        //==========================================================================
        private void emptyTextBoxes()
        {
            txtCaster.Text= "";
            txtChecker.Text = "";
            txtItem.Text = "";
            txtStyle.Text = "";
            txtSize.Text = "";
            txtQuantity.Text = "";
            txtDate.Text = "";
            txtUpdateQuantity.Text = "";
            txtCastedQuantity.Text = "";
            txtFreeQuantity.Text = "";
        }
        //=============================================================================
        //==============================================================================
        private void populateTextFields()
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                
                MoldStockWorkerDAL dal = new MoldStockWorkerDAL();
                txtCaster.Text = dgvReport.Rows[selectedRow].Cells[0].Value.ToString();
                txtChecker.Text = dgvReport.Rows[selectedRow].Cells[1].Value.ToString();
                txtItem.Text = dgvReport.Rows[selectedRow].Cells[2].Value.ToString();
                txtStyle.Text = dgvReport.Rows[selectedRow].Cells[3].Value.ToString();
                txtSize.Text = dgvReport.Rows[selectedRow].Cells[4].Value.ToString();
                txtQuantity.Text = dgvReport.Rows[selectedRow].Cells[5].Value.ToString();
                txtDate.Text = dgvReport.Rows[selectedRow].Cells[6].Value.ToString();
                txtFreeQuantity.Text = Convert.ToString(dal.getFreeStockByCasterItemStyleAndSize(caster[selectedRow],itemDAL.getItemID(txtItem.Text), styleDAL.getStyleID(txtStyle.Text), sizeDAL.getSizeID(txtSize.Text)));
                txtCastedQuantity.Text = Convert.ToString(dal.getCastedStockByCasterItemStyleAndSize(caster[selectedRow], itemDAL.getItemID(txtItem.Text), styleDAL.getStyleID(txtStyle.Text), sizeDAL.getSizeID(txtSize.Text)));
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //==================================================================================
        private void loadDataGrid()
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                
                caster = new List<int>();
                checker = new List<int>();
                selectedRow = -1;
                for (Int16 i = 0; i < list.Count; i++)
                {
                    dgvReport.Rows.Add();
                    caster.Add(list[i].WorkerID);
                    checker.Add(list[i].CheckerID);
                    dgvReport.Rows[i].Cells[0].Value =personDAL.getPersonName(list[i].WorkerID);
                    dgvReport.Rows[i].Cells[1].Value = personDAL.getPersonName(list[i].CheckerID);
                    dgvReport.Rows[i].Cells[2].Value = itemDAL.getItemName(list[i].ItemID);
                    dgvReport.Rows[i].Cells[3].Value = styleDAL.getItemStyleName(list[i].StyleID);
                    dgvReport.Rows[i].Cells[4].Value = sizeDAL.getItemSizeName(list[i].SizeID);
                    dgvReport.Rows[i].Cells[5].Value = list[i].Quantity;
                    dgvReport.Rows[i].Cells[6].Value = list[i].Date.ToString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //===================================================================================
        private void dgvReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(chkbxUpdate.Checked.Equals(true))
            {
                selectedRow = Convert.ToInt16(e.RowIndex);
                if(selectedRow!=-1)
                {
                    populateTextFields();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRow.Equals(-1))
            {
                MessageBox.Show("Select record...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                deleteSelectedRecord();
            }
        }
        //==================================================================================
        //==============================================================================
        private void deleteSelectedRecord()
        {
            try
            {
                GreenWareHouseItemCheckReportDAL greenwareReportDAL = new GreenWareHouseItemCheckReportDAL();
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                UnGlazeStockCompanyDAL companyStockDAL = new UnGlazeStockCompanyDAL();

                //=============delete report
                GreenWareHouseItemCheckReport obj = new GreenWareHouseItemCheckReport();
                obj.WorkerID = caster[selectedRow];
                obj.CheckerID = checker[selectedRow];
                obj.ItemID = itemDAL.getItemID(txtItem.Text);
                obj.StyleID = styleDAL.getStyleID(txtStyle.Text);
                obj.SizeID = sizeDAL.getSizeID(txtSize.Text);
                obj.Quantity = Convert.ToInt32(txtQuantity.Text);
                obj.Date = Convert.ToDateTime(txtDate.Text);
                greenwareReportDAL.deleteReport(obj);
                MessageBox.Show("Report has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //=======================================================================================================
                //=====deduct from the company item stock=====//delete the selected record and add the updated record where the date remain the same...
                UnGlazeStockCompany objStock = new UnGlazeStockCompany();
                objStock.ItemID = obj.ItemID;
                objStock.StyleID = obj.StyleID;
                objStock.SizeID = obj.SizeID;
                objStock.Quantity = companyStockDAL.getStockByObject(objStock) - Convert.ToInt32(txtQuantity.Text);
                companyStockDAL.updateStock(objStock);
                MessageBox.Show("Unglazed item stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //====================end deduct from company stock
                //===========update the worker stock
                GreenWareHouseWorkerStockDAL dal = new GreenWareHouseWorkerStockDAL();
                GreenWareHouseWorkerStock workerStock = new GreenWareHouseWorkerStock();
                workerStock.WorkerID = obj.WorkerID;
                workerStock.ItemID = obj.ItemID;
                workerStock.StyleID = obj.StyleID;
                workerStock.SizeID = obj.SizeID;
                if (dal.checkIsRecordExist(workerStock).Equals(true))
                {
                    int q = dal.getStock(workerStock);
                    workerStock.Quantity = q + Convert.ToInt32(txtQuantity.Text);
                    dal.updateStock(workerStock);
                    MessageBox.Show("Caster unglaze item's stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    workerStock.Quantity = Convert.ToInt32(txtQuantity.Text);
                    dal.addStock(workerStock);
                }
                //=======================================================================================================
                emptyTextBoxes();
                dgvReport.Rows.RemoveAt(selectedRow);
                selectedRow = -1;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //====================================================================================================================================
        private void chkbxUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbxUpdate.Checked.Equals(true))
            {
                gbxUpdate.Enabled = true;
            }
            if(chkbxUpdate.Checked.Equals(false))
            {
                gbxUpdate.Enabled = false;
                selectedRow = -1;
                emptyTextBoxes();
            }
        }

        private void frmGreenWareItemCheckingShow_Load(object sender, EventArgs e)
        {
            gbxUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtUpdateQuantity.Text.Equals(""))
                {
                    MessageBox.Show("Enter updated quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((Convert.ToInt32(txtCastedQuantity.Text) + Convert.ToInt32(txtQuantity.Text)) < Convert.ToInt32(txtUpdateQuantity.Text))
                {
                    MessageBox.Show("Entered updated quantity is greater than casted mold stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GreenWareHouseItemCheckReportDAL greenwareReportDAL = new GreenWareHouseItemCheckReportDAL();
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    UnGlazeStockCompanyDAL companyStockDAL = new UnGlazeStockCompanyDAL();

                    //=============update the checking report
                    GreenWareHouseItemCheckReport obj = new GreenWareHouseItemCheckReport();
                    obj.CheckerID = checker[selectedRow];
                    obj.WorkerID = caster[selectedRow];
                    obj.ItemID = itemDAL.getItemID(txtItem.Text);
                    obj.StyleID = styleDAL.getStyleID(txtStyle.Text);
                    obj.SizeID = sizeDAL.getSizeID(txtSize.Text);
                    obj.Quantity = Convert.ToInt16(txtUpdateQuantity.Text);
                    obj.Date = Convert.ToDateTime(txtDate.Text);
                    greenwareReportDAL.updateReport(obj);
                    MessageBox.Show("Information has been recorded...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //=======================================================================================================
                    //=====Update the company item stock=====//delete the selected record and add the updated record where the date remain the same...
                    UnGlazeStockCompany objStock = new UnGlazeStockCompany();
                    objStock.ItemID = obj.ItemID;
                    objStock.StyleID = obj.StyleID;
                    objStock.SizeID = obj.SizeID;
                    int quantityInStock = companyStockDAL.getStockByItemStyleSize(obj.ItemID, obj.StyleID, obj.SizeID);
                    objStock.Quantity = (quantityInStock - Convert.ToInt32(txtQuantity.Text)) + Convert.ToInt32(txtUpdateQuantity.Text);
                    companyStockDAL.updateStock(objStock);
                    MessageBox.Show("Unglazed stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //=======================================================================================================
                    //===========update the worker stock
                    GreenWareHouseWorkerStockDAL dal = new GreenWareHouseWorkerStockDAL();
                    GreenWareHouseWorkerStock workerStock = new GreenWareHouseWorkerStock();
                    workerStock.WorkerID = obj.WorkerID;
                    workerStock.ItemID = obj.ItemID;
                    workerStock.StyleID = obj.StyleID;
                    workerStock.SizeID = obj.SizeID;
                    if (dal.checkIsRecordExist(workerStock).Equals(true))
                    {
                        int q = dal.getStock(workerStock);
                        workerStock.Quantity = (q + Convert.ToInt32(txtQuantity.Text)) - Convert.ToInt32(txtUpdateQuantity.Text);
                        dal.updateStock(workerStock);
                        MessageBox.Show("Caster unglaze item's stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        workerStock.Quantity = 0;
                        dal.addStock(workerStock); 
                    }
                    //=======================================================================================================
                    selectedRow = -1;
                    emptyTextBoxes();
                    showCall();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----report object
        rptFrmGreenwareItemChecking report;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false) && rbtnYear.Checked.Equals(false))
                {
                    MessageBox.Show("Select some critaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //else
                //{
                    if (!this.Parent.Contains(report))
                    {
                        report = new rptFrmGreenwareItemChecking();
                        //report.TopLevel = false;
                        //report.Dock = DockStyle.Fill;
                        //this.Parent.Controls.Add(report);
                        if (rbtnDay.Checked.Equals(true))
                        {
                            report.reportByDate(dtpGlazeHouse.Value);
                            report.BringToFront();
                            report.Show();
                        }
                        else if (rbtnMonth.Checked.Equals(true))
                        {
                            report.reportByMonth(dtpGlazeHouse.Value);
                            report.BringToFront();
                            report.Show();
                        }
                        else if (rbtnYear.Checked.Equals(true))
                        {
                            report.reportByYear(dtpGlazeHouse.Value);
                            report.BringToFront();
                            report.Show();
                        }
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

        private void txtFreeQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtCastedQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtUpdateQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            txtUpdateQuantity.Focus();
        }
        //==============================================================================
    }
}
