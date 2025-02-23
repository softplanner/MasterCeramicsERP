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
using MasterCeramicsERP.Datasets.dsDBTableAdapters; 

namespace MasterCeramicsERP
{
    public partial class frmMoldReceiveRecordShow : Form
    {
        Int16 selectedRow = -1;
        public frmMoldReceiveRecordShow()
        {
            InitializeComponent();
        }

        private void frmMoldReceiveRecordShow_Load(object sender, EventArgs e)
        {
        }
        private void dgvMold_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = Convert.ToInt16(e.RowIndex);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                MoldRegisterRecordTableAdapter dal = new MoldRegisterRecordTableAdapter();
                dsDB.MoldRegisterRecordDataTable dt = new dsDB.MoldRegisterRecordDataTable();
                if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false))
                {
                    MessageBox.Show("Please select some critaria...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //===============================
                if (rbtnDay.Checked.Equals(true))
                {
                    dt = dal.GetDataBy(dtpMold.Value.Day,dtpMold.Value.Month,dtpMold.Value.Year);
                    dgvMold.DataSource = dt;
                    dgvMold.Columns["CasterID"].Visible = false;
                    dgvMold.Columns["ItemID"].Visible = false;
                    dgvMold.Columns["StyleID"].Visible = false;
                    dgvMold.Columns["SizeID"].Visible = false;
                    
                }
                else if (rbtnMonth.Checked.Equals(true))
                {
                    dt = dal.GetDataByMonth(dtpMold.Value.Year, dtpMold.Value.Month);
                    dgvMold.DataSource = dt;
                    dgvMold.Columns["CasterID"].Visible = false;
                    dgvMold.Columns["ItemID"].Visible = false;
                    dgvMold.Columns["StyleID"].Visible = false;
                    dgvMold.Columns["SizeID"].Visible = false;
                }
                else
                { }
                //===============================//
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
                    MessageBox.Show("No record found ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //===================================================================================
        //-----report object
        rptFrmMoldReceive report;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false) )
                {
                    MessageBox.Show("Select some critaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = (DataTable)dgvMold.DataSource;
                    //if (!this.Parent.Contains(report))
                    //{
                        report = new rptFrmMoldReceive();
                        //report.TopLevel = false;
                        //report.Dock = DockStyle.Fill;
                        //this.Parent.Controls.Add(report);
                        //report.Show();

                        if (rbtnDay.Checked.Equals(true))
                        {
                            report.reportByDayDT(dt);
                            report.BringToFront();
                            report.Show();
                        }
                        else if (rbtnMonth.Checked.Equals(true))
                        {
                            report.reportByMonthDT(dt);
                            report.BringToFront();
                            report.Show();
                        }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //==================================================================================================================================
    }
}
