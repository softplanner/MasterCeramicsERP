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
    public partial class frmAdmin : Form
    {
        //UserDAL userDAL = new UserDAL();
        string userType = null, userName = null;
        //=====font family work here
        FontFamily fontFamily=new FontFamily("Arial");
        FontStyle fontStyle = FontStyle.Bold;
        int selectedRow = -1;
        //---------------------------
        public frmAdmin()
        {
            InitializeComponent();
        }
        private void InvisiblePanelStart1()
        {
            pnlStart1.Visible = false;
        }
        private void VisiblePanelStart1()
        {
            pnlStart1.Visible = true;
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            //pnlMainMenu.Visible = true;
            //InvisiblePanelStart1();
            InvisiblePanelContainer2();
            pbxStart.Visible = false;
            pbxStart0.Visible = false;
            //=====login work
            lblLogout.Visible = false;
            pbxLogout.Visible = false;
            lblUsernameInfo.Visible = false;
            lblPasswordInfo.Visible = false;
            lblLogout.Visible = false;
            pbxLogout.Visible = false;
            //=====end login work
            txtName.Focus();
        }
        //=====Invisible login menu
        private void HideLoginCompponents()
        {
            txtName.Visible = false;
            lblName.Visible = false;
            txtPassword.Visible = false;
            lblPassword.Visible = false;
            btnLogin.Visible = false;
            btnReset.Visible = false;
        }
        //====end 
        //=====visible login menu
        private void showLoginCompponents()
        {
            txtName.Visible = true;
            lblName.Visible = true;
            txtPassword.Visible = true;
            lblPassword.Visible = true;
            btnLogin.Visible = true;
            btnReset.Visible = true;
        }
        //=====Invisible login menu
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Enter User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            else
            {
                try
                {
                    UserDAL userDAL = new UserDAL();

                    if (userDAL.getPassword(txtName.Text).Equals(txtPassword.Text))
                    {
                        userName = txtName.Text;
                        userType = userDAL.getUserType(userName);
                        HideLoginCompponents();
                        visiblePanelContainer2();
                        lblLogout.Visible = true;
                        pbxLogout.Visible = true;
                        lblSlogan.ForeColor = Color.Maroon;
                        lblSlogans.ForeColor = Color.Maroon;
                        lblCompanyName.ForeColor = Color.Maroon;
                        lblCompanyNames.ForeColor = Color.Maroon;
                    }
                    else
                    {
                        MessageBox.Show("Invalid username/ passeord", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Connection with server reporting error.....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void visiblePanelContainer2()
        {
            pnlContainer2.Enabled = true;
            pbxStart0.Visible = true;
        }
        private void InvisiblePanelContainer2()
        {
            pbxStart0.Visible = false;
            link2.Visible = false;
            linkInventory.Visible= false;
            linkPayroll.Visible = false;
            linkSale.Visible = false;
            pnlContainer2.Enabled = false;
            pnlStart1.Visible = false;
            pnlInventorySub.Visible = false;
            pnlPayrollSub.Visible = false;
            pnlSalesSub.Visible = false;
            dgv.Visible = false;
        }
        //=====logout defination
        private void logout()
        {
            //InvisibleLabel();
            showLoginCompponents();
            InvisiblePanelStart1();
            InvisiblePanelContainer2();
            //pnlMainMenu.Enabled = false;
            txtName.Text = "";
            txtPassword.Text = "";
            pbxLogout.Visible = false;
            lblLogout.Visible = false;
            lblCompanyName.ForeColor = Color.Transparent;
            lblCompanyNames.ForeColor = Color.Transparent;
            lblSlogan.ForeColor = Color.Transparent;
            lblSlogans.ForeColor = Color.Transparent;
            txtName.Focus();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout();
        }
        // end logout
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                UserDAL userDAL = new UserDAL();

                if (txtName.Text.Length > 0)
                {

                    if (userDAL.IsAlreadyExist(txtName.Text).Equals(true))
                    {
                        lblUsernameInfo.ForeColor = Color.DarkSlateBlue;
                        lblUsernameInfo.Text = "Valid User Name";
                        lblUsernameInfo.Visible = true;
                    }
                    else
                    {
                        lblUsernameInfo.ForeColor = Color.Red;
                        lblUsernameInfo.Text = "Invalid User Name";
                        lblUsernameInfo.Visible = true;
                        return;
                    }
                }
                if (txtPassword.Text.Length > 0)
                {
                    if (userDAL.getPassword(txtName.Text).Equals(txtPassword.Text))
                    {
                        lblPasswordInfo.ForeColor = Color.DarkSlateBlue;
                        lblPasswordInfo.Text = "Valid Password";
                        lblPasswordInfo.Visible = true;
                    }
                    else
                    {
                        lblPasswordInfo.ForeColor = Color.Red;
                        lblPasswordInfo.Text = "Invalid Password";
                        lblPasswordInfo.Visible = true;
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Connection with server reporting error.....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                lblUsernameInfo.Visible = false;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                lblPasswordInfo.Visible = false;
            }
        }
        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            lblUsernameInfo.Visible = false;
            lblPasswordInfo.Visible = false;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPassword.Text = "";
        }

        private void pbxLogout_MouseEnter(object sender, EventArgs e)
        {
            //pbxLogout.Location = new Point(895,32);
            //pbxLogout.Size = new Size(60, 47);
        }

        private void pbxLogout_MouseLeave(object sender, EventArgs e)
        {
            pbxLogout.Location = new Point(907,32);
            pbxLogout.Size = new Size(50, 43);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdmin_MouseEnter(object sender, EventArgs e)
        {
            //pbxClose.Location = new Point(967,9);
            //pbxClose.Size = new Size(32,23);
        }

        private void frmAdmin_MouseLeave(object sender, EventArgs e)
        {
            //pbxClose.Location = new Point(964,9);
            //pbxClose.Size = new Size(29, 21);
        }

        private void pbxStart0_MouseEnter(object sender, EventArgs e)
        {
            pbxStart0.Visible = false;
            pbxStart.Visible = true;
            lblCompanyName.ForeColor = Color.Red;
            lblCompanyNames.ForeColor = Color.Red;
            lblSlogan.ForeColor = Color.Red;
            lblSlogans.ForeColor = Color.Red;
        }
        private void pnlInventoryStart1_MouseEnter(object sender, EventArgs e)
        {
            link2.Visible = false;
            //-----applying color
            removePayrollColor();
            removeSalesColor();
            applyInventoryColor();
            //-------------------
            pnlInventorySub.Visible = true;
            pnlPayrollSub.Visible = false;
            pnlSalesSub.Visible = false;
            dgv.Visible = false;
            pbxInventoryIcon.Size = new Size(59, 42);
            pbxInventoryIcon.Location = new Point(130,4);
            //fontFamily = lblInventoryStart1.Font.FontFamily;
            //fontStyle = lblInventoryStart1.Font.Style;
            lblInventoryStart1.Font = new Font(fontFamily, 12, fontStyle);
        }
        private void closeStartMenu()
        {
            link2.Visible = false;
            linkInventory.Visible = false;
            //-----remiving color
            removeInventoryColor();
            removePayrollColor();
            removeSalesColor();
            ///---
            dgv.Visible = false;
            pnlInventorySub.Visible = false;
            pnlPayrollSub.Visible = false;
            pnlSalesSub.Visible = false;
            pnlStart1.Visible = false;
            pbxStart0.Visible = true;
            pbxStart.Visible = false;
        }
        private void pbxmainMenuClose_Click(object sender, EventArgs e)
        {
            closeStartMenu();
        }

        private void pbxStart_Click(object sender, EventArgs e)
        {
            VisiblePanelStart1();

        }

        private void pbxStart_MouseLeave(object sender, EventArgs e)
        {
            pbxStart0.Visible = true;
            pbxStart.Visible = false;
        }

        private void pnlInventoryStart1_MouseLeave(object sender, EventArgs e)
        {
            //pnlInventorySub.Visible = false;
            pbxInventoryIcon.Size = new Size(36, 31);
            pbxInventoryIcon.Location = new Point(153, 12);
            lblInventoryStart1.Font = new Font(fontFamily,10,fontStyle);
        }
        private void invisibleSubMenu1()
        {
            pnlInventorySub.Visible = false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            link2.Visible = false;
            linkInventory.Visible = false;
            //-----remiving color
            removeInventoryColor();
            ///---
            pnlInventorySub.Visible = false;
            dgv.Visible = false;
        }

        private void lblPayrollStart1_MouseEnter(object sender, EventArgs e)
        {
            link2.Visible = false;
            //-----remove color
            removeInventoryColor();
            removeSalesColor();
            applyPayrollColor();
            //-----------------
            pnlInventorySub.Visible = false;
            pnlPayrollSub.Visible = true;
            pnlSalesSub.Visible = false;
            dgv.Visible = false;
            pbxPayrollIcon.Size = new Size(59,42);
            pbxPayrollIcon.Location = new Point(130,4);
            //fontFamily = lblPayrollStart1.Font.FontFamily;
            //fontStyle = lblPayrollStart1.Font.Style;
            lblPayrollStart1.Font = new Font(fontFamily, 12, fontStyle);
        }

        private void pbxPayrollClose_Click(object sender, EventArgs e)
        {
            link2.Visible = false;
            removePayrollColor();
            pnlPayrollSub.Visible = false;
            dgv.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            removeSalesColor();
            pnlSalesSub.Visible = false;
            dgv.Visible = false;
            link2.Visible = false;
        }

        private void lblPayrollStart1_MouseLeave(object sender, EventArgs e)
        {
            //pnlPayrollSub.Visible = false;
            pbxPayrollIcon.Location = new Point(153,12);
            pbxPayrollIcon.Size = new Size(31, 36);
            lblPayrollStart1.Font = new Font(fontFamily,10, fontStyle);
        }

        private void lblSalesStart1_MouseEnter(object sender, EventArgs e)
        {
            link2.Visible = false;
            //-----applying colors
            removeInventoryColor();
            removePayrollColor();
            applySalesColor();
            //---------------------
            pnlInventorySub.Visible = false;
            pnlPayrollSub.Visible = false;
            pnlSalesSub.Visible = true;
            dgv.Visible = false;
            pbxSalesIcon.Size = new Size(59,42);
            pbxSalesIcon.Location = new Point(130,4);
            //fontFamily = lblSalesStart1.Font.FontFamily;
            //fontStyle = lblSalesStart1.Font.Style;
            lblSalesStart1.Font = new Font(fontFamily,12, fontStyle);
        }

        private void lblSalesStart1_MouseLeave(object sender, EventArgs e)
        {
            //pnlSalesSub.Visible = false;
            pbxSalesIcon.Location = new Point(153,12);
            pbxSalesIcon.Size = new Size(36, 31);
            lblSalesStart1.Font = new Font(fontFamily, 10, fontStyle);
        }

        private void lblInv1_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.Tan;
            link2.Location = new Point(363, 64);
            //------
            pbxPerson.Location = new Point(72, 2);
            pbxPerson.Size = new Size(36, 31);
            lblInv1.Font = new Font(fontFamily, 8, fontStyle);
            //-------------------------------------------------
            dgv.Location = new Point(409, 64);
            dgv.Columns[0].HeaderText= "Person";
            string[] arr=new string[]{"Add New Person","Search Person","Manage Job's","Manage Addresses","Manage Contact's","Manage Countries","Manage Provinces","Manage Cities"};
            for (int i = 0; i < 8;i++ )
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }

        private void lblInv1_MouseLeave(object sender, EventArgs e)
        {
            pbxPerson.Location = new Point(78, 7);
            pbxPerson.Size = new Size(26, 21);
            lblInv1.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }

        private void pnlSubMenuContents2_MouseEnter(object sender, EventArgs e)//lblInv2 mouse enter
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.Tan;
            link2.Location = new Point(363, 104);
            //------
            pbxRawmaterial.Location = new Point(72, 2);
            pbxRawmaterial.Size = new Size(36, 31);
            lblInv2.Font = new Font(fontFamily, 8, fontStyle);
            ///-------------------------------------------------------------
            dgv.Location = new Point(409,104);
            dgv.Columns[0].HeaderText = "Raw Material";
            string[] arr = new string[] { "Add New Raw Material", "Purchase Report", "Update Purchase Report", "Manage Stock"};
            for (int i = 0; i < 4; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblInv2_MouseLeave(object sender, EventArgs e)
        {
            pbxRawmaterial.Location = new Point(78, 7);
            pbxRawmaterial.Size = new Size(26, 21);
            lblInv2.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }

        private void lblInv3_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.Tan;
            link2.Location = new Point(363, 144);
            //------
            pbxBallMill.Location = new Point(72, 2);
            pbxBallMill.Size = new Size(36, 31);
            lblInv3.Font = new Font(fontFamily, 8, fontStyle);

            dgv.Location = new Point(409, 144);
            dgv.Columns[0].HeaderText = "Ball Mill";
            string[] arr = new string[] { "Manage BallMill", "Load & Unload BallMill"};
            for (int i = 0; i < 2; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblInv3_MouseLeave(object sender, EventArgs e)
        {
            pbxBallMill.Location = new Point(78, 7);
            pbxBallMill.Size = new Size(26,21);
            lblInv3.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }
        private void lblInv4_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.Tan;
            link2.Location = new Point(363, 184);
            //------
            pbxgreenware.Location = new Point(72, 2);
            pbxgreenware.Size = new Size(36, 31);
            lblInv4.Font = new Font(fontFamily, 8, fontStyle);

            dgv.Location = new Point(409,184);
            dgv.Columns[0].HeaderText = "GreenWare";
            string[] arr = new string[] { "Mold Casting", "Update Mold Casting","Caster Mold Stock","Item Checking","Update Item Checking","Item Breakage","Update Item Breakage" };
            for (int i = 0; i < 7; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblInv4_MouseLeave(object sender, EventArgs e)
        {
            pbxgreenware.Location = new Point(78, 7);
            pbxgreenware.Size = new Size(26, 21);
            lblInv4.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }
        private void lblInv5_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.Tan;
            link2.Location = new Point(363, 224);
            //------
            pbxOilInspection.Location = new Point(72, 2);
            pbxOilInspection.Size = new Size(36, 31);
            lblInv5.Font = new Font(fontFamily, 8, fontStyle);

            dgv.Location = new Point(409, 224);
            dgv.Columns[0].HeaderText = "Oil Inspection";
            string[] arr = new string[] { "Add Inspection Report", "View & Update Report"};
            for (int i = 0; i < 2; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblInv5_MouseLeave(object sender, EventArgs e)
        {
            pbxOilInspection.Location = new Point(78, 7);
            pbxOilInspection.Size = new Size(26, 21);
            lblInv5.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }
        private void lblInv6_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.Tan;
            link2.Location = new Point(363, 264);
            //------
            pbxGlazeHouse.Location = new Point(72, 2);
            pbxGlazeHouse.Size = new Size(36, 31);
            lblInv6.Font = new Font(fontFamily, 8, fontStyle);

            dgv.Location = new Point(409, 264);
            dgv.Columns[0].HeaderText = "Glaze House";
            string[] arr = new string[] { "Daily Glazing Report's", "View & Update Glazing Report's","Glazed Item Breakage","Update Breakage Report's","Manage Glaze Booth's"};
            for (int i = 0; i < 5; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblInv6_MouseLeave(object sender, EventArgs e)
        {
            pbxGlazeHouse.Location = new Point(78, 7);
            pbxGlazeHouse.Size = new Size(26, 21);
            lblInv6.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }
        private void lblInv7_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.Tan;
            link2.Location = new Point(363, 304);
            //------
            pbxKillen.Location = new Point(72, 2);
            pbxKillen.Size = new Size(36, 31);
            lblInv7.Font = new Font(fontFamily, 8, fontStyle);

            dgv.Location = new Point(409, 304);
            dgv.Columns[0].HeaderText = "Killen";
            string[] arr = new string[] { "Daily Killen Report's", "Update Killen Report's", "Killen Feed", "Update Killen Feed", "Manage Killen's" };
            for (int i = 0; i < 5; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblInv7_MouseLeave(object sender, EventArgs e)
        {
            pbxKillen.Location = new Point(78, 7);
            pbxKillen.Size = new Size(26, 21);
            lblInv7.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }
        private void pnlSubMenuContents8_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.Tan;
            link2.Location = new Point(363, 361);
            //------
            pbxItemStock.Location = new Point(72, 2);
            pbxItemStock.Size = new Size(36, 31);
            lblInv8.Font = new Font(fontFamily, 8, fontStyle);

            dgv.Location = new Point(409, 247);
            dgv.Columns[0].HeaderText = "Item Stock";
            string[] arr = new string[] { "View Item Stock", "Update Item Stock", "Manage Item's", "Manage Style's", "Manage Item's Weight" };
            for (int i = 0; i < 5; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblInv8_MouseLeave(object sender, EventArgs e)
        {
            pbxItemStock.Location = new Point(78, 7);
            pbxItemStock.Size = new Size(26, 21);
            lblInv8.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }
        private void pnlSubMenuContents9_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.Tan;
            link2.Location = new Point(363, 402);
            //------
            pbxMold.Location = new Point(72, 2);
            pbxMold.Size = new Size(36, 31);
            lblInv9.Font = new Font(fontFamily, 8, fontStyle);

            dgv.Location = new Point(409, 244);
            dgv.Columns[0].HeaderText = "Mold";
            string[] arr = new string[] { "Receive Report's", "Update Receive Reort's", "Issue Report", "Update Issue Report's", "Mold Breakage" ,"Update Breakage","Company Stock"};
            for (int i = 0; i < 7; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblInv9_MouseLeave(object sender, EventArgs e)
        {
            pbxMold.Location = new Point(78, 7);
            pbxMold.Size = new Size(26, 21);
            lblInv9.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }
        private void pnlSubMenuContents10_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.Tan;
            link2.Location = new Point(363, 440);
            //------
            pbxGeneral.Location = new Point(72, 2);
            pbxGeneral.Size = new Size(36, 31);
            lblInv10.Font = new Font(fontFamily, 8, fontStyle);

            dgv.Location = new Point(409, 326);
            dgv.Columns[0].HeaderText = "General";
            string[] arr = new string[] { "Predict Slip From Item's", "Predict RawMaterial", "Predict Item's From Slip", "Slip Percentage Info", "Update Slip Percentage"};
            for (int i = 0; i < 5; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblInv10_MouseLeave(object sender, EventArgs e)
        {
            pbxGeneral.Location = new Point(78, 7);
            pbxGeneral.Size = new Size(26, 21);
            lblInv10.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }
        private void pnlSubMenuContents11_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.Tan;
            link2.Location = new Point(363,486);
            //------
            pbxUser.Location = new Point(72, 2);
            pbxUser.Size = new Size(36, 31);
            lblInv11.Font = new Font(fontFamily, 8, fontStyle);

            dgv.Location = new Point(409, 416);
            dgv.Columns[0].HeaderText = "User";
            string[] arr = new string[] { "Add User", "Change Password", "Delete User"};
            for (int i = 0; i < 3; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblInv11_MouseLeave(object sender, EventArgs e)
        {
            pbxUser.Location = new Point(78, 7);
            pbxUser.Size = new Size(26, 21);
            lblInv11.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }
        private void pnlInventorySub_MouseLeave(object sender, EventArgs e)
        {
            //dgv.Visible = false;
        }

        private void pnlPayrollSub_MouseLeave(object sender, EventArgs e)
        {
            //dgv.Visible = false;
        }

        private void pnlSalesSub_MouseLeave(object sender, EventArgs e)
        {
            //dgv.Visible=false;
        }

        private void lblPR1_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.SlateBlue;
            link2.Location = new Point(363, 261);
            //------
            pbxAttendance.Location = new Point(97, 2);
            pbxAttendance.Size = new Size(43, 31);
            lblPR1.Font = new Font(fontFamily, 8, fontStyle);

            dgv.Location = new Point(409, 261);
            dgv.Columns[0].HeaderText = "Attendance";
            string[] arr = new string[] { "Mark Attendance", "View Attendance", "Delete User" };
            for (int i = 0; i < 2; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblPR1_MouseLeave(object sender, EventArgs e)
        {
            pbxAttendance.Location = new Point(103, 7);
            pbxAttendance.Size = new Size(33, 22);
            lblPR1.Font= new Font(fontFamily, 8, FontStyle.Regular);
        }
        private void lblPR2_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.SlateBlue;
            link2.Location = new Point(363, 297);
            //-----------
            pbxWorkerLoan.Location = new Point(97, 2);
            pbxWorkerLoan.Size = new Size(43, 31);
            lblPR2.Font = new Font(fontFamily, 8, fontStyle);

            dgv.Location = new Point(409, 297);
            dgv.Columns[0].HeaderText = "Worker Loan";
            string[] arr = new string[] { "Manage Loan", "Update Loan Report's"};
            for (int i = 0; i < 2; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblPR2_MouseLeave(object sender, EventArgs e)
        {
            pbxWorkerLoan.Location = new Point(103, 7);
            pbxWorkerLoan.Size = new Size(33, 22);
            lblPR2.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }
        private void lblPR3_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.SlateBlue;
            link2.Location = new Point(363, 337);
            //------
            pbxCasterPayment.Location = new Point(97, 2);
            pbxCasterPayment.Size = new Size(43, 31);
            lblPR3.Font = new Font(fontFamily, 8, fontStyle);

            dgv.Location = new Point(409, 337);
            dgv.Columns[0].HeaderText = "Caster Payment";
            string[] arr = new string[] { "Add Payment Report", "View Payment Report" };
            for (int i = 0; i < 2; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblPR3_MouseLeave(object sender, EventArgs e)
        {
            pbxCasterPayment.Location = new Point(103, 7);
            pbxCasterPayment.Size = new Size(33, 22);
            lblPR3.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }
        private void lblPR4_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.SlateBlue;
            link2.Location = new Point(363, 376);
            //------
            pbxDailyWaes.Location = new Point(97, 2);
            pbxDailyWaes.Size = new Size(43, 31);
            lblPR4.Font = new Font(fontFamily, 8, fontStyle);

            dgv.Location = new Point(409, 376);
            dgv.Columns[0].HeaderText = "Daily Wages";
            string[] arr = new string[] { "Add Wages Report", "View Wages Report" };
            for (int i = 0; i < 2; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblPR4_MouseLeave(object sender, EventArgs e)
        {
            pbxDailyWaes.Location = new Point(103, 7);
            pbxDailyWaes.Size = new Size(33, 22);
            lblPR4.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }
        private void lblPR5_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.SlateBlue;
            link2.Location = new Point(363, 440);
            //------
            pbxMonthlySalary.Location = new Point(97, 2);
            pbxMonthlySalary.Size = new Size(43, 31);
            lblPR5.Font = new Font(fontFamily, 8, fontStyle);

            dgv.Location = new Point(409, 392);
            dgv.Columns[0].HeaderText = "Monthly Salary";
            string[] arr = new string[] { "Add Salary Report", "View Salary Report" };
            for (int i = 0; i < 2; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblPR5_MouseLeave(object sender, EventArgs e)
        {
            pbxMonthlySalary.Location = new Point(103, 7);
            pbxMonthlySalary.Size = new Size(33, 22);
            lblPR5.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }

        private void lblSale1_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.BurlyWood;
            link2.Location = new Point(363, 266);
            //------
            pbxSubDealer.Location = new Point(97, 2);
            pbxSubDealer.Size = new Size(43, 31);
            lblSale1.Font = new Font(fontFamily, 8, fontStyle);

            dgv.Location = new Point(409, 266);
            dgv.Columns[0].HeaderText = "SubDealer";
            string[] arr = new string[] { "Manage SubDealer's"};
            for (int i = 0; i < 1; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblSale1_MouseLeave(object sender, EventArgs e)
        {
            pbxSubDealer.Location = new Point(103, 7);
            pbxSubDealer.Size = new Size(33, 22);
            lblSale1.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }
        private void lblSale2_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.BurlyWood;
            link2.Location = new Point(363, 306);
            //------
            pbxGoods.Location = new Point(97, 2);
            pbxGoods.Size = new Size(43, 31);
            lblSale2.Font = new Font(fontFamily, 8, fontStyle);

            dgv.Location = new Point(409, 306);
            dgv.Columns[0].HeaderText = "Good's Company";
            string[] arr = new string[] { "Manage Goods Companies"};
            for (int i = 0; i < 1; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblSale2_MouseLeave(object sender, EventArgs e)
        {
            pbxGoods.Location = new Point(103, 7);
            pbxGoods.Size = new Size(33, 22);
            lblSale2.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }
        private void lblSale3_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.BurlyWood;
            link2.Location = new Point(363, 343);
            //------
            pbxAddOrder.Location = new Point(97, 2);
            pbxAddOrder.Size = new Size(43, 31);
            lblSale3.Font = new Font(fontFamily, 8, fontStyle);

            dgv.Location = new Point(409, 343);
            dgv.Columns[0].HeaderText = "Get Order's";
            string[] arr = new string[] { "Add New Order", "View By Dealer","View By Sub-Dealer" };
            for (int i = 0; i < 3; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblSale3_MouseLeave(object sender, EventArgs e)
        {
            pbxAddOrder.Location = new Point(103, 7);
            pbxAddOrder.Size = new Size(33, 22);
            lblSale3.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }
        private void lblSale4_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.BurlyWood;
            link2.Location = new Point(363, 382);
            //------
            pbxDeliveryChallan.Location = new Point(97, 2);
            pbxDeliveryChallan.Size = new Size(43, 31);
            lblSale4.Font = new Font(fontFamily, 8, fontStyle);

            dgv.Location = new Point(409, 382);
            dgv.Columns[0].HeaderText = "Delivery Challan";
            string[] arr = new string[] { "Create New Challan", "View Challan Info" };
            for (int i = 0; i < 2; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblSale4_MouseLeave(object sender, EventArgs e)
        {
            pbxDeliveryChallan.Location = new Point(103, 7);
            pbxDeliveryChallan.Size = new Size(33, 22);
            lblSale4.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }
        private void lblSale5_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.BurlyWood;
            link2.Location = new Point(363, 422);
            //------
            pbxPostedOrder.Location = new Point(97, 2);
            pbxPostedOrder.Size = new Size(43, 31);
            lblSale5.Font = new Font(fontFamily, 8, fontStyle);

            dgv.Location = new Point(409, 422);
            dgv.Columns[0].HeaderText = "Posted Order's";
            string[] arr = new string[] { "Add Posted Order's", "View Order's","Create Order's Bill" };
            for (int i = 0; i < 3; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblSale5_MouseLeave(object sender, EventArgs e)
        {
            pbxPostedOrder.Location = new Point(103, 7);
            pbxPostedOrder.Size = new Size(33, 22);
            lblSale5.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }
        private void lblSale6_MouseEnter(object sender, EventArgs e)
        {
            generalFunctionForDGV();
            //-----link2
            link2.FillColor = Color.BurlyWood;
            link2.Location = new Point(363, 491);
            //------
            pbxBills.Location = new Point(97, 2);
            pbxBills.Size = new Size(43, 31);
            lblSale6.Font = new Font(fontFamily, 8, fontStyle);

            dgv.Location = new Point(409, 399);
            dgv.Columns[0].HeaderText = "Bill's";
            string[] arr = new string[] { "By Delivery Challan", "For Customer's","Empty Bill","Letter Head" };
            for (int i = 0; i < 4; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = arr[i];
            }
        }
        private void lblSale6_MouseLeave(object sender, EventArgs e)
        {
            pbxBills.Location = new Point(103, 7);
            pbxBills.Size = new Size(33, 22);
            lblSale6.Font = new Font(fontFamily, 8, FontStyle.Regular);
        }
        private void pbxStart0_MouseLeave(object sender, EventArgs e)
        {
            lblCompanyName.ForeColor = Color.Maroon;
            lblCompanyNames.ForeColor = Color.Maroon;
            lblSlogan.ForeColor = Color.Maroon;
            lblSlogans.ForeColor = Color.Maroon;
        }

        private void pbxStartClose_MouseEnter(object sender, EventArgs e)
        {
            pbxStartClose.Location = new Point(166,5);
            pbxStartClose.Size = new Size(24,21);
        }

        private void pbxStartClose_MouseLeave(object sender, EventArgs e)
        {
            pbxStartClose.Location = new Point(169, 8);
            pbxStartClose.Size = new Size(21, 18);
        }

        private void pbxStartLogout_MouseEnter(object sender, EventArgs e)
        {
            pbxStartLogout.Location = new Point(8,205);
            pbxStartLogout.Size = new Size(40,35);
        }

        private void pbxStartLogout_MouseLeave(object sender, EventArgs e)
        {
            pbxStartLogout.Location = new Point(12,211);
            pbxStartLogout.Size = new Size(30,25);
        }

        private void pbxStartExist_MouseEnter(object sender, EventArgs e)
        {
            pbxStartExist.Location = new Point(150,207);
            pbxStartExist.Size = new Size(40,35);
        }

        private void pbxStartExist_MouseLeave(object sender, EventArgs e)
        {
            pbxStartExist.Location = new Point(154,211);
            pbxStartExist.Size = new Size(30,25);
        }

        private void pbxStartLogout_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void pbxStartExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxInventoryClose_MouseEnter(object sender, EventArgs e)
        {
            pbxInventoryClose.Location = new Point(106,1);
            pbxInventoryClose.Size = new Size(26,23);
        }

        private void pbxInventoryClose_MouseLeave(object sender, EventArgs e)
        {
            pbxInventoryClose.Location = new Point(106, 4);
            pbxInventoryClose.Size = new Size(21, 18);
        }

        private void pbxPayrollClose_MouseEnter(object sender, EventArgs e)
        {
            pbxPayrollClose.Location = new Point(121,5);
            pbxPayrollClose.Size = new Size(29,22);
        }

        private void pbxCloseSales_MouseEnter(object sender, EventArgs e)
        {
            pbxCloseSales.Location = new Point(121,5);
            pbxCloseSales.Size = new Size(29,22);
        }

        private void pbxCloseSales_MouseLeave(object sender, EventArgs e)
        {
            pbxCloseSales.Location = new Point(129, 8);
            pbxCloseSales.Size = new Size(21, 18);
        }
        //---------------------------------------------------------------------applying back colors
        private void removeInventoryColor()
        {
            //-----remiving color
            pnlInventoryStart1.BackColor = Color.Transparent;
            //pnlInventorySub.BackColor = Color.Transparent;
            ///---
            linkInventory.Visible = false;
        }
        private void applyInventoryColor()
        {
            //-----remiving color
            pnlInventoryStart1.BackColor = Color.Tan;
            //pnlInventorySub.BackColor = Color.GreenYellow;
            ///---
            linkInventory.Visible = true;
        }
        private void removePayrollColor()
        {
            //-----remiving color
            pnlPayrollStart1.BackColor = Color.Transparent;
            //pnlPayrollSub.BackColor = Color.Transparent;
            ///---
            linkPayroll.Visible = false;
        }
        private void applyPayrollColor()
        {
            //-----remiving color
            pnlPayrollStart1.BackColor = Color.SlateBlue;
            //pnlPayrollSub.BackColor = Color.Brown;
            //---
            linkPayroll.Visible = true;
        }
        private void removeSalesColor()
        {
            //-----remiving color
            pnlSalesStart1.BackColor = Color.Transparent;
            //pnlSalesSub.BackColor = Color.Transparent;
            ///---
            linkSale.Visible = false;
        }
        private void applySalesColor()
        {
            //-----remiving color
            pnlSalesStart1.BackColor = Color.BurlyWood;
            //pnlSalesSub.BackColor = Color.SlateBlue;
            //---
            linkSale.Visible = true;
        }
        private void generalFunctionForDGV()
        {
            link2.Visible = true;
            dgv.Rows.Clear();
            dgv.Visible = true;
        }
        //end login work defination====================================================================
        frmAddNewPerson frmPerson;

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(selectedRow!=-1)
            {
                openSelectedForms();
            }
        }
        private void openSelectedForms()
        { 
            if(dgv.Rows[selectedRow].Cells[0].Value.Equals("Add New Person"))
            {
                frmPerson = new frmAddNewPerson();
                frmPerson.TopLevel = false;
                pnlFormsContainer.Size=new Size(800,600);
                pnlFormsContainer.Controls.Add(frmPerson);
                frmPerson.Show();
            }
        }

        private void pnlContainer2_Click(object sender, EventArgs e)
        {
            closeStartMenu();
        }

        private void dgv_Click(object sender, EventArgs e)
        {
            closeStartMenu();
        }

     
    }
}
