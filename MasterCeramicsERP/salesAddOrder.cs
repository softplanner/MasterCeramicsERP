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
    public partial class salesAddOrder : Form
    {
        int subRow = -1, subSelectedRow = -1,orderRow=-1,orderSelectedRow=-1;

        DataSet dsItems = new DataSet();
        DataSet dsItemStyle = new DataSet();
        DataSet dsItemSize = new DataSet();
        DataSet dsColor = new DataSet();
        DataSet dsWorker = new DataSet();
        DataSet dsJobs = new DataSet();

        //PersonDAL personDAL = new PersonDAL();
        //DealerCustomerDAL customerDAL = new DealerCustomerDAL();
        //ItemDAL itemDAL = new ItemDAL();
        //DALItemStyle styleDAL = new DALItemStyle();
        //ItemSizeDAL sizeDAL = new ItemSizeDAL();
        //ColorDAL colorDAL = new ColorDAL();
        //OrderPreInfoDAL orderDAL = new OrderPreInfoDAL();
        //JobsDAL jobDal = new JobsDAL();

        
        public salesAddOrder()
        {
            InitializeComponent();
        }
        private void loadComboBoxes()
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                ColorDAL colorDAL = new ColorDAL();

                //populate cbx With All Item
                dsItems.Clear();
                dsItems = itemDAL.getAllItem();
                cbxItem.DataSource = dsItems.Tables[0];
                cbxItem.DisplayMember = "Name";
                //end populate

                //populate cbx of all itemstyle
                dsItemStyle.Clear();
                dsItemStyle = styleDAL.getAllItemStyle();
                cbxStyle.DataSource = dsItemStyle.Tables[0];
                cbxStyle.DisplayMember = "Name";
                //end populate

                //populate cbx of all item size
                dsItemSize.Clear();
                dsItemSize = sizeDAL.getAllItemSize();
                cbxSize.DataSource = dsItemSize.Tables[0];
                cbxSize.DisplayMember = "Name";
                //end populate

                //populate cbx of all Color
                dsColor.Clear();
                dsColor = colorDAL.getAllColor();
                cbxColor.DataSource = dsColor.Tables[0];
                cbxColor.DisplayMember = "Name";
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
                    dgvSelectedCustomers.Rows[subRow].Cells[2].Value = customerDAL.getShopName(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]),lst[i]);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salesAddOrder_Load(object sender, EventArgs e)
        {
            loadPersonDGV();
            loadComboBoxes();
        }

        
        private void dgvSelectedCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            subSelectedRow = e.RowIndex;
        }
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantity.Text.Equals(""))
                {
                    MessageBox.Show("Enter quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    addRow();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addRow()
        {
            try
            {
                for (int i = 0; i <= orderRow; i++)
                {
                    if (dgvOrderInfo.Rows[i].Cells[0].Value.Equals(cbxItem.Text))
                    {
                        if (dgvOrderInfo.Rows[i].Cells[1].Value.Equals(cbxStyle.Text))
                        {
                            if (dgvOrderInfo.Rows[i].Cells[2].Value.Equals(cbxSize.Text))
                            {
                                if (dgvOrderInfo.Rows[i].Cells[3].Value.Equals(cbxColor.Text))
                                {
                                    dgvOrderInfo.Rows[i].Cells[4].Value = Convert.ToString(Convert.ToInt32(dgvOrderInfo.Rows[i].Cells[4].Value) + Convert.ToInt32(txtQuantity.Text));
                                    return;
                                }
                            }
                        }
                    }
                }
                orderRow = dgvOrderInfo.Rows.Add();
                dgvOrderInfo.Rows[orderRow].Cells[0].Value = cbxItem.Text;
                dgvOrderInfo.Rows[orderRow].Cells[1].Value = cbxStyle.Text;
                dgvOrderInfo.Rows[orderRow].Cells[2].Value = cbxSize.Text;
                dgvOrderInfo.Rows[orderRow].Cells[3].Value = cbxColor.Text;
                dgvOrderInfo.Rows[orderRow].Cells[4].Value = txtQuantity.Text;
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
                if (orderSelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select order...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
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
            dgvSelectedCustomers.Rows.Clear();
            txtQuantity.Text = "";
            subRow = subSelectedRow = orderRow = orderSelectedRow = -1;
            dgvOrderInfo.Rows.Clear();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            txtQuantity.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderRow == -1)
                {
                    MessageBox.Show("No record found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbxWorker.Text.Equals(""))
                {
                    MessageBox.Show("Select dealer... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (subSelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select SubDealer... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    ColorDAL colorDAL = new ColorDAL();
                    OrderPreInfoDAL orderDAL = new OrderPreInfoDAL();

                    OrderPreInfo o;
                    for (int i = 0; i <= orderRow; i++)
                    {
                        o = new OrderPreInfo();
                        o.DealerID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                        o.DealerCustomerID = Convert.ToInt32(dgvSelectedCustomers.Rows[subSelectedRow].Cells[0].Value);
                        o.ItemID = itemDAL.getItemID(dgvOrderInfo.Rows[i].Cells[0].Value.ToString());
                        o.StyleID = styleDAL.getStyleID(dgvOrderInfo.Rows[i].Cells[1].Value.ToString());
                        o.SizeID = sizeDAL.getSizeID(dgvOrderInfo.Rows[i].Cells[2].Value.ToString());
                        o.ColorID = colorDAL.getColorID(dgvOrderInfo.Rows[i].Cells[3].Value.ToString());
                        o.Quantity = Convert.ToInt16(dgvOrderInfo.Rows[i].Cells[4].Value);
                        o.Date = DateTime.Now;
                        if (orderDAL.checkIsOrderExist(o).Equals(true))
                        {
                            o.Quantity = Convert.ToInt16(o.Quantity + orderDAL.getOrderQuantity(o));
                            orderDAL.updateOrder(o);
                            MessageBox.Show("Order has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            orderDAL.addOrder(o);
                            MessageBox.Show("Order has been added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    dgvOrderInfo.Rows.Clear();
                    orderSelectedRow = orderRow = -1;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        //===========================================================================================================
    }
}
