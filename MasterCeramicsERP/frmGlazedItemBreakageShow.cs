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
    public partial class frmGlazedItemBreakageShow : Form
    {
        DataSet dsGlazeHouse = new DataSet();
        //GlazeHouseDAL glazeHouseDAL = new GlazeHouseDAL();
        //PersonDAL personDAL = new PersonDAL();
        //GlazeHouseBreakageDAL glazeHouseBreakageDAL = new GlazeHouseBreakageDAL();
        //RemarksDAL remarksDAL = new RemarksDAL();
        //ItemDAL itemDAL = new ItemDAL();
        //DALItemStyle styleDAL = new DALItemStyle();
        //ItemSizeDAL sizeDAL = new ItemSizeDAL();
        //ColorDAL colorDAL = new ColorDAL();
        //GlazeStockCompanyDAL glazeStockCompanyDAL = new GlazeStockCompanyDAL();
        List<GlazeHouseBreakage> list;
        Int16 selectedRow = -1;
        List<int> id;
        public frmGlazedItemBreakageShow()
        {
            InitializeComponent();
        }

        private void frmGlazedItemBreakageShow_Load(object sender, EventArgs e)
        {
            gbxUpdate.Enabled = false;
            txtGlazedItemInStock.Enabled = false;
        }

        private void loadDataGrid()
        {
            PersonDAL personDAL = new PersonDAL();
            ItemDAL itemDAL = new ItemDAL();
            DALItemStyle styleDAL = new DALItemStyle();
            ItemSizeDAL sizeDAL = new ItemSizeDAL();
            ColorDAL colorDAL = new ColorDAL();
            
            selectedRow = -1;
            id = new List<int>();
            for (Int16 i = 0; i < list.Count; i++)
            {
                dgvBreakage.Rows.Add();
                id.Add(list[i].SprayManID);
                dgvBreakage.Rows[i].Cells[0].Value = personDAL.getPersonName(list[i].SprayManID);
                dgvBreakage.Rows[i].Cells[1].Value = itemDAL.getItemName(list[i].ItemID);
                dgvBreakage.Rows[i].Cells[2].Value = styleDAL.getItemStyleName(list[i].StyleID);
                dgvBreakage.Rows[i].Cells[3].Value = sizeDAL.getItemSizeName(list[i].SizeID);
                dgvBreakage.Rows[i].Cells[4].Value = colorDAL.getColorName(list[i].ColorID);
                dgvBreakage.Rows[i].Cells[5].Value = list[i].Quantity;
                dgvBreakage.Rows[i].Cells[6].Value = list[i].Remarks;
                dgvBreakage.Rows[i].Cells[7].Value = list[i].Date.ToString();
            }
        }

        private void chkbxUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxUpdate.Checked.Equals(true))
            {
                gbxUpdate.Enabled = true;
            }
            else if (chkbxUpdate.Checked.Equals(false))
            {
                gbxUpdate.Enabled = false;
                emptyTextBoxes();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First select record...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (txtUpdateQuantity.Text == "")
                {
                    MessageBox.Show("Enter updated quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(txtUpdateQuantity.Text) > Convert.ToInt32(txtGlazedItemInStock.Text) + Convert.ToInt32(txtQuantity.Text))
                {
                    MessageBox.Show("Entered quantity is greater than available stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GlazeHouseBreakageDAL glazeHouseBreakageDAL = new GlazeHouseBreakageDAL();
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    ColorDAL colorDAL = new ColorDAL();
                    GlazeStockCompanyDAL glazeStockCompanyDAL = new GlazeStockCompanyDAL();

                    GlazeHouseBreakage obj = new GlazeHouseBreakage();
                    //=======================================================================================================
                    obj.SprayManID = id[selectedRow];
                    obj.ItemID = itemDAL.getItemID(txtItem.Text);
                    obj.StyleID = styleDAL.getStyleID(txtStyle.Text);
                    obj.SizeID = sizeDAL.getSizeID(txtSize.Text);
                    obj.ColorID = colorDAL.getColorID(txtColor.Text);
                    obj.Quantity = Convert.ToInt16(txtUpdateQuantity.Text);
                    obj.Remarks = txtRemarks.Text;
                    obj.Date = Convert.ToDateTime(txtDate.Text);
                    glazeHouseBreakageDAL.updateGlazingReport(obj);
                    MessageBox.Show("Item breakage report has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //=======================================================================================================
                    //=====Update the glazed item stock=====//delete the selected record and add the updated record where the date remain the same...
                    GlazeStockCompany objStock = new GlazeStockCompany();
                    objStock.ItemID = obj.ItemID;
                    objStock.StyleID = obj.StyleID;
                    objStock.SizeID = obj.SizeID;
                    objStock.ColorID = obj.ColorID;
                    objStock.Quantity = glazeStockCompanyDAL.getStockByObject(objStock) + Convert.ToInt16(txtQuantity.Text) - Convert.ToInt16(txtUpdateQuantity.Text);
                    glazeStockCompanyDAL.updateStock(objStock);
                    MessageBox.Show("Glazed Stock Updated ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //=======================================================================================================
                    selectedRow = -1;
                    emptyTextBoxes();
                    showCall();
                    //=======================================================================================================
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void showCall()
        {
            try
            {
                GlazeHouseBreakageDAL glazeHouseBreakageDAL = new GlazeHouseBreakageDAL();
                
                list = new List<GlazeHouseBreakage>();
                dgvBreakage.Rows.Clear();

                if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false) && rbtnYear.Checked.Equals(false))
                {
                    MessageBox.Show("Please select some critaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //===============================
                else if (rbtnDay.Checked.Equals(true))
                {


                    list = glazeHouseBreakageDAL.getReportByDay(dtpGlazeHouse.Value);
                    if (list.Count.Equals(0))
                    {
                        MessageBox.Show("No record found... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        list.TrimExcess();
                        loadDataGrid();
                    }
                }
                else if (rbtnMonth.Checked.Equals(true))
                {
                    list = glazeHouseBreakageDAL.getReportByMonth(dtpGlazeHouse.Value);
                    if (list.Count.Equals(0))
                    {
                        MessageBox.Show("No record found... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        list.TrimExcess();
                        loadDataGrid();
                    }
                }
                else if (rbtnYear.Checked.Equals(true))
                {
                    list = glazeHouseBreakageDAL.getReportByYear(dtpGlazeHouse.Value);
                    if (list.Count.Equals(0))
                    {
                        MessageBox.Show("No record found... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        list.TrimExcess();
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
            showCall();
        }
        //==========================================================================
        private void emptyTextBoxes()
        {
            txtSprayMans.Text = "";
            txtItem.Text = "";
            txtStyle.Text = "";
            txtSize.Text = "";
            txtColor.Text = "";
            txtQuantity.Text = "";
            txtDate.Text = "";
            txtRemarks.Text = "";
            txtUpdateQuantity.Text = "";
            txtGlazedItemInStock.Text = "";
        }
        //=============================================================================
        private void dgvBreakage_CellClick(object sender, DataGridViewCellEventArgs e)
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
        //==============================================================================
        private void populateTextFields()
        {
            ItemDAL itemDAL = new ItemDAL();
            DALItemStyle styleDAL = new DALItemStyle();
            ItemSizeDAL sizeDAL = new ItemSizeDAL();
            ColorDAL colorDAL = new ColorDAL();
            GlazeStockCompanyDAL glazeStockCompanyDAL = new GlazeStockCompanyDAL();

            txtSprayMans.Text = dgvBreakage.Rows[selectedRow].Cells[0].Value.ToString();
            txtItem.Text = dgvBreakage.Rows[selectedRow].Cells[1].Value.ToString();
            txtStyle.Text = dgvBreakage.Rows[selectedRow].Cells[2].Value.ToString();
            txtSize.Text = dgvBreakage.Rows[selectedRow].Cells[3].Value.ToString();
            txtColor.Text = dgvBreakage.Rows[selectedRow].Cells[4].Value.ToString();
            txtQuantity.Text = dgvBreakage.Rows[selectedRow].Cells[5].Value.ToString();
            txtRemarks.Text = dgvBreakage.Rows[selectedRow].Cells[6].Value.ToString();
            txtDate.Text = dgvBreakage.Rows[selectedRow].Cells[7].Value.ToString();
            //-----populate glazed item stock feild
            GlazeStockCompany g = new GlazeStockCompany();
            g.ItemID = itemDAL.getItemID(txtItem.Text);
            g.StyleID = styleDAL.getStyleID(txtStyle.Text);
            g.SizeID = sizeDAL.getSizeID(txtSize.Text);
            g.ColorID = colorDAL.getColorID(txtColor.Text);
            txtGlazedItemInStock.Text = glazeStockCompanyDAL.getStockByObject(g).ToString();
            //-------------------------------------
        }
        //==================================================================================
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
        //==============================================================================
        private void deleteSelectedRecord()
        {
            try
            {
                GlazeHouseBreakageDAL glazeHouseBreakageDAL = new GlazeHouseBreakageDAL();
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                ColorDAL colorDAL = new ColorDAL();
                GlazeStockCompanyDAL glazeStockCompanyDAL = new GlazeStockCompanyDAL();

                GlazeHouseBreakage obj = new GlazeHouseBreakage();
                //=======================================================================================================
                obj.SprayManID = id[selectedRow];
                obj.ItemID = itemDAL.getItemID(txtItem.Text);
                obj.StyleID = styleDAL.getStyleID(txtStyle.Text);
                obj.SizeID = sizeDAL.getSizeID(txtSize.Text);
                obj.ColorID = colorDAL.getColorID(txtColor.Text);
                obj.Quantity = Convert.ToInt16(txtQuantity.Text);
                obj.Remarks = txtRemarks.Text;
                obj.Date = Convert.ToDateTime(txtDate.Text);
                //=======================================================================================================
                glazeHouseBreakageDAL.deleteGlazingReport(obj);
                MessageBox.Show("Breakage report has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //=======================================================================================================
                //=======================================================================================================
                //=====delete from glazed item stock=====//
                //=====Update the glazed item stock=====//delete the selected record and add the updated record where the date remain the same...
                GlazeStockCompany objStock = new GlazeStockCompany();
                objStock.ItemID = obj.ItemID;
                objStock.StyleID = obj.StyleID;
                objStock.SizeID = obj.SizeID;
                objStock.ColorID = obj.ColorID;
                objStock.Quantity = glazeStockCompanyDAL.getStockByObject(objStock) + Convert.ToInt32(txtQuantity.Text);
                glazeStockCompanyDAL.updateStock(objStock);
                MessageBox.Show("Glazed item stock has been updated... ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //=======================================================================================================
                emptyTextBoxes();
                dgvBreakage.Rows.RemoveAt(selectedRow);
                selectedRow = -1;
                //=======================================================================================================
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----report object
        rptFrmGlazedItemBreakage report;
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
                        report = new rptFrmGlazedItemBreakage();
                        //report.TopLevel = false;
                        //report.Dock = DockStyle.Fill;
                        //this.Parent.Controls.Add(report);
                        report.Show();

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
        //==============================================================================
    }
}
