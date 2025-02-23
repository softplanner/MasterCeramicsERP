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
    public partial class frmAddItemSize : Form
    {
        //ItemSizeDAL sizeDAL = new ItemSizeDAL();
        int row = -1, selectedRow = -1;

        public frmAddItemSize()
        {
            InitializeComponent();
        }

        private void frmAddItemSize_Load(object sender, EventArgs e)
        {
            loadStyleDGV();
        }
        private void loadStyleDGV()
        {
            try
            {
                ItemSizeDAL sizeDAL = new ItemSizeDAL();

                row = -1;
                selectedRow = -1;
                dgvItems.Rows.Clear();
                List<ItemSize> lst = new List<ItemSize>();
                lst = sizeDAL.getItemSizeList();
                lst.TrimExcess();
                for (Int16 i = 0; i < lst.Count; i++)
                {
                    row = dgvItems.Rows.Add();
                    dgvItems.Rows[row].Cells[0].Value = lst[i].ID;
                    dgvItems.Rows[row].Cells[1].Value = lst[i].Name;
                }
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
                ItemSizeDAL sizeDAL = new ItemSizeDAL();

                if (txtName.Text.Equals(""))
                {
                    MessageBox.Show("Enter item name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sizeDAL.isItemSizeExist(txtName.Text).Equals(true))
                {
                    MessageBox.Show("Item size already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Text = "";
                }
                else
                {
                    sizeDAL.addNewItemSize(txtName.Text);
                    MessageBox.Show("New item size has been added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadStyleDGV();
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
                ItemSizeDAL sizeDAL = new ItemSizeDAL();

                if (selectedRow == -1)
                {
                    MessageBox.Show("Select item size...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtName.Text.Equals(""))
                {
                    MessageBox.Show("Enter size name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sizeDAL.isItemSizeExist(txtName.Text).Equals(true))
                {
                    MessageBox.Show("Item size already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Text = "";
                }
                else
                {
                    ItemSize i = new ItemSize();
                    i.ID = Convert.ToInt16(dgvItems.Rows[selectedRow].Cells[0].Value);
                    i.Name = txtName.Text;
                    sizeDAL.updateItemSize(i);
                    MessageBox.Show("Item size has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvItems.Rows[selectedRow].Cells[1].Value = txtName.Text;
                    txtName.Text = "";
                    selectedRow = -1;
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
                ItemSizeDAL sizeDAL = new ItemSizeDAL();

                if (selectedRow == -1)
                {
                    MessageBox.Show("select item size...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sizeDAL.deleteItemSize(Convert.ToInt16(dgvItems.Rows[selectedRow].Cells[0].Value));
                    MessageBox.Show("Selected item size has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvItems.Rows.RemoveAt(selectedRow);
                    txtName.Text = "";
                    selectedRow = -1;
                    row--;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Due to dependencies can't delete this item size...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow != -1)
            {
                txtName.Text = dgvItems.Rows[selectedRow].Cells[1].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadStyleDGV();
        }

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Focus();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }
    }
}
