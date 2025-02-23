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
    public partial class frmAddBarmil : Form
    {
        //BarmilDAL barmildal = new BarmilDAL();
        List<Barmil> lst = new List<Barmil>();
        int selectedRow = -1,row=-1;
        public frmAddBarmil()
        {
            InitializeComponent();
        }

        private void frmAddBarmil_Load(object sender, EventArgs e)
        {
            //------------------------
            rbtnAdd.Checked = true;
            mtxtID.Enabled = false;
            btnDelete.Enabled = false;
            //------------------------
            populateGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (mtxtWeight.Text == "")
            {
                MessageBox.Show("Enter ballmill weight ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                try
                {
                    BarmilDAL barmildal = new BarmilDAL();
                    barmildal.addBarmil(Convert.ToInt16(mtxtWeight.Text));
                    BarmilLoadInfoDAL dal = new BarmilLoadInfoDAL();
                    populateGridView();
                    dal.addNewAsOffStatus(lst[row].ID, "OFF");
                    MessageBox.Show("New ballmill has been added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BarmilLoadInfoDAL dal = new BarmilLoadInfoDAL();
                    if (selectedRow.Equals(-1))
                    {
                        MessageBox.Show("Select ballmill ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else if (dal.checkBarmil(Convert.ToInt16(mtxtID.Text)).Equals(1))
                    {
                        if (dal.getBarmilStatusByBarmilID(Convert.ToInt16(mtxtID.Text)).Equals("ON"))
                        {
                            MessageBox.Show("Can't delete ...first unload ballmill", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (MessageBox.Show("Are you sure you want to delete this ballmill ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                dal.deleteBallMillRecord(Convert.ToInt16(mtxtID.Text));
                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to delete this ballmill ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            BarmilDAL barmildal = new BarmilDAL();
                            barmildal.deleteBarmil(Convert.ToInt16(mtxtID.Text));
                            MessageBox.Show("Selected ballmill deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            populateGridView();
                            //---------------------------------
                            mtxtID.Text = "";
                            mtxtWeight.Text = "";
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //-----------------------
        }

        private void rbtnDelete_CheckedChanged(object sender, EventArgs e)
        {
            mtxtID.Text = "";
            mtxtWeight.Text = "";
            mtxtWeight.Enabled = false;
            //------------------------
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            //-----------------------
        }
        public void populateGridView() 
        {
            try
            {
                BarmilDAL barmildal = new BarmilDAL();
                selectedRow = -1;
                row = -1;
                dgvBarmil.Rows.Clear();
                lst.Clear();
                lst = barmildal.getAllBarmilList();
                lst.TrimExcess();
                for (Int16 i = 0; i < lst.Count; i++)
                {
                    row = dgvBarmil.Rows.Add();
                    dgvBarmil.Rows[row].Cells[0].Value = lst[i].ID.ToString();
                    dgvBarmil.Rows[row].Cells[1].Value = lst[i].Weight;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtxtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.KeyChar = '\b';
            else if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void mtxtWeight_MouseClick(object sender, MouseEventArgs e)
        {
            mtxtWeight.Focus();
        }
    }
}
