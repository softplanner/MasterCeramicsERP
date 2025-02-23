using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class DailyGlazingReportDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public bool checkIsReportExist(DailyGlazingReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from DailyGlazingReport where (SprayManID='"+obj.SprayManID+"' and Date='"+obj.Date+"' and ItemID='"+obj.ItemID+"' and StyleID='"+obj.StyleID+"' and SizeID='"+obj.SizeID+"' and ColorID='"+obj.ColorID+"')", objSqlConnection);
            SqlDataReader dr = null;
            bool b = false;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                b = true;
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return b;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public Int16 getCuurentReportQuantity(DailyGlazingReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from DailyGlazingReport where (SprayManID='" + obj.SprayManID + "' and Date='" + obj.Date + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' and ColorID='" + obj.ColorID + "')", objSqlConnection);
            SqlDataReader dr = null;
            Int16 b = 0;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                b = Convert.ToInt16(dr["Quantity"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return b;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void addGlazingReport(DailyGlazingReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into DailyGlazingReport(GlazeHouseID,SprayManID,Date,ItemID,StyleID,SizeID,ColorID,Quantity)values('" + obj.GlazedHouseID + "','" + obj.SprayManID + "','" + obj.Date + "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.ColorID + "','" + obj.Quantity + "')", objSqlConnection);
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
        public void updateGlazingReport(DailyGlazingReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE  DailyGlazingReport SET Quantity='"+obj.Quantity+"' WHERE (GlazeHouseID='" +obj.GlazedHouseID  + "'and SprayManID='"+obj.SprayManID+"' and ItemID='"+obj.ItemID+"'and StyleID='"+obj.StyleID+"'and SizeID='"+obj.SizeID+"'and ColorID='"+obj.ColorID+"')", objSqlConnection);
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
        public void deleteGlazingReport(DailyGlazingReport obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from DailyGlazingReport WHERE (GlazeHouseID='" + obj.GlazedHouseID + "'and SprayManID='" + obj.SprayManID + "'and Date='" + obj.Date + "'and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and ColorID='" + obj.ColorID + "'and Quantity='" + obj.Quantity + "')", objSqlConnection);
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
        public List<DailyGlazingReport> getGlazingReportByDate(DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyGlazingReport where (Date = '" + date + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyGlazingReport> list = new List<DailyGlazingReport>();
            while (dr.Read())
            {
                DailyGlazingReport g = new DailyGlazingReport();
                g.GlazedHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);

                list.Add(g);
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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<DailyGlazingReport> getGlazingReportByDateAndGlazeHouse(DateTime date,Int16 glazeHouseID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyGlazingReport where (Date = '" + date + "'and GlazeHouseID='"+glazeHouseID+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyGlazingReport> list = new List<DailyGlazingReport>();
            while (dr.Read())
            {
                DailyGlazingReport g = new DailyGlazingReport();
                g.GlazedHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);

                list.Add(g);
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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<DailyGlazingReport> getGlazingReportByDateAndSprayMan(DateTime date,int sprayManID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyGlazingReport where (Date = '" + date + "'and SprayManID='"+sprayManID+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyGlazingReport> list = new List<DailyGlazingReport>();
            while (dr.Read())
            {
                DailyGlazingReport g = new DailyGlazingReport();
                g.GlazedHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);

                list.Add(g);
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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<DailyGlazingReport> getGlazingReportByDateAndColor(DateTime date, Int16 colorID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyGlazingReport where (Date = '" + date + "'and ColorID='" + colorID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyGlazingReport> list = new List<DailyGlazingReport>();
            while (dr.Read())
            {
                DailyGlazingReport g = new DailyGlazingReport();
                g.GlazedHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);

                list.Add(g);
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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<DailyGlazingReport> getGlazingReportByDateAndItem(DateTime date, Int16 itemID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyGlazingReport where (Date = '" + date + "'and ItemID='" + itemID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyGlazingReport> list = new List<DailyGlazingReport>();
            while (dr.Read())
            {
                DailyGlazingReport g = new DailyGlazingReport();
                g.GlazedHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);

                list.Add(g);
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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<DailyGlazingReport> getGlazingReportByDateAndStyle(DateTime date, Int16 styleID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyGlazingReport where (Date = '" + date + "'and StyleID='" + styleID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyGlazingReport> list = new List<DailyGlazingReport>();
            while (dr.Read())
            {
                DailyGlazingReport g = new DailyGlazingReport();
                g.GlazedHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);

                list.Add(g);
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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<DailyGlazingReport> getDayReport(DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyGlazingReport where (Date = '" + date + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyGlazingReport> list = new List<DailyGlazingReport>();
            while (dr.Read())
            {
                DailyGlazingReport g = new DailyGlazingReport();
                g.GlazedHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);

                list.Add(g);
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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<DailyGlazingReport> getDailyReport(DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyGlazingReport where (day(Date) = '" + date.Day + "' and month(Date) = '" + date.Month + "' and year(Date) = '" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyGlazingReport> list = new List<DailyGlazingReport>();
            while (dr.Read())
            {
                DailyGlazingReport g = new DailyGlazingReport();
                g.GlazedHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);

                list.Add(g);
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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<DailyGlazingReport> getMonthlyReport(DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyGlazingReport where (month(Date) = '" + date.Month + "' and year(Date)='"+date.Year+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyGlazingReport> list = new List<DailyGlazingReport>();
            while (dr.Read())
            {
                DailyGlazingReport g = new DailyGlazingReport();
                g.GlazedHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);

                list.Add(g);
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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<DailyGlazingReport> getYearlyReport(DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyGlazingReport where (year(Date)='" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyGlazingReport> list = new List<DailyGlazingReport>();
            while (dr.Read())
            {
                DailyGlazingReport g = new DailyGlazingReport();
                g.GlazedHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);

                list.Add(g);
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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getYearlyGlazingReport(DateTime d)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            GlazeHouseDAL glazehouseDAL = new GlazeHouseDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyGlazingReport where (year(Date)='" + d.Year+ "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyGlazingReport> list = new List<DailyGlazingReport>();
            DailyGlazingReport g;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Glaze House", typeof(string));
            dt.Columns.Add("Spray Man", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                g = new DailyGlazingReport();
                g.GlazedHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);

                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = glazehouseDAL.getGlazeHouseName(g.GlazedHouseID);
                dataRow[1] = personDAL.getPersonName(g.SprayManID);
                dataRow[2] = item.getItemName(g.ItemID);
                dataRow[3] = style.getItemStyleName(g.StyleID);
                dataRow[4] = size.getItemSizeName(g.SizeID);
                dataRow[5] = color.getColorName(g.ColorID);
                dataRow[6] = g.Quantity;
                dataRow[7] = g.Date;
                ds.Tables[0].Rows.Add(dataRow);

            }
            objSqlConnection.Close();
            list.TrimExcess();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getMonthlyStockReport(DateTime date)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            GlazeHouseDAL glazehouseDAL = new GlazeHouseDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyGlazingReport where (month(Date) = '" + date.Month + "' and year(Date)='" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyGlazingReport> list = new List<DailyGlazingReport>();
            DailyGlazingReport g;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Glaze House", typeof(string));
            dt.Columns.Add("Spray Man", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                g = new DailyGlazingReport();
                g.GlazedHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);

                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = glazehouseDAL.getGlazeHouseName(g.GlazedHouseID);
                dataRow[1] = personDAL.getPersonName(g.SprayManID);
                dataRow[2] = item.getItemName(g.ItemID);
                dataRow[3] = style.getItemStyleName(g.StyleID);
                dataRow[4] = size.getItemSizeName(g.SizeID);
                dataRow[5] = color.getColorName(g.ColorID);
                dataRow[6] = g.Quantity;
                dataRow[7] = g.Date;
                ds.Tables[0].Rows.Add(dataRow);

            }
            objSqlConnection.Close();
            list.TrimExcess();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getDailyStockReport(DateTime date)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            GlazeHouseDAL glazehouseDAL = new GlazeHouseDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyGlazingReport where (day(Date) = '" + date.Day + "' and month(Date) = '" + date.Month + "' and year(Date) = '" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyGlazingReport> list = new List<DailyGlazingReport>();
            DailyGlazingReport g;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Glaze House", typeof(string));
            dt.Columns.Add("Spray Man", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                g = new DailyGlazingReport();
                g.GlazedHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);

                dataRow = ds.Tables[0].NewRow();

                dataRow[0] = glazehouseDAL.getGlazeHouseName(g.GlazedHouseID);
                dataRow[1] = personDAL.getPersonName(g.SprayManID);
                dataRow[2] = item.getItemName(g.ItemID);
                dataRow[3] = style.getItemStyleName(g.StyleID);
                dataRow[4] = size.getItemSizeName(g.SizeID);
                dataRow[5] = color.getColorName(g.ColorID);
                dataRow[6] = g.Quantity;
                dataRow[7] = g.Date;
                ds.Tables[0].Rows.Add(dataRow);

            }
            objSqlConnection.Close();
            list.TrimExcess();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return ds;
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
