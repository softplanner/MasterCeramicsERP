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
    public partial class frmMoldBreakage : Form
    {
        DataSet dsRemarks = new DataSet();
        DataSet dsJobs = new DataSet();
        DataSet dsWorker = new DataSet();

        List<MoldStockCompany> lstCompanyStock;
        List<MoldStockWorker> lstCasterStock;

        //JobsDAL jobDal = new JobsDAL();
        //RemarksDAL remarksDAL = new RemarksDAL();
        //PersonDAL personDAL = new PersonDAL();
        //ItemDAL itemDAL = new ItemDAL();
        //DALItemStyle styleDAL = new DALItemStyle();
        //ItemSizeDAL sizeDAL = new ItemSizeDAL();
        //MoldStockWorkerDAL moldStockWorkerDAL = new MoldStockWorkerDAL();
        //MoldStockCompanyDAL moldStockCompnayDAL = new MoldStockCompanyDAL();
        //MoldBreakageDAL moldBreakgeDAL = new MoldBreakageDAL();

        int row = -1, selectedRow = -1, companyRow = -1, companySelectedRow = -1;

        public frmMoldBreakage()
        {
            InitializeComponent();
        }

        private void frmMoldBreakage_Load(object sender, EventArgs e)
        {
            populateDGVwithCompanyStock();
            populateJobsCBX();
            populateRemarksDataset();
            txtRemarks.Enabled = false;
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
        private void populateRemarksDataset()
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
        private void populateDGVwithCompanyStock()
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                MoldStockCompanyDAL moldStockCompnayDAL = new MoldStockCompanyDAL();
                
                dgvStock.Rows.Clear();
                companyRow = -1;
                companySelectedRow = -1;
                lstCompanyStock = new List<MoldStockCompany>();
                lstCompanyStock = moldStockCompnayDAL.getStock();
                lstCompanyStock.TrimExcess();
                for (Int16 i = 0; i < lstCompanyStock.Count; i++)
                {
                    companyRow = dgvStock.Rows.Add();
                    dgvStock.Rows[i].Cells[0].Value = itemDAL.getItemName(lstCompanyStock[i].ItemID);
                    dgvStock.Rows[i].Cells[1].Value = styleDAL.getItemStyleName(lstCompanyStock[i].StyleID);
                    dgvStock.Rows[i].Cells[2].Value = sizeDAL.getItemSizeName(lstCompanyStock[i].SizeID);
                    dgvStock.Rows[i].Cells[3].Value = lstCompanyStock[i].Quantity.ToString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private void populateDGVwithCasteryStock()
        //{
        //    try
        //    {
        //        dgvStock.Rows.Clear();
        //        companyRow = -1;
        //        companySelectedRow = -1;
        //        lstCasterStock = new List<MoldStockWorker>();
        //        lstCasterStock = moldStockWorkerDAL.getStockByCaster(Convert.ToInt32(dgvCaster.Rows[casterRow].Cells[0].Value.ToString()));
        //        lstCasterStock.TrimExcess();
        //        for (Int16 i = 0; i < lstCasterStock.Count; i++)
        //        {
        //            companyRow = dgvStock.Rows.Add();
        //            dgvStock.Rows[i].Cells[0].Value = itemDAL.getItemName(lstCasterStock[i].ItemID);
        //            dgvStock.Rows[i].Cells[1].Value = styleDAL.getItemStyleName(lstCasterStock[i].StyleID);
        //            dgvStock.Rows[i].Cells[2].Value = sizeDAL.getItemSizeName(lstCasterStock[i].SizeID);
        //            dgvStock.Rows[i].Cells[3].Value = Convert.ToString(Convert.ToInt32(lstCasterStock[i].Quantity.ToString()) + Convert.ToInt32(lstCasterStock[i].CastQuantity.ToString()));
        //        }
        //    }
        //    catch (Exception exp)
        //    {
        //        MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void rbtnCompany_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rbtnCompany.Checked.Equals(true)) 
        //    {
        //        row = -1;
        //        dgvMoldBreakage.Rows.Clear();
        //        companyRow = -1;
        //        companySelectedRow=-1;
        //        dgvStock.Rows.Clear();
        //        gbxCaster.Enabled= false;
        //        dgvCaster.Rows.Clear();
        //        //casterRow = -1;
        //        dgvCaster.BackgroundColor = Color.DarkGray;
        //        //=====load dgv with company mold stock
        //        populateDGVwithCompanyStock();
                
        //    }
        //}
        private void chkbxAddRemarks_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkbxAddRemarks.Checked.Equals(true))
            {
                txtRemarks.Enabled = true;
                dsRemarks.Clear();
                cbxRemarks.Enabled = false;
                cbxRemarks.Enabled = false;
                lblRemark.Enabled  = false;
            }
            else if (chkbxAddRemarks.Checked.Equals(false))
            {
                txtRemarks.Text = "";
                txtRemarks.Enabled = false;
                populateRemarksDataset();
                cbxRemarks.Enabled = true;
                lblRemark.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(companySelectedRow.Equals(-1))
            {
                MessageBox.Show("First select mold from stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (txtQuantity.Text == "")
            {
                MessageBox.Show("Enter quantity... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Convert.ToInt16(txtQuantity.Text) > Convert.ToInt16 (dgvStock.Rows[companySelectedRow].Cells[3].Value.ToString()))
            {
                MessageBox.Show("Entered value is greater than available stock... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addRowToDataGrid();
                companySelectedRow = -1;
                txtQuantity.Text = "";
            }
        }
        private void addRowToDataGrid()
        {
            for (Int16 i = 0; i <=row; i++)
            {
                if (dgvMoldBreakage.Rows[i].Cells[0].Value.ToString().Equals(dgvStock.Rows[companySelectedRow].Cells[0].Value.ToString()))
                {
                    if (dgvStock.Rows[companySelectedRow].Cells[1].Value.Equals(dgvMoldBreakage.Rows[i].Cells[1].Value))
                    {
                        if (dgvStock.Rows[companySelectedRow].Cells[2].Value.Equals(dgvMoldBreakage.Rows[i].Cells[2].Value))
                        {
                            dgvMoldBreakage.Rows[i].Cells[3].Value = Convert.ToString(Convert.ToInt32(dgvMoldBreakage.Rows[i].Cells[3].Value.ToString()) + Convert.ToInt32(txtQuantity.Text));
                            dgvStock.Rows[companySelectedRow].Cells[3].Value = Convert.ToString(Convert.ToInt32(dgvStock.Rows[companySelectedRow].Cells[3].Value.ToString()) - Convert.ToInt32(txtQuantity.Text));
                            return;
                        }
                    }
                }
            }
            
            //////------Show record in the data grid view------//////
            row = Convert.ToInt16(dgvMoldBreakage.Rows.Add());
            //MessageBox.Show(row.ToString());
            dgvMoldBreakage.Rows[row].Cells[0].Value = dgvStock.Rows[companySelectedRow].Cells[0].Value;
            dgvMoldBreakage.Rows[row].Cells[1].Value = dgvStock.Rows[companySelectedRow].Cells[1].Value;
            dgvMoldBreakage.Rows[row].Cells[2].Value = dgvStock.Rows[companySelectedRow].Cells[2].Value;
            dgvMoldBreakage.Rows[row].Cells[3].Value = txtQuantity.Text;
            dgvStock.Rows[companySelectedRow].Cells[3].Value = Convert.ToString(Convert.ToInt32(dgvStock.Rows[companySelectedRow].Cells[3].Value.ToString()) - Convert.ToInt32(txtQuantity.Text));
            if (chkbxAddRemarks.Checked.Equals(true))
            {
                if (txtRemarks.Text.Equals(""))
                {
                    txtRemarks.Text = "No Remarks";
                }
                else
                {
                    dgvMoldBreakage.Rows[row].Cells[4].Value = txtRemarks.Text;
                }
            }
            else
            {
                dgvMoldBreakage.Rows[row].Cells[4].Value = cbxRemarks.Text;
            }
            ////------End show record in the data grid view------////
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            companySelectedRow = e.RowIndex;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = "";
            if (chkbxAddRemarks.Checked.Equals(true))
            {
                txtRemarks.Text = "";
            }
            //if (rbtnCompany.Checked.Equals(true))
            //{
            //    dgvStock.Rows.Clear();
            //    populateDGVwithCompanyStock();
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("No record found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (Int16 i = 0; i <= companyRow; i++)
                    {
                        if (dgvMoldBreakage.Rows[selectedRow].Cells[0].Value.Equals(dgvStock.Rows[i].Cells[0].Value))
                        {
                            if (dgvStock.Rows[i].Cells[1].Value.Equals(dgvMoldBreakage.Rows[selectedRow].Cells[1].Value))
                            {
                                if (dgvStock.Rows[i].Cells[2].Value.Equals(dgvMoldBreakage.Rows[selectedRow].Cells[2].Value))
                                {
                                    dgvStock.Rows[i].Cells[3].Value = Convert.ToString(Convert.ToInt32(dgvStock.Rows[i].Cells[3].Value.ToString()) + Convert.ToInt32(dgvMoldBreakage.Rows[selectedRow].Cells[3].Value.ToString()));
                                    dgvMoldBreakage.Rows.RemoveAt(selectedRow);
                                    selectedRow = -1;
                                    row--;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvMoldBreakage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void btnAddDB_Click(object sender, EventArgs e)
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                MoldStockCompanyDAL moldStockCompnayDAL = new MoldStockCompanyDAL();
                MoldBreakageDAL moldBreakgeDAL = new MoldBreakageDAL();

                if (row.Equals(-1))
                {
                    MessageBox.Show("No record found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //if (rbtnCompany.Checked.Equals(true))
                    //{
                        //=====update the mold stock company
                        MoldStockCompany m;
                        for (Int16 i = 0; i <= companyRow; i++)
                        {
                            m = new MoldStockCompany();
                            m.ItemID = itemDAL.getItemID(dgvStock.Rows[i].Cells[0].Value.ToString());
                            m.StyleID = styleDAL.getStyleID(dgvStock.Rows[i].Cells[1].Value.ToString());
                            m.SizeID = sizeDAL.getSizeID(dgvStock.Rows[i].Cells[2].Value.ToString());
                            m.Quantity = Convert.ToInt16(dgvStock.Rows[i].Cells[3].Value.ToString());
                            moldStockCompnayDAL.updateStock(m);
                        }
                        MessageBox.Show("Company mold stock has been update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //=====end
                    //}
                    //else if (rbtnWorker.Checked.Equals(true))
                    //{
                    //    //=====update the mold stock caster
                    //    MoldStockWorker m;
                    //    for (Int16 i = 0; i <= companyRow; i++)
                    //    {
                    //        m = new MoldStockWorker();
                    //        m.WorkerID = Convert.ToInt32(dgvCaster.Rows[casterRow].Cells[0].Value.ToString());
                    //        m.ItemID = itemDAL.getItemID(dgvStock.Rows[i].Cells[0].Value.ToString());
                    //        m.StyleID = styleDAL.getStyleID(dgvStock.Rows[i].Cells[1].Value.ToString());
                    //        m.SizeID = sizeDAL.getSizeID(dgvStock.Rows[i].Cells[2].Value.ToString());
                    //        m.Quantity = Convert.ToInt16(dgvStock.Rows[i].Cells[3].Value.ToString());
                    //        moldStockWorkerDAL.updateStock(m);
                    //    }
                    //    MessageBox.Show("Worker mold stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    //=====end
                    //}
                    //=====add breakage report
                    MoldBreakage b;
                    for (Int16 j = 0; j <= row; j++)
                    {
                        b = new MoldBreakage();
                        b.WorkerID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                        b.ItemID = itemDAL.getItemID(dgvMoldBreakage.Rows[j].Cells[0].Value.ToString());
                        b.StyleID = styleDAL.getStyleID(dgvMoldBreakage.Rows[j].Cells[1].Value.ToString());
                        b.SizeID = sizeDAL.getSizeID(dgvMoldBreakage.Rows[j].Cells[2].Value.ToString());
                        b.Quantity = Convert.ToInt16(dgvMoldBreakage.Rows[j].Cells[3].Value.ToString());
                        b.Remarks = dgvMoldBreakage.Rows[j].Cells[4].Value.ToString();
                        b.Date = DateTime.Now;
                        moldBreakgeDAL.addCompanyReport(b);
                        //if (rbtnCompany.Checked.Equals(true))
                        //{
                            //b.MoldContainer = "Company";
                            //b.WorkerID = 1;
                            //moldBreakgeDAL.addWorkerReport(b);
                        //}
                        //else if (rbtnWorker.Checked.Equals(true))
                        //{
                        //    b.WorkerID = Convert.ToInt32(dgvCaster.Rows[casterRow].Cells[0].Value.ToString());
                        //    b.MoldContainer = "Caster";
                        //    moldBreakgeDAL.addWorkerReport(b);
                        //}
                    }
                    MessageBox.Show("Mold breakage report has been added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //=====end
                    dgvMoldBreakage.Rows.Clear();
                    row = selectedRow = -1;
                    companyRow = companySelectedRow = -1;
                    txtQuantity.Text = "";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnIncreaseStock_Click(object sender, EventArgs e)
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                MoldStockCompanyDAL moldStockCompnayDAL = new MoldStockCompanyDAL();
                
                if (row >= 0)
                {
                    MessageBox.Show("Cannot increase mold quantity untill breakage report updated...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (companyRow.Equals(-1))
                {
                    MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtQuantity.Text.Equals(""))
                {
                    MessageBox.Show("Enter increase quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //if (rbtnCompany.Checked.Equals(true))
                    //{
                        //=====update the mold stock company
                        MoldStockCompany c;
                        c = new MoldStockCompany();
                        c.ItemID = itemDAL.getItemID(dgvStock.Rows[companySelectedRow].Cells[0].Value.ToString());
                        c.StyleID = styleDAL.getStyleID(dgvStock.Rows[companySelectedRow].Cells[1].Value.ToString());
                        c.SizeID = sizeDAL.getSizeID(dgvStock.Rows[companySelectedRow].Cells[2].Value.ToString());
                        c.Quantity = Convert.ToInt16(Convert.ToInt16(dgvStock.Rows[companySelectedRow].Cells[3].Value.ToString()) + Convert.ToInt16(txtQuantity.Text));
                        moldStockCompnayDAL.updateStock(c);
                        MessageBox.Show("Company mold stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        populateDGVwithCompanyStock();
                        //=====end
                    //}
                    //else if (rbtnWorker.Checked.Equals(true))
                    //{
                    //    //=====update the mold stock caster
                    //    MoldStockWorker m;
                    //    m = new MoldStockWorker();
                    //    m.WorkerID = Convert.ToInt32(dgvCaster.Rows[casterRow].Cells[0].Value.ToString());
                    //    m.ItemID = itemDAL.getItemID(dgvStock.Rows[companySelectedRow].Cells[0].Value.ToString());
                    //    m.StyleID = styleDAL.getStyleID(dgvStock.Rows[companySelectedRow].Cells[1].Value.ToString());
                    //    m.SizeID = sizeDAL.getSizeID(dgvStock.Rows[companySelectedRow].Cells[2].Value.ToString());
                    //    m.Quantity = Convert.ToInt16(Convert.ToInt16(dgvStock.Rows[companySelectedRow].Cells[3].Value.ToString()) + Convert.ToInt16(txtQuantity.Text));
                    //    moldStockWorkerDAL.updateStock(m);
                    //    MessageBox.Show("Caster mold stock has been update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    populateDGVwithCasteryStock();
                    //}
                    //=====end
                    txtQuantity.Text = "";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                MoldStockCompanyDAL moldStockCompnayDAL = new MoldStockCompanyDAL();
                
                if (row >= 0)
                {
                    MessageBox.Show("Cannot decrease mold quantity untill breakage report has been update...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (companyRow.Equals(-1))
                {
                    MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtQuantity.Text.Equals(""))
                {
                    MessageBox.Show("Enter decrease quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //if (rbtnCompany.Checked.Equals(true))
                    //{
                        //=====update the mold stock company
                        MoldStockCompany c;
                        c = new MoldStockCompany();
                        c.ItemID = itemDAL.getItemID(dgvStock.Rows[companySelectedRow].Cells[0].Value.ToString());
                        c.StyleID = styleDAL.getStyleID(dgvStock.Rows[companySelectedRow].Cells[1].Value.ToString());
                        c.SizeID = sizeDAL.getSizeID(dgvStock.Rows[companySelectedRow].Cells[2].Value.ToString());
                        c.Quantity = Convert.ToInt16(Convert.ToInt16(dgvStock.Rows[companySelectedRow].Cells[3].Value.ToString()) - Convert.ToInt16(txtQuantity.Text));
                        moldStockCompnayDAL.updateStock(c);
                        //=====end
                    //}
                    //else if (rbtnWorker.Checked.Equals(true))
                    //{
                    //    //=====update the mold stock caster
                    //    MoldStockWorker m;
                    //    m = new MoldStockWorker();
                    //    m.WorkerID = Convert.ToInt32(dgvCaster.Rows[casterRow].Cells[0].Value.ToString());
                    //    m.ItemID = itemDAL.getItemID(dgvStock.Rows[companySelectedRow].Cells[0].Value.ToString());
                    //    m.StyleID = styleDAL.getStyleID(dgvStock.Rows[companySelectedRow].Cells[1].Value.ToString());
                    //    m.SizeID = sizeDAL.getSizeID(dgvStock.Rows[companySelectedRow].Cells[2].Value.ToString());
                    //    m.Quantity = Convert.ToInt16(Convert.ToInt16(dgvStock.Rows[companySelectedRow].Cells[3].Value.ToString()) - Convert.ToInt16(txtQuantity.Text));
                    //    moldStockWorkerDAL.updateStock(m);
                    //}
                    //=====end
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void dgvCaster_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //casterRow = e.RowIndex;
        //    //======================
        //    if (rbtnCompany.Checked.Equals(false) && rbtnWorker.Checked.Equals(false))
        //    {
        //        MessageBox.Show("Select some critaria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else if (rbtnCompany.Checked.Equals(true))
        //    {
        //        dgvMoldBreakage.Rows.Clear();
        //        row = -1;
        //        selectedRow = -1;

        //        populateDGVwithCompanyStock();
        //    }
        //    else
        //    {
        //        dgvMoldBreakage.Rows.Clear();
        //        row = -1;
        //        selectedRow = -1;

        //        populateDGVwithCasteryStock();
        //    }
        //}

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

        private void txtRemarks_MouseClick(object sender, MouseEventArgs e)
        {
            txtRemarks.Focus();
        }

        private void cbxSelectJob_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                JobsDAL jobDal = new JobsDAL();
                PersonDAL personDAL = new PersonDAL();
                
                //if (row >= 0)
                //{
                //    returnToStockComplete();
                //    dgvMold.Rows.Clear();
                //    row = selectedRow = -1;
                //}
                if (row >= 0)
                {
                    dgvMoldBreakage.Rows.Clear();
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
            if(row>=0)
            {
                dgvMoldBreakage.Rows.Clear();
                row = selectedRow = -1;
            }
            //if (rbtnCompany.Checked.Equals(false) && rbtnWorker.Checked.Equals(false))
            //{
            //    MessageBox.Show("Select some critaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (rbtnCompany.Checked.Equals(true))
            //{
            //    dgvMoldBreakage.Rows.Clear();
            //    row = -1;
            //    selectedRow = -1;

            //    populateDGVwithCompanyStock();
            //}
            //else
            //{
            //    dgvMoldBreakage.Rows.Clear();
            //    row = -1;
            //    selectedRow = -1;

            //    populateDGVwithCasteryStock();
            //}

        }
        //=========================================================================================================
    }
}
