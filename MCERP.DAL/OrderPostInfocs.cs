using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class OrderPostInfocs
    {
        //-------------------------------------------------------------------------------------------------------
        public DataSet getMonthlyOrderReport(DateTime date)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            GoodsCompanyDAL good = new GoodsCompanyDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderPostInfo where (year(Date) = '" + date.Year + "' and month(Date) = '" + date.Month + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Dealer", typeof(string));
            dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("GatePass", typeof(string));
            dt.Columns.Add("BiltyNo", typeof(string));
            dt.Columns.Add("G.T Comp", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["DealerID"]));
                dataRow[1] = personDAL.getPersonName(Convert.ToInt32(dr["DealerCustomerID"]));
                dataRow[2] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[3] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[4] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[5] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToString(dr["GatePass"]);
                dataRow[8] = Convert.ToString(dr["BiltyNo"]);
                dataRow[9] = good.getGoodsCompanyName(Convert.ToInt16(dr["GoodsCompanyID"]));
                dataRow[10] = Convert.ToDateTime(dr["Date"]);

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getMonthlyOrderReportByDealer(DateTime date,int did)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            GoodsCompanyDAL good = new GoodsCompanyDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderPostInfo where (year(Date) = '" + date.Year + "' and month(Date) = '" + date.Month + "' and DealerID='"+did+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Dealer", typeof(string));
            dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("GatePass", typeof(string));
            dt.Columns.Add("BiltyNo", typeof(string));
            dt.Columns.Add("G.T Comp", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["DealerID"]));
                dataRow[1] = personDAL.getPersonName(Convert.ToInt32(dr["DealerCustomerID"]));
                dataRow[2] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[3] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[4] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[5] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToString(dr["GatePass"]);
                dataRow[8] = Convert.ToString(dr["BiltyNo"]);
                dataRow[9] = good.getGoodsCompanyName(Convert.ToInt16(dr["GoodsCompanyID"]));
                dataRow[10] = Convert.ToDateTime(dr["Date"]);

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getMonthlyOrderReportByCustomer(DateTime date, int cid)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            GoodsCompanyDAL good = new GoodsCompanyDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderPostInfo where (year(Date) = '" + date.Year + "' and month(Date) = '" + date.Month + "' and DealerCustomerID='" + cid + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Dealer", typeof(string));
            dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("GatePass", typeof(string));
            dt.Columns.Add("BiltyNo", typeof(string));
            dt.Columns.Add("G.T Comp", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["DealerID"]));
                dataRow[1] = personDAL.getPersonName(Convert.ToInt32(dr["DealerCustomerID"]));
                dataRow[2] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[3] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[4] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[5] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToString(dr["GatePass"]);
                dataRow[8] = Convert.ToString(dr["BiltyNo"]);
                dataRow[9] = good.getGoodsCompanyName(Convert.ToInt16(dr["GoodsCompanyID"]));
                dataRow[10] = Convert.ToDateTime(dr["Date"]);

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getSelectedDateOrderReport(DateTime date)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            GoodsCompanyDAL good = new GoodsCompanyDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderPostInfo where (year(Date) = '" + date.Year + "' and month(Date) = '" + date.Month + "' and day(Date) = '" + date.Day + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Dealer", typeof(string));
            dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("GatePass", typeof(string));
            dt.Columns.Add("BiltyNo", typeof(string));
            dt.Columns.Add("G.T Comp", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["DealerID"]));
                dataRow[1] = personDAL.getPersonName(Convert.ToInt32(dr["DealerCustomerID"]));
                dataRow[2] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[3] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[4] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[5] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToString(dr["GatePass"]);
                dataRow[8] = Convert.ToString(dr["BiltyNo"]);
                dataRow[9] = good.getGoodsCompanyName(Convert.ToInt16(dr["GoodsCompanyID"]));
                dataRow[10] = Convert.ToDateTime(dr["Date"]);

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getSelectedDateOrderReportByDealer(DateTime date,int did)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            GoodsCompanyDAL good = new GoodsCompanyDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderPostInfo where (DealerID='"+did+"' and year(Date) = '" + date.Year + "' and month(Date) = '" + date.Month + "' and day(Date) = '" + date.Day + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Dealer", typeof(string));
            dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("GatePass", typeof(string));
            dt.Columns.Add("BiltyNo", typeof(string));
            dt.Columns.Add("G.T Comp", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["DealerID"]));
                dataRow[1] = personDAL.getPersonName(Convert.ToInt32(dr["DealerCustomerID"]));
                dataRow[2] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[3] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[4] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[5] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToString(dr["GatePass"]);
                dataRow[8] = Convert.ToString(dr["BiltyNo"]);
                dataRow[9] = good.getGoodsCompanyName(Convert.ToInt16(dr["GoodsCompanyID"]));
                dataRow[10] = Convert.ToDateTime(dr["Date"]);

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getSelectedDateOrderReportByCustomer(DateTime date,int cid)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            GoodsCompanyDAL good = new GoodsCompanyDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderPostInfo where (DealerCustomerID='"+cid+"' and year(Date) = '" + date.Year + "' and month(Date) = '" + date.Month + "' and day(Date) = '" + date.Day + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Dealer", typeof(string));
            dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("GatePass", typeof(string));
            dt.Columns.Add("BiltyNo", typeof(string));
            dt.Columns.Add("G.T Comp", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["DealerID"]));
                dataRow[1] = personDAL.getPersonName(Convert.ToInt32(dr["DealerCustomerID"]));
                dataRow[2] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[3] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[4] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[5] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToString(dr["GatePass"]);
                dataRow[8] = Convert.ToString(dr["BiltyNo"]);
                dataRow[9] = good.getGoodsCompanyName(Convert.ToInt16(dr["GoodsCompanyID"]));
                dataRow[10] = Convert.ToDateTime(dr["Date"]);

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getDailyOrderReport()
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            GoodsCompanyDAL good = new GoodsCompanyDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderPostInfo where (year(Date)='" + DateTime.Today.Year + "' and month(Date)='" + DateTime.Today.Month + "' and day(Date)='" + DateTime.Today.Day + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Dealer", typeof(string));
            dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("GatePass", typeof(string));
            dt.Columns.Add("BiltyNo", typeof(string));
            dt.Columns.Add("G.T Comp", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["DealerID"]));
                dataRow[1] = personDAL.getPersonName(Convert.ToInt32(dr["DealerCustomerID"]));
                dataRow[2] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[3] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[4] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[5] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToString(dr["GatePass"]);
                dataRow[8] = Convert.ToString(dr["BiltyNo"]);
                dataRow[9] = good.getGoodsCompanyName(Convert.ToInt16(dr["GoodsCompanyID"]));
                dataRow[10] = Convert.ToDateTime(dr["Date"]);

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getDailyOrderReportByDealer(int did)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            GoodsCompanyDAL good = new GoodsCompanyDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderPostInfo where (year(Date)='" + DateTime.Today.Year + "' and month(Date)='" + DateTime.Today.Month + "' and day(Date)='" + DateTime.Today.Day + "' and DealerID='" + did + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Dealer", typeof(string));
            dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("GatePass", typeof(string));
            dt.Columns.Add("BiltyNo", typeof(string));
            dt.Columns.Add("G.T Comp", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["DealerID"]));
                dataRow[1] = personDAL.getPersonName(Convert.ToInt32(dr["DealerCustomerID"]));
                dataRow[2] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[3] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[4] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[5] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToString(dr["GatePass"]);
                dataRow[8] = Convert.ToString(dr["BiltyNo"]);
                dataRow[9] = good.getGoodsCompanyName(Convert.ToInt16(dr["GoodsCompanyID"]));
                dataRow[10] = Convert.ToDateTime(dr["Date"]);

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getDailyOrderReportByCustomer(int cid)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            GoodsCompanyDAL good = new GoodsCompanyDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderPostInfo where (year(Date)='" + DateTime.Today.Year + "' and month(Date)='" + DateTime.Today.Month + "' and day(Date)='" + DateTime.Today.Day + "' and DealerCustomerID='" + cid + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Dealer", typeof(string));
            dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("GatePass", typeof(string));
            dt.Columns.Add("BiltyNo", typeof(string));
            dt.Columns.Add("G.T Comp", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["DealerID"]));
                dataRow[1] = personDAL.getPersonName(Convert.ToInt32(dr["DealerCustomerID"]));
                dataRow[2] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[3] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[4] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[5] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToString(dr["GatePass"]);
                dataRow[8] = Convert.ToString(dr["BiltyNo"]);
                dataRow[9] = good.getGoodsCompanyName(Convert.ToInt16(dr["GoodsCompanyID"]));
                dataRow[10] = Convert.ToDateTime(dr["Date"]);

                ds.Tables[0].Rows.Add(dataRow);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void addOrder(OrderPostInfo obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("insert into OrderPostInfo (Date,ItemID,StyleID,SizeID,ColorID,Quantity,DealerID,DealerCustomerID,GatePass,BiltyNo,GoodsCompanyID)values('" + obj.Date + "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.ColorID + "','" + obj.Quantity + "','" + obj.DealerID + "','" + obj.DealerCustomerID + "','" + obj.GatePass + "','" + obj.BiltyNo + "','" + obj.GoodsCompanyID + "')", objSqlConnection);
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                //////////////////////////////////////
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void deleteOrder(OrderPostInfo obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("Delete from OrderPostInfo where (year(Date)='" + obj.Date.Year + "' and month(Date)='" + obj.Date.Month + "' and day(Date)='" + obj.Date.Day + "' and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and ColorID='" + obj.ColorID + "'and Quantity='" + obj.Quantity + "'and DealerID='" + obj.DealerID + "' and DealerCustomerID='" + obj.DealerCustomerID + "' and BiltyNo='"+obj.BiltyNo+"' and GatePass='"+obj.GatePass+"')", objSqlConnection);
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                //////////////////////////////////////
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OrderPostInfo> getOrderByGatePass(string gatePass)
        {
            List<OrderPostInfo> list = new List<OrderPostInfo>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from OrderPostInfo where (GatePass='" + gatePass+ "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    OrderPostInfo o = new OrderPostInfo();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                    o.GatePass = Convert.ToString(dr["GatePass"]);
                    o.BiltyNo = Convert.ToString(dr["BiltyNo"]);
                    o.GoodsCompanyID = Convert.ToInt16(dr["GoodsCompanyID"]);
                    o.ItemID = Convert.ToInt16(dr["ItemID"]);
                    o.StyleID = Convert.ToInt16(dr["StyleID"]);
                    o.SizeID = Convert.ToInt16(dr["SizeID"]);
                    o.ColorID = Convert.ToInt16(dr["ColorID"]);
                    o.Quantity = Convert.ToInt16(dr["Quantity"]);

                    list.Add(o);
                }
                objSqlConnection.Close();
                list.TrimExcess();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return list;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;

        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OrderPostInfo> getOrderByBilty(string bilty)
        {
            List<OrderPostInfo> list = new List<OrderPostInfo>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from OrderPostInfo where (BiltyNo='" + bilty+ "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    OrderPostInfo o = new OrderPostInfo();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                    o.GatePass = Convert.ToString(dr["GatePass"]);
                    o.BiltyNo = Convert.ToString(dr["BiltyNo"]);
                    o.GoodsCompanyID = Convert.ToInt16(dr["GoodsCompanyID"]);
                    o.ItemID = Convert.ToInt16(dr["ItemID"]);
                    o.StyleID = Convert.ToInt16(dr["StyleID"]);
                    o.SizeID = Convert.ToInt16(dr["SizeID"]);
                    o.ColorID = Convert.ToInt16(dr["ColorID"]);
                    o.Quantity = Convert.ToInt16(dr["Quantity"]);

                    list.Add(o);
                }
                objSqlConnection.Close();
                list.TrimExcess();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return list;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;

        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OrderPostInfo> getReportByDate(DateTime date)
        {
            List<OrderPostInfo> list = new List<OrderPostInfo>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from OrderPostInfo where (year(Date)='" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    OrderPostInfo o = new OrderPostInfo();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                    o.GatePass = Convert.ToString(dr["GatePass"]);
                    o.BiltyNo = Convert.ToString(dr["BiltyNo"]);
                    o.GoodsCompanyID = Convert.ToInt16(dr["GoodsCompanyID"]);
                    o.ItemID = Convert.ToInt16(dr["ItemID"]);
                    o.StyleID = Convert.ToInt16(dr["StyleID"]);
                    o.SizeID = Convert.ToInt16(dr["SizeID"]);
                    o.ColorID = Convert.ToInt16(dr["ColorID"]);
                    o.Quantity = Convert.ToInt16(dr["Quantity"]);

                    list.Add(o);
                }
                objSqlConnection.Close();
                list.TrimExcess();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return list;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
                
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OrderPostInfo> getReportByDateAndDealer(int did,DateTime date)
        {
            List<OrderPostInfo> list = new List<OrderPostInfo>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from OrderPostInfo where (year(Date)='" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "' and DealerID='"+did+"')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    OrderPostInfo o = new OrderPostInfo();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                    o.GatePass = Convert.ToString(dr["GatePass"]);
                    o.BiltyNo = Convert.ToString(dr["BiltyNo"]);
                    o.GoodsCompanyID = Convert.ToInt16(dr["GoodsCompanyID"]);
                    o.ItemID = Convert.ToInt16(dr["ItemID"]);
                    o.StyleID = Convert.ToInt16(dr["StyleID"]);
                    o.SizeID = Convert.ToInt16(dr["SizeID"]);
                    o.ColorID = Convert.ToInt16(dr["ColorID"]);
                    o.Quantity = Convert.ToInt16(dr["Quantity"]);

                    list.Add(o);
                }
                objSqlConnection.Close();
                list.TrimExcess();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return list;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;

        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OrderPostInfo> getReportByDateDealerAndCustomerID(int did,int cid, DateTime date)
        {
            List<OrderPostInfo> list = new List<OrderPostInfo>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from OrderPostInfo where (year(Date)='" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "' and DealerID='"+did+"' and DealerCustomerID='" + cid+ "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    OrderPostInfo o = new OrderPostInfo();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                    o.GatePass = Convert.ToString(dr["GatePass"]);
                    o.BiltyNo = Convert.ToString(dr["BiltyNo"]);
                    o.GoodsCompanyID = Convert.ToInt16(dr["GoodsCompanyID"]);
                    o.ItemID = Convert.ToInt16(dr["ItemID"]);
                    o.StyleID = Convert.ToInt16(dr["StyleID"]);
                    o.SizeID = Convert.ToInt16(dr["SizeID"]);
                    o.ColorID = Convert.ToInt16(dr["ColorID"]);
                    o.Quantity = Convert.ToInt16(dr["Quantity"]);

                    list.Add(o);
                }
                objSqlConnection.Close();
                list.TrimExcess();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return list;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OrderPostInfo> getReportByDateAndCustomerID(int customerID,DateTime date)
        { 
            List<OrderPostInfo> list = new List<OrderPostInfo>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from OrderPostInfo where (year(Date)='" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "' and DealerCustomerID='" + customerID + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    OrderPostInfo o = new OrderPostInfo();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                    o.GatePass = Convert.ToString(dr["GatePass"]);
                    o.BiltyNo = Convert.ToString(dr["BiltyNo"]);
                    o.GoodsCompanyID = Convert.ToInt16(dr["GoodsCompanyID"]);
                    o.ItemID = Convert.ToInt16(dr["ItemID"]);
                    o.StyleID = Convert.ToInt16(dr["StyleID"]);
                    o.SizeID = Convert.ToInt16(dr["SizeID"]);
                    o.ColorID = Convert.ToInt16(dr["ColorID"]);
                    o.Quantity = Convert.ToInt16(dr["Quantity"]);

                    list.Add(o);
                }
                objSqlConnection.Close();
                list.TrimExcess();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return list;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OrderPostInfo> getReportByMonth(DateTime date)
        {
            List<OrderPostInfo> list = new List<OrderPostInfo>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from OrderPostInfo where (month(Date)='" + date.Month + "'and year(Date)='" + date.Year + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    OrderPostInfo o = new OrderPostInfo();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                    o.GatePass = Convert.ToString(dr["GatePass"]);
                    o.BiltyNo = Convert.ToString(dr["BiltyNo"]);
                    o.GoodsCompanyID = Convert.ToInt16(dr["GoodsCompanyID"]);
                    o.ItemID = Convert.ToInt16(dr["ItemID"]);
                    o.StyleID = Convert.ToInt16(dr["StyleID"]);
                    o.SizeID = Convert.ToInt16(dr["SizeID"]);
                    o.ColorID = Convert.ToInt16(dr["ColorID"]);
                    o.Quantity = Convert.ToInt16(dr["Quantity"]);

                    list.Add(o);
                }
                objSqlConnection.Close();
                list.TrimExcess();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return list;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;

        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OrderPostInfo> getReportByMonthAndCustomerID(int customerID, DateTime date)
        {
            List<OrderPostInfo> list = new List<OrderPostInfo>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from OrderPostInfo where (month(Date)='" + date.Month + "' and year(Date)='" + date.Year + "' and DealerCustomerID='" + customerID + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    OrderPostInfo o = new OrderPostInfo();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                    o.GatePass = Convert.ToString(dr["GatePass"]);
                    o.BiltyNo = Convert.ToString(dr["BiltyNo"]);
                    o.GoodsCompanyID = Convert.ToInt16(dr["GoodsCompanyID"]);
                    o.ItemID = Convert.ToInt16(dr["ItemID"]);
                    o.StyleID = Convert.ToInt16(dr["StyleID"]);
                    o.SizeID = Convert.ToInt16(dr["SizeID"]);
                    o.ColorID = Convert.ToInt16(dr["ColorID"]);
                    o.Quantity = Convert.ToInt16(dr["Quantity"]);

                    list.Add(o);
                }
                objSqlConnection.Close();
                list.TrimExcess();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return list;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OrderPostInfo> getReportByMonthAndDealerID(int did,DateTime date)
        {
            List<OrderPostInfo> list = new List<OrderPostInfo>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from OrderPostInfo where (month(Date)='" + date.Month + "' and year(Date)='" + date.Year + "' and DealerID='" + did + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    OrderPostInfo o = new OrderPostInfo();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                    o.GatePass = Convert.ToString(dr["GatePass"]);
                    o.BiltyNo = Convert.ToString(dr["BiltyNo"]);
                    o.GoodsCompanyID = Convert.ToInt16(dr["GoodsCompanyID"]);
                    o.ItemID = Convert.ToInt16(dr["ItemID"]);
                    o.StyleID = Convert.ToInt16(dr["StyleID"]);
                    o.SizeID = Convert.ToInt16(dr["SizeID"]);
                    o.ColorID = Convert.ToInt16(dr["ColorID"]);
                    o.Quantity = Convert.ToInt16(dr["Quantity"]);

                    list.Add(o);
                }
                objSqlConnection.Close();
                list.TrimExcess();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return list;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OrderPostInfo> getReportByMonthDealerAndCustomerID(int did,int cid, DateTime date)
        {
            List<OrderPostInfo> list = new List<OrderPostInfo>();
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from OrderPostInfo where (month(Date)='" + date.Month + "' and year(Date)='" + date.Year + "' and DealerID='" + did + "' and DealerCustomerID='" + cid + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    OrderPostInfo o = new OrderPostInfo();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
                    o.GatePass = Convert.ToString(dr["GatePass"]);
                    o.BiltyNo = Convert.ToString(dr["BiltyNo"]);
                    o.GoodsCompanyID = Convert.ToInt16(dr["GoodsCompanyID"]);
                    o.ItemID = Convert.ToInt16(dr["ItemID"]);
                    o.StyleID = Convert.ToInt16(dr["StyleID"]);
                    o.SizeID = Convert.ToInt16(dr["SizeID"]);
                    o.ColorID = Convert.ToInt16(dr["ColorID"]);
                    o.Quantity = Convert.ToInt16(dr["Quantity"]);

                    list.Add(o);
                }
                objSqlConnection.Close();
                list.TrimExcess();
                ///////////////////////////////////////---Reallocate the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                dr.Dispose();
                //////////////////////////////////////
                return list;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error Accessing Database  " + exp.ToString());
            }
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
