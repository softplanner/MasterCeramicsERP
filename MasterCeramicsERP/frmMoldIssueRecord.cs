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
    public partial class frmMoldIssueRecord : Form
    {
        //PersonDAL personDAL = new PersonDAL();
        //ItemDAL itemDAL = new ItemDAL();
        //DALItemStyle styleDAL = new DALItemStyle();
        //ItemSizeDAL sizeDAL = new ItemSizeDAL();
        //MoldIssueRecordDAL moldIssueDAL = new MoldIssueRecordDAL();
        //MoldStockWorkerDAL moldStockWorkerDAL = new MoldStockWorkerDAL();
        //MoldStockCompanyDAL moldStockCompanyDAL = new MoldStockCompanyDAL();
        //JobsDAL jobDal = new JobsDAL();

        Int16 row = -1, selectedRow = -1,companyRow=-1,companySelectedRow=-1;
        DataSet dsJobs = new DataSet();
        DataSet dsWorker = new DataSet();
        
        public frmMoldIssueRecord()
        {
            InitializeComponent();
        }

        private void frmMoldIssueRecord_Load(object sender, EventArgs e)
        {
            //loadCasterDGV();
            populateJobsCBX();
            populateCompanyStockDGV();
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxWorker.Text.Equals(""))
                {
                    MessageBox.Show("First select caster...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (companySelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select mold from company mold stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtIssueQuantity.Text.Equals(""))
                {
                    MessageBox.Show("Enter issue quantity... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int stock = Convert.ToInt32(dgvCompanyStock.Rows[companySelectedRow].Cells[3].Value);
                    int issue = Convert.ToInt32(txtIssueQuantity.Text);
                    if (stock < issue)
                    {
                        MessageBox.Show("Issue quantity is greater than mold in stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dgvCompanyStock.Rows[companySelectedRow].Cells[3].Value = Convert.ToString((stock - issue));
                        addRowToDataGrid();
                        emptyTextFeilds();
                        companySelectedRow = -1;
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
        
        //===============================================================================================================
        private void addRowToDataGrid()
        {
            for (Int16 i = 0; i <= row;i++ )
            {
                if(dgvMold.Rows[i].Cells[0].Value.Equals(dgvCompanyStock.Rows[companySelectedRow].Cells[0].Value))
                {
                    if (dgvMold.Rows[i].Cells[1].Value.Equals(dgvCompanyStock.Rows[companySelectedRow].Cells[1].Value))
                    {
                        if (dgvMold.Rows[i].Cells[2].Value.Equals(dgvCompanyStock.Rows[companySelectedRow].Cells[2].Value))
                        {
                            dgvMold.Rows[i].Cells[4].Value = Convert.ToString(Convert.ToInt16(dgvMold.Rows[i].Cells[4].Value.ToString()) + Convert.ToInt16(txtIssueQuantity.Text));
                            return;
                        }
                    }   
                }
            }
            //////------Show record in the data grid view------//////
            row = Convert.ToInt16(dgvMold.Rows.Add());
            dgvMold.Rows[row].Cells[0].Value = txtItem.Text;
            dgvMold.Rows[row].Cells[1].Value = txtStyle.Text;
            dgvMold.Rows[row].Cells[2].Value = txtSize.Text;
            dgvMold.Rows[row].Cells[3].Value = cbxWorker.Text;
            dgvMold.Rows[row].Cells[4].Value = txtIssueQuantity.Text;
            ////------End show record in the data grid view------////
        }
        //==============================================================================================================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            companySelectedRow = -1;
            emptyTextFeilds();
        }
        //==============================================================================================================
        private void btnAddDB_Click(object sender, EventArgs e)
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                MoldIssueRecordDAL moldIssueDAL = new MoldIssueRecordDAL();
                MoldStockWorkerDAL moldStockWorkerDAL = new MoldStockWorkerDAL();
                MoldStockCompanyDAL moldStockCompanyDAL = new MoldStockCompanyDAL();
                
                if (row == -1)
                {
                    MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //=====update the company stock
                    MoldStockCompany moldCompanyStock;
                    for (Int16 i = 0; i <= companyRow; i++)
                    {
                        moldCompanyStock = new MoldStockCompany();
                        moldCompanyStock.ItemID = itemDAL.getItemID(dgvCompanyStock.Rows[i].Cells[0].Value.ToString());
                        moldCompanyStock.StyleID = styleDAL.getStyleID(dgvCompanyStock.Rows[i].Cells[1].Value.ToString());
                        moldCompanyStock.SizeID = sizeDAL.getSizeID(dgvCompanyStock.Rows[i].Cells[2].Value.ToString());
                        moldCompanyStock.Quantity = Convert.ToInt16(dgvCompanyStock.Rows[i].Cells[3].Value);
                        moldStockCompanyDAL.updateStock(moldCompanyStock);
                    }
                    //====end update company stock
                    MessageBox.Show("Company mold stock has been Update...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //======add to issue record
                    MoldIssueRecord IssueReport;
                    for (int i = 0; i <= row; i++)
                    {
                        //======add issue report
                        IssueReport = new MoldIssueRecord();
                        IssueReport.ItemID = itemDAL.getItemID(dgvMold.Rows[i].Cells[0].Value.ToString());
                        IssueReport.StyleID = styleDAL.getStyleID(dgvMold.Rows[i].Cells[1].Value.ToString());
                        IssueReport.SizeID = sizeDAL.getSizeID(dgvMold.Rows[i].Cells[2].Value.ToString());
                        IssueReport.WorkerID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                        IssueReport.Quantity = Convert.ToInt16(dgvMold.Rows[i].Cells[4].Value.ToString());
                        IssueReport.IssueDate = DateTime.Now;
                        if(moldIssueDAL.checkIsReportExist(IssueReport).Equals(true))
                        {
                            IssueReport.Quantity = Convert.ToInt16(IssueReport.Quantity + moldIssueDAL.getCurrentReportQuantity(IssueReport));
                            moldIssueDAL.updateReport(IssueReport);
                        }
                        else
                        {
                            moldIssueDAL.addReport(IssueReport);
                        }
                        //==========end add issue report

                        //MessageBox.Show("issue report updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //====add to worker stock
                        MoldStockWorker workerStock = new MoldStockWorker();
                        workerStock.WorkerID = IssueReport.WorkerID;
                        workerStock.ItemID = IssueReport.ItemID;
                        workerStock.StyleID = IssueReport.StyleID;
                        workerStock.SizeID = IssueReport.SizeID;
                        if (moldStockWorkerDAL.checkIsMoldExist(IssueReport.ItemID, IssueReport.StyleID, IssueReport.SizeID, IssueReport.WorkerID).Equals(1))
                        {
                            //===then get stock contain by that particular worker/caster
                            Int16 workerMold = moldStockWorkerDAL.getFreeStock(workerStock);
                            workerStock.Quantity = Convert.ToInt16(workerMold + Convert.ToInt16(dgvMold.Rows[i].Cells[4].Value.ToString()));
                            moldStockWorkerDAL.updateStock(workerStock);
                            MessageBox.Show("Caster mold stock has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //====add new mold to the worker stock
                            workerStock.Quantity = Convert.ToInt16(dgvMold.Rows[i].Cells[4].Value.ToString());
                            moldStockWorkerDAL.addStock(workerStock);
                            MessageBox.Show("Mold has been added to caster mold stock...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //====end add to worker stock
                    }
                }
                populateCompanyStockDGV();
                dgvMold.Rows.Clear();
                row = -1;
                selectedRow = -1;
                companySelectedRow = -1;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //===============================================================================================================
        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (selectedRow == -1)
            {
                MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                returnToStock();
                dgvMold.Rows.RemoveAt(selectedRow);
                selectedRow = -1;
                row--;
            }
        }
       //================================================================================================================
        private void populateCompanyStockDGV() 
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                MoldStockCompanyDAL moldStockCompanyDAL = new MoldStockCompanyDAL();
                
                dgvCompanyStock.Rows.Clear();
                companyRow = -1;
                List<MoldStockCompany> list = new List<MoldStockCompany>();
                list = moldStockCompanyDAL.getStock();
                list.TrimExcess();
                for (Int16 i = 0; i < list.Count; i++)
                {
                    companyRow = Convert.ToInt16(dgvCompanyStock.Rows.Add());
                    dgvCompanyStock.Rows[companyRow].Cells[0].Value = itemDAL.getItemName(list[i].ItemID);
                    dgvCompanyStock.Rows[companyRow].Cells[1].Value = styleDAL.getItemStyleName(list[i].StyleID);
                    dgvCompanyStock.Rows[companyRow].Cells[2].Value = sizeDAL.getItemSizeName(list[i].SizeID);
                    dgvCompanyStock.Rows[companyRow].Cells[3].Value = list[i].Quantity;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //===============================================================================================================
        private void dgvCompanyStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            companySelectedRow = Convert.ToInt16(e.RowIndex);
            if (companySelectedRow != -1)
            {
                emptyTextFeilds();
                populateTextFeilds();
            }
        }
        //================================================================================================================
        private void populateTextFeilds()
        {
            txtItem.Text = dgvCompanyStock.Rows[companySelectedRow].Cells[0].Value.ToString();
            txtStyle.Text = dgvCompanyStock.Rows[companySelectedRow].Cells[1].Value.ToString();
            txtSize.Text = dgvCompanyStock.Rows[companySelectedRow].Cells[2].Value.ToString();
        }
        //================================================================================================================
        private void emptyTextFeilds() 
        {
            txtItem.Text = "";
            txtStyle.Text = "";
            txtSize.Text = "";
            txtIssueQuantity.Text = "";
        }
        //===============================================================================================================

        private void dgvMold_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = Convert.ToInt16(e.RowIndex);
        }
        //========================================================================================================
        private void returnToStock() 
        {
            for (Int16 i = 0; i < companyRow;i++ )
            {
                if(dgvCompanyStock.Rows[i].Cells[0].Value.Equals(dgvMold.Rows[selectedRow].Cells[0].Value))
                {
                    if (dgvCompanyStock.Rows[i].Cells[1].Value.Equals(dgvMold.Rows[selectedRow].Cells[1].Value))
                    {
                        if (dgvCompanyStock.Rows[i].Cells[2].Value.Equals(dgvMold.Rows[selectedRow].Cells[2].Value))
                        {
                            dgvCompanyStock.Rows[i].Cells[3].Value =Convert.ToString ( Convert.ToInt16(dgvCompanyStock.Rows[i].Cells[3].Value) + Convert.ToInt16(dgvMold.Rows[selectedRow].Cells[4].Value));
                        }
                    }
                }
            }
        }
        //========================================================================================================
        private void returnToStockComplete()
        {
            int i = 0, j = 0;
            for (j = 0; j <= row; j++)
            {
                for (i = 0; i <= companyRow; i++)
                {
                    if (dgvCompanyStock.Rows[i].Cells[0].Value.Equals(dgvMold.Rows[j].Cells[0].Value))
                    {
                        if (dgvCompanyStock.Rows[i].Cells[1].Value.Equals(dgvMold.Rows[j].Cells[1].Value))
                        {
                            if (dgvCompanyStock.Rows[i].Cells[2].Value.Equals(dgvMold.Rows[j].Cells[2].Value))
                            {
                                dgvCompanyStock.Rows[i].Cells[3].Value = Convert.ToString(Convert.ToInt16(dgvCompanyStock.Rows[i].Cells[3].Value) + Convert.ToInt16(dgvMold.Rows[j].Cells[4].Value));
                            }
                        }
                    }
                }
            }
        }
        private void txtIssueQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtIssueQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            txtIssueQuantity.Focus();
        }

        private void cbxSelectJob_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                JobsDAL jobDal = new JobsDAL();

                if(row>=0)
                {
                    returnToStockComplete();
                    dgvMold.Rows.Clear();
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
                returnToStockComplete();
                dgvMold.Rows.Clear();
                row = selectedRow = -1;
            }
        }
        //=========================================================================================================
    }
}
