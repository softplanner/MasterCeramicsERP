using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class KillenFeedDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addReport(KillenFeed obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into KillenFeed (ItemID,StyleID,SizeID,ColorID,Quantity,KillenID)values('" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.ColorID + "','" + obj.Quantity + "','" + obj.KillenID + "')", objSqlConnection);
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
        public void updateReport(KillenFeed obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE KillenFeed SET Quantity='" + obj.Quantity + "' WHERE (ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and ColorID='" + obj.ColorID + "'and KillenID='" + obj.KillenID + "')", objSqlConnection);
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
        public void updateReport2(KillenFeed obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE KillenFeed SET Quantity='" + obj.Quantity + "' WHERE (ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and ColorID='" + obj.ColorID + "'and KillenID='" + obj.KillenID + "')", objSqlConnection);
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
        public void deleteReport(KillenFeed obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from KillenFeed WHERE (ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and ColorID='" + obj.ColorID + "' and KillenID='" + obj.KillenID + "')", objSqlConnection);
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
        public bool checkItemIsAlreasyExist(KillenFeed obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Select Quantity from KillenFeed WHERE (ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and ColorID='" + obj.ColorID + "' and KillenID='" + obj.KillenID + "')", objSqlConnection);

            SqlDataReader dr = null;
            bool b = false;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            while (dr.Read())
            {
                b=true;
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
        public Int16 getStock(KillenFeed obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Select Quantity from KillenFeed WHERE (ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and ColorID='" + obj.ColorID + "' and KillenID='" + obj.KillenID + "')", objSqlConnection);

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
        public Int16 getStockByKillen(Int16 killenID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Select Quantity from KillenFeed WHERE (KillenID='" + killenID + "')", objSqlConnection);

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
        public DataSet getKillenReport(Int16 killenID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            KillenDAL killenDAL = new KillenDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from KillenFeed where (KillenID = '" + killenID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            KillenFeed k;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Killen", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                k = new KillenFeed();
                k.KillenID = Convert.ToInt16(dr["KillenID"]);
                k.ItemID = Convert.ToInt16(dr["ItemID"]);
                k.StyleID = Convert.ToInt16(dr["StyleID"]);
                k.SizeID = Convert.ToInt16(dr["SizeID"]);
                k.ColorID = Convert.ToInt16(dr["ColorID"]);
                k.Quantity = Convert.ToInt16(dr["Quantity"]);

                dataRow = ds.Tables[0].NewRow();

                dataRow[0] = killenDAL.getKillenName(k.KillenID);
                dataRow[1] = item.getItemName(k.ItemID);
                dataRow[2] = style.getItemStyleName(k.StyleID);
                dataRow[3] = size.getItemSizeName(k.SizeID);
                dataRow[4] = color.getColorName(k.ColorID);
                dataRow[5] = k.Quantity;
            
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
        public DataSet getAllKillenReport()
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            KillenDAL killenDAL = new KillenDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from KillenFeed ", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            KillenFeed k;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Killen", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                k = new KillenFeed();
                k.KillenID = Convert.ToInt16(dr["KillenID"]);
                k.ItemID = Convert.ToInt16(dr["ItemID"]);
                k.StyleID = Convert.ToInt16(dr["StyleID"]);
                k.SizeID = Convert.ToInt16(dr["SizeID"]);
                k.ColorID = Convert.ToInt16(dr["ColorID"]);
                k.Quantity = Convert.ToInt16(dr["Quantity"]);

                dataRow = ds.Tables[0].NewRow();

                dataRow[0] = killenDAL.getKillenName(k.KillenID);
                dataRow[1] = item.getItemName(k.ItemID);
                dataRow[2] = style.getItemStyleName(k.StyleID);
                dataRow[3] = size.getItemSizeName(k.SizeID);
                dataRow[4] = color.getColorName(k.ColorID);
                dataRow[5] = k.Quantity;

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
        ////-------------------------------------------------------------------------------------------------------
        //public List<KillenFeed> getReportByDay(DateTime date)
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from KillenFeed where (Date = '" + date + "')", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    List<KillenFeed> list = new List<KillenFeed>();
        //    while (dr.Read())
        //    {
        //        KillenFeed k = new KillenFeed();
        //        k.Date = Convert.ToDateTime(dr["Date"]);
        //        k.KillenID = Convert.ToInt16(dr["KillenID"]);
        //        k.ItemID = Convert.ToInt16(dr["ItemID"]);
        //        k.StyleID = Convert.ToInt16(dr["StyleID"]);
        //        k.SizeID = Convert.ToInt16(dr["SizeID"]);
        //        k.ColorID = Convert.ToInt16(dr["ColorID"]);
        //        k.Quantity = Convert.ToInt16(dr["Quantity"]);
               
        //        list.Add(k);
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
        ////-------------------------------------------------------------------------------------------------------
        //public DataSet getDailyReport(DateTime date)
        //{
        //    ItemDAL item = new ItemDAL();
        //    DALItemStyle style = new DALItemStyle();
        //    ItemSizeDAL size = new ItemSizeDAL();
        //    ColorDAL color = new ColorDAL();
        //    KillenDAL killenDAL = new KillenDAL();
        //    PersonDAL personDAL = new PersonDAL();

        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from KillenFeed where (Date = '" + date + "')", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    KillenFeed k;
        //    DataSet ds = new DataSet();
        //    DataTable dt = new DataTable();
        //    DataRow dataRow;
        //    dt.Columns.Add("Killen", typeof(string));
        //    dt.Columns.Add("Item", typeof(string));
        //    dt.Columns.Add("Style", typeof(string));
        //    dt.Columns.Add("Size", typeof(string));
        //    dt.Columns.Add("Color", typeof(string));
        //    dt.Columns.Add("Quantity", typeof(Int16));
        //    dt.Columns.Add("Date", typeof(DateTime));
        //    ds.Tables.Add(dt);
        //    while (dr.Read())
        //    {
        //        k = new KillenFeed();
        //        k.KillenID = Convert.ToInt16(dr["KillenID"]);
        //        k.Date = Convert.ToDateTime(dr["Date"]);
        //        k.ItemID = Convert.ToInt16(dr["ItemID"]);
        //        k.StyleID = Convert.ToInt16(dr["StyleID"]);
        //        k.SizeID = Convert.ToInt16(dr["SizeID"]);
        //        k.ColorID = Convert.ToInt16(dr["ColorID"]);
        //        k.Quantity = Convert.ToInt16(dr["Quantity"]);
            
        //        dataRow = ds.Tables[0].NewRow();

        //        dataRow[0] = killenDAL.getKillenName(k.KillenID);
        //        dataRow[1] = item.getItemName(k.ItemID);
        //        dataRow[2] = style.getItemStyleName(k.StyleID);
        //        dataRow[3] = size.getItemSizeName(k.SizeID);
        //        dataRow[4] = color.getColorName(k.ColorID);
        //        dataRow[5] = k.Quantity;
        //        dataRow[6] = k.Date;
               
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
        ////-------------------------------------------------------------------------------------------------------
        //public DataSet getDailyReportByKillen(DateTime date,Int16 killenID)
        //{
        //    ItemDAL item = new ItemDAL();
        //    DALItemStyle style = new DALItemStyle();
        //    ItemSizeDAL size = new ItemSizeDAL();
        //    ColorDAL color = new ColorDAL();
        //    KillenDAL killenDAL = new KillenDAL();
        //    PersonDAL personDAL = new PersonDAL();

        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from KillenFeed where (Date = '" + date + "' and KillenID='"+killenID+"')", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    KillenFeed k;
        //    DataSet ds = new DataSet();
        //    DataTable dt = new DataTable();
        //    DataRow dataRow;
        //    dt.Columns.Add("Killen", typeof(string));
        //    dt.Columns.Add("Item", typeof(string));
        //    dt.Columns.Add("Style", typeof(string));
        //    dt.Columns.Add("Size", typeof(string));
        //    dt.Columns.Add("Color", typeof(string));
        //    dt.Columns.Add("Quantity", typeof(Int16));
        //    dt.Columns.Add("Date", typeof(DateTime));
        //    ds.Tables.Add(dt);
        //    while (dr.Read())
        //    {
        //        k = new KillenFeed();
        //        k.KillenID = Convert.ToInt16(dr["KillenID"]);
        //        k.Date = Convert.ToDateTime(dr["Date"]);
        //        k.ItemID = Convert.ToInt16(dr["ItemID"]);
        //        k.StyleID = Convert.ToInt16(dr["StyleID"]);
        //        k.SizeID = Convert.ToInt16(dr["SizeID"]);
        //        k.ColorID = Convert.ToInt16(dr["ColorID"]);
        //        k.Quantity = Convert.ToInt16(dr["Quantity"]);

        //        dataRow = ds.Tables[0].NewRow();
        //        dataRow[0] = killenDAL.getKillenName(k.KillenID);
        //        dataRow[1] = item.getItemName(k.ItemID);
        //        dataRow[2] = style.getItemStyleName(k.StyleID);
        //        dataRow[3] = size.getItemSizeName(k.SizeID);
        //        dataRow[4] = color.getColorName(k.ColorID);
        //        dataRow[5] = k.Quantity;
        //        dataRow[6] = k.Date;

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
        ////-------------------------------------------------------------------------------------------------------
        //public List<KillenFeed> getReportByDayAndKillen(DateTime date,Int16 killenID)
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from KillenFeed where (Date = '" + date + "' and KillenID='"+killenID+"')", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    List<KillenFeed> list = new List<KillenFeed>();
        //    while (dr.Read())
        //    {
        //        KillenFeed k = new KillenFeed();
        //        k.Date = Convert.ToDateTime(dr["Date"]);
        //        k.KillenID = Convert.ToInt16(dr["KillenID"]);
        //        k.ItemID = Convert.ToInt16(dr["ItemID"]);
        //        k.StyleID = Convert.ToInt16(dr["StyleID"]);
        //        k.SizeID = Convert.ToInt16(dr["SizeID"]);
        //        k.ColorID = Convert.ToInt16(dr["ColorID"]);
        //        k.Quantity = Convert.ToInt16(dr["Quantity"]);

        //        list.Add(k);
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
        ////-------------------------------------------------------------------------------------------------------
        //public List<KillenFeed> getReportByMonth(Int16 month,Int16 year)
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from KillenFeed where (month(Date) = '" + month + "' and year(Date)='"+year+"')", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    List<KillenFeed> list = new List<KillenFeed>();
        //    while (dr.Read())
        //    {
        //        KillenFeed k = new KillenFeed();
        //        k.Date = Convert.ToDateTime(dr["Date"]);
        //        k.KillenID = Convert.ToInt16(dr["KillenID"]);
        //        k.ItemID = Convert.ToInt16(dr["ItemID"]);
        //        k.StyleID = Convert.ToInt16(dr["StyleID"]);
        //        k.SizeID = Convert.ToInt16(dr["SizeID"]);
        //        k.ColorID = Convert.ToInt16(dr["ColorID"]);
        //        k.Quantity = Convert.ToInt16(dr["Quantity"]);

        //        list.Add(k);
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
        ////-------------------------------------------------------------------------------------------------------
        //public DataSet getMonthlyReport(Int16 month,Int16 year)
        //{
        //    ItemDAL item = new ItemDAL();
        //    DALItemStyle style = new DALItemStyle();
        //    ItemSizeDAL size = new ItemSizeDAL();
        //    ColorDAL color = new ColorDAL();
        //    KillenDAL killenDAL = new KillenDAL();
        //    PersonDAL personDAL = new PersonDAL();

        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from KillenFeed where (month(Date) = '" + month + "' and year(Date)='"+year+"')", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    KillenFeed k;
        //    DataSet ds = new DataSet();
        //    DataTable dt = new DataTable();
        //    DataRow dataRow;
        //    dt.Columns.Add("Killen", typeof(string));
        //    dt.Columns.Add("Item", typeof(string));
        //    dt.Columns.Add("Style", typeof(string));
        //    dt.Columns.Add("Size", typeof(string));
        //    dt.Columns.Add("Color", typeof(string));
        //    dt.Columns.Add("Quantity", typeof(Int16));
        //    dt.Columns.Add("Date", typeof(DateTime));
        //    ds.Tables.Add(dt);
        //    while (dr.Read())
        //    {
        //        k = new KillenFeed();
        //        k.KillenID = Convert.ToInt16(dr["KillenID"]);
        //        k.Date = Convert.ToDateTime(dr["Date"]);
        //        k.ItemID = Convert.ToInt16(dr["ItemID"]);
        //        k.StyleID = Convert.ToInt16(dr["StyleID"]);
        //        k.SizeID = Convert.ToInt16(dr["SizeID"]);
        //        k.ColorID = Convert.ToInt16(dr["ColorID"]);
        //        k.Quantity = Convert.ToInt16(dr["Quantity"]);

        //        dataRow = ds.Tables[0].NewRow();
        //        dataRow[0] = killenDAL.getKillenName(k.KillenID);
        //        dataRow[1] = item.getItemName(k.ItemID);
        //        dataRow[2] = style.getItemStyleName(k.StyleID);
        //        dataRow[3] = size.getItemSizeName(k.SizeID);
        //        dataRow[4] = color.getColorName(k.ColorID);
        //        dataRow[5] = k.Quantity;
        //        dataRow[6] = k.Date;

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
        ////-------------------------------------------------------------------------------------------------------
        //public DataSet getMonthlyReportByKillen(Int16 month, Int16 year,Int16 killenID)
        //{
        //    ItemDAL item = new ItemDAL();
        //    DALItemStyle style = new DALItemStyle();
        //    ItemSizeDAL size = new ItemSizeDAL();
        //    ColorDAL color = new ColorDAL();
        //    KillenDAL killenDAL = new KillenDAL();
        //    PersonDAL personDAL = new PersonDAL();

        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from KillenFeed where (month(Date) = '" + month + "' and year(Date)='" + year + "' and KillenID='"+killenID+"')", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    KillenFeed k;
        //    DataSet ds = new DataSet();
        //    DataTable dt = new DataTable();
        //    DataRow dataRow;
        //    dt.Columns.Add("Killen", typeof(string));
        //    dt.Columns.Add("Item", typeof(string));
        //    dt.Columns.Add("Style", typeof(string));
        //    dt.Columns.Add("Size", typeof(string));
        //    dt.Columns.Add("Color", typeof(string));
        //    dt.Columns.Add("Quantity", typeof(Int16));
        //    dt.Columns.Add("Date", typeof(DateTime));
        //    ds.Tables.Add(dt);
        //    while (dr.Read())
        //    {
        //        k = new KillenFeed();
        //        k.KillenID = Convert.ToInt16(dr["KillenID"]);
        //        k.Date = Convert.ToDateTime(dr["Date"]);
        //        k.ItemID = Convert.ToInt16(dr["ItemID"]);
        //        k.StyleID = Convert.ToInt16(dr["StyleID"]);
        //        k.SizeID = Convert.ToInt16(dr["SizeID"]);
        //        k.ColorID = Convert.ToInt16(dr["ColorID"]);
        //        k.Quantity = Convert.ToInt16(dr["Quantity"]);

        //        dataRow = ds.Tables[0].NewRow();
        //        dataRow[0] = killenDAL.getKillenName(k.KillenID);
        //        dataRow[1] = item.getItemName(k.ItemID);
        //        dataRow[2] = style.getItemStyleName(k.StyleID);
        //        dataRow[3] = size.getItemSizeName(k.SizeID);
        //        dataRow[4] = color.getColorName(k.ColorID);
        //        dataRow[5] = k.Quantity;
        //        dataRow[6] = k.Date;

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
        ////-------------------------------------------------------------------------------------------------------
        //public List<KillenFeed> getReportByMonthAndKillen(Int16 month, Int16 year,Int16 killenID)
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from KillenFeed where (month(Date) = '" + month + "' and year(Date)='" + year + "' and KillenID='"+killenID+"')", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    List<KillenFeed> list = new List<KillenFeed>();
        //    while (dr.Read())
        //    {
        //        KillenFeed k = new KillenFeed();
        //        k.Date = Convert.ToDateTime(dr["Date"]);
        //        k.KillenID = Convert.ToInt16(dr["KillenID"]);
        //        k.ItemID = Convert.ToInt16(dr["ItemID"]);
        //        k.StyleID = Convert.ToInt16(dr["StyleID"]);
        //        k.SizeID = Convert.ToInt16(dr["SizeID"]);
        //        k.ColorID = Convert.ToInt16(dr["ColorID"]);
        //        k.Quantity = Convert.ToInt16(dr["Quantity"]);

        //        list.Add(k);
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
        ////-------------------------------------------------------------------------------------------------------
        //public List<KillenFeed> getReportByDateAndkillen(DateTime date, Int16 killenID)
        //{
        //    ConnectionDB objConnectionDB = new ConnectionDB();
        //    SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
        //    SqlCommand objSqlCommand = new SqlCommand("select * from KillenFeed where Date = '" + date + "'and KillenID='" + killenID + "')", objSqlConnection);

        //    SqlDataReader dr = null;
        //    objSqlConnection.Open();
        //    dr = objSqlCommand.ExecuteReader();
        //    List<KillenFeed> list = new List<KillenFeed>();
        //    while (dr.Read())
        //    {
        //        KillenFeed k = new KillenFeed();
        //        k.Date = Convert.ToDateTime(dr["Date"]);
        //        k.KillenID = Convert.ToInt16(dr["KillenID"]);
        //        k.ItemID = Convert.ToInt16(dr["ItemID"]);
        //        k.StyleID = Convert.ToInt16(dr["StyleID"]);
        //        k.SizeID = Convert.ToInt16(dr["SizeID"]);
        //        k.ColorID = Convert.ToInt16(dr["ColorID"]);
        //        k.Quantity = Convert.ToInt16(dr["Quantity"]);
               
        //        list.Add(k);
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
        public List<KillenFeed> getReportByKillen(Int16 killenID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from KillenFeed where (KillenID='" + killenID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<KillenFeed> list = new List<KillenFeed>();
            while (dr.Read())
            {
                KillenFeed k = new KillenFeed();
                k.KillenID = Convert.ToInt16(dr["KillenID"]);
                k.ItemID = Convert.ToInt16(dr["ItemID"]);
                k.StyleID = Convert.ToInt16(dr["StyleID"]);
                k.SizeID = Convert.ToInt16(dr["SizeID"]);
                k.ColorID = Convert.ToInt16(dr["ColorID"]);
                k.Quantity = Convert.ToInt16(dr["Quantity"]);

                list.Add(k);
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
        public List<KillenFeed> getStockListtAllKillen()
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from KillenFeed ", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<KillenFeed> list = new List<KillenFeed>();
            while (dr.Read())
            {
                KillenFeed k = new KillenFeed();
                k.KillenID = Convert.ToInt16(dr["KillenID"]);
                k.ItemID = Convert.ToInt16(dr["ItemID"]);
                k.StyleID = Convert.ToInt16(dr["StyleID"]);
                k.SizeID = Convert.ToInt16(dr["SizeID"]);
                k.ColorID = Convert.ToInt16(dr["ColorID"]);
                k.Quantity = Convert.ToInt16(dr["Quantity"]);

                list.Add(k);
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
    }
}
