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
    public partial class frmAddKillen : Form
    {
        //KillenDAL killenDAL = new KillenDAL();
        int selectedRow = -1, row = -1;
        public frmAddKillen()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                KillenDAL killenDAL = new KillenDAL();

                if (mtxtName.Text == "")
                {
                    MessageBox.Show("Enter killen name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (killenDAL.checkIsAlreadyExist(mtxtName.Text).Equals(true))
                {
                    MessageBox.Show("Killen already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    killenDAL.addKillen(mtxtName.Text);
                    MessageBox.Show("New killen has been added... ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                KillenDAL killenDAL = new KillenDAL();

                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First select killen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (mtxtID.Text == "")
                {
                    MessageBox.Show("Select killen...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (mtxtName.Text == "")
                {
                    MessageBox.Show("Enter name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (killenDAL.checkIsAlreadyExist(mtxtName.Text).Equals(true))
                {
                    MessageBox.Show("Killen already exist... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Killen b = new Killen();
                    b.ID = Convert.ToInt16(mtxtID.Text);
                    b.Name = mtxtName.Text;
                    killenDAL.updateKillen(b);
                    MessageBox.Show("Killen has been updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                mtxtName.Text = "";
                mtxtID.Text = dgvBarmil.Rows[selectedRow].Cells[0].Value.ToString();
                mtxtName.Text = dgvBarmil.Rows[selectedRow].Cells[1].Value.ToString();
                //------------------------ 
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateGridView();
            mtxtID.Text = "";
            mtxtName.Text = "";
        }

        private void rbtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAdd.Checked.Equals(true))
            {
                mtxtID.Text = "";
                mtxtName.Text = "";
                mtxtName.Enabled = true;
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
            mtxtName.Text = "";
            mtxtName.Enabled = true;
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
                KillenDAL killenDAL = new KillenDAL();

                selectedRow = -1;
                row = -1;
                dgvBarmil.Rows.Clear();
                List<Killen> lst = new List<Killen>();
                lst = killenDAL.getAllKillen();
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
            mtxtName.Text = "";
            mtxtName.Enabled = false;
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
                KillenDAL killenDAL = new KillenDAL();

                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First Select Killen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (mtxtID.Text == "")
                {
                    MessageBox.Show("Select Killen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (killenDAL.checkIsAlreadyExistInDailyKillenReport(Convert.ToInt16(mtxtID.Text)))
                {
                    MessageBox.Show("This Killen Record Present In Daily Killen Report", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (killenDAL.checkIsAlreadyExistInKillenFeed(Convert.ToInt16(mtxtID.Text)))
                {
                    MessageBox.Show("This Killen Record Present In Killen Feed Report", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    killenDAL.deleteKillen(Convert.ToInt16(mtxtID.Text));
                    MessageBox.Show("Killen Deleted ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populateGridView();
                    //---------------------------------
                    mtxtID.Text = "";
                    mtxtName.Text = "";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Due to dependencies can't delete this killen...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddKillen_Load(object sender, EventArgs e)
        {
            //------------------------
            rbtnAdd.Checked = true;
            mtxtID.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            //------------------------
            populateGridView();
        }

        private void mtxtName_MouseClick(object sender, MouseEventArgs e)
        {
            mtxtName.Focus();
        }
    }
}
