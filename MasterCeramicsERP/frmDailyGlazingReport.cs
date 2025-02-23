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
    public partial class frmDailyGlazingReport : Form
    {
        DataSet dsColor = new DataSet();
        DataSet dsGlazeBooth = new DataSet();
        DataSet dsJobs = new DataSet();
        DataSet dsWorker = new DataSet();
        JobsDAL jobDal = new JobsDAL();
        Int16 row = -1, selectedRow = -1, unglazeRow=-1, unglazeSelectedRow = -1;
        
        public frmDailyGlazingReport()
        {
            InitializeComponent();
        }
        private void frmDailyGlazingReport_Load(object sender, EventArgs e)
        {
            try
            {
                populateComboBoxes();
                populateGridWithGlazeHouseUnglazeStock();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvDailyGlazinReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = Convert.ToInt16(e.RowIndex);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUnGlaze_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                unglazeSelectedRow = Convert.ToInt16(e.RowIndex);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (row == -1)
                {
                    MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PersonDAL personDAL = new PersonDAL();
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    ColorDAL colorDAL = new ColorDAL();
                    DailyGlazingReportN obj = new DailyGlazingReportN();
                    DailyGlazingReportTableAdapter dalDailyReport = new DailyGlazingReportTableAdapter();
                    taUnglazeStockCompany dalUStock = new taUnglazeStockCompany();
                    GlazeStockCompanyTableAdapter dalGStock = new GlazeStockCompanyTableAdapter();
                    int uquantity = 0;
                    int gQuantity = 0;
                    for (Int16 i = 0; i <= row; i++)
                    {
                        //-----save daily glazing report record into database
                        obj = new DailyGlazingReportN();
                        obj.SprayManID = Convert.ToInt32(dgvDailyGlazinReport.Rows[i].Cells["gSprayManID"].Value.ToString());
                        obj.ItemID = itemDAL.getItemID(dgvDailyGlazinReport.Rows[i].Cells["gItem"].Value.ToString());
                        obj.StyleID = styleDAL.getStyleID(dgvDailyGlazinReport.Rows[i].Cells["gStyle"].Value.ToString());
                        obj.SizeID = sizeDAL.getSizeID(dgvDailyGlazinReport.Rows[i].Cells["gSize"].Value.ToString());
                        obj.ColorID = colorDAL.getColorID(dgvDailyGlazinReport.Rows[i].Cells["gColor"].Value.ToString());
                        obj.Quantity = Convert.ToInt32(dgvDailyGlazinReport.Rows[i].Cells["gQuantity"].Value.ToString());
                        obj.Breakage = Convert.ToInt32(dgvDailyGlazinReport.Rows[i].Cells["gBreakage"].Value.ToString());
                        obj.Remarks = dgvDailyGlazinReport.Rows[i].Cells["gRemarks"].Value.ToString();
                        obj.Date = DateTime.Now;

                        dalDailyReport.InsertQuery(obj.SprayManID,obj.ItemID,obj.StyleID,obj.SizeID,obj.ColorID,obj.Quantity,obj.Breakage,obj.Remarks,obj.Date);
                        //------update company unnglaze stock
                        uquantity = Convert.ToInt32(dalUStock.getStockByID(obj.ItemID, obj.StyleID, obj.SizeID)) - (obj.Quantity + obj.Breakage);
                        dalUStock.UpdateStockByID(uquantity, obj.ItemID, obj.StyleID, obj.SizeID);
                        //-----------------------------------
                        //-----update company glazed Stock
                        if (Convert.ToInt32(dalGStock.CheckIsItemExist(obj.ItemID, obj.StyleID, obj.SizeID, obj.ColorID)) > 0)
                        {
                            //update stock item
                            gQuantity = Convert.ToInt32(dalGStock.getStockQuantity(obj.ItemID, obj.StyleID, obj.SizeID, obj.ColorID)) + obj.Quantity;
                            dalGStock.UpdateQueryByID(gQuantity, obj.ItemID, obj.StyleID, obj.SizeID, obj.ColorID);
                        }
                        else
                        {
                            //---add new item in stock
                            dalGStock.InsertQuery(obj.ItemID, obj.StyleID, obj.SizeID, obj.ColorID, obj.Quantity);
                        }
 
                        //--------------------------------
                    }
                    MessageBox.Show("Daily Glazing Report has been added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvDailyGlazinReport.Rows.Clear();
                    row = -1;
                    selectedRow = -1;
                    txtBreakage.Text = "";
                    txtQuantity.Text = "";
                    txtRemarks.Text = "";
                    populateGridWithGlazeHouseUnglazeStock();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (unglazeSelectedRow.Equals(-1))
            {
                MessageBox.Show("Select item's from company unglaze item stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxColor.Text.Equals(""))
            {
                MessageBox.Show("Select color...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtQuantity.Text == "")
            {
                MessageBox.Show("Enter quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxWorker.Text.Equals(""))
            {
                MessageBox.Show("Select SprayMan...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addRowToDataGridMoldCasting();
                unglazeSelectedRow = -1;
            }
        }
        
         private void btnDeleteRecord_Click(object sender, EventArgs e)
         {
             if (MessageBox.Show("Are you sure you want to delete ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             {
                 if (selectedRow == -1)
                 {
                     MessageBox.Show("First select some record...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 }
                 else
                 {
                     dgvDailyGlazinReport.Rows.RemoveAt(selectedRow);
                     selectedRow = -1;
                     row--;
                 }
             }
         }

         private void populateGridWithGlazeHouseUnglazeStock()
        {
            try
            {
                taUnglazeStockCompany dalCompanyStock = new taUnglazeStockCompany();
                dsDB.UnglazeStockCompanyDataTable dt = new dsDB.UnglazeStockCompanyDataTable();
                dt = dalCompanyStock.GetData();
                dgvUnGlaze.DataSource = dt;
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
                GlazeHouseDAL glazeHouseDAL = new GlazeHouseDAL();
                ColorDAL colorDAL = new ColorDAL();
                
                //populate cbx of all color
                dsColor.Clear();
                dsColor = colorDAL.getAllColor();
                cbxColor.DataSource = dsColor.Tables[0];
                cbxColor.DisplayMember = "Name";
                //end populate

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

        private void addRowToDataGridMoldCasting()
        {
            try
            {
                int spraymanId = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                if (Convert.ToInt32(txtQuantity.Text) > Convert.ToInt32(dgvUnGlaze.Rows[unglazeSelectedRow].Cells["uQuantity"].Value.ToString()))
                {
                    MessageBox.Show("Entered quantity is greater than available stock ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {                //////------Show record in the data grid view------//////

                    for (Int16 i = 0; i <= row; i++)
                    {
                        if (dgvDailyGlazinReport.Rows[i].Cells["gSprayManID"].Value.ToString().Equals(spraymanId.ToString()))
                        {
                            if (dgvDailyGlazinReport.Rows[i].Cells["gItem"].Value.ToString().Equals(dgvUnGlaze.Rows[unglazeSelectedRow].Cells["uItem"].Value))
                            {
                                if (dgvDailyGlazinReport.Rows[i].Cells["gStyle"].Value.ToString().Equals(dgvUnGlaze.Rows[unglazeSelectedRow].Cells["uStyle"].Value))
                                {
                                    if (dgvDailyGlazinReport.Rows[i].Cells["gSize"].Value.ToString().Equals(dgvUnGlaze.Rows[unglazeSelectedRow].Cells["uSize"].Value))
                                    {
                                        if (dgvDailyGlazinReport.Rows[i].Cells["gColor"].Value.ToString().Equals(cbxColor.Text))
                                        {
                                            dgvDailyGlazinReport.Rows[i].Cells["gQuantity"].Value = txtQuantity.Text;
                                            if (txtBreakage.Text.Equals(""))
                                            {
                                                dgvDailyGlazinReport.Rows[i].Cells["gBreakage"].Value = 0;
                                            }
                                            else
                                            {
                                                dgvDailyGlazinReport.Rows[i].Cells["gBreakage"].Value = txtBreakage.Text;
                                            }
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    row = Convert.ToInt16(dgvDailyGlazinReport.Rows.Add());
                    dgvDailyGlazinReport.Rows[row].Cells["gSprayManID"].Value = spraymanId;
                    dgvDailyGlazinReport.Rows[row].Cells["gItem"].Value = dgvUnGlaze.Rows[unglazeSelectedRow].Cells["uItem"].Value;
                    dgvDailyGlazinReport.Rows[row].Cells["gStyle"].Value = dgvUnGlaze.Rows[unglazeSelectedRow].Cells["uStyle"].Value;
                    dgvDailyGlazinReport.Rows[row].Cells["gSize"].Value = dgvUnGlaze.Rows[unglazeSelectedRow].Cells["uSize"].Value;
                    dgvDailyGlazinReport.Rows[row].Cells["gColor"].Value = cbxColor.Text;
                    dgvDailyGlazinReport.Rows[row].Cells["gQuantity"].Value = txtQuantity.Text;
                    if (txtBreakage.Text.Equals(""))
                    {
                        dgvDailyGlazinReport.Rows[row].Cells["gBreakage"].Value = 0;
                    }
                    else
                    {
                        dgvDailyGlazinReport.Rows[row].Cells["gBreakage"].Value = txtBreakage.Text;
                    }
                    dgvDailyGlazinReport.Rows[row].Cells["gSprayMan"].Value = cbxWorker.Text;
                    dgvDailyGlazinReport.Rows[row].Cells["gRemarks"].Value = txtRemarks.Text;
                    //dgvDailyGlazinReport.Columns["gSprayManID"].Visible = false;
                }
                ////------End show record in the data grid view------////
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (row >= 0)
                {
                    dgvDailyGlazinReport.Rows.Clear();
                    row = selectedRow = -1;
                }

                PersonDAL personDAL = new PersonDAL();
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

        private void txtBreakage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtBreakage_MouseClick(object sender, MouseEventArgs e)
        {
            txtBreakage.Focus();
        }

   }
}
