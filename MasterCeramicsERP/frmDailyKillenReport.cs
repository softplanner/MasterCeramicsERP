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
using MasterCeramicsERP.Datasets;
using MasterCeramicsERP.Datasets.dsDBTableAdapters;
namespace MasterCeramicsERP
{
    public partial class frmDailyKillenReport : Form
    {
        DataSet dsKillenItem = new DataSet();

        int kSelectedRow=-1,row=-1,selectedRow=-1;

        public frmDailyKillenReport()
        {
            InitializeComponent();
        }

        private void frmDailyKillenReport_Load(object sender, EventArgs e)
        {
            populateGridWithKillenFeedStock();
            populateComboBoxes();
        }
        private void populateGridWithKillenFeedStock()
        {
            try
            {
                KillenFeedStockTableAdapter dal = new KillenFeedStockTableAdapter();
                dsDB.KillenFeedStockDataTable dt = new dsDB.KillenFeedStockDataTable();
                dt = dal.GetData();
                dgvKillenFeedStock.DataSource = dt;
                dgvKillenFeedStock.Columns["ItemID"].Visible = false;
                dgvKillenFeedStock.Columns["StyleID"].Visible = false;
                dgvKillenFeedStock.Columns["SizeID"].Visible = false;
                dgvKillenFeedStock.Columns["ColorID"].Visible = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void populateComboBoxes()
        {
            try
            {
                KillenItemCategoryDAL killenItemCategoryDAL = new KillenItemCategoryDAL();

                //populate killen item category cbx
                dsKillenItem.Clear();
                dsKillenItem = killenItemCategoryDAL.getAllKillenItemCategory();
                cbxItemCategory.DataSource = dsKillenItem.Tables[0];
                cbxItemCategory.DisplayMember = "Name";
                //end populate
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
                if (kSelectedRow.Equals(-1))
                {
                    MessageBox.Show("First select item's from killen feed stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtQuantity.Text == "")
                {
                    MessageBox.Show("Enter quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(txtQuantity.Text) > Convert.ToInt32(dgvKillenFeedStock.Rows[kSelectedRow].Cells["sQuantity"].Value.ToString()))
                {
                    MessageBox.Show("Entered quantity is greater than available stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    addRowToDataGrid();
                    kSelectedRow = -1;
                    //----end
                    txtQuantity.Text = "";
                    txtRemarks.Text = "";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addRowToDataGrid()
        {
            try
            {
                for (Int16 i = 0; i <= row; i++)
                {
                    //if (dgvKillenReport.Rows[i].Cells[0].Value.Equals(cbxKillen.Text))
                    //{
                        if (dgvKillenReport.Rows[i].Cells["rItem"].Value.ToString().Equals(dgvKillenFeedStock.Rows[kSelectedRow].Cells["sItem"].Value.ToString()))
                        {
                            if (dgvKillenReport.Rows[i].Cells["rStyle"].Value.ToString().Equals(dgvKillenFeedStock.Rows[kSelectedRow].Cells["sStyle"].Value.ToString()))
                            {
                                if (dgvKillenReport.Rows[i].Cells["rSize"].Value.ToString().Equals(dgvKillenFeedStock.Rows[kSelectedRow].Cells["sSize"].Value.ToString()))
                                {
                                    if (dgvKillenReport.Rows[i].Cells["rColor"].Value.ToString().Equals(dgvKillenFeedStock.Rows[kSelectedRow].Cells["sColor"].Value.ToString()))
                                    {
                                        if (dgvKillenReport.Rows[i].Cells["rItemCategory"].Value.ToString().Equals(cbxItemCategory.Text))
                                        {
                                            if (dgvKillenReport.Rows[i].Cells["rKillenID"].Value.ToString().Equals(txtKillenNo.Text))
                                            {
                                                dgvKillenReport.Rows.RemoveAt(i);
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    //}
                }
                //////------Show record in the data grid view------//////
                row = Convert.ToInt16(dgvKillenReport.Rows.Add());
                //MessageBox.Show(row.ToString());

                dgvKillenReport.Rows[row].Cells["rKillenID"].Value = txtKillenNo.Text;
                dgvKillenReport.Rows[row].Cells["rItem"].Value = dgvKillenFeedStock.Rows[kSelectedRow].Cells["sItem"].Value.ToString();
                dgvKillenReport.Rows[row].Cells["rStyle"].Value = dgvKillenFeedStock.Rows[kSelectedRow].Cells["sStyle"].Value.ToString();
                dgvKillenReport.Rows[row].Cells["rSize"].Value = dgvKillenFeedStock.Rows[kSelectedRow].Cells["sSize"].Value.ToString();
                dgvKillenReport.Rows[row].Cells["rColor"].Value = dgvKillenFeedStock.Rows[kSelectedRow].Cells["sColor"].Value.ToString();
                dgvKillenReport.Rows[row].Cells["rItemCategory"].Value = cbxItemCategory.Text;
                dgvKillenReport.Rows[row].Cells["rQuantity"].Value = txtQuantity.Text;
                dgvKillenReport.Rows[row].Cells["rRemarks"].Value = txtRemarks.Text;
                ////------End show record in the data grid view------////
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvKillenReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = Convert.ToInt16(e.RowIndex);
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow == -1)
                {
                    MessageBox.Show("First select item for delete...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dgvKillenReport.Rows.RemoveAt(selectedRow);
                        selectedRow = -1;
                        row--;
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                //KillenDAL killenDAL = new KillenDAL();
                int feed_stock = 0;
                int ready_stock = 0;
                KillenItemCategoryDAL killenItemCategoryDAL = new KillenItemCategoryDAL();
                DailyKillenReportsTableAdapter dalDailyReport = new DailyKillenReportsTableAdapter();
                KillenFeedStockTableAdapter dalKillenFeedStock = new KillenFeedStockTableAdapter();
                ReadyItemStockTableAdapter dalReadyItem=new ReadyItemStockTableAdapter();
                if (row == -1)
                {
                    MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DailyKillenReport k = new DailyKillenReport();
                    //-----update killen feed stock
                    for (Int16 j = 0; j <= row; j++)
                    {
                        k = new DailyKillenReport();
                        k.ItemID = itemDAL.getItemID(dgvKillenReport.Rows[j].Cells["rItem"].Value.ToString());
                        k.StyleID = styleDAL.getStyleID(dgvKillenReport.Rows[j].Cells["rStyle"].Value.ToString());
                        k.SizeID = sizeDAL.getSizeID(dgvKillenReport.Rows[j].Cells["rSize"].Value.ToString());
                        k.ColorID = colorDAL.getColorID(dgvKillenReport.Rows[j].Cells["rColor"].Value.ToString());
                        k.KillenID = Convert.ToInt32(dgvKillenReport.Rows[j].Cells["rKillenID"].Value.ToString());
                        k.Quantity = Convert.ToInt32(dgvKillenReport.Rows[j].Cells["rQuantity"].Value.ToString());
                        k.Date = DateTime.Now;
                        k.ItemCategoryID = killenItemCategoryDAL.getKillenItemCategoryID(dgvKillenReport.Rows[j].Cells["rItemCategory"].Value.ToString());
                        k.Remarks = dgvKillenReport.Rows[j].Cells["rRemarks"].Value.ToString();
                        //------add daily killen report
                        dalDailyReport.InsertQuery(k.Date, k.KillenID, k.ItemID, k.StyleID, k.SizeID, k.ItemCategoryID, k.ColorID, k.Quantity, k.Remarks);
                        //-----deduct from killen feed stock
                        feed_stock = Convert.ToInt32(dalKillenFeedStock.getStockByID(k.ItemID, k.StyleID, k.SizeID, k.ColorID));
                        dalKillenFeedStock.UpdateQuery(feed_stock - k.Quantity, k.ItemID, k.StyleID, k.SizeID, k.ColorID);
                        //-----update ready item stock
                        if (Convert.ToInt32(dalReadyItem.checkIsItemExist(k.ItemID, k.StyleID, k.SizeID, k.ColorID, k.ItemCategoryID)) > 0)
                        {
                            //-----update here
                            ready_stock = Convert.ToInt32(dalReadyItem.getStockByID(k.ItemID, k.StyleID, k.SizeID, k.ColorID, k.ItemCategoryID)) - k.Quantity;
                            dalReadyItem.UpdateQuery(ready_stock, k.ItemID, k.StyleID, k.SizeID, k.ColorID, k.ItemCategoryID);
                        }
                        else 
                        {
                            dalReadyItem.InsertQuery(k.ItemID, k.StyleID, k.SizeID, k.ColorID, k.ItemCategoryID, k.Quantity);
                        }

                    }
                    MessageBox.Show("Report Added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvKillenReport.Rows.Clear();
                    row = -1;
                    selectedRow = -1;
                    populateGridWithKillenFeedStock();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvKillenFeedStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kSelectedRow = e.RowIndex;
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

        private void txtRemarks_MouseClick(object sender, MouseEventArgs e)
        {
            txtRemarks.Focus();
        }

        private void txtKillenNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtKillenNo_MouseClick(object sender, MouseEventArgs e)
        {
            txtKillenNo.Focus();
        }
        //========================================================================================
    }
}
