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
    public partial class SalesGoodsTransportCompany : Form
    {
        List<GoodsCompany> lst;
        //GoodsCompanyDAL dal = new GoodsCompanyDAL();
        int selectedRow = -1;

        public SalesGoodsTransportCompany()
        {
            InitializeComponent();
        }

        private void SalesGoodsTransportCompany_Load(object sender, EventArgs e)
        {
            loadDataGrid();
        }
        private void loadDataGrid()
        {
            try
            {
                GoodsCompanyDAL dal = new GoodsCompanyDAL();

                dgvrawMaterial.Rows.Clear();
                selectedRow = -1;
                lst = new List<GoodsCompany>();
                lst = dal.getAllGoodsCompanyList();
                lst.TrimExcess();
                for (Int16 i = 0; i < lst.Count; i++)
                {
                    dgvrawMaterial.Rows.Add();
                    dgvrawMaterial.Rows[i].Cells[0].Value = lst[i].ID;
                    dgvrawMaterial.Rows[i].Cells[1].Value = lst[i].Name.ToString();
                    dgvrawMaterial.Rows[i].Cells[2].Value = lst[i].Address.ToString();
                }
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
                if (txtName.Text.Equals(""))
                {
                    MessageBox.Show("Enter name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtAddress.Text.Equals(""))
                {
                    MessageBox.Show("Enter address...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GoodsCompanyDAL dal = new GoodsCompanyDAL();

                    GoodsCompany g = new GoodsCompany();
                    g.Name = txtName.Text;
                    g.Address = txtAddress.Text;
                    dal.addGoodsCompany(g);
                    MessageBox.Show("New company has been registered...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            selectedRow = -1;
            txtID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
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
                txtID.Text = dgvrawMaterial.Rows[selectedRow].Cells[0].Value.ToString();
                txtName.Text = dgvrawMaterial.Rows[selectedRow].Cells[1].Value.ToString();
                txtAddress.Text= dgvrawMaterial.Rows[selectedRow].Cells[2].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First select some company...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtName.Text.Equals(""))
                {
                    MessageBox.Show("Enter name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtAddress.Text.Equals(""))
                {
                    MessageBox.Show("Enter address...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GoodsCompanyDAL dal = new GoodsCompanyDAL();

                    GoodsCompany g = new GoodsCompany();
                    g.ID = Convert.ToInt16(dgvrawMaterial.Rows[selectedRow].Cells[0].Value);
                    g.Name = txtName.Text;
                    g.Address = txtAddress.Text;
                    dal.updateGoodsCompany(g);
                    MessageBox.Show("Compnay Updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGrid();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                GoodsCompanyDAL dal = new GoodsCompanyDAL();

                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First select company... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dal.checkIsOrderDependent(Convert.ToInt16(txtID.Text)).Equals(true))
                {
                    MessageBox.Show("Some order depends to this compnay...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Int16 id = Convert.ToInt16(txtID.Text);
                    dal.deleteGoodsCompany(id);
                    txtID.Text = "";
                    txtName.Text = "";
                    txtAddress.Text = "";
                    MessageBox.Show("Company has been unregistered...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGrid();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Focus();
        }

        private void txtAddress_MouseClick(object sender, MouseEventArgs e)
        {
            txtAddress.Focus();
        }
    }
}
