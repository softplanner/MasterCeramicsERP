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
    public partial class salesCreateBill : Form
    {
        int total=0,totalDis=0,orderRow = -1, orderSelectedRow = -1;
        DataSet dsItems = new DataSet();
        DataSet dsItemStyle = new DataSet();
        DataSet dsItemSize = new DataSet();
        DataSet dsColor = new DataSet();

        public salesCreateBill()
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

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantity.Text.Equals(""))
                {
                    MessageBox.Show("Enter quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPrice.Text.Equals(""))
                {
                    MessageBox.Show("Enter price...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                    //dgvOrderInfo.Rows[i].Cells[5].Value = Convert.ToString(Convert.ToInt32(dgvOrderInfo.Rows[i].Cells[5].Value) + (Convert.ToInt32(txtPrice.Text)*Convert.ToInt32(txtQuantity.Text)));
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
                dgvOrderInfo.Rows[orderRow].Cells[5].Value = txtPrice.Text;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salesCreateBill_Load(object sender, EventArgs e)
        {
            loadComboBoxes();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            orderRow = orderSelectedRow = -1;
            dgvOrderInfo.Rows.Clear();
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtDiscount.Text = "";
            txtBuyerName.Text = "";
            txtDisTotal.Text = "";
            txtTotal.Text = "";
        }
        private void viewTotal()
        {
            try
            {
                if (orderRow == -1)
                {
                    MessageBox.Show("Add some items...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtDiscount.Text.Equals(""))
                {
                    MessageBox.Show("Enter discount rate...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(txtDiscount.Text) > 100)
                {
                    MessageBox.Show("Enter discount rate within 100 %...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int totalPrice = 0;
                    int discount = 0;
                    for (int i = 0; i <= orderRow; i++)
                    {
                        totalPrice = totalPrice + (Convert.ToInt32(dgvOrderInfo.Rows[i].Cells[4].Value) * Convert.ToInt32(dgvOrderInfo.Rows[i].Cells[5].Value));
                    }
                    txtTotal.Text = totalPrice.ToString();
                    discount = (totalPrice * Convert.ToInt32(txtDiscount.Text)) / 100;
                    txtDisTotal.Text = (Convert.ToInt32(totalPrice) - discount).ToString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            viewTotal();
        }

        private void dgvOrderInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderSelectedRow = e.RowIndex;
        }

        private void txtQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            txtQuantity.Focus();
        }

        private void txtPrice_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrice.Focus();
        }

        private void txtDiscount_MouseClick(object sender, MouseEventArgs e)
        {
            txtDiscount.Focus();
        }

        private void txtBuyerName_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuyerName.Focus();
        }

        private void txtTotal_MouseClick(object sender, MouseEventArgs e)
        {
            txtTotal.Focus();
        }

        private void txtDisTotal_MouseClick(object sender, MouseEventArgs e)
        {
            txtDisTotal.Focus();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if (txtQuantity.Text.Length < 5)
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                    e.Handled = true;
            }
            else
            {
                e.Handled = true;
                e.KeyChar = '\b';
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if (txtPrice.Text.Length < 7)
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                    e.Handled = true;
            }
            else
            {
                e.Handled = true;
                e.KeyChar = '\b';
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if (txtDiscount.Text.Length <3)
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                    e.Handled = true;
            }
            else
            {
                e.Handled = true;
                e.KeyChar='\b';
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (orderRow == -1)
            {
                MessageBox.Show("Add some items...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDiscount.Text.Equals(""))
            {
                MessageBox.Show("Enter discount rate...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtBuyerName.Text.Equals(""))
            {
                MessageBox.Show("Enter buyer name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //-----
                viewTotal();
                //-----
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                DataRow dataRow;
                dt.Columns.Add("Buyer", typeof(string));
                dt.Columns.Add("Item", typeof(string));
                dt.Columns.Add("Style", typeof(string));
                dt.Columns.Add("Size", typeof(string));
                dt.Columns.Add("Color", typeof(string));
                dt.Columns.Add("Quantity", typeof(Int16));
                dt.Columns.Add("Price", typeof(int));
                dt.Columns.Add("Total Amount", typeof(int));
                dt.Columns.Add("Discount Amount", typeof(int));
                dt.Columns.Add("Discount Rate", typeof(int));
                dt.Columns.Add("Total Price", typeof(int));
                
                ds.Tables.Add(dt);

                for (int i = 0; i <= orderRow; i++)
                {
                    dataRow = ds.Tables[0].NewRow();
                    dataRow[0]  = txtBuyerName.Text;
                    dataRow[1]  = dgvOrderInfo.Rows[i].Cells[0].Value.ToString();
                    dataRow[2]  = dgvOrderInfo.Rows[i].Cells[1].Value.ToString();
                    dataRow[3]  = dgvOrderInfo.Rows[i].Cells[2].Value.ToString();
                    dataRow[4]  = dgvOrderInfo.Rows[i].Cells[3].Value.ToString();
                    dataRow[5]  =  Convert.ToInt16(dgvOrderInfo.Rows[i].Cells[4].Value.ToString());
                    dataRow[6]  = Convert.ToSingle(dgvOrderInfo.Rows[i].Cells[5].Value.ToString());
                    dataRow[7]  = Convert.ToInt32(txtTotal.Text);
                    dataRow[8]  = Convert.ToInt32(txtDisTotal.Text);
                    dataRow[9]  = Convert.ToInt32(txtDiscount.Text);
                    dataRow[10] = Convert.ToInt32(Convert.ToInt32(dgvOrderInfo.Rows[i].Cells[4].Value) * Convert.ToInt32(dgvOrderInfo.Rows[i].Cells[5].Value));
                    
                    ds.Tables[0].Rows.Add(dataRow);
                }
                rptFrmSaleCreateBill report = new rptFrmSaleCreateBill();
                report.getReport(ds);
                report.Show();
            }
        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }
    }
}
