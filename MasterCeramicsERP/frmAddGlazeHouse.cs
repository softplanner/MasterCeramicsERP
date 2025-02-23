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
    public partial class frmAddGlazeHouse : Form
    {
        //GlazeHouseDAL glazeHouseDAL = new GlazeHouseDAL();
        int selectedRow = -1,row=-1;
        public frmAddGlazeHouse()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                GlazeHouseDAL glazeHouseDAL = new GlazeHouseDAL();

                if (mtxtWeight.Text == "")
                {
                    MessageBox.Show("Enter glaze booth name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (glazeHouseDAL.checkIsGlazeHouseExist(mtxtWeight.Text).Equals(true))
                {
                    MessageBox.Show("Galze booth already exist... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    glazeHouseDAL.addGlazeHouse(mtxtWeight.Text);
                    MessageBox.Show("New galze booth has been added... ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populateGridView();
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
                GlazeHouseDAL glazeHouseDAL = new GlazeHouseDAL();

                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("Select galze booth", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (mtxtID.Text == "")
                {
                    MessageBox.Show("Select glaze booth...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (mtxtWeight.Text == "")
                {
                    MessageBox.Show("Enter name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (glazeHouseDAL.checkIsGlazeHouseExist(mtxtWeight.Text).Equals(true))
                {
                    MessageBox.Show("Galze booth already exist... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GlazeHouse b = new GlazeHouse();
                    b.ID = Convert.ToInt16(mtxtID.Text);
                    b.Name = mtxtWeight.Text;
                    glazeHouseDAL.updateGlazeHouse(b);
                    MessageBox.Show("Glaze booth has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populateGridView();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvBarmil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow != -1)
            {
                //------------------------
                mtxtID.Text = "";
                mtxtWeight.Text = "";
                mtxtID.Text = dgvBarmil.Rows[selectedRow].Cells[0].Value.ToString();
                mtxtWeight.Text = dgvBarmil.Rows[selectedRow].Cells[1].Value.ToString();
                //------------------------ 
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateGridView();
            mtxtID.Text = "";
            mtxtWeight.Text = "";
        }

        private void rbtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAdd.Checked.Equals(true))
            {
                mtxtID.Text = "";
                mtxtWeight.Text = "";
                mtxtWeight.Enabled = true;
                //------------------------
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                //------------------------
            }
        }

        private void rbtnUpdate_CheckedChanged(object sender, EventArgs e)
        {
            mtxtID.Text = "";
            mtxtWeight.Text = "";
            mtxtWeight.Enabled = true;
            //------------------------
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = true;
            //-----------------------
        }
       
        public void populateGridView()
        {
            try
            {
                GlazeHouseDAL glazeHouseDAL = new GlazeHouseDAL();

                selectedRow = -1;
                row = -1;
                dgvBarmil.Rows.Clear();
                List<GlazeHouse> lst = new List<GlazeHouse>();
                lst = glazeHouseDAL.getAllGlazeHouse();
                lst.TrimExcess();
                for (Int16 i = 0; i < lst.Count; i++)
                {
                    row = dgvBarmil.Rows.Add();
                    dgvBarmil.Rows[row].Cells[0].Value = lst[i].ID.ToString();
                    dgvBarmil.Rows[row].Cells[1].Value = lst[i].Name;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtxtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void frmAddGlazeHouse_Load(object sender, EventArgs e)
        {
            //------------------------
            rbtnAdd.Checked = true;
            mtxtID.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            //------------------------
            populateGridView();
        }

        private void rbtnDelete_CheckedChanged(object sender, EventArgs e)
        {
            mtxtID.Text = "";
            mtxtWeight.Text = "";
            mtxtWeight.Enabled = false;
            //------------------------
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = true;
            //-----------------------
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                GlazeHouseDAL glazeHouseDAL = new GlazeHouseDAL();

                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First select glaze booth", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //else if (mtxtWeight.Text == "")
                //{
                //    MessageBox.Show("Select Glaze House", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (glazeHouseDAL.checkIsGlazeHouseExistInDailyGlazingReport(Convert.ToInt16(mtxtID.Text)))
                //{
                //    MessageBox.Show("Selected glaze booth record present in daily glazing report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                else
                {
                    glazeHouseDAL.deleteGlazeHouse(Convert.ToInt16(mtxtID.Text));
                    MessageBox.Show("Selected glaze booth has been deleted ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populateGridView();
                    //---------------------------------
                    mtxtID.Text = "";
                    mtxtWeight.Text = "";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Due to dependencies can't delete this glaze booth...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtxtWeight_MouseClick(object sender, MouseEventArgs e)
        {
            mtxtWeight.Focus();
        }
    }
}
