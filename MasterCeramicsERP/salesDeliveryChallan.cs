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
    public partial class salesDeliveryChallan : Form
    {
        int orderRow = -1, orderSelectedRow = -1;
        
        DataSet dsItems = new DataSet();
        DataSet dsItemStyle = new DataSet();
        DataSet dsItemSize = new DataSet();
        DataSet dsColor = new DataSet();
        DataSet dsWorker = new DataSet();
        DataSet dsJobs = new DataSet();
        DataSet dsCategory = new DataSet();
        string gatePassNo = null;

        public salesDeliveryChallan()
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
                KillenItemCategoryDAL killenItemCategoryDAL = new KillenItemCategoryDAL();

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
                dsColor = colorDAL.getAllColorDetail();
                cbxColor.DataSource = dsColor.Tables[0];
                cbxColor.DisplayMember = "Name";
                //end populate

                //populate killen item category cbx
                dsCategory.Clear();
                dsCategory = killenItemCategoryDAL.getAllKillenItemCategoryDetail();
                cbxItemCategory.DataSource = dsCategory.Tables[0];
                cbxItemCategory.DisplayMember = "Name";
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
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                ReadyItemStockDAL dal = new ReadyItemStockDAL();
                
                if (txtQuantity.Text.Equals(""))
                {
                    MessageBox.Show("Enter quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(Convert.ToInt32(txtQuantity.Text) > dal.getStockByItemStyleSizeCategoryColorCategory(Convert.ToInt16(dsItems.Tables[0].Rows[cbxItem.SelectedIndex]["ID"]),Convert.ToInt16(dsItemStyle.Tables[0].Rows[cbxStyle.SelectedIndex]["ID"]),Convert.ToInt16(dsItemSize.Tables[0].Rows[cbxSize.SelectedIndex]["ID"]),Convert.ToInt16(dsColor.Tables[0].Rows[cbxColor.SelectedIndex]["ID"]),Convert.ToInt16(dsCategory.Tables[0].Rows[cbxItemCategory.SelectedIndex]["ID"])))
                {
                    MessageBox.Show("Enter quantity greater than available stock !" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                    if (dgvOrderInfo.Rows[i].Cells[5].Value.Equals(cbxItemCategory.Text))
                                    {
                                        dgvOrderInfo.Rows[i].Cells[4].Value = Convert.ToString(Convert.ToInt32(dgvOrderInfo.Rows[i].Cells[4].Value) + Convert.ToInt32(txtQuantity.Text));
                                        return;
                                    }
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
                dgvOrderInfo.Rows[orderRow].Cells[5].Value = cbxItemCategory.Text;
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
            //dgvSelectedCustomers.Rows.Clear();
            txtQuantity.Text = "";
            orderRow = orderSelectedRow = -1;
            dgvOrderInfo.Rows.Clear();
            loadPersonDGV();
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
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                ColorDAL colorDAL = new ColorDAL();
                KillenItemCategoryDAL catDal = new KillenItemCategoryDAL();
                deliveryChallanDAL orderDAL = new deliveryChallanDAL();

                if (orderRow == -1)
                {
                    MessageBox.Show("Add some item's", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbxWorker.Text.Equals(""))
                {
                    MessageBox.Show("Select dealer... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    deliveryChallan o;
                    if (chkbxDeductStock.Checked.Equals(true))
                    {
                        //for update the ready item in stock
                        //--------------------------------------------------
                        ReadyItemStockDAL stockDal = new ReadyItemStockDAL();
                        ReadyItemStock itemObj = new ReadyItemStock();
                        int itemQuanInStock = 0;
                        //-----------------------
                        DataSet ds = new DataSet();
                        DataTable dt = new DataTable();
                        DataRow dataRow;

                        dt.Columns.Add("ItemID", typeof(Int16));
                        dt.Columns.Add("StyleID", typeof(Int16));
                        dt.Columns.Add("SizeID", typeof(Int16));
                        dt.Columns.Add("ColorID", typeof(Int16));
                        dt.Columns.Add("Category", typeof(Int16));
                        dt.Columns.Add("Quantity", typeof(Int16));

                        ds.Tables.Add(dt);
                        //---------------------------------------------------
                        for (int j = 0; j <= orderRow; j++)
                        {
                            o = new deliveryChallan();
                            o.DealerID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                            o.ItemID = itemDAL.getItemID(dgvOrderInfo.Rows[j].Cells[0].Value.ToString());
                            o.StyleID = styleDAL.getStyleID(dgvOrderInfo.Rows[j].Cells[1].Value.ToString());
                            o.SizeID = sizeDAL.getSizeID(dgvOrderInfo.Rows[j].Cells[2].Value.ToString());
                            o.ColorID = colorDAL.getColorID(dgvOrderInfo.Rows[j].Cells[3].Value.ToString());
                            o.Quantity = Convert.ToInt16(dgvOrderInfo.Rows[j].Cells[4].Value);
                            o.CategoryID = catDal.getKillenItemCategoryID(dgvOrderInfo.Rows[j].Cells[5].Value.ToString());
                            o.Date = DateTime.Now;
                            o.GatePass = txtGPass.Text;
                            orderDAL.addOrder(o);

                            itemQuanInStock = stockDal.getStockByItemStyleSizeCategoryColorCategory(o.ItemID, o.StyleID, o.SizeID, o.ColorID, o.CategoryID) - o.Quantity;

                            dataRow = ds.Tables[0].NewRow();
                            dataRow[0] = o.ItemID;
                            dataRow[1] = o.StyleID;
                            dataRow[2] = o.SizeID;
                            dataRow[3] = o.ColorID;
                            dataRow[4] = o.CategoryID;
                            dataRow[5] = itemQuanInStock;

                            ds.Tables[0].Rows.Add(dataRow);
                        }
                        stockDal.updateStockInBulk(ds.Tables[0]);
                    }
                        //-------------------------------------------------------------------------------
                    else
                    {
                        for (int i = 0; i <= orderRow; i++)
                        {
                            o = new deliveryChallan();
                            o.DealerID = Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]);
                            o.ItemID = itemDAL.getItemID(dgvOrderInfo.Rows[i].Cells[0].Value.ToString());
                            o.StyleID = styleDAL.getStyleID(dgvOrderInfo.Rows[i].Cells[1].Value.ToString());
                            o.SizeID = sizeDAL.getSizeID(dgvOrderInfo.Rows[i].Cells[2].Value.ToString());
                            o.ColorID = colorDAL.getColorID(dgvOrderInfo.Rows[i].Cells[3].Value.ToString());
                            o.Quantity = Convert.ToInt16(dgvOrderInfo.Rows[i].Cells[4].Value);
                            o.CategoryID = catDal.getKillenItemCategoryID(dgvOrderInfo.Rows[i].Cells[5].Value.ToString());
                            o.Date = DateTime.Now;
                            o.GatePass = txtGPass.Text;
                            orderDAL.addOrder(o);
                        }
                    }
                    MessageBox.Show("Order has been added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvOrderInfo.Rows.Clear();
                    orderSelectedRow = orderRow = -1;
                    txtQuantity.Text = "";
                    //get new gate pass number
                    GatePassCounter gatePassCounter = new GatePassCounter();
                    gatePassCounter.incrementInGatePassNumber();
                    GatePassCounter dal = new GatePassCounter();
                    txtGPass.Text = Convert.ToString(dal.getYear()) + "-" + Convert.ToString(dal.getGatePassNo());
                    //-----------------------
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salesDeliveryChallan_Load(object sender, EventArgs e)
        {
            //create gate pass number
            GatePassCounter dal=new GatePassCounter();
            //check if the new year has been start then counter set to zero
            dal.updateYear();
            txtGPass.Text = Convert.ToString(dal.getYear()) +"-"+ Convert.ToString(dal.getGatePassNo());
            //-----------------------
            loadPersonDGV();
            loadComboBoxes();
        }

        private void txtGPass_MouseClick(object sender, MouseEventArgs e)
        {
            txtGPass.Focus();
        }

        private void cbxSelectJob_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                PersonDAL personDAL = new PersonDAL();
                JobsDAL jobDal = new JobsDAL();

                //dgvSelectedCustomers.Rows.Clear();
                //subRow = subSelectedRow = -1;
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
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void cbxWorker_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    loadSelectedSubDealer();
        //}
    }
}
