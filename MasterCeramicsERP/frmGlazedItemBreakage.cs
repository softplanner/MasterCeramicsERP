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
    public partial class frmGlazedItemBreakage : Form
    {
        DataSet dsGlazeHouse = new DataSet();
        DataSet dsWorker = new DataSet();
        DataSet dsRemarks = new DataSet();
        DataSet dsJobs = new DataSet();

        //JobsDAL jobDal = new JobsDAL();
        //GlazeHouseDAL glazeHouseDAL = new GlazeHouseDAL();
        //PersonDAL personDAL = new PersonDAL();
        //ItemDAL itemDAL = new ItemDAL();
        //DALItemStyle styleDAL = new DALItemStyle();
        //ItemSizeDAL sizeDAL = new ItemSizeDAL();
        //ColorDAL colorDAL = new ColorDAL();
        //RemarksDAL remarksDAL = new RemarksDAL();

        Int16 row = -1, selectedRow = -1,glazedRow=-1,glazedSelectedRow=-1;
        
        public frmGlazedItemBreakage()
        {
            InitializeComponent();
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
        private void frmGlazedItemBreakage_Load(object sender, EventArgs e)
        {
            populateJobsCBX();
            loadGlazedStockDGV();
            txtRemarks.Enabled = false;
            populateRemarks();
        }
        private void loadGlazedStockDGV()
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                ColorDAL colorDAL = new ColorDAL();
                
                GlazeStockCompanyDAL dal = new GlazeStockCompanyDAL();
                List<GlazeStockCompany> lst = new List<GlazeStockCompany>();
                dgvGlazedStock.Rows.Clear();
                glazedSelectedRow = -1;
                glazedRow = -1;
                lst = dal.getAllStockList();
                lst.TrimExcess();
                for (Int16 i = 0; i < lst.Count; i++)
                {
                    glazedRow = Convert.ToInt16(dgvGlazedStock.Rows.Add());
                    dgvGlazedStock.Rows[i].Cells[0].Value = itemDAL.getItemName(lst[i].ItemID);
                    dgvGlazedStock.Rows[i].Cells[1].Value = styleDAL.getItemStyleName(lst[i].StyleID);
                    dgvGlazedStock.Rows[i].Cells[2].Value = sizeDAL.getItemSizeName(lst[i].SizeID);
                    dgvGlazedStock.Rows[i].Cells[3].Value = colorDAL.getColorName(lst[i].ColorID);
                    dgvGlazedStock.Rows[i].Cells[4].Value = lst[i].Quantity;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void populateRemarks()
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

        private void chkbxAddRemarks_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxAddRemarks.Checked.Equals(true))
            {
                cbxRemarks.Enabled = false;
                txtRemarks.Enabled = true;
            }
            else if(chkbxAddRemarks.Checked.Equals(false))
            {
                txtRemarks.Text = "";
                txtRemarks.Enabled = false;
                cbxRemarks.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (glazedSelectedRow.Equals(-1))
                {
                    MessageBox.Show("First select item...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (txtQuantity.Text == "")
                {
                    MessageBox.Show("Enter quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt16(txtQuantity.Text) > Convert.ToInt16(dgvGlazedStock.Rows[glazedSelectedRow].Cells[4].Value.ToString()))
                {
                    MessageBox.Show("Entered quantity is greater than stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    addRowToDataGrid();
                    dgvGlazedStock.Rows[glazedSelectedRow].Cells[4].Value = Convert.ToString(Convert.ToInt16(dgvGlazedStock.Rows[glazedSelectedRow].Cells[4].Value) - Convert.ToInt16(txtQuantity.Text));
                    glazedSelectedRow = -1;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addRowToDataGrid()
        {
            try
            {
                for (Int16 i = 0; i <= row; i++)
                {
                    //if (dgvItemBreakage.Rows[i].Cells[0].Value.Equals(cbxWorker.Text))
                    //{
                    if (dgvItemBreakage.Rows[i].Cells[0].Value.Equals(dgvGlazedStock.Rows[glazedSelectedRow].Cells[0].Value))
                    {
                        if (dgvItemBreakage.Rows[i].Cells[1].Value.Equals(dgvGlazedStock.Rows[glazedSelectedRow].Cells[1].Value))
                        {
                            if (dgvItemBreakage.Rows[i].Cells[2].Value.Equals(dgvGlazedStock.Rows[glazedSelectedRow].Cells[2].Value))
                            {
                                if (dgvItemBreakage.Rows[i].Cells[3].Value.Equals(dgvGlazedStock.Rows[glazedSelectedRow].Cells[3].Value))
                                {
                                    dgvItemBreakage.Rows[i].Cells[4].Value = Convert.ToString(Convert.ToInt16(dgvItemBreakage.Rows[i].Cells[4].Value.ToString()) + Convert.ToInt16(txtQuantity.Text));
                                    return;
                                }

                            }

                        }

                    }
                    //}
                }
                //////------Show record in the data grid view------//////
                row = Convert.ToInt16(dgvItemBreakage.Rows.Add());
                //MessageBox.Show(row.ToString());
                //dgvItemBreakage.Rows[row].Cells[0].Value = cbxWorker.Text;
                dgvItemBreakage.Rows[row].Cells[0].Value = dgvGlazedStock.Rows[glazedSelectedRow].Cells[0].Value.ToString();
                dgvItemBreakage.Rows[row].Cells[1].Value = dgvGlazedStock.Rows[glazedSelectedRow].Cells[1].Value.ToString();
                dgvItemBreakage.Rows[row].Cells[2].Value = dgvGlazedStock.Rows[glazedSelectedRow].Cells[2].Value.ToString();
                dgvItemBreakage.Rows[row].Cells[3].Value = dgvGlazedStock.Rows[glazedSelectedRow].Cells[3].Value.ToString();
                dgvItemBreakage.Rows[row].Cells[4].Value = txtQuantity.Text;
                if (chkbxAddRemarks.Checked.Equals(true))
                {
                    dgvItemBreakage.Rows[row].Cells[5].Value = txtRemarks.Text;
                }
                else
                {
                    dgvItemBreakage.Rows[row].Cells[5].Value = cbxRemarks.Text;
                }
                ////------End show record in the data grid view------////
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateRemarks();
            txtRemarks.Text = "";
            txtQuantity.Text = "";
        }

        private void btnAddDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (row == -1)
                {
                    MessageBox.Show("No record found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    ColorDAL colorDAL = new ColorDAL();
                    
                    GlazeHouseBreakage g = new GlazeHouseBreakage();
                    GlazeHouseBreakageDAL b = new GlazeHouseBreakageDAL();
                    GlazeStockCompany companyGlazestock = new GlazeStockCompany();
                    GlazeStockCompanyDAL companyGlazedStockDAL = new GlazeStockCompanyDAL();
                    for (Int16 i = 0; i <= row; i++)
                    {
                        //================================
                        g.SprayManID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                        g.ItemID = itemDAL.getItemID(dgvItemBreakage.Rows[i].Cells[0].Value.ToString());
                        g.StyleID = styleDAL.getStyleID(dgvItemBreakage.Rows[i].Cells[1].Value.ToString());
                        g.SizeID = sizeDAL.getSizeID(dgvItemBreakage.Rows[i].Cells[2].Value.ToString());
                        g.ColorID = colorDAL.getColorID(dgvItemBreakage.Rows[i].Cells[3].Value.ToString());
                        g.Quantity = Convert.ToInt16(dgvItemBreakage.Rows[i].Cells[4].Value);
                        g.Remarks = dgvItemBreakage.Rows[i].Cells[5].Value.ToString();
                        g.Date = DateTime.Now;
                        //=====Add to glaze house breakage
                        if (b.checkIsReportExist(g).Equals(true))
                        {
                            g.Quantity = Convert.ToInt16(g.Quantity + b.getCurrentReportStock(g));
                            b.updateGlazingReport(g);
                        }
                        else
                        {
                            b.addReport(g);
                        }
                    }
                    for (Int16 i = 0; i <= glazedRow; i++)
                    {
                        //================================update glazed Stock
                        companyGlazestock = new GlazeStockCompany();
                        companyGlazestock.ItemID = itemDAL.getItemID(dgvGlazedStock.Rows[i].Cells[0].Value.ToString());
                        companyGlazestock.StyleID = styleDAL.getStyleID(dgvGlazedStock.Rows[i].Cells[1].Value.ToString()); ;
                        companyGlazestock.SizeID = sizeDAL.getSizeID(dgvGlazedStock.Rows[i].Cells[2].Value.ToString()); ;
                        companyGlazestock.ColorID = colorDAL.getColorID(dgvGlazedStock.Rows[i].Cells[3].Value.ToString()); ;
                        companyGlazestock.Quantity = Convert.ToInt32(dgvGlazedStock.Rows[i].Cells[4].Value.ToString());
                        companyGlazedStockDAL.updateStock(companyGlazestock);
                    }
                    MessageBox.Show("Breakage information has been recorded...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Glazed item stock has been update... ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvItemBreakage.Rows.Clear();
                row = -1;
                txtQuantity.Text = "";
                txtRemarks.Text = "";
                //loadGlazedStockDGV();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvItemBreakage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow =Convert.ToInt16(e.RowIndex);
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow == -1)
                {
                    MessageBox.Show("First select record...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (Int16 i = 0; i <= glazedRow; i++)
                    {
                        if (dgvGlazedStock.Rows[i].Cells[0].Value.Equals(dgvItemBreakage.Rows[selectedRow].Cells[0].Value))
                        {
                            if (dgvGlazedStock.Rows[i].Cells[1].Value.Equals(dgvItemBreakage.Rows[selectedRow].Cells[1].Value))
                            {
                                if (dgvGlazedStock.Rows[i].Cells[2].Value.Equals(dgvItemBreakage.Rows[selectedRow].Cells[2].Value))
                                {
                                    if (dgvGlazedStock.Rows[i].Cells[3].Value.Equals(dgvItemBreakage.Rows[selectedRow].Cells[3].Value))
                                    {
                                        dgvGlazedStock.Rows[i].Cells[4].Value = Convert.ToString(Convert.ToInt32(dgvGlazedStock.Rows[i].Cells[4].Value.ToString()) + Convert.ToInt32(dgvItemBreakage.Rows[selectedRow].Cells[4].Value.ToString()));
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    dgvItemBreakage.Rows.RemoveAt(selectedRow);
                    selectedRow = -1;
                    row--;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGlazedStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            glazedSelectedRow = Convert.ToInt16(e.RowIndex);
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

        private void cbxSelectJob_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                JobsDAL jobDal = new JobsDAL();
                PersonDAL personDAL = new PersonDAL();
                
                if (row >= 0)
                {
                    dgvItemBreakage.Rows.Clear();
                    row = selectedRow = -1;
                }
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

        private void cbxWorker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (row >= 0)
            {
                dgvItemBreakage.Rows.Clear();
                row = selectedRow = -1;
            }
        }
    }
}
