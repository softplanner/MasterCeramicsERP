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
    public partial class frmPersonJobs : Form
    {
        //PersonDAL personDAL = new PersonDAL();
        //PersonJobsDAL personJobDAL = new PersonJobsDAL();
        //JobsDAL jobDAL = new JobsDAL();

        int row = -1, selectedRow = -1,jobRow=-1,jobSelectedRow=-1,allJobRow=-1,allJobSelectedRow=-1;
        public frmPersonJobs()
        {
            InitializeComponent();
        }

        private void frmPersonJobs_Load(object sender, EventArgs e)
        {
            loadPersonDGV();
            loadAllJobs();
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

        private void dgvPerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(selectedRow!=-1)
            {
                loadJobs();
            }
        }
        private void loadJobs()
        {
            try
            {
                PersonJobsDAL personJobDAL = new PersonJobsDAL();
                
                jobSelectedRow = -1;
                jobRow = -1;
                dgvrawMaterial.Rows.Clear();
                List<string> lst = new List<string>();
                lst = personJobDAL.getPersonJobs(Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells[0].Value.ToString()));
                lst.TrimExcess();
                for (Int16 i = 0; i <lst.Count; i++)
                {
                    jobRow = dgvrawMaterial.Rows.Add();
                    dgvrawMaterial.Rows[jobRow].Cells[0].Value = lst[i].ToString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadAllJobs()
        {
            try
            {
                JobsDAL jobDAL = new JobsDAL();

                allJobSelectedRow= -1;
                allJobRow = -1;
                dgvAllJobs.Rows.Clear();
                List<Jobs> lst = new List<Jobs>();
                lst = jobDAL.getAllJobList();
                lst.TrimExcess();
                for (Int16 i = 0; i < lst.Count; i++)
                {
                    allJobRow = dgvAllJobs.Rows.Add();
                    dgvAllJobs.Rows[allJobRow].Cells[0].Value = lst[i].ID.ToString();
                    dgvAllJobs.Rows[allJobRow].Cells[1].Value = lst[i].Name;
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
                PersonJobsDAL personJobDAL = new PersonJobsDAL();
                JobsDAL jobDAL = new JobsDAL();

                if (selectedRow == -1)
                {
                    MessageBox.Show("Select person...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (allJobSelectedRow == -1)
                {
                    MessageBox.Show("Select job...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (personJobDAL.isJobAlreadyExist(Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells[0].Value),jobDAL.getJobID(dgvAllJobs.Rows[allJobSelectedRow].Cells[1].Value.ToString())).Equals(true))
                {
                    MessageBox.Show("Job already assigned...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PersonJobs p = new PersonJobs();
                    p.PersonID = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells[0].Value);
                    p.JobTitle = Convert.ToInt16(dgvAllJobs.Rows[allJobSelectedRow].Cells[0].Value);
                    personJobDAL.addJob(p);
                    MessageBox.Show("New job has been assigned...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadJobs();
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
                if (selectedRow == -1)
                {
                    MessageBox.Show("Select person...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (jobSelectedRow == -1)
                {
                    MessageBox.Show("Select job...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PersonJobsDAL personJobDAL = new PersonJobsDAL();
                    JobsDAL jobDAL = new JobsDAL();

                    PersonJobs p = new PersonJobs();
                    p.PersonID = Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells[0].Value);
                    p.JobTitle = jobDAL.getJobID(dgvrawMaterial.Rows[jobSelectedRow].Cells[0].Value.ToString());
                    personJobDAL.deleteJob(p);
                    MessageBox.Show("Job has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadJobs();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Due to dependencies, can't delete this job" + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvrawMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            jobSelectedRow = e.RowIndex;
        }

        private void dgvAllJobs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            allJobSelectedRow = e.RowIndex;
        }
    }
}
