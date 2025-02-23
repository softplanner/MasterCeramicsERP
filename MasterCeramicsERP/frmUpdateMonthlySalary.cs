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

namespace MasterCeramicsERP
{
    public partial class frmUpdateMonthlySalary : Form
    {
        int recordRow = -1, recordSelectedRow = -1;
      
        public frmUpdateMonthlySalary()
        {
            InitializeComponent();
        }

        private void clearRecordDGV()
        {
            recordRow = -1;
            recordSelectedRow = -1;
            dgvRecord.Rows.Clear();
        }

        private void dgvRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            recordSelectedRow = e.RowIndex;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                SalaryForTheMonthOfTableAdapter dal = new SalaryForTheMonthOfTableAdapter();
                dsPayroll.SalaryForTheMonthOfDataTable dt = new dsPayroll.SalaryForTheMonthOfDataTable();
                dt = dal.GetDataByMonth(dtpAttendence.Value.Month,dtpAttendence.Value.Year);
                dgvRecord.DataSource = dt;
                //===============================//
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUpdateMonthlySalary_Load(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           try
           {
               SalaryForTheMonthOfTableAdapter dal=new SalaryForTheMonthOfTableAdapter();
               WorkerLoanInfoTableAdapter dalLoan = new WorkerLoanInfoTableAdapter();
                if (recordSelectedRow.Equals(-1))
                {
                    MessageBox.Show("First select record... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("Are you sure you want to delete ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { 
                    //=====delete report
                    int id = Convert.ToInt32(dgvRecord.Rows[recordSelectedRow].Cells["WorkerID"].Value);
                    DateTime d = Convert.ToDateTime(dgvRecord.Rows[recordSelectedRow].Cells["Date"].Value.ToString());
                    dal.DeleteQuery(d.Month, d.Year, id);
                    //=====update loan 
                    int shortLoan = Convert.ToInt32(dalLoan.getShortLoan(id)) + Convert.ToInt32(dgvRecord.Rows[recordSelectedRow].Cells["DeductShortLoan"].Value.ToString());
                    int advanceLoan = Convert.ToInt32(dalLoan.getAdvanceLoan(id)) + Convert.ToInt32(dgvRecord.Rows[recordSelectedRow].Cells["DeductAdvanceLoan"].Value.ToString());
                    dalLoan.UpdateShortLoan(shortLoan, id);
                    dalLoan.UpdateAdvanceLoan(advanceLoan, id);
                    dgvRecord.Rows.RemoveAt(recordSelectedRow);
                    recordSelectedRow = -1;
                }
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        rptFrmPMonSal report;
        private void btnprintReport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = (DataTable)dgvRecord.DataSource;
                //if (!this.Parent.Contains(report))
                //{
                    report = new rptFrmPMonSal();
                    //report.TopLevel = false;
                    //report.Dock = DockStyle.Fill;
                    //this.Parent.Controls.Add(report);
                    //report.Show();

                    report.dailyReportByMonthDT(dt);
                    report.BringToFront();
                    report.Show();
                //}
                //else
                //{
                //    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
