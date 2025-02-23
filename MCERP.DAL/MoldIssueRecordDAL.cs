using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MCERP.Entities;

namespace MCERP.DAL
{
    public class MoldIssueRecordDAL
    {
        //-------------------------------------------------------------------------------------------------------
        public void addReport(MoldIssueRecord obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("insert into MoldIssueRecord(IssueDate,ItemID,StyleID,SizeID,Quantity,WorkerID)values('" + obj.IssueDate+ "','" + obj.ItemID + "','" + obj.StyleID + "','" + obj.SizeID + "','" + obj.Quantity + "','" + obj.WorkerID + "')", objSqlConnection);
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
        public void updateReport(MoldIssueRecord obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("update MoldIssueRecord set Quantity='" + obj.Quantity + "' where (day(IssueDate) = '" + obj.IssueDate.Day + "' and month(IssueDate) = '" + obj.IssueDate.Month + "' and year(IssueDate) = '" + obj.IssueDate.Year + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' and WorkerID='" + obj.WorkerID + "')", objSqlConnection);
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
        public void deleteReport(MoldIssueRecord obj)
        {

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("Delete from MoldIssueRecord WHERE (day(IssueDate) = '" + obj.IssueDate.Day + "' and month(IssueDate) = '" + obj.IssueDate.Month + "' and year(IssueDate) = '" + obj.IssueDate.Year + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' and Quantity='" + obj.Quantity + "' and WorkerID='" + obj.WorkerID + "')", objSqlConnection);
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
        public bool checkIsReportExist(MoldIssueRecord obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from MoldIssueRecord where(WorkerID='" + obj.WorkerID + "' and day(IssueDate) = '" + obj.IssueDate.Day + "' and month(IssueDate) = '" + obj.IssueDate.Month + "' and year(IssueDate) = '" + obj.IssueDate.Year + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            bool list=false;
            while (dr.Read())
            {
                list=true;
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
        public Int16 getCurrentReportQuantity(MoldIssueRecord obj)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select Quantity from MoldIssueRecord where (day(IssueDate) = '" + obj.IssueDate.Day + "' and month(IssueDate) = '" + obj.IssueDate.Month + "' and year(IssueDate) = '" + obj.IssueDate.Year + "' and ItemID='" + obj.ItemID + "' and StyleID='" + obj.StyleID + "' and SizeID='" + obj.SizeID + "' and WorkerID='" + obj.WorkerID + "')", objSqlConnection);

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
        public List<MoldIssueRecord> getReportByIssueDay(DateTime issueDate)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldIssueRecord where (day(IssueDate) = '" + issueDate.Day + "' and month(IssueDate) = '" + issueDate.Month + "' and year(IssueDate) = '" + issueDate.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldIssueRecord> list = new List<MoldIssueRecord>();
            while (dr.Read())
            {
                MoldIssueRecord m = new MoldIssueRecord();
                m.IssueDate = Convert.ToDateTime(dr["IssueDate"]);
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
        public DataSet getDailyReport(DateTime issueDate)
        {
            ItemDAL item = new ItemDAL();
            DALItemStyle style = new DALItemStyle();
            ItemSizeDAL size = new ItemSizeDAL();
            PersonDAL personDAL = new PersonDAL();

            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldIssueRecord where (day(IssueDate) = '" + issueDate.Day + "' and month(IssueDate) = '" + issueDate.Month + "' and year(IssueDate) = '" + issueDate.Year + "')", objSqlConnection);

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
            dt.Columns.Add("Issue Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();
                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = Convert.ToInt16(dr["Quantity"]);
                dataRow[5] = Convert.ToDateTime(dr["IssueDate"]);
               
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
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldIssueRecord where (month(IssueDate) = '" + d.Month + "' and year(IssueDate)='"+d.Year+"')", objSqlConnection);

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
            dt.Columns.Add("Issue Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();

                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = Convert.ToInt16(dr["Quantity"]);
                dataRow[5] = Convert.ToDateTime(dr["IssueDate"]);

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
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldIssueRecord where (year(IssueDate)='" + d.Year + "')", objSqlConnection);

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
            dt.Columns.Add("Issue Date", typeof(DateTime));
            ds.Tables.Add(dt);
            while (dr.Read())
            {
                dataRow = ds.Tables[0].NewRow();

                dataRow[0] = personDAL.getPersonName(Convert.ToInt32(dr["WorkerID"]));
                dataRow[1] = item.getItemName(Convert.ToInt16(dr["ItemID"]));
                dataRow[2] = style.getItemStyleName(Convert.ToInt16(dr["StyleID"]));
                dataRow[3] = size.getItemSizeName(Convert.ToInt16(dr["SizeID"]));
                dataRow[4] = Convert.ToInt16(dr["Quantity"]);
                dataRow[5] = Convert.ToDateTime(dr["IssueDate"]);

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
        //-------------------------------------------------------------------------------------------------------//-------------------------------------------------------------------------------------------------------
        public Int16 getStockByCaster(Int16 item,Int16 style,Int16 size,int casterID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldIssueRecord where (ItemID = '" + item + "'and StyleID='" + style + "' and SizeID='" + size + "' and WorkerID='"+casterID+"')", objSqlConnection);

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
        //-------------------------------------------------------------------------------------------------------
        public Int16 checkIsWorkerContainMold(Int16 item, Int16 style, Int16 size)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldIssueRecord where (ItemID = '" + item + "'and StyleID='" + style + "' and SizeID='" + size + "')", objSqlConnection);

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
        //-------------------------------------------------------------------------------------------------------
        public List<MoldIssueRecord> getReportByMonth(DateTime d)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldIssueRecord where (month(IssueDate) = '" + d.Month+ "' and year(IssueDate)='"+d.Year+"')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldIssueRecord> list = new List<MoldIssueRecord>();
            while (dr.Read())
            {
                MoldIssueRecord m = new MoldIssueRecord();
                m.IssueDate = Convert.ToDateTime(dr["IssueDate"]);
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
        public List<MoldIssueRecord> getReportByYear(DateTime d)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldIssueRecord where (year(IssueDate)='" + d.Year + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldIssueRecord> list = new List<MoldIssueRecord>();
            while (dr.Read())
            {
                MoldIssueRecord m = new MoldIssueRecord();
                m.IssueDate = Convert.ToDateTime(dr["IssueDate"]);
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
        public List<MoldIssueRecord> getReportByWorker(int casterID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldIssueRecord where (WorkerID='" + casterID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldIssueRecord> list = new List<MoldIssueRecord>();
            while (dr.Read())
            {
                MoldIssueRecord m = new MoldIssueRecord();
                m.IssueDate = Convert.ToDateTime(dr["IssueDate"]);
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
        public List<MoldIssueRecord> getReportByIssueDateAndWorker(DateTime date, Int32 workerID)
        {
            ConnectionDB objConnectionDB = new ConnectionDB();
            SqlConnection objSqlConnection = objConnectionDB.getConnectionString();
            SqlCommand objSqlCommand = new SqlCommand("select * from MoldIssueRecord where (day(IssueDate) = '" + date.Day + "' and month(IssueDate) = '" + date.Month + "' and year(IssueDate) = '" + date.Year+ "' and WorkerID='" + workerID + "')", objSqlConnection);

            SqlDataReader dr = null;
            objSqlConnection.Open();
            dr = objSqlCommand.ExecuteReader();
            List<MoldIssueRecord> list = new List<MoldIssueRecord>();
            while (dr.Read())
            {
                MoldIssueRecord m = new MoldIssueRecord();
                m.IssueDate = Convert.ToDateTime(dr["IssueDate"]);
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
    }
}
