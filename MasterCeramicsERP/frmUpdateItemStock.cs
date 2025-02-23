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
    public partial class frmUpdateItemStock : Form
    {
        Int16 unglazeRow = -1, glazeRow = -1, readyItemsRow = -1;
        DataSet dsItemStyle = new DataSet();
        DataSet dsItemSize = new DataSet();
        DataSet dsItem = new DataSet();
        DataSet dsColor = new DataSet();
        DataSet dsCategory = new DataSet();

        int unglazeSelectedRow = -1, glazeSelectedRow = -1, readyItemStockSelectedRow = -1;
        public frmUpdateItemStock()
        {
            InitializeComponent();
        }
        private void populateGridWithUnglazeStock()
        {
            try
            {
                taUnglazeStockCompany dal = new taUnglazeStockCompany();
                dsDB.UnglazeStockCompanyDataTable dt = new dsDB.UnglazeStockCompanyDataTable();
                dt = dal.GetData();
                dgvUnglazeStock.DataSource = dt;

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void populateGridWithGlazedStock()
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
        private void populateGridWithReadyItems()
        {
            try
            {
                ReadyItemStockTableAdapter dal = new ReadyItemStockTableAdapter();
                dsDB.ReadyItemStockDataTable dt = new dsDB.ReadyItemStockDataTable();

                dt = dal.GetData();
                dgvReadyItems.DataSource = dt;
                dgvReadyItems.Columns["ItemID"].Visible = false;
                dgvReadyItems.Columns["StyleID"].Visible = false;
                dgvReadyItems.Columns["SizeID"].Visible = false;
                dgvReadyItems.Columns["ColorID"].Visible = false;
                dgvReadyItems.Columns["Category"].Visible = false;
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
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                ColorDAL colorDAL = new ColorDAL();
                KillenItemCategoryDAL killenItemCategoryDAL = new KillenItemCategoryDAL();

                //populate cbx With All Item
                dsItem.Clear();
                dsItem = itemDAL.getAllItem();
                cbxItem.DataSource = dsItem.Tables[0];
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

                //populate cbx of all color
                dsColor.Clear();
                dsColor = colorDAL.getAllColor();
                cbxColor.DataSource = dsColor.Tables[0];
                cbxColor.DisplayMember = "Name";
                //end populate

                //populate cbx category
                dsCategory.Clear();
                dsCategory = killenItemCategoryDAL.getAllKillenItemCategory();
                cbxCategory.DataSource = dsCategory.Tables[0];
                cbxCategory.DisplayMember = "Name";
                //end
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getStock();
        }
        private void getStock()
        {
            try
            {
                //-----
                taUnglazeStockCompany dalUStock = new taUnglazeStockCompany();
                GlazeStockCompanyTableAdapter dalGStock = new GlazeStockCompanyTableAdapter();
                ReadyItemStockTableAdapter dalReadyItem = new ReadyItemStockTableAdapter();
                txtUnglazeQuantity.Text = dalUStock.getUnglazeStock(cbxItem.Text, cbxStyle.Text, cbxSize.Text).ToString();
                txtGlazedQuantity.Text = dalGStock.getStcokByName(cbxItem.Text, cbxStyle.Text, cbxSize.Text, cbxColor.Text).ToString();
                txtReadyItems.Text = dalReadyItem.getStockByName(cbxItem.Text, cbxStyle.Text, cbxSize.Text, cbxColor.Text, cbxCategory.Text).ToString();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtGlazedQuantity.Text = "";
            txtUnglazeQuantity.Text = "";
            txtReadyItems.Text = "";
            populateComboBoxes();
            populateGridWithUnglazeStock();
            populateGridWithGlazedStock();
            populateGridWithReadyItems();
        }
        //-----Report Objects
        private void btnPrintUnglaze_Click(object sender, EventArgs e)
        {
            try
            {
                if (unglazeSelectedRow.Equals(-1))
                {
                    MessageBox.Show("First select unglaze item stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtUnglazeQuantity.Text.Equals(""))
                {
                    MessageBox.Show("Enter quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    taUnglazeStockCompany dal = new taUnglazeStockCompany();
                    string item = dgvUnglazeStock.Rows[unglazeSelectedRow].Cells["uItem"].Value.ToString();
                    string style = dgvUnglazeStock.Rows[unglazeSelectedRow].Cells["uStyle"].Value.ToString();
                    string iSize = dgvUnglazeStock.Rows[unglazeSelectedRow].Cells["uSize"].Value.ToString();
                    int q = Convert.ToInt32(txtUnglazeQuantity.Text);
                    dal.updateStockByName(q, item, style, iSize);
                    MessageBox.Show("Unglaze item stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGlazedQuantity.Text = "";
                    txtUnglazeQuantity.Text = "";
                    txtReadyItems.Text = "";
                    populateGridWithUnglazeStock();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGlazedItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (glazeSelectedRow.Equals(-1))
                {
                    MessageBox.Show("First select glazed item stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtGlazedQuantity.Text.Equals(""))
                {
                    MessageBox.Show("Enter quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GlazeStockCompanyTableAdapter dal = new GlazeStockCompanyTableAdapter();
                    string item = dgvGlazedStock.Rows[glazeSelectedRow].Cells["gItem"].Value.ToString();
                    string style = dgvGlazedStock.Rows[glazeSelectedRow].Cells["gStyle"].Value.ToString();
                    string iSize = dgvGlazedStock.Rows[glazeSelectedRow].Cells["gSize"].Value.ToString();
                    string color = dgvGlazedStock.Rows[glazeSelectedRow].Cells["gColor"].Value.ToString();
                    int q = Convert.ToInt32(txtGlazedQuantity.Text);
                    dal.UpdateQueryByName(q, item, style, iSize,color);
                    MessageBox.Show("Glazed item stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGlazedQuantity.Text = "";
                    txtUnglazeQuantity.Text = "";
                    txtReadyItems.Text = "";
                    populateGridWithGlazedStock();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadyItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (readyItemStockSelectedRow.Equals(-1))
                {
                    MessageBox.Show("First select item from ready item stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtReadyItems.Text.Equals(""))
                {
                    MessageBox.Show("Enter quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ReadyItemStockTableAdapter dal = new ReadyItemStockTableAdapter();
                    string item = dgvReadyItems.Rows[readyItemStockSelectedRow].Cells["rItem"].Value.ToString();
                    string style = dgvReadyItems.Rows[readyItemStockSelectedRow].Cells["rStyle"].Value.ToString();
                    string iSize = dgvReadyItems.Rows[readyItemStockSelectedRow].Cells["rSize"].Value.ToString();
                    string color = dgvReadyItems.Rows[readyItemStockSelectedRow].Cells["rColor"].Value.ToString();
                    string category = dgvReadyItems.Rows[readyItemStockSelectedRow].Cells["rItemCategory"].Value.ToString();
                    int q = Convert.ToInt32(txtReadyItems.Text);
                    dal.UpdateQueryByName(q, item, style, iSize, color, category);
                    MessageBox.Show("Ready item's stock has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGlazedQuantity.Text = "";
                    txtUnglazeQuantity.Text = "";
                    txtReadyItems.Text = "";
                    populateGridWithReadyItems();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUnglazeStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            unglazeSelectedRow = e.RowIndex;
        }

        private void dgvGlazedStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            glazeSelectedRow = e.RowIndex;
        }

        private void dgvReadyItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            readyItemStockSelectedRow = e.RowIndex;
        }

        private void frmUpdateItemStock_Load(object sender, EventArgs e)
        {
            populateComboBoxes();
            populateGridWithUnglazeStock();
            populateGridWithGlazedStock();
            populateGridWithReadyItems();
        }

        private void txtUnglazeQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtGlazedQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtReadyItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtUnglazeQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            txtUnglazeQuantity.Focus();
        }

        private void txtGlazedQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            txtGlazedQuantity.Focus();
        }

        private void txtReadyItems_MouseClick(object sender, MouseEventArgs e)
        {
            txtReadyItems.Focus();
        }
    }
}
