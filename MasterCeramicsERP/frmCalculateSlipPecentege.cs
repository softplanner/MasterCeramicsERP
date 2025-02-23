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
    public partial class frmCalculateSlipPecentege : Form
    {
        List<SlipPercentage> listSP = new List<SlipPercentage>();
        //SlipPercentageDAL DALsp = new SlipPercentageDAL();
        //RawMaterialDAL DALrm = new RawMaterialDAL();

        int selectedRow = -1;
      
        public frmCalculateSlipPecentege()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSlipPercentageInfo.Rows.Clear();
                if (txtBarmilWeight.Text == "")
                {
                    MessageBox.Show("Enter ballmill weight...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SlipPercentageDAL DALsp = new SlipPercentageDAL();
                    RawMaterialDAL DALrm = new RawMaterialDAL();

                    listSP = DALsp.getSlipPercentageOfSlipMaterial();
                    listSP.TrimExcess();
                    for (int i = 0; i < listSP.Count; i++)
                    {
                        dgvSlipPercentageInfo.Rows.Add();
                        dgvSlipPercentageInfo.Rows[i].Cells[0].Value = listSP[i].RMID;
                        dgvSlipPercentageInfo.Rows[i].Cells[1].Value = DALrm.getMaterialName(listSP[i].RMID);
                        dgvSlipPercentageInfo.Rows[i].Cells[2].Value = Convert.ToInt32(txtBarmilWeight.Text) * listSP[i].SlipPercent;
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }

        private void txtBarmilWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtBarmilWeight_MouseClick(object sender, MouseEventArgs e)
        {
            txtBarmilWeight.Focus();
        }
   }
}
