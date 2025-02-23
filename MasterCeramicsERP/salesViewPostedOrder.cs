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
    public partial class salesViewPostedOrder : Form
    {
        int subRow = -1, subSelectedRow = -1, orderRow = -1, orderSelectedRow = -1;
        List<OrderPostInfo> lst;
        DataSet dsJobs = new DataSet();
        DataSet dsGoodsCompany = new DataSet();
        DataSet dsWorker = new DataSet();
        List<int> dealerID;
        List<int> customerID;

        //PersonDAL personDAL = new PersonDAL();
        //DealerCustomerDAL customerDAL = new DealerCustomerDAL();
        //ItemDAL itemDAL = new ItemDAL();
        //DALItemStyle styleDAL = new DALItemStyle();
        //ItemSizeDAL sizeDAL = new ItemSizeDAL();
        //ColorDAL colorDAL = new ColorDAL();
        //OrderPostInfocs orderDAL = new OrderPostInfocs();
        //GoodsCompanyDAL goodsDAL = new GoodsCompanyDAL();
        //JobsDAL jobDal = new JobsDAL();
        
        public salesViewPostedOrder()
        {
            InitializeComponent();
        }

        private void salesViewPostedOrder_Load(object sender, EventArgs e)
        {
            lblTemp.Text = "";
            txtTemp.Visible = false;
            loadPersonDGV();
        }

        private void cbxViewBy_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxViewBy.Text.Equals("Gate Pass Number"))
            {
                lblTemp.Visible = true;
                txtTemp.Visible = true;
                lblTemp.Text = "Enter Gate Pass Number";
            }
            else if (cbxViewBy.Text.Equals("Bilty Number"))
            {
                lblTemp.Visible = true;
                txtTemp.Visible = true;
                lblTemp.Text = "Enter Bilty Number";
            }
            else if (cbxViewBy.Text.Equals("Calender/Dealer Info"))
            {

                lblTemp.Visible = false;
                txtTemp.Visible = false;
            }
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
                    dgvSelectedCustomers.Rows[subRow].Cells[2].Value = customerDAL.getShopName(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]), lst[i]);
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
                PersonDAL personDAL = new PersonDAL();
                DealerCustomerDAL customerDAL = new DealerCustomerDAL();
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                ColorDAL colorDAL = new ColorDAL();
                GoodsCompanyDAL goodsDAL = new GoodsCompanyDAL();
                
                lst.TrimExcess();
                dealerID = new List<int>();
                customerID = new List<int>();
                orderRow = -1;
                orderSelectedRow = -1;
                dgvOrderInfo.Rows.Clear();
                for (int i = 0; i < lst.Count; i++)
                {
                    orderRow = dgvOrderInfo.Rows.Add();

                    dealerID.Add(lst[i].DealerID);
                    customerID.Add(lst[i].DealerCustomerID);
                    dgvOrderInfo.Rows[orderRow].Cells[0].Value = personDAL.getPersonName(lst[i].DealerID);    
                    dgvOrderInfo.Rows[orderRow].Cells[1].Value = personDAL.getPersonName(lst[i].DealerCustomerID);
                    dgvOrderInfo.Rows[orderRow].Cells[2].Value = customerDAL.getShopName(lst[i].DealerID,lst[i].DealerCustomerID);
                    dgvOrderInfo.Rows[orderRow].Cells[3].Value = itemDAL.getItemName(lst[i].ItemID);
                    dgvOrderInfo.Rows[orderRow].Cells[4].Value = styleDAL.getItemStyleName(lst[i].StyleID);
                    dgvOrderInfo.Rows[orderRow].Cells[5].Value = sizeDAL.getItemSizeName(lst[i].SizeID);
                    dgvOrderInfo.Rows[orderRow].Cells[6].Value = colorDAL.getColorName(lst[i].ColorID);
                    dgvOrderInfo.Rows[orderRow].Cells[7].Value = lst[i].Quantity;
                    dgvOrderInfo.Rows[orderRow].Cells[8].Value = lst[i].GatePass;
                    dgvOrderInfo.Rows[orderRow].Cells[9].Value = lst[i].BiltyNo;
                    dgvOrderInfo.Rows[orderRow].Cells[10].Value = goodsDAL.getGoodsCompanyName(lst[i].GoodsCompanyID);
                    dgvOrderInfo.Rows[orderRow].Cells[11].Value = lst[i].Date.ToString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearOrderDGV()
        {
            dgvOrderInfo.Rows.Clear();
            orderRow = orderSelectedRow = -1;
        }
        private void btnViewOrderInfo_Click(object sender, EventArgs e)
        {
            try
            {
                OrderPostInfocs orderDAL = new OrderPostInfocs();
                
                if (cbxViewBy.Text.Equals(""))
                {
                    MessageBox.Show("Select some critaria from view order by...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbxViewBy.Text.Equals("Gate Pass Number"))
                {
                    if (txtTemp.Text.Equals(""))
                    {
                        MessageBox.Show("Enter Gate Pass Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        lst = orderDAL.getOrderByGatePass(txtTemp.Text);
                        if (lst.Count.Equals(0))
                        {
                            MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearOrderDGV();
                        }
                        else
                        {
                            loadOrderDGV();
                        }
                    }
                }
                else if (cbxViewBy.Text.Equals("Bilty Number"))
                {
                    if (txtTemp.Text.Equals(""))
                    {
                        MessageBox.Show("Enter bilty number...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        lst = orderDAL.getOrderByBilty(txtTemp.Text);
                        if (lst.Count.Equals(0))
                        {
                            MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearOrderDGV();
                        }
                        else
                        {
                            loadOrderDGV();
                        }
                    }
                }
                else if (cbxViewBy.Text.Equals("Calender/Dealer Info"))
                {
                    if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false))
                    {
                        MessageBox.Show("Select Day/Month", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (chkbxDealer.Checked.Equals(false) && chkbxCustomer.Checked.Equals(false))
                    {
                        MessageBox.Show("Select dealer or sub-dealer...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (rbtnDay.Checked.Equals(true))
                    {
                        if (chkbxDealer.Checked.Equals(true) && chkbxCustomer.Checked.Equals(false))
                        {
                            if (cbxWorker.Text.Equals(""))
                            {
                                MessageBox.Show("Select dealer...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                lst = orderDAL.getReportByDateAndDealer(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]), dtpAddOrder.Value);
                                if (lst.Count.Equals(0))
                                {
                                    MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    clearOrderDGV();
                                }
                                else
                                {
                                    loadOrderDGV();
                                }
                            }
                        }
                        else if (chkbxDealer.Checked.Equals(false) && chkbxCustomer.Checked.Equals(true))
                        {
                            if (subSelectedRow.Equals(-1))
                            {
                                MessageBox.Show("Select sub-dealer...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                lst = orderDAL.getReportByDateAndCustomerID(Convert.ToInt32(dgvSelectedCustomers.Rows[subSelectedRow].Cells[0].Value), dtpAddOrder.Value);
                                if (lst.Count.Equals(0))
                                {
                                    MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    clearOrderDGV();
                                }
                                else
                                {
                                    loadOrderDGV();
                                }
                            }
                        }
                        else if (chkbxDealer.Checked.Equals(true) && chkbxCustomer.Checked.Equals(true))
                        {
                            if (cbxWorker.Text.Equals(""))
                            {
                                MessageBox.Show("Select Dealer ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (subSelectedRow.Equals(-1))
                            {
                                MessageBox.Show("Select Sub Dealer ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                lst = orderDAL.getReportByDateDealerAndCustomerID(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]), Convert.ToInt32(dgvSelectedCustomers.Rows[subSelectedRow].Cells[0].Value), dtpAddOrder.Value);
                                if (lst.Count.Equals(0))
                                {
                                    MessageBox.Show("No Record Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    clearOrderDGV();
                                }
                                else
                                {
                                    loadOrderDGV();
                                }
                            }
                        }
                    }
                    else if (rbtnMonth.Checked.Equals(true))
                    {
                        if (chkbxDealer.Checked.Equals(true) && chkbxCustomer.Checked.Equals(false))
                        {
                            if (cbxWorker.Text.Equals(""))
                            {
                                MessageBox.Show("Select dealer...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                lst = orderDAL.getReportByMonthAndDealerID(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]), dtpAddOrder.Value);
                                if (lst.Count.Equals(0))
                                {
                                    MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    clearOrderDGV();
                                }
                                else
                                {
                                    loadOrderDGV();
                                }
                            }
                        }
                        else if (chkbxDealer.Checked.Equals(false) && chkbxCustomer.Checked.Equals(true))
                        {
                            if (subSelectedRow.Equals(-1))
                            {
                                MessageBox.Show("Select sub-dealer...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                lst = orderDAL.getReportByMonthAndCustomerID(Convert.ToInt32(dgvSelectedCustomers.Rows[subSelectedRow].Cells[0].Value), dtpAddOrder.Value);
                                if (lst.Count.Equals(0))
                                {
                                    MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    clearOrderDGV();
                                }
                                else
                                {
                                    loadOrderDGV();
                                }
                            }
                        }
                        else if (chkbxDealer.Checked.Equals(true) && chkbxCustomer.Checked.Equals(true))
                        {
                            if (cbxWorker.Text.Equals(""))
                            {
                                MessageBox.Show("Select dealer... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (subSelectedRow.Equals(-1))
                            {
                                MessageBox.Show("Select sub-dealer...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                lst = orderDAL.getReportByMonthDealerAndCustomerID(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]), Convert.ToInt32(dgvSelectedCustomers.Rows[subSelectedRow].Cells[0].Value), dtpAddOrder.Value);
                                if (lst.Count.Equals(0))
                                {
                                    MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    clearOrderDGV();
                                }
                                else
                                {
                                    loadOrderDGV();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSelectedCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            subSelectedRow = e.RowIndex;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            subRow = subSelectedRow = orderRow = orderSelectedRow = -1;
            dgvOrderInfo.Rows.Clear();
        }

        private void dgvOrderInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderSelectedRow = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderSelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select order...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    ColorDAL colorDAL = new ColorDAL();
                    OrderPostInfocs orderDAL = new OrderPostInfocs();
                    
                    OrderPostInfo o = new OrderPostInfo();
                    o.DealerID = dealerID[orderSelectedRow];
                    o.DealerCustomerID = customerID[orderSelectedRow];
                    o.ItemID = itemDAL.getItemID(dgvOrderInfo.Rows[orderSelectedRow].Cells[3].Value.ToString());
                    o.StyleID = styleDAL.getStyleID(dgvOrderInfo.Rows[orderSelectedRow].Cells[4].Value.ToString());
                    o.SizeID = sizeDAL.getSizeID(dgvOrderInfo.Rows[orderSelectedRow].Cells[5].Value.ToString());
                    o.ColorID = colorDAL.getColorID(dgvOrderInfo.Rows[orderSelectedRow].Cells[6].Value.ToString());
                    o.Quantity = Convert.ToInt16(dgvOrderInfo.Rows[orderSelectedRow].Cells[7].Value.ToString());
                    o.GatePass = dgvOrderInfo.Rows[orderSelectedRow].Cells[8].Value.ToString();
                    o.BiltyNo = dgvOrderInfo.Rows[orderSelectedRow].Cells[9].Value.ToString();
                    o.Date = Convert.ToDateTime(dgvOrderInfo.Rows[orderSelectedRow].Cells[11].Value);

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

        private void txtTemp_MouseClick(object sender, MouseEventArgs e)
        {
            txtTemp.Focus();
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
            loadSelectedSubDealer();
        }
        //--------------------------------------------------------------------------------------------------------------
    }
}
