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
    public partial class frmCompanyItemStock : Form
    {
        Int16 unglazeRow = -1,glazeRow=-1,readyItemsRow=-1;
        DataSet dsItemStyle = new DataSet();
        DataSet dsItemSize = new DataSet();
        DataSet dsItem = new DataSet();
        DataSet dsColor = new DataSet();
        DataSet dsCategory = new DataSet();
        
        public frmCompanyItemStock()
        {
            InitializeComponent();
        }

        private void frmCompanyItemStock_Load(object sender, EventArgs e)
        {
            populateComboBoxes();
            populateGridWithUnglazeStock();
            populateGridWithGlazedStock();
            populateGridWithReadyItems();
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
                txtUnglazeQuantity.Text = dalUStock.getUnglazeStock(cbxItem.Text,cbxStyle.Text,cbxSize.Text).ToString();
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
            populateGridWithUnglazeStock();
            populateGridWithGlazedStock();
            populateGridWithReadyItems();
            populateComboBoxes();
        }
        //-----Report Objects
        rptFrmUnglazeItemStock report;
        private void btnPrintUnglaze_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                 dt = (DataTable)dgvUnglazeStock.DataSource;
                //if (!this.Parent.Contains(report))
                //{
                    report = new rptFrmUnglazeItemStock();
                    //reportUnglazeItem.TopLevel = false;
                    //reportUnglazeItem.Dock = DockStyle.Fill;
                    //this.Parent.Controls.Add(reportUnglazeItem);
                    report.UnglazeStockByDT(dt);
                    report.Show();
                    report.BringToFront();
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

        private void btnGlazedItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = (DataTable)dgvGlazedStock.DataSource;
                //if (!this.Parent.Contains(report))
                //{
                    report = new rptFrmUnglazeItemStock();
                    //reportGlazedItem.TopLevel = false;
                    //reportGlazedItem.Dock = DockStyle.Fill;
                    //this.Parent.Controls.Add(reportGlazedItem);
                    report.glazedItemStockByDT(dt);
                    report.Show();
                    report.BringToFront();
                //}
                //else
                //{
                //    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
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
                DataTable dt = new DataTable();
                dt = (DataTable)dgvReadyItems.DataSource;
                //if (!this.Parent.Contains(report))
                //{
                    report = new rptFrmUnglazeItemStock();
                    //reportReadyItem.TopLevel = false;
                    //reportReadyItem.Dock = DockStyle.Fill;
                    //this.Parent.Controls.Add(reportReadyItem);
                    report.readyItemStockByDT(dt);
                    report.Show();
                    report.BringToFront();
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
