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
    public partial class frmUnglazeItemBreakageShow : Form
    {
        //PersonDAL personDAL = new PersonDAL();
        //ItemDAL itemDAL = new ItemDAL();
        //DALItemStyle styleDAL = new DALItemStyle();
        //ItemSizeDAL sizeDAL = new ItemSizeDAL();

        List<GreenWareHouseBreakage> list;
        List<int> id;
        int selectedRow = -1;
       
        public frmUnglazeItemBreakageShow()
        {
            InitializeComponent();
        }

        private void frmUnglazeItemBreakageShow_Load(object sender, EventArgs e)
        {
            gbxUpdate.Enabled = false;
        }
        //==========================================================================
        private void emptyTextBoxes()
        {
            txtCaster.Text = "";
            txtItem.Text = "";
            txtStyle.Text = "";
            txtSize.Text = "";
            txtQuantity.Text = "";
            txtBreakageType.Text = "";
            txtDate.Text = "";
            txtRemarks.Text = "";
            txtUpdateQuantity.Text = "";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                GreenWareHouseBreakageDAL dal = new GreenWareHouseBreakageDAL();
                if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false) && rbtnYear.Checked.Equals(false))
                {
                    MessageBox.Show("Please select some critaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (rbtnDay.Checked.Equals(true))
                {
                    selectedRow = -1;
                    dgvBreakages.Rows.Clear();

                    list = new List<GreenWareHouseBreakage>();
                    list = dal.getReportByDate(dtpGlazeHouse.Value);
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
                    selectedRow = -1;
                    dgvBreakages.Rows.Clear();

                    list = new List<GreenWareHouseBreakage>();
                    list = dal.getMonthlyReport(dtpGlazeHouse.Value);
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
                    selectedRow = -1;
                    dgvBreakages.Rows.Clear();

                    list = new List<GreenWareHouseBreakage>();
                    list = dal.getYearlyReport(dtpGlazeHouse.Value);
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
        //=============================================================================
        private void loadDataGrid()
        {
            PersonDAL personDAL = new PersonDAL();
            ItemDAL itemDAL = new ItemDAL();
            DALItemStyle styleDAL = new DALItemStyle();
            ItemSizeDAL sizeDAL = new ItemSizeDAL();

            selectedRow = -1;
            id = new List<int>();
            for (Int16 i = 0; i < list.Count;i++ )
            {
                dgvBreakages.Rows.Add();
                id.Add(list[i].WorkerID);
                dgvBreakages.Rows[i].Cells[0].Value = personDAL.getPersonName(list[i].WorkerID);
                dgvBreakages.Rows[i].Cells[1].Value = itemDAL.getItemName(list[i].ItemID);
                dgvBreakages.Rows[i].Cells[2].Value = styleDAL.getItemStyleName(list[i].StyleID);
                dgvBreakages.Rows[i].Cells[3].Value = sizeDAL.getItemSizeName(list[i].SizeID);
                dgvBreakages.Rows[i].Cells[4].Value = list[i].BreakageType;
                dgvBreakages.Rows[i].Cells[5].Value = list[i].Quantity.ToString();
                dgvBreakages.Rows[i].Cells[6].Value = list[i].Remarks;
                dgvBreakages.Rows[i].Cells[7].Value = list[i].Date.ToString(); 
            }
        }

        private void chkbxUpdates_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxUpdates.Checked.Equals(true))
            {
                gbxUpdate.Enabled = true;
            }
            else if (chkbxUpdates.Checked.Equals(false))
            {
                gbxUpdate.Enabled = false;
                emptyTextBoxes();
            }
        }

        private void dgvBreakages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(selectedRow!=-1)
            {
                if(chkbxUpdates.Checked.Equals(true))
                {
                    txtCaster.Text=dgvBreakages.Rows[selectedRow].Cells[0].Value.ToString();
                    txtItem.Text=dgvBreakages.Rows[selectedRow].Cells[1].Value.ToString();
                    txtStyle.Text=dgvBreakages.Rows[selectedRow].Cells[2].Value.ToString();
                    txtSize.Text=dgvBreakages.Rows[selectedRow].Cells[3].Value.ToString();
                    txtBreakageType.Text=dgvBreakages.Rows[selectedRow].Cells[4].Value.ToString();
                    txtQuantity.Text=dgvBreakages.Rows[selectedRow].Cells[5].Value.ToString();
                    txtRemarks.Text=dgvBreakages.Rows[selectedRow].Cells[6].Value.ToString();
                    txtDate.Text=dgvBreakages.Rows[selectedRow].Cells[7].Value.ToString();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First select some record...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (txtUpdateQuantity.Text.Equals(""))
                {
                    MessageBox.Show("Enter quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();

                    GreenWareHouseBreakageDAL breakageDAL = new GreenWareHouseBreakageDAL();
                    MoldStockWorkerDAL workerDAL = new MoldStockWorkerDAL();
                    //=====update worker mold stock
                    MoldStockWorker w = new MoldStockWorker();
                    w.WorkerID = id[selectedRow];
                    w.ItemID = itemDAL.getItemID(txtItem.Text);
                    w.StyleID = styleDAL.getStyleID(txtStyle.Text);
                    w.SizeID = sizeDAL.getSizeID(txtSize.Text);
                    w.CastQuantity = Convert.ToInt16((workerDAL.getCastedStock(w) + Convert.ToInt32(txtQuantity.Text)) - Convert.ToInt32(txtUpdateQuantity.Text));
                    w.Quantity = Convert.ToInt16((workerDAL.getFreeStock(w) - Convert.ToInt32(txtQuantity.Text)) + Convert.ToInt32(txtUpdateQuantity.Text));
                    workerDAL.updateStockByCasting(w);
                    //=====end
                    //=====add report
                    GreenWareHouseBreakage g = new GreenWareHouseBreakage();
                    g.WorkerID = w.WorkerID;
                    g.ItemID = w.ItemID;
                    g.StyleID = w.StyleID;
                    g.SizeID = w.SizeID;
                    g.BreakageType = txtBreakageType.Text;
                    g.Quantity = Convert.ToInt16(txtUpdateQuantity.Text);
                    g.Date = DateTime.Today;
                    breakageDAL.updateReport(g);
                    //=====end

                    MessageBox.Show("Worker mold Sstock, and report has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                    MessageBox.Show("First select some record...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();

                    GreenWareHouseBreakageDAL breakageDAL = new GreenWareHouseBreakageDAL();
                    MoldStockWorkerDAL workerDAL = new MoldStockWorkerDAL();
                    //=====update worker mold stock
                    MoldStockWorker w = new MoldStockWorker();
                    w.WorkerID = id[selectedRow];
                    w.ItemID = itemDAL.getItemID(txtItem.Text);
                    w.StyleID = styleDAL.getStyleID(txtStyle.Text);
                    w.SizeID = sizeDAL.getSizeID(txtSize.Text);
                    w.CastQuantity = Convert.ToInt16(workerDAL.getCastedStock(w) + Convert.ToInt16(txtQuantity.Text));
                    w.Quantity = Convert.ToInt16(workerDAL.getFreeStock(w) - Convert.ToInt32(txtQuantity.Text));
                    workerDAL.updateStockByCasting(w);
                    //=====end
                    //=====add report
                    GreenWareHouseBreakage g = new GreenWareHouseBreakage();
                    g.WorkerID = w.WorkerID;
                    g.ItemID = w.ItemID;
                    g.StyleID = w.StyleID;
                    g.SizeID = w.SizeID;
                    g.BreakageType = txtBreakageType.Text;
                    g.Quantity = Convert.ToInt16(txtQuantity.Text);
                    g.Date = DateTime.Today;
                    breakageDAL.deleteReport(g);
                    //=====end
                    dgvBreakages.Rows.RemoveAt(selectedRow);
                    selectedRow = -1;

                    MessageBox.Show("Worker mold Sstock, and report has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       //=====report object
        rptFrmUnglazeItemBreakage report;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false) && rbtnYear.Checked.Equals(false))
                {
                    MessageBox.Show("Select some citaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //if (!this.Parent.Contains(report))
                {
                    report = new rptFrmUnglazeItemBreakage();
                    //report.TopLevel = false;
                    //report.Dock = DockStyle.Fill;
                    //this.Parent.Controls.Add(report);
                    //report.Show();

                    if (rbtnDay.Checked.Equals(true))
                    {
                        report.reportByDate(dtpGlazeHouse.Value);
                        report.BringToFront();
                        report.Show();
                    }
                    else if(rbtnMonth.Checked.Equals(true))
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
                }
                //else
                //{
                //    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
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
    }
}
