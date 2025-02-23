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
    public partial class frmGreenWareMoldCasting : Form
    {
        Int32 row = -1, selectedRow = -1, companyRow = -1, companySelectedRow = -1;
        DataSet dsJobs = new DataSet();
        DataSet dsWorker = new DataSet();
        public frmGreenWareMoldCasting()
        {
            InitializeComponent();
        }

        private void frmMoldCasting_Load(object sender, EventArgs e)
        {
            emptyTextFeilds();
            txtSlip.Text = Convert.ToString(getSlip());
            populateJobsCBX();
            dgvMold.Columns[0].Visible = false;
        }
        private void cbxSelectJob_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                JobsDAL jobDal = new JobsDAL();

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
        private void loadCasterStockDGV()
        {
            try
            {
                BindingSource bs = new BindingSource();
                row = -1;
                selectedRow = -1;
                int casterId = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                CasterMoldStockTableAdapter dal = new CasterMoldStockTableAdapter();
                dsDB.CasterMoldStockDataTable dt = new dsDB.CasterMoldStockDataTable();
                dal.GetByCasterID(dt, casterId);
                
                if (dt.Rows.Count.Equals(0))
                {
                    MessageBox.Show("Caster does not contain any mold in his stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvWorkerStock.DataSource = null;
                }
                else
                {
                    companyRow = -1;
                    bs.DataSource = dt;
                    dgvWorkerStock.DataSource = bs;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addCastingReport() 
        {
            try
            {
                if (dgvMold.Rows.Count.Equals(0))
                {
                    MessageBox.Show("No record found to save...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    DailyReportGreenwareTableAdapter dal = new DailyReportGreenwareTableAdapter();
                    ItemWeightTableAdapter dalItemWeight = new ItemWeightTableAdapter();
                    taUnglazeStockCompany dalCompany = new taUnglazeStockCompany();
                    CasterItemStockTableAdapter dalCasterStock = new CasterItemStockTableAdapter();
                    CasterCheckedItemInfoTableAdapter dalCasterCheckedItem = new CasterCheckedItemInfoTableAdapter();

                    int newCompanyStock ;
                    int slipQua=0,totalItemWeight = 0,casterID = 0, mouldQuantity = 0, mouldCasting = 0, breakage = 0, DryBreakage = 0,BalanceBF = 0, totalItem = 0, checkedItems = 0, BalanceItems = 0, Rejected=0 ;
                    Int16 itemID = 0, styleID = 0, sizeID = 0;
                    int temp = 0;
                    DateTime d = DateTime.Now;
                    for (Int16 i = 0; i <= row; i++)
                    {
                        //-------------------
                        newCompanyStock = 0;
                        //-------------------
                        slipQua = Convert.ToInt32(txtSlip.Text);
                        casterID = Convert.ToInt32(dgvMold.Rows[i].Cells["CasterID"].Value.ToString());
                        itemID = itemDAL.getItemID(dgvMold.Rows[i].Cells["Item"].Value.ToString());
                        styleID = styleDAL.getStyleID(dgvMold.Rows[i].Cells["Style"].Value.ToString());
                        sizeID = sizeDAL.getSizeID(dgvMold.Rows[i].Cells["Size"].Value.ToString());
                        mouldQuantity = Convert.ToInt32(dgvMold.Rows[i].Cells["MouldQuantity"].Value.ToString());
                        mouldCasting = Convert.ToInt32(dgvMold.Rows[i].Cells["MouldCasting"].Value.ToString());
                        breakage = Convert.ToInt32(dgvMold.Rows[i].Cells["Breakage"].Value.ToString());
                        DryBreakage = Convert.ToInt32(dgvMold.Rows[i].Cells["DryBreakage"].Value.ToString());
                        BalanceBF = Convert.ToInt32(dgvMold.Rows[i].Cells["BalanceBF"].Value.ToString());
                        totalItem = Convert.ToInt32(dgvMold.Rows[i].Cells["Total"].Value.ToString());
                        Rejected = Convert.ToInt32(dgvMold.Rows[i].Cells["Rejected"].Value.ToString());
                        checkedItems = Convert.ToInt32(dgvMold.Rows[i].Cells["Checked"].Value.ToString());
                        BalanceItems = Convert.ToInt32(dgvMold.Rows[i].Cells["BalanceItems"].Value.ToString());
                        //------update slip here....
                        totalItemWeight = Convert.ToInt32(dalItemWeight.getItemWeight(itemID, styleID, sizeID)) * mouldCasting;
                        txtSlip.Text = Convert.ToString(slipQua - totalItemWeight);
                        //------add daily report green ware one by one
                        dal.InsertQuery(casterID, itemID, styleID, sizeID, mouldQuantity, mouldCasting, breakage, DryBreakage, BalanceBF, totalItem, Rejected, checkedItems, BalanceItems, txtRemarks.Text, 1, d);
                        //01------update company unglaze item stock
                        //02------checked items are added to company unglaze item stock...
                        //check if company contain item already then update otherwise add new item and its stock
                        temp = 0;
                        temp = Convert.ToInt32(dalCompany.checkByIDIsItemExist(Convert.ToInt16(itemID), Convert.ToInt16(styleID), Convert.ToInt16(sizeID)));
                        if (temp.Equals(0))
                        {
                            dalCompany.InsertQuery(itemID, styleID, sizeID, checkedItems); 
                        }
                        else
                        {
                            newCompanyStock = Convert.ToInt32(dalCompany.getUnglazeStock(dgvMold.Rows[i].Cells["Item"].Value.ToString(), dgvMold.Rows[i].Cells["Style"].Value.ToString(), dgvMold.Rows[i].Cells["Size"].Value.ToString())) + checkedItems;
                            dalCompany.UpdateQuery(newCompanyStock, itemID, styleID, sizeID);                                                            
                        }
                        //check if caster contain item already then update otherwise add new item and its stock
                        temp = 0;
                        temp = Convert.ToInt32(dalCasterStock.checkByItemIDIsItemExist(itemID,styleID,sizeID,casterID));
                        if (temp.Equals(0))
                        {
                            dalCasterStock.Insert(casterID, itemID, styleID, sizeID, BalanceItems);
                        }
                        else
                        {
                            //------update BrodForward Caster Item Stock....)
                            dalCasterStock.UpdateStock(BalanceItems, itemID, styleID, sizeID,casterID);
                        }
                        //check if caster contain item in its checked item stock already then update otherwise add new item and its stock
                        temp = 0;
                        temp = Convert.ToInt32(dalCasterCheckedItem.checkByItemIDIsItemExist(itemID,styleID,sizeID,casterID));
                        if (temp.Equals(0))
                        {
                            dalCasterCheckedItem.InsertQuery(casterID, itemID, styleID, sizeID, checkedItems);
                        }
                        else
                        {
                            temp = Convert.ToInt32(dalCasterCheckedItem.getStock(itemID, styleID, sizeID, casterID)) + checkedItems;
                            dalCasterCheckedItem.UpdateQuery(temp,itemID,styleID,sizeID,casterID);
                        }
                    }
                    dgvMold.Rows.Clear();
                    row = -1;
                    selectedRow = -1;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void dgvWorkerStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                companySelectedRow = Convert.ToInt16(e.RowIndex);
                if (companySelectedRow != -1)
                {
                    emptyTextFeilds();
                    txtBalanceBF.Text = dgvWorkerStock.Rows[companySelectedRow].Cells["ItemBF"].Value.ToString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //========================================================================
        private void emptyTextFeilds()
        {
            txtMouldCasting.Text = "0";
            txtBreakage.Text = "0";
            txtDryBreakage.Text = "0";
            txtBalanceBF.Text = "0";
            txtCheckedItems.Text = "0";
            txtTotalItems.Text = "0";
            txtBalanceItems.Text = "0";
            txtRemarks.Text = "";
            txtRejected.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (companySelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select mould ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                else if (txtMouldCasting.Text.Equals(""))
                {
                    MessageBox.Show("Enter mould casting quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(Convert.ToInt32(dgvWorkerStock.Rows[companySelectedRow].Cells["MoldQuantity"].Value.ToString()) < Convert.ToInt32(txtMouldCasting.Text))
                {
                    MessageBox.Show("Insufficient Mould...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if((Convert.ToInt32(txtMouldCasting.Text) + Convert.ToInt32(txtBalanceBF.Text)) < Convert.ToInt32(txtCheckedItems.Text))
                {
                    MessageBox.Show("Invalid cheked items quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int id = Convert.ToInt32(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]));
                    calculate();
                    //=====first check is sufficient slip available for casting
                    if (deductSlip().Equals(true))
                    {
                        addRowToDataGrid();
                        companySelectedRow = -1;
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //===============================================================================================================
        private void addRowToDataGrid()
        {
            try
            {
                int id = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                for (int i = 0; i <= row; i++)
                {
                    if (dgvMold.Rows[i].Cells["CasterID"].Value.ToString().Equals(id.ToString()))
                    {
                        if (dgvMold.Rows[i].Cells["Item"].Value.ToString().Equals(dgvWorkerStock.Rows[companySelectedRow].Cells["ItemName"].Value.ToString()))
                        {
                            if (dgvMold.Rows[i].Cells["Style"].Value.ToString().Equals(dgvWorkerStock.Rows[companySelectedRow].Cells["StyleName"].Value.ToString()))
                            {
                                if (dgvMold.Rows[i].Cells["Size"].Value.ToString().Equals(dgvWorkerStock.Rows[companySelectedRow].Cells["SizeName"].Value.ToString()))
                                {
                                    dgvMold.Rows.RemoveAt(i);
                                    --row;
                                }
                            }
                        }
                    }
                }
                //////------Show record in the data grid view------//////
                row = dgvMold.Rows.Add();
                dgvMold.Rows[row].Cells["CasterID"].Value = Convert.ToString(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                dgvMold.Rows[row].Cells["Caster"].Value = dgvWorkerStock.Rows[companySelectedRow].Cells["CasterName"].Value.ToString();
                dgvMold.Rows[row].Cells["Item"].Value = dgvWorkerStock.Rows[companySelectedRow].Cells["ItemName"].Value.ToString();
                dgvMold.Rows[row].Cells["Style"].Value = dgvWorkerStock.Rows[companySelectedRow].Cells["StyleName"].Value.ToString(); 
                dgvMold.Rows[row].Cells["Size"].Value = dgvWorkerStock.Rows[companySelectedRow].Cells["SizeName"].Value.ToString();
                dgvMold.Rows[row].Cells["MouldQuantity"].Value = dgvWorkerStock.Rows[companySelectedRow].Cells["MoldQuantity"].Value.ToString();
                dgvMold.Rows[row].Cells["BalanceBF"].Value = dgvWorkerStock.Rows[companySelectedRow].Cells["ItemBF"].Value.ToString();
                dgvMold.Rows[row].Cells["MouldCasting"].Value = txtMouldCasting.Text;
                dgvMold.Rows[row].Cells["Breakage"].Value = txtBreakage.Text;
                dgvMold.Rows[row].Cells["DryBreakage"].Value = txtDryBreakage.Text;
                dgvMold.Rows[row].Cells["Total"].Value = txtTotalItems.Text;
                dgvMold.Rows[row].Cells["Rejected"].Value = txtRejected.Text;
                dgvMold.Rows[row].Cells["Checked"].Value = txtCheckedItems.Text;
                dgvMold.Rows[row].Cells["BalanceItems"].Value = txtBalanceItems.Text;
                dgvMold.Rows[row].Cells["Remarks"].Value = txtRemarks.Text;
                ////------End show record in the data grid view------////
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //========================================================================================================
        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow == -1)
                {
                    MessageBox.Show("Select from casting report...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    addSlip();
                    dgvMold.Rows.RemoveAt(selectedRow);
                    --row;
                    //-----
                    emptyTextFeilds();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //==============================================================================================================
        private void dgvMold_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = Convert.ToInt16(e.RowIndex);
        }
        //=========================================================================================================
        private void btnAddDB_Click(object sender, EventArgs e)
        {
            try
            {
                addCastingReport();
                saveSlipToDB();
                emptyTextFeilds();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //=======================================================================================================
        private void saveSlipToDB()
        {
            try
            {
                SlipStockDAL slipStockDAL = new SlipStockDAL();
                slipStockDAL.updateSlipStock(Convert.ToSingle(txtSlip.Text));
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //========================================================================================================
        private float getSlip()
        {
            SlipStockDAL slipStockDAL = new SlipStockDAL();
            
            float q =0;
            try
            {
            q = slipStockDAL.getSlipInStock();
            return q;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return q;
            
        }
        //========================================================================================================
        private bool deductSlip()
        {
            ItemDAL itemDAL = new ItemDAL();
            DALItemStyle styleDAL = new DALItemStyle();
            ItemSizeDAL sizeDAL = new ItemSizeDAL();
            ItemWeightDAL itemWeightDAL = new ItemWeightDAL();
            PersonDAL personDAL = new PersonDAL();
            
            
            float w = itemWeightDAL.getItemWeight(itemDAL.getItemID(dgvWorkerStock.Rows[companySelectedRow].Cells["ItemName"].Value.ToString()), styleDAL.getStyleID(dgvWorkerStock.Rows[companySelectedRow].Cells["StyleName"].Value.ToString()), sizeDAL.getSizeID(dgvWorkerStock.Rows[companySelectedRow].Cells["SizeName"].Value.ToString()));
            //if ((Convert.ToInt32(w) * Convert.ToInt32(txtBalanceItems.Text)) > Convert.ToInt32(txtSlip.Text))
            //{
            //    MessageBox.Show("Require more slip for casting that items...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //else
            //{
                txtSlip.Text = Convert.ToString(Convert.ToInt32(txtSlip.Text) - ((Convert.ToInt32(w)) * Convert.ToInt32(txtBalanceItems.Text)));
                return true;
            //}
        }
        //========================================================================================================
        private void addSlip()
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                ItemWeightDAL itemWeightDAL = new ItemWeightDAL();
                
                float w = itemWeightDAL.getItemWeight(itemDAL.getItemID(dgvMold.Rows[selectedRow].Cells["Item"].Value.ToString()), styleDAL.getStyleID(dgvMold.Rows[selectedRow].Cells["Style"].Value.ToString()), sizeDAL.getSizeID(dgvMold.Rows[selectedRow].Cells["Size"].Value.ToString()));
                txtSlip.Text = Convert.ToString(Convert.ToInt32(txtSlip.Text) + ((Convert.ToInt32(w)) * Convert.ToInt32(dgvMold.Rows[selectedRow].Cells["MouldCasting"].Value.ToString())));
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //========================================================================================================
        private void txtCastQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtCastQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            txtBalanceItems.Focus();
        }
        private void cbxWorker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //dgvWorkerStock.Rows.Clear();
            //dgvMold.Rows.Clear();
            row = -1;
            selectedRow = -1;
            loadCasterStockDGV();
        }

        private void txtBreakage_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtBreakage.Focus();
        }

        private void txtDryBreakage_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtDryBreakage.Focus();
        }

        private void txtCheckedItems_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtCheckedItems.Focus();
        }

        private void txtBreakage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtDryBreakage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtCheckedItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtMouldCasting_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtMouldCasting.Focus();
        }

        private void txtMouldCasting_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void calculate()
        {
            if (companySelectedRow != -1)
            {
                //perform calculation...

                if (txtMouldCasting.Text.Equals(""))
                {
                    txtMouldCasting.Text = "0";
                }
                if (txtBreakage.Text.Equals(""))
                {
                    txtBreakage.Text = "0";
                }
                if (txtDryBreakage.Text.Equals(""))
                {
                    txtDryBreakage.Text = "0";
                }
                if (txtRejected.Text.Equals(""))
                {
                    txtRejected.Text = "0";
                }
                if (txtCheckedItems.Text.Equals(""))
                {
                    txtCheckedItems.Text = "0";
                }
                //1
                txtTotalItems.Text = (Convert.ToInt32(txtBalanceBF.Text) + Convert.ToInt32(txtMouldCasting.Text)).ToString();
                //2
                txtBalanceItems.Text = (Convert.ToInt32(txtTotalItems.Text) - (Convert.ToInt32(txtBreakage.Text) + Convert.ToInt32(txtDryBreakage.Text) + Convert.ToInt32(txtRejected.Text) + Convert.ToInt32(txtCheckedItems.Text))).ToString();
                //5
            }
            else 
            {
            }
        }

        private void txtRejected_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtRejected_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtRejected.Focus();
        }

        //========================================================================================================
    }
}
