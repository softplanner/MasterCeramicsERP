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
    public partial class salesAddSubDealer : Form
    {
        int row = -1, selectedRow = -1,subRow = -1, subSelectedRow = -1;
        
        DataSet dsJobs = new DataSet();
        DataSet dsWorker = new DataSet();
        DataSet dsJobsChecker = new DataSet();
        DataSet dsChecker = new DataSet();

        //PersonDAL personDAL = new PersonDAL();
        //DealerCustomerDAL customerDAL = new DealerCustomerDAL();
        //JobsDAL jobDal = new JobsDAL();

        public salesAddSubDealer()
        {
            InitializeComponent();
        }
        private void loadPersonDGV()
        {
            try
            {
                JobsDAL jobDal = new JobsDAL();

                //populate cbx supplier
                dsJobs.Clear();
                dsJobs = jobDal.getAllJobsDataSet();
                cbxSelectJob.DataSource = dsJobs.Tables[0];
                cbxSelectJob.DisplayMember = "Name";
                //end populate
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //try
            //{
            //    row = -1;
            //    selectedRow = -1;
            //    dgvPerson.Rows.Clear();
            //    List<Person> lst = new List<Person>();
            //    lst = personDAL.getPersonByJobs("Dealer");
            //    lst.TrimExcess();
            //    for (int i = 0; i < lst.Count; i++)
            //    {
            //        row = dgvPerson.Rows.Add();
            //        dgvPerson.Rows[row].Cells[0].Value = lst[i].ID.ToString();
            //        dgvPerson.Rows[row].Cells[1].Value = lst[i].Name;
            //    }
            //}
            //catch (Exception exp)
            //{
            //    MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void loadSubDealerDGV()
        {
            try
            {
                JobsDAL jobDal = new JobsDAL();
                //populate cbx supplier
                dsJobsChecker.Clear();
                dsJobsChecker = jobDal.getAllJobsDataSet();
                cbxJobChecker.DataSource = dsJobsChecker.Tables[0];
                cbxJobChecker.DisplayMember = "Name";
                //end populate
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //try
            //{
            //    subRowAll = -1;
            //    subSelectedRowAll= -1;
            //    dgvSubDealer.Rows.Clear();
            //    List<Person> lst = new List<Person>();
            //    lst = personDAL.getPersonByJobs("Sub Dealer");
            //    lst.TrimExcess();
            //    for (int i = 0; i < lst.Count; i++)
            //    {
            //        subRowAll = dgvSubDealer.Rows.Add();
            //        dgvSubDealer.Rows[subRowAll].Cells[0].Value = lst[i].ID.ToString();
            //        dgvSubDealer.Rows[subRowAll].Cells[1].Value = lst[i].Name;
            //    }
            //}
            //catch (Exception exp)
            //{
            //    MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void loadSelectedSubDealer()
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                DealerCustomerDAL customerDAL = new DealerCustomerDAL();

                subRow = -1;
                subSelectedRow = -1;
                dgvSelectedCustomers.Rows.Clear();
                List<int> lst = new List<int>();
                lst = customerDAL.getAllDealerCustomer(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]));
                lst.TrimExcess();
                for (int i = 0; i < lst.Count; i++)
                {
                    subRow = dgvSelectedCustomers.Rows.Add();
                    dgvSelectedCustomers.Rows[subRow].Cells[0].Value = lst[i].ToString();
                    dgvSelectedCustomers.Rows[subRow].Cells[1].Value = personDAL.getPersonName(lst[i]);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salesAddSubDealer_Load(object sender, EventArgs e)
        {
            loadPersonDGV();
            loadSubDealerDGV();
        }

        //private void dgvPerson_CellClick(object sender,DataGridViewCellEventArgs e)
        //{
        //    selectedRow = e.RowIndex;
        //    if (selectedRow != -1)
        //    {
        //        clearTextFeilds();
        //        loadSelectedSubDealer();
        //        txtDealer.Text = dgvPerson.Rows[selectedRow].Cells[1].Value.ToString();
        //    }
        //}
        private void dgvSelectedCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            subSelectedRow = e.RowIndex;
            if (subSelectedRow != -1)
            {
                getShopName();
            }
        }
        private void getShopName()
        {
            try
            {
                DealerCustomerDAL customerDAL = new DealerCustomerDAL();

                int did = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                int cid = Convert.ToInt32(dgvSelectedCustomers.Rows[subSelectedRow].Cells[0].Value);
                txtSubDealer.Text = dgvSelectedCustomers.Rows[subSelectedRow].Cells[1].Value.ToString();
                txtShopName.Text = customerDAL.getShopName(did, cid);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private void dgvSubDealer_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    subSelectedRowAll = e.RowIndex;
        //    if (subSelectedRowAll != -1)
        //    {
        //        txtSubDealer.Text = dgvSubDealer.Rows[subSelectedRowAll].Cells[1].Value.ToString();
        //    }
        //}
        private void clearTextFeilds()
        {
            txtDealer.Text = "";
            txtSubDealer.Text = "";
            txtShopName.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxWorker.Text.Equals(""))
                {
                    MessageBox.Show("Select dealer... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbxChecker.Text.Equals(""))
                {
                    MessageBox.Show("Select sub-dealer... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtShopName.Text.Equals(""))
                {
                    MessageBox.Show("Enter shop name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //else if (customerDAL.checkIsAlreadyExist(Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells[0].Value), Convert.ToInt32(dgvSubDealer.Rows[subSelectedRowAll].Cells[0].Value)).Equals(true))
                //{
                //    MessageBox.Show("This Sub-Dealer already assigned...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                else
                {
                    DealerCustomerDAL customerDAL = new DealerCustomerDAL();

                    DealerCustomer d = new DealerCustomer();
                    d.DealerID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                    d.DealerCustomerID = Convert.ToInt32(dsChecker.Tables[0].Rows[cbxChecker.SelectedIndex]["ID"]);
                    d.ShopName = txtShopName.Text;
                    customerDAL.addDealerCustomer(d);
                    MessageBox.Show("Sub dealer has been added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadSelectedSubDealer();
                    clearTextFeilds();

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearTextFeilds();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxWorker.Text.Equals(""))
                {
                    MessageBox.Show("Select dealer... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (subSelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select sub dealer... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //else if (customerDAL.isDealerAndCustomerExistInOrderPre(Convert.ToInt32(dgvPerson.Rows[selectedRow].Cells[0].Value),Convert.ToInt32(dgvSelectedCustomers.Rows[subSelectedRow].Cells[0].Value)).Equals(true))
                //{
                //    MessageBox.Show("Some other information depends upon it...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                else
                {
                    DealerCustomerDAL customerDAL = new DealerCustomerDAL();

                    customerDAL.deleteDealerCustomer(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]), Convert.ToInt32(dgvSelectedCustomers.Rows[subSelectedRow].Cells[0].Value));
                    MessageBox.Show("Deleted Successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSelectedCustomers.Rows.RemoveAt(subSelectedRow);
                    subSelectedRow = -1;
                    selectedRow = -1;
                    subRow--;
                    clearTextFeilds();
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
                if (cbxWorker.Text.Equals(""))
                {
                    MessageBox.Show("Select dealer... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (subSelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select sub dealer... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtShopName.Text.Equals(""))
                {
                    MessageBox.Show("Enter shop name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DealerCustomerDAL customerDAL = new DealerCustomerDAL();

                    DealerCustomer d = new DealerCustomer();
                    d.DealerID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                    d.DealerCustomerID=Convert.ToInt32(dgvSelectedCustomers.Rows[subSelectedRow].Cells[0].Value);
                    d.ShopName=txtShopName.Text;
                    customerDAL.updateInfo(d); ;
                    MessageBox.Show("Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getShopName();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtShopName_MouseClick(object sender, MouseEventArgs e)
        {
            txtShopName.Focus();
        }

        private void cbxSelectJob_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                JobsDAL jobDal = new JobsDAL();

                dgvSelectedCustomers.Rows.Clear();
                subRow = subSelectedRow = -1;
                lblWorker.Text = cbxSelectJob.Text;
                //populate cbx supplier
                dsWorker.Clear();
                dsWorker = personDAL.getPersonByJobDataset(jobDal.getJobID(cbxSelectJob.Text));
                cbxWorker.DataSource = dsWorker.Tables[0];
                cbxWorker.DisplayMember = "Name";
                //end populate
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxWorker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clearTextFeilds();
            loadSelectedSubDealer();
            txtDealer.Text = cbxWorker.Text;
        }

        private void cbxChecker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                JobsDAL jobDal = new JobsDAL();

                lblChecker.Text = cbxJobChecker.Text;
                //populate cbx supplier
                dsChecker.Clear();
                dsChecker = personDAL.getPersonByJobDataset(jobDal.getJobID(cbxJobChecker.Text));
                cbxChecker.DataSource = dsChecker.Tables[0];
                cbxChecker.DisplayMember = "Name";
                //end populate

            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxJobChecker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                JobsDAL jobDal = new JobsDAL();

                lblChecker.Text = cbxJobChecker.Text;
                //populate cbx supplier
                dsChecker.Clear();
                dsChecker = personDAL.getPersonByJobDataset(jobDal.getJobID(cbxJobChecker.Text));
                cbxChecker.DataSource = dsChecker.Tables[0];
                cbxChecker.DisplayMember = "Name";
                //end populate

            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxChecker_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            txtSubDealer.Text = cbxChecker.Text;
            
        }
       
    }
}
