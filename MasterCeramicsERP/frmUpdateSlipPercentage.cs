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
    public partial class frmUpdateSlipPercentage : Form
    {
        List<SlipPercentage> listSP = new List<SlipPercentage>();
        //SlipPercentageDAL DALsp = new SlipPercentageDAL();
        //RawMaterialDAL DALrm = new RawMaterialDAL();
        int rows = -1,selectedRow=-1;

        public frmUpdateSlipPercentage()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }
        private void loadDataGrid()
        {
            try
            {
                SlipPercentageDAL DALsp = new SlipPercentageDAL();
                RawMaterialDAL DALrm = new RawMaterialDAL();

                //////////////////////////////////////////////////////////////////
                dgvSlipPercentage_updateSlip.Rows.Clear();
                rows = 0;
                selectedRow = -1;
                listSP = DALsp.getSlipPercentageOfSlipMaterial();
                listSP.TrimExcess();
                string RMname = null;
                for (int i = 0; i < listSP.Count; i++)
                {
                    RMname = DALrm.getMaterialName(listSP[i].RMID);
                    rows = dgvSlipPercentage_updateSlip.Rows.Add();
                    dgvSlipPercentage_updateSlip.Rows[rows].Cells[0].Value = listSP[i].RMID;
                    dgvSlipPercentage_updateSlip.Rows[rows].Cells[1].Value = RMname;
                    dgvSlipPercentage_updateSlip.Rows[rows].Cells[2].Value = listSP[i].SlipPercent;
                }
                /////////////////////////////////////////////////////////////////
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmUpdateSlipPercentage_Load(object sender, EventArgs e)
        {
            try
            {
                btnRefreshdatabase_updateSlip.Enabled = false;
                loadDataGrid();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_updateSlip_Click(object sender, EventArgs e)
        {
            try
            {
                SlipPercentageDAL DALsp = new SlipPercentageDAL();
                RawMaterialDAL DALrm = new RawMaterialDAL();

                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select raw material...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SlipPercentage sp = new SlipPercentage();
                    RawMaterialDAL DAlrm = new RawMaterialDAL();
                    sp.RMID = DALrm.getMaterialID(txtName.Text);
                    sp.SlipPercent = Convert.ToSingle(txtValue_updateSlip.Text);
                    DALsp.updateRMSlipPercentage(sp);
                    MessageBox.Show("Value has been update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtValue_updateSlip.Text = "";
                    btnRefreshdatabase_updateSlip.Enabled = true;
                    loadDataGrid();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshdatabase_updateSlip_Click(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void txtValue_updateSlip_MouseClick(object sender, MouseEventArgs e)
        {
            txtValue_updateSlip.Focus();
        }

        private void txtValue_updateSlip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';

            else if ((e.KeyChar < '0') || (e.KeyChar > '9') || e.KeyChar=='.')
            {
                if (e.KeyChar=='.')
                {
                    if (txtValue_updateSlip.Text.Contains("."))
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

        private void txtValue_updateSlip_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtValue_updateSlip.Focus();
        }

        private void dgvSlipPercentage_updateSlip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow != -1)
            {
                txtName.Text = dgvSlipPercentage_updateSlip.Rows[selectedRow].Cells[1].Value.ToString();
                txtValue_updateSlip.Text = dgvSlipPercentage_updateSlip.Rows[selectedRow].Cells[2].Value.ToString();
            }
        }    
    }
}
