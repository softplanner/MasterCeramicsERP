using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class GreenWareHouseItemCheckReportDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public bool checkIsReportExist(GreenWareHouseItemCheckReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from GreenWareHouseItemCheckReport where (Date='" + obj.Date + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' and WorkerID='"+obj.WorkerID+"' and CheckerID='"+obj.CheckerID+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            bool b= false;
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
        public int getCurrentStock(GreenWareHouseItemCheckReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from GreenWareHouseItemCheckReport where (Date='" + obj.Date + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' and WorkerID='" + obj.WorkerID + "' and CheckerID='" + obj.CheckerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            int b = 0;
            while (dr.Read())
            {
                b = Convert.ToInt32(dr["Quantity"]);
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
        public void addReport(GreenWareHouseItemCheckReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into GreenWareHouseItemCheckReport(WorkerID,Date,ItemID,StyleID,SizeID,Quantity,CheckerID)values('" + obj.WorkerID + "','" + obj.Date + "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.Quantity + "','" + obj.CheckerID+ "')", objSqlConnection);
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
        public void updateReport(GreenWareHouseItemCheckReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE  GreenWareHouseItemCheckReport SET Quantity='" + obj.Quantity + "' WHERE (WorkerID='" + obj.WorkerID + "' and Date='" + obj.Date + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' and CheckerID='" + obj.CheckerID+ "')", objSqlConnection);
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
        public void deleteReport(GreenWareHouseItemCheckReport obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from GreenWareHouseItemCheckReport WHERE (WorkerID='" + obj.WorkerID + "' and Date='" + obj.Date + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' and Quantity='" + obj.Quantity + "' and CheckerID='" + obj.CheckerID+ "')", objSqlConnection);
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
        public DataSet getDailyReport(DateTime date)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseItemCheckReport where (day(Date)='" + date.Day + "' and month(Date)='" + date.Month + "' and year(Date)='" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;

            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Checker", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));

            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = personDAL.getPersonName(Convert.ToInt32(dr["CheckerID"]));
                dataRow[2] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[3] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[4] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[5] = Convert.ToInt16(dr["Quantity"]);
                dataRow[6] = Convert.ToDateTime(dr["Date"]);
                
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
        public List<GreenWareHouseItemCheckReport> getReportByDay(DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseItemCheckReport where (day(Date) = '" + date.Day + "' and month(Date)='"+date.Month+"' and year(Date)='"+date.Year+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GreenWareHouseItemCheckReport> list = new List<GreenWareHouseItemCheckReport>();
            while (dr.Read())
            {
                GreenWareHouseItemCheckReport g = new GreenWareHouseItemCheckReport();
                g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                g.CheckerID= Convert.ToInt32(dr["CheckerID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
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
        public DataSet getMonthlyReport(DateTime d)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseItemCheckReport where (month(Date) = '" + d.Month + "' and year(Date)='" + d.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;

            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Checker", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));

            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = personDAL.getPersonName(Convert.ToInt32(dr["CheckerID"]));
                dataRow[2] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[3] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[4] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[5] = Convert.ToInt16(dr["Quantity"]);
                dataRow[6] = Convert.ToDateTime(dr["Date"]);

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
        public List<GreenWareHouseItemCheckReport> getReportByMonth(DateTime d)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseItemCheckReport where (month(Date) = '" + d.Month + "' and year(Date)='"+d.Year+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GreenWareHouseItemCheckReport> list = new List<GreenWareHouseItemCheckReport>();
            while (dr.Read())
            {
                GreenWareHouseItemCheckReport g = new GreenWareHouseItemCheckReport();
                g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                g.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
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
        public DataSet getyearlyReport(DateTime d)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseItemCheckReport where (year(Date)='" + d.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;

            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Checker", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));

            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = personDAL.getPersonName(Convert.ToInt32(dr["CheckerID"]));
                dataRow[2] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[3] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[4] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[5] = Convert.ToInt16(dr["Quantity"]);
                dataRow[6] = Convert.ToDateTime(dr["Date"]);

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
        public List<GreenWareHouseItemCheckReport> getReportByYear(DateTime d)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseItemCheckReport where (year(Date)='" + d.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GreenWareHouseItemCheckReport> list = new List<GreenWareHouseItemCheckReport>();
            while (dr.Read())
            {
                GreenWareHouseItemCheckReport g = new GreenWareHouseItemCheckReport();
                g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                g.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
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
        public DataSet getDailyReportByWorker(DateTime date, int workerID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            ColorDAL color = new ColorDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseItemCheckReport where (Date = '" + date + "'and WorkerID='" + workerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            GreenWareHouseItemCheckReport g;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;

            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Checker", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));

            ds.Tables.Add(dt);
            while (dr.Read())
            {
                g = new GreenWareHouseItemCheckReport();
                g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                g.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);

                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(g.WorkerID);
                dataRow[1] = personDAL.getPersonName(g.CheckerID);
                dataRow[2] = item.getItemName(g.ItemID);
                dataRow[3] = style.getItemStyleName(g.StyleID);
                dataRow[4] = size.getItemSizeName(g.SizeID);
                dataRow[5] = g.Quantity;
                dataRow[6] = g.Date;

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
        public List<GreenWareHouseItemCheckReport> getReportByDateAndWorker(DateTime date, int workerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseItemCheckReport where (Date = '" + date + "'and WorkerID='" + workerID+ "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GreenWareHouseItemCheckReport> list = new List<GreenWareHouseItemCheckReport>();
            while (dr.Read())
            {
                GreenWareHouseItemCheckReport g = new GreenWareHouseItemCheckReport();
                g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                g.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
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
        public List<GreenWareHouseItemCheckReport> getReportByDateAndChecker(DateTime date, int checkerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseItemCheckReport where Date = '" + date + "'and CheckerID='" + checkerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GreenWareHouseItemCheckReport> list = new List<GreenWareHouseItemCheckReport>();
            while (dr.Read())
            {
                GreenWareHouseItemCheckReport g = new GreenWareHouseItemCheckReport();
                g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                g.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
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
        public List<GreenWareHouseItemCheckReport> getReportByDateAndItem(DateTime date, Int16 itemID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseItemCheckReport where Date = '" + date + "'and ItemID='" + itemID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GreenWareHouseItemCheckReport> list = new List<GreenWareHouseItemCheckReport>();
            while (dr.Read())
            {
                GreenWareHouseItemCheckReport g = new GreenWareHouseItemCheckReport();
                g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                g.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
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
        public List<GreenWareHouseItemCheckReport> getReportByDateAndStyle(DateTime date, Int16 styleID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseItemCheckReport where Date = '" + date + "'and StyleID='" + styleID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GreenWareHouseItemCheckReport> list = new List<GreenWareHouseItemCheckReport>();
            while (dr.Read())
            {
                GreenWareHouseItemCheckReport g = new GreenWareHouseItemCheckReport();
                g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                g.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
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
    }
}
