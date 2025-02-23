using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MCERP.DAL;
using MCERP.Entities;

namespace MasterCeramicsERP
{
    public partial class frmSlipPercentageInfo : Form
    {
        List<SlipPercentage> listSP = new List<SlipPercentage>();

        //SlipPercentageDAL DALsp = new SlipPercentageDAL();
        //RawMaterialDAL DALrm = new RawMaterialDAL();

        public frmSlipPercentageInfo()
        {
            InitializeComponent();
        }

        private void frmSlipPercentageInfo_Load(object sender, EventArgs e)
        {
            try
            {
                SlipPercentageDAL DALsp = new SlipPercentageDAL();
                RawMaterialDAL DALrm = new RawMaterialDAL();

                dgvSlipPercentageInfo.ForeColor = Color.SaddleBrown;
                dgvSlipPercentageInfo.Rows.Clear();
                listSP = DALsp.getSlipPercentageOfSlipMaterial();
                listSP.TrimExcess();
                for (int i = 0; i < listSP.Count; i++)
                {
                    dgvSlipPercentageInfo.Rows.Add();
                    dgvSlipPercentageInfo.Rows[i].Cells[0].Value = listSP[i].RMID;
                    dgvSlipPercentageInfo.Rows[i].Cells[1].Value = DALrm.getMaterialName(listSP[i].RMID);
                    //dgvSlipPercentageInfo.Rows[i].Cells[2].Value = 100 * listSP[i].SlipPercent;
                    dgvSlipPercentageInfo.Rows[i].Cells[2].Value = listSP[i].SlipPercent;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}