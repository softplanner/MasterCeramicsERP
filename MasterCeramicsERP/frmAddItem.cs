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
    public partial class frmAddItem : Form
    {
        //ItemDAL itemDAL = new ItemDAL();
        int row = -1, selectedRow = -1;
        public frmAddItem()
        {
            InitializeComponent();
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            loadItemDGV();
        }
        private void loadItemDGV()
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();

                row = -1;
                selectedRow = -1;
                dgvItems.Rows.Clear();
                List<Item> lst = new List<Item>();
                lst = itemDAL.getItemList();
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

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow != -1)
            {
                txtName.Text = dgvItems.Rows[selectedRow].Cells[1].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();

                if (txtName.Text.Equals(""))
                {
                    MessageBox.Show("Enter item name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (itemDAL.isItemsExistsByName(txtName.Text).Equals(true))
                {
                    MessageBox.Show("Item already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Text = "";
                }
                else
                {
                    itemDAL.addNewItem(txtName.Text);
                    MessageBox.Show("New item has been added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadItemDGV();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadItemDGV();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ItemDAL itemDAL = new ItemDAL();

                if (selectedRow == -1)
                {
                    MessageBox.Show("Select item for update...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (txtName.Text.Equals(""))
                {
                    MessageBox.Show("Enter item name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (itemDAL.isItemExistByName(txtName.Text).Equals(true))
                {
                    MessageBox.Show("Item already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Text = "";
                }
                else
                {
                    Item i = new Item();
                    i.ID = Convert.ToInt16(dgvItems.Rows[selectedRow].Cells[0].Value);
                    i.Name = txtName.Text;
                    itemDAL.updateItem(i);
                    MessageBox.Show("Selected item has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvItems.Rows[selectedRow].Cells[1].Value = txtName.Text;
                    txtName.Text = "";
                    loadItemDGV();
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
                ItemDAL itemDAL = new ItemDAL();

                if (selectedRow == -1)
                {
                    MessageBox.Show("Select item...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    itemDAL.deleteItem(Convert.ToInt16(dgvItems.Rows[selectedRow].Cells[0].Value));
                    MessageBox.Show("Selected item has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvItems.Rows.RemoveAt(selectedRow);
                    txtName.Text = "";
                    loadItemDGV();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Due to dependencies can't delete this item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
