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
    public partial class frmSalesViewBill : Form
    {
        DataSet dsWorker = new DataSet();
        DataSet dsJobs = new DataSet();
        int vselectedRow = -1;
        public frmSalesViewBill()
        {
            InitializeComponent();
        }

        private void frmSalesViewBill_Load(object sender, EventArgs e)
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
                        dt = dal.GetBillByDate(dtpAttendence.Value.Day, dtpAttendence.Value.Month, dtpAttendence.Value.Year, Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]));
                    }
                    else if (rbtnMonth.Checked.Equals(true))
                    {
                        dt = dal.GetBillByMonth(dtpAttendence.Value.Month, dtpAttendence.Value.Year, Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]));
                    }
                    else if (rbtnYear.Checked.Equals(true))
                    {
                        dt = dal.GetBillByYear(dtpAttendence.Value.Year, Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]));
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
                vselectedRow = -1;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-----report objects
        rptFrmSaleCreateBill report;
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
                    report = new rptFrmSaleCreateBill();
                    report.ReportByDT(dt);
                    report.BringToFront();
                    report.Show();
                }
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
                BillsTableAdapter dal = new BillsTableAdapter();
                dsPayroll.BillsDataTable dt = new dsPayroll.BillsDataTable();
                dt = dal.GetDataByBillNo(dgvViewBy.Rows[vselectedRow].Cells["vBillNo"].Value.ToString());
                dgvOrderInfo.DataSource = dt;
                dgvOrderInfo.Columns["DealerID"].Visible = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
