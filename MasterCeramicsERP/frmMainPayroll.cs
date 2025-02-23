using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MCERP.DAL;

namespace MasterCeramicsERP
{
    public partial class frmMainPayroll : Form
    {
        UserDAL userDAL = new UserDAL();
        string userType = null, userName = null;
        int check = 0;

        public frmMainPayroll()
        {
            InitializeComponent();
        }
        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            lblExit.Visible = false;
            pbxExit.Visible = true;
        }
        private void pbxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxExit_MouseLeave(object sender, EventArgs e)
        {
            pbxExit.Visible = false;
            lblExit.Visible = true;
        }

        private void lblLoginMain_MouseEnter(object sender, EventArgs e)
        {
            lblLoginMain.Visible = false;
            pbxLoginMain.Visible = true;
        }

        private void pbxLoginMain_MouseLeave(object sender, EventArgs e)
        {
            pbxLoginMain.Visible = false;
            lblLoginMain.Visible = true;
            if (check.Equals(1))
            {
                lblLoginMain.Visible = false;
            }
        }
        private void frmMainPayroll_Load(object sender, EventArgs e)
        {
            pbxLoginMain.Visible = false;
            pbxExit.Visible = false;
            pnlMainMenu.Enabled = false;
            lblLoginUserName.Visible = false;
            //=====login work
            lblLogout.Visible = false;
            pbxLogout.Visible = false;
            //=====end login work
            InvisibleLabel();
            emptyLabelsText();
            this.pnlFormsMenu.AutoScroll = true;
            this.ResumeLayout(false);
        }
        //login work defination=====================================================
        //=====visible login menu
        private void showLoginCompponents()
        {
            txtName.Visible = true;
            lblName.Visible = true;
            txtPassword.Visible = true;
            lblPassword.Visible = true;
        }
        //=====Invisible login menu
        private void HideLoginCompponents()
        {
            txtName.Visible = false;
            lblName.Visible = false;
            txtPassword.Visible = false;
            lblPassword.Visible = false;
        }
        //====end invisible login
        private void pbxLogout_Click(object sender, EventArgs e)
        {
            check = 0;
            lblExit.Visible = true;
            lblLoginMain.Visible = true;
            //====disable login name
            lblLoginUserName.Visible = false;
            lblLoginUserName.Text = "";
            //login name end
            pnlMainMenu.BackColor = Color.Transparent;
            InvisibleLabel();
            showLoginCompponents();
            pnlFormsMenu.Enabled = false;
            pnlMainMenu.Enabled = false;
            txtName.Text = "";
            txtPassword.Text = "";
            lblLogout.Visible = false;
            pbxLogout.Visible = false;
            lblCompanyName.ForeColor = Color.Transparent;
            lblCompanyNames.ForeColor = Color.Transparent;
            lblSlogan.ForeColor = Color.Transparent;
            lblSlogans.ForeColor = Color.Transparent;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ////-----update counter()
                //userDAL.updateCounter();
                ////-----end
                //if (userDAL.checkSecurity().Equals(false))
                //{
                    if (txtName.Text.Equals(""))
                    {
                        MessageBox.Show("Enter username...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else if (txtPassword.Text.Equals(""))
                    {
                        MessageBox.Show("Enter password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                    else
                    {
                        if (txtPassword.Text.Equals(userDAL.getPassword(txtName.Text)))
                        {
                            check = 1;
                            lblExit.Visible = false;
                            userName = txtName.Text;
                            userType = userDAL.getUserType(userName);
                            //=====login user name show
                            lblLoginUserName.Visible = true;
                            lblLoginUserName.Text = txtName.Text;
                            //end login name show
                            HideLoginCompponents();
                            pnlFormsMenu.Enabled = true;
                            pnlMainMenu.Enabled = true;
                            lblLogout.Visible = true;
                            pbxLogout.Visible = true;
                            lblSlogan.ForeColor = Color.Red;
                            lblSlogans.ForeColor = Color.Red;
                            lblCompanyName.ForeColor = Color.Red;
                            lblCompanyNames.ForeColor = Color.Red;
                        }
                        else
                        {
                            MessageBox.Show("Enter correct username/password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            txtPassword.Text = "";
                            //lblLoginMain.Visible = true;
                            pbxLoginMain.Visible = true;
                        }
                    }
                //}
                //else
                //{
                //    this.Close();
                //}
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //end login work defination====================================================================
        private void visibleLabel()
        {
            lblHeading.Visible = true;
            linkLabel1.Visible = true;
            linkLabel2.Visible = true;
            linkLabel3.Visible = true;
            linkLabel4.Visible = true;
            linkLabel5.Visible = true;
            linkLabel6.Visible = true;
            linkLabel7.Visible = true;
            linkLabel8.Visible = true;
        }
        private void InvisibleLabel()
        {
            lblHeading.Visible = false;
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
            linkLabel4.Visible = false;
            linkLabel5.Visible = false;
            linkLabel6.Visible = false;
            linkLabel7.Visible = false;
            linkLabel8.Visible = false;
        }
        private void emptyLabelsText()
        {
            lblHeading.Text = "";
            linkLabel1.Text = "";
            linkLabel2.Text = "";
            linkLabel3.Text = "";
            linkLabel4.Text = "";
            linkLabel5.Text = "";
            linkLabel6.Text = "";
            linkLabel7.Text = "";
            linkLabel8.Text = "";
        }

        private void pbxBarmilSection_MouseEnter(object sender, EventArgs e)
        {
            pbxBarmilSection.Location = new Point(188, 7);
            pbxBarmilSection.Size = new Size(83, 51);
        }

        private void pbxBarmilSection_MouseLeave(object sender, EventArgs e)
        {
            pbxBarmilSection.Location = new Point(198, 22);
            pbxBarmilSection.Size = new Size(54, 29);
        }

        private void pbxGreenWare_MouseEnter(object sender, EventArgs e)
        {
            pbxGreenWare.Location = new Point(279, 7);
            pbxGreenWare.Size = new Size(83, 51);
        }

        private void pbxGreenWare_MouseLeave(object sender, EventArgs e)
        {
            pbxGreenWare.Location = new Point(289, 22);
            pbxGreenWare.Size = new Size(54, 29);
        }

        private void pbxOilInspection_MouseEnter(object sender, EventArgs e)
        {
            pbxOilInspection.Location = new Point(370, 7);
            pbxOilInspection.Size = new Size(83, 51);
        }

        private void pbxOilInspection_MouseLeave(object sender, EventArgs e)
        {
            pbxOilInspection.Location = new Point(380, 22);
            pbxOilInspection.Size = new Size(54, 29);
        }

        private void pbxGlazeHouse_MouseEnter(object sender, EventArgs e)
        {
            pbxGlazeHouse.Location = new Point(461, 7);
            pbxGlazeHouse.Size = new Size(83, 51);
        }

        private void pbxGlazeHouse_MouseLeave(object sender, EventArgs e)
        {
            pbxGlazeHouse.Location = new Point(471, 22);
            pbxGlazeHouse.Size = new Size(54, 29);
        }

        private void pbxKillenReport_MouseEnter(object sender, EventArgs e)
        {
            pbxKillenReport.Location = new Point(549, 7);
            pbxKillenReport.Size = new Size(83, 51);
        }

        private void pbxKillenReport_MouseLeave(object sender, EventArgs e)
        {
            pbxKillenReport.Location = new Point(559, 22);
            pbxKillenReport.Size = new Size(54, 29);
        }
        private void pbxBarmilSection_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.Maroon;
            linkLabel2.LinkColor = Color.Maroon;
            lblSlogans.ForeColor = Color.Maroon;
            lblSlogan.ForeColor = Color.Maroon;
            lblHeading.ForeColor = Color.Maroon;
            pnlMainMenu.BackColor = Color.Maroon;
            lblCompanyName.ForeColor = Color.Maroon;
            lblCompanyNames.ForeColor = Color.Maroon;
            //====================================================
            lblHeading.Text = "Attendence";
            linkLabel1.Text = "Mark Attendance";
            linkLabel2.Text = "View Attendance Record";
        }
        private void pbxGreenWare_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = SystemColors.ActiveCaptionText;
            linkLabel2.LinkColor = SystemColors.ActiveCaptionText;
            linkLabel3.LinkColor = SystemColors.ActiveCaptionText;
            lblSlogans.ForeColor = SystemColors.ActiveCaptionText;
            lblSlogan.ForeColor = SystemColors.ActiveCaptionText;
            lblHeading.ForeColor = SystemColors.ActiveCaptionText;
            pnlMainMenu.BackColor = SystemColors.ActiveCaptionText;
            lblCompanyName.ForeColor = SystemColors.ActiveCaptionText;
            lblCompanyNames.ForeColor = SystemColors.ActiveCaptionText;
            //====================================================
            lblHeading.Text = "Worker Loan";
            linkLabel1.Text = "Manage Worker Loan";
            linkLabel2.Text = "Update Loan Report";
            linkLabel3.Text = "Change Loan Amount";
        }

        private void pbxOilInspection_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.SaddleBrown;
            linkLabel2.LinkColor = Color.SaddleBrown;
            linkLabel3.LinkColor = Color.SaddleBrown;
            lblSlogans.ForeColor = Color.SaddleBrown;
            lblSlogan.ForeColor = Color.SaddleBrown;
            lblHeading.ForeColor = Color.SaddleBrown;
            pnlMainMenu.BackColor = Color.SaddleBrown;
            lblCompanyName.ForeColor = Color.SaddleBrown;
            lblCompanyNames.ForeColor = Color.SaddleBrown;
            //====================================================
            lblHeading.Text = "Caster Payment";
            linkLabel1.Text = "Add Payment Report";
            linkLabel2.Text = "View Payment Report";
            linkLabel3.Text = "Item Casting Rate";
        }

        private void pbxGlazeHouse_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = SystemColors.ControlDarkDark;
            linkLabel2.LinkColor = SystemColors.ControlDarkDark;
            lblSlogans.ForeColor = SystemColors.ControlDarkDark;
            lblSlogan.ForeColor = SystemColors.ControlDarkDark;
            lblHeading.ForeColor = SystemColors.ControlDarkDark;
            pnlMainMenu.BackColor = SystemColors.ControlDarkDark;
            lblCompanyName.ForeColor = SystemColors.ControlDarkDark;
            lblCompanyNames.ForeColor = SystemColors.ControlDarkDark;
            //====================================================
            lblHeading.Text = "Daily Wages";
            linkLabel1.Text = "Add Wages Report";
            linkLabel2.Text = "View Wages Report";
        }

        private void pbxKillenReport_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.DarkSlateGray;
            linkLabel2.LinkColor = Color.DarkSlateGray;
            lblSlogans.ForeColor = Color.DarkSlateGray;
            lblSlogan.ForeColor = Color.DarkSlateGray;
            lblHeading.ForeColor = Color.DarkSlateGray;
            pnlMainMenu.BackColor = Color.DarkSlateGray;
            lblCompanyName.ForeColor = Color.DarkSlateGray;
            lblCompanyNames.ForeColor = Color.DarkSlateGray;
            //====================================================
            lblHeading.Text = "Monthly Salary";
            linkLabel1.Text = "Add Salary Report";
            linkLabel2.Text = "View Salary Report";
        }

        private void pbxLogout_MouseEnter(object sender, EventArgs e)
        {
            pbxLogout.Location = new Point(101, 440);
            pbxLogout.Size = new Size(60, 47);
        }

        private void pbxLogout_MouseLeave(object sender, EventArgs e)
        {
            pbxLogout.Location = new Point(107, 440);
            pbxLogout.Size = new Size(50, 43);
        }
        //=====font family work here
        FontFamily fontFamily;
        FontStyle fontStyle;

        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            fontFamily = linkLabel1.Font.FontFamily;
            fontStyle = linkLabel1.Font.Style;
            linkLabel1.Font = new Font(fontFamily, 10, fontStyle);
        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.Font = new Font(fontFamily, 8, fontStyle);
        }

        private void linkLabel2_MouseEnter(object sender, EventArgs e)
        {
            fontFamily = linkLabel2.Font.FontFamily;
            fontStyle = linkLabel2.Font.Style;
            linkLabel2.Font = new Font(fontFamily, 10, fontStyle);
        }
        private void linkLabel3_MouseEnter(object sender, EventArgs e)
        {
            fontFamily = linkLabel3.Font.FontFamily;
            fontStyle = linkLabel3.Font.Style;
            linkLabel3.Font = new Font(fontFamily, 10, fontStyle);
        }

        private void linkLabel3_MouseLeave(object sender, EventArgs e)
        {
            linkLabel3.Font = new Font(fontFamily, 8, fontStyle);
        }
        private void linkLabel4_MouseEnter(object sender, EventArgs e)
        {
            fontFamily = linkLabel4.Font.FontFamily;
            fontStyle = linkLabel4.Font.Style;
            linkLabel4.Font = new Font(fontFamily, 10, fontStyle);
        }

        private void linkLabel4_MouseLeave(object sender, EventArgs e)
        {
            linkLabel4.Font = new Font(fontFamily, 8, fontStyle);
        }

        private void linkLabel5_MouseEnter(object sender, EventArgs e)
        {
            fontFamily = linkLabel5.Font.FontFamily;
            fontStyle = linkLabel5.Font.Style;
            linkLabel5.Font = new Font(fontFamily, 10, fontStyle);
        }

        private void linkLabel5_MouseLeave(object sender, EventArgs e)
        {
            linkLabel5.Font = new Font(fontFamily, 8, fontStyle);
        }

        private void linkLabel6_MouseEnter(object sender, EventArgs e)
        {
            fontFamily = linkLabel6.Font.FontFamily;
            fontStyle = linkLabel6.Font.Style;
            linkLabel6.Font = new Font(fontFamily, 10, fontStyle);
        }

        private void linkLabel6_MouseLeave(object sender, EventArgs e)
        {
            linkLabel6.Font = new Font(fontFamily, 8, fontStyle);
        }

        private void linkLabel7_MouseEnter(object sender, EventArgs e)
        {
            fontFamily = linkLabel7.Font.FontFamily;
            fontStyle = linkLabel7.Font.Style;
            linkLabel7.Font = new Font(fontFamily, 10, fontStyle);
        }
        private void linkLabel7_MouseLeave(object sender, EventArgs e)
        {
            linkLabel7.Font = new Font(fontFamily, 8, fontStyle);
        }
        private void linkLabel8_MouseEnter(object sender, EventArgs e)
        {
            fontFamily = linkLabel8.Font.FontFamily;
            fontStyle = linkLabel8.Font.Style;
            linkLabel8.Font = new Font(fontFamily, 10, fontStyle);
        }

        private void linkLabel8_MouseLeave(object sender, EventArgs e)
        {
            linkLabel8.Font = new Font(fontFamily, 8, fontStyle);
        }
        private void linkLabel2_MouseLeave(object sender, EventArgs e)
        {
            linkLabel2.Font = new Font(fontFamily, 8, fontStyle);
        }
        //=====objects used by first label option in sub menu
        frmMarkAttendence markAttendence;
        frmWorkerLoan workerLoan;
        frmCasterPayment casterPayment;
        frmDailyWages dailyWages;
        frmMonthlySalary monthlySalary;
        frmAddNewPerson addNewPerson;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (linkLabel1.Text.Equals("Add New User"))
                {
                    if (!pnlFormsMenu.Contains(addNewUser))
                    {
                        addNewUser = new frmAddNewUser();
                        addNewUser.TopLevel = false;
                        addNewUser.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(addNewUser);
                        addNewUser.Show();
                        addNewUser.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel1.Text.Equals("Mark Attendance"))
                {
                    if (!pnlFormsMenu.Contains(markAttendence))
                    {
                        markAttendence = new frmMarkAttendence();
                        markAttendence.TopLevel = false;
                        markAttendence.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(markAttendence);
                        markAttendence.Show();
                        markAttendence.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel1.Text.Equals("Add New Person"))
                {
                    if (!pnlFormsMenu.Contains(addNewPerson))
                    {
                        addNewPerson = new frmAddNewPerson();
                        addNewPerson.TopLevel = false;
                        addNewPerson.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(addNewPerson);
                        addNewPerson.Show();
                        addNewPerson.BringToFront();
                        //addNewPerson.Focus=true;
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel1.Text.Equals("Manage Worker Loan"))
                {
                    if (!pnlFormsMenu.Contains(workerLoan))
                    {
                        workerLoan = new frmWorkerLoan();
                        workerLoan.TopLevel = false;
                        workerLoan.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(workerLoan);
                        workerLoan.Show();
                        workerLoan.BringToFront();
                        //addNewPerson.Focus=true;
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel1.Text.Equals("Add Payment Report"))
                {
                    if (!pnlFormsMenu.Contains(casterPayment))
                    {
                        casterPayment = new frmCasterPayment();
                        casterPayment.TopLevel = false;
                        casterPayment.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(casterPayment);
                        casterPayment.Show();
                        casterPayment.BringToFront();
                        //addNewPerson.Focus=true;
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel1.Text.Equals("Add Wages Report"))
                {
                    if (!pnlFormsMenu.Contains(dailyWages))
                    {
                        dailyWages = new frmDailyWages();
                        dailyWages.TopLevel = false;
                        dailyWages.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(dailyWages);
                        dailyWages.Show();
                        dailyWages.BringToFront();
                        //addNewPerson.Focus=true;
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel1.Text.Equals("Add Salary Report"))
                {
                    if (!pnlFormsMenu.Contains(monthlySalary))
                    {
                        monthlySalary = new frmMonthlySalary();
                        monthlySalary.TopLevel = false;
                        monthlySalary.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(monthlySalary);
                        monthlySalary.Show();
                        monthlySalary.BringToFront();
                        //addNewPerson.Focus=true;
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Problem Occur During Accessing Selected Form " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //=====objects used by second label option in sub menu
        frmViewAttendenceRecord viewAttendece;
        frmUpdateLoanReport updateLoan;
        frmUpdateCasterReport updateCaster;
        frmUpdateMonthlySalary updateMonthlySalary;
        frmUpdateDailyWages updateDailyWages;
        frmSearchPerson searchPerson;
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (linkLabel2.Text.Equals("Change Password"))
                {
                    if (!pnlFormsMenu.Contains(addNewUser))
                    {
                        addNewUser = new frmAddNewUser();
                        addNewUser.TopLevel = false;
                        addNewUser.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(addNewUser);
                        addNewUser.Show();
                        addNewUser.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel2.Text.Equals("View Attendance Record"))
                {
                    if (!pnlFormsMenu.Contains(viewAttendece))
                    {
                        viewAttendece = new frmViewAttendenceRecord();
                        viewAttendece.TopLevel = false;
                        viewAttendece.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(viewAttendece);
                        viewAttendece.Show();
                        viewAttendece.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel2.Text.Equals("Search Person"))
                {
                    if (!pnlFormsMenu.Contains(searchPerson))
                    {
                        searchPerson = new frmSearchPerson();
                        searchPerson.TopLevel = false;
                        searchPerson.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(searchPerson);
                        searchPerson.Show();
                        searchPerson.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel2.Text.Equals("Update Loan Report"))
                {
                    if (!pnlFormsMenu.Contains(updateLoan))
                    {
                        updateLoan = new frmUpdateLoanReport();
                        updateLoan.TopLevel = false;
                        updateLoan.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(updateLoan);
                        updateLoan.Show();
                        updateLoan.BringToFront();
                        //addNewPerson.Focus=true;
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel2.Text.Equals("View Payment Report"))
                {
                    if (!pnlFormsMenu.Contains(updateCaster))
                    {
                        updateCaster = new frmUpdateCasterReport();
                        updateCaster.TopLevel = false;
                        updateCaster.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(updateCaster);
                        updateCaster.Show();
                        updateCaster.BringToFront();
                        //addNewPerson.Focus=true;
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel2.Text.Equals("View Wages Report"))
                {
                    if (!pnlFormsMenu.Contains(updateDailyWages))
                    {
                        updateDailyWages = new frmUpdateDailyWages();
                        updateDailyWages.TopLevel = false;
                        updateDailyWages.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(updateDailyWages);
                        updateDailyWages.Show();
                        updateDailyWages.BringToFront();
                        //addNewPerson.Focus=true;
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel2.Text.Equals("View Salary Report"))
                {
                    if (!pnlFormsMenu.Contains(updateMonthlySalary))
                    {
                        updateMonthlySalary = new frmUpdateMonthlySalary();
                        updateMonthlySalary.TopLevel = false;
                        updateMonthlySalary.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(updateMonthlySalary);
                        updateMonthlySalary.Show();
                        updateMonthlySalary.BringToFront();
                        //addNewPerson.Focus=true;
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Problem Occur During Accessing Selected Form " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //=====objects used by third label option in sub menu
        frmAddJobs addJob;
        frmAddNewUser addNewUser;
        frmChangeWorkerLoanAmount changeWorkerLoan;
        frmItemCastingRate castingRate;
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (linkLabel3.Text.Equals("Delete User"))
                {
                    if (!pnlFormsMenu.Contains(addNewUser))
                    {
                        addNewUser = new frmAddNewUser();
                        addNewUser.TopLevel = false;
                        addNewUser.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(addNewUser);
                        addNewUser.Show();
                        addNewUser.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel3.Text.Equals("Change Loan Amount"))
                {
                    if (!pnlFormsMenu.Contains(changeWorkerLoan))
                    {
                        changeWorkerLoan = new frmChangeWorkerLoanAmount();
                        changeWorkerLoan.TopLevel = false;
                        changeWorkerLoan.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(changeWorkerLoan);
                        changeWorkerLoan.Show();
                        changeWorkerLoan.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel3.Text.Equals("Add Person Job"))
                {
                    if (!pnlFormsMenu.Contains(addJob))
                    {
                        addJob = new frmAddJobs();
                        addJob.TopLevel = false;
                        addJob.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(addJob);
                        addJob.Show();
                        addJob.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel3.Text.Equals("Item Casting Rate"))
                {
                    if (!pnlFormsMenu.Contains(castingRate))
                    {
                        castingRate = new frmItemCastingRate();
                        castingRate.TopLevel = false;
                        castingRate.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(castingRate);
                        castingRate.Show();
                        castingRate.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Database error..." + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //=====objects used by fourth label option in sub menu
        frmAddAddress addAddress;
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (linkLabel4.Text.Equals("Add Person Address"))
                {
                    if (!pnlFormsMenu.Contains(addAddress))
                    {
                        addAddress = new frmAddAddress();
                        addAddress.TopLevel = false;
                        addAddress.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(addAddress);
                        addAddress.Show();
                        addAddress.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("database error..." + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //=====objects used by fifth label option in sub menu
        frmAddContact addContact;
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (linkLabel5.Text.Equals("Add Person Contact"))
                {
                    if (!pnlFormsMenu.Contains(addContact))
                    {
                        addContact = new frmAddContact();
                        addContact.TopLevel = false;
                        addContact.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(addContact);
                        addContact.Show();
                        addContact.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Database error..." + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //=====objects used by sixth label option in sub menu
        frmAddCountry addCountry;
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (linkLabel6.Text.Equals("Add Country"))
                {
                    if (!pnlFormsMenu.Contains(addCountry))
                    {
                        addCountry = new frmAddCountry();
                        addCountry.TopLevel = false;
                        addCountry.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(addCountry);
                        addCountry.Show();
                        addCountry.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Database error..." + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //=====objects used by seventh label option in sub menu
        frmAddProvince addProvince;
        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (linkLabel7.Text.Equals("Add Province"))
                {
                    if (!pnlFormsMenu.Contains(addProvince))
                    {
                        addProvince = new frmAddProvince();
                        addProvince.TopLevel = false;
                        addProvince.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(addProvince);
                        addProvince.Show();
                        addProvince.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Database error..." + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //=====objects used by Eighth label option in sub menu
        frmAddCity addCity;
        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (linkLabel8.Text.Equals("Add City"))
                {
                    if (!pnlFormsMenu.Contains(addCity))
                    {
                        addCity = new frmAddCity();
                        addCity.TopLevel = false;
                        addCity.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(addCity);
                        addCity.Show();
                        addCity.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Database error..." + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pbxPerson_Click(object sender, EventArgs e)
        {
            //====================================================
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.Indigo;
            linkLabel2.LinkColor = Color.Indigo;
            linkLabel3.LinkColor = Color.Indigo;
            linkLabel4.LinkColor = Color.Indigo;
            linkLabel5.LinkColor = Color.Indigo;
            linkLabel6.LinkColor = Color.Indigo;
            linkLabel7.LinkColor = Color.Indigo;
            linkLabel8.LinkColor = Color.Indigo;
            lblSlogans.ForeColor = Color.Indigo;
            lblSlogan.ForeColor = Color.Indigo;
            lblHeading.ForeColor = Color.Indigo;
            pnlMainMenu.BackColor = Color.Indigo;
            lblCompanyName.ForeColor = Color.Indigo;
            lblCompanyNames.ForeColor = Color.Indigo;
            //====================================================
            lblHeading.Text = "Person Setting";
            linkLabel1.Text = "Add New Person";
            linkLabel2.Text = "Search Person";
            linkLabel3.Text = "Add Person Job";
            linkLabel4.Text = "Add Person Address";
            linkLabel5.Text = "Add Person Contact";
            linkLabel6.Text = "Add Country";
            linkLabel7.Text = "Add Province";
            linkLabel8.Text = "Add City";
        }

        private void pbxPerson_MouseEnter(object sender, EventArgs e)
        {
            pbxPerson.Location = new Point(2, 7);
            pbxPerson.Size = new Size(83, 51);
        }

        private void pbxPerson_MouseLeave(object sender, EventArgs e)
        {
            pbxPerson.Location = new Point(22, 22);
            pbxPerson.Size = new Size(54, 29);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogin_Click(this, e);
                lblLoginMain.Visible = false;
            }
        }

    }
}
