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
    public partial class frmAddCity : Form
    {
        //ProvinceDAL provinceDAL = new ProvinceDAL();
        //CountryDAL countryDAL = new CountryDAL();
        //CityDAL cityDAL = new CityDAL();

        DataSet dsCountry = new DataSet();
        DataSet dsProvince = new DataSet();
        
        List<City> lst;
        int selectedRow = -1;

        public frmAddCity()
        {
            InitializeComponent();
        }

        private void frmAddCity_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
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
        private void PopulateProvinceCBX()
        {
            try
            {
                ProvinceDAL provinceDAL = new ProvinceDAL();
                CountryDAL countryDAL = new CountryDAL();
                
                dsProvince.Clear();
                dsProvince = provinceDAL.getAllProvinceByCountryID(countryDAL.getCountryID(cbxCountry.Text));
                cbxProvince.DataSource = dsProvince.Tables[0];
                cbxProvince.DisplayMember = "Name";
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
                ProvinceDAL provinceDAL = new ProvinceDAL();
                CountryDAL countryDAL = new CountryDAL();
                CityDAL cityDAL = new CityDAL();

                lst = new List<City>();
                lst = cityDAL.getCitiesListByProvince(provinceDAL.getProvinceIDByCountryIDAndProvinceName(countryDAL.getCountryID(cbxCountry.Text), cbxProvince.Text));
                if (lst.Count.Equals(0))
                {
                    dgvrawMaterial.Rows.Clear();
                    selectedRow = -1;
                }
                else
                {
                    lst.TrimExcess();
                    dgvrawMaterial.Rows.Clear();
                    for (Int16 i = 0; i < lst.Count; i++)
                    {
                        dgvrawMaterial.Rows.Add();
                        dgvrawMaterial.Rows[i].Cells[0].Value = lst[i].CityID.ToString();
                        dgvrawMaterial.Rows[i].Cells[1].Value = lst[i].Name;
                    }
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

        private void dgvrawMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow != -1)
            {
                txtID.Text = dgvrawMaterial.Rows[selectedRow].Cells[0].Value.ToString();
                txtName.Text = dgvrawMaterial.Rows[selectedRow].Cells[1].Value.ToString();
            }
        }

        private void cbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateProvinceCBX();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ProvinceDAL provinceDAL = new ProvinceDAL();
                CountryDAL countryDAL = new CountryDAL();
                CityDAL cityDAL = new CityDAL();

                if (txtName.Text.Equals(""))
                {
                    MessageBox.Show("Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbxProvince.Text.Equals(""))
                {
                    MessageBox.Show("There Is No Province Selected For City First Add Province", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Text = "";
                }
                else if (cityDAL.IsAlreadyExist(txtName.Text, provinceDAL.getProvinceIDByCountryIDAndProvinceName(countryDAL.getCountryID(cbxCountry.Text), cbxProvince.Text)).Equals(true))
                {
                    MessageBox.Show("This City is Already Exist For Selected Province", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    City obj = new City();
                    obj.ProvinceID = provinceDAL.getProvinceIDByCountryIDAndProvinceName(countryDAL.getCountryID(cbxCountry.Text), cbxProvince.Text);
                    obj.Name = txtName.Text;
                    cityDAL.addCity(obj);
                    MessageBox.Show("New city has been added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGrid();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ProvinceDAL provinceDAL = new ProvinceDAL();
                CountryDAL countryDAL = new CountryDAL();
                CityDAL cityDAL = new CityDAL();

                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First Select City From Data Grid For Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cityDAL.IsAlreadyExist(txtName.Text, provinceDAL.getProvinceIDByCountryIDAndProvinceName(countryDAL.getCountryID(cbxCountry.Text), cbxProvince.Text)).Equals(true))
                {
                    MessageBox.Show("This City is Already Exist For Selected Province", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    City obj = new City();
                    obj.ProvinceID = provinceDAL.getProvinceIDByCountryIDAndProvinceName(countryDAL.getCountryID(cbxCountry.Text), cbxProvince.Text);
                    obj.CityID = Convert.ToInt16(txtID.Text);
                    obj.Name = txtName.Text;
                    cityDAL.updateCity(obj);
                    MessageBox.Show("Selected city has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (cbxProvince.Text.Equals(""))
            {
                MessageBox.Show("There is No Province Selected For Add Some City, First Add Province", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                dgvrawMaterial.Rows.Clear();
                selectedRow = -1;
                txtID.Text = "";
                txtName.Text = "";
            }
            else
            {
                loadComboBox();
                loadDataGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First Select City For Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //else if (cityDAL.IsAddressDependsUponThisCity(Convert.ToInt16(txtID.Text)).Equals(true))
                //{
                //    MessageBox.Show("Address Depends to That City So, We Cannot Delete This City", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                else
                {
                    CityDAL cityDAL = new CityDAL();

                    Int16 id = Convert.ToInt16(txtID.Text);
                    cityDAL.deleteCity(id);
                    txtID.Text = "";
                    txtName.Text = "";
                    dgvrawMaterial.Rows.RemoveAt(selectedRow);
                    selectedRow = -1;
                    MessageBox.Show("Selected city has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGrid();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Due to dependencies can't delete this city..." + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < 'A') || (e.KeyChar > 'Z') && (e.KeyChar < 'a') || (e.KeyChar > 'z'))
                e.Handled = true;
        }

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Focus();
        }
        private void cbxProvince_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxProvince.Text.Equals(""))
                {
                    dgvrawMaterial.Rows.Clear();
                    selectedRow = -1;
                    txtID.Text = "";
                    txtName.Text = "";
                }
                else
                {
                    loadDataGrid();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
