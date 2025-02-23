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
    public partial class frmRemarks : Form
    {
        BindingSource bs = new BindingSource();
        DataSet ds = new DataSet();
        int selectedRow = -1, row = -1;

        public frmRemarks()
        {
            InitializeComponent();
        }

        private void frmRemarks_Load(object sender, EventArgs e)
        {
            loadDataGrid();
        }
        private void loadDataGrid()
        {
            try
            {
                RemarksDAL dal = new RemarksDAL();

                selectedRow = -1;
                ds = dal.getRemarks();
                bs.DataSource = ds;
                bs.DataMember = ds.Tables[0].TableName;
                dgvrawMaterial.DataSource = bs;
                dgvrawMaterial.Columns[0].Width = 800;

            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                RemarksDAL dal = new RemarksDAL();

                if (txtName.Text.Equals(""))
                {
                    MessageBox.Show("Enter new remarks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dal.IsRemarksAlreadyExist(txtName.Text).Equals(true))
                {
                    MessageBox.Show("Such type of Remarks already exist...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dal.addRemarks(txtName.Text);
                    MessageBox.Show("New remarks has been added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGrid();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearFeild_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void dgvrawMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow != -1)
            {
                txtName.Text = dgvrawMaterial.Rows[selectedRow].Cells[0].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                RemarksDAL dal = new RemarksDAL();

                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First select some remarks ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (dal.IsRemarksAlreadyExist(txtName.Text).Equals(true))
                {
                    MessageBox.Show("Such type of remarks already exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    string oldRemarks = dgvrawMaterial.Rows[selectedRow].Cells[0].Value.ToString();
                    string newRemarks = txtName.Text;
                    dal.updateRemarks(oldRemarks,newRemarks);
                    MessageBox.Show("Remarks has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First select some remarks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    RemarksDAL dal = new RemarksDAL();

                    dal.deleteRemarks(txtName.Text);
                    txtName.Text = "";
                    MessageBox.Show("Selected remarks has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGrid();
                }
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
