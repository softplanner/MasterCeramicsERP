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
    public partial class frmRawMaterialReport : Form
    {
        DataSet dsSupplier = new DataSet();
        DataSet dsRawMaterial= new DataSet();
        DataSet dsJobs = new DataSet();

        //PersonDAL personDAL = new PersonDAL();
        //RawMaterialDAL rawMaterialDAL = new RawMaterialDAL();
        //JobsDAL jobsDal = new JobsDAL();

        int row = -1,selectedRow=-1;
        
        public frmRawMaterialReport()
        {
            InitializeComponent();
        }

        private void frmRawMaterialReport_Load(object sender, EventArgs e)
        {
            populateCBX();
        }
        private void populateCBX()
        {
            try
            {
                RawMaterialDAL rawMaterialDAL = new RawMaterialDAL();
                JobsDAL jobsDal = new JobsDAL();

                //populate raw material cbx
                dsRawMaterial.Clear();
                dsRawMaterial = rawMaterialDAL.getAllRawMaterialDataSet();
                cbxRawMaterial.DataSource = dsRawMaterial.Tables[0];
                cbxRawMaterial.DisplayMember = "Name";
                //end populate

                //populate cbx supplier
                dsJobs.Clear();
                dsJobs = jobsDal.getAllJobsDataSet();
                cbxSelectJob.DataSource = dsJobs.Tables[0];
                cbxSelectJob.DisplayMember = "Name";
                //end populate
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Equals("")||txtUnitRate.Text.Equals(""))
            {
                MessageBox.Show("Enter quantity...","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else 
            {
                if (row.Equals(-1))
                {
                    addRecord();
                }
                else
                {
                    checkRecord();
                }
            }
        }
        private void checkRecord()
        {
            
            if (cbxRawMaterial.Text.Equals(dgvReport.Rows[row].Cells[0].Value))
            {
                if (cbxSupplier.Text.Equals(dgvReport.Rows[row].Cells[1].Value))
                {
                    if (txtUnitRate.Text.Equals(dgvReport.Rows[row].Cells[2].Value))
                    {
                        dgvReport.Rows[row].Cells[3].Value = Convert.ToString(Convert.ToSingle(dgvReport.Rows[row].Cells[3].Value) + Convert.ToSingle(txtQuantity.Text));
                        dgvReport.Rows[row].Cells[4].Value = Convert.ToString(Convert.ToSingle(dgvReport.Rows[row].Cells[4].Value) + (Convert.ToSingle(txtUnitRate.Text) * Convert.ToSingle(txtQuantity.Text)));
                        return;                        
                    }
                }
            }
            addRecord();
        }
        private void addRecord()
        {
            row = dgvReport.Rows.Add();
            dgvReport.Rows[row].Cells[0].Value = cbxRawMaterial.Text;
            dgvReport.Rows[row].Cells[1].Value = cbxSupplier.Text;
            dgvReport.Rows[row].Cells[2].Value = txtUnitRate.Text;
            dgvReport.Rows[row].Cells[3].Value = txtQuantity.Text;
            dgvReport.Rows[row].Cells[4].Value = Convert.ToString(Math.Round(Convert.ToSingle(txtUnitRate.Text) * Convert.ToSingle(txtQuantity.Text),2));
            dgvReport.Rows[row].Cells[5].Value = DateTime.Now.ToString();
            dgvReport.Rows[row].Cells[6].Value = dsSupplier.Tables[0].Rows[cbxSupplier.SelectedIndex]["ID"].ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRow.Equals(-1))
            {
                MessageBox.Show("First select record...","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else 
            {
                dgvReport.Rows.RemoveAt(selectedRow);
                selectedRow = -1;
                row--;
            }
        }

        private void dgvReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateCBX();
            txtQuantity.Text = "";
            txtUnitRate.Text = "";
        }

        private void btnAddDB_Click(object sender, EventArgs e)
        {
            try
            {
                RawMaterialDAL rawMaterialDAL = new RawMaterialDAL();

                if (row.Equals(-1))
                {
                    MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RawMaterialStockDAL stockDAL = new RawMaterialStockDAL();
                    RawMaterialReport r;
                    RawMaterialReportDAL dal = new RawMaterialReportDAL();
                    for (Int16 i = 0; i <= row; i++)
                    {
                        //=====add report
                        r = new RawMaterialReport();
                        r.RMID = rawMaterialDAL.getMaterialID(dgvReport.Rows[i].Cells[0].Value.ToString());
                        r.SupplierID = Convert.ToInt32(dgvReport.Rows[i].Cells[6].Value.ToString());
                        r.Quantity = Convert.ToSingle(dgvReport.Rows[i].Cells[3].Value.ToString());
                        r.UnitRate = Convert.ToSingle(dgvReport.Rows[i].Cells[2].Value.ToString());
                        r.Date = DateTime.Now;
                        if (dal.isReportExist(r).Equals(true))
                        {
                            r.Quantity = Convert.ToSingle(dal.getCurrentReportInfo(r) + r.Quantity);
                            dal.updateCurrentReport(r);
                            MessageBox.Show("Report has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            dal.addReport(r);
                            MessageBox.Show("Report has been added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //=====end
                        //=====update raw material stock
                        float quantity = Convert.ToSingle(stockDAL.getStock(r.RMID) + r.Quantity);
                        stockDAL.updateStock(r.RMID, quantity);
                        //=====end
                    }
                }
                dgvReport.Rows.Clear();
                row = -1;
                selectedRow = -1;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';

            else if ((e.KeyChar < '0') || (e.KeyChar > '9') || e.KeyChar == '.')
            {
                if (e.KeyChar == '.')
                {
                    if (txtQuantity.Text.Contains("."))
                    {
                    }
                    else
                    {
                        e.KeyChar = '.';
                        return;
                    }
                }
                e.Handled = true;
            }
        }

        private void txtUnitRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';

            else if ((e.KeyChar < '0') || (e.KeyChar > '9') || e.KeyChar == '.')
            {
                if (e.KeyChar == '.')
                {
                    if (txtUnitRate.Text.Contains("."))
                    {
                    }
                    else
                    {
                        e.KeyChar = '.';
                        return;
                    }
                }
                e.Handled = true;
            }
        }

        private void txtUnitRate_MouseClick(object sender, MouseEventArgs e)
        {
            txtUnitRate.Focus();
        }

        private void txtQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            txtQuantity.Focus();
        }

        private void cbxSelectJob_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PersonDAL personDAL = new PersonDAL();
            JobsDAL jobsDal = new JobsDAL();

            //populate cbx supplier
            dsSupplier.Clear();
            dsSupplier = personDAL.getPersonByJobDataset(jobsDal.getJobID(cbxSelectJob.Text));
            cbxSupplier.DataSource = dsSupplier.Tables[0];
            cbxSupplier.DisplayMember = "Name";
            //end populate
        }
    }
}
