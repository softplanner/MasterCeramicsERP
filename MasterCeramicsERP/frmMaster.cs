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
    public partial class frmMaster : Form
    {
        UserDAL userDAL = new UserDAL();
        string userType = null, userName = null;

        public frmMaster()
        {
            InitializeComponent();
        }

        private void frmMaster_Load(object sender, EventArgs e)
        {
            pnlMainMenuInventory.Visible = false;
            pnlMainMenuPayroll.Visible = false;
            pnlMainMenuSales.Visible = false;
            //=====login work
            lblUsernameInfo.Visible = false;
            lblPasswordInfo.Visible = false;
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
            btnLogin.Visible = true;
            btnReset.Visible = true;
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
        //=====logout defination
        //private void btnLogout_Click(object sender, EventArgs e)
        //{
        //    InvisibleLabel();
        //    showLoginCompponents();
        //    pnlFormsMenu.Enabled = false;
        //    pnlMainMenuInventory.Enabled = false;
        //    txtName.Text = "";
        //    txtPassword.Text = "";
        //}
        // end logout
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            try
            {
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
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
                    if (userDAL.getPassword(txtName.Text).Equals(txtPassword.Text))
                    {
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
                        //end login name show
                        HideLoginCompponents();
                        pnlFormsMenu.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid username/ passeord", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Connection with server reporting error.....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //=====objects used by first label In Payroll Application option in sub menu
        frmMarkAttendence markAttendence;
        frmWorkerLoan workerLoan;
        frmCasterPayment casterPayment;
        frmDailyWages dailyWages;
        frmMonthlySalary monthlySalary;
        //=====objects used by first label In sales Application option in sub menu
        salesAddSubDealer manageSubDealer;
        SalesGoodsTransportCompany manageGoodsCompany;
        salesAddOrder addOrder;
        salesDeliveryChallan createNewChallan;
        salesPostOrder addPostedOrder;
        salesCreateBillByGatePass createBillByGatepass;
        //=====objects used by second label option in sub menu
        salesViewUnpostedOrderByDealer viewUnpostedOrderByDealer;
        salesViewDeliveryChallan viewDeliveryChallan;
        salesViewPostedOrder viewPostedOrder;
        salesCreateBill createBill;
        //=====objects used by third label option in sub menu
        salesViewUnPostedOrder viewUnpostedOrder;
        salesFrmEmptyBill createEmptyBill;
        salesPostedOrderBill createOrderBill;

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
                else if (linkLabel1.Text.Equals("Add And Update Ball Mill"))
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
                else if (linkLabel1.Text.Equals("Mold Casting"))
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
                else if (linkLabel1.Text.Equals("Mold Receive Report"))
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
                //-----payroll
                else if (linkLabel1.Text.Equals("Mark Attendence"))
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
                //--end payroll
                //-----sales
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
                //---end sales
                }
            catch
            {
                MessageBox.Show("Connection Error.....while connecting to server","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
        //=====objects used by second label payroll application option in sub menu
        frmViewAttendenceRecord viewAttendece;
        frmUpdateLoanReport updateLoan;
        frmUpdateCasterReport updateCaster;
        frmUpdateMonthlySalary updateMonthlySalary;
        frmUpdateDailyWages updateDailyWages;
        

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
            else if (linkLabel2.Text.Equals("Purchase Report"))
            {
                if (!pnlFormsMenu.Contains(rawMaterialReport))
                {
                    rawMaterialReport = new frmRawMaterialReport();
                    rawMaterialReport.TopLevel = false;
                    rawMaterialReport.Dock = DockStyle.Fill;
                    pnlFormsMenu.Controls.Add(rawMaterialReport);
                    rawMaterialReport.Show();
                    rawMaterialReport.BringToFront();
                }
                else
                {
                    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (linkLabel2.Text.Equals("Load & Unload"))
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
            else if (linkLabel2.Text.Equals("Update Mold Casting"))
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
            else if (linkLabel2.Text.Equals("Update Daily Glazing Report"))
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
            else if (linkLabel2.Text.Equals("Update Daily Killen Report"))
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
            else if (linkLabel2.Text.Equals("Update Mold Received Report"))
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
            else if (linkLabel2.Text.Equals("Update Item Stock"))
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
            else if (linkLabel2.Text.Equals("Calculate Material Amount"))
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
            else if (linkLabel2.Text.Equals("Update Report"))
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
                //-----payroll
           
            else if (linkLabel2.Text.Equals("View Attendence Record"))
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
                //--end payroll
                //-----sales
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
            else if (linkLabel2.Text.Equals("For Customer's"))
            {
                if (!pnlFormsMenu.Contains(createBill))
                {
                    createBill = new salesCreateBill();
                    createBill.TopLevel = false;
                    createBill.Dock = DockStyle.Fill;
                    pnlFormsMenu.Controls.Add(createBill);
                    createBill.Show();
                    createBill.BringToFront();
                    //addNewPerson.Focus=true;
                }
                else
                {
                    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
                //-----end sales
            }
            catch
            {
                MessageBox.Show("Connection Error.....while connecting to server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (linkLabel3.Text.Equals("Update Purchase Report"))
            {
                if (!pnlFormsMenu.Contains(updatePurchaseReport))
                {
                    updatePurchaseReport = new frmRawMaterialReportShow();
                    updatePurchaseReport.TopLevel = false;
                    updatePurchaseReport.Dock = DockStyle.Fill;
                    pnlFormsMenu.Controls.Add(updatePurchaseReport);
                    updatePurchaseReport.Show();
                    updatePurchaseReport.BringToFront();
                }
                else
                {
                    MessageBox.Show("Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (linkLabel3.Text.Equals("Caster Mold Stock"))
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
                //-----sales
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
                //-----end sales
            }
            catch
            {
                MessageBox.Show("Connection Error.....while connecting to server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (linkLabel4.Text.Equals("Update Stock Report"))
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
        //=====objects used by fifth label option in sub menu
        frmAddContact addContact;
        frmGreenWareItemCheckingShow updateGreenwareItemChecking;
        frmMoldBreakage moldBreakage;
        frmUpdateSlipPercentage updateSlipPercentage;
        frmAddGlazeHouse addGlazedHouse;
        frmAddKillen addKillen;
        frmAddItemWeight addItemWeight;
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
            else if (linkLabel5.Text.Equals("Add/Update Item Weight"))
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
        //=====objects used by sixth label option in sub menu
        frmAddCountry addCountry;
        frmUnGlazeItemBreakage unglazeItemBreakage;
        frmMoldBreakageShow updateMoldBreakage;
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
        //=====objects used by seventh label option in sub menu
        frmAddProvince addProvince;
        frmUnglazeItemBreakageShow updateUnglazeItemBreakage;
        frmCompanyMoldStock companyMoldStock;
        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
            else if (linkLabel7.Text.Equals("Show Company Stock"))
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
        }
        //=====objects used by Eighth label option in sub menu
        frmAddCity addCity;
        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void pbxPerson_Click(object sender, EventArgs e)
        {
            //====================================================
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.CornflowerBlue;
            linkLabel2.LinkColor = Color.CornflowerBlue;
            linkLabel3.LinkColor = Color.CornflowerBlue;
            linkLabel4.LinkColor = Color.CornflowerBlue;
            linkLabel5.LinkColor = Color.CornflowerBlue;
            linkLabel6.LinkColor = Color.CornflowerBlue;
            linkLabel7.LinkColor = Color.CornflowerBlue;
            linkLabel8.LinkColor = Color.CornflowerBlue;
            lblHeading.ForeColor = Color.CornflowerBlue;
            pnlMainMenuInventory.BackColor = Color.CornflowerBlue;
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

        private void pbxRawMaterial_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.Olive;
            linkLabel2.LinkColor = Color.Olive;
            linkLabel3.LinkColor = Color.Olive;
            linkLabel4.LinkColor = Color.Olive;
            linkLabel5.LinkColor = Color.Olive;
            //lblSlogans.ForeColor = Color.Olive;
            //lblSlogan.ForeColor = Color.Olive;
            lblHeading.ForeColor = Color.Olive;
            pnlMainMenuInventory.BackColor = Color.Olive;
            //lblCompanyName.ForeColor = Color.Olive;
            //lblCompanyNames.ForeColor = Color.Olive;
            //====================================================
            lblHeading.Text = "Raw Material";
            linkLabel1.Text = "Add New Raw Material";
            linkLabel2.Text = "Purchase Report";
            linkLabel3.Text = "Update Purchase Report";
            linkLabel4.Text = "Update Stock Report";
        }

        private void pbxBarmilSection_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.Crimson;
            linkLabel2.LinkColor = Color.Crimson;
            lblHeading.ForeColor = Color.Crimson;
            pnlMainMenuInventory.BackColor = Color.Crimson;
            //====================================================
            lblHeading.Text = "Barmil";
            linkLabel1.Text = "Add And Update Ball Mill";
            linkLabel2.Text = "Load & Unload";
        }

        private void pbxGreenWare_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.DarkGreen;
            linkLabel2.LinkColor = Color.DarkGreen;
            linkLabel3.LinkColor = Color.DarkGreen;
            linkLabel4.LinkColor = Color.DarkGreen;
            linkLabel5.LinkColor = Color.DarkGreen;
            linkLabel6.LinkColor = Color.DarkGreen;
            linkLabel7.LinkColor = Color.DarkGreen;
            lblHeading.ForeColor = Color.DarkGreen;
            pnlMainMenuInventory.BackColor = Color.DarkGreen;
            //====================================================
            lblHeading.Text = "GreenWare House";
            linkLabel1.Text = "Mold Casting";
            linkLabel2.Text = "Update Mold Casting";
            linkLabel3.Text = "Caster Mold Stock";
            linkLabel4.Text = "Item Checking";
            linkLabel5.Text = "Update Item Checking";
            linkLabel6.Text = "Item Breakage Report";
            linkLabel7.Text = "Update Item Breakage Report";
        }

        private void pbxOilInspection_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.DarkViolet;
            linkLabel2.LinkColor = Color.DarkViolet;
            lblHeading.ForeColor = Color.DarkViolet;
            pnlMainMenuInventory.BackColor = Color.DarkViolet;
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
            linkLabel3.LinkColor = Color.DarkMagenta;
            linkLabel4.LinkColor = Color.DarkMagenta;
            linkLabel5.LinkColor = Color.DarkMagenta;
            lblHeading.ForeColor = Color.DarkMagenta;
            pnlMainMenuInventory.BackColor = Color.DarkMagenta;
            //====================================================
            lblHeading.Text = "Glaze House";
            linkLabel1.Text = "Daily Glazing Report";
            linkLabel2.Text = "Update Daily Glazing Report";
            linkLabel3.Text = "Glazed Item Breakage";
            linkLabel4.Text = "Update Glazed Item Breakage";
            linkLabel5.Text = "Add/Update Glaze House";
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
            linkLabel5.LinkColor = Color.Firebrick;
            lblHeading.ForeColor = Color.Firebrick;
            pnlMainMenuInventory.BackColor = Color.Firebrick;
            //====================================================
            lblHeading.Text = "Killen";
            linkLabel1.Text = "Daily Killen Report";
            linkLabel2.Text = "Update Daily Killen Report";
            linkLabel3.Text = "Killen Feed Report";
            linkLabel4.Text = "Update Killen Feed Report";
            linkLabel5.Text = "Add/Update Killen";
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
            lblHeading.ForeColor = Color.DarkSlateBlue;
            pnlMainMenuInventory.BackColor = Color.DarkSlateBlue;
            //====================================================
            lblHeading.Text = "Stock";
            linkLabel1.Text = "Item Stock";
            linkLabel2.Text = "Update Item Stock";
            linkLabel3.Text = "Add/Update Item";
            linkLabel4.Text = "Add/Update Style";
            linkLabel5.Text = "Add/Update Item Weight";
        }

        private void pbxMold_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.Navy;
            linkLabel2.LinkColor = Color.Navy;
            linkLabel3.LinkColor = Color.Navy;
            linkLabel4.LinkColor = Color.Navy;
            linkLabel5.LinkColor = Color.Navy;
            linkLabel6.LinkColor = Color.Navy;
            linkLabel7.LinkColor = Color.Navy;
            //lblSlogans.ForeColor = Color.Navy;
            //lblSlogan.ForeColor = Color.Navy;
            lblHeading.ForeColor = Color.Navy;
            pnlMainMenuInventory.BackColor = Color.Navy;
            //lblCompanyName.ForeColor = Color.Navy;
            //lblCompanyNames.ForeColor = Color.Navy;
            //====================================================
            lblHeading.Text = "Mold";
            linkLabel1.Text = "Mold Receive Report";
            linkLabel2.Text = "Update Mold Received Report";
            linkLabel3.Text = "Mold Issue Report";
            linkLabel4.Text = "Update Mold Issued Report";
            linkLabel5.Text = "Mold Breakage Report";
            linkLabel6.Text = "Update Mold Breakage Report";
            linkLabel7.Text = "Show Company Stock";
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
            lblHeading.ForeColor = Color.SaddleBrown;
            pnlMainMenuInventory.BackColor = Color.SaddleBrown;
            //====================================================
            lblHeading.Text = "General Reports";
            linkLabel1.Text = "Calculate Slip From Items";
            linkLabel2.Text = "Calculate Material Amount";
            linkLabel3.Text = "Item Estimation From Slip";
            if (userType.Equals("Administrator"))
            {
                linkLabel4.Text = "Slip Percentage Info";
                linkLabel5.Text = "Update Slip Percentage";
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
            //lblSlogans.ForeColor = Color.Red;
            //lblSlogan.ForeColor = Color.Red;
            lblHeading.ForeColor = Color.Red;
            pnlMainMenuInventory.BackColor = Color.Red;
            //lblCompanyName.ForeColor = Color.Red;
            //lblCompanyNames.ForeColor = Color.Red;
            //====================================================
            lblHeading.Text = "User";
            linkLabel1.Text = "Add New User";
            linkLabel2.Text = "Change Password";
            linkLabel3.Text = "Delete User";
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

        private void pbxRawMaterial_MouseEnter(object sender, EventArgs e)
        {
            pbxRawMaterial.Location = new Point(101, 7);
            pbxRawMaterial.Size = new Size(83, 51);
        }

        private void pbxRawMaterial_MouseLeave(object sender, EventArgs e)
        {
            pbxRawMaterial.Location = new Point(111, 22);
            pbxRawMaterial.Size = new Size(54, 29);
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

        private void pbxMold_MouseEnter(object sender, EventArgs e)
        {
            pbxMold.Location = new Point(727, 7);
            pbxMold.Size = new Size(83, 51);
        }

        private void pbxMold_MouseLeave(object sender, EventArgs e)
        {
            pbxMold.Location = new Point(737, 22);
            pbxMold.Size = new Size(54, 29);
        }

        private void pbxGeneralReports_MouseEnter(object sender, EventArgs e)
        {
            pbxGeneralReports.Location = new Point(816, 7);
            pbxGeneralReports.Size = new Size(83, 51);
        }

        private void pbxGeneralReports_MouseLeave(object sender, EventArgs e)
        {
            pbxGeneralReports.Location = new Point(826, 22);
            pbxGeneralReports.Size = new Size(54, 29);
        }

        private void pbxUser_MouseEnter(object sender, EventArgs e)
        {
            pbxUser.Location = new Point(905, 7);
            pbxUser.Size = new Size(83, 51);
        }

        private void pbxUser_MouseLeave(object sender, EventArgs e)
        {
            pbxUser.Location = new Point(915, 22);
            pbxUser.Size = new Size(54, 29);
        }

        private void pbxLogout_MouseEnter(object sender, EventArgs e)
        {
            //pbxLogout.Location = new Point(101, 440);
            //pbxLogout.Size = new Size(60, 47);
        }

        private void pbxLogout_MouseLeave(object sender, EventArgs e)
        {
            //pbxLogout.Location = new Point(107, 440);
            //pbxLogout.Size = new Size(50, 43);
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

        private void linkLabel2_MouseLeave(object sender, EventArgs e)
        {
            linkLabel2.Font = new Font(fontFamily, 8, fontStyle);
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
        //-------------------------------------------------------------------------------payroll
        private void pbxAttendance_MouseEnter(object sender, EventArgs e)
        {
            pbxAttendance.Location = new Point(188, 7);
            pbxAttendance.Size = new Size(83, 51);
        }
        private void pbxAttendance_MouseLeave(object sender, EventArgs e)
        {
            pbxAttendance.Location = new Point(198, 22);
            pbxAttendance.Size = new Size(54, 29);
        }
        private void pbxWorkerLoan_MouseEnter(object sender, EventArgs e)
        {
            pbxWorkerLoan.Location = new Point(279, 7);
            pbxWorkerLoan.Size = new Size(83, 51);

        }
        private void pbxWorkerLoan_MouseLeave(object sender, EventArgs e)
        {
            pbxWorkerLoan.Location = new Point(289, 22);
            pbxWorkerLoan.Size = new Size(54, 29);
        }
        
        private void pbxCasterPayment_MouseEnter(object sender, EventArgs e)
        {
            pbxCasterPayment.Location = new Point(370, 7);
            pbxCasterPayment.Size = new Size(83, 51);
        }
        private void pbxCasterPayment_MouseLeave(object sender, EventArgs e)
        {
            pbxCasterPayment.Location = new Point(380, 22);
            pbxCasterPayment.Size = new Size(54, 29);
        }
        private void pbxDailyWages_MouseEnter(object sender, EventArgs e)
        {
            pbxDailyWages.Location = new Point(461, 7);
            pbxDailyWages.Size = new Size(83, 51);
        }
        private void pbxDailyWages_MouseLeave(object sender, EventArgs e)
        {
            pbxDailyWages.Location = new Point(471, 22);
            pbxDailyWages.Size = new Size(54, 29);
        }
        private void pbxMonthlySalary_MouseEnter(object sender, EventArgs e)
        {
            pbxMonthlySalary.Location = new Point(549, 7);
            pbxMonthlySalary.Size = new Size(83, 51);
        }
        private void pbxMonthlySalary_MouseLeave(object sender, EventArgs e)
        {
            pbxMonthlySalary.Location = new Point(559, 22);
            pbxMonthlySalary.Size = new Size(54, 29);
        }
        private void pbxAttendance_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.Maroon;
            linkLabel2.LinkColor = Color.Maroon;
            lblHeading.ForeColor = Color.Maroon;
            pnlMainMenuPayroll.BackColor = Color.Maroon;
            //====================================================
            lblHeading.Text = "Attendence";
            linkLabel1.Text = "Mark Attendence";
            linkLabel2.Text = "View Attendence Record";
        }
        private void pbxWorkerLoan_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = SystemColors.ActiveCaptionText;
            linkLabel2.LinkColor = SystemColors.ActiveCaptionText;
            lblHeading.ForeColor = SystemColors.ActiveCaptionText;
            pnlMainMenuPayroll.BackColor = SystemColors.ActiveCaptionText;
            //====================================================
            lblHeading.Text = "Worker Loan";
            linkLabel1.Text = "Manage Worker Loan";
            linkLabel2.Text = "Update Loan Report";
        }

        private void pbxCasterPayment_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.SaddleBrown;
            linkLabel2.LinkColor = Color.SaddleBrown;
            lblHeading.ForeColor = Color.SaddleBrown;
            pnlMainMenuPayroll.BackColor = Color.SaddleBrown;
            //====================================================
            lblHeading.Text = "Caster Payment";
            linkLabel1.Text = "Add Payment Report";
            linkLabel2.Text = "View Payment Report";
        }

        private void pbxDailyWages_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = SystemColors.ControlDarkDark;
            linkLabel2.LinkColor = SystemColors.ControlDarkDark;
            lblHeading.ForeColor = SystemColors.ControlDarkDark;
            pnlMainMenuPayroll.BackColor = SystemColors.ControlDarkDark;
            //====================================================
            lblHeading.Text = "Daily Wages";
            linkLabel1.Text = "Add Wages Report";
            linkLabel2.Text = "View Wages Report";
        }

        private void pbxMonthlySalary_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.DarkSlateGray;
            linkLabel2.LinkColor = Color.DarkSlateGray;
            lblHeading.ForeColor = Color.DarkSlateGray;
            pnlMainMenuPayroll.BackColor = Color.DarkSlateGray;
            //====================================================
            lblHeading.Text = "Monthly Salary";
            linkLabel1.Text = "Add Salary Report";
            linkLabel2.Text = "View Salary Report";
        }
        //-----sales management system
        //-------------------------------------------------------------------------------payroll
        private void pbxSubDealer_MouseEnter(object sender, EventArgs e)
        {
            pbxSubDealer.Location = new Point(188, 7);
            pbxSubDealer.Size = new Size(83, 51);
        }
        private void pbxSubDealer_MouseLeave(object sender, EventArgs e)
        {
            pbxSubDealer.Location = new Point(198, 22);
            pbxSubDealer.Size = new Size(54, 29);
        }
        private void pbxGoodsCompany_MouseEnter(object sender, EventArgs e)
        {
            pbxGoodsCompany.Location = new Point(279, 7);
            pbxGoodsCompany.Size = new Size(83, 51);
        }
        private void pbxGoodsCompany_MouseLeave(object sender, EventArgs e)
        {
            pbxGoodsCompany.Location = new Point(289, 22);
            pbxGoodsCompany.Size = new Size(54, 29);
        }
        private void pbxAddOrder_MouseEnter(object sender, EventArgs e)
        {
            pbxAddOrder.Location = new Point(370, 7);
            pbxAddOrder.Size = new Size(83, 51);
        }
        private void pbxAddOrder_MouseLeave(object sender, EventArgs e)
        {
            pbxAddOrder.Location = new Point(380, 22);
            pbxAddOrder.Size = new Size(54, 29);
        }
        private void pbxDeliveryChallan_MouseEnter(object sender, EventArgs e)
        {
            pbxDeliveryChallan.Location = new Point(461, 7);
            pbxDeliveryChallan.Size = new Size(83, 51);
        }
        private void pbxDeliveryChallan_MouseLeave(object sender, EventArgs e)
        {
            pbxDeliveryChallan.Location = new Point(471, 22);
            pbxDeliveryChallan.Size = new Size(54, 29);
        }
        private void pbxPostOrder_MouseEnter(object sender, EventArgs e)
        {
            pbxPostOrder.Location = new Point(549, 7);
            pbxPostOrder.Size = new Size(83, 51);
        }
        private void pbxPostOrder_MouseLeave(object sender, EventArgs e)
        {
            pbxPostOrder.Location = new Point(559, 22);
            pbxPostOrder.Size = new Size(54, 29);
        }
        private void pbxBills_MouseEnter(object sender, EventArgs e)
        {
            pbxBills.Location = new Point(638, 7);
            pbxBills.Size = new Size(83, 51);
        }
        private void pbxBills_MouseLeave(object sender, EventArgs e)
        {
            pbxBills.Location = new Point(648, 22);
            pbxBills.Size = new Size(54, 29);
        }
        private void pbxSubDealer_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.Maroon;
            lblHeading.ForeColor = Color.Maroon;
            pnlMainMenuSales.BackColor = Color.Maroon;
            //====================================================
            lblHeading.Text = "Sub Dealer";
            linkLabel1.Text = "Manage Sub-Dealer";
        }
        private void pbxGoodsCompany_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = SystemColors.ActiveCaptionText;
            lblHeading.ForeColor = SystemColors.ActiveCaptionText;
            pnlMainMenuSales.BackColor = SystemColors.ActiveCaptionText;
            //====================================================
            lblHeading.Text = "Goods Transport";
            linkLabel1.Text = "Manage Goods Company";
        }

        private void pbxAddOrder_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.SaddleBrown;
            linkLabel2.LinkColor = Color.SaddleBrown;
            linkLabel3.LinkColor = Color.SaddleBrown;
            lblHeading.ForeColor = Color.SaddleBrown;
            pnlMainMenuSales.BackColor = Color.SaddleBrown;
            //====================================================
            lblHeading.Text = "Get Order";
            linkLabel1.Text = "Add Order";
            linkLabel2.Text = "View By Dealer";
            linkLabel3.Text = "View By Sub-Dealer";
        }

        private void pbxDeliveryChallan_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = SystemColors.ControlDarkDark;
            linkLabel2.LinkColor = SystemColors.ControlDarkDark;
            lblHeading.ForeColor = SystemColors.ControlDarkDark;
            pnlMainMenuSales.BackColor = SystemColors.ControlDarkDark;
            //====================================================
            lblHeading.Text = "Delivery Challan";
            linkLabel1.Text = "Create New Challan";
            linkLabel2.Text = "View Challan Info";
        }

        private void pbxPostedOrder_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.DarkSlateGray;
            linkLabel2.LinkColor = Color.DarkSlateGray;
            linkLabel3.LinkColor = Color.DarkSlateGray;
            lblHeading.ForeColor = Color.DarkSlateGray;
            pnlMainMenuSales.BackColor = Color.DarkSlateGray;
            //====================================================
            lblHeading.Text = "Posted Order";
            linkLabel1.Text = "Add Posted Order's";
            linkLabel2.Text = "View Order's";
            linkLabel3.Text = "Create Order's Bill";
        }
        private void pbxBills_Click(object sender, EventArgs e)
        {
            emptyLabelsText();
            visibleLabel();
            //====change color
            linkLabel1.LinkColor = Color.DarkSlateBlue;
            linkLabel2.LinkColor = Color.DarkSlateBlue;
            linkLabel3.LinkColor = Color.DarkSlateBlue;
            linkLabel4.LinkColor = Color.DarkSlateBlue;
            lblHeading.ForeColor = Color.DarkSlateBlue;
            pnlMainMenuSales.BackColor = Color.DarkSlateBlue;
            //====================================================
            lblHeading.Text = "Create Bills";
            linkLabel1.Text = "By Delivery Challan";
            linkLabel2.Text = "For Customer's";
            linkLabel3.Text = "Empty Bill";
            linkLabel4.Text = "Letter Head";
        }

        private void lblInventoryApplication_Click(object sender, EventArgs e)
        {
            InvisibleLabel();
            pnlMainMenuPayroll.Visible = false;
            pnlMainMenuSales.Visible = false;
            pnlMainMenuInventory.Visible = true;
        }

        private void lblPayrollApplication_Click(object sender, EventArgs e)
        {
            InvisibleLabel();
            pnlMainMenuSales.Visible = false;
            pnlMainMenuInventory.Visible = false;
            pnlMainMenuPayroll.Visible = true;
        }

        private void lblSalesApplicarion_Click(object sender, EventArgs e)
        {
            InvisibleLabel();
            pnlMainMenuInventory.Visible = false;
            pnlMainMenuPayroll.Visible = false;
            pnlMainMenuSales.Visible = true;
        }
        //========================================================================================================================
    }
}
