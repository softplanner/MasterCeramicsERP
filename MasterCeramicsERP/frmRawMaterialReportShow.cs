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
    public partial class frmRawMaterialReportShow : Form
    {
        //PersonDAL personDAL = new PersonDAL();
        //RawMaterialDAL rawMaterialDAL = new RawMaterialDAL();
        //RawMaterialReportDAL rawMaterialReportDAL=new RawMaterialReportDAL();
        //RawMaterialStockDAL stockDAL = new RawMaterialStockDAL();

        List<RawMaterialReport> list;
        List<int> vendorID=new List<int>();
        int selectedRow = -1;
        public frmRawMaterialReportShow()
        {
            InitializeComponent();
        }
        private void callShow()
        {
            try
            {
                RawMaterialReportDAL rawMaterialReportDAL = new RawMaterialReportDAL();
                
                if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false) && rbtnYear.Checked.Equals(false))
                {
                    MessageBox.Show("Please select some critaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //===============================
                else if (rbtnDay.Checked.Equals(true))
                {
                    list = new List<RawMaterialReport>();
                    dgvReport.Rows.Clear();

                    list = rawMaterialReportDAL.getReportByDate(dtpMold.Value);
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
                    list = new List<RawMaterialReport>();
                    dgvReport.Rows.Clear();
                    list = rawMaterialReportDAL.getReportByMonth(dtpMold.Value);
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
                    list = new List<RawMaterialReport>();
                    dgvReport.Rows.Clear();
                    list = rawMaterialReportDAL.getReportByYear(dtpMold.Value);
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
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            callShow();
        }
            //===============================//
        //==================================================================================
        private void loadDataGrid()
        {
            PersonDAL personDAL = new PersonDAL();
            RawMaterialDAL rawMaterialDAL = new RawMaterialDAL();
            
            for (Int16 i = 0; i < list.Count; i++)
            {
                dgvReport.Rows.Add();
                dgvReport.Rows[i].Cells[0].Value = rawMaterialDAL.getMaterialName(list[i].RMID);
                vendorID.Add(list[i].SupplierID);
                dgvReport.Rows[i].Cells[1].Value = personDAL.getPersonName(list[i].SupplierID);
                dgvReport.Rows[i].Cells[2].Value = list[i].UnitRate.ToString();
                dgvReport.Rows[i].Cells[3].Value = list[i].Quantity.ToString();
                dgvReport.Rows[i].Cells[4].Value = Convert.ToString(list[i].UnitRate * list[i].Quantity);
                dgvReport.Rows[i].Cells[5].Value = list[i].Date.ToShortDateString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtUnitRate.Text = "";
            txtQuantity.Text = "";
        }
        private void emptyTextFeilds() 
        {
            txtVendor.Text = "";
            txtUnitRate.Text = "";
            txtQuantity.Text = "";
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select record...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RawMaterialDAL rawMaterialDAL = new RawMaterialDAL();
                    RawMaterialReportDAL rawMaterialReportDAL = new RawMaterialReportDAL();
                    RawMaterialStockDAL stockDAL = new RawMaterialStockDAL();

                    //=====delete report
                    RawMaterialReport report = new RawMaterialReport();
                    report.RMID = rawMaterialDAL.getMaterialID(dgvReport.Rows[selectedRow].Cells[0].Value.ToString());
                    report.SupplierID = vendorID[selectedRow];
                    report.UnitRate = Convert.ToSingle(dgvReport.Rows[selectedRow].Cells[2].Value);
                    report.Quantity = Convert.ToSingle(dgvReport.Rows[selectedRow].Cells[3].Value.ToString());
                    report.Date = Convert.ToDateTime(dgvReport.Rows[selectedRow].Cells[5].Value);
                    rawMaterialReportDAL.deleteTransaction(report);
                    //=====end
                    if (chkbxDeduct.Checked.Equals(true))
                    {
                        //=====update stock
                        float quantity = stockDAL.getStock(report.RMID) - report.Quantity;
                        stockDAL.updateStock(report.RMID, quantity);
                        //=====
                    }
                    dgvReport.Rows.RemoveAt(selectedRow);
                    emptyTextFeilds();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow != -1)
            {
                txtUnitRate.Text = dgvReport.Rows[selectedRow].Cells[2].Value.ToString();
                txtQuantity.Text = dgvReport.Rows[selectedRow].Cells[3].Value.ToString();
                txtVendor.Text = dgvReport.Rows[selectedRow].Cells[1].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select record...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtQuantity.Text.Equals("") || txtUnitRate.Text.Equals(""))
                {
                    MessageBox.Show("Enter quantity");
                }
                else
                {
                    RawMaterialDAL rawMaterialDAL = new RawMaterialDAL();
                    RawMaterialReportDAL rawMaterialReportDAL = new RawMaterialReportDAL();
                    RawMaterialStockDAL stockDAL = new RawMaterialStockDAL();

                    //=====update the report
                    RawMaterialReport report = new RawMaterialReport();
                    report.RMID = rawMaterialDAL.getMaterialID(dgvReport.Rows[selectedRow].Cells[0].Value.ToString());
                    report.SupplierID = vendorID[selectedRow];
                    report.UnitRate = Convert.ToSingle(txtUnitRate.Text);
                    report.Quantity = Convert.ToSingle(txtQuantity.Text);
                    report.Date = Convert.ToDateTime(dgvReport.Rows[selectedRow].Cells[5].Value);
                    rawMaterialReportDAL.updateReport(report);
                    //=====end
                    //=====update stock
                    float quantity = Convert.ToSingle((stockDAL.getStock(report.RMID) + report.Quantity) - Convert.ToSingle(dgvReport.Rows[selectedRow].Cells[3].Value.ToString()));
                    stockDAL.updateStock(report.RMID, quantity);
                    //=====
                    callShow();
                    //=====end
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //=====report object
        rptFrmRawMaterialReport report;
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
                    //if (!this.Parent.Contains(report))
                    //{
                        report = new rptFrmRawMaterialReport();
                        //report.TopLevel = false;
                        //report.Dock = DockStyle.Fill;
                        //this.Parent.Controls.Add(report);
                        //report.Show();

                        if (rbtnDay.Checked.Equals(true))
                        {
                            report.reportByDate(dtpMold.Value);
                            report.BringToFront();
                            report.Show();
                        }
                        else if (rbtnMonth.Checked.Equals(true))
                        {
                            report.reportByMonth(dtpMold.Value);
                            report.BringToFront();
                            report.Show();
                        }
                        else if (rbtnYear.Checked.Equals(true))
                        {
                            report.reportByYear(dtpMold.Value);
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

        private void txtUnitRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';

            else if ((e.KeyChar < '0') || (e.KeyChar > '9') || e.KeyChar == '.')
            {
                if (e.KeyChar == '.')
                {
                    if (txtUnitRate.Text.Contains("."))
                    {
                    }
                    else
                    {
                        e.KeyChar = '.';
                        return;
                    }
                }
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';

            else if ((e.KeyChar < '0') || (e.KeyChar > '9') || e.KeyChar == '.')
            {
                if (e.KeyChar == '.')
                {
                    if (txtQuantity.Text.Contains("."))
                    {
                    }
                    else
                    {
                        e.KeyChar = '.';
                        return;
                    }
                }
                e.Handled = true;
            }
        }

        private void txtUnitRate_MouseClick(object sender, MouseEventArgs e)
        {
            txtUnitRate.Focus();
        }

        private void txtQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            txtQuantity.Focus();
        }
      //==================================================================================================================
    }
}

