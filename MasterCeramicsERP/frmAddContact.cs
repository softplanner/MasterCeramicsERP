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
    public partial class frmAddContact : Form
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
        int row = -1, selectedRow = -1, addressRow = -1, addressSelectedRow = -1;

        public frmAddContact()
        {
            InitializeComponent();
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
        private void frmAddContact_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            loadPersonDGV();
            populateContactTypeComboBox();
        }
        private void dgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(selectedRow!=-1)
            {
            loadContactsDGV();
            mtxtNumber.Text = "";
            }
        }

        private void populateContactTypeComboBox()
        {
            try
            {
                //-------------------------------------------------
                cbxContactType.Items.Add(ContactType.Cell);
                cbxContactType.Items.Add(ContactType.Fax);
                cbxContactType.Items.Add(ContactType.Home);
                cbxContactType.Items.Add(ContactType.Other);
                cbxContactType.Items.Add(ContactType.WLL);
                cbxContactType.Items.Add(ContactType.Work);
                //-------------------------------------------------
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadContactsDGV()
        {
            try
            {
                ContactDAL contactDAL = new ContactDAL();
                
                addressRow = -1;
                addressSelectedRow = -1;
                dgvAddress.Rows.Clear();
                List<Contact> lst = new List<Contact>();
                lst = contactDAL.getContactsListByPerson(Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells[0].Value));
                lst.TrimExcess();
                for (Int16 i = 0; i < lst.Count; i++)
                {
                    addressRow = dgvAddress.Rows.Add();
                    dgvAddress.Rows[addressRow].Cells[0].Value = lst[i].ContactType;
                    dgvAddress.Rows[addressRow].Cells[1].Value = lst[i].Number;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAddress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addressSelectedRow = e.RowIndex;
            if (addressSelectedRow != -1)
            {
                mtxtNumber.Text = dgvAddress.Rows[addressSelectedRow].Cells[1].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select person... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (mtxtNumber.Text.Equals(""))
                {
                    MessageBox.Show("Enter number...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ContactDAL contactDAL = new ContactDAL();
                    
                    Contact c = new Contact();
                    c.PersonID = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells[0].Value);
                    c.ContactType = cbxContactType.Text;
                    c.Number = mtxtNumber.Text;
                    if (contactDAL.isPersonContactExist(c))
                    {
                        MessageBox.Show("Contact already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        contactDAL.addContact(c);
                        MessageBox.Show("New contact has been added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mtxtNumber.Text = "";
                    }
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
                if (addressSelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select contact...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbxContactType.Text.Equals(""))
                {
                    MessageBox.Show("Select contact type...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (mtxtNumber.Text.Equals(""))
                {
                    MessageBox.Show("Enter number...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ContactDAL contactDAL = new ContactDAL();
                    
                    Contact c = new Contact();
                    c.PersonID = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells[0].Value);
                    c.ContactType = cbxContactType.Text;
                    c.Number = mtxtNumber.Text;
                    if (contactDAL.isPersonContactExist(c))
                    {
                        MessageBox.Show("Contact already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        contactDAL.updateContact(c, dgvAddress.Rows[addressSelectedRow].Cells[1].Value.ToString());
                        MessageBox.Show("Contact has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvAddress.Rows[addressSelectedRow].Cells[0].Value = cbxContactType.Text;
                        dgvAddress.Rows[addressSelectedRow].Cells[1].Value = mtxtNumber.Text;
                        mtxtNumber.Text = "";
                    }
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
                if (addressSelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select Contact For Delete ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ContactDAL contactDAL = new ContactDAL();
                    
                    Contact c = new Contact();
                    c.PersonID = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells[0].Value);
                    c.ContactType = cbxContactType.Text;
                    c.Number = mtxtNumber.Text;
                    contactDAL.deleteContact(c);
                    MessageBox.Show("Selected contact has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAddress.Rows.RemoveAt(addressSelectedRow);
                    addressRow--;
                    addressSelectedRow = -1;
                    mtxtNumber.Text = "";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void mtxtNumber_MouseClick(object sender, MouseEventArgs e)
        {
            mtxtNumber.Focus();
        }
        //===========================================================================================================================
    }
}
