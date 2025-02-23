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
    public partial class frmAddAddress : Form
    {
        //PersonDAL personDAL = new PersonDAL();
        //AddressDAL addressDAL = new AddressDAL();
        //ContactDAL contactDAL = new ContactDAL();
        //CityDAL cityDAL = new CityDAL();
        //CountryDAL countryDAL = new CountryDAL();
        //ProvinceDAL provinceDAL = new ProvinceDAL();
        DataSet dsCountry = new DataSet();
        DataSet dsProvince = new DataSet();
        DataSet dsCity = new DataSet();
        int row = -1,selectedRow=-1,addressRow=-1,addressSelectedRow=-1;
        public frmAddAddress()
        {
            InitializeComponent();
        }

        private void frmAddAddress_Load(object sender, EventArgs e)
        {
            loadInitialData();
        }
        private void loadInitialData()
        {
            loadPersonDGV();
            populateAddressTypeComboBox();
            populateCountryComboBox();
        }
        private void loadPersonDGV()
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                row = -1;
                selectedRow = -1;
                dgvPerson.Rows.Clear();
                List<Person> lst = new List<Person>();
                lst = personDAL.getAllPersonIDandName();
                lst.TrimExcess();
                for (int i = 0; i < lst.Count; i++)
                {
                    row = dgvPerson.Rows.Add();
                    dgvPerson.Rows[row].Cells[0].Value = lst[i].ID.ToString();
                    dgvPerson.Rows[row].Cells[1].Value = lst[i].Name;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow != -1)
            {
                loadAddressDGV();
            }
        }
        private void loadAddressDGV()
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                AddressDAL addressDAL = new AddressDAL();
                CityDAL cityDAL = new CityDAL();
                
                addressRow = -1;
                addressSelectedRow = -1;
                dgvAddress.Rows.Clear();
                List<Address> lst = new List<Address>();
                lst = addressDAL.getAddresesListByPerson(Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells[0].Value));
                lst.TrimExcess();
                for (Int16 i = 0; i < lst.Count; i++)
                {
                    addressRow = dgvAddress.Rows.Add();
                    dgvAddress.Rows[addressRow].Cells[0].Value = lst[i].ID.ToString();
                    dgvAddress.Rows[addressRow].Cells[1].Value = personDAL.getPersonName(lst[i].PersonID);
                    dgvAddress.Rows[addressRow].Cells[2].Value = lst[i].AddressType;
                    dgvAddress.Rows[addressRow].Cells[3].Value = lst[i].ZipCode;
                    dgvAddress.Rows[addressRow].Cells[4].Value = cityDAL.getCityName(lst[i].CityID);
                    dgvAddress.Rows[addressRow].Cells[5].Value = lst[i].StreetAddress;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void populateAddressTypeComboBox()
        {
            //-------------------------------------------------
            cbxAddressType.Items.Add(AddressType.Commercial);
            cbxAddressType.Items.Add(AddressType.Residential);
            //-------------------------------------------------
        }
        private void populateCountryComboBox()
        {
            try
            {
                CountryDAL countryDAL = new CountryDAL();
                
                dsCountry.Clear();
                //-------------------------------------------------
                dsCountry = countryDAL.getAllCountries();
                cbxCountry.DataSource = dsCountry.Tables[0];
                cbxCountry.DisplayMember = "Name";
                //-------------------------------------------------
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CountryDAL countryDAL = new CountryDAL();
                ProvinceDAL provinceDAL = new ProvinceDAL();
                
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

        private void cbxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CityDAL cityDAL = new CityDAL();
                CountryDAL countryDAL = new CountryDAL();
                ProvinceDAL provinceDAL = new ProvinceDAL();
                
                dsCity.Clear();
                dsCity = cityDAL.getAllCitiesByProvince(provinceDAL.getProvinceIDByCountryIDAndProvinceName(countryDAL.getCountryID(cbxCountry.Text), cbxProvince.Text));
                cbxCity.DataSource = dsCity.Tables[0];
                cbxCity.DisplayMember = "Name";
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(selectedRow==-1)
            {
                MessageBox.Show("Select person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxCountry.Text == "")
            {
                MessageBox.Show("Select country  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else if (cbxProvince.Text == "")
            {
                MessageBox.Show("Select province  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if (cbxCity.Text == "")
            {
                MessageBox.Show("Select city", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtStreetAddress.Text == "")
            {
                MessageBox.Show("Enter street address ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxAddressType.Text == "")
            {
                MessageBox.Show("Select address type ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mtxtZipCode.Text == "")
            {
                MessageBox.Show("Enter zip/postal code  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    AddressDAL addressDAL = new AddressDAL();
                    CityDAL cityDAL = new CityDAL();
                    
                    //=====add address
                    Address address = new Address();
                    //-----
                    address.PersonID = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells[0].Value);
                    address.AddressType = cbxAddressType.Text;
                    address.StreetAddress = txtStreetAddress.Text;
                    address.CityID = cityDAL.getCityID(cbxCity.Text);
                    address.ZipCode = mtxtZipCode.Text;
                    //--------
                    addressDAL.addAddress(address);
                    //=====end
                    MessageBox.Show("New address has been added... ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception exp)
                {
                    MessageBox.Show(exp.ToString());
                }
                
            }
        }

        private void btnClearFeilds_Click(object sender, EventArgs e)
        {
            emptytextFeilds();
        }
        private void emptytextFeilds()
        {
            txtStreetAddress.Text = "";
            mtxtZipCode.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadInitialData();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (addressSelectedRow == -1)
            {
                MessageBox.Show("Select address ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxCountry.Text == "")
            {
                MessageBox.Show("Select country  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxProvince.Text == "")
            {
                MessageBox.Show("Select province  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (cbxCity.Text == "")
            {
                MessageBox.Show("Select city", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtStreetAddress.Text == "")
            {
                MessageBox.Show("Enter street address ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxAddressType.Text == "")
            {
                MessageBox.Show("Select address type ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mtxtZipCode.Text == "")
            {
                MessageBox.Show("Enter zip/postal code  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    AddressDAL addressDAL = new AddressDAL();
                    CityDAL cityDAL = new CityDAL();
                    
                    //=====update address
                    Address address = new Address();
                    //-----
                    address.ID = Convert.ToInt32(dgvAddress.Rows[addressSelectedRow].Cells[0].Value);
                    address.PersonID = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells[0].Value);
                    address.AddressType = cbxAddressType.Text;
                    address.StreetAddress = txtStreetAddress.Text;
                    address.CityID = cityDAL.getCityID(cbxCity.Text);
                    address.ZipCode = mtxtZipCode.Text;
                    //--------
                    addressDAL.updateAddress(address);
                    //=====end
                    MessageBox.Show("Address has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadAddressDGV();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvAddress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addressSelectedRow = e.RowIndex;
            if(addressSelectedRow!=-1)
            {
            txtStreetAddress.Text = dgvAddress.Rows[addressSelectedRow].Cells[5].Value.ToString();
            mtxtZipCode.Text = dgvAddress.Rows[addressSelectedRow].Cells[3].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (addressSelectedRow == -1)
            {
                MessageBox.Show("Select address ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    AddressDAL addressDAL = new AddressDAL();
                    
                    //=====delete address
                    addressDAL.deleteAddress(Convert.ToInt32(dgvAddress.Rows[addressSelectedRow].Cells[0].Value));
                    //=====end
                    MessageBox.Show("Selected address has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAddress.Rows.RemoveAt(addressSelectedRow);
                    addressSelectedRow = -1;
                    addressRow--;
                    emptytextFeilds();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void mtxtZipCode_MouseClick(object sender, MouseEventArgs e)
        {
            mtxtZipCode.Focus();
        }
    }
}
