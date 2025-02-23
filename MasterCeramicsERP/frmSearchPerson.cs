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
    public partial class frmSearchPerson : Form
    {
        BindingSource bsPerson = new BindingSource();
        DataSet dsPerson = new DataSet();
        DataSet dsJobs = new DataSet();

        int selectedRow = -1;

        public frmSearchPerson()
        {
            InitializeComponent();
        }

        private void frmSearchPerson_Load(object sender, EventArgs e)
        {
            loadComboBoxes();
            txtSalary.Text = "0";
        }

        private void clearPersonDGV()
        {
            dgvPerson.Rows.Clear();
            selectedRow = -1;

        }

        private void dgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            mtxtName.Text = dgvPerson.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            cbxJobs.Text = dgvPerson.Rows[e.RowIndex].Cells["Job"].Value.ToString();
            txtStreetAddress.Text = dgvPerson.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            mtxtNumber.Text = dgvPerson.Rows[e.RowIndex].Cells["Contact"].Value.ToString();
            txtSalary.Text = dgvPerson.Rows[e.RowIndex].Cells["Salary"].Value.ToString();
        }


        private void emptyTextFeilds()
        {
            txtStreetAddress.Text = "";
            mtxtName.Text = "";
            mtxtNumber.Text = "";
            txtSalary.Text = "0";
        }

        private void loadComboBoxes()
        {
            try
            {
                JobsDAL jobsDAL = new JobsDAL();
                
                //-------------------------------------------------
                dsJobs = jobsDAL.getAllJobsDataSet();
                cbxJobs.DataSource = dsJobs.Tables[0];
                cbxJobs.DisplayMember = "Name";
                //-------------------------------------------------
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtxtSearchID_MouseClick(object sender, MouseEventArgs e)
        {
            mtxtName.Focus();
        }

        private void mtxtName_MouseClick(object sender, MouseEventArgs e)
        {
            mtxtName.Focus();
        }

        private void mtxtNumber_MouseClick(object sender, MouseEventArgs e)
        {
            mtxtNumber.Focus();
        }

        private void txtStreetAddress_MouseClick(object sender, MouseEventArgs e)
        {
            txtStreetAddress.Focus();
        }

        private void btnPersonProfile_Click(object sender, EventArgs e)
        {
            if (selectedRow.Equals(-1))
            {
                MessageBox.Show("Select person...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmPersonProfile obj = new frmPersonProfile();
                obj.showPersonProfile(Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells[0].Value));
                obj.BringToFront();
                obj.Show();
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (mtxtName.Text == "")
            {
                MessageBox.Show("Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxCategory.Text == "")
            {
                MessageBox.Show("Select Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bindGrid();
            }
        }
        private void bindGrid()
        {
            try
            {
                    selectedRow = -1;
                    PersonDAL personDAL = new PersonDAL();
                    PersonJobsDAL personJobDal = new PersonJobsDAL();
                    dsPerson = personDAL.getPersonByNameAndCategory(mtxtName.Text, cbxCategory.Text);

                    if (dsPerson.Tables[0].Rows.Count > 0)
                    {
                        bsPerson.DataSource = dsPerson.Tables[0];
                        dgvPerson.DataSource = bsPerson;
                        dgvPerson.Refresh();
                        dgvPerson.Columns["ID"].Visible = false;
                        dgvPerson.Columns["Name"].Width = 150;
                        dgvPerson.Columns["Address"].Width = 250;
                        dgvPerson.Columns["Contact"].Width = 250;
                        dgvPerson.Columns["Salary"].Width = 250;
                        dgvPerson.Columns["Job"].Width = 150;
                        dgvPerson.Columns["Category"].Visible = false;
                    }
                    else
                    {
                        bsPerson.DataSource = null;
                        dgvPerson.DataSource = bsPerson;
                        MessageBox.Show("No Record Found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select some record","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else if (cbxCategory.Text.Equals("Worker") && txtSalary.Text.Equals(""))
                {
                    MessageBox.Show("Enter Salary or Wages", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to update this record ?","Confirm Update", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Person objPerson = new Person();
                        PersonDAL dal = new PersonDAL();
                        //PersonJobsDAL personJobDal = new PersonJobsDAL();

                        objPerson.ID = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells["ID"].Value.ToString());
                        objPerson.Name = mtxtName.Text;
                        //objPerson.Job = cbxJobs.Text;
                        //objPerson.Category = dgvPerson.Rows[selectedRow].Cells["Category"].Value.ToString();
                        objPerson.Address = txtStreetAddress.Text;
                        objPerson.Contact = mtxtNumber.Text;
                        objPerson.Salary = Convert.ToInt32(txtSalary.Text);
                        dal.updatePerson(objPerson);

                        emptyTextFeilds();
                        dgvPerson.DataSource = null;
                        //bindGrid();
                    }
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            emptyTextFeilds();
            //bindGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(selectedRow.Equals(-1))
                {
                    MessageBox.Show("Slect some record","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this record ?","Confirm Delete", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        PersonDAL dal = new PersonDAL();
                        dal.deletePerson(Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells["ID"].Value.ToString()));

                        dgvPerson.Rows.RemoveAt(selectedRow);
                        emptyTextFeilds();
                    }
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtSalary_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtSalary.Focus();
        }
    }
}
