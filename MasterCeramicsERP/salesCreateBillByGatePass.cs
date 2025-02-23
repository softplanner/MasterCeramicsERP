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
    public partial class salesCreateBillByGatePass : Form
    {
        int vselectedRow = -1, selectedRow = -1;
        DataSet dsWorker = new DataSet();
        DataSet dsJobs = new DataSet();

        public salesCreateBillByGatePass()
        {
            InitializeComponent();
        }

        private void salesCreateBillByGatePass_Load(object sender, EventArgs e)
        {
            dtpAttendence.Format = DateTimePickerFormat.Time;
            loadComboBoxes();
        }
        private void loadComboBoxes()
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
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false) && rbtnYear.Checked.Equals(false))
                {
                    MessageBox.Show("Select some critaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbxWorker.Text.Equals(""))
                {
                    MessageBox.Show("Select dealer...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    OutwardGPUtilityTableAdapter dal = new OutwardGPUtilityTableAdapter();
                    dsPayroll.OutwardGPUtilityDataTable dt = new dsPayroll.OutwardGPUtilityDataTable();
                    if (rbtnDay.Checked.Equals(true))
                    {
                        dt = dal.GetData(dtpAttendence.Value.Day, dtpAttendence.Value.Month, dtpAttendence.Value.Year, Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]));
                    }
                    else if (rbtnMonth.Checked.Equals(true))
                    {
                        dt = dal.GetDataByMonth(dtpAttendence.Value.Month, dtpAttendence.Value.Year, Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]));
                    }
                    else if (rbtnYear.Checked.Equals(true))
                    {
                        dt = dal.GetDataByYear(dtpAttendence.Value.Year, Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]));
                    }
                    else { }
                    dgvViewBy.DataSource = dt;
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
                int b = dgvViewBy.Rows.Count;

                for (int i = 0; i < a; a--)
                {
                    dgvOrderInfo.Rows.RemoveAt(a - 1);
                }
                for (int j = 0; j < b; b--)
                {
                    dgvViewBy.Rows.RemoveAt(b - 1);
                }
                selectedRow = -1;
                vselectedRow = -1;

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

        private void cbxWorker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                int a = dgvOrderInfo.Rows.Count;
                int b = dgvViewBy.Rows.Count;

                for (int i = 0; i < a; a--)
                {
                    dgvOrderInfo.Rows.RemoveAt(a - 1);
                }
                for (int j = 0; j < b; b--)
                {
                    dgvViewBy.Rows.RemoveAt(b - 1);
                }
                selectedRow = -1;
                vselectedRow = -1;
                txtShop.Text = cbxWorker.Text;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvViewBy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vselectedRow = e.RowIndex;
                OutwardGatePassTableAdapter dal = new OutwardGatePassTableAdapter();
                dsPayroll.OutwardGatePassDataTable dt = new dsPayroll.OutwardGatePassDataTable();
                dt = dal.GetDataByBillNo(dgvViewBy.Rows[vselectedRow].Cells["vBillNo"].Value.ToString());
                dgvOrderInfo.DataSource = dt;
                dgvOrderInfo.Columns["DealerID"].Visible = false;
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

        //-----report objects
        rptFrmOutwardGatePass report;
        private void btnprintReport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = (DataTable)dgvOrderInfo.DataSource;
                if (dgvOrderInfo.Rows.Count.Equals(0))
                {
                    MessageBox.Show("No record found !......", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    report = new rptFrmOutwardGatePass();
                    report.reportByDataTable(dt);
                    report.BringToFront();
                    report.Show();
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
                if (dgvOrderInfo.Rows.Count.Equals(0))
                {
                    MessageBox.Show("No record found...?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtDiscount.Text == "")
                {
                    MessageBox.Show("Enter discount percentage...?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("Are you sure you want to create bill?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Dealer = null, Shop = null, Item = null, Style = null, Size = null, Color = null, Category = null, BillNo = null;
                    int DealerID = 0, Quantity = 0, UnitPrice = 0, Total = 0, Discount = 0, NetAmount = 0, TotalPrice = 0;
                    ItemPriceTableAdapter dalItemPrice = new ItemPriceTableAdapter();
                    BillsTableAdapter dalBill = new BillsTableAdapter();
                    DateTime d;
                    BillNo = dgvOrderInfo.Rows[0].Cells["BillNo"].Value.ToString();
                    if (dalBill.CheckIsBillExist(BillNo) == null)
                    {
                        // read data for bill
                        int totalRecords = dgvOrderInfo.Rows.Count;
                        DealerID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"].ToString());
                        Dealer = cbxWorker.Text;
                        Shop = txtShop.Text;
                        d = DateTime.Now;
                        for (int i = 0; i < totalRecords; i++)
                        {
                            Item = dgvOrderInfo.Rows[i].Cells["Item"].Value.ToString();
                            Style = dgvOrderInfo.Rows[i].Cells["Style"].Value.ToString();
                            Size = dgvOrderInfo.Rows[i].Cells["Size"].Value.ToString();
                            Color = dgvOrderInfo.Rows[i].Cells["Color"].Value.ToString();
                            Category = dgvOrderInfo.Rows[i].Cells["Category"].Value.ToString();
                            BillNo = dgvOrderInfo.Rows[i].Cells["BillNo"].Value.ToString();
                            Quantity = Convert.ToInt32(dgvOrderInfo.Rows[i].Cells["Quantity"].Value.ToString());
                            if (dalItemPrice.checkIsitemExist(Item, Style, Size, Color, Category) == null)
                            {
                                UnitPrice = 0;
                            }
                            else
                            {
                                UnitPrice = Convert.ToInt32(dalItemPrice.getItemPriceByName(Item, Style, Size, Color, Category));
                            }
                            TotalPrice = UnitPrice * Quantity;
                            Total = Total + TotalPrice;
                            Discount = Convert.ToInt32(txtDiscount.Text);
                            NetAmount = Total - ((Total * Discount) / 100);
                            //-----add bill here
                            dalBill.InsertQuery(Dealer, Shop, Item, Style, Size, Color, Quantity, UnitPrice, TotalPrice, Total, d, Category, BillNo, DealerID, Discount, NetAmount);
                            TotalPrice = UnitPrice = Discount = 0;
                        }
                        MessageBox.Show("Bill created...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        int a = dgvOrderInfo.Rows.Count;
                        int b = dgvViewBy.Rows.Count;

                        for (int i = 0; i < a; a--)
                        {
                            dgvOrderInfo.Rows.RemoveAt(a - 1);
                        }
                        for (int j = 0; j < b; b--)
                        {
                            dgvViewBy.Rows.RemoveAt(b - 1);
                        }
                        selectedRow = -1;
                        vselectedRow = -1;
                    }
                    else
                    {
                        MessageBox.Show("Already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //---------------------------------------------------------------
                }
                else { }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if (txtDiscount.Text.Length < 3)
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                    e.Handled = true;
            }
            else
            {
                e.Handled = true;
                e.KeyChar = '\b';
            }
        }

        private void txtDiscount_MouseClick(object sender, MouseEventArgs e)
        {
            txtDiscount.Focus();
        }

    }
}
