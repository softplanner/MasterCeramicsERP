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
    public partial class frmAddNewUser : Form
    {
        //UserDAL userDAL = new UserDAL();
        List<User> lst;
        int selectedRow=-1;
        public frmAddNewUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                UserDAL userDAL = new UserDAL();

                if (txtName.Text == "")
                {
                    MessageBox.Show("Enter username...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Enter password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtRetypePassword.Text == "")
                {
                    MessageBox.Show("Re-Type password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text != txtRetypePassword.Text)
                {
                    MessageBox.Show("Password does not match...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (userDAL.IsAlreadyExist(txtName.Text).Equals(true))
                {
                    MessageBox.Show("User already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    User u = new User();
                    u.UserType = cbxUserType.Text;
                    u.UserName = txtName.Text;
                    u.Password = txtPassword.Text;
                    userDAL.addUser(u);
                    MessageBox.Show("New user has been added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populateGridView();
                    emptyTextFeilds();
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
                UserDAL userDAL = new UserDAL();

                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First select user...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                //else if (txtName.Text == "admin")
                //{
                //    MessageBox.Show("Cannot Change Password Of The Master User,Due To The Default Administration Rights", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Enter password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtRetypePassword.Text == "")
                {
                    MessageBox.Show("Re-Type password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text != txtRetypePassword.Text)
                {
                    MessageBox.Show("Password does not match...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    userDAL.updateUser(txtName.Text, txtPassword.Text);
                    MessageBox.Show("Password has been changed successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populateGridView();
                    emptyTextFeilds();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateGridView();
            emptyTextFeilds();
        }
        private void emptyTextFeilds()
        {
            try
            {
                txtName.Text = "";
                txtUserType.Text = "";
                txtPassword.Text = "";
                txtRetypePassword.Text = "";
                lblStrength1.ForeColor = Color.Transparent;
                lblStrength2.ForeColor = Color.Transparent;
                lblStrength3.ForeColor = Color.Transparent;
                lblStrength4.ForeColor = Color.Transparent;
                lblStrength5.ForeColor = Color.Transparent;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void removeColorFromPasswordSrength()
        {
            try
            {
                lblStrength1.ForeColor = Color.Gray;
                lblStrength2.ForeColor = Color.Gray;
                lblStrength3.ForeColor = Color.Gray;
                lblStrength4.ForeColor = Color.Gray;
                lblStrength5.ForeColor = Color.Gray;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void rbtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnAdd.Checked.Equals(true))
                {
                    emptyTextFeilds();
                    removeColorFromPasswordSrength();
                    lblName.Enabled = true;
                    txtName.Enabled = true;
                    lblRetypePassword.Enabled = true;
                    txtRetypePassword.Enabled = true;
                    lblPassword.Enabled = true;
                    txtPassword.Enabled = true;
                    //------------------------
                    btnAdd.Enabled = true;
                    btnchangePassword.Enabled = false;
                    btnDelete.Enabled = false;
                    //------------------------
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtnUpdate_CheckedChanged(object sender, EventArgs e)
        {
            emptyTextFeilds();
            removeColorFromPasswordSrength();
            lblName.Enabled = false;
            txtName.Enabled = false;
            lblRetypePassword.Enabled = true;
            txtRetypePassword.Enabled = true;
            lblPassword.Enabled = true;
            txtPassword.Enabled = true;
            //------------------------
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnchangePassword.Enabled = true;
            //-----------------------
        }

        public void populateGridView()
        {
            try
            {
                UserDAL userDAL = new UserDAL();

                selectedRow = -1;
                dgvUser.Rows.Clear();
                if (cbxUserType.Text != "")
                {
                    lst = new List<User>();
                    lst = userDAL.getAllUserByType(cbxUserType.Text);
                    lst.TrimExcess();
                    if (lst.Count.Equals(0))
                    {
                        // do nothing.....
                    }
                    else
                    {
                        for (Int16 i = 0; i < lst.Count; i++)
                        {
                            dgvUser.Rows.Add();
                            dgvUser.Rows[i].Cells[0].Value = lst[i].UserName;
                            dgvUser.Rows[i].Cells[1].Value = lst[i].Password;
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtnDelete_CheckedChanged(object sender, EventArgs e)
        {
            emptyTextFeilds();
            removeColorFromPasswordSrength();
            lblName.Enabled = false;
            txtName.Enabled = false;
            lblRetypePassword.Enabled = false;
            txtRetypePassword.Enabled = false;
            lblPassword.Enabled = false;
            txtPassword.Enabled = false;
            //------------------------
            btnAdd.Enabled = false;
            btnchangePassword.Enabled = false;
            btnDelete.Enabled = true;
            //-----------------------
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow.Equals(-1))
                {
                    MessageBox.Show("First select user...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtName.Text.Equals("Admin"))
                {
                    MessageBox.Show("Cannot delete that user, because this user is default administrator..... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UserDAL userDAL = new UserDAL();

                    userDAL.deleteUser(txtName.Text);
                    MessageBox.Show("User has been deleted Successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    emptyTextFeilds();
                    populateGridView();
                    //---------------------------------
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBarmil_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow=e.RowIndex;
            if(selectedRow!=-1)
            {
                populateTextFeilds();
            }
        }
        private void populateTextFeilds()
        {
            txtUserType.Text = cbxUserType.Text;
            txtName.Text = dgvUser.Rows[selectedRow].Cells[0].Value.ToString();
            txtPassword.Text = dgvUser.Rows[selectedRow].Cells[1].Value.ToString();
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            try
            {
                UserDAL userDAL = new UserDAL();

                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnchangePassword.Enabled = false;
                //=============================
                lblUserType.Enabled = false;
                txtUserType.Enabled = false;
                if (userDAL.checkUserExistByType("Administrator").Equals(true))
                {

                    populateGridView();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxUserType_SelectionChangeCommitted(object sender, EventArgs e)
        {
                populateGridView();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPassword.Text.Length.Equals(1))
                lblStrength1.ForeColor = Color.Orange;
            else if (txtPassword.Text.Length.Equals(3))
                lblStrength2.ForeColor = Color.Orange;
            else if (txtPassword.Text.Length.Equals(5))
                lblStrength3.ForeColor = Color.Orange;
            else if (txtPassword.Text.Length.Equals(7))
                lblStrength4.ForeColor = Color.Orange;
            else if (txtPassword.Text.Length.Equals(9))
                lblStrength5.ForeColor = Color.Orange;
            else if (txtPassword.Text.Length < 9 && txtPassword.Text.Length > 7)
            {
                lblStrength5.ForeColor = Color.Gray;
            }
            else if (txtPassword.Text.Length < 7 && txtPassword.Text.Length > 5)
            {
                lblStrength4.ForeColor = Color.Gray;
            }
            else if (txtPassword.Text.Length < 5 && txtPassword.Text.Length > 3)
            {
                lblStrength3.ForeColor = Color.Gray;
            }
            else if (txtPassword.Text.Length < 3 && txtPassword.Text.Length > 1)
            {
                lblStrength2.ForeColor = Color.Gray;
            }
            else if (txtPassword.Text.Length == 0)
            {
                lblStrength1.ForeColor = Color.Gray;
            }
        }
        private void txtRetypePassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtRetypePassword.Focus();
        }

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Focus();
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Focus();
        }
    }
}
