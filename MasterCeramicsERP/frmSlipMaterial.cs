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
    public partial class frmSlipMaterial : Form
    {
        public frmSlipMaterial()
        {
            InitializeComponent();
        }

        int selectedRow = -1,row = -1,slipRow = -1,slipSelectedRow =-1;

        private void loadDataGrid()
        {
            try
            {
                RawMaterialDAL dal = new RawMaterialDAL();

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
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadSlipMaterial()
        {
            try
            {
                SlipPercentageDAL slipDAL = new SlipPercentageDAL();

                slipSelectedRow= -1;
                slipRow = -1;
                dgvSlipMaterial.Rows.Clear();
                List<RawMaterial> lst = new List<RawMaterial>();
                lst = slipDAL.getRawMaterialList();
                lst.TrimExcess();
                for (Int16 i = 0; i < lst.Count; i++)
                {
                    slipRow = dgvSlipMaterial.Rows.Add();
                    dgvSlipMaterial.Rows[slipRow].Cells[0].Value = lst[i].ID.ToString();
                    dgvSlipMaterial.Rows[slipRow].Cells[1].Value = lst[i].Name;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Database connection error" + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSlipMaterial_Load(object sender, EventArgs e)
        {
            loadDataGrid();
            loadSlipMaterial();
        }

        private void dgvrawMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SlipPercentageDAL slipDAL = new SlipPercentageDAL();

                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select some raw material ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtSlipPercentage.Text.Equals(""))
                {
                    MessageBox.Show("Enter percentage amount...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (slipDAL.isMaterialExist(Convert.ToInt16(dgvrawMaterial.Rows[selectedRow].Cells[0].Value)).Equals(true))
                {
                    MessageBox.Show("Already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SlipPercentage obj = new SlipPercentage();
                    obj.RMID = Convert.ToInt16(dgvrawMaterial.Rows[selectedRow].Cells[0].Value);
                    obj.SlipPercent = Convert.ToSingle(txtSlipPercentage.Text);
                    slipDAL.addSlipPercentage(obj);
                    MessageBox.Show("New raw material in slip has been added successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadSlipMaterial();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Database error..." + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSlipPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';

            else if ((e.KeyChar < '0') || (e.KeyChar > '9') || e.KeyChar == '.')
            {
                if (e.KeyChar == '.')
                {
                    if (txtSlipPercentage.Text.Contains("."))
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

        private void txtSlipPercentage_MouseClick(object sender, MouseEventArgs e)
        {
            txtSlipPercentage.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SlipPercentageDAL slipDAL = new SlipPercentageDAL();

                if (slipSelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select some raw material from slip material...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    slipDAL.deleteSlipPercent(Convert.ToInt16(dgvSlipMaterial.Rows[slipSelectedRow].Cells[0].Value));
                    MessageBox.Show("Selected raw material has been deleted ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadSlipMaterial();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Database connection error" + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSlipMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            slipSelectedRow = e.RowIndex;
        }
    }
}
