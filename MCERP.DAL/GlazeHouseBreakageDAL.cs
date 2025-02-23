using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class GlazeHouseBreakageDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public bool checkIsReportExist(GlazeHouseBreakage obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from GlazeHouseBreakage where (Date = '" + obj.Date + "' and SprayManID='"+obj.SprayManID+"' and ItemID='"+obj.ItemID+"' and StyleID='"+obj.StyleID+"' and SizeID='"+obj.SizeID+"' and ColorID='"+obj.ColorID+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            bool b = false;
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
        public Int16 getCurrentReportStock(GlazeHouseBreakage obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from GlazeHouseBreakage where (Date = '" + obj.Date + "' and SprayManID='" + obj.SprayManID + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' and ColorID='" + obj.ColorID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            Int16 b= 0;
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
        public void addReport(GlazeHouseBreakage obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into GlazeHouseBreakage(SprayManID,Date,ItemID,StyleID,SizeID,ColorID,Quantity,Remarks)values('" + obj.SprayManID + "','" + obj.Date + "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.ColorID + "','" + obj.Quantity + "','"+obj.Remarks+"')", objSqlConnection);
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
        public void updateGlazingReport(GlazeHouseBreakage obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE  GlazeHouseBreakage SET Quantity ='" + obj.Quantity + "' WHERE (SprayManID='" + obj.SprayManID + "' and Date='" + obj.Date + "'and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' and ColorID='" + obj.ColorID + "')", objSqlConnection);
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
        public void deleteGlazingReport(GlazeHouseBreakage obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from GlazeHouseBreakage WHERE (SprayManID='" + obj.SprayManID + "'and Date='" + obj.Date + "'and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and ColorID='" + obj.ColorID + "'and Quantity='" + obj.Quantity + "'and Remarks='" + obj.Remarks + "')", objSqlConnection);
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
        public List<GlazeHouseBreakage> getReportByDay(DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseBreakage where (day(Date) = '" + date.Day + "' and month(Date) = '" + date.Month + "' and year(Date) = '" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeHouseBreakage> list = new List<GlazeHouseBreakage>();
            while (dr.Read())
            {
                GlazeHouseBreakage g = new GlazeHouseBreakage();
                 g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);
                g.Remarks= Convert.ToString(dr["Remarks"]);

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
        ////-------------------------------------------------------------------------------------------------------
        //public List<GlazeHouseBreakage> getReportByDayAndGlazeHouse(DateTime date,Int16 glazeHouseID)
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseBreakage where (Date = '" + date + "' and GlazeHouseID='"+glazeHouseID+"')", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    List<GlazeHouseBreakage> list = new List<GlazeHouseBreakage>();
        //    while (dr.Read())
        //    {
        //        GlazeHouseBreakage g = new GlazeHouseBreakage();
        //        g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
        //        g.Date = Convert.ToDateTime(dr["Date"]);
        //        g.ItemID = Convert.ToInt16(dr["ItemID"]);
        //        g.StyleID = Convert.ToInt16(dr["StyleID"]);
        //        g.SizeID = Convert.ToInt16(dr["SizeID"]);
        //        g.ColorID = Convert.ToInt16(dr["ColorID"]);
        //        g.Quantity = Convert.ToInt16(dr["Quantity"]);
        //         g.Remarks = Convert.ToString(dr["Remarks"]);

        //        list.Add(g);
        //    }
        //    objSqlConnection.Close();
        //    list.TrimExcess();
        //    ///////////////////////////////////////---Reallocate the resources
        //    objSqlConnection.Dispose();
        //    objSqlCommand.Dispose();
        //    dr.Dispose();
        //    //////////////////////////////////////
        //    return list;
        //}
        //-------------------------------------------------------------------------------------------------------
        public List<GlazeHouseBreakage> getReportByMonth(DateTime da)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseBreakage where (month(Date) = '" + da.Month + "' and year(Date)='"+da.Year+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeHouseBreakage> list = new List<GlazeHouseBreakage>();
            while (dr.Read())
            {
                GlazeHouseBreakage g = new GlazeHouseBreakage();
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);
                g.Remarks = Convert.ToString(dr["Remarks"]);

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
        public List<GlazeHouseBreakage> getReportByYear(DateTime da)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseBreakage where (year(Date)='" + da.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeHouseBreakage> list = new List<GlazeHouseBreakage>();
            while (dr.Read())
            {
                GlazeHouseBreakage g = new GlazeHouseBreakage();
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);
                g.Remarks = Convert.ToString(dr["Remarks"]);

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
        ////-------------------------------------------------------------------------------------------------------
        //public List<GlazeHouseBreakage> getReportByMonthAndGlazeHouse(Int16 month, Int16 year,Int16 glazehouseID)
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseBreakage where (month(Date) = '" + month + "' and year(Date)='" + year + "' and GlazeHouseID='"+glazehouseID+"')", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    List<GlazeHouseBreakage> list = new List<GlazeHouseBreakage>();
        //    while (dr.Read())
        //    {
        //        GlazeHouseBreakage g = new GlazeHouseBreakage();
        //        g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
        //        g.Date = Convert.ToDateTime(dr["Date"]);
        //        g.ItemID = Convert.ToInt16(dr["ItemID"]);
        //        g.StyleID = Convert.ToInt16(dr["StyleID"]);
        //        g.SizeID = Convert.ToInt16(dr["SizeID"]);
        //        g.ColorID = Convert.ToInt16(dr["ColorID"]);
        //        g.Quantity = Convert.ToInt16(dr["Quantity"]);
        //        g.Remarks = Convert.ToString(dr["Remarks"]);

        //        list.Add(g);
        //    }
        //    objSqlConnection.Close();
        //    list.TrimExcess();
        //    ///////////////////////////////////////---Reallocate the resources
        //    objSqlConnection.Dispose();
        //    objSqlCommand.Dispose();
        //    dr.Dispose();
        //    //////////////////////////////////////
        //    return list;
        //}
        ////-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<GlazeHouseBreakage> getGlazingReportByDateAndGlazeHouse(DateTime date, Int16 glazeHouseID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseBreakage where Date = '" + date + "'and GlazeHouseID='" + glazeHouseID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeHouseBreakage> list = new List<GlazeHouseBreakage>();
            while (dr.Read())
            {
                GlazeHouseBreakage g = new GlazeHouseBreakage();
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);
                g.Remarks = Convert.ToString(dr["Remarks"]);

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
        public List<GlazeHouseBreakage> getGlazingReportByDateAndSprayMan(DateTime date, int sprayManID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseBreakage where Date = '" + date + "'and SprayManID='" + sprayManID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeHouseBreakage> list = new List<GlazeHouseBreakage>();
            while (dr.Read())
            {
                GlazeHouseBreakage g = new GlazeHouseBreakage();
                 g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);
                 g.Remarks = Convert.ToString(dr["Remarks"]);

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
        public List<GlazeHouseBreakage> getGlazingReportByDateAndColor(DateTime date, Int16 colorID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseBreakage where Date = '" + date + "'and ColorID='" + colorID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeHouseBreakage> list = new List<GlazeHouseBreakage>();
            while (dr.Read())
            {
                GlazeHouseBreakage g = new GlazeHouseBreakage();
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);
                g.Remarks = Convert.ToString(dr["Remarks"]);

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
        public List<GlazeHouseBreakage> getGlazingReportByDateAndItem(DateTime date, Int16 itemID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseBreakage where Date = '" + date + "'and ItemID='" + itemID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeHouseBreakage> list = new List<GlazeHouseBreakage>();
            while (dr.Read())
            {
                GlazeHouseBreakage g = new GlazeHouseBreakage();
                g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);
                 g.Remarks = Convert.ToString(dr["Remarks"]);

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
        public List<GlazeHouseBreakage> getGlazingReportByDateAndStyle(DateTime date, Int16 styleID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseBreakage where Date = '" + date + "'and StyleID='" + styleID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GlazeHouseBreakage> list = new List<GlazeHouseBreakage>();
            while (dr.Read())
            {
                GlazeHouseBreakage g = new GlazeHouseBreakage();
                 g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.ColorID = Convert.ToInt16(dr["ColorID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);
                g.Remarks = Convert.ToString(dr["Remarks"]);

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
        public DataSet getDailyReport(DateTime date)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();
            GlazeHouseDAL glazeHouseDAL = new GlazeHouseDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseBreakage where (day(Date) = '" + date.Day + "' and month(Date) = '" + date.Month + "' and year(Date) = '" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Spray Man", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["SprayManID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[5] = Convert.ToInt16(dr["Quantity"]);
                dataRow[6] = Convert.ToString(dr["Remarks"]);
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
        ////-------------------------------------------------------------------------------------------------------
        //public DataSet getDailyReportAndGlazeHouse(DateTime date,Int16 glazeHouseID)
        //{
        //    ItemDAL item = new ItemDAL();
        //    DALItemStyle style = new DALItemStyle();
        //    ItemSizeDAL size = new ItemSizeDAL();
        //    ColorDAL color = new ColorDAL();
        //    PersonDAL personDAL = new PersonDAL();
        //    GlazeHouseDAL glazeHouseDAL = new GlazeHouseDAL();

        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseBreakage where (Date = '" + date + "' and GlazeHouseID='"+glazeHouseID+"')", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    GlazeHouseBreakage g;
        //    DataSet ds = new DataSet();
        //    DataTable dt = new DataTable();
        //    DataRow dataRow;
        //     dt.Columns.Add("Spray Man", typeof(string));
        //    dt.Columns.Add("Item", typeof(string));
        //    dt.Columns.Add("Style", typeof(string));
        //    dt.Columns.Add("Size", typeof(string));
        //    dt.Columns.Add("Color", typeof(string));
        //    dt.Columns.Add("Quantity", typeof(Int16));
        //    dt.Columns.Add("Remarks", typeof(string));
        //    dt.Columns.Add("Date", typeof(DateTime));
        //    ds.Tables.Add(dt);
        //    while (dr.Read())
        //    {
        //        g = new GlazeHouseBreakage();
        //        g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
        //        g.Date = Convert.ToDateTime(dr["Date"]);
        //        g.ItemID = Convert.ToInt16(dr["ItemID"]);
        //        g.StyleID = Convert.ToInt16(dr["StyleID"]);
        //        g.SizeID = Convert.ToInt16(dr["SizeID"]);
        //        g.ColorID = Convert.ToInt16(dr["ColorID"]);
        //        g.Quantity = Convert.ToInt16(dr["Quantity"]);
        //        g.Remarks = Convert.ToString(dr["Remarks"]);


        //        dataRow = ds.Tables[0].NewRow();
        //        dataRow[0] = personDAL.getPersonName(g.SprayManID);
        //        dataRow[1] = item.getItemName(g.ItemID);
        //        dataRow[2] = style.getItemStyleName(g.StyleID);
        //        dataRow[3] = size.getItemSizeName(g.SizeID);
        //        dataRow[4] = color.getColorName(g.ColorID);
        //        dataRow[5] = g.Quantity;
        //        dataRow[6] = g.Remarks;
        //        dataRow[7] = g.Date;

        //        ds.Tables[0].Rows.Add(dataRow);

        //    }
        //    objSqlConnection.Close();
        //    ///////////////////////////////////////---Reallocate the resources
        //    objSqlConnection.Dispose();
        //    objSqlCommand.Dispose();
        //    dr.Dispose();
        //    //////////////////////////////////////
        //    return ds;
        //}
        ////-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getMonthlyReport(DateTime d)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();
            GlazeHouseDAL glazeHouseDAL = new GlazeHouseDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseBreakage where (month(Date) = '" + d.Month + "' and year(Date)='" + d.Year+ "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Spray Man", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["SprayManID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[5] = Convert.ToInt16(dr["Quantity"]);
                dataRow[6] = Convert.ToString(dr["Remarks"]);
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
        public DataSet getYearlyReport(DateTime d)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();
            GlazeHouseDAL glazeHouseDAL = new GlazeHouseDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseBreakage where (year(Date)='" + d.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Spray Man", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["SprayManID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[5] = Convert.ToInt16(dr["Quantity"]);
                dataRow[6] = Convert.ToString(dr["Remarks"]);
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
        ////-------------------------------------------------------------------------------------------------------
        //public DataSet getMonthlyReportByGlazeHouse(Int16 month, Int16 year,Int16 glazeHouseID)
        //{
        //    ItemDAL item = new ItemDAL();
        //    DALItemStyle style = new DALItemStyle();
        //    ItemSizeDAL size = new ItemSizeDAL();
        //    ColorDAL color = new ColorDAL();
        //    PersonDAL personDAL = new PersonDAL();
        //    GlazeHouseDAL glazeHouseDAL = new GlazeHouseDAL();

        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from GlazeHouseBreakage where (month(Date) = '" + month + "' and year(Date)='" + year + "' and GlazeHouseID='"+glazeHouseID+"')", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    GlazeHouseBreakage g;
        //    DataSet ds = new DataSet();
        //    DataTable dt = new DataTable();
        //    DataRow dataRow;
        //    dt.Columns.Add("Glaze House", typeof(string));
        //    dt.Columns.Add("Spray Man", typeof(string));
        //    dt.Columns.Add("Breakage Type", typeof(string));
        //    dt.Columns.Add("Item", typeof(string));
        //    dt.Columns.Add("Style", typeof(string));
        //    dt.Columns.Add("Size", typeof(string));
        //    dt.Columns.Add("Color", typeof(string));
        //    dt.Columns.Add("Quantity", typeof(Int16));
        //    dt.Columns.Add("Remarks", typeof(string));
        //    dt.Columns.Add("Date", typeof(DateTime));
        //    ds.Tables.Add(dt);
        //    while (dr.Read())
        //    {
        //        g = new GlazeHouseBreakage();
        //        g.GlazedHouseID = Convert.ToInt16(dr["GlazeHouseID"]);
        //        g.SprayManID = Convert.ToInt32(dr["SprayManID"]);
        //        g.Date = Convert.ToDateTime(dr["Date"]);
        //        g.ItemID = Convert.ToInt16(dr["ItemID"]);
        //        g.StyleID = Convert.ToInt16(dr["StyleID"]);
        //        g.SizeID = Convert.ToInt16(dr["SizeID"]);
        //        g.ColorID = Convert.ToInt16(dr["ColorID"]);
        //        g.Quantity = Convert.ToInt16(dr["Quantity"]);
        //        g.BreakageType = Convert.ToString(dr["BreakageType"]);
        //        g.Remarks = Convert.ToString(dr["Remarks"]);


        //        dataRow = ds.Tables[0].NewRow();
        //        dataRow[0] = glazeHouseDAL.getGlazeHouseName(g.GlazedHouseID);
        //        dataRow[1] = personDAL.getPersonName(g.SprayManID);
        //        dataRow[2] = g.BreakageType;
        //        dataRow[3] = item.getItemName(g.ItemID);
        //        dataRow[4] = style.getItemStyleName(g.StyleID);
        //        dataRow[5] = size.getItemSizeName(g.SizeID);
        //        dataRow[6] = color.getColorName(g.ColorID);
        //        dataRow[7] = g.Quantity;
        //        dataRow[8] = g.Remarks;
        //        dataRow[9] = g.Date;

        //        ds.Tables[0].Rows.Add(dataRow);

        //    }
        //    objSqlConnection.Close();
        //    ///////////////////////////////////////---Reallocate the resources
        //    objSqlConnection.Dispose();
        //    objSqlCommand.Dispose();
        //    dr.Dispose();
        //    //////////////////////////////////////
        //    return ds;
        //}
        ////-------------------------------------------------------------------------------------------------------
    }
}
