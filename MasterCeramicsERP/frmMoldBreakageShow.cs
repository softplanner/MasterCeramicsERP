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
    public partial class frmMoldBreakageShow : Form
    {
        
        //MoldBreakageDAL moldBreakageDAL = new MoldBreakageDAL();
        //PersonDAL personDAL = new PersonDAL();
        //ItemDAL itemDAL = new ItemDAL();
        //DALItemStyle styleDAL = new DALItemStyle();
        //ItemSizeDAL sizeDAL = new ItemSizeDAL();
        //MoldStockCompanyDAL moldStockCompany = new MoldStockCompanyDAL();
        //MoldStockWorkerDAL moldStockWorker = new MoldStockWorkerDAL();

        List<MoldBreakage> list;
        List<int> breakerID ;
        int selectedRow = -1;

        public frmMoldBreakageShow()
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
            txtRemarks.Text = "";
        }
        //=============================================================================
        //==============================================================================
        private void populateTextFields()
        {
            //if (dgvBreakage.Rows[selectedRow].Cells[8].Value.ToString().Equals("Caster"))
            //{
            //    lblCaster.Enabled = true;
            //    txtCaster.Text =dgvBreakage.Rows[selectedRow].Cells[1].Value.ToString();
            //}
            //else
            //{
            //    lblCaster.Enabled = false;
            //    txtCaster.Text = "";
            //}
            txtCaster.Text = dgvBreakage.Rows[selectedRow].Cells[0].Value.ToString();
            txtItem.Text = dgvBreakage.Rows[selectedRow].Cells[1].Value.ToString();
            txtStyle.Text = dgvBreakage.Rows[selectedRow].Cells[2].Value.ToString();
            txtSize.Text = dgvBreakage.Rows[selectedRow].Cells[3].Value.ToString();
            txtQuantity.Text = dgvBreakage.Rows[selectedRow].Cells[4].Value.ToString();
            txtRemarks.Text = dgvBreakage.Rows[selectedRow].Cells[5].Value.ToString();
            txtDate.Text = dgvBreakage.Rows[selectedRow].Cells[6].Value.ToString();
        }
        //==================================================================================
        //==================================================================================
        private void loadDataGrid()
        {
            //try
            //{
                PersonDAL personDAL = new PersonDAL();
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();

                breakerID = new List<int>();
                selectedRow = -1;
                for (Int16 i = 0; i < list.Count; i++)
                {
                    dgvBreakage.Rows.Add();
                    //if (list[i].MoldContainer.ToString() == "Company")
                    //{
                    //    dgvBreakage.Rows[i].Cells[0].Value = "";
                    //    dgvBreakage.Rows[i].Cells[1].Value = "";
                    //}
                    //else
                    //{
                    //    dgvBreakage.Rows[i].Cells[0].Value = list[i].WorkerID.ToString();
                    //    dgvBreakage.Rows[i].Cells[1].Value =personDAL.getPersonName(list[i].WorkerID);
                    //}
                    breakerID.Add(list[i].WorkerID);
                    dgvBreakage.Rows[i].Cells[0].Value = personDAL.getPersonName(list[i].WorkerID);
                    dgvBreakage.Rows[i].Cells[1].Value = itemDAL.getItemName(list[i].ItemID);
                    dgvBreakage.Rows[i].Cells[2].Value = styleDAL.getItemStyleName(list[i].StyleID);
                    dgvBreakage.Rows[i].Cells[3].Value = sizeDAL.getItemSizeName(list[i].SizeID);
                    dgvBreakage.Rows[i].Cells[4].Value = list[i].Quantity;
                    dgvBreakage.Rows[i].Cells[5].Value = list[i].Remarks;
                    dgvBreakage.Rows[i].Cells[6].Value = list[i].Date.ToShortDateString();
                }
            //}
            //catch (Exception exp)
            //{
            //    MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void dgvBreakage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(chkbxUpdate.Enabled.Equals(true))
            {
                if (selectedRow != -1)
                {
                    populateTextFields();
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            callShow();
        }
        private void callShow()
        {
            //try
            //{
                MoldBreakageDAL moldBreakageDAL = new MoldBreakageDAL();
            
                if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false) && rbtnYear.Checked.Equals(false))
                {
                    MessageBox.Show("Select some critaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                list = new List<MoldBreakage>();
                dgvBreakage.Rows.Clear();
                //===============================
                if (rbtnDay.Checked.Equals(true))
                {
                    list = moldBreakageDAL.getReportByDay(dtpGlazeHouse.Value);
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
                    list = moldBreakageDAL.getReportByMonth(dtpGlazeHouse.Value);
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
                    list = moldBreakageDAL.getReportByYear(dtpGlazeHouse.Value);
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
            //}
            //catch (Exception exp)
            //{
            //    MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRow.Equals(-1))
            {
                MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                deleteSelectedRecord();
                MessageBox.Show("Stock has been Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                callShow();
            }
        }
        //===================================================================================
        //==============================================================================
        private void deleteSelectedRecord()
        {
            try
            {
                MoldBreakageDAL moldBreakageDAL = new MoldBreakageDAL();
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                MoldStockCompanyDAL moldStockCompany = new MoldStockCompanyDAL();
                
                //=============delete report
                MoldBreakage obj = new MoldBreakage();

                obj.WorkerID = breakerID[selectedRow];
                obj.ItemID = itemDAL.getItemID(txtItem.Text);
                obj.StyleID = styleDAL.getStyleID(txtStyle.Text);
                obj.SizeID = sizeDAL.getSizeID(txtSize.Text);
                obj.Remarks = txtRemarks.Text;
                obj.Quantity = Convert.ToInt16(txtQuantity.Text);
                obj.Date = Convert.ToDateTime(txtDate.Text);
                //if (txtCaster.Text.Equals(""))
                //{
                    moldBreakageDAL.deleteReportCompanyStock(obj);
                //}
                //else
                //{
                //    obj.WorkerID = Convert.ToInt32(dgvBreakage.Rows[selectedRow].Cells[0].Value.ToString());
                //    moldBreakageDAL.deleteReportCasterStock(obj);
                //}
                //==============end delete report
                //=====update the caster or worker stock
                //if (txtCaster.Text.Equals(""))//then update the company stock 
                //{
                    MoldStockCompany m = new MoldStockCompany();
                    m.ItemID = itemDAL.getItemID(txtItem.Text);
                    m.StyleID = styleDAL.getStyleID(txtStyle.Text);
                    m.SizeID = sizeDAL.getSizeID(txtSize.Text);
                    m.Quantity = Convert.ToInt16(moldStockCompany.getStockByItemStyleSize(m.ItemID, m.StyleID, m.SizeID) + Convert.ToInt16(txtQuantity.Text));
                    moldStockCompany.updateStock(m);
                //}
                //else //update the caster mold stock
                //{
                //    MoldStockWorker m = new MoldStockWorker();
                //    m.WorkerID = Convert.ToInt32(dgvBreakage.Rows[selectedRow].Cells[0].Value);
                //    m.ItemID = itemDAL.getItemID(txtItem.Text);
                //    m.StyleID = styleDAL.getStyleID(txtStyle.Text);
                //    m.SizeID = sizeDAL.getSizeID(txtSize.Text);
                //    m.Quantity = Convert.ToInt16(moldStockWorker.getFreeStock(m) + Convert.ToInt16(txtQuantity.Text));
                //    moldStockWorker.updateStock(m);
                //}
                //=====end
                emptyTextBoxes();
                dgvBreakage.Rows.RemoveAt(selectedRow);
                selectedRow = -1;
                MessageBox.Show("Selected record has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMoldBreakageShow_Load(object sender, EventArgs e)
        {
            gbxUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                MoldBreakageDAL moldBreakageDAL = new MoldBreakageDAL();
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                MoldStockCompanyDAL moldStockCompany = new MoldStockCompanyDAL();
                
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
                    //=====update the breakage report
                    MoldBreakage obj = new MoldBreakage();
                    obj.WorkerID = breakerID[selectedRow];
                    obj.ItemID = itemDAL.getItemID(txtItem.Text);
                    obj.StyleID = styleDAL.getStyleID(txtStyle.Text);
                    obj.SizeID = sizeDAL.getSizeID(txtSize.Text);
                    obj.Remarks = txtRemarks.Text;
                    obj.Quantity = Convert.ToInt16(txtUpdateQuantity.Text);
                    obj.Date = Convert.ToDateTime(txtDate.Text);
                    //if (txtCaster.Text.Equals(""))
                    //{
                    moldBreakageDAL.updateReportCompany(obj);
                    //}
                    //else
                    //{
                    //    moldBreakageDAL.updateReportCaster(obj);
                    //}
                    //=====end
                    //=====update the caster or worker stock
                    //if (txtCaster.Text.Equals(""))//then update the company stock 
                    //{
                        MoldStockCompany m = new MoldStockCompany();
                        m.ItemID = itemDAL.getItemID(txtItem.Text);
                        m.StyleID = styleDAL.getStyleID(txtStyle.Text);
                        m.SizeID = sizeDAL.getSizeID(txtSize.Text);
                        m.Quantity = Convert.ToInt16((moldStockCompany.getStockByItemStyleSize(m.ItemID, m.StyleID, m.SizeID) - Convert.ToInt16(txtUpdateQuantity.Text)) + Convert.ToInt16(txtQuantity.Text));
                        moldStockCompany.updateStock(m);
                    //}
                    //else //update the caster mold stock
                    //{
                    //    MoldStockWorker m = new MoldStockWorker();
                    //    m.WorkerID = Convert.ToInt32(dgvBreakage.Rows[selectedRow].Cells[0].Value);
                    //    m.ItemID = itemDAL.getItemID(txtItem.Text);
                    //    m.StyleID = styleDAL.getStyleID(txtStyle.Text);
                    //    m.SizeID = sizeDAL.getSizeID(txtSize.Text);
                    //    m.Quantity = Convert.ToInt16((moldStockWorker.getFreeStock(m) - Convert.ToInt16(txtUpdateQuantity.Text)) + Convert.ToInt16(txtQuantity.Text));
                    //    moldStockWorker.updateStock(m);
                    //}
                    //=====end
                    emptyTextBoxes();
                    MessageBox.Show("Stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    callShow();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----report object
        rptFrmMoldBreakage report;
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
                        report = new rptFrmMoldBreakage();
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
        //====================================================================================================================================
    }
}
