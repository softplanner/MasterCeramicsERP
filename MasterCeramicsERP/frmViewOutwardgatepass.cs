using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MCERP.DAL;
using MasterCeramicsERP.Datasets;
using MasterCeramicsERP.Datasets.dsPayrollTableAdapters;
using MasterCeramicsERP.Datasets.dsDBTableAdapters;

namespace MasterCeramicsERP
{
    public partial class frmViewOutwardgatepass : Form
    {
        int vselectedRow=-1,selectedRow = -1,rows=-1;
        DataSet dsWorker = new DataSet();
        DataSet dsJobs = new DataSet();
        public frmViewOutwardgatepass()
        {
            InitializeComponent();
        }

        private void frmViewOutwardgatepass_Load(object sender, EventArgs e)
        {
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
                    else if(rbtnMonth.Checked.Equals(true))
                    {
                        dt = dal.GetDataByMonth(dtpAttendence.Value.Month, dtpAttendence.Value.Year, Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]));
                    }
                    else if (rbtnYear.Checked.Equals(true))
                    {
                        dt = dal.GetDataByYear(dtpAttendence.Value.Year, Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]));
                    }
                    else { }
                    if (dt.Rows.Count.Equals(0))
                    {
                        MessageBox.Show("No record found...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dgvViewBy.DataSource = dt;
                    }
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
                rows = -1;

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
                    dgvOrderInfo.Rows.RemoveAt(a-1);
                }
                for (int j = 0; j < b; b--)
                {
                    dgvViewBy.Rows.RemoveAt(b-1);
                }
                selectedRow = -1;
                vselectedRow = -1;
                rows = -1;
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
                if (vselectedRow.Equals(-1))
                {
                    MessageBox.Show("Select record to delete...?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("Are you sure you want to delete ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //---update ready item stock and delete reprot....
                    ReadyItemStockTableAdapter dalReadyItem = new ReadyItemStockTableAdapter();
                    OutwardGatePassTableAdapter dal = new OutwardGatePassTableAdapter();
                    int new_stock = 0, did = 0, iid = 0, stid = 0, sid = 0, cid = 0, catid = 0, qua = 0;
                    int totalRecords = dgvOrderInfo.Rows.Count;
                    string billno = "";
                    billno = dgvViewBy.Rows[vselectedRow].Cells["vBillNo"].Value.ToString();

                    for (int i = 0; i < totalRecords; i++)
                    {
                        iid = Convert.ToInt32(dgvOrderInfo.Rows[i].Cells["ItemID"].Value.ToString());
                        stid = Convert.ToInt32(dgvOrderInfo.Rows[i].Cells["StyleID"].Value.ToString());
                        sid = Convert.ToInt32(dgvOrderInfo.Rows[i].Cells["SizeID"].Value.ToString());
                        cid = Convert.ToInt32(dgvOrderInfo.Rows[i].Cells["ColorID"].Value.ToString());
                        catid = Convert.ToInt32(dgvOrderInfo.Rows[i].Cells["CategoryID"].Value.ToString());
                        qua = Convert.ToInt32(dgvOrderInfo.Rows[i].Cells["Quantity"].Value.ToString());
                        //-----deduct from company ready item stock
                        new_stock = Convert.ToInt32(dalReadyItem.getStockByID(iid, stid, sid, cid, catid)) + qua;
                        dalReadyItem.UpdateQuery(new_stock, iid, stid, sid, cid, catid);
                    }
                    //delete report here...
                    dal.DeleteByBillNo(billno);
                    MessageBox.Show("Report deleted and ready item stock has updated ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    rows = -1;

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
