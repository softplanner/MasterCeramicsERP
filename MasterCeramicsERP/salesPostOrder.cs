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
    public partial class salesPostOrder : Form
    {
        int subRow = -1, subSelectedRow = -1, orderRow = -1, orderSelectedRow = -1;
        DataSet dsJobs = new DataSet();
        DataSet dsGoodsCompany = new DataSet();
        DataSet dsWorker = new DataSet();
        List<OrderPreInfo> lst;

        //PersonDAL personDAL = new PersonDAL();
        //DealerCustomerDAL customerDAL = new DealerCustomerDAL();
        //ItemDAL itemDAL = new ItemDAL();
        //DALItemStyle styleDAL = new DALItemStyle();
        //ItemSizeDAL sizeDAL = new ItemSizeDAL();
        //ColorDAL colorDAL = new ColorDAL();
        //OrderPreInfoDAL orderDAL = new OrderPreInfoDAL();
        //GoodsCompanyDAL goodsDAL = new GoodsCompanyDAL();
        //JobsDAL jobDal = new JobsDAL();
        
        public salesPostOrder()
        {
            InitializeComponent();
        }

        private void loadGoodsDGV()
        {
            try
            {
                GoodsCompanyDAL goodsDAL = new GoodsCompanyDAL();
                
                //populate cbx supplier
                dsGoodsCompany.Clear();
                dsGoodsCompany = goodsDAL.getAllGoodsCompany_ID_Name();
                cbxGoodsCompany.DataSource = dsGoodsCompany.Tables[0];
                cbxGoodsCompany.DisplayMember = "Name";
                //end populate
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void salesPostOrder_Load(object sender, EventArgs e)
        {
            loadGoodsDGV();
            loadPersonDGV();
        }

        private void dgvSelectedCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            subSelectedRow = e.RowIndex;
        }
        private void loadOrderDGV()
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
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
                    dgvOrderInfo.Rows[orderRow].Cells[5].Value = lst[i].Date.ToShortDateString();
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

        private void btnViewOrderInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxWorker.Text.Equals(""))
                {
                    MessageBox.Show("Select dealer ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (subSelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select sub-dealer ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    OrderPreInfoDAL orderDAL = new OrderPreInfoDAL();

                    if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false))
                    {
                        MessageBox.Show("Select Day/Month", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (rbtnDay.Checked.Equals(true))
                    {
                        lst = new List<OrderPreInfo>();
                        int did = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                        int cid = Convert.ToInt32(dgvSelectedCustomers.Rows[subSelectedRow].Cells[0].Value);
                        lst = orderDAL.getReportByDateDealerAndCustomer(dtpAddOrder.Value.Date, did, cid);
                        if (lst.Count.Equals(0))
                        {
                            MessageBox.Show("No record found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearOrderDgv();
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
                        int cid = Convert.ToInt32(dgvSelectedCustomers.Rows[subSelectedRow].Cells[0].Value);
                        lst = orderDAL.getReportByMonthDealerAndCustomer(dtpAddOrder.Value.Date, did, cid);
                        if (lst.Count.Equals(0))
                        {
                            MessageBox.Show("No record found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearOrderDgv();
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
        private void clearOrderDgv()
        {
            orderRow = orderSelectedRow = -1;
            dgvOrderInfo.Rows.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxWorker.Text.Equals(""))
                {
                    MessageBox.Show("Select dealer ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (subSelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select sub-dealer... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (orderSelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select order...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    ColorDAL colorDAL = new ColorDAL();
                    OrderPreInfoDAL orderDAL = new OrderPreInfoDAL();
                    

                    OrderPreInfo o = new OrderPreInfo();
                    o.DealerID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                    o.DealerCustomerID = Convert.ToInt32(dgvSelectedCustomers.Rows[subSelectedRow].Cells[0].Value);
                    o.ItemID = itemDAL.getItemID(dgvOrderInfo.Rows[orderSelectedRow].Cells[0].Value.ToString());
                    o.StyleID = styleDAL.getStyleID(dgvOrderInfo.Rows[orderSelectedRow].Cells[1].Value.ToString());
                    o.SizeID = sizeDAL.getSizeID(dgvOrderInfo.Rows[orderSelectedRow].Cells[2].Value.ToString());
                    o.ColorID = colorDAL.getColorID(dgvOrderInfo.Rows[orderSelectedRow].Cells[3].Value.ToString());
                    o.Quantity = Convert.ToInt16(dgvOrderInfo.Rows[orderSelectedRow].Cells[4].Value.ToString());
                    o.Date = Convert.ToDateTime(dgvOrderInfo.Rows[orderSelectedRow].Cells[5].Value);
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

        private void refresh()
        {
            txtBiltyNo.Text = "";
            txtGatePass.Text = "";
            subRow = subSelectedRow = orderRow = orderSelectedRow = -1;
            dgvOrderInfo.Rows.Clear();
        }
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxWorker.Text.Equals(""))
                {
                    MessageBox.Show("Select dealer ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (subSelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select sub-dealer... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (orderSelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select order...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbxGoodsCompany.Text.Equals(""))
                {
                    MessageBox.Show("Select goods company...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtBiltyNo.Text.Equals(""))
                {
                    MessageBox.Show("Enter bilty number ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtGatePass.Text.Equals(""))
                {
                    MessageBox.Show("Enter gate-pass number ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    ColorDAL colorDAL = new ColorDAL();
                    OrderPreInfoDAL orderDAL = new OrderPreInfoDAL();

                    OrderPostInfo p = new OrderPostInfo();
                    OrderPostInfocs dal = new OrderPostInfocs();
                    p.DealerID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                    p.DealerCustomerID = Convert.ToInt32(dgvSelectedCustomers.Rows[subSelectedRow].Cells[0].Value);
                    p.ItemID = itemDAL.getItemID(dgvOrderInfo.Rows[orderSelectedRow].Cells[0].Value.ToString());
                    p.StyleID = styleDAL.getStyleID(dgvOrderInfo.Rows[orderSelectedRow].Cells[1].Value.ToString());
                    p.SizeID = sizeDAL.getSizeID(dgvOrderInfo.Rows[orderSelectedRow].Cells[2].Value.ToString());
                    p.ColorID = colorDAL.getColorID(dgvOrderInfo.Rows[orderSelectedRow].Cells[3].Value.ToString());
                    p.Quantity = Convert.ToInt16(dgvOrderInfo.Rows[orderSelectedRow].Cells[4].Value.ToString());
                    p.Date = dtpAddOrder.Value;
                    p.GatePass = txtGatePass.Text;
                    p.BiltyNo = txtBiltyNo.Text;
                    p.GoodsCompanyID = Convert.ToInt16(dsGoodsCompany.Tables[0].Rows[cbxGoodsCompany.SelectedIndex]["ID"]);
                    dal.addOrder(p);
                    MessageBox.Show("Order has been posted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //=====delete order fro order pre info
                    OrderPreInfo o = new OrderPreInfo();
                    o.DealerID = p.DealerID;
                    o.DealerCustomerID = p.DealerCustomerID;
                    o.ItemID = p.ItemID;
                    o.StyleID = p.StyleID;
                    o.SizeID = p.SizeID;
                    o.ColorID = p.ColorID;
                    o.Quantity = p.Quantity;
                    o.Date = Convert.ToDateTime(dgvOrderInfo.Rows[orderSelectedRow].Cells[5].Value);
                    orderDAL.deleteOrder(o);
                    dgvOrderInfo.Rows.RemoveAt(orderSelectedRow);
                    orderSelectedRow = -1;
                    orderRow--;
                    //------------------------------------
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtGatePass_MouseClick(object sender, MouseEventArgs e)
        {
            txtGatePass.Focus();
        }

        private void txtBiltyNo_MouseClick(object sender, MouseEventArgs e)
        {
            txtBiltyNo.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
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
    }
}
