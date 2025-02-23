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
    public partial class frmMarkAttendence : Form
    {
        int selectedRow = -1;
        public frmMarkAttendence()
        {
            InitializeComponent();
        }

        private void frmMarkAttendence_Load(object sender, EventArgs e)
        {
            dtpAttandance.Format = DateTimePickerFormat.Time;
            //dtpAttandance.ShowUpDown = true;
            //dtpAttandance.ShowCheckBox = true;
            loadPersonDGV();
        }
        private void loadPersonDGV()
        {
            try
            {
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
            try
            {
                selectedRow = e.RowIndex;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMarkAttendence_Click(object sender, EventArgs e)
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
                    int chk = Convert.ToInt32(dal.IsWorkerPresent(dtpAttandance.Value.Day,dtpAttandance.Value.Month,dtpAttandance.Value.Year,wid));
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
                        w.DateTime_Attandance = Convert.ToDateTime(dtpAttandance.Value.ToString());
                        dal.MarkAttandance(w.WorkerID, w.Status, w.ExtraAttandance, w.DateTime_Attandance);    
                    }
                }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select Worker ?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtQuantity.Text.Equals(""))
                {
                    MessageBox.Show("Enter extra attandance days ?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int wid = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells["ID"].Value.ToString());
                    WorkerAttandanceTableAdapter dal = new WorkerAttandanceTableAdapter();
                    int chk = Convert.ToInt32(dal.IsWorkerPresent(dtpAttandance.Value.Day, dtpAttandance.Value.Month, dtpAttandance.Value.Year, wid));
                    AttandanceWorkerNew w = new AttandanceWorkerNew();
                    w.WorkerID = wid;
                    w.Status = 1;
                    w.ExtraAttandance = Convert.ToInt32(txtQuantity.Text);
                    w.DateTime_Attandance = Convert.ToDateTime(dtpAttandance.Value.ToString());
                    if (chk > 0)
                    {
                        dal.UpdateQuery(w.ExtraAttandance, w.Status, w.WorkerID, w.DateTime_Attandance.Day, w.DateTime_Attandance.Month, w.DateTime_Attandance.Year);
                    }
                    else
                    {
                        dal.MarkAttandance(w.WorkerID, w.Status, w.ExtraAttandance, w.DateTime_Attandance);
                    }
                    txtQuantity.Text = "";
                    selectedRow = -1;
                    MessageBox.Show("Attandance Marked ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //=====================================================================================================================================
    }
}
