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
    public partial class frmAddRawMaterial : Form
    {
        //RawMaterialDAL dal = new RawMaterialDAL();
        //RawMaterialStockDAL stockDal = new RawMaterialStockDAL();
        int selectedRow = -1,row=-1;
        public frmAddRawMaterial()
        {
            InitializeComponent();
        }
        private void loadDataGrid()
        {
            try
            {
                RawMaterialDAL dal = new RawMaterialDAL();
                
                //===empty text feilds
                txtID.Text = "";
                txtName.Text = "";
                //===empty text feilds
                selectedRow = -1;
                row = -1;
                dgvrawMaterial.Rows.Clear();
                List<RawMaterial> lst = new List<RawMaterial>();
                lst = dal.getAllRawMaterialList();
                lst.TrimExcess();
                for (Int16 i = 0; i < lst.Count; i++)
                {
                    row = dgvrawMaterial.Rows.Add();
                    dgvrawMaterial.Rows[row].Cells[0].Value = lst[i].ID.ToString();
                    dgvrawMaterial.Rows[row].Cells[1].Value = lst[i].Name;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmAddRawMaterial_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            loadDataGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                RawMaterialDAL dal = new RawMaterialDAL();
                RawMaterialStockDAL stockDal = new RawMaterialStockDAL();

                if (txtName.Text.Equals(""))
                {
                    MessageBox.Show("Enter name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dal.IsAlreadyExist(txtName.Text).Equals(true))
                {
                    MessageBox.Show("Raw material already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    dal.addRawMaterial(txtName.Text);
                    RawMaterialStock stock = new RawMaterialStock();
                    stock.RMID = dal.getMaterialID(txtName.Text);
                    stock.Quantity = 0;
                    stock.AlarmAmount = 0;
                    stockDal.addStockObj(stock);
                    MessageBox.Show("New raw material has been added in the raw material list", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("New raw material has been added in the stock list", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGrid();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearFeild_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDataGrid();
            txtID.Text = "";
            txtName.Text = "";
        }

        private void dgvrawMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow != -1)
            {
                txtID.Text = dgvrawMaterial.Rows[selectedRow].Cells[0].Value.ToString();
                txtName.Text = dgvrawMaterial.Rows[selectedRow].Cells[1].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this raw material name ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RawMaterialDAL dal = new RawMaterialDAL();

                    if (selectedRow.Equals(-1))
                    {
                        MessageBox.Show("First select raw material...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dal.IsAlreadyExist(txtName.Text).Equals(true))
                    {
                        MessageBox.Show("Raw material already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        RawMaterial obj = new RawMaterial();
                        obj.ID = Convert.ToInt16(txtID.Text);
                        obj.Name = txtName.Text;
                        dal.updateRawMaterial(obj);
                        MessageBox.Show("Raw material name has been updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDataGrid();
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
                if (MessageBox.Show("Are you sure you want to delete ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RawMaterialDAL dal = new RawMaterialDAL();
                    RawMaterialStockDAL stockDal = new RawMaterialStockDAL();

                    if (selectedRow.Equals(-1))
                    {
                        MessageBox.Show("First select raw material...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dal.IsSlipPercentageDependsUpon(Convert.ToInt16(txtID.Text)).Equals(true))
                    {
                        MessageBox.Show("Cannot delete this raw material ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (Convert.ToSingle(stockDal.getStock(Convert.ToInt16(txtID.Text))).Equals(0))
                    {
                        if (MessageBox.Show("Are you sure you want to delete this raw material ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            dal.deleteRawMaterial(Convert.ToInt16(txtID.Text));
                            txtID.Text = "";
                            txtName.Text = "";
                            MessageBox.Show("Selected raw material has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadDataGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Raw material available in stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            catch(Exception exp) 
            {
                MessageBox.Show(exp.ToString()+"Selected raw material available in stock so, can't delete this ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Focus();
        }
    }
}
