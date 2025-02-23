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
    public partial class frmAddProvince : Form
    {
        //ProvinceDAL dal = new ProvinceDAL();
        //CountryDAL countryDAL = new CountryDAL();

        DataSet dsCountry = new DataSet();
        BindingSource bs = new BindingSource();
        DataSet ds = new DataSet();
        List<Province> lst;
        int selectedRow = -1;

        public frmAddProvince()
        {
            InitializeComponent();
        }

        private void frmAddProvince_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            //loadDataGrid();
            loadComboBox();
        }
        private void loadComboBox() 
        {
            try
            {
                CountryDAL countryDAL = new CountryDAL();

                dsCountry.Clear();
                dsCountry = countryDAL.getAllCountries();
                cbxCountry.DataSource = dsCountry.Tables[0];
                cbxCountry.DisplayMember = "Name";
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadDataGrid()
        {
            try
            {
                ProvinceDAL dal = new ProvinceDAL();
                CountryDAL countryDAL = new CountryDAL();

                dgvrawMaterial.Rows.Clear();
                lst = new List<Province>();
                lst = dal.getAllProvinceListByCountry(countryDAL.getCountryID(cbxCountry.Text));
                lst.TrimExcess();
                for (Int16 i = 0; i < lst.Count; i++)
                {
                    dgvrawMaterial.Rows.Add();
                    dgvrawMaterial.Rows[i].Cells[0].Value = lst[i].ID;
                    dgvrawMaterial.Rows[i].Cells[1].Value = lst[i].Name;
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
                ProvinceDAL dal = new ProvinceDAL();
                CountryDAL countryDAL = new CountryDAL();

                if (txtName.Text.Equals(""))
                {
                    MessageBox.Show("Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dal.IsAlreadyExist(txtName.Text, countryDAL.getCountryID(cbxCountry.Text)).Equals(true))
                {
                    MessageBox.Show("This Province is Already Exist For Selected Country", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Province obj = new Province();
                    obj.CountryID = countryDAL.getCountryID(cbxCountry.Text);
                    obj.Name = txtName.Text;
                    dal.addProvince(obj);
                    MessageBox.Show("New Province Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ProvinceDAL dal = new ProvinceDAL();
                CountryDAL countryDAL = new CountryDAL();

                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First Select Province For Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dal.IsAlreadyExist(txtName.Text, countryDAL.getCountryID(cbxCountry.Text)).Equals(true))
                {
                    MessageBox.Show("This Province is Already Exist For Selected Country", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Province obj = new Province();
                    obj.CountryID = countryDAL.getCountryID(cbxCountry.Text);
                    obj.ID = Convert.ToInt16(txtID.Text);
                    obj.Name = txtName.Text;
                    dal.updateProvince(obj);
                    MessageBox.Show("Province has been updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGrid();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvrawMaterial.Rows.Clear();
            selectedRow = -1;
            loadDataGrid();
            loadComboBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ProvinceDAL dal = new ProvinceDAL();
                CountryDAL countryDAL = new CountryDAL();

                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First Select Province For Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dal.IsCityDependsUponThisProvince(Convert.ToInt16(txtID.Text)).Equals(true))
                {
                    MessageBox.Show("City Depends to That Province So, We Cannot Delete This Province", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Int16 id = Convert.ToInt16(txtID.Text);
                    dal.deleteProvince(id);
                    txtID.Text = "";
                    txtName.Text = "";
                    MessageBox.Show("Province Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGrid();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Due to dependencies can't delete this province...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Focus();
        }

        private void cbxCountry_SelectedValueChanged(object sender, EventArgs e)
        {
            loadDataGrid();
        }
    }
}
