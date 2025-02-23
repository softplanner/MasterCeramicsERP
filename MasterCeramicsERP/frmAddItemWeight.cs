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
    public partial class frmAddItemWeight : Form
    {
        DataSet dsItems = new DataSet();       
        DataSet dsItemStyle = new DataSet();
        DataSet dsItemSize = new DataSet();

        int row = -1, selectedRow = -1;
        public frmAddItemWeight()
        {
            InitializeComponent();
        }
        private void loadWeightDGV()
        {
            try
            {
                //ItemCrossJoinTableAdapter dal = new ItemCrossJoinTableAdapter();
                //dsDB.ItemCrossJoinDataTable dt = new dsDB.ItemCrossJoinDataTable();
                //dt = dal.GetItemByCrossJoin();
                //dgvItemWeight.Columns["ItemID"].Visible = false;
                //dgvItemWeight.Columns["StyleID"].Visible = false;
                //dgvItemWeight.Columns["SizeID"].Visible = false;
                //dgvItemWeight.DataSource = dt;
                ItemDAL itemDAL = new ItemDAL();
                DALItemStyle styleDAL = new DALItemStyle();
                ItemSizeDAL sizeDAL = new ItemSizeDAL();
                ItemWeightDAL weightDAL = new ItemWeightDAL();

                row = -1;
                selectedRow = -1;
                dgvItemWeight.Rows.Clear();
                List<ItemWeight> lst = new List<ItemWeight>();
                lst = weightDAL.getItemWeightList();
                lst.TrimExcess();
                for (Int16 i = 0; i < lst.Count; i++)
                {
                    row = dgvItemWeight.Rows.Add();
                    dgvItemWeight.Rows[row].Cells[0].Value = itemDAL.getItemName(lst[i].ItemID);
                    dgvItemWeight.Rows[row].Cells[1].Value = styleDAL.getItemStyleName(lst[i].StyleID);
                    dgvItemWeight.Rows[row].Cells[2].Value = sizeDAL.getItemSizeName(lst[i].SizeID);
                    dgvItemWeight.Rows[row].Cells[3].Value = lst[i].Weight.ToString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmAddItemWeight_Load(object sender, EventArgs e)
        {
            loadWeightDGV();
            loadComboBoxes();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtWeight.Text.Equals(""))
                {
                    MessageBox.Show("Enter item weight...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    ItemWeightDAL weightDAL = new ItemWeightDAL();

                    ItemWeight i = new ItemWeight();
                    i.ItemID = itemDAL.getItemID(cbxItem.Text);
                    i.StyleID = styleDAL.getStyleID(cbxStyle.Text);
                    i.SizeID = sizeDAL.getSizeID(cbxSize.Text);
                    i.Weight = Convert.ToSingle(txtWeight.Text);
                    if (weightDAL.isAlreadyExist(i))
                    {
                        MessageBox.Show("Already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtWeight.Text = "";
                    }
                    else
                    {
                        weightDAL.addItemWeight(i);
                        MessageBox.Show("Item weight has been added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtWeight.Text = "";
                        loadWeightDGV();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadWeightDGV();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select item...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtWeight.Text.Equals(""))
                {
                    MessageBox.Show("Enter item weight...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    ItemWeightDAL weightDAL = new ItemWeightDAL();

                    ItemWeight iu = new ItemWeight();
                    iu.ItemID = itemDAL.getItemID(cbxItem.Text);
                    iu.StyleID = styleDAL.getStyleID(cbxStyle.Text);
                    iu.SizeID = sizeDAL.getSizeID(cbxSize.Text);
                    iu.Weight = Convert.ToSingle(txtWeight.Text);
                    if (Convert.ToInt32(weightDAL.getItemWeights(iu)).Equals(Convert.ToInt32(txtWeight.Text)))
                    {
                        MessageBox.Show("Already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtWeight.Text = "";
                    }
                    else
                    {
                        //if (weightDAL.isAlreadyExist(iu))
                        //{
                        //    MessageBox.Show("Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    txtWeight.Text = "";
                        //}
                        //else
                        //{
                        ItemWeight ip = new ItemWeight();
                        ip.ItemID = itemDAL.getItemID(dgvItemWeight.Rows[selectedRow].Cells[0].Value.ToString());
                        ip.StyleID = styleDAL.getStyleID(dgvItemWeight.Rows[selectedRow].Cells[1].Value.ToString());
                        ip.SizeID = sizeDAL.getSizeID(dgvItemWeight.Rows[selectedRow].Cells[2].Value.ToString());
                        ip.Weight = Convert.ToSingle(dgvItemWeight.Rows[selectedRow].Cells[3].Value.ToString());
                        weightDAL.updateItemWeight(iu, ip);
                        MessageBox.Show("Item Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvItemWeight.Rows[selectedRow].Cells[0].Value = cbxItem.Text;
                        dgvItemWeight.Rows[selectedRow].Cells[1].Value = cbxStyle.Text;
                        dgvItemWeight.Rows[selectedRow].Cells[2].Value = cbxSize.Text;
                        dgvItemWeight.Rows[selectedRow].Cells[3].Value = txtWeight.Text;
                        txtWeight.Text = "";
                        selectedRow = -1;
                        //}
                    }
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
            if (selectedRow != -1)
            {
                txtWeight.Text = dgvItemWeight.Rows[selectedRow].Cells[3].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select item...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemDAL itemDAL = new ItemDAL();
                    DALItemStyle styleDAL = new DALItemStyle();
                    ItemSizeDAL sizeDAL = new ItemSizeDAL();
                    ItemWeightDAL weightDAL = new ItemWeightDAL();

                    ItemWeight ip = new ItemWeight();
                    ip.ItemID = itemDAL.getItemID(dgvItemWeight.Rows[selectedRow].Cells[0].Value.ToString());
                    ip.StyleID = styleDAL.getStyleID(dgvItemWeight.Rows[selectedRow].Cells[1].Value.ToString());
                    ip.SizeID = sizeDAL.getSizeID(dgvItemWeight.Rows[selectedRow].Cells[2].Value.ToString());
                    ip.Weight = Convert.ToSingle(dgvItemWeight.Rows[selectedRow].Cells[3].Value.ToString());
                    weightDAL.deleteWeight(ip);
                    MessageBox.Show("Selected item has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvItemWeight.Rows.RemoveAt(selectedRow);
                    selectedRow = -1;
                    row--;
                    txtWeight.Text = "";

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Due to dependencies can't delete this item weight...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';

            else if ((e.KeyChar < '0') || (e.KeyChar > '9') || e.KeyChar == '.')
            {
                if (e.KeyChar == '.')
                {
                    if (txtWeight.Text.Contains("."))
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

        private void txtWeight_MouseClick(object sender, MouseEventArgs e)
        {
            txtWeight.Focus();
        }
        //-----------------------------------------------------------------------------------------------------------
    }
}
