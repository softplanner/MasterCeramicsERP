using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class OilInspectionReportDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public bool checkIsreportExist(OilInspectionReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select CheckedQuantity from OilInspectionReport where (day(Date) = '" + obj.Date.Day + "' and month(Date)='" + obj.Date.Month + "' and year(Date)='" + obj.Date.Year + "' and WorkerID='" + obj.WorkerID + "' and CheckerID='" + obj.CheckerID + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            bool list = false;
            while (dr.Read())
            {
                list = true;
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public Int16 getCurrentCheckedQuantity(OilInspectionReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select CheckedQuantity from OilInspectionReport where (day(Date) = '" + obj.Date.Day + "' and month(Date)='" + obj.Date.Month + "' and year(Date)='" + obj.Date.Year + "' and WorkerID='" + obj.WorkerID + "' and CheckerID='" + obj.CheckerID + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            Int16 list = 0;
            while (dr.Read())
            {
                list = Convert.ToInt16(dr["CheckedQuantity"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public Int16 getCurrentRejectQuantity(OilInspectionReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select RejectQuantity from OilInspectionReport where (day(Date) = '" + obj.Date.Day + "' and month(Date)='" + obj.Date.Month + "' and year(Date)='" + obj.Date.Year + "' and WorkerID='" + obj.WorkerID + "' and CheckerID='" + obj.CheckerID + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            Int16 list = 0;
            while (dr.Read())
            {
                list = Convert.ToInt16(dr["RejectQuantity"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return list;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public void addReport(OilInspectionReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into OilInspectionReport(Date,ItemID,StyleID,SizeID,CheckedQuantity,Remarks,WorkerID,CheckerID,RejectQuantity)values('" + obj.Date + "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.CheckedQuantity+ "','" + obj.Remarks + "','" + obj.WorkerID + "','"+obj.CheckerID+"','"+obj.RejectQuantity+"')", objSqlConnection);
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
        public void updateReport(OilInspectionReport obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE  OilInspectionReport SET CheckedQuantity='" + obj.CheckedQuantity + "',RejectQuantity='" + obj.RejectQuantity + "' WHERE (day(Date) = '" + obj.Date.Day + "' and month(Date)='" + obj.Date.Month + "' and year(Date)='" + obj.Date.Year + "' and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "' and WorkerID='" + obj.WorkerID + "'and CheckerID='" + obj.CheckerID + "')", objSqlConnection);
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
        public void deleteReport(OilInspectionReport obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from OilInspectionReport WHERE (day(Date) = '" + obj.Date.Day + "' and month(Date)='" + obj.Date.Month + "' and year(Date)='" + obj.Date.Year + "' and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and CheckedQuantity='" + obj.CheckedQuantity + "' and WorkerID='" + obj.WorkerID + "'and CheckerID='" + obj.CheckerID + "'and RejectQuantity='" + obj.RejectQuantity + "')", objSqlConnection);
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
        public List<OilInspectionReport> getReportByDay(DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (day(Date) = '" + date.Day + "' and month(Date)='" + date.Month + "' and year(Date)='"+date.Year+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<OilInspectionReport> list = new List<OilInspectionReport>();
            while (dr.Read())
            {
                OilInspectionReport o = new OilInspectionReport();
                o.Date = Convert.ToDateTime(dr["Date"]);
                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.CheckerID= Convert.ToInt32(dr["CheckerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity= Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity= Convert.ToInt16(dr["RejectQuantity"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);

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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public DataSet getDailyReport(DateTime date)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (day(Date) = '" + date.Day + "' and month(Date)='" + date.Month + "' and year(Date)='" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            OilInspectionReport o;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Checker", typeof(string));
            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Checked", typeof(Int16));
            dt.Columns.Add("Rejected", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                o = new OilInspectionReport();

                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);
                o.Date = Convert.ToDateTime(dr["Date"]);
           
                dataRow = ds.Tables[0].NewRow();

                dataRow[0] = personDAL.getPersonName(o.CheckerID);
                dataRow[1] = personDAL.getPersonName(o.WorkerID);
                dataRow[2] = item.getItemName(o.ItemID);
                dataRow[3] = style.getItemStyleName(o.StyleID);
                dataRow[4] = size.getItemSizeName(o.SizeID);
                dataRow[5] = o.CheckedQuantity;
                dataRow[6] = o.RejectQuantity;
                dataRow[7] = o.Remarks;
                dataRow[8] = o.Date;

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
        public DataSet getDailyReportByCaster(DateTime date,int casterID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (day(Date) = '" + date.Day + "' and month(Date)='" + date.Month + "' and year(Date)='" + date.Year + "' and WorkerID='" + casterID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            OilInspectionReport o;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Checker", typeof(string));
            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Checked", typeof(Int16));
            dt.Columns.Add("Rejected", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                o = new OilInspectionReport();

                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);
                o.Date = Convert.ToDateTime(dr["Date"]);

                dataRow = ds.Tables[0].NewRow();

                dataRow[0] = personDAL.getPersonName(o.CheckerID);
                dataRow[1] = personDAL.getPersonName(o.WorkerID);
                dataRow[2] = item.getItemName(o.ItemID);
                dataRow[3] = style.getItemStyleName(o.StyleID);
                dataRow[4] = size.getItemSizeName(o.SizeID);
                dataRow[5] = o.CheckedQuantity;
                dataRow[6] = o.RejectQuantity;
                dataRow[7] = o.Remarks;
                dataRow[8] = o.Date;

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
        public DataSet getDailyReportByChecker(DateTime date,int checkerID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (day(Date) = '" + date.Day + "' and month(Date)='" + date.Month + "' and year(Date)='" + date.Year + "' and CheckerID='" + checkerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            OilInspectionReport o;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Checker", typeof(string));
            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Checked", typeof(Int16));
            dt.Columns.Add("Rejected", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                o = new OilInspectionReport();

                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);
                o.Date = Convert.ToDateTime(dr["Date"]);

                dataRow = ds.Tables[0].NewRow();

                dataRow[0] = personDAL.getPersonName(o.CheckerID);
                dataRow[1] = personDAL.getPersonName(o.WorkerID);
                dataRow[2] = item.getItemName(o.ItemID);
                dataRow[3] = style.getItemStyleName(o.StyleID);
                dataRow[4] = size.getItemSizeName(o.SizeID);
                dataRow[5] = o.CheckedQuantity;
                dataRow[6] = o.RejectQuantity;
                dataRow[7] = o.Remarks;
                dataRow[8] = o.Date;

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
        public DataSet getDailyReportByCaster_Checker(DateTime date, int casterID,int checkerID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (day(Date) = '" + date.Day + "' and month(Date)='" + date.Month + "' and year(Date)='" + date.Year + "' and WorkerID='" + casterID + "' and CheckerID='" + checkerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            OilInspectionReport o;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Checker", typeof(string));
            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Checked", typeof(Int16));
            dt.Columns.Add("Rejected", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                o = new OilInspectionReport();

                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);
                o.Date = Convert.ToDateTime(dr["Date"]);

                dataRow = ds.Tables[0].NewRow();

                dataRow[0] = personDAL.getPersonName(o.CheckerID);
                dataRow[1] = personDAL.getPersonName(o.WorkerID);
                dataRow[2] = item.getItemName(o.ItemID);
                dataRow[3] = style.getItemStyleName(o.StyleID);
                dataRow[4] = size.getItemSizeName(o.SizeID);
                dataRow[5] = o.CheckedQuantity;
                dataRow[6] = o.RejectQuantity;
                dataRow[7] = o.Remarks;
                dataRow[8] = o.Date;

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
        public DataSet getMonthlyReport(Int16 month,Int16 year)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (month(Date) = '" + month + "' and year(Date)='"+year+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            OilInspectionReport o;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Checker", typeof(string));
            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Checked", typeof(Int16));
            dt.Columns.Add("Rejected", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                o = new OilInspectionReport();

                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);
                o.Date = Convert.ToDateTime(dr["Date"]);
        
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(o.CheckerID);
                dataRow[1] = personDAL.getPersonName(o.WorkerID);
                dataRow[2] = item.getItemName(o.ItemID);
                dataRow[3] = style.getItemStyleName(o.StyleID);
                dataRow[4] = size.getItemSizeName(o.SizeID);
                dataRow[5] = o.CheckedQuantity;
                dataRow[6] = o.RejectQuantity;
                dataRow[7] = o.Remarks;
                dataRow[8] = o.Date;

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
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (year(Date)='" + d.Year+ "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            OilInspectionReport o;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Checker", typeof(string));
            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Checked", typeof(Int16));
            dt.Columns.Add("Rejected", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                o = new OilInspectionReport();

                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);
                o.Date = Convert.ToDateTime(dr["Date"]);

                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(o.CheckerID);
                dataRow[1] = personDAL.getPersonName(o.WorkerID);
                dataRow[2] = item.getItemName(o.ItemID);
                dataRow[3] = style.getItemStyleName(o.StyleID);
                dataRow[4] = size.getItemSizeName(o.SizeID);
                dataRow[5] = o.CheckedQuantity;
                dataRow[6] = o.RejectQuantity;
                dataRow[7] = o.Remarks;
                dataRow[8] = o.Date;

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
        public DataSet getMonthlyReportByCaster(Int16 month, Int16 year,int casterID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (month(Date) = '" + month + "' and year(Date)='" + year + "' and WorkerID='"+casterID+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            OilInspectionReport o;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Checker", typeof(string));
            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Checked", typeof(Int16));
            dt.Columns.Add("Rejected", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                o = new OilInspectionReport();

                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);
                o.Date = Convert.ToDateTime(dr["Date"]);

                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(o.CheckerID);
                dataRow[1] = personDAL.getPersonName(o.WorkerID);
                dataRow[2] = item.getItemName(o.ItemID);
                dataRow[3] = style.getItemStyleName(o.StyleID);
                dataRow[4] = size.getItemSizeName(o.SizeID);
                dataRow[5] = o.CheckedQuantity;
                dataRow[6] = o.RejectQuantity;
                dataRow[7] = o.Remarks;
                dataRow[8] = o.Date;

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
        public DataSet getYearlyReportByCaster(DateTime d, int casterID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (year(Date)='" + d.Year+ "' and WorkerID='" + casterID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            OilInspectionReport o;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Checker", typeof(string));
            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Checked", typeof(Int16));
            dt.Columns.Add("Rejected", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                o = new OilInspectionReport();

                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);
                o.Date = Convert.ToDateTime(dr["Date"]);

                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(o.CheckerID);
                dataRow[1] = personDAL.getPersonName(o.WorkerID);
                dataRow[2] = item.getItemName(o.ItemID);
                dataRow[3] = style.getItemStyleName(o.StyleID);
                dataRow[4] = size.getItemSizeName(o.SizeID);
                dataRow[5] = o.CheckedQuantity;
                dataRow[6] = o.RejectQuantity;
                dataRow[7] = o.Remarks;
                dataRow[8] = o.Date;

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
        public DataSet getMonthlyReportByCaster_Checker(Int16 month, Int16 year, int casterID,int checkerID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (month(Date) = '" + month + "' and year(Date)='" + year + "' and WorkerID='" + casterID + "' and CheckerID='"+checkerID+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            OilInspectionReport o;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Checker", typeof(string));
            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Checked", typeof(Int16));
            dt.Columns.Add("Rejected", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                o = new OilInspectionReport();

                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);
                o.Date = Convert.ToDateTime(dr["Date"]);

                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(o.CheckerID);
                dataRow[1] = personDAL.getPersonName(o.WorkerID);
                dataRow[2] = item.getItemName(o.ItemID);
                dataRow[3] = style.getItemStyleName(o.StyleID);
                dataRow[4] = size.getItemSizeName(o.SizeID);
                dataRow[5] = o.CheckedQuantity;
                dataRow[6] = o.RejectQuantity;
                dataRow[7] = o.Remarks;
                dataRow[8] = o.Date;

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
        public DataSet getYearlyReportByCaster_Checker(DateTime d, int casterID, int checkerID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (year(Date)='" + d.Year+ "' and WorkerID='" + casterID + "' and CheckerID='" + checkerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            OilInspectionReport o;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Checker", typeof(string));
            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Checked", typeof(Int16));
            dt.Columns.Add("Rejected", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                o = new OilInspectionReport();

                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);
                o.Date = Convert.ToDateTime(dr["Date"]);

                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(o.CheckerID);
                dataRow[1] = personDAL.getPersonName(o.WorkerID);
                dataRow[2] = item.getItemName(o.ItemID);
                dataRow[3] = style.getItemStyleName(o.StyleID);
                dataRow[4] = size.getItemSizeName(o.SizeID);
                dataRow[5] = o.CheckedQuantity;
                dataRow[6] = o.RejectQuantity;
                dataRow[7] = o.Remarks;
                dataRow[8] = o.Date;

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
        public DataSet getMonthlyReportByChecker(Int16 month, Int16 year, int checkerID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (month(Date) = '" + month + "' and year(Date)='" + year + "' and CheckerID='" + checkerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            OilInspectionReport o;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Checker", typeof(string));
            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Checked", typeof(Int16));
            dt.Columns.Add("Rejected", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                o = new OilInspectionReport();

                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);
                o.Date = Convert.ToDateTime(dr["Date"]);

                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(o.CheckerID);
                dataRow[1] = personDAL.getPersonName(o.WorkerID);
                dataRow[2] = item.getItemName(o.ItemID);
                dataRow[3] = style.getItemStyleName(o.StyleID);
                dataRow[4] = size.getItemSizeName(o.SizeID);
                dataRow[5] = o.CheckedQuantity;
                dataRow[6] = o.RejectQuantity;
                dataRow[7] = o.Remarks;
                dataRow[8] = o.Date;

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
        public DataSet getYearlyReportByChecker(DateTime d, int checkerID)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (year(Date)='" + d.Year+ "' and CheckerID='" + checkerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            OilInspectionReport o;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Checker", typeof(string));
            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Checked", typeof(Int16));
            dt.Columns.Add("Rejected", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                o = new OilInspectionReport();

                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);
                o.Date = Convert.ToDateTime(dr["Date"]);

                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(o.CheckerID);
                dataRow[1] = personDAL.getPersonName(o.WorkerID);
                dataRow[2] = item.getItemName(o.ItemID);
                dataRow[3] = style.getItemStyleName(o.StyleID);
                dataRow[4] = size.getItemSizeName(o.SizeID);
                dataRow[5] = o.CheckedQuantity;
                dataRow[6] = o.RejectQuantity;
                dataRow[7] = o.Remarks;
                dataRow[8] = o.Date;

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
        public List<OilInspectionReport> getReportByDayAndCaster(DateTime date,int casterID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (day(Date) = '" + date.Day + "' and month(Date)='" + date.Month + "' and year(Date)='" + date.Year + "' and WorkerID='" + casterID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<OilInspectionReport> list = new List<OilInspectionReport>();
            while (dr.Read())
            {
                OilInspectionReport o = new OilInspectionReport();
                o.Date = Convert.ToDateTime(dr["Date"]);
                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);

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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OilInspectionReport> getReportByDayCasterAndChecker(DateTime date, int casterID,int checkerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (day(Date) = '" + date.Day + "' and month(Date)='" + date.Month + "' and year(Date)='" + date.Year + "' and WorkerID='" + casterID + "' and CheckerID='" + checkerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<OilInspectionReport> list = new List<OilInspectionReport>();
            while (dr.Read())
            {
                OilInspectionReport o = new OilInspectionReport();
                o.Date = Convert.ToDateTime(dr["Date"]);
                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);

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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OilInspectionReport> getReportByDayAndChecker(DateTime date, Int32 checkerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (day(Date) = '" + date.Day + "' and month(Date)='" + date.Month + "' and year(Date)='" + date.Year + "' and CheckerID='" + checkerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<OilInspectionReport> list = new List<OilInspectionReport>();
            while (dr.Read())
            {
                OilInspectionReport o = new OilInspectionReport();
                o.Date = Convert.ToDateTime(dr["Date"]);
                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);

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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OilInspectionReport> getReportByMonth(DateTime d)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (month(Date) = '" +d.Month+ "'and year(Date)='" + d.Year+ "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<OilInspectionReport> list = new List<OilInspectionReport>();
            while (dr.Read())
            {
                OilInspectionReport o = new OilInspectionReport();
                o.Date = Convert.ToDateTime(dr["Date"]);
                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);

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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OilInspectionReport> getReportByYear(DateTime d)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (year(Date)='" + d.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<OilInspectionReport> list = new List<OilInspectionReport>();
            while (dr.Read())
            {
                OilInspectionReport o = new OilInspectionReport();
                o.Date = Convert.ToDateTime(dr["Date"]);
                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);

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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OilInspectionReport> getReportByMonthAndCaster(DateTime d,int casterID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (month(Date) = '" + d.Month+ "'and year(Date)='" + d.Year+ "' and WorkerID='"+casterID+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<OilInspectionReport> list = new List<OilInspectionReport>();
            while (dr.Read())
            {
                OilInspectionReport o = new OilInspectionReport();
                o.Date = Convert.ToDateTime(dr["Date"]);
                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);

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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OilInspectionReport> getReportByYearAndCaster(DateTime d, int casterID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (year(Date)='" + d.Year + "' and WorkerID='" + casterID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<OilInspectionReport> list = new List<OilInspectionReport>();
            while (dr.Read())
            {
                OilInspectionReport o = new OilInspectionReport();
                o.Date = Convert.ToDateTime(dr["Date"]);
                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);

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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OilInspectionReport> getReportByMonthAndChecker(DateTime d, int checkerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (month(Date) = '" + d.Month+ "'and year(Date)='" + d.Year+ "' and CheckerID='" + checkerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<OilInspectionReport> list = new List<OilInspectionReport>();
            while (dr.Read())
            {
                OilInspectionReport o = new OilInspectionReport();
                o.Date = Convert.ToDateTime(dr["Date"]);
                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);

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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OilInspectionReport> getReportByYearAndChecker(DateTime d, int checkerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (year(Date)='" + d.Year + "' and CheckerID='" + checkerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<OilInspectionReport> list = new List<OilInspectionReport>();
            while (dr.Read())
            {
                OilInspectionReport o = new OilInspectionReport();
                o.Date = Convert.ToDateTime(dr["Date"]);
                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);

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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OilInspectionReport> getReportByMonthCheckerAndCaster(DateTime d, int casterID,int checkerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (month(Date) = '" + d.Month+ "'and year(Date)='" + d.Year+ "' and WorkerID='" + casterID + "' and CheckerID='"+checkerID+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<OilInspectionReport> list = new List<OilInspectionReport>();
            while (dr.Read())
            {
                OilInspectionReport o = new OilInspectionReport();
                o.Date = Convert.ToDateTime(dr["Date"]);
                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);

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
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public List<OilInspectionReport> getReportByYearCheckerAndCaster(DateTime d, int casterID, int checkerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from OilInspectionReport where (year(Date)='" + d.Year + "' and WorkerID='" + casterID + "' and CheckerID='" + checkerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<OilInspectionReport> list = new List<OilInspectionReport>();
            while (dr.Read())
            {
                OilInspectionReport o = new OilInspectionReport();
                o.Date = Convert.ToDateTime(dr["Date"]);
                o.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                o.CheckerID = Convert.ToInt32(dr["CheckerID"]);
                o.ItemID = Convert.ToInt16(dr["ItemID"]);
                o.StyleID = Convert.ToInt16(dr["StyleID"]);
                o.SizeID = Convert.ToInt16(dr["SizeID"]);
                o.CheckedQuantity = Convert.ToInt16(dr["CheckedQuantity"]);
                o.RejectQuantity = Convert.ToInt16(dr["RejectQuantity"]);
                o.Remarks = Convert.ToString(dr["Remarks"]);

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
        //-------------------------------------------------------------------------------------------------------
    }
}
