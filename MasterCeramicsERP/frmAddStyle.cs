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
    public partial class frmAddStyle : Form
    {
        //DALItemStyle styleDAL = new DALItemStyle();
        int row = -1, selectedRow = -1;

        public frmAddStyle()
        {
            InitializeComponent();
        }

        private void frmAddStyle_Load(object sender, EventArgs e)
        {
            loadStyleDGV();
        }
        private void loadStyleDGV()
        {
            try
            {
                DALItemStyle styleDAL = new DALItemStyle();

                row = -1;
                selectedRow = -1;
                dgvItems.Rows.Clear();
                List<ItemStyle> lst = new List<ItemStyle>();
                lst = styleDAL.getItemStyleList();
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
                DALItemStyle styleDAL = new DALItemStyle();

                if (txtName.Text.Equals(""))
                {
                    MessageBox.Show("Enter Item Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (styleDAL.isItemsStyleExists(txtName.Text).Equals(true))
                {
                    MessageBox.Show("Style Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Text = "";
                }
                else
                {
                    styleDAL.addNewItemStyle(txtName.Text);
                    MessageBox.Show("Item Style Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DALItemStyle styleDAL = new DALItemStyle();

                if (selectedRow == -1)
                {
                    MessageBox.Show("Select Style For Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtName.Text.Equals(""))
                {
                    MessageBox.Show("Enter Style Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (styleDAL.isItemsStyleExists(txtName.Text).Equals(true))
                {
                    MessageBox.Show("Style Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Text = "";
                }
                else
                {
                    ItemStyle i = new ItemStyle();
                    i.ID = Convert.ToInt16(dgvItems.Rows[selectedRow].Cells[0].Value);
                    i.Name = txtName.Text;
                    styleDAL.updateItemStyle(i);
                    MessageBox.Show("Style Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (selectedRow == -1)
                {
                    MessageBox.Show("Select Style For Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DALItemStyle styleDAL = new DALItemStyle();

                    styleDAL.deleteItemStyle(Convert.ToInt16(dgvItems.Rows[selectedRow].Cells[0].Value));
                    MessageBox.Show("Selected item style has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvItems.Rows.RemoveAt(selectedRow);
                    txtName.Text = "";
                    selectedRow = -1;
                    row--;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Due to dependencies can't delete this item style...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
