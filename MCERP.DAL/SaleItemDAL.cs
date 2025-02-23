//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Data;
//using System.Data.SqlClient;
//using MCERP.Entities;
//namespace MCERP.DAL
//{
//    public class SaleItemDAL
//    {
//        public DataSet getDailyReport(DateTime date)
//        {
//            ItemDAL item = new ItemDAL();
//            DALItemStyle style = new DALItemStyle();
//            ItemSizeDAL size = new ItemSizeDAL();
//            ColorDAL color = new ColorDAL();

//            ConnectionDB objConnectionDB = new ConnectionDB();
//            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
//            SqlCommand objSqlCommand = new SqlCommand("select * from SaleItem where (Date = '" + date + "')", objSqlConnection);

//            SqlDataReader dr = null;
//            objSqlConnection.Open();
//            dr = objSqlCommand.ExecuteReader();
//            DataSet ds = new DataSet();
//            DataTable dt = new DataTable();
//            DataRow dataRow;
//            dt.Columns.Add("Buyer", typeof(string));
//            dt.Columns.Add("Item", typeof(string));
//            dt.Columns.Add("Style", typeof(string));
//            dt.Columns.Add("Size", typeof(string));
//            dt.Columns.Add("Color", typeof(string));
//            dt.Columns.Add("Quantity", typeof(int));
//            dt.Columns.Add("Date", typeof(DateTime));

//            ds.Tables.Add(dt);
//            while (dr.Read())
//            {
//                dataRow = ds.Tables[0].NewRow();
//                dataRow[0] = Convert.ToString(dr["Buyer"]);
//                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
//                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
//                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
//                dataRow[4] = color.getColorName(Convert.ToInt16(dr["Color"]));
//                dataRow[5] = Convert.ToInt16(dr["Quantity"]);
//                dataRow[6] = Convert.ToDateTime(dr["Date"]);

//                ds.Tables[0].Rows.Add(dataRow);

//            }
//            objSqlConnection.Close();
//            ///////////////////////////////////////---Reallocate the resources
//            objSqlConnection.Dispose();
//            objSqlCommand.Dispose();
//            dr.Dispose();
//            //////////////////////////////////////
//            return ds;
//        }
//        //-------------------------------------------------------------------------------------------------------
//        //-------------------------------------------------------------------------------------------------------
//        public DataSet getMonthlyReportDataset(DateTime date)
//        {
//            ItemDAL item = new ItemDAL();
//            DALItemStyle style = new DALItemStyle();
//            ItemSizeDAL size = new ItemSizeDAL();
//            ColorDAL color = new ColorDAL();

//            ConnectionDB objConnectionDB = new ConnectionDB();
//            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
//            SqlCommand objSqlCommand = new SqlCommand("select * from SaleItem where (month(Date) = '" + date.Month+ "' and year(Date)='" + date.Year + "')", objSqlConnection);

//            SqlDataReader dr = null;
//            objSqlConnection.Open();
//            dr = objSqlCommand.ExecuteReader();
//            DataSet ds = new DataSet();
//            DataTable dt = new DataTable();
//            DataRow dataRow;
//            dt.Columns.Add("Buyer", typeof(string));
//            dt.Columns.Add("Item", typeof(string));
//            dt.Columns.Add("Style", typeof(string));
//            dt.Columns.Add("Size", typeof(string));
//            dt.Columns.Add("Color", typeof(string));
//            dt.Columns.Add("Quantity", typeof(int));
//            dt.Columns.Add("Date", typeof(DateTime));

//            ds.Tables.Add(dt);
//            while (dr.Read())
//            {
//                dataRow = ds.Tables[0].NewRow();
//                dataRow[0] = Convert.ToString(dr["Buyer"]);
//                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
//                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
//                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
//                dataRow[4] = color.getColorName(Convert.ToInt16(dr["Color"]));
//                dataRow[5] = Convert.ToInt16(dr["Quantity"]);
//                dataRow[6] = Convert.ToDateTime(dr["Date"]);

//                ds.Tables[0].Rows.Add(dataRow);


//            }
//            objSqlConnection.Close();
//            ///////////////////////////////////////---Reallocate the resources
//            objSqlConnection.Dispose();
//            objSqlCommand.Dispose();
//            dr.Dispose();
//            //////////////////////////////////////
//            return ds;
//        }
//        //-------------------------------------------------------------------------------------------------------
//        //-------------------------------------------------------------------------------------------------------
//        public void addReport(SaleItem obj)
//        {
//            ConnectionDB objConnectionDB = new ConnectionDB();
//            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
//            SqlCommand objSqlCommand = new SqlCommand("insert into SaleItem (Buyer,Date,ItemID,StyleID,SizeID,Quantity,ColorID)values('" + obj.Buyer+ "','" + obj.Date+ "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.Quantity + "','" + obj.ColorID+ "')", objSqlConnection);
//            objSqlConnection.Open();
//            objSqlCommand.ExecuteNonQuery();
//            objSqlConnection.Close();
//            ///////////////////////////////////////---Release the resources
//            objSqlConnection.Dispose();
//            objSqlCommand.Dispose();
//            //////////////////////////////////////
//        }
//        //-------------------------------------------------------------------------------------------------------
//        //-------------------------------------------------------------------------------------------------------
//        public void deleteReport(GreenWareHouseBreakage obj)
//        {

//            ConnectionDB objConnectionDB = new ConnectionDB();
//            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
//            SqlCommand objSqlCommand = new SqlCommand("Delete from GreenWareHouseBreakage WHERE (WorkerID='" + obj.WorkerID + "'and Date='" + obj.Date + "'and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and Quantity='" + obj.Quantity + "' and BreakageType='"+obj.BreakageType+"')", objSqlConnection);
//            objSqlConnection.Open();
//            objSqlCommand.ExecuteNonQuery();
//            objSqlConnection.Close();
//            ///////////////////////////////////////---Release the resources
//            objSqlConnection.Dispose();
//            objSqlCommand.Dispose();
//            //////////////////////////////////////

//        }
//        //-------------------------------------------------------------------------------------------------------
//        //-------------------------------------------------------------------------------------------------------
//        public List<GreenWareHouseBreakage> getReportByDate(DateTime date)
//        {
//            ConnectionDB objConnectionDB = new ConnectionDB();
//            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
//            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseBreakage where (Date = '" + date + "')", objSqlConnection);

//            SqlDataReader dr = null;
//            objSqlConnection.Open();
//            dr = objSqlCommand.ExecuteReader();
//            List<GreenWareHouseBreakage> list = new List<GreenWareHouseBreakage>();
//            GreenWareHouseBreakage g;
//            while (dr.Read())
//            {
//                g = new GreenWareHouseBreakage();
//                g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
//                g.Date = Convert.ToDateTime(dr["Date"]);
//                g.ItemID = Convert.ToInt16(dr["ItemID"]);
//                g.StyleID = Convert.ToInt16(dr["StyleID"]);
//                g.SizeID = Convert.ToInt16(dr["SizeID"]);
//                g.Quantity = Convert.ToInt16(dr["Quantity"]);
//                g.BreakageType = Convert.ToString(dr["BreakageType"]);
//                g.Remarks = Convert.ToString(dr["Remarks"]);

//                list.Add(g);
//            }
//            objSqlConnection.Close();
//            list.TrimExcess();
//            ///////////////////////////////////////---Reallocate the resources
//            objSqlConnection.Dispose();
//            objSqlCommand.Dispose();
//            dr.Dispose();
//            //////////////////////////////////////
//            return list;
//        }
//        //-------------------------------------------------------------------------------------------------------
//        //-------------------------------------------------------------------------------------------------------
//        public List<GreenWareHouseBreakage> getMonthlyReport(Int16 month,Int16 year)
//        {
//            ConnectionDB objConnectionDB = new ConnectionDB();
//            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
//            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseBreakage where (month(Date) = '" + month + "' and year(Date)='"+year+"')", objSqlConnection);

//            SqlDataReader dr = null;
//            objSqlConnection.Open();
//            dr = objSqlCommand.ExecuteReader();
//            List<GreenWareHouseBreakage> list = new List<GreenWareHouseBreakage>();
//            while (dr.Read())
//            {
//                GreenWareHouseBreakage g = new GreenWareHouseBreakage();
//                g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
//                g.Date = Convert.ToDateTime(dr["Date"]);
//                g.ItemID = Convert.ToInt16(dr["ItemID"]);
//                g.StyleID = Convert.ToInt16(dr["StyleID"]);
//                g.SizeID = Convert.ToInt16(dr["SizeID"]);
//                g.Quantity = Convert.ToInt16(dr["Quantity"]);
//                g.BreakageType = Convert.ToString(dr["BreakageType"]);
//                g.Remarks = Convert.ToString(dr["Remarks"]);

//                list.Add(g);
//            }
//            objSqlConnection.Close();
//            list.TrimExcess();
//            ///////////////////////////////////////---Reallocate the resources
//            objSqlConnection.Dispose();
//            objSqlCommand.Dispose();
//            dr.Dispose();
//            //////////////////////////////////////
//            return list;
//        }
//        //-------------------------------------------------------------------------------------------------------
//        //-------------------------------------------------------------------------------------------------------
//        public List<GreenWareHouseBreakage> getReportByDateAndWorker(DateTime date, int workerID)
//        {
//            ConnectionDB objConnectionDB = new ConnectionDB();
//            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
//            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseBreakage where (Date = '" + date + "'and WorkerID='" + workerID + "')", objSqlConnection);

//            SqlDataReader dr = null;
//            objSqlConnection.Open();
//            dr = objSqlCommand.ExecuteReader();
//            List<GreenWareHouseBreakage> list = new List<GreenWareHouseBreakage>();
//            while (dr.Read())
//            {
//                GreenWareHouseBreakage g = new GreenWareHouseBreakage();
//                g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
//                g.Date = Convert.ToDateTime(dr["Date"]);
//                g.ItemID = Convert.ToInt16(dr["ItemID"]);
//                g.StyleID = Convert.ToInt16(dr["StyleID"]);
//                g.SizeID = Convert.ToInt16(dr["SizeID"]);
//                g.Quantity = Convert.ToInt16(dr["Quantity"]);
//                g.BreakageType = Convert.ToString(dr["BreakageType"]);
//                g.Remarks = Convert.ToString(dr["Remarks"]);

//                list.Add(g);
//            }
//            objSqlConnection.Close();
//            list.TrimExcess();
//            ///////////////////////////////////////---Reallocate the resources
//            objSqlConnection.Dispose();
//            objSqlCommand.Dispose();
//            dr.Dispose();
//            //////////////////////////////////////
//            return list;
//        }
//        //-------------------------------------------------------------------------------------------------------
//        //-------------------------------------------------------------------------------------------------------
//        public List<GreenWareHouseBreakage> getGlazingReportByDateAndItem(DateTime date, Int16 itemID)
//        {
//            ConnectionDB objConnectionDB = new ConnectionDB();
//            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
//            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseBreakage where (Date = '" + date + "'and ItemID='" + itemID + "')", objSqlConnection);

//            SqlDataReader dr = null;
//            objSqlConnection.Open();
//            dr = objSqlCommand.ExecuteReader();
//            List<GreenWareHouseBreakage> list = new List<GreenWareHouseBreakage>();
//            while (dr.Read())
//            {
//                GreenWareHouseBreakage g = new GreenWareHouseBreakage();
//                g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
//                g.Date = Convert.ToDateTime(dr["Date"]);
//                g.ItemID = Convert.ToInt16(dr["ItemID"]);
//                g.StyleID = Convert.ToInt16(dr["StyleID"]);
//                g.SizeID = Convert.ToInt16(dr["SizeID"]);
//                g.Quantity = Convert.ToInt16(dr["Quantity"]);
//                g.BreakageType = Convert.ToString(dr["BreakageType"]);
//                g.Remarks = Convert.ToString(dr["Remarks"]);

//                list.Add(g);
//            }
//            objSqlConnection.Close();
//            list.TrimExcess();
//            ///////////////////////////////////////---Reallocate the resources
//            objSqlConnection.Dispose();
//            objSqlCommand.Dispose();
//            dr.Dispose();
//            //////////////////////////////////////
//            return list;
//        }
//        //-------------------------------------------------------------------------------------------------------
//        //-------------------------------------------------------------------------------------------------------
//        public List<GreenWareHouseBreakage> getGlazingReportByDateAndStyle(DateTime date, Int16 styleID)
//        {
//            ConnectionDB objConnectionDB = new ConnectionDB();
//            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
//            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseBreakage where (Date = '" + date + "'and StyleID='" + styleID + "')", objSqlConnection);

//            SqlDataReader dr = null;
//            objSqlConnection.Open();
//            dr = objSqlCommand.ExecuteReader();
//            List<GreenWareHouseBreakage> list = new List<GreenWareHouseBreakage>();
//            while (dr.Read())
//            {
//                GreenWareHouseBreakage g = new GreenWareHouseBreakage();
//                g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
//                g.Date = Convert.ToDateTime(dr["Date"]);
//                g.ItemID = Convert.ToInt16(dr["ItemID"]);
//                g.StyleID = Convert.ToInt16(dr["StyleID"]);
//                g.SizeID = Convert.ToInt16(dr["SizeID"]);
//                g.Quantity = Convert.ToInt16(dr["Quantity"]);
//                g.BreakageType = Convert.ToString(dr["BreakageType"]);
//                g.Remarks = Convert.ToString(dr["Remarks"]);

//                list.Add(g);
//            }
//            objSqlConnection.Close();
//            list.TrimExcess();
//            ///////////////////////////////////////---Reallocate the resources
//            objSqlConnection.Dispose();
//            objSqlCommand.Dispose();
//            dr.Dispose();
//            //////////////////////////////////////
//            return list;
//        }
//        //-------------------------------------------------------------------------------------------------------
//    }
//}
