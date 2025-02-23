using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class OrderPreInfoDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public DataSet getDailyReport()
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderePreInfo where (Date = '" + DateTime.Today+ "')", objSqlConnection);

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
                dataRow[7] = Convert.ToDateTime(dr["Date"]);

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
        public DataSet getDailyReportByDealer(int dealerID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderePreInfo where (DealerID='"+dealerID+"' and Date = '" + DateTime.Today + "')", objSqlConnection);

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
                dataRow[7] = Convert.ToDateTime(dr["Date"]);

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
        public DataSet getDailyReport(int customerID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderePreInfo where (DealerCustomerID='"+customerID+"' and Date = '" + DateTime.Today + "')", objSqlConnection);

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
                dataRow[7] = Convert.ToDateTime(dr["Date"]);

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
        public DataSet getSelectedDayReport(DateTime date)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderePreInfo where (year(Date) = '" + date.Year+ "' and month(Date)='"+date.Month+"' and day(Date)='"+date.Day+"')", objSqlConnection);

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
                dataRow[7] = Convert.ToDateTime(dr["Date"]);

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
        public DataSet getSelectedDayReportByDealer(DateTime date,int dealerID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderePreInfo where (DealerID='"+dealerID+"' and year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);

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
                dataRow[7] = Convert.ToDateTime(dr["Date"]);

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
        public DataSet getSelectedDayReportByCustomer(DateTime date,int customerID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderePreInfo where (DealerCustomerID='"+customerID+"' and year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);

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
                dataRow[7] = Convert.ToDateTime(dr["Date"]);

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
        public DataSet getMonthlyReport(DateTime date)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderePreInfo where (year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "')", objSqlConnection);

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
                dataRow[7] = Convert.ToDateTime(dr["Date"]);

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
        public DataSet getMonthlyReportByDealer(DateTime date,int dealerID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderePreInfo where (DealerID='"+dealerID+"' and year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "')", objSqlConnection);

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
                dataRow[7] = Convert.ToDateTime(dr["Date"]);

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
        public DataSet getMonthlyReportByCustomer(DateTime date,int customerID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OrderePreInfo where (DealerCustomerID='"+customerID+"' and year(Date) = '" + date.Year + "' and month(Date)='" + date.Month + "')", objSqlConnection);

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
                dataRow[7] = Convert.ToDateTime(dr["Date"]);

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
        public void addOrder(OrderPreInfo obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("insert into OrderePreInfo(Date,ItemID,StyleID,SizeID,ColorID,Quantity,DealerID,DealerCustomerID)values('" + obj.Date + "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.ColorID + "','" + obj.Quantity + "','" + obj.DealerID + "','" + obj.DealerCustomerID + "')", objSqlConnection);
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
        public void updateOrder(OrderPreInfo obj)
        {
            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("UPDATE OrderePreInfo SET ItemID='" + obj.ItemID + "',StyleID='" + obj.StyleID + "',SizeID='" + obj.SizeID + "',ColorID='" + obj.ColorID + "',Quantity='" + obj.Quantity + "' WHERE (Date='" + obj.Date + "'and DealerID='" + obj.DealerID + "'and DealerCustomerID='" + obj.DealerCustomerID + "')", objSqlConnection);
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
        public void deleteOrder(OrderPreInfo objec)
        {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("Delete from OrderePreInfo WHERE (year(Date)='" + objec.Date.Year + "' and month(Date)='" + objec.Date.Month + "' and day(Date)='" + objec.Date.Day + "' and DealerID='" + objec.DealerID + "' and DealerCustomerID='" + objec.DealerCustomerID + "' and ItemID='" + objec.ItemID + "' and StyleID='" + objec.StyleID + "' and SizeID='" + objec.SizeID + "' and ColorID='" + objec.ColorID + "' and Quantity='" + objec.Quantity + "')", objSqlConnection);
                objSqlConnection.Open();
                objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
                ///////////////////////////////////////---Release the resources
                objSqlConnection.Dispose();
                objSqlCommand.Dispose();
                //////////////////////////////////////
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OrderPreInfo> getReportByDate(DateTime date)
        {
            List<OrderPreInfo> list = new List<OrderPreInfo>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from OrderePreInfo where (year(Date)='" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    OrderPreInfo o = new OrderPreInfo();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
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
        public List<OrderPreInfo> getReportByDateAndDealer(DateTime date,int dealerID)
        {
            List<OrderPreInfo> list = new List<OrderPreInfo>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from OrderePreInfo where (year(Date)='" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "' and DealerID='"+dealerID+"')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    OrderPreInfo o = new OrderPreInfo();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
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
        public List<OrderPreInfo> getReportByDateDealerAndCustomer(DateTime date, int did,int cid)
        {
            List<OrderPreInfo> list = new List<OrderPreInfo>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from OrderePreInfo where (year(Date)='" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "' and DealerID='" + did+ "' and DealerCustomerID='"+cid+"')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    OrderPreInfo o = new OrderPreInfo();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
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
        public List<OrderPreInfo> getReportByMonth(DateTime date)
        {
            List<OrderPreInfo> list = new List<OrderPreInfo>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from OrderePreInfo where (month(Date)='" + date.Month + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    OrderPreInfo o = new OrderPreInfo();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
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
        public List<OrderPreInfo> getReportByMonthAndDealer(DateTime date, int dealerID)
        {
            List<OrderPreInfo> list = new List<OrderPreInfo>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from OrderePreInfo where (month(Date)='" + date.Month + "'and year(Date)='" + date.Year + "' and DealerID='" + dealerID + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    OrderPreInfo o = new OrderPreInfo();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
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
        public List<OrderPreInfo> getReportByMonthDealerAndCustomer(DateTime date, int did, int cid)
        {
            List<OrderPreInfo> list = new List<OrderPreInfo>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from OrderePreInfo where (month(Date)='" + date.Month + "'and year(Date)='" + date.Year + "' and DealerID='" + did + "' and DealerCustomerID='" + cid + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    OrderPreInfo o = new OrderPreInfo();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
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
        public List<OrderPreInfo> getReportByYear(DateTime date)
        {
            List<OrderPreInfo> list = new List<OrderPreInfo>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from OrderePreInfo where (year(Date)='" + date.Year + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    OrderPreInfo o = new OrderPreInfo();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
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
        public List<OrderPreInfo> getReportByYearAndDealer(DateTime date, int dealerID)
        {
            List<OrderPreInfo> list = new List<OrderPreInfo>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from OrderePreInfo where (DealerID='" + dealerID + "'and year(Date)='" + date.Year + "')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    OrderPreInfo o = new OrderPreInfo();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
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
        public List<OrderPreInfo> getReportByYearDealerAndCustomer(DateTime date, int did, int cid)
        {
            List<OrderPreInfo> list = new List<OrderPreInfo>();

            try
            {
                ConnectionDB objConnectionDB = new ConnectionDB();
                SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
                SqlCommand objSqlCommand = new SqlCommand("select * from OrderePreInfo where (DealerID='" + did + "' and DealerCustomerID='" + cid + "' and year(Date)='"+date.Year+"')", objSqlConnection);

                SqlDataReader dr = null;
                objSqlConnection.Open();
                dr = objSqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    OrderPreInfo o = new OrderPreInfo();
                    o.Date = Convert.ToDateTime(dr["Date"]);
                    o.DealerID = Convert.ToInt32(dr["DealerID"]);
                    o.DealerCustomerID = Convert.ToInt32(dr["DealerCustomerID"]);
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
        public bool checkIsOrderExist(OrderPreInfo obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from OrderePreInfo where (DealerID='" + obj.DealerID + "' and DealerCustomerID='" + obj.DealerCustomerID + "' and day(Date)='" + obj.Date.Day + "' and month(Date)='" + obj.Date.Month + "' and year(Date)='" + obj.Date.Year + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' and ColorID='" + obj.ColorID + "' )", objSqlConnection);

            bool c=false;
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                c=true;
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return c;
        }
        //-------------------------------------------------------------------------------------------------------
        public Int16 getOrderQuantity(OrderPreInfo obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from OrderePreInfo where (DealerID='" + obj.DealerID + "' and DealerCustomerID='" + obj.DealerCustomerID + "' and day(Date)='" + obj.Date.Day + "' and month(Date)='" + obj.Date.Month + "' and year(Date)='" + obj.Date.Year + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' and ColorID='" + obj.ColorID + "')", objSqlConnection);

            Int16 c = 0;
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                c = Convert.ToInt16(dr["Quantity"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();    
            dr.Dispose();
            //////////////////////////////////////
            return c;
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
