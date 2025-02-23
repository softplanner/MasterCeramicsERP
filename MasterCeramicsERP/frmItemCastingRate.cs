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
using MasterCeramicsERP.Datasets.dsPayrollTableAdapters;

namespace MasterCeramicsERP
{
    public partial class frmItemCastingRate : Form
    {
        DataSet dsItems = new DataSet();
        DataSet dsItemStyle = new DataSet();
        DataSet dsItemSize = new DataSet();
        int selectedRow = -1;
        public frmItemCastingRate()
        {
            InitializeComponent();
        }
        private void frmItemCastingRate_Load(object sender, EventArgs e)
        {
            loadComboBoxes();
            loadDGV();
        }
        private void loadComboBoxes()
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();

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
        private void loadDGV()
        {
            try
            {
                ItemCastingRateTableAdapter dal = new ItemCastingRateTableAdapter();
                dsPayroll.ItemCastingRateDataTable dt = new dsPayroll.ItemCastingRateDataTable();
                dt = dal.GetData();
                dgvItemWeight.DataSource = dt;
                dgvItemWeight.Columns["ItemID"].Visible = false;
                dgvItemWeight.Columns["StyleID"].Visible = false;
                dgvItemWeight.Columns["SizeID"].Visible = false;
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
                if (cbxItem.Text != "" && cbxStyle.Text != "" && cbxSize.Text != "" && txtItemRate.Text != "")
                {
                    ItemCastingRateTableAdapter dal = new ItemCastingRateTableAdapter();
                    if (dal.checkIsItemExist(cbxItem.Text, cbxStyle.Text, cbxSize.Text) == null)
                    {
                        ItemDAL itemDal = new ItemDAL();
                        DALItemStyle styleDal = new DALItemStyle();
                        ItemSizeDAL sizeDal = new ItemSizeDAL();
                        int itemId = 0, styleId = 0, sizeId = 0;
                        itemId = itemDal.getItemID(cbxItem.Text);
                        styleId = styleDal.getStyleID(cbxStyle.Text);
                        sizeId = sizeDal.getSizeID(cbxSize.Text);
                        dal.InsertQuery(itemId, styleId, sizeId, Convert.ToInt32(txtItemRate.Text));
                        MessageBox.Show("New item casting rate added ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        selectedRow = -1;
                        txtItemRate.Text = "";
                        loadDGV();
                    }
                    else
                    {
                        MessageBox.Show("Already Exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
                    }
                }
                else
                {
                    MessageBox.Show("Enter proper info.?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvItemWeight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRow != -1 && txtItemRate.Text != "")
            {
                ItemCastingRateTableAdapter dal = new ItemCastingRateTableAdapter();
                int itemId = 0, styleId = 0, sizeId = 0;
                itemId = Convert.ToInt32(dgvItemWeight.Rows[selectedRow].Cells["ItemID"].Value.ToString());
                styleId = Convert.ToInt32(dgvItemWeight.Rows[selectedRow].Cells["StyleID"].Value.ToString());
                sizeId = Convert.ToInt32(dgvItemWeight.Rows[selectedRow].Cells["SizeID"].Value.ToString());
                dal.UpdateQuery(Convert.ToInt32(txtItemRate.Text), itemId, styleId, sizeId);
                MessageBox.Show("Item casting rate has update ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedRow = -1 ;
                txtItemRate.Text ="" ;
                loadDGV();
            }
            else
            {
                MessageBox.Show("Enter proper info...?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtItemRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtItemRate_MouseClick(object sender, MouseEventArgs e)
        {
            txtItemRate.Focus();
        }

        rptFrmItemCastingRate report;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = (DataTable)dgvItemWeight.DataSource;
                //if (!this.Parent.Contains(report))
                //{
                report = new rptFrmItemCastingRate();
                //report.TopLevel = false;
                //report.Dock = DockStyle.Fill;
                //this.Parent.Controls.Add(report);
                //report.Show();

                report.showRateListDT(dt);
                report.BringToFront();
                report.Show();
                //}
                //else
                //{
                //    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   }
}
