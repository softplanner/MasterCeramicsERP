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
    public partial class frmAddJobs : Form
    {
        BindingSource bs = new BindingSource();
        DataSet ds = new DataSet();
        //JobsDAL dal = new JobsDAL();

        int selectedRow = -1,row=-1;
        
        public frmAddJobs()
        {
            InitializeComponent();
        }

        private void frmAddJobs_Load(object sender, EventArgs e)
        {
            btnManagePersonJob.Visible = false;
            txtID.Enabled = false;
            loadDataGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                JobsDAL dal = new JobsDAL();

                if (txtName.Text.Equals(""))
                {
                    MessageBox.Show("Enter name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dal.IsAlreadyExist(txtName.Text).Equals(true))
                {
                    MessageBox.Show("This job already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dal.addNewJob(txtName.Text);
                    txtID.Text = "";
                    txtName.Text = "";
                    MessageBox.Show("New job has been added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGrid();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearFeild_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
        }
        private void loadDataGrid()
        {
            try
            {
                JobsDAL dal = new JobsDAL();

                selectedRow = -1;
                row = -1;
                dgvrawMaterial.Rows.Clear();
                List<Jobs> lst = new List<Jobs>();
                lst = dal.getAllJobList();
                lst.TrimExcess();
                for (Int16 i = 0; i < lst.Count; i++)
                {
                    row = dgvrawMaterial.Rows.Add();
                    dgvrawMaterial.Rows[row].Cells[0].Value = lst[i].ID.ToString();
                    dgvrawMaterial.Rows[row].Cells[1].Value = lst[i].Name;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void dgvrawMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                if (selectedRow != -1)
                {
                    txtID.Text = dgvrawMaterial.Rows[selectedRow].Cells[0].Value.ToString();
                    txtName.Text = dgvrawMaterial.Rows[selectedRow].Cells[1].Value.ToString();
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                JobsDAL dal = new JobsDAL();

                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First select job...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dal.IsAlreadyExist(txtName.Text).Equals(true))
                {
                    MessageBox.Show("This job already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Jobs obj = new Jobs();
                    obj.ID = Convert.ToInt16(txtID.Text);
                    obj.Name = txtName.Text;
                    dal.updateJob(obj);
                    MessageBox.Show("Job has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGrid();
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
                if (MessageBox.Show("Are you sure you want to delete this job ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    JobsDAL dal = new JobsDAL();
                    if (selectedRow.Equals(-1))
                    {
                        MessageBox.Show("First select job...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dal.IsPersonDependsUponThisJob(Convert.ToInt16(txtID.Text)).Equals(true))
                    {
                        MessageBox.Show("Can't delete this job...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dal.deleteJob(Convert.ToInt16(txtID.Text));
                        txtID.Text = "";
                        txtName.Text = "";
                        MessageBox.Show("Selected job has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDataGrid();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //frmPersonJobs report;
        private void btnManagePersonJob_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!this.Parent.Contains(report))
                //{
                    //report = new frmPersonJobs();
                    //report.TopLevel = false;
                    //report.Dock = DockStyle.Fill;
                    //this.Parent.Controls.Add(report);
                    //report.Show();
                    //report.BringToFront();
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

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Focus();
        }
    }
}
