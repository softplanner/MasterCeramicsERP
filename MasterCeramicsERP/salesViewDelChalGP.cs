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
    public partial class salesViewDelChalGP : Form
    {
        int orderRow = -1, orderSelectedRow = -1;
        List<deliveryChallan> lst;

        public salesViewDelChalGP()
        {
            InitializeComponent();
        }
        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            try
            {
                deliveryChallanDAL orderDAL = new deliveryChallanDAL();
                
                if (txtTemp.Text.Equals(""))
                {
                    MessageBox.Show("Enter Gatepass Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    lst = orderDAL.getReportListByGatePass(txtTemp.Text);
                    if (lst.Count.Equals(0))
                    {
                        MessageBox.Show("Invalid GatePass Number...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearOrderDGV();
                    }
                    else
                    {
                        loadOrderDGV();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                dgvOrderInfo.Rows.Clear();
                for (int i = 0; i < lst.Count; i++)
                {
                    orderRow = dgvOrderInfo.Rows.Add();
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

        private void btnDeleteChallan_Click(object sender, EventArgs e)
        {
            deliveryChallanDAL orderDAL = new deliveryChallanDAL();
            try
            {
                if (txtTemp.Text.Equals(""))
                {
                    MessageBox.Show("Enter gatepass number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    orderDAL.deleteWholeChallan(txtTemp.Text);
                    MessageBox.Show("Delivery Challan has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearOrderDGV();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    o.ItemID = itemDAL.getItemID(dgvOrderInfo.Rows[orderSelectedRow].Cells[1].Value.ToString());
                    o.StyleID = styleDAL.getStyleID(dgvOrderInfo.Rows[orderSelectedRow].Cells[2].Value.ToString());
                    o.SizeID = sizeDAL.getSizeID(dgvOrderInfo.Rows[orderSelectedRow].Cells[3].Value.ToString());
                    o.ColorID = colorDAL.getColorID(dgvOrderInfo.Rows[orderSelectedRow].Cells[4].Value.ToString());
                    o.Quantity = Convert.ToInt16(dgvOrderInfo.Rows[orderSelectedRow].Cells[5].Value.ToString());
                    o.GatePass = dgvOrderInfo.Rows[orderSelectedRow].Cells[6].Value.ToString();
                    o.Date = Convert.ToDateTime(dgvOrderInfo.Rows[orderSelectedRow].Cells[7].Value);

                    orderDAL.deleteOrder(o);
                    MessageBox.Show("Record has been deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtTemp_MouseClick(object sender, MouseEventArgs e)
        {
            txtTemp.Focus();
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
                if (txtTemp.Text.Equals(""))
                {
                    MessageBox.Show("Enter gatepass number...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                { 
                    addReport();
                    report.getReportByGatePass(txtTemp.Text);
                    report.Show();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error Accessing Database  " + exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--------------------------------------------------------------------------------
    }
}

