using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class MoldBreakageDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addCompanyReport(MoldBreakage obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into MoldBreakage(Date,ItemID,StyleID,SizeID,Quantity,Remarks,WorkerID)values('" + obj.Date + "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.Quantity + "','" + obj.Remarks + "','"+obj.WorkerID+"')", objSqlConnection);
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
        public void addWorkerReport(MoldBreakage obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into MoldBreakage(Date,ItemID,StyleID,SizeID,Quantity,Remarks,WorkerID)values('" + obj.Date + "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.Quantity + "','" + obj.Remarks + "','" + obj.WorkerID + "')", objSqlConnection);
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
        public void updateReportCaster(MoldBreakage obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE  MoldBreakage SET Quantity='" + obj.Quantity + "' WHERE (Date='" + obj.Date + "'and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "' and Remarks='" + obj.Remarks + "' and WorkerID='" + obj.WorkerID+ "')", objSqlConnection);
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
        public void updateReportCompany(MoldBreakage obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("UPDATE  MoldBreakage SET Quantity='" + obj.Quantity + "' WHERE (day(Date)='" + obj.Date.Day + "' and month(Date)='" + obj.Date.Month + "' and year(Date)='" + obj.Date.Year + "' and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "' and Remarks='" + obj.Remarks + "' and WorkerID='" + obj.WorkerID + "')", objSqlConnection);
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
        public void deleteReportCompanyStock(MoldBreakage obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from MoldBreakage WHERE (WorkerID='" + obj.WorkerID + "' and  day(Date)='" + obj.Date.Day + "' and month(Date)='" + obj.Date.Month + "' and year(Date)='" + obj.Date.Year + "' and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and Quantity='" + obj.Quantity + "'and Remarks='" + obj.Remarks + "')", objSqlConnection);
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
        public void deleteReportCasterStock(MoldBreakage obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from MoldBreakage WHERE (Date='" + obj.Date + "'and ItemID='" + obj.ItemID + "'and StyleID='" + obj.StyleID + "'and SizeID='" + obj.SizeID + "'and Quantity='" + obj.Quantity + "'and Remarks='" + obj.Remarks + "'and WorkerID='" + obj.WorkerID + "')", objSqlConnection);
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
        public bool checkIsReportExist(MoldBreakage obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from MoldBreakage where (Date = '" + obj.Date + "' and ItemID='"+obj.ItemID+"' and StyleID='"+obj.StyleID+"' and SizeID='"+obj.SizeID+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            bool list = false;
            while (dr.Read())
            {
                list= true;
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
        public Int16 getCurentReportQuantity(MoldBreakage obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from MoldBreakage where (Date = '" + obj.Date + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "')", objSqlConnection);

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
        public List<MoldBreakage> getReportByDay(DateTime date)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldBreakage where (day(Date) = '" + date.Day + "' and month(Date) = '" + date.Month + "' and year(Date) = '" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldBreakage> list = new List<MoldBreakage>();
            while (dr.Read())
            {
                MoldBreakage m = new MoldBreakage();
                m.Date = Convert.ToDateTime(dr["Date"]);
                m.WorkerID= Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);
                m.Remarks = Convert.ToString(dr["Remarks"]);

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
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldBreakage where (day(Date) = '" + date.Day + "' and month(Date) = '" + date.Month + "' and year(Date) = '" + date.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = Convert.ToInt16(dr["Quantity"]);
                dataRow[5] = Convert.ToString(dr["Remarks"]);
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
        public DataSet getMonthlyReport(DateTime d)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldBreakage where (month(Date) = '" + d.Month + "' and year(Date)='"+d.Year+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = Convert.ToInt16(dr["Quantity"]);
                dataRow[5] = Convert.ToString(dr["Remarks"]);
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
        public DataSet getYearlyReport(DateTime d)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldBreakage where (year(Date)='" + d.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dataRow;
            dt.Columns.Add("Caster", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Style", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int16));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = Convert.ToInt16(dr["Quantity"]);
                dataRow[5] = Convert.ToString(dr["Remarks"]);
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
        public List<MoldBreakage> getReportByDayAndWorker(DateTime date,int workerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldBreakage where (day(Date) = '" + date.Day + "' and month(Date) = '" + date.Month + "' and year(Date) = '" + date.Year + "' and WorkerID='" + workerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldBreakage> list = new List<MoldBreakage>();
            while (dr.Read())
            {
                MoldBreakage m = new MoldBreakage();
                m.Date = Convert.ToDateTime(dr["Date"]);
                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);
                m.Remarks = Convert.ToString(dr["Remarks"]);

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
        public List<MoldBreakage> getReportByMonth(DateTime d)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldBreakage where (month(Date) = '" + d.Month + "' and year(Date)='"+d.Year+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldBreakage> list = new List<MoldBreakage>();
            while (dr.Read())
            {
                MoldBreakage m = new MoldBreakage();
                m.Date = Convert.ToDateTime(dr["Date"]);
                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);
                m.Remarks = Convert.ToString(dr["Remarks"]);

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
        public List<MoldBreakage> getReportByYear(DateTime d)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldBreakage where (year(Date)='" + d.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldBreakage> list = new List<MoldBreakage>();
            while (dr.Read())
            {
                MoldBreakage m = new MoldBreakage();
                m.Date = Convert.ToDateTime(dr["Date"]);
                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);
                m.Remarks = Convert.ToString(dr["Remarks"]);

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
        public List<MoldBreakage> getReportByMonthAndWorker(Int16 month, Int16 year,int workerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldBreakage where (month(Date) = '" + month + "' and year(Date)='" + year + "' and WorkerID='"+workerID+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldBreakage> list = new List<MoldBreakage>();
            while (dr.Read())
            {
                MoldBreakage m = new MoldBreakage();
                m.Date = Convert.ToDateTime(dr["Date"]);
                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);
                m.Remarks = Convert.ToString(dr["Remarks"]);

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
        public List<MoldBreakage> getReportByDateAndWorker(DateTime date, Int32 workerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldBreakage where day(Date) = '" + date.Day + "' and month(Date) = '" + date.Month + "' and year(Date) = '" + date.Year + "' and WorkerID='" + workerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldBreakage> list = new List<MoldBreakage>();
            while (dr.Read())
            {
                MoldBreakage m = new MoldBreakage();
                m.Date = Convert.ToDateTime(dr["Date"]);
                m.WorkerID = Convert.ToInt32(dr["WorkerID"]);
                m.ItemID = Convert.ToInt16(dr["ItemID"]);
                m.StyleID = Convert.ToInt16(dr["StyleID"]);
                m.SizeID = Convert.ToInt16(dr["SizeID"]);
                m.Quantity = Convert.ToInt16(dr["Quantity"]);
                m.Remarks = Convert.ToString(dr["Remarks"]);

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
    }
}
