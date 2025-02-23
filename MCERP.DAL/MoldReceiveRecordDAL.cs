using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class MoldReceiveRecordDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public bool checkIsReportExist(MoldReceiveRecord obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from MoldReceiveRecord where (Date = '" + obj.Date + "'and WorkerID='" + obj.WorkerID + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' )", objSqlConnection);

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
        public Int16 getCurrentReportQuantity(MoldReceiveRecord obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from MoldReceiveRecord where (Date = '" + obj.Date + "'and WorkerID='" + obj.WorkerID + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' )", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            Int16 list = 0;
            while (dr.Read())
            {
                list = Convert.ToInt16(dr["Quantity"]);
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
        public void addReport(MoldReceiveRecord obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into MoldReceiveRecord(Date,ItemID,StyleID,SizeID,Quantity,WorkerID)values('" + obj.Date+ "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.Quantity + "','" + obj.WorkerID + "')", objSqlConnection);
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
        public void updateReport(MoldReceiveRecord obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE  MoldReceiveRecord SET Quantity='"+obj.Quantity+"' WHERE (Date='" + obj.Date + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' and WorkerID='" + obj.WorkerID + "')", objSqlConnection);
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
        public void deleteReport(MoldReceiveRecord obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from MoldReceiveRecord WHERE (Date='" + obj.Date + "'and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and Quantity='" + obj.Quantity + "'and WorkerID='" + obj.WorkerID + "')", objSqlConnection);
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
        public List<MoldReceiveRecord> getReportByDay(DateTime Date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldReceiveRecord where (day(Date) = '" + Date.Day + "' and month(Date) = '" + Date.Month + "' and year(Date) = '" + Date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldReceiveRecord> list = new List<MoldReceiveRecord>();
            while (dr.Read())
            {
                MoldReceiveRecord m = new MoldReceiveRecord();
                m.Date = Convert.ToDateTime(dr["Date"]);
                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);
     
                list.Add(m);
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
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldReceiveRecord where (day(Date) = '" + date.Day + "' and month(Date) = '" + date.Month + "' and year(Date) = '" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            MoldReceiveRecord m;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Received By", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                m = new MoldReceiveRecord();
                m.Date = Convert.ToDateTime(dr["Date"]);
                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);

                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(m.WorkerID);
                dataRow[1] = item.getItemName(m.ItemID);
                dataRow[2] = style.getItemStyleName(m.StyleID);
                dataRow[3] = size.getItemSizeName(m.SizeID);
                dataRow[4] = m.Quantity;
                dataRow[5] = m.Date;

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
        public DataSet getMonthlyReport(DateTime d)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldReceiveRecord where (month(Date) = '" + d.Month+ "' and year(Date)='"+d.Year+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            MoldReceiveRecord m;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Received By", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                m = new MoldReceiveRecord();
                m.Date = Convert.ToDateTime(dr["Date"]);
                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);

                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(m.WorkerID);
                dataRow[1] = item.getItemName(m.ItemID);
                dataRow[2] = style.getItemStyleName(m.StyleID);
                dataRow[3] = size.getItemSizeName(m.SizeID);
                dataRow[4] = m.Quantity;
                dataRow[5] = m.Date;

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
        public DataSet getyearlyReport(DateTime d)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldReceiveRecord where (year(Date)='" + d.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            MoldReceiveRecord m;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Received By", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                m = new MoldReceiveRecord();
                m.Date = Convert.ToDateTime(dr["Date"]);
                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);

                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(m.WorkerID);
                dataRow[1] = item.getItemName(m.ItemID);
                dataRow[2] = style.getItemStyleName(m.StyleID);
                dataRow[3] = size.getItemSizeName(m.SizeID);
                dataRow[4] = m.Quantity;
                dataRow[5] = m.Date;

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
        public List<MoldReceiveRecord> getReportByMonth(DateTime d)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldReceiveRecord where (month(Date) = '" + d.Month+ "' and year(Date)='"+d.Year+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldReceiveRecord> list = new List<MoldReceiveRecord>();
            while (dr.Read())
            {
                MoldReceiveRecord m = new MoldReceiveRecord();
                m.Date = Convert.ToDateTime(dr["Date"]);
                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);

                list.Add(m);
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
        public List<MoldReceiveRecord> getReportByYear(DateTime d)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldReceiveRecord where (year(Date)='" + d.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldReceiveRecord> list = new List<MoldReceiveRecord>();
            while (dr.Read())
            {
                MoldReceiveRecord m = new MoldReceiveRecord();
                m.Date = Convert.ToDateTime(dr["Date"]);
                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);

                list.Add(m);
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
        public List<MoldReceiveRecord> getReportByDateAndWorker(DateTime date, Int32 workerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldReceiveRecord where (Date = '" + date + "'and WorkerID='" + workerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldReceiveRecord> list = new List<MoldReceiveRecord>();
            while (dr.Read())
            {
                MoldReceiveRecord m = new MoldReceiveRecord();
                m.Date = Convert.ToDateTime(dr["Date"]);
                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);
               
                list.Add(m);
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
        public Int16 checkIsMoldExist(Int16 item,Int16 style,Int16 size)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from MoldReceiveRecord where (ItemID = '" + item + "'and StyleID='" + style + "' and SizeID='"+size+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            Int16 check = 0;
            while (dr.Read())
            {
                check = 1;
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return check;
        }
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        public Int16 getStock(Int16 item, Int16 style, Int16 size)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from MoldReceiveRecord where (ItemID = '" + item + "'and StyleID='" + style + "' and SizeID='" + size + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            Int16 quantity = 0;
            while (dr.Read())
            {
                quantity = Convert.ToInt16(dr["Quantity"]);
            }
            objSqlConnection.Close();
            ///////////////////////////////////////---Reallocate the resources
            objSqlConnection.Dispose();
            objSqlCommand.Dispose();
            dr.Dispose();
            //////////////////////////////////////
            return quantity;
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
