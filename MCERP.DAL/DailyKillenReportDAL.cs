using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class DailyKillenReportDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public bool checkIsReportExist(DailyKillenReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from DailyKillenReport where (Date='" + obj.Date+ "' and ItemID='"+obj.ItemID+"' and StyleID='"+obj.StyleID+"' and SizeID='"+obj.SizeID+"' and ColorID='"+obj.ColorID+"' and KillenID='"+obj.KillenID+"' and KillenItemCategoryID='"+obj.ItemCategoryID+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            bool b = false;
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
        public int getCuurentReportQuantity(DailyKillenReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from DailyKillenReport where (Date='" + obj.Date + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' and ColorID='" + obj.ColorID + "' and KillenID='" + obj.KillenID + "' and KillenItemCategoryID='" + obj.ItemCategoryID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            int b = 0;
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
        public void addKillenReport(DailyKillenReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into DailyKillenReport(KillenID,Date,ItemID,StyleID,SizeID,KillenItemCategoryID,ColorID,Quantity,Remarks)values('" + obj.KillenID + "','" + obj.Date + "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.ItemCategoryID + "','" + obj.ColorID + "','" + obj.Quantity + "','"+obj.Remarks+"')", objSqlConnection);
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
        public void updateKillenReportByDualOBjects(DailyKillenReport updatedObj, DailyKillenReport beforeUpdateObj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE  DailyKillenReport SET KillenID ='" + updatedObj.KillenID + "',Date='" + updatedObj.Date + "',ItemID='" + updatedObj.ItemID + "',StyleID='" + updatedObj.StyleID + "',SizeID='" + updatedObj.SizeID + "',KillenItemCategoryID='" + updatedObj.ItemCategoryID + "',ColorID='" + updatedObj.ColorID + "',Quantity='" + updatedObj.Quantity + "' WHERE (KillenID='" + beforeUpdateObj.KillenID + "'and KillenItemCategoryID='" + beforeUpdateObj.ItemCategoryID + "'and Date='" + beforeUpdateObj.Date + "'and ItemID='" + beforeUpdateObj.ItemID + "'and StyleID='" + beforeUpdateObj.StyleID + "'and SizeID='" + beforeUpdateObj.SizeID + "'and ColorID='" + beforeUpdateObj.ColorID + "'and Quantity='" + beforeUpdateObj.Quantity + "')", objSqlConnection);
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
        public void updateKillenReport(DailyKillenReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE  DailyKillenReport SET Quantity ='" + obj.Quantity +"' WHERE (KillenID='" + obj.KillenID + "'and KillenItemCategoryID='" + obj.ItemCategoryID + "'and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and ColorID='" + obj.ColorID + "')", objSqlConnection);
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
        public void deleteKillenReport(DailyKillenReport obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from DailyKillenReport where (KillenID='" + obj.KillenID + "'and KillenItemCategoryID='" + obj.ItemCategoryID + "'and Date='" + obj.Date + "'and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and ColorID='" + obj.ColorID + "'and Quantity='" + obj.Quantity + "')", objSqlConnection);
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
        public DataSet getDailyKillenReport(DateTime date)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            KillenDAL killenDAL = new KillenDAL();
            KillenItemCategoryDAL categoryDAL = new KillenItemCategoryDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyKillenReport where (day(Date) = '" + date.Day + "' and month(Date) = '" + date.Month + "' and year(Date) = '" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Killen", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = killenDAL.getKillenName(Convert.ToInt16(dr["KillenID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = categoryDAL.getKillenItemCategoryName(Convert.ToInt16(dr["KillenItemCategoryID"]));
                dataRow[5] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToString(dr["Remarks"]);
                dataRow[8] = Convert.ToDateTime(dr["Date"]);

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
        public DataSet getDailyKillenReportByKillen(DateTime date,Int16 killenID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            KillenDAL killenDAL = new KillenDAL();
            KillenItemCategoryDAL categoryDAL = new KillenItemCategoryDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyKillenReport where (day(Date) = '" + date.Day + "' and month(Date) = '" + date.Month + "' and year(Date) = '" + date.Year + "' and KillenID='" + killenID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Killen", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = killenDAL.getKillenName(Convert.ToInt16(dr["KillenID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = categoryDAL.getKillenItemCategoryName(Convert.ToInt16(dr["KillenItemCategoryID"]));
                dataRow[5] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToString(dr["Remarks"]);
                dataRow[8] = Convert.ToDateTime(dr["Date"]);

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
        public DataSet getMonthlyKillenReport(DateTime date)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            KillenDAL killenDAL = new KillenDAL();
            KillenItemCategoryDAL categoryDAL = new KillenItemCategoryDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyKillenReport where (month(Date) = '" + date.Month + "' and year(Date)='" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Killen", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = killenDAL.getKillenName(Convert.ToInt16(dr["KillenID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = categoryDAL.getKillenItemCategoryName(Convert.ToInt16(dr["KillenItemCategoryID"]));
                dataRow[5] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToString(dr["Remarks"]);
                dataRow[8] = Convert.ToDateTime(dr["Date"]);

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
        public DataSet getMonthlyKillenReportByKillen(DateTime date, Int16 killenID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            KillenDAL killenDAL = new KillenDAL();
            KillenItemCategoryDAL categoryDAL = new KillenItemCategoryDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyKillenReport where (month(Date) = '" + date.Month + "' and year(Date)='" + date.Year + "' and KillenID='" + killenID + "')", objSqlConnection);
            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Killen", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = killenDAL.getKillenName(Convert.ToInt16(dr["KillenID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = categoryDAL.getKillenItemCategoryName(Convert.ToInt16(dr["KillenItemCategoryID"]));
                dataRow[5] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToString(dr["Remarks"]);
                dataRow[8] = Convert.ToDateTime(dr["Date"]);

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
        public DataSet getYearlyKillenReport(DateTime date)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            KillenDAL killenDAL = new KillenDAL();
            KillenItemCategoryDAL categoryDAL = new KillenItemCategoryDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyKillenReport where (year(Date)='" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Killen", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = killenDAL.getKillenName(Convert.ToInt16(dr["KillenID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = categoryDAL.getKillenItemCategoryName(Convert.ToInt16(dr["KillenItemCategoryID"]));
                dataRow[5] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToString(dr["Remarks"]);
                dataRow[8] = Convert.ToDateTime(dr["Date"]);

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
        public DataSet getYearlyKillenReportByKillen(DateTime date, Int16 killenID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            KillenDAL killenDAL = new KillenDAL();
            KillenItemCategoryDAL categoryDAL = new KillenItemCategoryDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyKillenReport where (year(Date)='" + date.Year + "' and KillenID='" + killenID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Killen", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = killenDAL.getKillenName(Convert.ToInt16(dr["KillenID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = categoryDAL.getKillenItemCategoryName(Convert.ToInt16(dr["KillenItemCategoryID"]));
                dataRow[5] = color.getColorName(Convert.ToInt16(dr["ColorID"]));
                dataRow[6] = Convert.ToInt16(dr["Quantity"]);
                dataRow[7] = Convert.ToString(dr["Remarks"]);
                dataRow[8] = Convert.ToDateTime(dr["Date"]);

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
        public List<DailyKillenReport> getKillenReportByDate(DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyKillenReport where (day(Date) = '" + date.Day + "' and month(Date) = '" + date.Month + "' and year(Date) = '" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyKillenReport> list = new List<DailyKillenReport>();
            while (dr.Read())
            {
                DailyKillenReport k = new DailyKillenReport();
                k.KillenID = Convert.ToInt16(dr["KillenID"]);
                k.ItemCategoryID = Convert.ToInt16(dr["KillenItemCategoryID"]);
                k.Date = Convert.ToDateTime(dr["Date"]);
                k.ItemID = Convert.ToInt16(dr["ItemID"]);
                k.StyleID = Convert.ToInt16(dr["StyleID"]);
                k.SizeID = Convert.ToInt16(dr["SizeID"]);
                k.ColorID = Convert.ToInt16(dr["ColorID"]);
                k.Quantity = Convert.ToInt16(dr["Quantity"]);
                k.Remarks= Convert.ToString(dr["Remarks"]);

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
        public List<DailyKillenReport> getKillenReportByDateAndKillen(DateTime date,Int16 killenID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyKillenReport where (day(Date) = '" + date.Day + "' and month(Date) = '" + date.Month + "' and year(Date) = '" + date.Year + "' and KillenID='" + killenID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyKillenReport> list = new List<DailyKillenReport>();
            while (dr.Read())
            {
                DailyKillenReport k = new DailyKillenReport();
                k.KillenID = Convert.ToInt16(dr["KillenID"]);
                k.ItemCategoryID = Convert.ToInt16(dr["KillenItemCategoryID"]);
                k.Date = Convert.ToDateTime(dr["Date"]);
                k.ItemID = Convert.ToInt16(dr["ItemID"]);
                k.StyleID = Convert.ToInt16(dr["StyleID"]);
                k.SizeID = Convert.ToInt16(dr["SizeID"]);
                k.ColorID = Convert.ToInt16(dr["ColorID"]);
                k.Quantity = Convert.ToInt16(dr["Quantity"]);
                k.Remarks = Convert.ToString(dr["Remarks"]);

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
        public List<DailyKillenReport> getKillenReportByMonth(DateTime da)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyKillenReport where (month(Date) = '" + da.Month + "' and year(Date)='"+da.Year+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyKillenReport> list = new List<DailyKillenReport>();
            while (dr.Read())
            {
                DailyKillenReport k = new DailyKillenReport();
                k.KillenID = Convert.ToInt16(dr["KillenID"]);
                k.ItemCategoryID = Convert.ToInt16(dr["KillenItemCategoryID"]);
                k.Date = Convert.ToDateTime(dr["Date"]);
                k.ItemID = Convert.ToInt16(dr["ItemID"]);
                k.StyleID = Convert.ToInt16(dr["StyleID"]);
                k.SizeID = Convert.ToInt16(dr["SizeID"]);
                k.ColorID = Convert.ToInt16(dr["ColorID"]);
                k.Quantity = Convert.ToInt16(dr["Quantity"]);
                k.Remarks = Convert.ToString(dr["Remarks"]);

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
        public List<DailyKillenReport> getKillenReportByMonthAndKillen(DateTime da,Int16 killenID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyKillenReport where (month(Date) = '" + da.Month + "' and year(Date)='" +da.Year+ "' and KillenID='"+killenID+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyKillenReport> list = new List<DailyKillenReport>();
            while (dr.Read())
            {
                DailyKillenReport k = new DailyKillenReport();
                k.KillenID = Convert.ToInt16(dr["KillenID"]);
                k.ItemCategoryID = Convert.ToInt16(dr["KillenItemCategoryID"]);
                k.Date = Convert.ToDateTime(dr["Date"]);
                k.ItemID = Convert.ToInt16(dr["ItemID"]);
                k.StyleID = Convert.ToInt16(dr["StyleID"]);
                k.SizeID = Convert.ToInt16(dr["SizeID"]);
                k.ColorID = Convert.ToInt16(dr["ColorID"]);
                k.Quantity = Convert.ToInt16(dr["Quantity"]);
                k.Remarks = Convert.ToString(dr["Remarks"]);

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
        public List<DailyKillenReport> getKillenReportByYear(DateTime da)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyKillenReport where (year(Date)='" + da.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyKillenReport> list = new List<DailyKillenReport>();
            while (dr.Read())
            {
                DailyKillenReport k = new DailyKillenReport();
                k.KillenID = Convert.ToInt16(dr["KillenID"]);
                k.ItemCategoryID = Convert.ToInt16(dr["KillenItemCategoryID"]);
                k.Date = Convert.ToDateTime(dr["Date"]);
                k.ItemID = Convert.ToInt16(dr["ItemID"]);
                k.StyleID = Convert.ToInt16(dr["StyleID"]);
                k.SizeID = Convert.ToInt16(dr["SizeID"]);
                k.ColorID = Convert.ToInt16(dr["ColorID"]);
                k.Quantity = Convert.ToInt16(dr["Quantity"]);
                k.Remarks = Convert.ToString(dr["Remarks"]);

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
        public List<DailyKillenReport> getKillenReportByYearAndKillen(DateTime da, Int16 killenID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyKillenReport where (year(Date)='" + da.Year + "' and KillenID='" + killenID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyKillenReport> list = new List<DailyKillenReport>();
            while (dr.Read())
            {
                DailyKillenReport k = new DailyKillenReport();
                k.KillenID = Convert.ToInt16(dr["KillenID"]);
                k.ItemCategoryID = Convert.ToInt16(dr["KillenItemCategoryID"]);
                k.Date = Convert.ToDateTime(dr["Date"]);
                k.ItemID = Convert.ToInt16(dr["ItemID"]);
                k.StyleID = Convert.ToInt16(dr["StyleID"]);
                k.SizeID = Convert.ToInt16(dr["SizeID"]);
                k.ColorID = Convert.ToInt16(dr["ColorID"]);
                k.Quantity = Convert.ToInt16(dr["Quantity"]);
                k.Remarks = Convert.ToString(dr["Remarks"]);

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
        public List<DailyKillenReport> getKillenReportByDateAndKillenID(DateTime date, Int16 KillenID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyKillenReport where Date = '" + date + "'and KillenID='" + KillenID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyKillenReport> list = new List<DailyKillenReport>();
            while (dr.Read())
            {
                DailyKillenReport k = new DailyKillenReport();
                k.KillenID = Convert.ToInt16(dr["KillenID"]);
                k.ItemCategoryID = Convert.ToInt16(dr["KillenItemCategoryID"]);
                k.Date = Convert.ToDateTime(dr["Date"]);
                k.ItemID = Convert.ToInt16(dr["ItemID"]);
                k.StyleID = Convert.ToInt16(dr["StyleID"]);
                k.SizeID = Convert.ToInt16(dr["SizeID"]);
                k.ColorID = Convert.ToInt16(dr["ColorID"]);
                k.Quantity = Convert.ToInt16(dr["Quantity"]);
                k.Remarks = Convert.ToString(dr["Remarks"]);

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
        public List<DailyKillenReport> getKillenReportByDateAndKillenItemCategoryID(DateTime date, Int16 killenItemCategoryID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyKillenReport where Date = '" + date + "'and KillenItemCategoryID='" + killenItemCategoryID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyKillenReport> list = new List<DailyKillenReport>();
            while (dr.Read())
            {
                DailyKillenReport k = new DailyKillenReport();
                k.KillenID = Convert.ToInt16(dr["KillenID"]);
                k.ItemCategoryID = Convert.ToInt16(dr["KillenItemCategoryID"]);
                k.Date = Convert.ToDateTime(dr["Date"]);
                k.ItemID = Convert.ToInt16(dr["ItemID"]);
                k.StyleID = Convert.ToInt16(dr["StyleID"]);
                k.SizeID = Convert.ToInt16(dr["SizeID"]);
                k.ColorID = Convert.ToInt16(dr["ColorID"]);
                k.Quantity = Convert.ToInt16(dr["Quantity"]);
                k.Remarks = Convert.ToString(dr["Remarks"]);

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
        public List<DailyKillenReport> getKillenReportByDateAndColor(DateTime date, Int16 colorID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyKillenReport where Date = '" + date + "'and ColorID='" + colorID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyKillenReport> list = new List<DailyKillenReport>();
            while (dr.Read())
            {
                DailyKillenReport k = new DailyKillenReport();
                k.KillenID = Convert.ToInt16(dr["KillenID"]);
                k.ItemCategoryID = Convert.ToInt16(dr["KillenItemCategoryID"]);
                k.Date = Convert.ToDateTime(dr["Date"]);
                k.ItemID = Convert.ToInt16(dr["ItemID"]);
                k.StyleID = Convert.ToInt16(dr["StyleID"]);
                k.SizeID = Convert.ToInt16(dr["SizeID"]);
                k.ColorID = Convert.ToInt16(dr["ColorID"]);
                k.Quantity = Convert.ToInt16(dr["Quantity"]);
                k.Remarks = Convert.ToString(dr["Remarks"]);
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
        public List<DailyKillenReport> getKillenReportByDateAndItem(DateTime date, Int16 itemID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyKillenReport where Date = '" + date + "'and ItemID='" + itemID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyKillenReport> list = new List<DailyKillenReport>();
            while (dr.Read())
            {
                DailyKillenReport k = new DailyKillenReport();
                k.KillenID = Convert.ToInt16(dr["KillenID"]);
                k.ItemCategoryID = Convert.ToInt16(dr["KillenItemCategoryID"]);
                k.Date = Convert.ToDateTime(dr["Date"]);
                k.ItemID = Convert.ToInt16(dr["ItemID"]);
                k.StyleID = Convert.ToInt16(dr["StyleID"]);
                k.SizeID = Convert.ToInt16(dr["SizeID"]);
                k.ColorID = Convert.ToInt16(dr["ColorID"]);
                k.Quantity = Convert.ToInt16(dr["Quantity"]);
                k.Remarks = Convert.ToString(dr["Remarks"]);

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
        public List<DailyKillenReport> getKillenReportByDateAndStyle(DateTime date, Int16 styleID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from DailyKillenReport where Date = '" + date + "'and StyleID='" + styleID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<DailyKillenReport> list = new List<DailyKillenReport>();
            while (dr.Read())
            {
                DailyKillenReport k = new DailyKillenReport();
                k.KillenID = Convert.ToInt16(dr["KillenID"]);
                k.ItemCategoryID = Convert.ToInt16(dr["KillenItemCategoryID"]);
                k.Date = Convert.ToDateTime(dr["Date"]);
                k.ItemID = Convert.ToInt16(dr["ItemID"]);
                k.StyleID = Convert.ToInt16(dr["StyleID"]);
                k.SizeID = Convert.ToInt16(dr["SizeID"]);
                k.ColorID = Convert.ToInt16(dr["ColorID"]);
                k.Quantity = Convert.ToInt16(dr["Quantity"]);
                k.Remarks = Convert.ToString(dr["Remarks"]);

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
