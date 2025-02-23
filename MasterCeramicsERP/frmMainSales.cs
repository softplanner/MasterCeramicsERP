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
    public partial class frmMainSales : Form
    {
        UserDAL userDAL = new UserDAL();
        string userType = null, userName = null;
        int check = 0;
        public frmMainSales()
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
        private void frmMainSales_Load(object sender, EventArgs e)
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
            //------disable the unwanted functionality
            pbxBarmilSection.Enabled = false;
            pbxOilInspection.Enabled = false;
            //----------------------------------------
        }
        //login work defination=====================================================
        //=====visible login menu
        private void showLoginCompponents()
        {
            txtName.Visible = true;
            lblName.Visible = true;
            txtPassword.Visible = true;
            lblPassword.Visible = true;
            lblLoginMain.Visible = true;
            lblExit.Visible = true;
        }
        //=====Invisible login menu
        private void HideLoginCompponents()
        {
            txtName.Visible = false;
            lblName.Visible = false;
            txtPassword.Visible = false;
            lblPassword.Visible = false;
            lblExit.Visible = false;
            lblLoginMain.Visible = false;
        }
        //====end invisible login
        private void pbxLogout_Click(object sender, EventArgs e)
        {
            check = 0;
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
                            MessageBox.Show("Enter correct username/password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            txtPassword.Text = "";
                        }
                    }
                //}
                //else
                //{
                //    this.Close();
                //}
            }
            catch 
            {
                MessageBox.Show("Server connection problem...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void pbxCompanyItemStock_MouseEnter(object sender, EventArgs e)
        {
            pbxCompanyItemStock.Location = new Point(638, 7);
            pbxCompanyItemStock.Size = new Size(83, 51);
        }

        private void pbxCompanyItemStock_MouseLeave(object sender, EventArgs e)
        {
            pbxCompanyItemStock.Location = new Point(648, 22);
            pbxCompanyItemStock.Size = new Size(54, 29);
        }
        private void pbxBarmilSection_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.Maroon;
            lblSlogans.ForeColor = Color.Maroon;
            lblSlogan.ForeColor = Color.Maroon;
            lblHeading.ForeColor = Color.Maroon;
            pnlMainMenu.BackColor = Color.Maroon;
            lblCompanyName.ForeColor = Color.Maroon;
            lblCompanyNames.ForeColor = Color.Maroon;
            //====================================================
            lblHeading.Text = "Sub Dealer";
            linkLabel1.Text = "Manage Sub-Dealer";
        }
        private void pbxGreenWare_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = SystemColors.ActiveCaptionText;
            lblSlogans.ForeColor = SystemColors.ActiveCaptionText;
            lblSlogan.ForeColor = SystemColors.ActiveCaptionText;
            lblHeading.ForeColor = SystemColors.ActiveCaptionText;
            pnlMainMenu.BackColor = SystemColors.ActiveCaptionText;
            lblCompanyName.ForeColor = SystemColors.ActiveCaptionText;
            lblCompanyNames.ForeColor = SystemColors.ActiveCaptionText;
            //====================================================
            lblHeading.Text = "Goods Transport";
            linkLabel1.Text = "Manage Goods Company";
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
            lblHeading.Text = "Get Order";
            linkLabel1.Text = "Add Order";
            linkLabel2.Text = "View By Dealer";
            linkLabel3.Text = "View By Sub-Dealer";
        }

        private void pbxGlazeHouse_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = SystemColors.ControlDarkDark;
            linkLabel2.LinkColor = SystemColors.ControlDarkDark;
            //linkLabel3.LinkColor = SystemColors.ControlDarkDark;
            //linkLabel4.LinkColor = SystemColors.ControlDarkDark;
            //linkLabel5.LinkColor = SystemColors.ControlDarkDark;
            lblSlogans.ForeColor = SystemColors.ControlDarkDark;
            lblSlogan.ForeColor = SystemColors.ControlDarkDark;
            lblHeading.ForeColor = SystemColors.ControlDarkDark;
            pnlMainMenu.BackColor = SystemColors.ControlDarkDark;
            lblCompanyName.ForeColor = SystemColors.ControlDarkDark;
            lblCompanyNames.ForeColor = SystemColors.ControlDarkDark;
            //====================================================
            lblHeading.Text = "Delivery Challan";
            //linkLabel1.Text = "Create New Challan";
            //linkLabel2.Text = "View Challan Info";
            //linkLabel3.Text = "By Gate Pass";
            linkLabel1.Text = "Outward GatePass";
            linkLabel2.Text = "View GatePass";
        }

        private void pbxKillenReport_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.DarkSlateGray;
            linkLabel2.LinkColor = Color.DarkSlateGray;
            linkLabel3.LinkColor = Color.DarkSlateGray;
            lblSlogans.ForeColor = Color.DarkSlateGray;
            lblSlogan.ForeColor = Color.DarkSlateGray;
            lblHeading.ForeColor = Color.DarkSlateGray;
            pnlMainMenu.BackColor = Color.DarkSlateGray;
            lblCompanyName.ForeColor = Color.DarkSlateGray;
            lblCompanyNames.ForeColor = Color.DarkSlateGray;
            //====================================================
            lblHeading.Text = "Posted Order";
            linkLabel1.Text = "Add Posted Order's";
            linkLabel2.Text = "View Order's";
            linkLabel3.Text = "Create Order's Bill";
        }
        private void pbxCompanyItemStock_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.DarkSlateBlue;
            linkLabel2.LinkColor = Color.DarkSlateBlue;
            linkLabel3.LinkColor = Color.DarkSlateBlue;
            linkLabel4.LinkColor = Color.DarkSlateBlue;
            linkLabel5.LinkColor = Color.DarkSlateBlue;
            lblSlogans.ForeColor = Color.DarkSlateBlue;
            lblSlogan.ForeColor = Color.DarkSlateBlue;
            lblHeading.ForeColor = Color.DarkSlateBlue;
            pnlMainMenu.BackColor = Color.DarkSlateBlue;
            lblCompanyName.ForeColor = Color.DarkSlateBlue;
            lblCompanyNames.ForeColor = Color.DarkSlateBlue;
            //====================================================
            lblHeading.Text = "Create Bills";
            linkLabel1.Text = "By Delivery Challan";
            linkLabel2.Text = "View Bill's";
            linkLabel3.Text = "Empty Bill";
            linkLabel4.Text = "Letter Head";
            //linkLabel5.Text = "View Bill's";

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
        //--------------------------------------------------------------------------------
        //=====objects used by first label option in sub menu
        salesAddSubDealer manageSubDealer;
        frmAddNewPerson addNewPerson;
        SalesGoodsTransportCompany manageGoodsCompany;
        salesAddOrder addOrder;
        salesDeliveryChallan createNewChallan;
        salesPostOrder addPostedOrder;
        salesCreateBillByGatePass createBillByGatepass;
        //=====objects used by second label option in sub menu
        salesViewUnpostedOrderByDealer viewUnpostedOrderByDealer;
        salesViewDeliveryChallan viewDeliveryChallan;
        frmSearchPerson searchPerson;
        salesViewPostedOrder viewPostedOrder;
        salesCreateBill createBill;
        //=====objects used by third label option in sub menu
        salesViewUnPostedOrder viewUnpostedOrder;
        salesFrmEmptyBill createEmptyBill;
        salesPostedOrderBill createOrderBill;
        frmAddJobs addJob;
        salesViewDelChalGP delChalGP;

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (linkLabel2.Text.Equals("View By Dealer"))
                {
                    if (!pnlFormsMenu.Contains(viewUnpostedOrderByDealer))
                    {
                        viewUnpostedOrderByDealer = new salesViewUnpostedOrderByDealer();
                        viewUnpostedOrderByDealer.TopLevel = false;
                        viewUnpostedOrderByDealer.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(viewUnpostedOrderByDealer);
                        viewUnpostedOrderByDealer.Show();
                        viewUnpostedOrderByDealer.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel2.Text.Equals("View Challan Info"))
                {
                    if (!pnlFormsMenu.Contains(viewDeliveryChallan))
                    {
                        viewDeliveryChallan = new salesViewDeliveryChallan();
                        viewDeliveryChallan.TopLevel = false;
                        viewDeliveryChallan.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(viewDeliveryChallan);
                        viewDeliveryChallan.Show();
                        viewDeliveryChallan.BringToFront();
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
                else if (linkLabel2.Text.Equals("View Order's"))
                {
                    if (!pnlFormsMenu.Contains(viewPostedOrder))
                    {
                        viewPostedOrder = new salesViewPostedOrder();
                        viewPostedOrder.TopLevel = false;
                        viewPostedOrder.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(viewPostedOrder);
                        viewPostedOrder.Show();
                        viewPostedOrder.BringToFront();
                        //addNewPerson.Focus=true;
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel2.Text.Equals("View GatePass"))
                {
                    if (!pnlFormsMenu.Contains(viewOutwardGP))
                    {
                        viewOutwardGP = new frmViewOutwardgatepass();
                        viewOutwardGP.TopLevel = false;
                        viewOutwardGP.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(viewOutwardGP);
                        viewOutwardGP.Show();
                        viewOutwardGP.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                //else if (linkLabel2.Text.Equals("For Customer's"))
                //{
                //    if (!pnlFormsMenu.Contains(createBill))
                //    {
                //        createBill = new salesCreateBill();
                //        createBill.TopLevel = false;
                //        createBill.Dock = DockStyle.Fill;
                //        pnlFormsMenu.Controls.Add(createBill);
                //        createBill.Show();
                //        createBill.BringToFront();
                //        //addNewPerson.Focus=true;
                //    }
                //    else
                //    {
                //        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }

                //}
                else if (linkLabel2.Text.Equals("View Bill's"))
                {
                    if (!pnlFormsMenu.Contains(viewDealerBill))
                    {
                        viewDealerBill = new frmSalesViewBill();
                        viewDealerBill.TopLevel = false;
                        viewDealerBill.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(viewDealerBill);
                        viewDealerBill.Show();
                        viewDealerBill.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (linkLabel3.Text.Equals("Create Order's Bill"))
                {
                    if (!pnlFormsMenu.Contains(createOrderBill))
                    {
                        createOrderBill = new salesPostedOrderBill();
                        createOrderBill.TopLevel = false;
                        createOrderBill.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(createOrderBill);
                        createOrderBill.Show();
                        createOrderBill.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel3.Text.Equals("View By Sub-Dealer"))
                {
                    if (!pnlFormsMenu.Contains(viewUnpostedOrder))
                    {
                        viewUnpostedOrder = new salesViewUnPostedOrder();
                        viewUnpostedOrder.TopLevel = false;
                        viewUnpostedOrder.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(viewUnpostedOrder);
                        viewUnpostedOrder.Show();
                        viewUnpostedOrder.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel3.Text.Equals("Empty Bill"))
                {
                    if (!pnlFormsMenu.Contains(createEmptyBill))
                    {
                        createEmptyBill = new salesFrmEmptyBill();
                        //createEmptyBill.TopLevel = false;
                        //createEmptyBill.Dock = DockStyle.Fill;
                        //pnlFormsMenu.Controls.Add(createEmptyBill);
                        createEmptyBill.Show();
                        createEmptyBill.BringToFront();
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
                else if (linkLabel3.Text.Equals("By Gate Pass"))
                {
                    if (!pnlFormsMenu.Contains(delChalGP))
                    {
                        delChalGP = new salesViewDelChalGP();
                        delChalGP.TopLevel = false;
                        delChalGP.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(delChalGP);
                        delChalGP.Show();
                        delChalGP.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //=====objects used by fourth label option in sub menu
        frmAddAddress addAddress;
        rptFrmLetterHead letterHead;
        frmOutwardGatePass outwardGP;
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
                else if (linkLabel4.Text.Equals("Letter Head"))
                {
                    if (!pnlFormsMenu.Contains(letterHead))
                    {
                        letterHead = new rptFrmLetterHead();
                        letterHead.getReport();
                        //letterHead.TopLevel = false;
                        //letterHead.Dock = DockStyle.Fill;
                        //pnlFormsMenu.Controls.Add(letterHead);
                        letterHead.Show();
                        letterHead.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //=====objects used by fifth label option in sub menu
        frmAddContact addContact;
        frmSalesViewBill viewDealerBill;
        frmViewOutwardgatepass viewOutwardGP;
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
                
                //else if (linkLabel5.Text.Equals("View Bill's"))
                //{
                //    if (!pnlFormsMenu.Contains(viewDealerBill))
                //    {
                //        viewDealerBill = new frmSalesViewBill();
                //        viewDealerBill.TopLevel = false;
                //        viewDealerBill.Dock = DockStyle.Fill;
                //        pnlFormsMenu.Controls.Add(viewDealerBill);
                //        viewDealerBill.Show();
                //        viewDealerBill.BringToFront();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //}
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                if (linkLabel1.Text.Equals("Manage Sub-Dealer"))
                {
                    if (!pnlFormsMenu.Contains(manageSubDealer))
                    {
                        manageSubDealer = new salesAddSubDealer();
                        manageSubDealer.TopLevel = false;
                        manageSubDealer.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(manageSubDealer);
                        manageSubDealer.Show();
                        manageSubDealer.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel1.Text.Equals("Outward GatePass"))
                {
                    if (!pnlFormsMenu.Contains(outwardGP))
                    {
                        outwardGP = new frmOutwardGatePass();
                        outwardGP.TopLevel = false;
                        outwardGP.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(outwardGP);
                        outwardGP.Show();
                        outwardGP.BringToFront();
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
                else if (linkLabel1.Text.Equals("Manage Goods Company"))
                {
                    if (!pnlFormsMenu.Contains(manageGoodsCompany))
                    {
                        manageGoodsCompany = new SalesGoodsTransportCompany();
                        manageGoodsCompany.TopLevel = false;
                        manageGoodsCompany.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(manageGoodsCompany);
                        manageGoodsCompany.Show();
                        manageGoodsCompany.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel1.Text.Equals("Add Order"))
                {
                    if (!pnlFormsMenu.Contains(addOrder))
                    {
                        addOrder = new salesAddOrder();
                        addOrder.TopLevel = false;
                        addOrder.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(addOrder);
                        addOrder.Show();
                        addOrder.BringToFront();
                        //addNewPerson.Focus=true;
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel1.Text.Equals("Create New Challan"))
                {
                    if (!pnlFormsMenu.Contains(createNewChallan))
                    {
                        createNewChallan = new salesDeliveryChallan();
                        createNewChallan.TopLevel = false;
                        createNewChallan.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(createNewChallan);
                        createNewChallan.Show();
                        createNewChallan.BringToFront();
                        //addNewPerson.Focus=true;
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel1.Text.Equals("Add Posted Order's"))
                {
                    if (!pnlFormsMenu.Contains(addPostedOrder))
                    {
                        addPostedOrder = new salesPostOrder();
                        addPostedOrder.TopLevel = false;
                        addPostedOrder.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(addPostedOrder);
                        addPostedOrder.Show();
                        addPostedOrder.BringToFront();
                        //addNewPerson.Focus=true;
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel1.Text.Equals("By Delivery Challan"))
                {
                    if (!pnlFormsMenu.Contains(createBillByGatepass))
                    {
                        createBillByGatepass = new salesCreateBillByGatePass();
                        createBillByGatepass.TopLevel = false;
                        createBillByGatepass.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(createBillByGatepass);
                        createBillByGatepass.Show();
                        createBillByGatepass.BringToFront();
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
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogin_Click(this, e);
            }
        }
        //----------------------------------------------------------------------------------------------------------------------
    }
}
