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
    public partial class frmCompanyMoldStock : Form
    {
        //ItemDAL itemD = new ItemDAL();
        //DALItemStyle styleD = new DALItemStyle();
        //ItemSizeDAL sizeD = new ItemSizeDAL();
        //MoldStockCompanyDAL moldStockD = new MoldStockCompanyDAL();

        DataSet dsItemStyle = new DataSet();
        DataSet dsItemSize = new DataSet();
        DataSet dsItem = new DataSet();
        Int16 row=0,selectedRow=-1;
        public frmCompanyMoldStock()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getStock();            
        }
        private void getStock() 
        {
            try
            {
                ItemDAL itemD = new ItemDAL();
                DALItemStyle styleD = new DALItemStyle();
                ItemSizeDAL sizeD = new ItemSizeDAL();
                MoldStockCompanyDAL moldStockD = new MoldStockCompanyDAL();

                txtMoldQuantity.Text = moldStockD.getStockByItemStyleSize(itemD.getItemID(cbxItem.Text), styleD.getStyleID(cbxStyle.Text), sizeD.getSizeID(cbxSize.Text)).ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCompanyMoldStock_Load(object sender, EventArgs e)
        {
            populateComboBoxes();
            populateGridWithMoldStock();
        }
        private void populateComboBoxes()
        {
            try
            {
                ItemDAL itemD = new ItemDAL();
                DALItemStyle styleD = new DALItemStyle();
                ItemSizeDAL sizeD = new ItemSizeDAL();
                MoldStockCompanyDAL moldStockD = new MoldStockCompanyDAL();

                //populate cbx With All Item
                dsItem.Clear();
                dsItem = itemD.getAllItem();
                cbxItem.DataSource = dsItem.Tables[0];
                cbxItem.DisplayMember = "Name";
                //end populate

                //populate cbx of all itemstyle
                dsItemStyle.Clear();
                dsItemStyle = styleD.getAllItemStyle();
                cbxStyle.DataSource = dsItemStyle.Tables[0];
                cbxStyle.DisplayMember = "Name";
                //end populate

                //populate cbx of all item size
                dsItemSize.Clear();
                dsItemSize = sizeD.getAllItemSize();
                cbxSize.DataSource = dsItemSize.Tables[0];
                cbxSize.DisplayMember = "Name";
                //end populate
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            selectedRow = -1;
            txtMoldQuantity.Text = "";
            txtUpdate.Text = "";
            populateComboBoxes();
        }
        public void populateGridWithMoldStock()
        {
            try
            {
                ItemDAL itemD = new ItemDAL();
                DALItemStyle styleD = new DALItemStyle();
                ItemSizeDAL sizeD = new ItemSizeDAL();
                MoldStockCompanyDAL moldStockD = new MoldStockCompanyDAL();

                dgvMold.Rows.Clear();
                selectedRow = -1;
                row = -1;
                List<MoldStockCompany> list = new List<MoldStockCompany>();
                list = moldStockD.getStock();
                list.TrimExcess();
                for (Int16 i = 0; i < list.Count; i++)
                {
                    row = Convert.ToInt16(dgvMold.Rows.Add());
                    dgvMold.Rows[i].Cells[0].Value = itemD.getItemName(list[i].ItemID);
                    dgvMold.Rows[i].Cells[1].Value = styleD.getItemStyleName(list[i].StyleID);
                    dgvMold.Rows[i].Cells[2].Value = sizeD.getItemSizeName(list[i].SizeID);
                    dgvMold.Rows[i].Cells[3].Value = list[i].Quantity;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select record...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtUpdate.Text == "")
                {
                    MessageBox.Show("Enter some quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemDAL itemD = new ItemDAL();
                    DALItemStyle styleD = new DALItemStyle();
                    ItemSizeDAL sizeD = new ItemSizeDAL();
                    MoldStockCompanyDAL moldStockD = new MoldStockCompanyDAL();

                    MoldStockCompany m = new MoldStockCompany();
                    m.ItemID = itemD.getItemID(dgvMold.Rows[selectedRow].Cells[0].Value.ToString());
                    m.StyleID = styleD.getStyleID(dgvMold.Rows[selectedRow].Cells[1].Value.ToString());
                    m.SizeID = sizeD.getSizeID(dgvMold.Rows[selectedRow].Cells[2].Value.ToString());
                    m.Quantity = Convert.ToInt16(txtUpdate.Text);
                    moldStockD.updateStock(m);
                    MessageBox.Show("Selected mold quantity has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMoldQuantity.Text = "";
                    txtUpdate.Text = "";
                    populateGridWithMoldStock();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvMold_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = Convert.ToInt16(e.RowIndex);
            if (selectedRow != -1)
            {
                txtMoldQuantity.Text=dgvMold.Rows[selectedRow].Cells[3].Value.ToString();
            }
        }
        //-----report object
        rptFrmMoldStockCompany report;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!this.Parent.Contains(report))
                //{
                    report = new rptFrmMoldStockCompany();
                    //report.TopLevel = false;
                    //report.Dock = DockStyle.Fill;
                    //this.Parent.Controls.Add(report);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMoldQuantity.Text == "")
                {
                    MessageBox.Show("Enter quantity...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemDAL itemD = new ItemDAL();
                    DALItemStyle styleD = new DALItemStyle();
                    ItemSizeDAL sizeD = new ItemSizeDAL();
                    MoldStockCompanyDAL moldStockD = new MoldStockCompanyDAL();

                    MoldStockCompany m = new MoldStockCompany();
                    m.ItemID = itemD.getItemID(cbxItem.Text);
                    m.StyleID = styleD.getStyleID(cbxStyle.Text);
                    m.SizeID = sizeD.getSizeID(cbxSize.Text);
                    if (moldStockD.checkIsMoldExist(m.ItemID, m.StyleID, m.SizeID).Equals(1))
                    {
                        MessageBox.Show("Mold already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        m.Quantity = Convert.ToInt16(Convert.ToInt32(txtMoldQuantity.Text));
                        moldStockD.addStock(m);
                        MessageBox.Show("New mold has been added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        populateGridWithMoldStock();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First select mold...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    ItemDAL itemD = new ItemDAL();
                    DALItemStyle styleD = new DALItemStyle();
                    ItemSizeDAL sizeD = new ItemSizeDAL();
                    MoldStockCompanyDAL moldStockD = new MoldStockCompanyDAL();

                    MoldStockCompany m = new MoldStockCompany();
                    m.ItemID = itemD.getItemID(cbxItem.Text);
                    m.StyleID = styleD.getStyleID(cbxStyle.Text);
                    m.SizeID = sizeD.getSizeID(cbxSize.Text);
                    //m.Quantity = Convert.ToInt16(Convert.ToInt32(txtMoldQuantity.Text) + Convert.ToInt32(moldStockD.getStockByItemStyleSize(m.ItemID, m.StyleID, m.SizeID)));
                    moldStockD.deleteStock(m);
                    MessageBox.Show("Selected mold has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMoldQuantity.Text = "";
                    populateGridWithMoldStock();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMoldQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            txtUpdate.Focus();
        }

        private void txtMoldQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            txtMoldQuantity.Focus();
        }
    }
}
