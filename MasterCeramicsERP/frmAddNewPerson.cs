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
    public partial class frmAddNewPerson : Form
    {
        DataSet dsSearchjJob = new DataSet();
        DataSet dsJobs = new DataSet();
        DataSet dsSearchPersonType = new DataSet();
        //PersonJobs
        int personID = 0;
        
        public frmAddNewPerson()
        {
            InitializeComponent();
        }

        private void frmAddNewPerson_Load(object sender, EventArgs e)
        {
            populatePersonIDFeild();
            populatePersonTypeComboBox();
            txtSalary.Text = "0";
        }
        private void populatePersonIDFeild()
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                mtxtID.Enabled = false;
                personID = personDAL.countPerson() + 1;
                mtxtID.Text = "MSW-" + Convert.ToString(personID);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populatePersonTypeComboBox() 
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtxtName.Text == "")
                {
                    MessageBox.Show("Enter name ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbxJobs.Text == "")
                {
                    MessageBox.Show("Select type ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbxCategory.Text == "")
                {
                    MessageBox.Show("Select Person Category ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtStreetAddress.Text == "")
                {
                    MessageBox.Show("Enter Address", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (mtxtNumber.Text == "")
                {
                    MessageBox.Show("Enter number  ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbxCategory.Text.Equals("Worker") && txtSalary.Text == "")
                {
                    MessageBox.Show("Enter salary or wages of the worker  ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PersonDAL personDAL = new PersonDAL();
                    PersonJobsDAL personJobDal = new PersonJobsDAL();
                    JobsDAL jobDal = new JobsDAL();
                    //------------------------------------------------------------
                    Person person = new Person();
                    PersonJobs personJob = new PersonJobs();

                    person.Name = mtxtName.Text;
                    person.Category = cbxCategory.Text;
                    person.Contact = mtxtNumber.Text;
                    person.Address = txtStreetAddress.Text;
                    person.Salary = Convert.ToInt32(txtSalary.Text);
                    int newPersonID = personDAL.addPerson(person);

                    
                    personJob.JobTitle = jobDal.getJobID(cbxJobs.Text);
                    personJob.PersonID = newPersonID;
                    personJobDal.addJob(personJob);
                    //------------------------------------------------------------
                    MessageBox.Show("New person has been added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populatePersonIDFeild();
                    emptyTextFeilds();
                    txtSalary.Text = "0";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void emptyTextFeilds()
        {
            txtStreetAddress.Text = "";
            mtxtID.Text = "";
            mtxtName.Text = "";
            mtxtNumber.Text="";
            txtSalary.Text = "0";
        }

        private void btnClearFeilds_Click(object sender, EventArgs e)
        {
            emptyTextFeilds();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populatePersonIDFeild();
            populatePersonTypeComboBox();
        }

        private void mtxtName_MouseClick(object sender, MouseEventArgs e)
        {
            mtxtName.Focus();
        }

        private void mtxtNumber_MouseClick(object sender, MouseEventArgs e)
        {
            mtxtNumber.Focus();
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
