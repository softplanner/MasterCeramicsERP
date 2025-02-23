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
    public partial class frmViewAttendenceRecord : Form
    {
        int selectedRow = -1,recordSelectedRow=-1;
        public frmViewAttendenceRecord()
        {
            InitializeComponent();
        }
        private void loadPersonDGV()
        {
            try
            {
                dtpAttendence.Format = DateTimePickerFormat.Time;
                PersonTableAdapter dal = new PersonTableAdapter();
                dsPayroll.PersonDataTable dt = new dsPayroll.PersonDataTable();
                dt = dal.GetPersonInfo("Worker");
                dgvPerson.DataSource = dt;
                dgvPerson.Columns["ID"].Visible = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void frmViewAttendenceRecord_Load(object sender, EventArgs e)
        {
            loadPersonDGV();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                WorkerAttandanceTableAdapter dal = new WorkerAttandanceTableAdapter();
                dsPayroll.WorkerAttandanceDataTable dt = new dsPayroll.WorkerAttandanceDataTable();

                if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false) && rbtnYear.Checked.Equals(false))
                {
                    MessageBox.Show("First select some critaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //===============================
                else if (rbtnDay.Checked.Equals(true) && selectedRow.Equals(-1))
                {
                    dt = dal.GetDataByDate(dtpAttendence.Value.Day,dtpAttendence.Value.Month,dtpAttendence.Value.Year,"Worker");
                    dgvRecord.DataSource = dt;
                }
                else if (rbtnDay.Checked.Equals(true) && selectedRow != -1)
                {
                    //if (selectedRow.Equals(-1))
                    //{
                    //    MessageBox.Show("Select worker...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    //else
                    //{
                        int wid = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells["ID"].Value.ToString());
                        dt = dal.GetDataByDayWorker(dtpAttendence.Value.Day, dtpAttendence.Value.Month, dtpAttendence.Value.Year, "Worker",wid);
                        dgvRecord.DataSource = dt;
                    //}
                }
                else if (rbtnMonth.Checked.Equals(true) && selectedRow.Equals(-1))
                {
                    dt = dal.GetDataByMonth(dtpAttendence.Value.Month, dtpAttendence.Value.Year, "Worker");
                    dgvRecord.DataSource = dt;
                }
                else if (rbtnMonth.Checked.Equals(true) && selectedRow != -1)
                {
                    if (selectedRow.Equals(-1))
                    {
                        MessageBox.Show("Select worker", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int wid = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells["ID"].Value.ToString());
                        dt = dal.GetDataMonthWorker(dtpAttendence.Value.Month, dtpAttendence.Value.Year, "Worker", wid);
                        dgvRecord.DataSource = dt;
                    }
                }
                else if (rbtnYear.Checked.Equals(true))
                {
                    if (selectedRow.Equals(-1))
                    {
                        MessageBox.Show("Select worker", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int wid = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells["ID"].Value.ToString());
                        dt = dal.GetDataByYearWorker(dtpAttendence.Value.Year, "Worker", wid);
                        dgvRecord.DataSource = dt;
                    }
                }
                else{ }
                dgvRecord.Columns["WorkerID"].Visible = false;
                //===============================//
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----report object
        rptFrmViewAttendence report;
        private void btnprintReport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = (DataTable)dgvRecord.DataSource;
                //if (!this.Parent.Contains(report))
                //{
                    report = new rptFrmViewAttendence();
                    //report.TopLevel = false;
                    //report.Dock = DockStyle.Fill;
                    //this.Parent.Controls.Add(report);
                    //report.Show();
                    
                    if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false) && rbtnYear.Checked.Equals(false))
                    {
                        MessageBox.Show("Select view report type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(rbtnDay.Checked.Equals(true) && selectedRow.Equals(-1))
                    {
                        report.dailyReportByDateDT(dt);
                        report.BringToFront();
                        report.Show();
                    }
                    else if (rbtnDay.Checked.Equals(true) &selectedRow != -1)
                    {
                        report.dailyReportByWorkerDT(dt);
                        report.BringToFront();
                        report.Show();
                    }
                    else if (rbtnMonth.Checked.Equals(true) && selectedRow.Equals(-1))
                    {
                        report.dailyReportByDateDT(dt);
                        report.BringToFront();
                        report.Show();
                    }
                    else if (rbtnMonth.Checked.Equals(true) && selectedRow != -1)
                    {
                        report.dailyReportByWorkerDT(dt);
                        report.BringToFront();
                        report.Show();
                    }
                    else if (rbtnYear.Checked.Equals(true))
                    {
                        if (selectedRow.Equals(-1))
                        {
                            MessageBox.Show("Select worker...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            report.dailyReportByDateDT(dt);
                            report.BringToFront();
                            report.Show();
                        }
                    }
                    else { }
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (recordSelectedRow.Equals(-1))
                { 
                    MessageBox.Show("Select Worker Report Record?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtQuantity.Text.Equals(""))
                {
                    MessageBox.Show("Enter extra attandance days ?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int wid = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells["ID"].Value.ToString());
                    WorkerAttandanceTableAdapter dal = new WorkerAttandanceTableAdapter();
                    int chk = Convert.ToInt32(dal.IsWorkerPresent(dtpAttendence.Value.Day, dtpAttendence.Value.Month, dtpAttendence.Value.Year, wid));
                    AttandanceWorkerNew w = new AttandanceWorkerNew();
                    w.WorkerID = wid;
                    w.Status = 1;
                    w.ExtraAttandance = Convert.ToInt32(txtQuantity.Text);
                    w.DateTime_Attandance = Convert.ToDateTime(dtpAttendence.Value.ToString());

                    dal.UpdateQuery(w.ExtraAttandance, w.Status, w.WorkerID, w.DateTime_Attandance.Day, w.DateTime_Attandance.Month, w.DateTime_Attandance.Year);

                    txtQuantity.Text = "";
                    selectedRow = -1;
                    MessageBox.Show("Extra Attandance Marked ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            recordSelectedRow = e.RowIndex;    
        }

        private void btnMarkdAttandance_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select Worker ?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int wid = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells["ID"].Value.ToString());
                    WorkerAttandanceTableAdapter dal = new WorkerAttandanceTableAdapter();
                    int chk = Convert.ToInt32(dal.IsWorkerPresent(dtpAttendence.Value.Day, dtpAttendence.Value.Month, dtpAttendence.Value.Year, wid));
                    if (chk > 0)
                    {
                        MessageBox.Show("Already Present", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        AttandanceWorkerNew w = new AttandanceWorkerNew();
                        w.WorkerID = wid;
                        w.Status = 1;
                        w.ExtraAttandance = 0;
                        w.DateTime_Attandance = Convert.ToDateTime(dtpAttendence.Value.ToString());
                        dal.MarkAttandance(w.WorkerID, w.Status, w.ExtraAttandance, w.DateTime_Attandance);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //==============================================================================================================
    }
}
