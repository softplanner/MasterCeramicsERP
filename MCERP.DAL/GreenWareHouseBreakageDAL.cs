using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class GreenWareHouseBreakageDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public DataSet getDailyReport(DateTime date)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseBreakage where (day(Date)='" + date.Day + "' and month(Date)='" + date.Month + "' and year(Date)='" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            GreenWareHouseBreakage m;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("BreakageType", typeof(string));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));

            ds.Tables.Add(dt);
            while (dr.Read())
            {
                m = new GreenWareHouseBreakage();

                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);
                m.BreakageType = Convert.ToString(dr["BreakageType"]);
                m.Remarks = Convert.ToString(dr["Remarks"]);
                m.Date = Convert.ToDateTime(dr["Date"]);

                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(m.WorkerID);
                dataRow[1] = item.getItemName(m.ItemID);
                dataRow[2] = style.getItemStyleName(m.StyleID);
                dataRow[3] = size.getItemSizeName(m.SizeID);
                dataRow[4] = m.BreakageType;
                dataRow[5] = m.Remarks;
                dataRow[6] = m.Quantity;
                dataRow[7] = m.Date;

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
        public DataSet getMonthlyReportDataset(DateTime d)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseBreakage where (month(Date) = '" + d.Month+ "' and year(Date)='" + d.Year+ "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            GreenWareHouseBreakage m;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;

            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("BreakageType", typeof(string));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));

            ds.Tables.Add(dt);
            while (dr.Read())
            {
                m = new GreenWareHouseBreakage();

                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);
                m.Remarks = Convert.ToString(dr["Remarks"]);
                m.BreakageType = Convert.ToString(dr["BreakageType"]);
                m.Date = Convert.ToDateTime(dr["Date"]);

                dataRow = ds.Tables[0].NewRow();

                dataRow[0] = personDAL.getPersonName(m.WorkerID);
                dataRow[1] = item.getItemName(m.ItemID);
                dataRow[2] = style.getItemStyleName(m.StyleID);
                dataRow[3] = size.getItemSizeName(m.SizeID);
                dataRow[4] = m.BreakageType;
                dataRow[5] = m.Remarks;
                dataRow[6] = m.Quantity;
                dataRow[7] = m.Date;

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
        public DataSet getYearlyReportDataset(DateTime d)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseBreakage where (year(Date)='" + d.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            GreenWareHouseBreakage m;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;

            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("BreakageType", typeof(string));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));

            ds.Tables.Add(dt);
            while (dr.Read())
            {
                m = new GreenWareHouseBreakage();

                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);
                m.Remarks = Convert.ToString(dr["Remarks"]);
                m.BreakageType = Convert.ToString(dr["BreakageType"]);
                m.Date = Convert.ToDateTime(dr["Date"]);

                dataRow = ds.Tables[0].NewRow();

                dataRow[0] = personDAL.getPersonName(m.WorkerID);
                dataRow[1] = item.getItemName(m.ItemID);
                dataRow[2] = style.getItemStyleName(m.StyleID);
                dataRow[3] = size.getItemSizeName(m.SizeID);
                dataRow[4] = m.BreakageType;
                dataRow[5] = m.Remarks;
                dataRow[6] = m.Quantity;
                dataRow[7] = m.Date;

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
        public void addReport(GreenWareHouseBreakage obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into GreenWareHouseBreakage(WorkerID,Date,ItemID,StyleID,SizeID,Quantity,BreakageType,Remarks)values('" + obj.WorkerID+ "','" + obj.Date+ "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.Quantity + "','" + obj.BreakageType+ "','" + obj.Remarks + "')", objSqlConnection);
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
        public void updateReport(GreenWareHouseBreakage obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE  GreenWareHouseBreakage SET Quantity='" + obj.Quantity + "' WHERE (WorkerID='" + obj.WorkerID + "'and Date='" + obj.Date + "'and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "' and BreakageType='" + obj.BreakageType + "')", objSqlConnection);
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
        public void deleteReport(GreenWareHouseBreakage obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from GreenWareHouseBreakage WHERE (WorkerID='" + obj.WorkerID + "'and Date='" + obj.Date + "'and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and Quantity='" + obj.Quantity + "' and BreakageType='"+obj.BreakageType+"')", objSqlConnection);
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
        public List<GreenWareHouseBreakage> getReportByDate(DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseBreakage where (year(Date) = '" + date.Year + "' and month(Date)='"+date.Month+"' and day(Date)='"+date.Day+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GreenWareHouseBreakage> list = new List<GreenWareHouseBreakage>();
            GreenWareHouseBreakage g;
            while (dr.Read())
            {
                g = new GreenWareHouseBreakage();
                g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);
                g.BreakageType = Convert.ToString(dr["BreakageType"]);
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
        public List<GreenWareHouseBreakage> getMonthlyReport(DateTime d)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseBreakage where (month(Date) = '" + d.Month+ "' and year(Date)='"+d.Year+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GreenWareHouseBreakage> list = new List<GreenWareHouseBreakage>();
            while (dr.Read())
            {
                GreenWareHouseBreakage g = new GreenWareHouseBreakage();
                g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);
                g.BreakageType = Convert.ToString(dr["BreakageType"]);
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
        public List<GreenWareHouseBreakage> getYearlyReport(DateTime d)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseBreakage where (year(Date)='" + d.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GreenWareHouseBreakage> list = new List<GreenWareHouseBreakage>();
            while (dr.Read())
            {
                GreenWareHouseBreakage g = new GreenWareHouseBreakage();
                g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);
                g.BreakageType = Convert.ToString(dr["BreakageType"]);
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
        public List<GreenWareHouseBreakage> getReportByDateAndWorker(DateTime date, int workerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseBreakage where (year(Date)='" + date.Year + "' and month(Date)='" + date.Month + "' and day(Date)='" + date.Day + "' and WorkerID='" + workerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GreenWareHouseBreakage> list = new List<GreenWareHouseBreakage>();
            while (dr.Read())
            {
                GreenWareHouseBreakage g = new GreenWareHouseBreakage();
                g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);
                g.BreakageType = Convert.ToString(dr["BreakageType"]);
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
        public List<GreenWareHouseBreakage> getGlazingReportByDateAndItem(DateTime date, Int16 itemID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseBreakage where (Date = '" + date + "'and ItemID='" + itemID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GreenWareHouseBreakage> list = new List<GreenWareHouseBreakage>();
            while (dr.Read())
            {
                GreenWareHouseBreakage g = new GreenWareHouseBreakage();
                g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);
                g.BreakageType = Convert.ToString(dr["BreakageType"]);
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
        public List<GreenWareHouseBreakage> getGlazingReportByDateAndStyle(DateTime date, Int16 styleID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from GreenWareHouseBreakage where (Date = '" + date + "'and StyleID='" + styleID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<GreenWareHouseBreakage> list = new List<GreenWareHouseBreakage>();
            while (dr.Read())
            {
                GreenWareHouseBreakage g = new GreenWareHouseBreakage();
                g.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                g.Date = Convert.ToDateTime(dr["Date"]);
                g.ItemID = Convert.ToInt16(dr["ItemID"]);
                g.StyleID = Convert.ToInt16(dr["StyleID"]);
                g.SizeID = Convert.ToInt16(dr["SizeID"]);
                g.Quantity = Convert.ToInt16(dr["Quantity"]);
                g.BreakageType = Convert.ToString(dr["BreakageType"]);
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
    }
}
