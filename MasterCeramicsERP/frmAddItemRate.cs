using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MasterCeramicsERP.Datasets;
using MasterCeramicsERP.Datasets.dsPayrollTableAdapters;
using MCERP.DAL;
using MCERP.Entities;

namespace MasterCeramicsERP
{
    public partial class frmAddItemRate : Form
    {
        DataSet dsItems = new DataSet();
        DataSet dsItemStyle = new DataSet();
        DataSet dsItemSize = new DataSet();
        DataSet dsKillenItem = new DataSet();
        DataSet dsColor = new DataSet();

        int row = -1, selectedRow = -1;

        private void frmAddItemRate_Load(object sender, EventArgs e)
        {
            loadComboBoxes();
            loadGrid();
        }
        public frmAddItemRate()
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
                KillenItemCategoryDAL killenItemCategoryDAL = new KillenItemCategoryDAL();
                ColorDAL colorDAL = new ColorDAL();

                //populate cbx of all color
                dsColor.Clear();
                dsColor = colorDAL.getAllColor();
                cbxColor.DataSource = dsColor.Tables[0];
                cbxColor.DisplayMember = "Name";
                //end populate

                //populate killen item category cbx
                dsKillenItem.Clear();
                dsKillenItem = killenItemCategoryDAL.getAllKillenItemCategory();
                cbxItemCategory.DataSource = dsKillenItem.Tables[0];
                cbxItemCategory.DisplayMember = "Name";
                //end populate

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
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadGrid()
        {
            try
            {
                dsPayroll.ItemPriceDataTable dt = new dsPayroll.ItemPriceDataTable();
                ItemPriceTableAdapter dal = new ItemPriceTableAdapter();
                dt = dal.GetData();
                dgvItemWeight.DataSource = dt;
                dgvItemWeight.Columns["ItemID"].Visible = false;
                dgvItemWeight.Columns["StyleID"].Visible = false;
                dgvItemWeight.Columns["SizeID"].Visible = false;
                dgvItemWeight.Columns["ColorID"].Visible = false;
                dgvItemWeight.Columns["CategoryID"].Visible = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtPrice_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtPrice.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ItemPriceTableAdapter dal = new ItemPriceTableAdapter();
                if (dal.checkIsitemExist(cbxItem.Text, cbxStyle.Text, cbxSize.Text, cbxColor.Text, cbxItemCategory.Text) == null)
                {
                    if (txtPrice.Text.Equals(""))
                    {
                        MessageBox.Show("Enter item price...?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ItemDAL itemdal = new ItemDAL();
                        DALItemStyle styledal = new DALItemStyle();
                        ItemSizeDAL sizedal = new ItemSizeDAL();
                        ColorDAL colordal = new ColorDAL();
                        KillenItemCategoryDAL catdal = new KillenItemCategoryDAL();
                        dal.InsertQuery(itemdal.getItemID(cbxItem.Text), styledal.getStyleID(cbxStyle.Text), sizedal.getSizeID(cbxSize.Text), colordal.getColorID(cbxColor.Text), catdal.getKillenItemCategoryID(cbxItemCategory.Text), Convert.ToInt32(txtPrice.Text));
                        loadGrid();
                        selectedRow = -1;
                        txtPrice.Text = "";
                        MessageBox.Show("New item added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRow.Equals(-1))
            {
                MessageBox.Show("Select item ...?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPrice.Text.Equals(""))
            {
                MessageBox.Show("Enter item price...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ItemPriceTableAdapter dal = new ItemPriceTableAdapter();
                int price = Convert.ToInt32(txtPrice.Text);
                string item = dgvItemWeight.Rows[selectedRow].Cells["Item"].Value.ToString();
                string style = dgvItemWeight.Rows[selectedRow].Cells["Style"].Value.ToString();
                string size = dgvItemWeight.Rows[selectedRow].Cells["Size"].Value.ToString();
                string color = dgvItemWeight.Rows[selectedRow].Cells["Color"].Value.ToString();
                string category = dgvItemWeight.Rows[selectedRow].Cells["Category"].Value.ToString();
                dal.UpdateQuery(price, item, style, size, color, category);
                loadGrid();
                selectedRow = -1;
                txtPrice.Text = "";
                MessageBox.Show("Item updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvItemWeight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRow.Equals(-1))
            {
                MessageBox.Show("Select item ...?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Are you sure you want to delete ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ItemPriceTableAdapter dal = new ItemPriceTableAdapter();
                int item = Convert.ToInt32(dgvItemWeight.Rows[selectedRow].Cells["ItemID"].Value.ToString());
                int style = Convert.ToInt32(dgvItemWeight.Rows[selectedRow].Cells["StyleID"].Value.ToString());
                int size = Convert.ToInt32(dgvItemWeight.Rows[selectedRow].Cells["SizeID"].Value.ToString());
                int color = Convert.ToInt32(dgvItemWeight.Rows[selectedRow].Cells["ColorID"].Value.ToString());
                int category = Convert.ToInt32(dgvItemWeight.Rows[selectedRow].Cells["CategoryID"].Value.ToString());
                dal.DeleteQuery(item, style, size, color, category);
                loadGrid();
                selectedRow = -1;
                txtPrice.Text = "";
                MessageBox.Show("Item deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItemWeight.Rows.Count.Equals(0))
                {
                    MessageBox.Show("No record found...?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = (DataTable)dgvItemWeight.DataSource;
                    rptFrmSaleCreateBill report = new rptFrmSaleCreateBill();
                    report.printItemPriceList(dt);
                    report.Show();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
