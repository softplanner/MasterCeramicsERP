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
    public partial class frmItemEstimationFromSlip : Form
    {
        int rows = 0;
        public frmItemEstimationFromSlip()
        {
            InitializeComponent();
        }

        private void txtSlip_itemsFromSlip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';

            else if ((e.KeyChar < '0') || (e.KeyChar > '9') || e.KeyChar == '.')
            {
                if (e.KeyChar == '.')
                {
                    if (txtSlip_itemsFromSlip.Text.Contains("."))
                    {
                    }
                    else
                    {
                        e.KeyChar = '.';
                        return;
                    }
                }
                e.Handled = true;
            }
        }

        private void btnCalculate_itemsFromSlip_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSlip_itemsFromSlip.Text == "")
                {
                    MessageBox.Show("Enter value...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbxCategory_itemsFromSlip.Text == "")
                {
                    MessageBox.Show("Select some critaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int i = 0, j = 0;
                    List<Item> itemList = new List<Item>();
                    List<ItemStyle> itemStyleList = new List<ItemStyle>();
                    List<ItemSize> itemSizeList = new List<ItemSize>();
                    List<ItemWeight> itemWeightList = new List<ItemWeight>();
                    ItemDAL DALitem = new ItemDAL();
                    ItemWeightDAL DALitemWeight = new ItemWeightDAL();
                    DALItemStyle DALitemStyle = new DALItemStyle();
                    ItemSizeDAL DALitemSize = new ItemSizeDAL();
                    //show by item
                    if (cbxCategory_itemsFromSlip.Text == "Item")
                    {
                        itemList.Clear();
                        dgvEstimateItems_itemsFromSlip.Columns[0].HeaderText = "Item";
                        dgvEstimateItems_itemsFromSlip.Columns[1].HeaderText = "Style";
                        dgvEstimateItems_itemsFromSlip.Columns[2].HeaderText = "Size";
                        rows = 0;
                        dgvEstimateItems_itemsFromSlip.Rows.Clear();
                        itemList = DALitem.getItemList();
                        itemList.TrimExcess();
                        for (i = 0; i < itemList.Count; i++)
                        {
                            ////////////////////////////////////
                            itemWeightList.Clear();
                            itemWeightList = DALitemWeight.getItemWeightListByItemStyleID(itemList[i].ID);
                            itemWeightList.TrimExcess();
                            for (j = 0; j < itemWeightList.Count; j++)
                            {
                                rows = dgvEstimateItems_itemsFromSlip.Rows.Add();
                                dgvEstimateItems_itemsFromSlip.Rows[rows].Cells[0].Value = itemList[i].Name;
                                dgvEstimateItems_itemsFromSlip.Rows[rows].Cells[1].Value = DALitemStyle.getItemStyleName(itemWeightList[j].StyleID);
                                dgvEstimateItems_itemsFromSlip.Rows[rows].Cells[2].Value = DALitemSize.getItemSizeName(itemWeightList[j].SizeID);
                                //dgvEstimateItems_itemsFromSlip.Rows[rows].Cells[3].Value = Convert.ToInt32(txtSlip_itemsFromSlip.Text) / itemWeightList[j].Weight;
                                dgvEstimateItems_itemsFromSlip.Rows[rows].Cells[3].Value = Math.Round((Convert.ToSingle(txtSlip_itemsFromSlip.Text) / itemWeightList[j].Weight),2);
                            }
                            ///////////////////////////////////
                        }

                    }//end show by item
                    //show by style
                    if (cbxCategory_itemsFromSlip.Text == "Style")
                    {
                        itemStyleList.Clear();
                        dgvEstimateItems_itemsFromSlip.Columns[0].HeaderText = "Style";
                        dgvEstimateItems_itemsFromSlip.Columns[1].HeaderText = "Item";
                        dgvEstimateItems_itemsFromSlip.Columns[2].HeaderText = "Size";
                        rows = 0;
                        dgvEstimateItems_itemsFromSlip.Rows.Clear();
                        itemStyleList = DALitemStyle.getItemStyleList();
                        itemStyleList.TrimExcess();
                        for (i = 0; i < itemStyleList.Count; i++)
                        {
                            ////////////////////////////////////
                            itemWeightList.Clear();
                            itemWeightList = DALitemWeight.getItemWeightListByItemStyleID(itemStyleList[i].ID);
                            itemWeightList.TrimExcess();
                            for (j = 0; j < itemWeightList.Count; j++)
                            {
                                rows = dgvEstimateItems_itemsFromSlip.Rows.Add();
                                dgvEstimateItems_itemsFromSlip.Rows[rows].Cells[0].Value = itemStyleList[i].Name;
                                dgvEstimateItems_itemsFromSlip.Rows[rows].Cells[1].Value = DALitem.getItemName(itemWeightList[j].ItemID);
                                dgvEstimateItems_itemsFromSlip.Rows[rows].Cells[2].Value = DALitemSize.getItemSizeName(itemWeightList[j].SizeID);
                                dgvEstimateItems_itemsFromSlip.Rows[rows].Cells[3].Value = Convert.ToSingle(txtSlip_itemsFromSlip.Text) / itemWeightList[j].Weight;
                            }
                            ///////////////////////////////////
                        }

                    }//end show by style
                    //show by size
                    if (cbxCategory_itemsFromSlip.Text == "Size")
                    {
                        itemSizeList.Clear();
                        dgvEstimateItems_itemsFromSlip.Columns[0].HeaderText = "Size";
                        dgvEstimateItems_itemsFromSlip.Columns[1].HeaderText = "Item";
                        dgvEstimateItems_itemsFromSlip.Columns[2].HeaderText = "Style";
                        rows = 0;
                        dgvEstimateItems_itemsFromSlip.Rows.Clear();
                        itemSizeList = DALitemSize.getItemSizeList();
                        itemSizeList.TrimExcess();
                        for (i = 0; i < itemSizeList.Count; i++)
                        {
                            ////////////////////////////////////
                            itemWeightList.Clear();
                            itemWeightList = DALitemWeight.getItemWeightListByItemSizID(itemSizeList[i].ID);
                            itemWeightList.TrimExcess();
                            for (j = 0; j < itemWeightList.Count; j++)
                            {
                                rows = dgvEstimateItems_itemsFromSlip.Rows.Add();
                                dgvEstimateItems_itemsFromSlip.Rows[rows].Cells[0].Value = itemSizeList[i].Name;
                                dgvEstimateItems_itemsFromSlip.Rows[rows].Cells[1].Value = DALitem.getItemName(itemWeightList[j].ItemID);
                                dgvEstimateItems_itemsFromSlip.Rows[rows].Cells[2].Value = DALitemStyle.getItemStyleName(itemWeightList[j].StyleID);
                                dgvEstimateItems_itemsFromSlip.Rows[rows].Cells[3].Value = Convert.ToSingle(txtSlip_itemsFromSlip.Text) / itemWeightList[j].Weight;
                            }
                            ///////////////////////////////////
                        }

                    }//end show by size
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSlip_itemsFromSlip_MouseClick(object sender, MouseEventArgs e)
        {
            txtSlip_itemsFromSlip.Focus();
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
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
                dt.Columns.Add("Slip Available", typeof(string));
         
                ds.Tables.Add(dt);

                for (int i = 0; i <= rows; i++)
                {
                    dataRow = ds.Tables[0].NewRow();
                    dataRow[0] = dgvEstimateItems_itemsFromSlip.Rows[i].Cells[0].Value.ToString();
                    dataRow[1] = dgvEstimateItems_itemsFromSlip.Rows[i].Cells[1].Value.ToString();
                    dataRow[2] = dgvEstimateItems_itemsFromSlip.Rows[i].Cells[2].Value.ToString();
                    dataRow[3] = dgvEstimateItems_itemsFromSlip.Rows[i].Cells[3].Value.ToString();
                    dataRow[4] = txtSlip_itemsFromSlip.Text;   
 
                    ds.Tables[0].Rows.Add(dataRow);
                }
                if(cbxCategory_itemsFromSlip.Text.Equals("Item"))
                {
                    rptFrmPrediction report = new rptFrmPrediction();
                    report.ItemEstimationFromSlipByItem(ds);
                    report.Show();
                }
                else if (cbxCategory_itemsFromSlip.Text.Equals("Style"))
                {
                    rptFrmPrediction report = new rptFrmPrediction();
                    report.ItemEstimationFromSlipByStyle(ds);
                    report.Show();
                }
                else if (cbxCategory_itemsFromSlip.Text.Equals("Size"))
                {
                    rptFrmPrediction report = new rptFrmPrediction();
                    report.ItemEstimationFromSlipBySize(ds);
                    report.Show();
                }
            }
        }
    }
}
