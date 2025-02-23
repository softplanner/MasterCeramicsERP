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
using MasterCeramicsERP.Datasets.dsDBTableAdapters;
using MasterCeramicsERP.Datasets;
namespace MasterCeramicsERP
{
    public partial class frmKillenFeed : Form
    {
        int row = -1, selectedRow = -1,glazeRow=-1,glazeSelectedRow=-1;

        public frmKillenFeed()
        {
            InitializeComponent();
        }
        private void populateGlazeHouseStock()
        {
            try
            {
                GlazeStockCompanyTableAdapter dal = new GlazeStockCompanyTableAdapter();
                dsDB.GlazeStockCompanyDataTable dt = new dsDB.GlazeStockCompanyDataTable();
                dt = dal.GetData();
                dgvGlazedStock.DataSource = dt;
                dgvGlazedStock.Columns["ItemID"].Visible = false;
                dgvGlazedStock.Columns["StyleID"].Visible = false;
                dgvGlazedStock.Columns["SizeID"].Visible = false;
                dgvGlazedStock.Columns["ColorID"].Visible = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (glazeSelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select some item's from stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtQuantity.Text == "")
                {
                    MessageBox.Show("Enter killen feed quantity... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtBreakage.Text == "")
                {
                    MessageBox.Show("Enter breakage quantity... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((Convert.ToInt32(txtQuantity.Text) + Convert.ToInt32(txtBreakage.Text)) > Convert.ToInt32(dgvGlazedStock.Rows[glazeSelectedRow].Cells["gQuantity"].Value.ToString()))
                {
                    MessageBox.Show("Entered quantity is greater than stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    addRowToDataGrid();
                    //deductQuantityFromGlazedStock();
                    glazeSelectedRow = -1;
                    selectedRow = -1;
                    txtQuantity.Text = "";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //====================================================================================================================================    
        private void addRowToDataGrid()
        {
            for (Int16 i = 0; i <= row; i++)
            {
                if (dgvGlazedStock.Rows[glazeSelectedRow].Cells["gItem"].Value.ToString().Equals(dgvKillenReport.Rows[i].Cells["kItem"].Value.ToString()))
                {
                    if (dgvGlazedStock.Rows[glazeSelectedRow].Cells["gStyle"].Value.Equals(dgvKillenReport.Rows[i].Cells["kStyle"].Value))
                    {
                        if (dgvGlazedStock.Rows[glazeSelectedRow].Cells["gSize"].Value.Equals(dgvKillenReport.Rows[i].Cells["kSize"].Value))
                        {
                            if (dgvGlazedStock.Rows[glazeSelectedRow].Cells["gColor"].Value.Equals(dgvKillenReport.Rows[i].Cells["kColor"].Value))
                            {
                                dgvKillenReport.Rows.RemoveAt(i);
                                break;
                            }
                        }
                    }
                }
            }
                //////------Show record in the data grid view------//////
                row = dgvKillenReport.Rows.Add();
                //MessageBox.Show(row.ToString());
                dgvKillenReport.Rows[row].Cells["kItem"].Value = dgvGlazedStock.Rows[glazeSelectedRow].Cells["gItem"].Value;
                dgvKillenReport.Rows[row].Cells["kStyle"].Value = dgvGlazedStock.Rows[glazeSelectedRow].Cells["gStyle"].Value;
                dgvKillenReport.Rows[row].Cells["kSize"].Value = dgvGlazedStock.Rows[glazeSelectedRow].Cells["gSize"].Value;
                dgvKillenReport.Rows[row].Cells["kColor"].Value = dgvGlazedStock.Rows[glazeSelectedRow].Cells["gColor"].Value;
                dgvKillenReport.Rows[row].Cells["kQuantity"].Value = txtQuantity.Text;
                dgvKillenReport.Rows[row].Cells["kBreakage"].Value = txtBreakage.Text;
                dgvKillenReport.Rows[row].Cells["kRemarks"].Value = txtRemarks.Text;
                ////------End show record in the data grid view------////
        }
        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (selectedRow == -1)
            {
                MessageBox.Show("first seelct some record !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvKillenReport.Rows.RemoveAt(selectedRow);
                }
            }
        }
        private void btnAddDB_Click(object sender, EventArgs e)
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                ColorDAL colorDAL = new ColorDAL();
                GlazeStockCompanyTableAdapter dalGlazeStock = new GlazeStockCompanyTableAdapter();
                KillenFeedReportTableAdapter dalKillen = new KillenFeedReportTableAdapter();
                KillenFeedStockTableAdapter dalKillenFeedStock = new KillenFeedStockTableAdapter();

                int new_qunatity = 0;
                int stock_Quantity = 0;
                int deduct_Quantity=0;
                int killen_Feed_Quantity = 0;
                if (row == -1)
                {
                    MessageBox.Show("No record found for save...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    killenFeedReport k;
                    for (Int16 i = 0; i <= row; i++)
                    {
                        //=====add killen feed report
                        k = new killenFeedReport();
                        k.ItemID = itemDAL.getItemID(dgvKillenReport.Rows[i].Cells["kItem"].Value.ToString());
                        k.StyleID = styleDAL.getStyleID(dgvKillenReport.Rows[i].Cells["kStyle"].Value.ToString());
                        k.SizeID = sizeDAL.getSizeID(dgvKillenReport.Rows[i].Cells["kSize"].Value.ToString());
                        k.ColorID = colorDAL.getColorID(dgvKillenReport.Rows[i].Cells["kColor"].Value.ToString());
                        k.Quantity = Convert.ToInt32(dgvKillenReport.Rows[i].Cells["kQuantity"].Value.ToString());
                        k.Breakage = Convert.ToInt32(dgvKillenReport.Rows[i].Cells["kBreakage"].Value.ToString());
                        k.Remarks = dgvKillenReport.Rows[i].Cells["kRemarks"].Value.ToString();
                        k.Date = DateTime.Now;
                        //-----addd report
                        dalKillen.InsertQuery(k.ItemID, k.StyleID, k.SizeID, k.ColorID, k.Quantity, k.Breakage, k.Date, k.Remarks);
                        //-----update glazed Stock
                        deduct_Quantity = k.Quantity + k.Breakage;
                        stock_Quantity = Convert.ToInt32(dalGlazeStock.getStockQuantity(k.ItemID, k.StyleID, k.SizeID, k.ColorID));
                        new_qunatity = stock_Quantity - deduct_Quantity;
                        dalGlazeStock.UpdateQueryByID(new_qunatity,k.ItemID,k.StyleID,k.SizeID,k.ColorID);
                        //-----update killen feed stock
                        if (Convert.ToInt32(dalKillenFeedStock.checkIsItemExist(k.ItemID, k.StyleID, k.SizeID, k.ColorID)) > 0)
                        {
                            //update here
                            killen_Feed_Quantity = Convert.ToInt32(dalKillenFeedStock.getStockByID(k.ItemID, k.StyleID, k.SizeID, k.ColorID));
                            dalKillenFeedStock.UpdateQuery(k.Quantity + killen_Feed_Quantity, k.ItemID, k.StyleID, k.SizeID, k.ColorID);
                        }
                        else
                        {
                            dalKillenFeedStock.InsertQuery(k.ItemID, k.StyleID, k.SizeID, k.ColorID, k.Quantity);
                        }

                    }
                }

                dgvKillenReport.Rows.Clear();
                glazeRow = -1;
                glazeSelectedRow = -1;
                selectedRow = -1;
                row = -1;
                txtQuantity.Text = "";
                txtBreakage.Text = "";
                txtRemarks.Text = "";
                populateGlazeHouseStock();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmKillenFeed_Load(object sender, EventArgs e)
        {
            populateGlazeHouseStock();
        }

        private void dgvGlazedStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            glazeSelectedRow = e.RowIndex;
        }

        private void dgvKillenReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
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

        private void txtBreakage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtBreakage_MouseClick(object sender, MouseEventArgs e)
        {
            txtBreakage.Focus();
        }
    }
}
