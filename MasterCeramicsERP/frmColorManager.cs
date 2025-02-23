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
    public partial class frmColorManager : Form
    {
        //ColorDAL dal = new ColorDAL();
        int row = -1, selectedRow = -1;
        public frmColorManager()
        {
            InitializeComponent();
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(selectedRow!=-1)
            {
                txtName.Text = dgvItems.Rows[selectedRow].Cells[1].Value.ToString();
            }
        }

        private void cbxCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadDatragrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxCategory.Text.Equals(""))
                {
                    MessageBox.Show("Select category e.g white, light, special ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtName.Text.Equals(""))
                {
                    MessageBox.Show("Enter new color name ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ColorDAL dal = new ColorDAL();

                    if (dal.checkIsAlreadyExist(txtName.Text).Equals(true))
                    {
                        MessageBox.Show("Already exist ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Colors obj = new Colors();
                        obj.Name = txtName.Text;
                        obj.Type = cbxCategory.Text;
                        dal.addColor(obj);
                        MessageBox.Show("New color has been added ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDatragrid();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Database error ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select color from list ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtName.Text.Equals(""))
                {
                    MessageBox.Show("Enter new color name ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ColorDAL dal = new ColorDAL();

                    if (dal.checkIsAlreadyExist(txtName.Text).Equals(true))
                    {
                        MessageBox.Show("Already exist ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Colors obj = new Colors();
                        obj.ID=Convert.ToInt16(dgvItems.Rows[selectedRow].Cells[0].Value);
                        obj.Name = txtName.Text;
                        obj.Type = cbxCategory.Text;
                        dal.updateColor(obj);
                        MessageBox.Show("Selected color has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDatragrid();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Database error ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select color from list ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ColorDAL dal = new ColorDAL();

                    dal.deleteColorByID(Convert.ToInt16(dgvItems.Rows[selectedRow].Cells[0].Value));
                    MessageBox.Show("Selected color has been delete...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvItems.Rows.RemoveAt(selectedRow);
                    loadDatragrid();
                }
            }
            catch
            {
                MessageBox.Show("Due to dependencies, can't delete selected color...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
        private void loadDatragrid()
        {
            try
            {
                if (cbxCategory.Text!="")
                {
                    ColorDAL dal = new ColorDAL();
                    List<Colors> list = new List<Colors>();
                    list = dal.getColorObjectListByType(cbxCategory.Text);
                    row = selectedRow = -1;
                    dgvItems.Rows.Clear();
                    for (int i = 0; i < list.Count; i++)
                    {
                        row = dgvItems.Rows.Add();
                        dgvItems.Rows[i].Cells[0].Value = list[i].ID.ToString();
                        dgvItems.Rows[i].Cells[1].Value = list[i].Name.ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Database error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
