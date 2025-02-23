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
using MasterCeramicsERP.Datasets;
using MasterCeramicsERP.Datasets.dsPayrollTableAdapters;
using MasterCeramicsERP.Datasets.dsDBTableAdapters;

namespace MasterCeramicsERP
{
    public partial class frmOutwardGatePass : Form
    {
        int row=-1,selectedRow = -1;

        DataSet dsItems = new DataSet();
        DataSet dsItemStyle = new DataSet();
        DataSet dsItemSize = new DataSet();
        DataSet dsColor = new DataSet();
        DataSet dsWorker = new DataSet();
        DataSet dsJobs = new DataSet();
        DataSet dsCategory = new DataSet();

        public frmOutwardGatePass()
        {
            InitializeComponent();
        }
        private void loadComboBoxes()
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                ColorDAL colorDAL = new ColorDAL();
                KillenItemCategoryDAL killenItemCategoryDAL = new KillenItemCategoryDAL();
                JobsDAL jobDal = new JobsDAL();

                //populate cbx supplier
                dsJobs.Clear();
                dsJobs = jobDal.getAllJobsDataSet();
                cbxSelectJob.DataSource = dsJobs.Tables[0];
                cbxSelectJob.DisplayMember = "Name";
                //end populate

                //populate cbx With All Item
                dsItems.Clear();
                dsItems = itemDAL.getAllItem();
                cbxItem.DataSource = dsItems.Tables[0];
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

                //populate cbx of all Color
                dsColor.Clear();
                dsColor = colorDAL.getAllColorDetail();
                cbxColor.DataSource = dsColor.Tables[0];
                cbxColor.DisplayMember = "Name";
                //end populate

                //populate killen item category cbx
                dsCategory.Clear();
                dsCategory = killenItemCategoryDAL.getAllKillenItemCategoryDetail();
                cbxItemCategory.DataSource = dsCategory.Tables[0];
                cbxItemCategory.DisplayMember = "Name";
                //end populate
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmOutwardGatePass_Load(object sender, EventArgs e)
        {
            try
            {
                dtpAttendence.Format = DateTimePickerFormat.Time;
                //create gate pass number
                GatePassCounter dal = new GatePassCounter();
                //check if the new year has been start then counter set to zero
                dal.updateYear();
                txtGPass.Text = Convert.ToString(dal.getYear()) + "-" + Convert.ToString(dal.getGatePassNo());
                //-----------------------
                loadComboBoxes();
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

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantity.Text.Equals(""))
                {
                    MessageBox.Show("Enter item quantity...?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(cbxWorker.Text.Equals(""))
                {
                    MessageBox.Show("Select Worker...?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(cbxItem.Text.Equals("") || cbxStyle.Text.Equals("") || cbxSize.Text.Equals(""))
                {
                    MessageBox.Show("Select item...?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int i = 0; i < dgvOrderInfo.Rows.Count;i++ )
                    {
                        if(dgvOrderInfo.Rows[i].Cells["Item"].Value.ToString().Equals(cbxItem.Text))
                        {
                            if (dgvOrderInfo.Rows[i].Cells["Style"].Value.ToString().Equals(cbxStyle.Text))
                            {
                                if (dgvOrderInfo.Rows[i].Cells["Size"].Value.ToString().Equals(cbxSize.Text))
                                {
                                    if (dgvOrderInfo.Rows[i].Cells["Color"].Value.ToString().Equals(cbxColor.Text))
                                    {
                                        if (dgvOrderInfo.Rows[i].Cells["Category"].Value.ToString().Equals(cbxItemCategory.Text))
                                        {
                                            dgvOrderInfo.Rows.RemoveAt(i);
                                            selectedRow = -1;
                                            --row;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    row = dgvOrderInfo.Rows.Add();

                    dgvOrderInfo.Rows[row].Cells["ItemID"].Value = Convert.ToInt32(dsItems.Tables[0].Rows[cbxItem.SelectedIndex]["ID"]);
                    dgvOrderInfo.Rows[row].Cells["StyleID"].Value = Convert.ToInt32(dsItemStyle.Tables[0].Rows[cbxStyle.SelectedIndex]["ID"]);
                    dgvOrderInfo.Rows[row].Cells["SizeID"].Value = Convert.ToInt32(dsItemSize.Tables[0].Rows[cbxSize.SelectedIndex]["ID"]);
                    dgvOrderInfo.Rows[row].Cells["ColorID"].Value = Convert.ToInt32(dsColor.Tables[0].Rows[cbxColor.SelectedIndex]["ID"]);
                    dgvOrderInfo.Rows[row].Cells["CategoryID"].Value = Convert.ToInt32(dsCategory.Tables[0].Rows[cbxItemCategory.SelectedIndex]["ID"]);

                    dgvOrderInfo.Rows[row].Cells["Item"].Value = cbxItem.Text;
                    dgvOrderInfo.Rows[row].Cells["Style"].Value = cbxStyle.Text;
                    dgvOrderInfo.Rows[row].Cells["Size"].Value = cbxSize.Text;
                    dgvOrderInfo.Rows[row].Cells["Color"].Value = cbxColor.Text;
                    dgvOrderInfo.Rows[row].Cells["Category"].Value = cbxItemCategory.Text;
                    //dgvOrderInfo.Rows[row].Cells["BillNo"].Value = txtGPass.Text;
                    //dgvOrderInfo.Rows[row].Cells["VehicleDescription"].Value = txtVehicle.Text;
                    dgvOrderInfo.Rows[row].Cells["Quantity"].Value = txtQuantity.Text;
                    //dgvOrderInfo.Rows[row].Cells["Date"].Value = DateTime.Now;
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
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select record...?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("Are you sure you want to delete ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvOrderInfo.Rows.RemoveAt(selectedRow);
                    --row;
                    selectedRow = -1;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOrderInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrderInfo.Rows.Count.Equals(0))
                {
                    MessageBox.Show("No record found...?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(txtVehicle.Text.Equals(""))
                {
                    MessageBox.Show("Enter vehicle description...?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbxWorker.Text.Equals(""))
                {
                    MessageBox.Show("Select dealer...?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int new_stock = 0, did = 0, iid = 0, stid = 0, sid = 0, cid = 0, catid = 0, qua = 0;
                    string vehicleDesc = "", billno = "";
                    DateTime d;
                    OutwardGatePassTableAdapter dal = new OutwardGatePassTableAdapter();
                    ReadyItemStockTableAdapter dalReadyItem = new ReadyItemStockTableAdapter();
                    did = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                    billno = txtGPass.Text;
                    d = Convert.ToDateTime(dtpAttendence.Value.ToString());
                    vehicleDesc = txtVehicle.Text;

                    for (int i = 0; i < dgvOrderInfo.Rows.Count; i++)
                    {
                        iid = Convert.ToInt32(dgvOrderInfo.Rows[i].Cells["ItemID"].Value.ToString());
                        stid = Convert.ToInt32(dgvOrderInfo.Rows[i].Cells["StyleID"].Value.ToString());
                        sid = Convert.ToInt32(dgvOrderInfo.Rows[i].Cells["SizeID"].Value.ToString());
                        cid = Convert.ToInt32(dgvOrderInfo.Rows[i].Cells["ColorID"].Value.ToString());
                        catid = Convert.ToInt32(dgvOrderInfo.Rows[i].Cells["CategoryID"].Value.ToString());
                        qua = Convert.ToInt32(dgvOrderInfo.Rows[i].Cells["Quantity"].Value.ToString());
                        dal.InsertQuery(iid, stid, sid, cid, catid, did, qua, billno, d, vehicleDesc);
                        //-----deduct from company ready item stock
                        //-----first check whether item is present in stock or not if not then added first and set quantity is zero
                        if(dalReadyItem.checkIsItemExist(iid,stid,sid,cid,catid)==null)
                        {
                            dalReadyItem.InsertQuery(iid, stid, sid, cid, catid, 0);
                        }
                        new_stock = Convert.ToInt32(dalReadyItem.getStockByID(iid, stid, sid, cid, catid)) - qua;
                        dalReadyItem.UpdateQuery(new_stock, iid, stid, sid, cid, catid);
                    }
                    MessageBox.Show("Outward gate pass created...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvOrderInfo.Rows.Clear();
                    selectedRow = -1;
                    row = -1;
                    txtQuantity.Text = "";
                    txtVehicle.Text = "";
                    //get new gate pass number
                    GatePassCounter gatePassCounter = new GatePassCounter();
                    gatePassCounter.incrementInGatePassNumber();
                    GatePassCounter dalGP = new GatePassCounter();
                    txtGPass.Text = Convert.ToString(dalGP.getYear()) + "-" + Convert.ToString(dalGP.getGatePassNo());
                    //-----------------------
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxSelectJob_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                int a = dgvOrderInfo.Rows.Count;

                for (int i = 0; i < a; a--)
                {
                    dgvOrderInfo.Rows.RemoveAt(a - 1);
                }
                selectedRow = -1;
                row = -1;
                txtVehicle.Text = "";

                PersonDAL personDAL = new PersonDAL();
                JobsDAL jobDal = new JobsDAL();

                //dgvSelectedCustomers.Rows.Clear();
                //subRow = subSelectedRow = -1;
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

        private void cbxWorker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int a = dgvOrderInfo.Rows.Count;

            for (int i = 0; i < a; a--)
            {
                dgvOrderInfo.Rows.RemoveAt(a - 1);
            }
            selectedRow = -1;
            row = -1;
            txtVehicle.Text = "";

        }

    }
}
