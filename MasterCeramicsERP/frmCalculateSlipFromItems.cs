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
    public partial class frmCalculateSlipFromItems : Form
    {
        //ItemDAL DALitem = new ItemDAL();
        //DALItemStyle DALitemStyle = new DALItemStyle();
        //ItemSizeDAL DALitemSize = new ItemSizeDAL();
        //ItemWeightDAL DALitemWeight = new ItemWeightDAL();
        //ItemWeight itemWeight = new ItemWeight();
        //SlipStockDAL slipStockDAL = new SlipStockDAL();

        DataSet dsMulti = new DataSet();
        DataSet dsItemStyle = new DataSet();
        DataSet dsItemSize = new DataSet();
        
        int rows = -1, selectedRow = -1;
        float calculatedSlip = 0;
        public frmCalculateSlipFromItems()
        {
            InitializeComponent();
        }

        private void frmCalculateSlipFromItems_Load(object sender, EventArgs e)
        {

            try
            {
                ItemDAL DALitem = new ItemDAL();
                DALItemStyle DALitemStyle = new DALItemStyle();
                ItemSizeDAL DALitemSize = new ItemSizeDAL();
                SlipStockDAL slipStockDAL = new SlipStockDAL();

                DALitem = new ItemDAL();
                DALitemSize = new ItemSizeDAL();
                DALitemStyle = new DALItemStyle();

                txtAvailableSlip.Text = slipStockDAL.getSlipInStock().ToString();
                lblItem_slipFromItem.Text = "Item";
                txtRequiredSlip_slipFromItem.Text = "0";
                //populate cbx With All Item
                dsMulti.Clear();
                dsMulti = DALitem.getAllItem();
                cbxItem_slipFromItem.DataSource = dsMulti.Tables[0];
                cbxItem_slipFromItem.DisplayMember = "Name";
                //end populate

                //populate cbx of all itemstyle
                dsItemStyle.Clear();
                dsItemStyle = DALitemStyle.getAllItemStyle();
                cbxStyle_slipFromItem.DataSource = dsItemStyle.Tables[0];
                cbxStyle_slipFromItem.DisplayMember = "Name";
                //end populate

                //populate cbx of all item size
                dsItemSize.Clear();
                dsItemSize = DALitemSize.getAllItemSize();
                cbxSize_slipFromItem.DataSource = dsItemSize.Tables[0];
                cbxSize_slipFromItem.DisplayMember = "Name";
                //end populate
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
             
        private void btnAdd_slipFromItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantity_slipFromItem.Text == "")
                {
                    MessageBox.Show("Enter quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (((calculateSlipAmountForNewRow() * Convert.ToInt32(txtQuantity_slipFromItem.Text)) + Convert.ToSingle(txtRequiredSlip_slipFromItem.Text)) > Convert.ToSingle(txtAvailableSlip.Text))
                    {
                        MessageBox.Show("Slip is short for required item's preparation...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        addNewRow();
                        calculatedSlip = calculatedSlip + (Convert.ToInt32(txtQuantity_slipFromItem.Text) * calculateSlipAmountForNewRow());
                        txtRequiredSlip_slipFromItem.Text = calculatedSlip.ToString();
                        txtQuantity_slipFromItem.Text = "";
                    }
                }
                txtQuantity_slipFromItem.Text = "";
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQuantity_slipFromItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void btnClear_slipFromItem_Click(object sender, EventArgs e)
        {
            if (rows == -1)
            {
                MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rows = -1;
                selectedRow = -1;
                calculatedSlip = 0;
                dgvContainRecords_slipFromItem.Rows.Clear();
                txtRequiredSlip_slipFromItem.Text = "0";
            }
        }

        private void btnDeleteRecord_slipFromItem_Click(object sender, EventArgs e)
        {
            if (selectedRow == -1)
            {
                MessageBox.Show("Select some record...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                calculatedSlip = calculatedSlip - Convert.ToInt32(dgvContainRecords_slipFromItem.Rows[selectedRow].Cells[5].Value);
                txtRequiredSlip_slipFromItem.Text = Convert.ToString(calculatedSlip);
                dgvContainRecords_slipFromItem.Rows.RemoveAt(selectedRow);
                selectedRow = -1;
                rows--;
            }
        }

        private void dgvContainRecords_slipFromItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }
                
        private void addNewRow() 
        {
            try
            {
                for (Int16 i = 0; i <= rows; i++)
                {
                    if (dgvContainRecords_slipFromItem.Rows[i].Cells[0].Value.Equals(cbxItem_slipFromItem.Text))
                    {
                        if (dgvContainRecords_slipFromItem.Rows[i].Cells[1].Value.Equals(cbxStyle_slipFromItem.Text))
                        {
                            if (dgvContainRecords_slipFromItem.Rows[i].Cells[2].Value.Equals(cbxSize_slipFromItem.Text))
                            {
                                dgvContainRecords_slipFromItem.Rows[i].Cells[3].Value = Convert.ToString(Convert.ToInt32(dgvContainRecords_slipFromItem.Rows[i].Cells[3].Value.ToString()) + Convert.ToInt32(txtQuantity_slipFromItem.Text));
                                dgvContainRecords_slipFromItem.Rows[i].Cells[5].Value = Convert.ToString(Convert.ToInt32(dgvContainRecords_slipFromItem.Rows[i].Cells[5].Value.ToString()) + (Convert.ToInt32(dgvContainRecords_slipFromItem.Rows[i].Cells[4].Value.ToString()) * Convert.ToInt32(txtQuantity_slipFromItem.Text)));
                                return;
                            }
                        }
                    }
                }
                double newItemWeight = 0;
                //////------Show record in the data grid view------//////
                rows = dgvContainRecords_slipFromItem.Rows.Add();
                dgvContainRecords_slipFromItem.Rows[rows].Cells[0].Value = cbxItem_slipFromItem.Text;
                dgvContainRecords_slipFromItem.Rows[rows].Cells[1].Value = cbxStyle_slipFromItem.Text;
                dgvContainRecords_slipFromItem.Rows[rows].Cells[2].Value = cbxSize_slipFromItem.Text;
                dgvContainRecords_slipFromItem.Rows[rows].Cells[3].Value = txtQuantity_slipFromItem.Text;
                newItemWeight = calculateSlipAmountForNewRow();
                dgvContainRecords_slipFromItem.Rows[rows].Cells[4].Value = newItemWeight;
                dgvContainRecords_slipFromItem.Rows[rows].Cells[5].Value = newItemWeight * Convert.ToInt32(txtQuantity_slipFromItem.Text);
                ////------End show record in the data grid view------////
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private float calculateSlipAmountForNewRow()
        {
            float rowWeight = 0;
            try
            {
                ItemDAL DALitem = new ItemDAL();
                DALItemStyle DALitemStyle = new DALItemStyle();
                ItemSizeDAL DALitemSize = new ItemSizeDAL();
                ItemWeightDAL DALitemWeight = new ItemWeightDAL();
                ItemWeight itemWeight = new ItemWeight();

                itemWeight.ItemID = DALitem.getItemID(cbxItem_slipFromItem.Text);
                itemWeight.StyleID = DALitemStyle.getStyleID(cbxStyle_slipFromItem.Text);
                itemWeight.SizeID = DALitemSize.getSizeID(cbxSize_slipFromItem.Text);
                itemWeight.Weight = DALitemWeight.getItemWeights(itemWeight);
                rowWeight = Convert.ToSingle(itemWeight.Weight);
                return rowWeight;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rowWeight;
        }

        private void txtQuantity_slipFromItem_MouseClick(object sender, MouseEventArgs e)
        {
            txtQuantity_slipFromItem.Focus();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (rows == -1)
            {
                MessageBox.Show("Add some items...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                DataRow dataRow;
                dt.Columns.Add("Item", typeof(string));
                dt.Columns.Add("Style", typeof(string));
                dt.Columns.Add("Size", typeof(string));
                dt.Columns.Add("Quantity", typeof(string));
                dt.Columns.Add("Unit Weight", typeof(int));
                dt.Columns.Add("Total Weight", typeof(int));
                dt.Columns.Add("Slip Required", typeof(int));
                dt.Columns.Add("Slip Available", typeof(int));

                ds.Tables.Add(dt);

                for (int i = 0; i <= rows; i++)
                {
                    dataRow = ds.Tables[0].NewRow();
                    dataRow[0] = dgvContainRecords_slipFromItem.Rows[i].Cells[0].Value.ToString();
                    dataRow[1] = dgvContainRecords_slipFromItem.Rows[i].Cells[1].Value.ToString();
                    dataRow[2] = dgvContainRecords_slipFromItem.Rows[i].Cells[2].Value.ToString();
                    dataRow[3] = dgvContainRecords_slipFromItem.Rows[i].Cells[3].Value.ToString();
                    dataRow[4] = dgvContainRecords_slipFromItem.Rows[i].Cells[4].Value.ToString();
                    dataRow[5] = dgvContainRecords_slipFromItem.Rows[i].Cells[5].Value.ToString();
                    dataRow[6] = txtRequiredSlip_slipFromItem.Text;
                    dataRow[7] = txtAvailableSlip.Text;

                    ds.Tables[0].Rows.Add(dataRow);
                }
                rptFrmPrediction report = new rptFrmPrediction();
                report.calculateSlipFromItems(ds);
                report.Show();
            }
        }
    }
}
