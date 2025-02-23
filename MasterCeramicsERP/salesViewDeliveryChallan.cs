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
    public partial class salesViewDeliveryChallan : Form
    {
        int  orderRow = -1, orderSelectedRow = -1;
        List<deliveryChallan> lst;
        DataSet dsWorker = new DataSet();
        DataSet dsJobs = new DataSet();
        List<int> dealerID;
        public salesViewDeliveryChallan()
        {
            InitializeComponent();
        }
        private void loadPersonDGV()
        {
            try
            {
                JobsDAL jobDal = new JobsDAL();
                //populate cbx supplier
                dsJobs.Clear();
                dsJobs = jobDal.getAllJobsDataSet();
                cbxSelectJob.DataSource = dsJobs.Tables[0];
                cbxSelectJob.DisplayMember = "Name";
                //end populate
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                deliveryChallanDAL orderDAL = new deliveryChallanDAL();

                if (cbxWorker.Text != "")
                {
                    if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false))
                    {
                        MessageBox.Show("Select day or month...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (rbtnDay.Checked.Equals(true))
                    {
                        lst = orderDAL.getReportByDateAndDealer(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]), dtpAddOrder.Value);
                        if (lst.Count.Equals(0))
                        {
                            MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearOrderDGV();
                        }
                        else
                        {
                            loadOrderDGV();
                        }
                    }
                    else if (rbtnMonth.Checked.Equals(true))
                    {
                        lst = orderDAL.getReportByMonthAndDealer(dtpAddOrder.Value, Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]));
                        if (lst.Count.Equals(0))
                        {
                            MessageBox.Show("No record found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearOrderDGV();
                        }
                        else
                        {
                            loadOrderDGV();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Select dealer...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salesViewDeliveryChallan_Load(object sender, EventArgs e)
        {
            loadPersonDGV();
        }

        private void loadOrderDGV()
        {
            PersonDAL personDAL = new PersonDAL();
            ItemDAL itemDAL = new ItemDAL();
            DALItemStyle styleDAL = new DALItemStyle();
            ItemSizeDAL sizeDAL = new ItemSizeDAL();
            ColorDAL colorDAL = new ColorDAL();

            try
            {
                lst.TrimExcess();
                orderRow = -1;
                orderSelectedRow = -1;
                dealerID = new List<int>();
                dgvOrderInfo.Rows.Clear();
                for (int i = 0; i < lst.Count; i++)
                {
                    orderRow = dgvOrderInfo.Rows.Add();
                    dealerID.Add(lst[i].DealerID);
                    dgvOrderInfo.Rows[orderRow].Cells[0].Value = personDAL.getPersonName(lst[i].DealerID);
                    dgvOrderInfo.Rows[orderRow].Cells[1].Value = itemDAL.getItemName(lst[i].ItemID);
                    dgvOrderInfo.Rows[orderRow].Cells[2].Value = styleDAL.getItemStyleName(lst[i].StyleID);
                    dgvOrderInfo.Rows[orderRow].Cells[3].Value = sizeDAL.getItemSizeName(lst[i].SizeID);
                    dgvOrderInfo.Rows[orderRow].Cells[4].Value = colorDAL.getColorName(lst[i].ColorID);
                    dgvOrderInfo.Rows[orderRow].Cells[5].Value = lst[i].Quantity;
                    dgvOrderInfo.Rows[orderRow].Cells[6].Value = lst[i].GatePass;
                    dgvOrderInfo.Rows[orderRow].Cells[7].Value = lst[i].Date.ToShortDateString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearOrderDGV()
        {
            dgvOrderInfo.Rows.Clear();
            orderRow = orderSelectedRow = -1;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            orderRow = orderSelectedRow = -1;
            dgvOrderInfo.Rows.Clear();
        }

        private void dgvOrderInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderSelectedRow = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ItemDAL itemDAL = new ItemDAL();
            DALItemStyle styleDAL = new DALItemStyle();
            ItemSizeDAL sizeDAL = new ItemSizeDAL();
            ColorDAL colorDAL = new ColorDAL();
            deliveryChallanDAL orderDAL = new deliveryChallanDAL();
            
            try
            {
                if (orderSelectedRow.Equals(-1))
                {
                    MessageBox.Show("Select order...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    deliveryChallan o = new deliveryChallan();
                    o.DealerID = dealerID[orderSelectedRow];
                    o.ItemID = itemDAL.getItemID(dgvOrderInfo.Rows[orderSelectedRow].Cells[1].Value.ToString());
                    o.StyleID = styleDAL.getStyleID(dgvOrderInfo.Rows[orderSelectedRow].Cells[2].Value.ToString());
                    o.SizeID = sizeDAL.getSizeID(dgvOrderInfo.Rows[orderSelectedRow].Cells[3].Value.ToString());
                    o.ColorID = colorDAL.getColorID(dgvOrderInfo.Rows[orderSelectedRow].Cells[4].Value.ToString());
                    o.Quantity = Convert.ToInt16(dgvOrderInfo.Rows[orderSelectedRow].Cells[5].Value.ToString());
                    o.GatePass = dgvOrderInfo.Rows[orderSelectedRow].Cells[6].Value.ToString();
                    o.Date = Convert.ToDateTime(dgvOrderInfo.Rows[orderSelectedRow].Cells[7].Value);

                    orderDAL.deleteOrder(o);
                    MessageBox.Show("Report has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvOrderInfo.Rows.RemoveAt(orderSelectedRow);
                    orderSelectedRow = -1;
                    orderRow--;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        rptFrmSDeliveryChallan report;
        private void addReport()
        {
            report = new rptFrmSDeliveryChallan();
            //report.TopLevel = false;
            //report.Dock = DockStyle.Fill;
            //this.Parent.Controls.Add(report);
            //report.BringToFront();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxWorker.Text != "")
                {
                    if (rbtnDay.Checked.Equals(false) && rbtnMonth.Checked.Equals(false))
                    {
                        MessageBox.Show("Select day or month...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (rbtnDay.Checked.Equals(true))
                    {
                        addReport();
                        report.dailyReportByDealer(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]), Convert.ToDateTime(dtpAddOrder.Value));
                        report.Show();
                    }
                    else if (rbtnMonth.Checked.Equals(true))
                    {
                        addReport();
                        report.monthlyReportByDealer(Convert.ToInt32(dsWorker.Tables[0].Rows[cbxWorker.SelectedIndex]["ID"]), Convert.ToDateTime(dtpAddOrder.Value));
                        report.Show();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxSelectJob_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PersonDAL personDAL = new PersonDAL();
            JobsDAL jobDal = new JobsDAL();

            try
            {
                lblWorker.Text = cbxSelectJob.Text;
                //populate cbx supplier
                dsWorker.Clear();
                dsWorker = personDAL.getPersonByJobDataset(jobDal.getJobID(cbxSelectJob.Text));
                cbxWorker.DataSource = dsWorker.Tables[0];
                cbxWorker.DisplayMember = "Name";
                //end populate
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--------------------------------------------------------------------------------
    }
}
