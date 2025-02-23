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
    public partial class frmMoldIssueRecordShow : Form
    {
        //PersonDAL personDAL = new PersonDAL();
        //ItemDAL itemDAL = new ItemDAL();
        //DALItemStyle styleDAL = new DALItemStyle();
        //ItemSizeDAL sizeDAL = new ItemSizeDAL();
        //MoldIssueRecordDAL moldIssueDAL = new MoldIssueRecordDAL();
        //MoldStockCompanyDAL moldStockCompanyDAL = new MoldStockCompanyDAL();
        //MoldStockWorkerDAL moldStockWorkerDAL = new MoldStockWorkerDAL();

        Int16 selectedRow = -1;
        List<MoldIssueRecord> list;
        List<int> caster;

        public frmMoldIssueRecordShow()
        {
            InitializeComponent();
        }

        private void chkbxUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxUpdate.Checked.Equals(true))
            {
                gbxUpdate.Enabled = true;
            }
            if (chkbxUpdate.Checked.Equals(false))
            {
                gbxUpdate.Enabled = false;
                selectedRow = -1;
                emptyTextBoxes();
            }
        }
        //========================================================================================================
        //==========================================================================
        private void emptyTextBoxes()
        {
            txtCaster.Text = "";
            txtItem.Text = "";
            txtStyle.Text = "";
            txtSize.Text = "";
            txtQuantity.Text = "";
            txtDate.Text = "";
            txtUpdateQuantity.Text = "";
        }
        //=============================================================================
        //==============================================================================
        private void populateTextFields()
        {
            txtCaster.Text = dgvReport.Rows[selectedRow].Cells[0].Value.ToString();
            txtItem.Text = dgvReport.Rows[selectedRow].Cells[1].Value.ToString();
            txtStyle.Text = dgvReport.Rows[selectedRow].Cells[2].Value.ToString();
            txtSize.Text = dgvReport.Rows[selectedRow].Cells[3].Value.ToString();
            txtQuantity.Text = dgvReport.Rows[selectedRow].Cells[4].Value.ToString();
            txtDate.Text = dgvReport.Rows[selectedRow].Cells[5].Value.ToString();
        }
        //==============================================================================================================
        private void btnShow_Click(object sender, EventArgs e)
        {
            callShow();
        }
        private void callShow()
        {
            try
            {
                MoldIssueRecordDAL moldIssueDAL = new MoldIssueRecordDAL();
                
                if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false) && rbtnYear.Checked.Equals(false))
                {
                    MessageBox.Show("Please select some critaria", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                list = new List<MoldIssueRecord>();
                dgvReport.Rows.Clear();
                //===============================
                if (rbtnDay.Checked.Equals(true))
                {
                    list = moldIssueDAL.getReportByIssueDay(dtpGlazeHouse.Value);
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
                    list = moldIssueDAL.getReportByMonth(dtpGlazeHouse.Value);
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
                    list = moldIssueDAL.getReportByYear(dtpGlazeHouse.Value);
                    if (list.Count.Equals(0))
                    {
                        MessageBox.Show("No record found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //===================================================================================================================================
        //==================================================================================
        private void loadDataGrid()
        {
            PersonDAL personDAL = new PersonDAL();
            ItemDAL itemDAL = new ItemDAL();
            DALItemStyle styleDAL = new DALItemStyle();
            ItemSizeDAL sizeDAL = new ItemSizeDAL();
            
            selectedRow = -1;
            caster = new List<int>();
            for (Int16 i = 0; i < list.Count; i++)
            {
                dgvReport.Rows.Add();
                dgvReport.Rows[i].Cells[0].Value = personDAL.getPersonName(list[i].WorkerID);
                caster.Add(list[i].WorkerID);
                dgvReport.Rows[i].Cells[1].Value = itemDAL.getItemName(list[i].ItemID);
                dgvReport.Rows[i].Cells[2].Value = styleDAL.getItemStyleName(list[i].StyleID);
                dgvReport.Rows[i].Cells[3].Value = sizeDAL.getItemSizeName(list[i].SizeID);
                dgvReport.Rows[i].Cells[4].Value = list[i].Quantity;
                dgvReport.Rows[i].Cells[5].Value = list[i].IssueDate.ToShortDateString();
            }
        }
        //===============================================================================
        private void frmMoldIssueRecordShow_Load(object sender, EventArgs e)
        {
            gbxUpdate.Enabled = false;
        }

        private void dgvReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (chkbxUpdate.Checked.Equals(true))
            {
                selectedRow = Convert.ToInt16(e.RowIndex);
                if (selectedRow != -1)
                {
                    populateTextFields();
                }
            }
        }
        //==================================================================================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRow.Equals(-1))
            {
                MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                deleteSelectedRecord();
                emptyTextBoxes();
            }
        }
        //===================================================================================
        //==============================================================================
        private void deleteSelectedRecord()
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                MoldIssueRecordDAL moldIssueDAL = new MoldIssueRecordDAL();
                MoldStockCompanyDAL moldStockCompanyDAL = new MoldStockCompanyDAL();
                MoldStockWorkerDAL moldStockWorkerDAL = new MoldStockWorkerDAL();

                //=============delete report
                MoldIssueRecord obj = new MoldIssueRecord();

                obj.WorkerID = caster[selectedRow];
                obj.ItemID = itemDAL.getItemID(txtItem.Text);
                obj.StyleID = styleDAL.getStyleID(txtStyle.Text);
                obj.SizeID = sizeDAL.getSizeID(txtSize.Text);
                obj.Quantity = Convert.ToInt16(txtQuantity.Text);
                obj.IssueDate = Convert.ToDateTime(txtDate.Text);

                moldIssueDAL.deleteReport(obj);
                //=======================================================================================================
                //=====deduct from caster stock
                MoldStockWorker workerStock = new MoldStockWorker();

                workerStock.WorkerID = obj.WorkerID;
                workerStock.ItemID = obj.ItemID;
                workerStock.StyleID = obj.StyleID;
                workerStock.SizeID = obj.SizeID;
                Int16 workerMold = moldStockWorkerDAL.getFreeStock(workerStock);
                workerStock.Quantity = Convert.ToInt16(workerMold - obj.Quantity);

                moldStockWorkerDAL.updateStock(workerStock);
                MessageBox.Show("Caster mold stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //==============================
                //=====add to the company mold stock=====
                Int16 quantityInStock = moldStockCompanyDAL.getStockByItemStyleSize(obj.ItemID, obj.StyleID, obj.SizeID);
                Int16 quantity = Convert.ToInt16(quantityInStock + Convert.ToInt16(txtQuantity.Text));

                MoldStockCompany objStock = new MoldStockCompany();
                objStock.ItemID = obj.ItemID;
                objStock.StyleID = obj.StyleID;
                objStock.SizeID = obj.SizeID;
                objStock.Quantity = quantity;
                moldStockCompanyDAL.updateStock(objStock);
                MessageBox.Show("Company mold stock has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //====================end add to company stock
                emptyTextBoxes();
                dgvReport.Rows.RemoveAt(selectedRow);
                selectedRow = -1;
                callShow();
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
                MoldIssueRecordDAL moldIssueDAL = new MoldIssueRecordDAL();
                MoldStockCompanyDAL moldStockCompanyDAL = new MoldStockCompanyDAL();
                MoldStockWorkerDAL moldStockWorkerDAL = new MoldStockWorkerDAL();

                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtUpdateQuantity.Text.Equals(""))
                {
                    MessageBox.Show("Enter some quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //=====update the issue report
                    MoldIssueRecord obj = new MoldIssueRecord();

                    obj.WorkerID = caster[selectedRow]; 
                    obj.ItemID = itemDAL.getItemID(txtItem.Text);
                    obj.StyleID = styleDAL.getStyleID(txtStyle.Text);
                    obj.SizeID = sizeDAL.getSizeID(txtSize.Text);
                    Int16 moldStock = moldIssueDAL.getStockByCaster(obj.ItemID, obj.StyleID, obj.SizeID, obj.WorkerID);
                    obj.Quantity = Convert.ToInt16(txtUpdateQuantity.Text);
                    obj.IssueDate = Convert.ToDateTime(txtDate.Text);
                    moldIssueDAL.updateReport(obj);
                    MessageBox.Show("Mold issue report has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //=====end
                    //=====update the caster stock
                    MoldStockWorker workerStock = new MoldStockWorker();
                    workerStock.WorkerID = obj.WorkerID;
                    workerStock.ItemID = obj.ItemID;
                    workerStock.StyleID = obj.StyleID;
                    workerStock.SizeID = obj.SizeID;
                    Int16 workerMold = moldStockWorkerDAL.getFreeStock(workerStock);
                    workerStock.Quantity = Convert.ToInt16((workerMold + obj.Quantity) - Convert.ToInt16(txtQuantity.Text));
                    moldStockWorkerDAL.updateStock(workerStock);
                    MessageBox.Show("Caster mold stock has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //=====end
                    //=====update the company mold stock=====
                    Int16 quantityInStock = moldStockCompanyDAL.getStockByItemStyleSize(obj.ItemID, obj.StyleID, obj.SizeID);
                    Int16 quantity = Convert.ToInt16((quantityInStock + Convert.ToInt16(txtQuantity.Text)) - Convert.ToInt16(txtUpdateQuantity.Text));

                    MoldStockCompany objStock = new MoldStockCompany();
                    objStock.ItemID = obj.ItemID;
                    objStock.StyleID = obj.StyleID;
                    objStock.SizeID = obj.SizeID;
                    objStock.Quantity = quantity;
                    moldStockCompanyDAL.updateStock(objStock);
                    MessageBox.Show("Company mold stock has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //====================end add to company stock
                }
                callShow();
                emptyTextBoxes();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----report object
        rptFrmMoldIssue report;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false) && rbtnYear.Checked.Equals(false))
                {
                    MessageBox.Show("Select some citaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //if (!this.Parent.Contains(report))
                    //{
                        report = new rptFrmMoldIssue();
                        //report.TopLevel = false;
                        //report.Dock = DockStyle.Fill;
                        //this.Parent.Controls.Add(report);
                        //report.Show();

                        if (rbtnDay.Checked.Equals(true))
                        {
                            report.reportByDate(dtpGlazeHouse.Value.Date);
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

        private void txtUpdateQuantity_KeyPress(object sender, KeyPressEventArgs e)
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
        //======================================================================================================================================
    }
}
