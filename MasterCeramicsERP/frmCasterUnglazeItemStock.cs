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
    public partial class frmCasterUnglazeItemStock : Form
    {
        //PersonDAL personDAL = new PersonDAL();
        //ItemDAL itemDAL = new ItemDAL();
        //DALItemStyle styleDAL = new DALItemStyle();
        //ItemSizeDAL sizeDAL = new ItemSizeDAL();
        //JobsDAL jobDal = new JobsDAL();
        //GreenWareHouseWorkerStockDAL moldStockWorkerDAL = new GreenWareHouseWorkerStockDAL();
        //MoldStockCompanyDAL companyStockDAL = new MoldStockCompanyDAL();

        DataSet dsJobs = new DataSet();
        DataSet dsWorker = new DataSet();
        DataSet dsItemStyle = new DataSet();
        DataSet dsItemSize = new DataSet();
        DataSet dsItem = new DataSet();
        DataSet dsCaster = new DataSet();
        
        List<GreenWareHouseWorkerStock> list;
        Int16 row = -1, selectedRow = -1;
        
        

        public frmCasterUnglazeItemStock()
        {
            InitializeComponent();
        }

        private void frmCasterUnglazeItemStock_Load(object sender, EventArgs e)
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
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void showCasterMoldStock()
        {
            try
            {
                if (cbxWorker.Text.Equals(""))
                {
                    //do nothing...
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    GreenWareHouseWorkerStockDAL moldStockWorkerDAL = new GreenWareHouseWorkerStockDAL();
                    
                    dgvCaster.Rows.Clear();
                    row = -1;
                    selectedRow = -1;
                    list = new List<GreenWareHouseWorkerStock>();
                    list = moldStockWorkerDAL.getStockByCaster(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]));
                    list.TrimExcess();
                    for (Int16 i = 0; i < list.Count; i++)
                    {
                        row = Convert.ToInt16(dgvCaster.Rows.Add());
                        dgvCaster.Rows[i].Cells[0].Value = itemDAL.getItemName(list[i].ItemID);
                        dgvCaster.Rows[i].Cells[1].Value = styleDAL.getItemStyleName(list[i].StyleID);
                        dgvCaster.Rows[i].Cells[2].Value = sizeDAL.getItemSizeName(list[i].SizeID);
                        dgvCaster.Rows[i].Cells[3].Value = list[i].Quantity.ToString();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void dgvCaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = Convert.ToInt16(e.RowIndex);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxWorker.Text.Equals(""))
                {
                    MessageBox.Show("Select caster...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (txtQuantity.Text == "")
                {
                    MessageBox.Show("Enter quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    GreenWareHouseWorkerStockDAL moldStockWorkerDAL = new GreenWareHouseWorkerStockDAL();
                    
                    GreenWareHouseWorkerStock m = new GreenWareHouseWorkerStock();
                    m.WorkerID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                    m.ItemID = itemDAL.getItemID(cbxItem.Text);
                    m.StyleID = styleDAL.getStyleID(cbxStyle.Text);
                    m.SizeID = sizeDAL.getSizeID(cbxSize.Text);

                    if (moldStockWorkerDAL.checkIsRecordExist(m).Equals(true))
                    {
                        MessageBox.Show(cbxWorker.Text + " already contained this item... ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        m.Quantity = Convert.ToInt32(txtQuantity.Text);
                        moldStockWorkerDAL.addStock(m);
                        MessageBox.Show("New item has been added in the " + cbxWorker.Text + " unglaze item stock...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showCasterMoldStock();
                    }
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
                    MessageBox.Show("Select item...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    GreenWareHouseWorkerStockDAL moldStockWorkerDAL = new GreenWareHouseWorkerStockDAL();
                    
                    GreenWareHouseWorkerStock m = new GreenWareHouseWorkerStock();
                    m.WorkerID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                    m.ItemID = itemDAL.getItemID(dgvCaster.Rows[selectedRow].Cells[0].Value.ToString());
                    m.StyleID = styleDAL.getStyleID(dgvCaster.Rows[selectedRow].Cells[1].Value.ToString());
                    m.SizeID = sizeDAL.getSizeID(dgvCaster.Rows[selectedRow].Cells[2].Value.ToString());
                    moldStockWorkerDAL.deleteStock(m);
                    MessageBox.Show("Selected item has been deleted from the the " + cbxWorker.Text + " unglaze item stock...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showCasterMoldStock();
               }
                    txtQuantity.Text = "";
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
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select mold...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtQuantity.Text.Equals(""))
                {
                    MessageBox.Show("Enter free mold qunatity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    GreenWareHouseWorkerStockDAL moldStockWorkerDAL = new GreenWareHouseWorkerStockDAL();
                    
                    GreenWareHouseWorkerStock m = new GreenWareHouseWorkerStock();
                    m.WorkerID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                    m.ItemID = itemDAL.getItemID(cbxItem.Text);
                    m.StyleID = styleDAL.getStyleID(cbxStyle.Text);
                    m.SizeID = sizeDAL.getSizeID(cbxSize.Text);
                    m.Quantity = Convert.ToInt32(txtQuantity.Text);
                    moldStockWorkerDAL.updateStock(m);
                    MessageBox.Show("Selected item has been updated in the the " + cbxWorker.Text + " unglaze item stock...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showCasterMoldStock();
                }
                txtQuantity.Text = "";
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (cbxWorker.Text != "")
            {
                showCasterMoldStock();
            }
        }
        private void txtCastQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }
        private void txtCastQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            txtQuantity.Focus();
        }
        //-----report object declaration
        rptFrmCasterItemStock report;
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
                    report = new rptFrmCasterItemStock();
                    //report.TopLevel = false;
                    //report.Dock = DockStyle.Fill;
                    //this.Parent.Controls.Add(report);
                    report.showReport(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]));
                    report.BringToFront();
                    report.Show();
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
    }
}
