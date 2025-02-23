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
    public partial class salesViewUnPostedOrder : Form
    {
        int  orderRow = -1, orderSelectedRow = -1;
        List<OrderPreInfo> lst;
        DataSet dsJobs = new DataSet();
        DataSet dsWorker = new DataSet();
        DataSet dsJobsChecker = new DataSet();
        DataSet dsChecker = new DataSet();

        public salesViewUnPostedOrder()
        {
            InitializeComponent();
        }

        private void salesViewUnPostedOrder_Load(object sender, EventArgs e)
        {
            loadPersonDGV();
            //loadSelectedSubDealer();
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
                else if (cbxChecker.Text.Equals(""))
                {
                    MessageBox.Show("Select sub-dealer... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        int cid = Convert.ToInt32(dsChecker.Tables[0].Rows[cbxChecker.SelectedIndex]["ID"]);
                        lst = orderDAL.getReportByDateDealerAndCustomer(dtpAddOrder.Value.Date, did, cid);
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
                        int cid = Convert.ToInt32(dsChecker.Tables[0].Rows[cbxChecker.SelectedIndex]["ID"]);
                        lst = orderDAL.getReportByMonthDealerAndCustomer(dtpAddOrder.Value.Date, did, cid);
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
                        int cid = Convert.ToInt32(dsChecker.Tables[0].Rows[cbxChecker.SelectedIndex]["ID"]);
                        lst = orderDAL.getReportByYearDealerAndCustomer(dtpAddOrder.Value.Date, did, cid);
                        if (lst.Count.Equals(0))
                        {
                            MessageBox.Show("No Record Found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void loadOrderDGV()
        {
            try
            {
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
                    dgvOrderInfo.Rows[orderRow].Cells[0].Value = itemDAL.getItemName(lst[i].ItemID);
                    dgvOrderInfo.Rows[orderRow].Cells[1].Value = styleDAL.getItemStyleName(lst[i].StyleID);
                    dgvOrderInfo.Rows[orderRow].Cells[2].Value = sizeDAL.getItemSizeName(lst[i].SizeID);
                    dgvOrderInfo.Rows[orderRow].Cells[3].Value = colorDAL.getColorName(lst[i].ColorID);
                    dgvOrderInfo.Rows[orderRow].Cells[4].Value = lst[i].Quantity;
                    dgvOrderInfo.Rows[orderRow].Cells[5].Value = lst[i].Date.ToString();
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
                if (cbxWorker.Text.Equals(""))
                {
                    MessageBox.Show("Select dealer... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbxChecker.Text.Equals(""))
                {
                    MessageBox.Show("Select sub dealer... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (orderSelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select order...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    OrderPreInfoDAL orderDAL = new OrderPreInfoDAL();
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    ColorDAL colorDAL = new ColorDAL();
                    
                    OrderPreInfo o = new OrderPreInfo();
                    o.DealerID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                    o.DealerCustomerID = Convert.ToInt32(dsChecker.Tables[0].Rows[cbxChecker.SelectedIndex]["ID"]);
                    o.ItemID = itemDAL.getItemID(dgvOrderInfo.Rows[orderSelectedRow].Cells[0].Value.ToString());
                    o.StyleID = styleDAL.getStyleID(dgvOrderInfo.Rows[orderSelectedRow].Cells[1].Value.ToString());
                    o.SizeID = sizeDAL.getSizeID(dgvOrderInfo.Rows[orderSelectedRow].Cells[2].Value.ToString());
                    o.ColorID = colorDAL.getColorID(dgvOrderInfo.Rows[orderSelectedRow].Cells[3].Value.ToString());
                    o.Quantity = Convert.ToInt16(dgvOrderInfo.Rows[orderSelectedRow].Cells[4].Value.ToString());
                    o.Date = Convert.ToDateTime(dgvOrderInfo.Rows[orderSelectedRow].Cells[5].Value.ToString());
                    orderDAL.deleteOrder(o);
                    MessageBox.Show("Order has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvOrderInfo.Rows.RemoveAt(orderSelectedRow);
                    orderSelectedRow = -1;
                    orderRow--;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOrderInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderSelectedRow = e.RowIndex;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            orderRow = orderSelectedRow = -1;
            dgvOrderInfo.Rows.Clear();
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

        private void cbxWorker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                
                //populate cbx supplier
                dsChecker.Clear();
                dsChecker = personDAL.getSubDealerByDealerDataset(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]));
                cbxChecker.DataSource = dsChecker.Tables[0];
                cbxChecker.DisplayMember = "Name";
                //end populate

            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
