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
    public partial class salesViewUnpostedOrderByDealer : Form
    {
        int row = -1, selectedRow = -1,orderRow = -1, orderSelectedRow = -1;
        List<OrderPreInfo> lst;
        DataSet dsWorker = new DataSet();
        DataSet dsJobs = new DataSet();

        //PersonDAL personDAL = new PersonDAL();
        //DealerCustomerDAL customerDAL = new DealerCustomerDAL();
        //OrderPreInfoDAL orderDAL = new OrderPreInfoDAL();
        //ItemDAL itemDAL = new ItemDAL();
        //DALItemStyle styleDAL = new DALItemStyle();
        //ItemSizeDAL sizeDAL = new ItemSizeDAL();
        //ColorDAL colorDAL = new ColorDAL();
        //JobsDAL jobDal = new JobsDAL();
        

        public salesViewUnpostedOrderByDealer()
        {
            InitializeComponent();
        }

        private void salesViewUnpostedOrderByDealer_Load(object sender, EventArgs e)
        {
            loadPersonDGV();
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

        private void dgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }
        private void loadOrderDGV()
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                DealerCustomerDAL customerDAL = new DealerCustomerDAL();
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                ColorDAL colorDAL = new ColorDAL();
                
                orderRow = -1;
                orderSelectedRow = -1;
                dgvOrderInfo.Rows.Clear();
                for (int i = 0; i < lst.Count; i++)
                {
                    orderRow = dgvOrderInfo.Rows.Add();
                    dgvOrderInfo.Rows[orderRow].Cells[0].Value = personDAL.getPersonName(lst[i].DealerCustomerID);
                    dgvOrderInfo.Rows[orderRow].Cells[1].Value = customerDAL.getShopName(lst[i].DealerID,lst[i].DealerCustomerID);
                    dgvOrderInfo.Rows[orderRow].Cells[2].Value = itemDAL.getItemName(lst[i].ItemID);
                    dgvOrderInfo.Rows[orderRow].Cells[3].Value = styleDAL.getItemStyleName(lst[i].StyleID);
                    dgvOrderInfo.Rows[orderRow].Cells[4].Value = sizeDAL.getItemSizeName(lst[i].SizeID);
                    dgvOrderInfo.Rows[orderRow].Cells[5].Value = colorDAL.getColorName(lst[i].ColorID);
                    dgvOrderInfo.Rows[orderRow].Cells[6].Value = lst[i].Quantity;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewOrderInfo_Click(object sender, EventArgs e)
        {
            try
            {
                OrderPreInfoDAL orderDAL = new OrderPreInfoDAL();
                
                if (cbxWorker.Text.Equals(""))
                {
                    MessageBox.Show("Select dealer... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false) && rbtnYear.Checked.Equals(false))
                    {
                        MessageBox.Show("Select Day/Month/Year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (rbtnDay.Checked.Equals(true))
                    {
                        lst = new List<OrderPreInfo>();
                        int did = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                        lst = orderDAL.getReportByDateAndDealer(dtpAddOrder.Value.Date, did);
                        if (lst.Count.Equals(0))
                        {
                            MessageBox.Show("No record found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvOrderInfo.Rows.Clear();
                            orderRow = orderSelectedRow = -1;
                        }
                        else
                        {
                            loadOrderDGV();
                        }
                    }
                    else if (rbtnMonth.Checked.Equals(true))
                    {
                        lst = new List<OrderPreInfo>();
                        int did = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                        lst = orderDAL.getReportByMonthAndDealer(dtpAddOrder.Value.Date, did);
                        if (lst.Count.Equals(0))
                        {
                            MessageBox.Show("No record found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvOrderInfo.Rows.Clear();
                            orderRow = orderSelectedRow = -1;
                        }
                        else
                        {
                            loadOrderDGV();
                        }
                    }
                    else if (rbtnYear.Checked.Equals(true))
                    {
                        lst = new List<OrderPreInfo>();
                        int did = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                        lst = orderDAL.getReportByYearAndDealer(dtpAddOrder.Value.Date, did);
                        if (lst.Count.Equals(0))
                        {
                            MessageBox.Show("No record found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvOrderInfo.Rows.Clear();
                            orderRow = orderSelectedRow = -1;
                        }
                        else
                        {
                            loadOrderDGV();
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            row = selectedRow = orderRow = orderSelectedRow = -1;
            dgvOrderInfo.Rows.Clear();
            rbtnDay.Checked = rbtnMonth.Checked = rbtnYear.Checked = false;
        }

        private void cbxSelectJob_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                JobsDAL jobDal = new JobsDAL();

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

    }
}
