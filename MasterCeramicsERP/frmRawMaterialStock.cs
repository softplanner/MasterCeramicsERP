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
    public partial class frmRawMaterialStock : Form
    {
        List<RawMaterialStock> list;
        frmMain main=new frmMain();
        int selectedRow = -1;

        public frmRawMaterialStock()
        {
            InitializeComponent();
        }

        private void frmRawMaterialStock_Load(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            lblName.Enabled = false;
            mtxtName.Enabled = false;
            populateDataGrid();
        }
        private void populateDataGrid()
        {
            try
            {
                RawMaterialDAL rawMaterialDAL = new RawMaterialDAL();
                RawMaterialStockDAL stockDAL = new RawMaterialStockDAL();

                dgvRawMaterialStock.Rows.Clear();
                selectedRow = -1;
                list = stockDAL.getStockList();
                if (list.Count.Equals(0))
                {
                    MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    list.TrimExcess();
                    for (Int16 i = 0; i < list.Count; i++)
                    {
                        dgvRawMaterialStock.Rows.Add();
                        dgvRawMaterialStock.Rows[i].Cells[0].Value = list[i].RMID.ToString();
                        dgvRawMaterialStock.Rows[i].Cells[1].Value = rawMaterialDAL.getMaterialName(list[i].RMID);
                        dgvRawMaterialStock.Rows[i].Cells[2].Value = list[i].Quantity.ToString();
                        dgvRawMaterialStock.Rows[i].Cells[3].Value = list[i].AlarmAmount.ToString();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRawMaterialStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow != -1)
            {
                mtxtName.Text = dgvRawMaterialStock.Rows[selectedRow].Cells[1].Value.ToString();
                mtxtQuantity.Text = dgvRawMaterialStock.Rows[selectedRow].Cells[2].Value.ToString();
                mtxtAlarmQuantity.Text = dgvRawMaterialStock.Rows[selectedRow].Cells[3].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            mtxtAlarmQuantity.Text = "";
            mtxtName.Text = "";
            mtxtQuantity.Text = "";
            populateDataGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RawMaterialStockDAL stockDAL = new RawMaterialStockDAL();

                    if (mtxtAlarmQuantity.Text.Equals("") || mtxtName.Text.Equals("") || mtxtAlarmQuantity.Text.Equals(""))
                    {
                        MessageBox.Show("Fill the text fields...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (rbtnAdd.Checked.Equals(false) && rbtnDeduct.Checked.Equals(false) && rbtnUpdate.Checked.Equals(false))
                    {
                        MessageBox.Show("Select some critaria...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (selectedRow.Equals(-1))
                    {
                        MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (rbtnAdd.Checked.Equals(true))
                    {
                        if (MessageBox.Show("Are you sure you want to add in raw material quantity ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            RawMaterialStock r = new RawMaterialStock();
                            r.RMID = Convert.ToInt16(dgvRawMaterialStock.Rows[selectedRow].Cells[0].Value.ToString());
                            r.Quantity = stockDAL.getStock(r.RMID) + Convert.ToSingle(mtxtQuantity.Text);
                            r.AlarmAmount = Convert.ToSingle(mtxtAlarmQuantity.Text);
                            stockDAL.updateStock(r.RMID, r.Quantity);
                            //stockDAL.updateAlarmAmount(r.RMID, r.AlarmAmount);
                        }
                    }
                    else if (rbtnDeduct.Checked.Equals(true))
                    {
                        if (MessageBox.Show("Are you sure you want to deduct raw material ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            RawMaterialStock r = new RawMaterialStock();
                            r.RMID = Convert.ToInt16(dgvRawMaterialStock.Rows[selectedRow].Cells[0].Value.ToString());
                            r.Quantity = stockDAL.getStock(r.RMID) - Convert.ToSingle(mtxtQuantity.Text);
                            r.AlarmAmount = Convert.ToSingle(mtxtAlarmQuantity.Text);
                            stockDAL.updateStock(r.RMID, r.Quantity);
                            //stockDAL.updateAlarmAmount(r.RMID, r.AlarmAmount);
                        }
                    }
                    else if (rbtnUpdate.Checked.Equals(true))
                    {
                        if (MessageBox.Show("Are you sure you want to update raw material quantity and alarm amount ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            RawMaterialStock r = new RawMaterialStock();
                            r.RMID = Convert.ToInt16(dgvRawMaterialStock.Rows[selectedRow].Cells[0].Value.ToString());
                            r.Quantity = Convert.ToSingle(mtxtQuantity.Text);
                            r.AlarmAmount = Convert.ToSingle(mtxtAlarmQuantity.Text);
                            stockDAL.updateStock(r.RMID, r.Quantity);
                            stockDAL.updateAlarmAmount(r.RMID, r.AlarmAmount);
                        }
                    }
                    populateDataGrid();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtnUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnUpdate.Checked.Equals(true))
            {
                mtxtName.Enabled = true;
                lblName.Enabled = true;
            }
            else if(rbtnUpdate.Checked.Equals(false))
            {
                mtxtName.Enabled = false;
                lblName.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //RawMaterialStockDAL stockDAL = new RawMaterialStockDAL();
                
                //if (selectedRow.Equals(-1))
                //{
                //    MessageBox.Show("Select raw material...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else if (stockDAL.getStock(Convert.ToInt16(dgvRawMaterialStock.Rows[selectedRow].Cells[0].Value.ToString())) > 0)
                //{
                //    MessageBox.Show("Available in stock...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                //{
                //    Int16 rmid = Convert.ToInt16(dgvRawMaterialStock.Rows[selectedRow].Cells[0].Value.ToString());
                //    RawMaterialDAL rmdal = new RawMaterialDAL();
                //    SlipPercentageDAL spdal = new SlipPercentageDAL();
                //    if (spdal.isMaterialExist(rmid).Equals(true))
                //    {
                //        MessageBox.Show("Raw material added as slip material...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //    else
                //    {
                //        rmdal.deleteRawMaterial(rmid);
                //        stockDAL.deleteStock(rmid);
                //        MessageBox.Show("Raw material has been deleted from stock and raw material list...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //}
                //populateDataGrid();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';

            else if ((e.KeyChar < '0') || (e.KeyChar > '9') || e.KeyChar == '.')
            {
                if (e.KeyChar == '.')
                {
                    if (mtxtQuantity.Text.Contains("."))
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

        private void mtxtAlarmQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';

            else if ((e.KeyChar < '0') || (e.KeyChar > '9') || e.KeyChar == '.')
            {
                if (e.KeyChar == '.')
                {
                    if (mtxtAlarmQuantity.Text.Contains("."))
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

        private void mtxtQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            mtxtQuantity.Focus();
        }

        private void mtxtAlarmQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            mtxtAlarmQuantity.Focus();
        }

        private void txtUpdateQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';

            else if ((e.KeyChar < '0') || (e.KeyChar > '9') || e.KeyChar == '.')
            {
                if (e.KeyChar == '.')
                {
                    if (mtxtQuantity.Text.Contains("."))
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
    }
}
