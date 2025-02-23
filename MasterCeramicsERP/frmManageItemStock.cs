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
    public partial class frmManageItemStock : Form
    {
        
        Int16 unglazeRow = -1, glazeRow = -1, readyItemsRow = -1;

        //UnGlazeStockCompanyDAL unglazeStockD = new UnGlazeStockCompanyDAL();
        //GlazeStockCompanyDAL glazeStockD = new GlazeStockCompanyDAL();
        //ItemDAL itemDAL = new ItemDAL();
        //DALItemStyle styleDAL = new DALItemStyle();
        //ItemSizeDAL sizeDAL = new ItemSizeDAL();
        //ReadyItemStockDAL readyItemStockDAL = new ReadyItemStockDAL();
        //ColorDAL colorDAL = new ColorDAL();
        //KillenItemCategoryDAL killenItemCategoryDAL = new KillenItemCategoryDAL();

        DataSet dsItemStyle = new DataSet();
        DataSet dsItemSize = new DataSet();
        DataSet dsItem = new DataSet();
        DataSet dsColor = new DataSet();
        DataSet dsCategory = new DataSet();

        int unglazeSelectedRow = -1, glazeSelectedRow = -1, readyItemStockSelectedRow = -1;

        public frmManageItemStock()
        {
            InitializeComponent();
        }

        private void populateGridWithUnglazeStock()
        {
            try
            {
                UnGlazeStockCompanyDAL unglazeStockD = new UnGlazeStockCompanyDAL();
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                
                dgvUnglazeStock.Rows.Clear();
                unglazeRow = -1;
                unglazeSelectedRow = -1;
                List<UnGlazeStockCompany> list = new List<UnGlazeStockCompany>();
                list = unglazeStockD.getStock();
                list.TrimExcess();
                for (Int16 i = 0; i < list.Count; i++)
                {
                    unglazeRow = Convert.ToInt16(dgvUnglazeStock.Rows.Add());
                    dgvUnglazeStock.Rows[i].Cells[0].Value = itemDAL.getItemName(list[i].ItemID);
                    dgvUnglazeStock.Rows[i].Cells[1].Value = styleDAL.getItemStyleName(list[i].StyleID);
                    dgvUnglazeStock.Rows[i].Cells[2].Value = sizeDAL.getItemSizeName(list[i].SizeID);
                    dgvUnglazeStock.Rows[i].Cells[3].Value = list[i].Quantity;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void populateGridWithGlazedStock()
        {
            try
            {
                GlazeStockCompanyDAL glazeStockD = new GlazeStockCompanyDAL();
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                ColorDAL colorDAL = new ColorDAL();
                
                dgvGlazedStock.Rows.Clear();
                glazeRow = -1;
                glazeSelectedRow = -1;
                List<GlazeStockCompany> list = new List<GlazeStockCompany>();
                list = glazeStockD.getStock();
                list.TrimExcess();
                for (Int16 i = 0; i < list.Count; i++)
                {
                    glazeRow = Convert.ToInt16(dgvGlazedStock.Rows.Add());
                    dgvGlazedStock.Rows[i].Cells[0].Value = itemDAL.getItemName(list[i].ItemID);
                    dgvGlazedStock.Rows[i].Cells[1].Value = styleDAL.getItemStyleName(list[i].StyleID);
                    dgvGlazedStock.Rows[i].Cells[2].Value = sizeDAL.getItemSizeName(list[i].SizeID);
                    dgvGlazedStock.Rows[i].Cells[3].Value = colorDAL.getColorName(list[i].ColorID);
                    dgvGlazedStock.Rows[i].Cells[4].Value = list[i].Quantity;

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void populateGridWithReadyItems()
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                ReadyItemStockDAL readyItemStockDAL = new ReadyItemStockDAL();
                ColorDAL colorDAL = new ColorDAL();
                KillenItemCategoryDAL killenItemCategoryDAL = new KillenItemCategoryDAL();

                dgvReadyItems.Rows.Clear();
                readyItemsRow = -1;
                readyItemStockSelectedRow = -1;
                List<ReadyItemStock> list = new List<ReadyItemStock>();
                list = readyItemStockDAL.getStock();
                list.TrimExcess();
                for (Int16 i = 0; i < list.Count; i++)
                {
                    readyItemsRow = Convert.ToInt16(dgvReadyItems.Rows.Add());
                    dgvReadyItems.Rows[i].Cells[0].Value = itemDAL.getItemName(list[i].ItemID);
                    dgvReadyItems.Rows[i].Cells[1].Value = styleDAL.getItemStyleName(list[i].StyleID);
                    dgvReadyItems.Rows[i].Cells[2].Value = sizeDAL.getItemSizeName(list[i].SizeID);
                    dgvReadyItems.Rows[i].Cells[3].Value = colorDAL.getColorName(list[i].ColorID);
                    dgvReadyItems.Rows[i].Cells[4].Value = killenItemCategoryDAL.getKillenItemCategoryName(list[i].Category);
                    dgvReadyItems.Rows[i].Cells[5].Value = list[i].Quantity;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                UnGlazeStockCompanyDAL unglazeStockD = new UnGlazeStockCompanyDAL();
                GlazeStockCompanyDAL glazeStockD = new GlazeStockCompanyDAL();
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                ReadyItemStockDAL readyItemStockDAL = new ReadyItemStockDAL();
                ColorDAL colorDAL = new ColorDAL();
                KillenItemCategoryDAL killenItemCategoryDAL = new KillenItemCategoryDAL();

                txtUnglazeQuantity.Text = unglazeStockD.getStockByItemStyleSize(itemDAL.getItemID(cbxItem.Text), styleDAL.getStyleID(cbxStyle.Text), sizeDAL.getSizeID(cbxSize.Text)).ToString();
                txtGlazedQuantity.Text = glazeStockD.getStockByItemStyleSizeColor(itemDAL.getItemID(cbxItem.Text), styleDAL.getStyleID(cbxStyle.Text), sizeDAL.getSizeID(cbxSize.Text), colorDAL.getColorID(cbxColor.Text)).ToString();
                txtReadyItems.Text = readyItemStockDAL.getStockByItemStyleSizeCategoryColorCategory(itemDAL.getItemID(cbxItem.Text), styleDAL.getStyleID(cbxStyle.Text), sizeDAL.getSizeID(cbxSize.Text), colorDAL.getColorID(cbxColor.Text), killenItemCategoryDAL.getKillenItemCategoryID(cbxCategory.Text)).ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (txtUnglazeQuantity.Text.Equals(""))
                {
                    MessageBox.Show("Enter some quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    
                    UnGlazeStockCompany u = new UnGlazeStockCompany();
                    UnGlazeStockCompanyDAL dal = new UnGlazeStockCompanyDAL();
                    u.ItemID = itemDAL.getItemID(cbxItem.Text);
                    u.StyleID = styleDAL.getStyleID(cbxStyle.Text);
                    u.SizeID = sizeDAL.getSizeID(cbxSize.Text);
                    u.Quantity = Convert.ToInt32(txtUnglazeQuantity.Text);
                    if (dal.checkIsItemAlreadyExist(u).Equals(true))
                    {
                        MessageBox.Show("Item already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dal.addStock(u);
                        MessageBox.Show("New item has been added in unglaze item stock...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtGlazedQuantity.Text = "";
                        txtUnglazeQuantity.Text = "";
                        txtReadyItems.Text = "";
                        populateGridWithUnglazeStock();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGlazedItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGlazedQuantity.Text.Equals(""))
                {
                    MessageBox.Show("Enter some quantity... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    ColorDAL colorDAL = new ColorDAL();
                    
                    GlazeStockCompany u = new GlazeStockCompany();
                    GlazeStockCompanyDAL dal = new GlazeStockCompanyDAL();
                    u.ItemID = itemDAL.getItemID(cbxItem.Text);
                    u.StyleID = styleDAL.getStyleID(cbxStyle.Text);
                    u.SizeID = sizeDAL.getSizeID(cbxSize.Text);
                    u.ColorID = colorDAL.getColorID(cbxColor.Text);
                    u.Quantity = Convert.ToInt32(txtGlazedQuantity.Text);
                    if (dal.checkIsItemExistByObject(u).Equals(true))
                    {
                        MessageBox.Show("Item already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dal.addStock(u);
                        MessageBox.Show("New item has been added in glazed item stock...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtGlazedQuantity.Text = "";
                        txtUnglazeQuantity.Text = "";
                        txtReadyItems.Text = "";
                        populateGridWithGlazedStock();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadyItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtReadyItems.Text.Equals(""))
                {
                    MessageBox.Show("Enter some quantity ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    ColorDAL colorDAL = new ColorDAL();
                    KillenItemCategoryDAL killenItemCategoryDAL = new KillenItemCategoryDAL();

                    ReadyItemStock u = new ReadyItemStock();
                    ReadyItemStockDAL dal = new ReadyItemStockDAL();
                    u.ItemID = itemDAL.getItemID(cbxItem.Text);
                    u.StyleID = styleDAL.getStyleID(cbxStyle.Text);
                    u.SizeID = sizeDAL.getSizeID(cbxSize.Text);
                    u.ColorID = colorDAL.getColorID(cbxColor.Text);
                    u.Category = killenItemCategoryDAL.getKillenItemCategoryID(cbxCategory.Text);
                    u.Quantity = Convert.ToInt32(txtReadyItems.Text);
                    if (dal.checkISitemExistByObject(u).Equals(true))
                    {
                        MessageBox.Show("Item already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dal.addStock(u);
                        MessageBox.Show("New item has been added to ready item stock...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtGlazedQuantity.Text = "";
                        txtUnglazeQuantity.Text = "";
                        txtReadyItems.Text = "";
                        populateGridWithReadyItems();
                    }
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

        private void btnDeleteUnglaze_Click(object sender, EventArgs e)
        {
            try
            {
                if (unglazeSelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select some item ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    

                    UnGlazeStockCompany u = new UnGlazeStockCompany();
                    UnGlazeStockCompanyDAL dal = new UnGlazeStockCompanyDAL();
                    u.ItemID = itemDAL.getItemID(dgvUnglazeStock.Rows[unglazeSelectedRow].Cells[0].Value.ToString());
                    u.StyleID = styleDAL.getStyleID(dgvUnglazeStock.Rows[unglazeSelectedRow].Cells[1].Value.ToString());
                    u.SizeID = sizeDAL.getSizeID(dgvUnglazeStock.Rows[unglazeSelectedRow].Cells[2].Value.ToString());
                    dal.deleteStock(u);
                    MessageBox.Show("Item has been deleted from unglaze item stock...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGlazedQuantity.Text = "";
                    txtUnglazeQuantity.Text = "";
                    txtReadyItems.Text = "";
                    populateGridWithUnglazeStock();
                 }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteGlaze_Click(object sender, EventArgs e)
        {
            try
            {
                if (glazeSelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select some item... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    ColorDAL colorDAL = new ColorDAL();
                    
                    GlazeStockCompany u = new GlazeStockCompany();
                    GlazeStockCompanyDAL dal = new GlazeStockCompanyDAL();
                    u.ItemID = itemDAL.getItemID(dgvGlazedStock.Rows[glazeSelectedRow].Cells[0].Value.ToString());
                    u.StyleID = styleDAL.getStyleID(dgvGlazedStock.Rows[glazeSelectedRow].Cells[1].Value.ToString());
                    u.SizeID = sizeDAL.getSizeID(dgvGlazedStock.Rows[glazeSelectedRow].Cells[2].Value.ToString());
                    u.ColorID = colorDAL.getColorID(dgvGlazedStock.Rows[glazeSelectedRow].Cells[3].Value.ToString());
                    dal.deleteStock(u);
                    MessageBox.Show("Item has been deleted from glazed item stock...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGlazedQuantity.Text = "";
                    txtUnglazeQuantity.Text = "";
                    txtReadyItems.Text = "";
                    populateGridWithGlazedStock();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteReady_Click(object sender, EventArgs e)
        {
            try
            {
                if (readyItemStockSelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select some item...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    ColorDAL colorDAL = new ColorDAL();
                    KillenItemCategoryDAL killenItemCategoryDAL = new KillenItemCategoryDAL();

                    ReadyItemStock u = new ReadyItemStock();
                    ReadyItemStockDAL dal = new ReadyItemStockDAL();
                    u.ItemID = itemDAL.getItemID(dgvReadyItems.Rows[readyItemStockSelectedRow].Cells[0].Value.ToString());
                    u.StyleID = styleDAL.getStyleID(dgvReadyItems.Rows[readyItemStockSelectedRow].Cells[1].Value.ToString());
                    u.SizeID = sizeDAL.getSizeID(dgvReadyItems.Rows[readyItemStockSelectedRow].Cells[2].Value.ToString());
                    u.ColorID = colorDAL.getColorID(dgvReadyItems.Rows[readyItemStockSelectedRow].Cells[3].Value.ToString());
                    u.Category = killenItemCategoryDAL.getKillenItemCategoryID(dgvReadyItems.Rows[readyItemStockSelectedRow].Cells[4].Value.ToString());
                    dal.deleteStock(u);
                    MessageBox.Show("Item has been deleted from ready item stock...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
