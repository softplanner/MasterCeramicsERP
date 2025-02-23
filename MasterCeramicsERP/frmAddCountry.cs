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
    public partial class frmAddCountry : Form
    {
        BindingSource bs = new BindingSource();
        DataSet ds = new DataSet();
        //CountryDAL dal = new CountryDAL();
        int selectedRow = -1,row=-1;

        public frmAddCountry()
        {
            InitializeComponent();
        }

        private void frmAddCountry_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            loadDataGrid();
        }
        private void loadDataGrid()
        {
            try
            {
                CountryDAL dal = new CountryDAL();

                selectedRow = -1;
                row = -1;
                dgvrawMaterial.Rows.Clear();
                List<Country> lst = new List<Country>();
                lst = dal.getAllCountriesList();
                lst.TrimExcess();
                for (Int16 i = 0; i < lst.Count; i++)
                {
                    row = dgvrawMaterial.Rows.Add();
                    dgvrawMaterial.Rows[row].Cells[0].Value = lst[i].ID.ToString();
                    dgvrawMaterial.Rows[row].Cells[1].Value = lst[i].Name;
                }
                //selectedRow = -1;
                //ds = dal.getAllCountries();
                //bs.DataSource = ds;
                //bs.DataMember = ds.Tables[0].TableName;
                //dgvrawMaterial.DataSource = bs;
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
                CountryDAL dal = new CountryDAL();

                if (txtName.Text.Equals(""))
                {
                    MessageBox.Show("Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dal.IsCountryAlreadyExist(txtName.Text).Equals(true))
                {
                    MessageBox.Show("Country already exist...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dal.addCountry(txtName.Text);
                    MessageBox.Show("New country has been added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtID.Text = "";
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
                txtID.Text = dgvrawMaterial.Rows[selectedRow].Cells[0].Value.ToString();
                txtName.Text = dgvrawMaterial.Rows[selectedRow].Cells[1].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CountryDAL dal = new CountryDAL();

                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First Select Country For Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (dal.IsCountryAlreadyExist(txtName.Text).Equals(true))
                {
                    MessageBox.Show("This Country is Already Exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    Country obj = new Country();
                    obj.ID = Convert.ToInt16(txtID.Text);
                    obj.Name = txtName.Text;
                    dal.updateCountry(obj);
                    MessageBox.Show("Country has been updated updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First Select Country For Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                //else if (dal.IsProvinceDependsUponThisCountry(Convert.ToInt16(txtID.Text)).Equals(true))
                //{
                //    MessageBox.Show("Province Depends to That Country So, We Cannot Delete This Country", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                //}
                else
                {
                    CountryDAL dal = new CountryDAL();

                    dal.deleteCountry(Convert.ToInt16(txtID.Text));
                    txtID.Text = "";
                    txtName.Text = "";
                    MessageBox.Show("Selected country has been deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGrid();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Due to dependencies can't delete this country...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Focus();
        }
    }
}
