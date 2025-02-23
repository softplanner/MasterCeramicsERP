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
    public partial class frmMain : Form
    {
        UserDAL userDAL = new UserDAL();
        string userType = null,userName=null;
        int check = 0;
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            timerAlarmAboutRawStock.Enabled = true;
            hideTimeComponents();
            lblReminder.Visible = false;
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
            lblLoginMain.Visible = true;
            lblExit.Visible = true;
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
            lblExit.Visible = false;
            lblLoginMain.Visible = false;
        }
        //====end 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ////-----update counter()
                //userDAL.updateCounter();
                ////-----end
                //if (userDAL.checkSecurity().Equals(false))
                //{
                //if (DateTime.Today.Day == 19)
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
                            lblReminder.Visible = true;
                            userName = txtName.Text;
                            userType = userDAL.getUserType(userName);
                            if (userDAL.getUserType(txtName.Text).Equals("Administrator"))
                            {
                                pbxUser.Enabled = true;
                            }
                            else
                            {
                                pbxUser.Enabled = false;
                            }
                            //=====login user name show
                            lblLoginUserName.Visible = true;
                            lblLoginUserName.Text = txtName.Text;
                            //end login name show
                            check = 1;
                            HideLoginCompponents();
                            pnlFormsMenu.Enabled = true;
                            pnlMainMenu.Enabled = true;
                            lblLogout.Visible = true;
                            pbxLogout.Visible = true;
                            lblSlogan.ForeColor = Color.Red;
                            lblSlogans.ForeColor = Color.Red;
                            lblCompanyName.ForeColor = Color.Red;
                            lblCompanyNames.ForeColor = Color.Red;
                            //-----
                            pbxOilInspection.Enabled = false;
                            //pbxGeneralReports.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                //}
                //else
                //{
                //    MessageBox.Show("Daikho yeh sab yahaan nahi chalay ga.....","Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                //}
                //}
                //else
                //{
                //    this.Close();
                //}
            }
            catch (Exception s)
            {
                MessageBox.Show(s.ToString()+"Server connection error...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //=====objects used by first label option in sub menu
        frmAddNewUser addNewUser;
        frmAddNewPerson addNewPerson;
        frmAddRawMaterial addRawMaterial;
        frmAddBarmil addBarmil;
        frmGreenWareMoldCasting moldCasting;
        frmOilInspection oilInspection;
        frmDailyGlazingReport dailyGlazingReport;
        frmDailyKillenReport dailyKillenReport;
        frmCompanyItemStock itemStock;
        frmMoldReceiveRecord moldReceiveRecord;
        frmCalculateSlipFromItems calculateSlipFromItems;
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
                else if (linkLabel1.Text.Equals("Add New Raw Material"))
                {
                    if (!pnlFormsMenu.Contains(addRawMaterial))
                    {
                        addRawMaterial = new frmAddRawMaterial();
                        addRawMaterial.TopLevel = false;
                        addRawMaterial.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(addRawMaterial);
                        addRawMaterial.Show();
                        addRawMaterial.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (linkLabel1.Text.Equals("Add And Update BallMill"))
                {
                    if (!pnlFormsMenu.Contains(addBarmil))
                    {
                        addBarmil = new frmAddBarmil();
                        addBarmil.TopLevel = false;
                        addBarmil.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(addBarmil);
                        addBarmil.Show();
                        addBarmil.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel1.Text.Equals("Daily Report"))
                {
                    if (!pnlFormsMenu.Contains(moldCasting))
                    {
                        moldCasting = new frmGreenWareMoldCasting();
                        moldCasting.TopLevel = false;
                        moldCasting.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(moldCasting);
                        moldCasting.Show();
                        moldCasting.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel1.Text.Equals("Add Report"))
                {
                    if (!pnlFormsMenu.Contains(oilInspection))
                    {
                        oilInspection = new frmOilInspection();
                        oilInspection.TopLevel = false;
                        oilInspection.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(oilInspection);
                        oilInspection.Show();
                        oilInspection.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel1.Text.Equals("Daily Glazing Report"))
                {
                    if (!pnlFormsMenu.Contains(dailyGlazingReport))
                    {
                        dailyGlazingReport = new frmDailyGlazingReport();
                        dailyGlazingReport.TopLevel = false;
                        dailyGlazingReport.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(dailyGlazingReport);
                        dailyGlazingReport.Show();
                        dailyGlazingReport.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel1.Text.Equals("Daily Killen Report"))
                {
                    if (!pnlFormsMenu.Contains(dailyKillenReport))
                    {
                        dailyKillenReport = new frmDailyKillenReport();
                        dailyKillenReport.TopLevel = false;
                        dailyKillenReport.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(dailyKillenReport);
                        dailyKillenReport.Show();
                        dailyKillenReport.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel1.Text.Equals("Item Stock"))
                {
                    if (!pnlFormsMenu.Contains(itemStock))
                    {
                        itemStock = new frmCompanyItemStock();
                        itemStock.TopLevel = false;
                        itemStock.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(itemStock);
                        itemStock.Show();
                        itemStock.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel1.Text.Equals("Mould Register Record"))
                {
                    if (!pnlFormsMenu.Contains(moldReceiveRecord))
                    {
                        moldReceiveRecord = new frmMoldReceiveRecord();
                        moldReceiveRecord.TopLevel = false;
                        moldReceiveRecord.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(moldReceiveRecord);
                        moldReceiveRecord.Show();
                        moldReceiveRecord.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel1.Text.Equals("Calculate Slip From Items"))
                {
                    if (!pnlFormsMenu.Contains(calculateSlipFromItems))
                    {
                        calculateSlipFromItems = new frmCalculateSlipFromItems();
                        calculateSlipFromItems.TopLevel = false;
                        calculateSlipFromItems.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(calculateSlipFromItems);
                        calculateSlipFromItems.Show();
                        calculateSlipFromItems.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        //=====objects used by second label option in sub menu
        frmSearchPerson searchPerson;
        frmRawMaterialReport rawMaterialReport;
        frmbarmilLoadInfo barmilLoadInfo;
        frmGreenWareMoldCastingShow updateMoldCasting;
        frmOilInspectionShow updateOilInspectionReport;
        frmShowDailyGlazingReport updateDailyGlazingReport;
        frmDailyKillenReportShow updateDailyKillenReport;
        frmMoldReceiveRecordShow updateMoldReceiveRecord;
        frmCalculateSlipPecentege calculateSlipPecentage;
        frmUpdateItemStock updateItemStock;
        
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
                    //msgFrm.BringToFront();
                    //msgFrm.TopMost = true;
                    //msgFrm.Activate();
                }
                else
                {
                    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (linkLabel2.Text.Equals("Update Stock Report"))
            {
                if (!pnlFormsMenu.Contains(updateRawMaterialStock))
                {
                    updateRawMaterialStock = new frmRawMaterialStock();
                    updateRawMaterialStock.TopLevel = false;
                    updateRawMaterialStock.Dock = DockStyle.Fill;
                    pnlFormsMenu.Controls.Add(updateRawMaterialStock);
                    updateRawMaterialStock.Show();
                    updateRawMaterialStock.BringToFront();
                }
                else
                {
                    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //else if(linkLabel2.Text.Equals("Purchase Report"))
            //{
            //    if (!pnlFormsMenu.Contains(rawMaterialReport))
            //    {
            //        rawMaterialReport= new frmRawMaterialReport();
            //        rawMaterialReport.TopLevel = false;
            //        rawMaterialReport.Dock = DockStyle.Fill;
            //        pnlFormsMenu.Controls.Add(rawMaterialReport);
            //        rawMaterialReport.Show();
            //        rawMaterialReport.BringToFront();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            else if(linkLabel2.Text.Equals("Load or Unload Ballmill"))
            {
                if (!pnlFormsMenu.Contains(barmilLoadInfo))
                {
                    barmilLoadInfo = new frmbarmilLoadInfo();
                    barmilLoadInfo.TopLevel = false;
                    barmilLoadInfo.Dock = DockStyle.Fill;
                    pnlFormsMenu.Controls.Add(barmilLoadInfo);
                    barmilLoadInfo.Show();
                    barmilLoadInfo.BringToFront();
                }
                else
                {
                    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(linkLabel2.Text.Equals("View Report"))
            {
                if (!pnlFormsMenu.Contains(updateMoldCasting))
                {
                    updateMoldCasting = new frmGreenWareMoldCastingShow();
                    updateMoldCasting.TopLevel = false;
                    updateMoldCasting.Dock = DockStyle.Fill;
                    pnlFormsMenu.Controls.Add(updateMoldCasting);
                    updateMoldCasting.Show();
                    updateMoldCasting.BringToFront();
                }
                else
                {
                    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(linkLabel2.Text.Equals("Update Daily Glazing Report"))
            {
                if (!pnlFormsMenu.Contains(updateDailyGlazingReport))
                {
                    updateDailyGlazingReport = new frmShowDailyGlazingReport();
                    updateDailyGlazingReport.TopLevel = false;
                    updateDailyGlazingReport.Dock = DockStyle.Fill;
                    pnlFormsMenu.Controls.Add(updateDailyGlazingReport);
                    updateDailyGlazingReport.Show();
                    updateDailyGlazingReport.BringToFront();
                }
                else
                {
                    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(linkLabel2.Text.Equals("Update Daily Killen Report"))
            {
                if (!pnlFormsMenu.Contains(updateDailyKillenReport))
                {
                    updateDailyKillenReport = new frmDailyKillenReportShow();
                    updateDailyKillenReport.TopLevel = false;
                    updateDailyKillenReport.Dock = DockStyle.Fill;
                    pnlFormsMenu.Controls.Add(updateDailyKillenReport);
                    updateDailyKillenReport.Show();
                    updateDailyKillenReport.BringToFront();
                }
                else
                {
                    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(linkLabel2.Text.Equals("Update Mould Register Record"))
            {
                if (!pnlFormsMenu.Contains(updateMoldReceiveRecord))
                {
                    updateMoldReceiveRecord = new frmMoldReceiveRecordShow();
                    updateMoldReceiveRecord.TopLevel = false;
                    updateMoldReceiveRecord.Dock = DockStyle.Fill;
                    pnlFormsMenu.Controls.Add(updateMoldReceiveRecord);
                    updateMoldReceiveRecord.Show();
                    updateMoldReceiveRecord.BringToFront();
                }
                else
                {
                    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(linkLabel2.Text.Equals("Update Item Stock"))
            {
                if (!pnlFormsMenu.Contains(updateItemStock))
                {
                    updateItemStock = new frmUpdateItemStock();
                    updateItemStock.TopLevel = false;
                    updateItemStock.Dock = DockStyle.Fill;
                    pnlFormsMenu.Controls.Add(updateItemStock);
                    updateItemStock.Show();
                    updateItemStock.BringToFront();
                }
                else
                {
                    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(linkLabel2.Text.Equals("Calculate Material Amount"))
            {
                if (!pnlFormsMenu.Contains(calculateSlipPecentage))
                {
                    calculateSlipPecentage = new frmCalculateSlipPecentege();
                    calculateSlipPecentage.TopLevel = false;
                    calculateSlipPecentage.Dock = DockStyle.Fill;
                    pnlFormsMenu.Controls.Add(calculateSlipPecentage);
                    calculateSlipPecentage.Show();
                    calculateSlipPecentage.BringToFront();
                }
                else
                {
                    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(linkLabel2.Text.Equals("Update Report"))
            {
                if (!pnlFormsMenu.Contains(updateOilInspectionReport))
                {
                    updateOilInspectionReport = new frmOilInspectionShow();
                    updateOilInspectionReport.TopLevel = false;
                    updateOilInspectionReport.Dock = DockStyle.Fill;
                    pnlFormsMenu.Controls.Add(updateOilInspectionReport);
                    updateOilInspectionReport.Show();
                    updateOilInspectionReport.BringToFront();
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
        //=====objects used by third label option in sub menu
        frmAddJobs addJob;
        frmRawMaterialReportShow updatePurchaseReport;
        frmGreenWareWorkerStock casterMoldStock;
        frmGlazedItemBreakage glazedItemBreakage;
        frmKillenFeed killenFeed;
        frmMoldIssueRecord moldIssueReport;
        frmItemEstimationFromSlip itemEstimationFromSlip;
        frmAddItem addItem;
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
                else if (linkLabel3.Text.Equals("Add/Update Item"))
                {
                    if (!pnlFormsMenu.Contains(addItem))
                    {
                        addItem = new frmAddItem();
                        addItem.TopLevel = false;
                        addItem.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(addItem);
                        addItem.Show();
                        addItem.BringToFront();
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
                //else if (linkLabel3.Text.Equals("Update Purchase Report"))
                //{
                //    if (!pnlFormsMenu.Contains(updatePurchaseReport))
                //    {
                //        updatePurchaseReport = new frmRawMaterialReportShow();
                //        updatePurchaseReport.TopLevel = false;
                //        updatePurchaseReport.Dock = DockStyle.Fill;
                //        pnlFormsMenu.Controls.Add(updatePurchaseReport);
                //        updatePurchaseReport.Show();
                //        updatePurchaseReport.BringToFront();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //}
                else if (linkLabel3.Text.Equals("Manage Caster's Mould"))
                {
                    if (!pnlFormsMenu.Contains(casterMoldStock))
                    {
                        casterMoldStock = new frmGreenWareWorkerStock();
                        casterMoldStock.TopLevel = false;
                        casterMoldStock.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(casterMoldStock);
                        casterMoldStock.Show();
                        casterMoldStock.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel3.Text.Equals("Glazed Item Breakage"))
                {
                    if (!pnlFormsMenu.Contains(glazedItemBreakage))
                    {
                        glazedItemBreakage = new frmGlazedItemBreakage();
                        glazedItemBreakage.TopLevel = false;
                        glazedItemBreakage.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(glazedItemBreakage);
                        glazedItemBreakage.Show();
                        glazedItemBreakage.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel3.Text.Equals("Killen Feed Report"))
                {
                    if (!pnlFormsMenu.Contains(killenFeed))
                    {
                        killenFeed = new frmKillenFeed();
                        killenFeed.TopLevel = false;
                        killenFeed.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(killenFeed);
                        killenFeed.Show();
                        killenFeed.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel3.Text.Equals("Mold Issue Report"))
                {
                    if (!pnlFormsMenu.Contains(moldIssueReport))
                    {
                        moldIssueReport = new frmMoldIssueRecord();
                        moldIssueReport.TopLevel = false;
                        moldIssueReport.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(moldIssueReport);
                        moldIssueReport.Show();
                        moldIssueReport.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel3.Text.Equals("Show Company Stock"))
                {
                    if (!pnlFormsMenu.Contains(companyMoldStock))
                    {
                        companyMoldStock = new frmCompanyMoldStock();
                        companyMoldStock.TopLevel = false;
                        companyMoldStock.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(companyMoldStock);
                        companyMoldStock.Show();
                        companyMoldStock.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel3.Text.Equals("Item Estimation From Slip"))
                {
                    if (!pnlFormsMenu.Contains(itemEstimationFromSlip))
                    {
                        itemEstimationFromSlip = new frmItemEstimationFromSlip();
                        itemEstimationFromSlip.TopLevel = false;
                        itemEstimationFromSlip.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(itemEstimationFromSlip);
                        itemEstimationFromSlip.Show();
                        itemEstimationFromSlip.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        //=====objects used by fourth label option in sub menu
        frmAddAddress addAddress;
        frmRawMaterialStock updateRawMaterialStock;
        frmGreenWareItemChecking greenwareItemChecking;
        frmGlazedItemBreakageShow updateGlazedItemBreakage;
        frmKillenFeedShow updateKillenFeedReport;
        frmMoldIssueRecordShow updateMoldIssuedReport;
        frmSlipPercentageInfo slipPercentageInfo;
        frmAddStyle addStyle;
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
                else if (linkLabel4.Text.Equals("Add/Update Style"))
                {
                    if (!pnlFormsMenu.Contains(addAddress))
                    {
                        addStyle = new frmAddStyle();
                        addStyle.TopLevel = false;
                        addStyle.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(addStyle);
                        addStyle.Show();
                        addStyle.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                //else if (linkLabel4.Text.Equals("Update Stock Report"))
                //{
                //    if (!pnlFormsMenu.Contains(updateRawMaterialStock))
                //    {
                //        updateRawMaterialStock = new frmRawMaterialStock();
                //        updateRawMaterialStock.TopLevel = false;
                //        updateRawMaterialStock.Dock = DockStyle.Fill;
                //        pnlFormsMenu.Controls.Add(updateRawMaterialStock);
                //        updateRawMaterialStock.Show();
                //        updateRawMaterialStock.BringToFront();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //}
                else if (linkLabel4.Text.Equals("Item Checking"))
                {
                    if (!pnlFormsMenu.Contains(greenwareItemChecking))
                    {
                        greenwareItemChecking = new frmGreenWareItemChecking();
                        greenwareItemChecking.TopLevel = false;
                        greenwareItemChecking.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(greenwareItemChecking);
                        greenwareItemChecking.Show();
                        greenwareItemChecking.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel4.Text.Equals("Update Glazed Item Breakage"))
                {
                    if (!pnlFormsMenu.Contains(updateGlazedItemBreakage))
                    {
                        updateGlazedItemBreakage = new frmGlazedItemBreakageShow();
                        updateGlazedItemBreakage.TopLevel = false;
                        updateGlazedItemBreakage.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(updateGlazedItemBreakage);
                        updateGlazedItemBreakage.Show();
                        updateGlazedItemBreakage.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel4.Text.Equals("Update Killen Feed Report"))
                {
                    if (!pnlFormsMenu.Contains(updateKillenFeedReport))
                    {
                        updateKillenFeedReport = new frmKillenFeedShow();
                        updateKillenFeedReport.TopLevel = false;
                        updateKillenFeedReport.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(updateKillenFeedReport);
                        updateKillenFeedReport.Show();
                        updateKillenFeedReport.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel4.Text.Equals("Update Mold Issued Report"))
                {
                    if (!pnlFormsMenu.Contains(updateMoldIssuedReport))
                    {
                        updateMoldIssuedReport = new frmMoldIssueRecordShow();
                        updateMoldIssuedReport.TopLevel = false;
                        updateMoldIssuedReport.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(updateMoldIssuedReport);
                        updateMoldIssuedReport.Show();
                        updateMoldIssuedReport.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel4.Text.Equals("Slip Percentage Info"))
                {
                    if (!pnlFormsMenu.Contains(slipPercentageInfo))
                    {
                        slipPercentageInfo = new frmSlipPercentageInfo();
                        slipPercentageInfo.TopLevel = false;
                        slipPercentageInfo.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(slipPercentageInfo);
                        slipPercentageInfo.Show();
                        slipPercentageInfo.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        //=====objects used by fifth label option in sub menu
        frmAddContact addContact;
        frmGreenWareItemCheckingShow updateGreenwareItemChecking;
        frmMoldBreakage moldBreakage;
        frmUpdateSlipPercentage updateSlipPercentage;
        frmAddGlazeHouse addGlazedHouse;
        frmAddKillen addKillen;
        frmAddItemWeight addItemWeight;
        frmAddItemSize itemSize;
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (linkLabel5.Text.Equals("Add/Update Killen"))
                {
                    if (!pnlFormsMenu.Contains(addKillen))
                    {
                        addKillen = new frmAddKillen();
                        addKillen.TopLevel = false;
                        addKillen.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(addKillen);
                        addKillen.Show();
                        addKillen.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel5.Text.Equals("Add/Update Size"))
                {
                    if (!pnlFormsMenu.Contains(itemSize))
                    {
                        itemSize = new frmAddItemSize();
                        itemSize.TopLevel = false;
                        itemSize.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(itemSize);
                        itemSize.Show();
                        itemSize.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel5.Text.Equals("Add/Update Glaze House"))
                {
                    if (!pnlFormsMenu.Contains(addGlazedHouse))
                    {
                        addGlazedHouse = new frmAddGlazeHouse();
                        addGlazedHouse.TopLevel = false;
                        addGlazedHouse.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(addGlazedHouse);
                        addGlazedHouse.Show();
                        addGlazedHouse.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel5.Text.Equals("Update Slip Percentage"))
                {
                    if (!pnlFormsMenu.Contains(updateSlipPercentage))
                    {
                        updateSlipPercentage = new frmUpdateSlipPercentage();
                        updateSlipPercentage.TopLevel = false;
                        updateSlipPercentage.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(updateSlipPercentage);
                        updateSlipPercentage.Show();
                        updateSlipPercentage.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel5.Text.Equals("Add Person Contact"))
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
                else if (linkLabel5.Text.Equals("Update Item Checking"))
                {
                    if (!pnlFormsMenu.Contains(updateGreenwareItemChecking))
                    {
                        updateGreenwareItemChecking = new frmGreenWareItemCheckingShow();
                        updateGreenwareItemChecking.TopLevel = false;
                        updateGreenwareItemChecking.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(updateGreenwareItemChecking);
                        updateGreenwareItemChecking.Show();
                        updateGreenwareItemChecking.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel5.Text.Equals("Mold Breakage Report"))
                {
                    if (!pnlFormsMenu.Contains(moldBreakage))
                    {
                        moldBreakage = new frmMoldBreakage();
                        moldBreakage.TopLevel = false;
                        moldBreakage.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(moldBreakage);
                        moldBreakage.Show();
                        moldBreakage.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        //=====objects used by sixth label option in sub menu
        frmAddCountry addCountry;
        frmUnGlazeItemBreakage unglazeItemBreakage;
        frmMoldBreakageShow updateMoldBreakage;
        frmManageItemStock manageItemStock;
        frmSlipMaterial slipMaterial;
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
                else if (linkLabel6.Text.Equals("Add/Update Item Weight"))
                {
                    if (!pnlFormsMenu.Contains(addItemWeight))
                    {
                        addItemWeight = new frmAddItemWeight();
                        addItemWeight.TopLevel = false;
                        addItemWeight.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(addItemWeight);
                        addItemWeight.Show();
                        addItemWeight.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel6.Text.Equals("Manage Slip Material"))
                {
                    if (!pnlFormsMenu.Contains(slipMaterial))
                    {
                        slipMaterial = new frmSlipMaterial();
                        slipMaterial.TopLevel = false;
                        slipMaterial.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(slipMaterial);
                        slipMaterial.Show();
                        slipMaterial.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel6.Text.Equals("Item Breakage Report"))
                {
                    if (!pnlFormsMenu.Contains(unglazeItemBreakage))
                    {
                        unglazeItemBreakage = new frmUnGlazeItemBreakage();
                        unglazeItemBreakage.TopLevel = false;
                        unglazeItemBreakage.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(unglazeItemBreakage);
                        unglazeItemBreakage.Show();
                        unglazeItemBreakage.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel6.Text.Equals("Update Mold Breakage Report"))
                {
                    if (!pnlFormsMenu.Contains(updateMoldBreakage))
                    {
                        updateMoldBreakage = new frmMoldBreakageShow();
                        updateMoldBreakage.TopLevel = false;
                        updateMoldBreakage.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(updateMoldBreakage);
                        updateMoldBreakage.Show();
                        updateMoldBreakage.BringToFront();
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
        frmUnglazeItemBreakageShow updateUnglazeItemBreakage;
        frmCompanyMoldStock companyMoldStock;
        frmRemarks remarks;
        frmAddItemRate itemRate;
        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (linkLabel7.Text.Equals("Item Price"))
                {
                    if (!pnlFormsMenu.Contains(itemRate))
                    {
                        itemRate = new frmAddItemRate();
                        itemRate.TopLevel = false;
                        itemRate.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(itemRate);
                        itemRate.Show();
                        itemRate.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel7.Text.Equals("Add Province"))
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
                else if (linkLabel7.Text.Equals("Manage Stock"))
                {
                    if (!pnlFormsMenu.Contains(manageItemStock))
                    {
                        manageItemStock = new frmManageItemStock();
                        manageItemStock.TopLevel = false;
                        manageItemStock.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(manageItemStock);
                        manageItemStock.Show();
                        manageItemStock.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel7.Text.Equals("Update Item Breakage Report"))
                {
                    if (!pnlFormsMenu.Contains(updateUnglazeItemBreakage))
                    {
                        updateUnglazeItemBreakage = new frmUnglazeItemBreakageShow();
                        updateUnglazeItemBreakage.TopLevel = false;
                        updateUnglazeItemBreakage.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(updateUnglazeItemBreakage);
                        updateUnglazeItemBreakage.Show();
                        updateUnglazeItemBreakage.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (linkLabel7.Text.Equals("Manage Remarks"))
                {
                    if (!pnlFormsMenu.Contains(manageItemStock))
                    {
                        remarks = new frmRemarks();
                        remarks.TopLevel = false;
                        remarks.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(remarks);
                        remarks.Show();
                        remarks.BringToFront();
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
        frmColorManager colorManager;
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
                else if (linkLabel8.Text.Equals("Manage Color"))
                {
                    if (!pnlFormsMenu.Contains(colorManager))
                    {
                        colorManager = new frmColorManager();
                        colorManager.TopLevel = false;
                        colorManager.Dock = DockStyle.Fill;
                        pnlFormsMenu.Controls.Add(colorManager);
                        colorManager.Show();
                        colorManager.BringToFront();
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

        private void pbxPerson_Click(object sender, EventArgs e)
        {
            //====================================================
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.Indigo;
            linkLabel2.LinkColor = Color.Indigo;
            linkLabel3.LinkColor = Color.Indigo;
            /*linkLabel4.LinkColor = Color.Indigo;
            linkLabel5.LinkColor = Color.Indigo;
            linkLabel6.LinkColor = Color.Indigo;
            linkLabel7.LinkColor = Color.Indigo;
            linkLabel8.LinkColor = Color.Indigo;*/
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
            //linkLabel4.Text = "Add Person Address";
            //linkLabel5.Text = "Add Person Contact";
            //linkLabel6.Text = "Add Country";
            //linkLabel7.Text = "Add Province";
            //linkLabel8.Text = "Add City";
        }

        private void pbxRawMaterial_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.DarkGoldenrod;
            linkLabel2.LinkColor = Color.DarkGoldenrod;
            //linkLabel3.LinkColor = Color.DarkGoldenrod;
            //linkLabel4.LinkColor = Color.DarkGoldenrod;
            //linkLabel5.LinkColor = Color.DarkGoldenrod;
            lblSlogans.ForeColor = Color.DarkGoldenrod;
            lblSlogan.ForeColor = Color.DarkGoldenrod;
            lblHeading.ForeColor = Color.DarkGoldenrod;
            pnlMainMenu.BackColor = Color.DarkGoldenrod;
            lblCompanyName.ForeColor = Color.DarkGoldenrod;
            lblCompanyNames.ForeColor = Color.DarkGoldenrod;
            //====================================================
            lblHeading.Text = "Raw Material";
            linkLabel1.Text = "Add New Raw Material";
            //linkLabel2.Text = "Purchase Report";
            //linkLabel3.Text = "Update Purchase Report";
            linkLabel2.Text = "Update Stock Report";
        }

        private void pbxBarmilSection_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.Crimson;
            linkLabel2.LinkColor = Color.Crimson;
            lblSlogans.ForeColor = Color.Crimson;
            lblSlogan.ForeColor = Color.Crimson;
            lblHeading.ForeColor = Color.Crimson;
            pnlMainMenu.BackColor = Color.Crimson;
            lblCompanyName.ForeColor = Color.Crimson;
            lblCompanyNames.ForeColor = Color.Crimson;
            //====================================================
            lblHeading.Text = "BallMill";
            linkLabel1.Text = "Add And Update BallMill";
            linkLabel2.Text = "Load or Unload Ballmill";
        }

        private void pbxGreenWare_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.DarkGreen;
            linkLabel2.LinkColor = Color.DarkGreen;
            linkLabel3.LinkColor = Color.DarkGreen;
            //linkLabel4.LinkColor = Color.DarkGreen;
            //linkLabel5.LinkColor = Color.DarkGreen;
            //linkLabel6.LinkColor = Color.DarkGreen;
            //linkLabel7.LinkColor = Color.DarkGreen;
            lblSlogans.ForeColor = Color.DarkGreen;
            lblSlogan.ForeColor = Color.DarkGreen;
            lblHeading.ForeColor = Color.DarkGreen;
            pnlMainMenu.BackColor = Color.DarkGreen;
            lblCompanyName.ForeColor = Color.DarkGreen;
            lblCompanyNames.ForeColor = Color.DarkGreen;
            //====================================================
            lblHeading.Text = "GreenWare House";
            linkLabel1.Text = "Daily Report";
            linkLabel2.Text = "View Report";
            linkLabel3.Text = "Manage Caster's Mould";
            //linkLabel4.Text = "Item Checking";
            //linkLabel5.Text = "Update Item Checking";
            //linkLabel6.Text = "Item Breakage Report";
            //linkLabel7.Text = "Update Item Breakage Report";
        }

        private void pbxOilInspection_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.DarkViolet;
            linkLabel2.LinkColor = Color.DarkViolet;
            lblSlogans.ForeColor = Color.DarkViolet;
            lblSlogan.ForeColor = Color.DarkViolet;
            lblHeading.ForeColor = Color.DarkViolet;
            pnlMainMenu.BackColor = Color.DarkViolet;
            lblCompanyName.ForeColor = Color.DarkViolet;
            lblCompanyNames.ForeColor = Color.DarkViolet;
            //====================================================
            lblHeading.Text = "Oil Inspection";
            linkLabel1.Text = "Add Report";
            linkLabel2.Text = "Update Report";
        }

        private void pbxGlazeHouse_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.DarkMagenta;
            linkLabel2.LinkColor = Color.DarkMagenta;
            //linkLabel3.LinkColor = Color.DarkMagenta;
            //linkLabel4.LinkColor = Color.DarkMagenta;
            //linkLabel5.LinkColor = Color.DarkMagenta;
            lblSlogans.ForeColor = Color.DarkMagenta;
            lblSlogan.ForeColor = Color.DarkMagenta;
            lblHeading.ForeColor = Color.DarkMagenta;
            pnlMainMenu.BackColor = Color.DarkMagenta;
            lblCompanyName.ForeColor = Color.DarkMagenta;
            lblCompanyNames.ForeColor = Color.DarkMagenta;
            //====================================================
            lblHeading.Text = "Glaze House";
            linkLabel1.Text = "Daily Glazing Report";
            linkLabel2.Text = "Update Daily Glazing Report";
            //linkLabel3.Text = "Glazed Item Breakage";
            //linkLabel4.Text = "Update Glazed Item Breakage";
            //linkLabel5.Text = "Add/Update Glaze House";
        }

        private void pbxKillenReport_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.Firebrick;
            linkLabel2.LinkColor = Color.Firebrick;
            linkLabel3.LinkColor = Color.Firebrick;
            linkLabel4.LinkColor = Color.Firebrick;
            //linkLabel5.LinkColor = Color.Firebrick;
            lblSlogans.ForeColor = Color.Firebrick;
            lblSlogan.ForeColor = Color.Firebrick;
            lblHeading.ForeColor = Color.Firebrick;
            pnlMainMenu.BackColor = Color.Firebrick;
            lblCompanyName.ForeColor = Color.Firebrick;
            lblCompanyNames.ForeColor = Color.Firebrick;
            //====================================================
            lblHeading.Text = "Killen";
            linkLabel1.Text = "Daily Killen Report";
            linkLabel2.Text = "Update Daily Killen Report";
            linkLabel3.Text = "Killen Feed Report";
            linkLabel4.Text = "Update Killen Feed Report";
            //linkLabel5.Text = "Add/Update Killen";
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
            linkLabel6.LinkColor = Color.DarkSlateBlue;
            linkLabel7.LinkColor = Color.DarkSlateBlue;
            linkLabel8.LinkColor = Color.DarkSlateBlue;
            lblSlogans.ForeColor = Color.DarkSlateBlue;
            lblSlogan.ForeColor = Color.DarkSlateBlue;
            lblHeading.ForeColor = Color.DarkSlateBlue;
            pnlMainMenu.BackColor = Color.DarkSlateBlue;
            lblCompanyName.ForeColor = Color.DarkSlateBlue;
            lblCompanyNames.ForeColor = Color.DarkSlateBlue;
            //====================================================
            lblHeading.Text = "Stock";
            linkLabel1.Text = "Item Stock";
            linkLabel2.Text = "Update Item Stock";
            linkLabel3.Text = "Add/Update Item";
            linkLabel4.Text = "Add/Update Style";
            linkLabel5.Text = "Add/Update Size";
            linkLabel6.Text = "Add/Update Item Weight";
            linkLabel7.Text = "Item Price";
            linkLabel8.Text = "Manage Color";
        }

        private void pbxMold_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.Navy;
            linkLabel2.LinkColor = Color.Navy;
            linkLabel3.LinkColor = Color.Navy;
            //linkLabel4.LinkColor = Color.Navy;
            //linkLabel5.LinkColor = Color.Navy;
            //linkLabel6.LinkColor = Color.Navy;
            //linkLabel7.LinkColor = Color.Navy;
            lblSlogans.ForeColor = Color.Navy;
            lblSlogan.ForeColor = Color.Navy;
            lblHeading.ForeColor = Color.Navy;
            pnlMainMenu.BackColor = Color.Navy;
            lblCompanyName.ForeColor = Color.Navy;
            lblCompanyNames.ForeColor = Color.Navy;
            //====================================================
            lblHeading.Text = "Mould";
            linkLabel1.Text = "Mould Register Record";
            linkLabel2.Text = "Update Mould Register Record";
            linkLabel3.Text = "Show Company Stock";
            //linkLabel3.Text = "Mold Issue Report";
            //linkLabel4.Text = "Update Mold Issued Report";
            //linkLabel5.Text = "Mold Breakage Report";
            //linkLabel6.Text = "Update Mold Breakage Report";
            //linkLabel7.Text = "Show Company Stock";
        }

        private void pbxGeneralReports_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.SaddleBrown;
            linkLabel2.LinkColor = Color.SaddleBrown;
            linkLabel3.LinkColor = Color.SaddleBrown;
            linkLabel4.LinkColor = Color.SaddleBrown;
            linkLabel5.LinkColor = Color.SaddleBrown;
            linkLabel6.LinkColor = Color.SaddleBrown;
            //linkLabel7.LinkColor = Color.SaddleBrown;
            lblSlogans.ForeColor = Color.SaddleBrown;
            lblSlogan.ForeColor = Color.SaddleBrown;
            lblHeading.ForeColor = Color.SaddleBrown;
            pnlMainMenu.BackColor = Color.SaddleBrown;
            lblCompanyName.ForeColor = Color.SaddleBrown;
            lblCompanyNames.ForeColor = Color.SaddleBrown;
            //====================================================
            lblHeading.Text = "General Reports";
            linkLabel1.Text = "Calculate Slip From Items";
            linkLabel2.Text = "Calculate Material Amount";
            linkLabel3.Text = "Item Estimation From Slip";
            if (userType.Equals("Administrator"))
            {
                linkLabel4.Text = "Slip Percentage Info";
                linkLabel5.Text = "Update Slip Percentage";
                linkLabel6.Text = "Manage Slip Material";
                //linkLabel7.Text = "Manage Remarks";
            }
        }

        private void pbxUser_Click(object sender, EventArgs e)
        {
            //====================================================
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.Red;
            linkLabel2.LinkColor = Color.Red;
            linkLabel3.LinkColor = Color.Red;
            lblSlogans.ForeColor = Color.Red;
            lblSlogan.ForeColor = Color.Red;
            lblHeading.ForeColor = Color.Red;
            pnlMainMenu.BackColor = Color.Red;
            lblCompanyName.ForeColor = Color.Red;
            lblCompanyNames.ForeColor = Color.Red;
            //====================================================
            lblHeading.Text = "User";
            linkLabel1.Text = "Add New User";
            linkLabel2.Text = "Change Password";
            linkLabel3.Text = "Delete User";
        }

        private void pbxLogout_Click(object sender, EventArgs e)
        {
            check = 0;
            lblReminder.Visible = false;
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
            if (pnlFormsMenu.Contains(addNewUser))
            {
                addNewUser.Dispose();
            }
            if (pnlFormsMenu.Contains(slipPercentageInfo))
            {
                slipPercentageInfo.Dispose();
            }
            if (pnlFormsMenu.Contains(updateSlipPercentage))
            {
                updateSlipPercentage.Dispose();
            }
        }

        private void pbxPerson_MouseEnter(object sender, EventArgs e)
        {
            pbxPerson.Location = new Point(2,7);
            pbxPerson.Size = new Size(83,51);
        }

        private void pbxPerson_MouseLeave(object sender, EventArgs e)
        {
            pbxPerson.Location = new Point(22,22);
            pbxPerson.Size = new Size(54,29);
        }

        private void pbxRawMaterial_MouseEnter(object sender, EventArgs e)
        {
            pbxRawMaterial.Location = new Point(101, 7);
            pbxRawMaterial.Size = new Size(83,51);
        }

        private void pbxRawMaterial_MouseLeave(object sender, EventArgs e)
        {
            pbxRawMaterial.Location = new Point(111, 22);
            pbxRawMaterial.Size = new Size(54,29);
        }

        private void pbxBarmilSection_MouseEnter(object sender, EventArgs e)
        {
            pbxBarmilSection.Location = new Point(188, 7);
            pbxBarmilSection.Size = new Size(83,51);
        }

        private void pbxBarmilSection_MouseLeave(object sender, EventArgs e)
        {
            pbxBarmilSection.Location = new Point(198, 22);
            pbxBarmilSection.Size = new Size(54,29);
        }

        private void pbxGreenWare_MouseEnter(object sender, EventArgs e)
        {
            pbxGreenWare.Location = new Point(279, 7);
            pbxGreenWare.Size = new Size(83,51);
        }

        private void pbxGreenWare_MouseLeave(object sender, EventArgs e)
        {
            pbxGreenWare.Location = new Point(289, 22);
            pbxGreenWare.Size = new Size(54,29);
        }

        private void pbxOilInspection_MouseEnter(object sender, EventArgs e)
        {
            pbxOilInspection.Location = new Point(370, 7);
            pbxOilInspection.Size = new Size(83,51);
        }

        private void pbxOilInspection_MouseLeave(object sender, EventArgs e)
        {
            pbxOilInspection.Location = new Point(380, 22);
            pbxOilInspection.Size = new Size(54,29);
        }

        private void pbxGlazeHouse_MouseEnter(object sender, EventArgs e)
        {
            pbxGlazeHouse.Location = new Point(461, 7);
            pbxGlazeHouse.Size = new Size(83,51);
        }

        private void pbxGlazeHouse_MouseLeave(object sender, EventArgs e)
        {
            pbxGlazeHouse.Location = new Point(471, 22);
            pbxGlazeHouse.Size = new Size(54, 29);
        }

        private void pbxKillenReport_MouseEnter(object sender, EventArgs e)
        {
            pbxKillenReport.Location = new Point(549, 7);
            pbxKillenReport.Size = new Size(83,51);
        }

        private void pbxKillenReport_MouseLeave(object sender, EventArgs e)
        {
            pbxKillenReport.Location = new Point(559, 22);
            pbxKillenReport.Size = new Size(54,29);
        }

        private void pbxCompanyItemStock_MouseEnter(object sender, EventArgs e)
        {
            pbxCompanyItemStock.Location = new Point(638, 7);
            pbxCompanyItemStock.Size = new Size(83,51);
        }

        private void pbxCompanyItemStock_MouseLeave(object sender, EventArgs e)
        {
            pbxCompanyItemStock.Location = new Point(648, 22);
            pbxCompanyItemStock.Size = new Size(54,29);
        }

        private void pbxMold_MouseEnter(object sender, EventArgs e)
        {
            pbxMold.Location = new Point(727, 7);
            pbxMold.Size = new Size(83,51);
        }

        private void pbxMold_MouseLeave(object sender, EventArgs e)
        {
            pbxMold.Location = new Point(737, 22);
            pbxMold.Size = new Size(54,29);
        }

        private void pbxGeneralReports_MouseEnter(object sender, EventArgs e)
        {
            pbxGeneralReports.Location = new Point(816, 7);
            pbxGeneralReports.Size = new Size(83,51);
        }

        private void pbxGeneralReports_MouseLeave(object sender, EventArgs e)
        {
            pbxGeneralReports.Location = new Point(826,22);
            pbxGeneralReports.Size = new Size(54,29);
        }

        private void pbxUser_MouseEnter(object sender, EventArgs e)
        {
            pbxUser.Location = new Point(905, 7);
            pbxUser.Size = new Size(83,51);
        }

        private void pbxUser_MouseLeave(object sender, EventArgs e)
        {
            pbxUser.Location = new Point(915, 22);
            pbxUser.Size = new Size(54,29);
        }

        private void pbxLogout_MouseEnter(object sender, EventArgs e)
        {
            pbxLogout.Location = new Point(101,440);
            pbxLogout.Size = new Size(60,47);
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
            linkLabel1.Font = new Font(fontFamily,10,fontStyle);
        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.Font = new Font(fontFamily, 8,fontStyle);
        }

        private void linkLabel2_MouseEnter(object sender, EventArgs e)
        {
            fontFamily = linkLabel2.Font.FontFamily;
            fontStyle = linkLabel2.Font.Style;
            linkLabel2.Font = new Font(fontFamily, 10,fontStyle);
        }

        private void linkLabel2_MouseLeave(object sender, EventArgs e)
        {
            linkLabel2.Font = new Font(fontFamily, 8,fontStyle);
        }

        private void linkLabel3_MouseEnter(object sender, EventArgs e)
        {
            fontFamily = linkLabel3.Font.FontFamily;
            fontStyle = linkLabel3.Font.Style;
            linkLabel3.Font = new Font(fontFamily, 10,fontStyle);
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
            linkLabel4.Font = new Font(fontFamily,8, fontStyle);
        }

        private void linkLabel5_MouseEnter(object sender, EventArgs e)
        {
            fontFamily = linkLabel5.Font.FontFamily;
            fontStyle = linkLabel5.Font.Style;
            linkLabel5.Font = new Font(fontFamily, 10, fontStyle);
        }

        private void linkLabel5_MouseLeave(object sender, EventArgs e)
        {
            linkLabel5.Font = new Font(fontFamily,8, fontStyle);
        }

        private void linkLabel6_MouseEnter(object sender, EventArgs e)
        {
            fontFamily = linkLabel6.Font.FontFamily;
            fontStyle = linkLabel6.Font.Style;
            linkLabel6.Font = new Font(fontFamily, 10, fontStyle);
        }

        private void linkLabel6_MouseLeave(object sender, EventArgs e)
        {
            linkLabel6.Font = new Font(fontFamily,8, fontStyle);
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
            linkLabel8.Font = new Font(fontFamily,8, fontStyle);
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
            if(check.Equals(1))
            {
                lblLoginMain.Visible = false;
            }
        }

        private void timerAlarmAboutRawStock_Tick(object sender, EventArgs e)
        {
            RawMaterialStockDAL dal = new RawMaterialStockDAL();
            if (dal.checkForStockAlarm().Equals(true))
            {
                frmAlarmAboutRawStock obj = new frmAlarmAboutRawStock();
                obj.Show();
                obj.BringToFront();
            }
        }
        private void hideTimeComponents()
        {
            lblTimer.Visible = false;
            txtTimeInterval.Visible = false;
            lblUnit.Visible = false;
            btnEnable.Visible = false;
            btnDisable.Visible = false;
            btnChangeTimesetting.Visible = false;
            btnReminderClose.Visible=false;
            lblLoginUserName.Visible = true;
            //---------------------------
            lblReminder.Visible = true;
            lblCompanyName.Visible = true;
            lblCompanyNames.Visible = true;
            pbxLogout.Visible = true;
            lblLogout.Visible = true;
            lblSlogan.Visible = true;
            lblSlogans.Visible = true;
            pbxMono.Visible = true;
            //-------------------------------
        }
        private void showTimeComponents() 
        {
            //---------------------------
            lblReminder.Visible = false;
            lblCompanyName.Visible = false;
            lblCompanyNames.Visible = false;
            pbxLogout.Visible = false;
            lblLogout.Visible = false;
            lblSlogan.Visible = false;
            lblSlogans.Visible = false;
            pbxMono.Visible = false;
            lblLoginUserName.Visible = false;
            //-------------------------------
            lblTimer.Visible = true;
            txtTimeInterval.Visible = true;
            lblUnit.Visible = true;
            btnEnable.Visible = true;
            btnDisable.Visible = true;
            btnChangeTimesetting.Visible = true;
            btnReminderClose.Visible = true;
        }
        private void lblReminder_Click(object sender, EventArgs e)
        {
            showTimeComponents();
        }

        private void btnReminderClose_Click(object sender, EventArgs e)
        {
            hideTimeComponents();
        }

        private void btnChangeTimesetting_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTimeInterval.Text.Equals(""))
                {
                    MessageBox.Show("Enter time in minutes eg 0.5, 0.7, 5, 7, 11 27.5 etc" ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    float time = Convert.ToSingle(txtTimeInterval.Text) * 60 * 1000;
                    timerAlarmAboutRawStock.Interval = Convert.ToInt32(time);
                    txtTimeInterval.Text = "";
                    MessageBox.Show("Reminder time has been changed...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { 
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            timerAlarmAboutRawStock.Enabled = true;
            MessageBox.Show("Reminder setting has been changed...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            timerAlarmAboutRawStock.Enabled = false;
            MessageBox.Show("Reminder setting has been changed...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblReminder_MouseEnter(object sender, EventArgs e)
        {
            lblReminder.Font = new Font(lblReminder.Font.FontFamily,9,FontStyle.Bold);
        }

        private void lblReminder_MouseLeave(object sender, EventArgs e)
        {
            lblReminder.Font = new Font(lblReminder.Font.FontFamily,8, FontStyle.Regular);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogin_Click(this,e);
            } 

        }
        //========================================================================================================================
    }
}
