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
    public partial class frmGreenWareWorkerStock : Form
    {
        DataSet dsItemStyle = new DataSet();
        DataSet dsItemSize = new DataSet();
        DataSet dsItem = new DataSet();
        DataSet dsJobs = new DataSet();
        DataSet dsWorker = new DataSet();
        DataSet dsCaster = new DataSet();

        Int16 selectedRow=-1;
        
        public frmGreenWareWorkerStock()
        {
            InitializeComponent();
        }

        private void frmGreenWareWorkerStock_Load(object sender, EventArgs e)
        {
            populateComboBoxes();
            populateJobsCBX();
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
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void populateComboBoxes()
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                
                //populate cbx With All Item
                dsItem.Clear();
                dsItem = itemDAL.getAllItem();
                cbxItem.DataSource = dsItem.Tables[0];
                cbxItem.DisplayMember = "Name";
                //end populate

                //populate cbx of all itemstyle
                dsItemStyle.Clear();
                dsItemStyle = styleDAL.getAllItemStyle();
                cbxStyle.DataSource = dsItemStyle.Tables[0];
                cbxStyle.DisplayMember = "Name";
                //end populate

                //populate cbx of all item size
                dsItemSize.Clear();
                dsItemSize = sizeDAL.getAllItemSize();
                cbxSize.DataSource = dsItemSize.Tables[0];
                cbxSize.DisplayMember = "Name";
                //end populate
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showCasterMoldStock()
        {
            try
            {
                if (cbxWorker.Text.Equals(""))
                {
                    MessageBox.Show("Select Caster...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int cid = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                    CasterMoldStockTableAdapter dal = new CasterMoldStockTableAdapter();
                    dsDB.CasterMoldStockDataTable dt = new dsDB.CasterMoldStockDataTable();
                    dt = dal.GetDataByCasterID(cid);
                    dgvCaster.DataSource = dt;
                    dgvCaster.Columns["ItemBF"].Visible = false;
                    dgvCaster.Columns["Caster"].Visible = false;    
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----report object
        rptFrmCasterMoldStock report;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxWorker.Text.Equals(""))
                {
                    MessageBox.Show("Select caster...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //if (!this.Parent.Contains(report))
                    //{
                    int wid = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                    CasterMoldStockTableAdapter dal = new CasterMoldStockTableAdapter();
                    DataTable dt = new DataTable();
                    dt=(DataTable)dal.GetData(wid);

                        report = new rptFrmCasterMoldStock();
                        //report.TopLevel = false;
                        //report.Dock = DockStyle.Fill;
                        //this.Parent.Controls.Add(report);
                        report.printReportByDT(dt);
                        report.Show();
                        report.BringToFront();

                    //}
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                MoldStockWorkerDAL moldStockWorkerDAL = new MoldStockWorkerDAL();
                MoldStockCompanyDAL companyStockDAL = new MoldStockCompanyDAL();
                JobsDAL jobDal = new JobsDAL();
                CasterMoldStockTableAdapter dal = new CasterMoldStockTableAdapter();

                if (cbxWorker.Text.Equals(""))
                {
                    MessageBox.Show("Select caster...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (txtMoldQuantity.Text == "")
                {
                    MessageBox.Show("Enter quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MoldStockWorker m = new MoldStockWorker();
                    m.WorkerID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                    m.ItemID = itemDAL.getItemID(cbxItem.Text);
                    m.StyleID = styleDAL.getStyleID(cbxStyle.Text);
                    m.SizeID = sizeDAL.getSizeID(cbxSize.Text);

                    if (chkbxCompany.Checked.Equals(true))
                    {
                        if (companyStockDAL.checkIsMoldExist(m.ItemID, m.StyleID, m.SizeID).Equals(0))
                        {
                            MessageBox.Show("Company has not contain enough mold for issue...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (Convert.ToInt32(companyStockDAL.getStockByItemStyleSize(m.ItemID, m.StyleID, m.SizeID)) < Convert.ToInt32(txtMoldQuantity.Text))
                        {
                            MessageBox.Show("Issue mold quantity is greater than company mold stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (Convert.ToInt32(dal.CheckIsItemExistByItemId(m.ItemID, m.StyleID, m.SizeID, m.WorkerID)).Equals(0))
                        {
                            m.Quantity = Convert.ToInt16(Convert.ToInt32(txtMoldQuantity.Text));
                            m.CastQuantity = 0;
                            dal.InsertQuery(m.WorkerID, m.ItemID, m.StyleID, m.SizeID, m.Quantity);
                            MessageBox.Show("New mould has been added in the" + cbxWorker.Text + " mould stock ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            showCasterMoldStock();
                            //-----deduct from company stock
                            MoldStockCompany c = new MoldStockCompany();
                            c.ItemID = m.ItemID;
                            c.StyleID = m.StyleID;
                            c.SizeID = m.SizeID;
                            c.Quantity = Convert.ToInt16(Convert.ToInt32(companyStockDAL.getStockByItemStyleSize(c.ItemID, c.StyleID, c.SizeID)) - Convert.ToInt32(txtMoldQuantity.Text));
                            companyStockDAL.updateStock(c);
                            MessageBox.Show("Company mould stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //-----end
                            txtMoldQuantity.Text = "";
                            //MessageBox.Show(cbxWorker.Text + "  already contained this mold...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //update caster mould stock
                            m.Quantity = Convert.ToInt16(Convert.ToInt16(dal.getMouldQuantityByInfo(m.ItemID,m.StyleID,m.SizeID,m.WorkerID)) + Convert.ToInt16(txtMoldQuantity.Text));
                            m.CastQuantity = 0;
                            dal.UpdateQuery(m.Quantity,m.WorkerID, m.ItemID, m.StyleID, m.SizeID);
                            MessageBox.Show("Caster mould stock has been updated ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            showCasterMoldStock();
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(dal.CheckIsItemExistByItemId(m.ItemID, m.StyleID, m.SizeID, m.WorkerID)).Equals(0) )
                        {
                            m.Quantity = Convert.ToInt16(Convert.ToInt32(txtMoldQuantity.Text));
                            m.CastQuantity = 0;
                            dal.InsertQuery(m.WorkerID, m.ItemID, m.StyleID, m.SizeID, m.Quantity);
                            MessageBox.Show("New mould has been added in the" + cbxWorker.Text + " mould stock ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            showCasterMoldStock();
                            //MessageBox.Show(cbxWorker.Text + " already contained this mould... ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            //update caster mould stock
                            m.Quantity = Convert.ToInt16(Convert.ToInt16(dal.getMouldQuantityByInfo(m.ItemID, m.StyleID, m.SizeID, m.WorkerID)) + Convert.ToInt32(txtMoldQuantity.Text));
                            m.CastQuantity = 0;
                            dal.UpdateQuery(m.Quantity,m.WorkerID, m.ItemID, m.StyleID, m.SizeID);
                            MessageBox.Show("Caster mould stock has been updated ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            showCasterMoldStock();
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                MoldStockWorkerDAL moldStockWorkerDAL = new MoldStockWorkerDAL();
                MoldStockCompanyDAL companyStockDAL = new MoldStockCompanyDAL();
                CasterMoldStockTableAdapter dal = new CasterMoldStockTableAdapter();

                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select mould...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("Are you sure you want to delete ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MoldStockWorker m = new MoldStockWorker();
                    m.WorkerID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                    m.ItemID = itemDAL.getItemID(dgvCaster.Rows[selectedRow].Cells["ItemName"].Value.ToString());
                    m.StyleID = styleDAL.getStyleID(dgvCaster.Rows[selectedRow].Cells["StyleName"].Value.ToString());
                    m.SizeID = sizeDAL.getSizeID(dgvCaster.Rows[selectedRow].Cells["SizeName"].Value.ToString());

                    if (chkbxCompany.Checked.Equals(true))
                    {
                        dal.DeleteQuery(m.WorkerID,m.ItemID,m.StyleID,m.SizeID);
                        MessageBox.Show("Mold has been deleted from " + cbxWorker.Text + " Stock...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showCasterMoldStock();
                    }
                    txtMoldQuantity.Text = "";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = Convert.ToInt16(e.RowIndex);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (cbxWorker.Text != "")
            {
                showCasterMoldStock();
            }
        }
        private void txtMoldQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }
        private void cbxSelectJob_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                JobsDAL jobDal = new JobsDAL();

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
            showCasterMoldStock();
        }

        private void txtMoldQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            txtMoldQuantity.Focus();
        }
        //===================================================================================================================
    }
}
