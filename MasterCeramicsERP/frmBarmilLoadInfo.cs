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
    public partial class frmbarmilLoadInfo : Form
    {
        //BarmilDAL barmilDAL = new BarmilDAL();
        //BarmilLoadInfoDAL barmilLoadInfoDAL = new BarmilLoadInfoDAL();
        //PersonDAL personDAL = new PersonDAL();
        //JobsDAL jobDal = new JobsDAL();
        //SlipStockDAL slipdal = new SlipStockDAL();

        DataSet ds;
        DataSet dsJobs = new DataSet();
        DataSet dsWorker = new DataSet();
        List<BarmilLoadInfo> list;
        BindingSource bs;
        int selectedRow = -1,row=0,bRow=-1,BSrow=-1;
        
        
        public frmbarmilLoadInfo()
        {
            InitializeComponent();
        }
        private void getSlip()
        {
            try
            {
                SlipStockDAL slipdal = new SlipStockDAL();

                mtxtSlip.Text= slipdal.getSlipInStock().ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addSlip()
        {
            try
            {
                SlipStockDAL slipdal = new SlipStockDAL();

                slipdal.updateSlipStock(Convert.ToSingle(Convert.ToInt32(mtxtSlip.Text)+Convert.ToInt32(dgvUnloadbarmil.Rows[selectedRow].Cells[1].Value)));
                MessageBox.Show("Slip Stock Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void chkbxBarmilLoading_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxBarmilLoading.Checked.Equals(true))
            {
                gbxBarmilLoading.Enabled = true;
                populateGridViewWithbarmils();
            }
            else
            {
                dsWorker.Clear();
                gbxBarmilLoading.Enabled = false;
                mtxtID.Text = "";
                mtxtWeight.Text = "";
            }
        }

        private void frmbarmilLoadInfo_Load(object sender, EventArgs e)
        {
            gbxBarmilLoading.Enabled = false;
            getSlip();
            populateCBX();
        }
        private void populateCBX()
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
        private void populateGridViewWithbarmils()
        {
            try
            {
                BarmilDAL barmilDAL = new BarmilDAL();
                
                bRow = -1;
                BSrow = -1;
                dgvBarmil.Rows.Clear();
                List<Barmil> lst = new List<Barmil>();
                lst = barmilDAL.getAllBarmilList();
                lst.TrimExcess();
                for (Int16 i = 0; i < lst.Count; i++)
                {
                    bRow = dgvBarmil.Rows.Add();
                    dgvBarmil.Rows[bRow].Cells[0].Value = lst[i].ID.ToString();
                    dgvBarmil.Rows[bRow].Cells[1].Value = lst[i].Weight;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to load this ballmill ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (mtxtID.Text == "")
                    {
                        MessageBox.Show("Select ballmill ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (cbxWorker.Text.Equals(""))
                    {
                        MessageBox.Show("Select ballmiller... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        BarmilLoadInfoDAL barmilLoadInfoDAL = new BarmilLoadInfoDAL();

                        BarmilLoadInfo barmilLoad = new BarmilLoadInfo();
                        barmilLoad.BarmilID = Convert.ToInt16(mtxtID.Text);
                        barmilLoad.PersonID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                        barmilLoad.LoadDate = DateTime.Now;
                        barmilLoad.UnloadDate = DateTime.Now;
                        barmilLoad.Status = "ON";

                        if (barmilLoadInfoDAL.isBallMillExist(Convert.ToInt16(mtxtID.Text)).Equals(true))
                        {
                            if (barmilLoadInfoDAL.getBarmilStatusByBarmilID(Convert.ToInt16(mtxtID.Text)).Equals("ON"))
                            {
                                MessageBox.Show("This ballmilll already loaded...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                barmilLoadInfoDAL.updateBarmil(barmilLoad);
                                //updateRawMaterial();
                                //MessageBox.Show("Raw material in stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MessageBox.Show("Ballmill has been loaded...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                populateGridViewUnloadbarmil();
                            }
                        }
                        else
                        {
                            barmilLoadInfoDAL.addRecord(barmilLoad);
                            MessageBox.Show("Ballmill has been loaded...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void updateRawMaterial()
        {
            try
            {
                RawMaterialStockDAL rmDal = new RawMaterialStockDAL();
                SlipPercentageDAL dal = new SlipPercentageDAL();
                List<SlipPercentage> lst = new List<SlipPercentage>();

                float ballmillweight_temp = Convert.ToSingle(dgvUnloadbarmil.Rows[selectedRow].Cells[1].Value.ToString());
                lst = dal.getSlipPercentageOfSlipMaterial();
                lst.TrimExcess();
                float updatedQuantity = 0;
                for (Int16 i = 0; i < lst.Count; i++)
                {
                    //updatedQuantity= Convert.ToSingle(rmDal.getStock(lst[i].RMID) - (dal.getPercentageByRawmaterialID(lst[i].RMID) * Convert.ToSingle(mtxtWeight.Text)));
                    updatedQuantity = Convert.ToSingle(rmDal.getStock(lst[i].RMID) - (dal.getPercentageByRawmaterialID(lst[i].RMID) * ballmillweight_temp));
                    rmDal.updateStock(lst[i].RMID, updatedQuantity);
                    //dgvBarmil.Rows[bRow].Cells[0].Value = lst[i].ID.ToString();
                    //dgvBarmil.Rows[bRow].Cells[1].Value = lst[i].Weight;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void populateGridViewUnloadbarmil() 
        {
            try
            {
                BarmilDAL barmilDAL = new BarmilDAL();
                BarmilLoadInfoDAL barmilLoadInfoDAL = new BarmilLoadInfoDAL();
                PersonDAL personDAL = new PersonDAL();
               
                row = 0;
                selectedRow = -1;
                dgvUnloadbarmil.Rows.Clear();
                list = new List<BarmilLoadInfo>();
                list = barmilLoadInfoDAL.getAllBarmilLoadInfoList();
                list.TrimExcess();
                for (Int16 i = 0; i < list.Count; i++)
                {
                    row = Convert.ToInt16(dgvUnloadbarmil.Rows.Add());
                    if (barmilLoadInfoDAL.getBarmilStatusByBarmilID(list[i].BarmilID).Equals("ON"))
                    {
                        dgvUnloadbarmil.Rows[row].Cells[3].Value = "Ballmill is on...";
                    }
                    else
                    {
                        dgvUnloadbarmil.Rows[row].Cells[3].Value = list[i].UnloadDate.ToShortDateString();
                    }
                    dgvUnloadbarmil.Rows[row].Cells[0].Value = list[i].BarmilID;
                    dgvUnloadbarmil.Rows[row].Cells[1].Value = barmilDAL.getBarmilWeight(list[i].BarmilID);
                    dgvUnloadbarmil.Rows[row].Cells[2].Value = list[i].LoadDate.ToShortDateString();
                    dgvUnloadbarmil.Rows[row].Cells[4].Value = personDAL.getPersonName(list[i].PersonID);
                    dgvUnloadbarmil.Rows[row].Cells[5].Value = list[i].Status;
                    //dgvUnloadbarmil.Rows[row].Cells[3].Value = list[i].UnloadDate.ToShortDateString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUnload_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to unload this Ballmill ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (selectedRow.Equals(-1))
                    {
                        MessageBox.Show("Select Ballmill for Unload", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dgvUnloadbarmil.Rows[selectedRow].Cells["Status"].Value.Equals("OFF"))
                    {
                        MessageBox.Show("This ballmill already unloaded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //update raw material stock
                        if (chkbxRawMaterial.Checked.Equals(true))
                        {
                            //if (MessageBox.Show("Are you sure you want to update raw material ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            //{
                                updateRawMaterial();
                                MessageBox.Show("Raw material in stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //}
                        }
                        //-------------------------
                        BarmilLoadInfoDAL barmilLoadInfoDAL = new BarmilLoadInfoDAL();

                        barmilLoadInfoDAL.unLoadBarmil(Convert.ToInt16(dgvUnloadbarmil.Rows[selectedRow].Cells[0].Value));
                        MessageBox.Show("BallMill unloaded successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvUnloadbarmil.Rows[selectedRow].Cells[5].Value = "OFF";
                        dgvUnloadbarmil.Rows[selectedRow].Cells[3].Value = DateTime.Now.ToShortDateString();
                        if (chkbxAddToStock.Checked.Equals(true))
                        {
                            //if (MessageBox.Show("Are you sure you want to update slip stock ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            //{
                                addSlip();
                            //}
                        }
                        getSlip();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUnloadbarmil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = Convert.ToInt16(e.RowIndex);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateGridViewUnloadbarmil();
            getSlip();
        }

        private void chkbxUnloadBarmil_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkbxUnloadBarmil.Checked.Equals(true))
            {
                //-----------------------------
                gbxUnLoadBarmil.Enabled = true;
                //-----------------------------
                populateGridViewUnloadbarmil();
            }
            else
            {
                //------------------------------
                gbxUnLoadBarmil.Enabled = false;
                //dgvUnloadbarmil.Rows.Clear();
                //dgvUnloadbarmil.Enabled = false;
                //chkbxAddToStock.Enabled = false;
                //btnUnload.Enabled = false;
                //------------------------------
            }
        }

        private void dgvBarmil_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BSrow = Convert.ToInt16(e.RowIndex);
                if (BSrow != -1)
                {
                    //------------------------
                    mtxtID.Text = "";
                    mtxtWeight.Text = "";
                    mtxtID.Text = dgvBarmil.Rows[e.RowIndex].Cells[0].Value.ToString();
                    mtxtWeight.Text = dgvBarmil.Rows[e.RowIndex].Cells[1].Value.ToString();
                    //------------------------ 
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtxtWeight_MouseClick(object sender, MouseEventArgs e)
        {
            mtxtWeight.Focus();
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
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
